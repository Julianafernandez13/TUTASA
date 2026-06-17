using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Almacenes;
using TUTASA.Enums;


namespace TUTASA.ImposicionCD
{
    internal class ImposicionCDModelo
    {
        private List<Guia> guias = new List<Guia>();
        private Cliente clienteSeleccionado = null;

        // CD activo de sesión (hardcodeado por ahora)
        private CentrosDeDistribucion cdActivo = new CentrosDeDistribucion
        {
            idCD = 1,
            nombreCD = "CD Buenos Aires",
            CodigosPostales = new List<string> { "1000", "1900", "1800", "1700" }
        };

        // Métodos para manejar el cliente seleccionado
        internal void SetClienteSeleccionado(Cliente cliente)
        {
            clienteSeleccionado = cliente;
        }

        internal Cliente GetClienteSeleccionado()
        {
            return clienteSeleccionado;
        }

        // Métodos para manejar los bultos
        internal void AgregarBulto(CategoriaBulto categoria)
        {
            guias.Add(new Guia
            {
                idGuia = guias.Count + 1,
                Categoria = categoria,
                Remitente = clienteSeleccionado
            });
        }

        internal void QuitarBulto(int indice)
        {
            guias.RemoveAt(indice);
            for (int i = 0; i < guias.Count; i++)
                guias[i].idGuia = i + 1;
        }

        internal List<Guia> GetBultos()
        {
            return guias;
        }

        internal Destinatario ConstruirDestinatario(string nombre, string dni, string telefono, TipoEntrega tipo,
            string domicilio = null, string codigoPostal = null,
            Agencias agencia = null, CentrosDeDistribucion cd = null)
        {
            return new Destinatario
            {
                NombreCompleto = nombre,
                DNI = dni,
                Telefono = telefono,
                TipoEntrega = tipo,
                DomicilioEntrega = domicilio,
                CodigoPostal = codigoPostal,
                AgenciaDestino = agencia,
                CDDestino = cd
            };
        }

        // Calcula la tarifa definitiva para una guia
        internal decimal CalcularTarifaDefinitiva(CategoriaBulto categoria, int idCDDestino, TipoEntrega tipoEntrega)
        {
            // 1) Buscar tarifa base vigente mas reciente
            TarifaCliente tarifaVigente = null;
            foreach (TarifaClienteEntidad t in TarifaClienteAlmacen.tarifaClientes)
            {
                if ((CategoriaBultoEnum)categoria == t.CategoriaBulto
                    && t.IdCDOrigen == cdActivo.idCD
                    && t.IdCDDestino == idCDDestino
                    && t.FechaVigencia <= DateTime.Now)
                {
                    if (tarifaVigente == null || t.FechaVigencia > tarifaVigente.FechaVigencia)
                    {
                        tarifaVigente = new TarifaCliente
                        {
                            IdTarifaCliente = t.IdTarifaCliente,
                            IdCDOrigen = t.IdCDOrigen,
                            IdCDDestino = t.IdCDDestino,
                            CategoriaBulto = (CategoriaBulto)t.CategoriaBulto,
                            PrecioBase = t.PrecioBase,
                            FechaVigencia = t.FechaVigencia
                        };
                    }
                }
            }

            decimal tarifa = tarifaVigente != null ? tarifaVigente.PrecioBase : 0; 

            // 2) Buscar extras vigentes mas recientes
            Extras extrasVigentes = null;
            foreach (ExtrasEntidad e in ExtrasAlmacen.extrass)
            {
                if (e.FechaVigencia <= DateTime.Now)
                {
                    if (extrasVigentes == null || e.FechaVigencia > extrasVigentes.FechaVigencia)
                    {
                        extrasVigentes = new Extras
                        {
                            IdExtras = e.IdExtras,
                            ExtraRetiroDomicilio = e.ExtraRetiroDomicilio,
                            ExtraEntregaAgencia = e.ExtraEntregaAgencia,
                            ExtraEntregaDomicilio = e.ExtraEntregaDomicilio,
                            FechaVigencia = e.FechaVigencia
                        };
                    }
                }
            }

            // 3) Sumar extras segun tipo de entrega
            // En ImposicionCD no hay extra de retiro (el cliente trae el bulto)
            if (extrasVigentes != null)
            {
                if (tipoEntrega == TipoEntrega.Domicilio)
                    tarifa += extrasVigentes.ExtraEntregaDomicilio;
                else if (tipoEntrega == TipoEntrega.Agencia)
                    tarifa += extrasVigentes.ExtraEntregaAgencia;
            }

            return tarifa;
        }

        internal void AsignarDestinatarioAGuias(Destinatario destinatario)
        {
            DateTime ahora = DateTime.Now;

            foreach (var bulto in guias)
            {
                // Generar NroTracking: idCD + número correlativo
                int nuevoId = GuiaAlmacen.guias.Count + 1;
                string nroTracking = cdActivo.idCD + "-" + nuevoId.ToString("D8");

                bulto.NroTracking = nroTracking;
                bulto.Destinatario = destinatario;
               

                // Determinar extras segun tipo de entrega
                bool tieneExtraRetiro = false; // en ImposicionCD nunca hay retiro a domicilio
                bool tieneExtraEntregaDomicilio = destinatario.TipoEntrega == TipoEntrega.Domicilio;
                bool tieneExtraEntregaAgencia = destinatario.TipoEntrega == TipoEntrega.Agencia;

                // Determinar idAgenciaDestino e idCDDestino segun tipo de entrega
                int idAgenciaDestino = 0;
                int idCDDestino = 0;

                if (destinatario.TipoEntrega == TipoEntrega.Domicilio)
                {
                    idCDDestino = ObtenerIdCDPorCodPostal(destinatario.CodigoPostal);
                }
                else if (destinatario.TipoEntrega == TipoEntrega.Agencia && destinatario.AgenciaDestino != null)
                {
                    idAgenciaDestino = destinatario.AgenciaDestino.idAgencia;
                    idCDDestino = ObtenerIdCDPorAgencia(destinatario.AgenciaDestino.idAgencia);
                }
                else if (destinatario.TipoEntrega == TipoEntrega.CD && destinatario.CDDestino != null)
                {
                    idCDDestino = destinatario.CDDestino.idCD;
                }

                // Determinar estado final
                EstadoGuiaEnum nuevoEstado;
                if (idCDDestino == cdActivo.idCD)
                {
                    if (destinatario.TipoEntrega == TipoEntrega.CD)
                        nuevoEstado = EstadoGuiaEnum.DisponibleParaEntrega;
                    else
                        nuevoEstado = EstadoGuiaEnum.PendienteDeDistribucion;
                }
                else
                {
                    nuevoEstado = EstadoGuiaEnum.Admitida;
                }
                bulto.Estado = (EstadoGuia)nuevoEstado;

                // Buscar idCliente en el almacen por CUIT
                int idCliente = 0;
                foreach (ClienteEntidad clienteEntidad in ClienteAlmacen.clientes)
                {
                    if (clienteEntidad.CuitCliente.ToString() == clienteSeleccionado.CUIT)
                    {
                        idCliente = clienteEntidad.IdCliente;
                        break;
                    }
                }

                // Buscar tarifa definitiva
                decimal tarifaDefinitiva = CalcularTarifaDefinitiva(bulto.Categoria, idCDDestino, destinatario.TipoEntrega);
                

                // Buscar idExtras vigente
                int idExtras = 0;
                if (tieneExtraEntregaDomicilio || tieneExtraEntregaAgencia)
                {
                    Extras extrasVigentes = null;
                    foreach (ExtrasEntidad e in ExtrasAlmacen.extrass)
                    {
                        if (e.FechaVigencia <= ahora)
                        {
                            if (extrasVigentes == null || e.FechaVigencia > extrasVigentes.FechaVigencia)
                            {
                                extrasVigentes = new Extras { IdExtras = e.IdExtras, FechaVigencia = e.FechaVigencia };
                            }
                        }
                    }
                    if (extrasVigentes != null)
                        idExtras = extrasVigentes.IdExtras;
                }

                // Buscar idTarifaCliente vigente
                int idTarifaCliente = 0;
                TarifaCliente tarifaVigente = null;
                foreach (TarifaClienteEntidad t in TarifaClienteAlmacen.tarifaClientes)
                {
                    if ((CategoriaBultoEnum)bulto.Categoria == t.CategoriaBulto
                        && t.IdCDOrigen == cdActivo.idCD
                        && t.IdCDDestino == idCDDestino
                        && t.FechaVigencia <= ahora)
                    {
                        if (tarifaVigente == null || t.FechaVigencia > tarifaVigente.FechaVigencia)
                        {
                            tarifaVigente = new TarifaCliente { IdTarifaCliente = t.IdTarifaCliente, FechaVigencia = t.FechaVigencia };
                        }
                    }
                }
                if (tarifaVigente != null)
                    idTarifaCliente = tarifaVigente.IdTarifaCliente;

                // Buscar comision agencia vigente por categoria
                int idComisionAgencia = 0;
                ComisionAgencia comisionAgenciaVigente = null;
                foreach (ComisionAgenciaEntidad ca in ComisionAgenciaAlmacen.comisionAgencias)
                {
                    if (ca.CategoriaBulto == (CategoriaBultoEnum)bulto.Categoria && ca.FechaVigencia <= ahora)
                    {
                        if (comisionAgenciaVigente == null || ca.FechaVigencia > comisionAgenciaVigente.FechaVigencia)
                            comisionAgenciaVigente = new ComisionAgencia { IdComisionAgencia = ca.IdComisionAgencia, FechaVigencia = ca.FechaVigencia };
                    }
                }
                if (comisionAgenciaVigente != null)
                    idComisionAgencia = comisionAgenciaVigente.IdComisionAgencia;

                // Buscar comision fletero vigente por categoria
                int idComisionFletero = 0;
                ComisionFletero comisionFleteroVigente = null;
                foreach (ComisionFleteroEntidad cf in ComisionFleteroAlmacen.comisionFleteros)
                {
                    if (cf.CategoriaBulto == (CategoriaBultoEnum)bulto.Categoria && cf.FechaVigencia <= ahora)
                    {
                        if (comisionFleteroVigente == null || cf.FechaVigencia > comisionFleteroVigente.FechaVigencia)
                            comisionFleteroVigente = new ComisionFletero { IdComisionFletero = cf.IdComisionFletero, FechaVigencia = cf.FechaVigencia };
                    }
                }
                if (comisionFleteroVigente != null)
                    idComisionFletero = comisionFleteroVigente.IdComisionFletero;

                // Crear GuiaEntidad con estado Admitida e historial de 2 pasos
                GuiaEntidad nuevaGuia = new GuiaEntidad
                {
                    IdGuia = nuevoId,
                    NroTracking = nroTracking,
                    IdCliente = idCliente,
                    FechaImposicion = ahora,
                    TipoEntrega = (TipoEntregaEnum)destinatario.TipoEntrega,
                    IdAgenciaOrigen = 0,
                    IdCDOrigen = cdActivo.idCD,
                    CategoriaBulto = (CategoriaBultoEnum)bulto.Categoria,
                    RemDni = 0,
                    RemDomicilioRetiro = string.Empty,
                    RemCodPostal = string.Empty,
                    DniDestinatario = long.Parse(destinatario.DNI),
                    NombreApellidoDestinatario = destinatario.NombreCompleto,
                    TelefonoDestinatario = long.Parse(destinatario.Telefono),
                    DomicilioEntrega = destinatario.DomicilioEntrega ?? string.Empty,
                    DomicilioEntregaCodPostal = destinatario.CodigoPostal ?? string.Empty,
                    IdAgenciaDestino = idAgenciaDestino,
                    IdCDDestino = idCDDestino,
                    IdTarifaCliente = idTarifaCliente,
                    IdExtras = idExtras,
                    TarifaDefinitiva = tarifaDefinitiva,
                    IdComisionAgencia = idComisionAgencia,
                    IdComisionFletero = idComisionFletero,
                    TieneExtraRetiro = tieneExtraRetiro,
                    TieneExtraEntregaDomicilio = tieneExtraEntregaDomicilio,
                    TieneExtraEntregaAgencia = tieneExtraEntregaAgencia,
                    EstadoGuia = nuevoEstado,
                    Historial = new List<HistorialGuia>
                    {
                        new HistorialGuia { Estado = EstadoGuiaEnum.Impuesta, Fecha = ahora },
                        new HistorialGuia { Estado = nuevoEstado,             Fecha = ahora }
                    }
                };

                GuiaAlmacen.guias.Add(nuevaGuia);
            }

            GuiaAlmacen.Guardar();
        }

        internal List<Agencias> ObtenerAgencias()
        {
            var resultado = new List<Agencias>();
            foreach (AgenciaEntidad agenciaEntidad in AgenciaAlmacen.agencias)
            {
                resultado.Add(new Agencias
                {
                    idAgencia = agenciaEntidad.IdAgencia,
                    nombreAgencia = agenciaEntidad.NombreAgencia,
                    CodigoPostal = agenciaEntidad.IdCodPostal
                });
            }
            return resultado;
        }

        internal List<CentrosDeDistribucion> ObtenerCentrosDeDistribucion()
        {
            var resultado = new List<CentrosDeDistribucion>();
            foreach (CentroDistribucionEntidad cdEntidad in CentroDistribucionAlmacen.centroDistribucions)
            {
                resultado.Add(new CentrosDeDistribucion
                {
                    idCD = cdEntidad.IdCD,
                    nombreCD = cdEntidad.NombreCD,
                    CodigosPostales = cdEntidad.IdCodPostal
                });
            }
            return resultado;
        }

        internal List<CodigoPostal> ObtenerCodigosPostales()
        {
            var resultado = new List<CodigoPostal>();
            foreach (CodigoPostalEntidad cpEntidad in CodigoPostalAlmacen.codigoPostals)
            {
                resultado.Add(new CodigoPostal
                {
                    idCodPostal = cpEntidad.IdCodPostal,
                    DescripcionProvincia = cpEntidad.DescripcionProvincia,
                    DescripcionLocalidad = cpEntidad.DescripcionLocalidad
                });
            }
            return resultado;
        }

        internal List<Cliente> ObtenerClientes()
        {
            var resultado = new List<Cliente>();
            foreach (ClienteEntidad clienteEntidad in ClienteAlmacen.clientes)
            {
                resultado.Add(new Cliente
                {
                    Id = clienteEntidad.IdCliente,
                    NombreCompleto = clienteEntidad.NombreCliente + " " + clienteEntidad.ApellidoCliente,
                    CUIT = clienteEntidad.CuitCliente.ToString()
                });
            }
            return resultado;
        }

        private int ObtenerIdCDPorCodPostal(string codPostal)
        {
            foreach (CentroDistribucionEntidad cd in CentroDistribucionAlmacen.centroDistribucions)
            {
                foreach (string cp in cd.IdCodPostal)
                {
                    if (cp == codPostal)
                        return cd.IdCD;
                }
            }
            return 0;
        }

        private int ObtenerIdCDPorAgencia(int idAgencia)
        {
            foreach (AgenciaEntidad agencia in AgenciaAlmacen.agencias)
            {
                if (agencia.IdAgencia == idAgencia)
                    return agencia.IdCD;
            }
            return 0;
        }
    }
}
