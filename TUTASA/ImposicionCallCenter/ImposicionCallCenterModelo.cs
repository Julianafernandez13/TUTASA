using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Almacenes;
using TUTASA.Enums;

namespace TUTASA.ImposicionCallCenter
{
    internal class ImposicionCallCenterModelo
    {
        private List<Guia> guias = new List<Guia>();
        private Cliente clienteSeleccionado = null;
        private DatosRetiro datosRetiro = null;

        // CD activo de sesión (hardcodeado por ahora)
        private CentrosDeDistribucion cdActivo = new CentrosDeDistribucion
        {
            idCD = 1,
            nombreCD = "CD Buenos Aires",
            CodigosPostales = new List<string> { "1000", "1900", "1800", "1700" }
        };

        internal void SetClienteSeleccionado(Cliente cliente)
        {
            clienteSeleccionado = cliente;
        }

        internal Cliente GetClienteSeleccionado()
        {
            return clienteSeleccionado;
        }

        internal void SetDatosRetiro(DatosRetiro datos)
        {
            datosRetiro = datos;
        }

        internal DatosRetiro GetDatosRetiro()
        {
            return datosRetiro;
        }

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

        // Construir objeto Destinatario a partir de datos ingresados en la vista
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
                bulto.Estado = EstadoGuia.DisponibleParaRetiro;

                // En ImposicionCallCenter siempre hay extra de retiro a domicilio
                bool tieneExtraRetiro = true;
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

                // Crear GuiaEntidad con estado DisponibleParaRetiro e historial de 2 pasos
                // La tarifa definitiva se calculara en Admision
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
                    RemDni = datosRetiro != null ? int.Parse(datosRetiro.DNIRemitente) : 0,
                    RemDomicilioRetiro = datosRetiro?.DomicilioRetiro ?? string.Empty,
                    RemCodPostal = datosRetiro?.CodigoPostal ?? string.Empty,
                    DniDestinatario = long.Parse(destinatario.DNI),
                    NombreApellidoDestinatario = destinatario.NombreCompleto,
                    TelefonoDestinatario = long.Parse(destinatario.Telefono),
                    DomicilioEntrega = destinatario.DomicilioEntrega ?? string.Empty,
                    DomicilioEntregaCodPostal = destinatario.CodigoPostal ?? string.Empty,
                    IdAgenciaDestino = idAgenciaDestino,
                    IdCDDestino = idCDDestino,
                    IdTarifaCliente = 0,    // se calcula en Admision
                    IdExtras = 0,    // se calcula en Admision
                    TarifaDefinitiva = 0,    // se calcula en Admision
                    TieneExtraRetiro = tieneExtraRetiro,
                    TieneExtraEntregaDomicilio = tieneExtraEntregaDomicilio,
                    TieneExtraEntregaAgencia = tieneExtraEntregaAgencia,
                    EstadoGuia = EstadoGuiaEnum.DisponibleParaRetiro,
                    Historial = new List<HistorialGuia>
                    {
                        new HistorialGuia { Estado = EstadoGuiaEnum.Impuesta,             Fecha = ahora },
                        new HistorialGuia { Estado = EstadoGuiaEnum.DisponibleParaRetiro, Fecha = ahora }
                    }
                };

                GuiaAlmacen.guias.Add(nuevaGuia);
            }

            GuiaAlmacen.Guardar();
        }

        // Obtener agencias del almacen y convertir a modelo de agencia para la vista
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

        // Obtener centros de distribucion del almacen y convertir a modelo de centro de distribucion para la vista
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

        // Obtener codigos postales del almacen y convertir a modelo de codigo postal para la vista
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

        // Obtener clientes del almacen y convertir a modelo de cliente para la vista
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

