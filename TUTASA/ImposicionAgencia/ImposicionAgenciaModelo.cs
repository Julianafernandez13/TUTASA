using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Almacenes;
using TUTASA.Enums;


namespace TUTASA.ImposicionAgencia
{

    internal class ImposicionAgenciaModelo
    {
        private List<Guia> guias = new List<Guia>();
        private Cliente clienteSeleccionado = null;
        private DatosRetiro datosRetiro = null;

        // Agencia activa hardcodeada por ahora
        private Agencias agenciaActiva = new Agencias
        {
            idAgencia = 1,
            nombreAgencia = "Agencia La Plata Centro",
            CodigoPostal = "1900",
            Domicilio = "Calle 7 Nro 123"
        };

        internal Agencias GetAgenciaActiva()
        {
            return agenciaActiva;
        }

        internal DatosRetiro GetDatosRetiroAgencia()
        {
            var cp = ObtenerCodigosPostales().Find(c => c.idCodPostal == agenciaActiva.CodigoPostal);

            return new DatosRetiro
            {
                DomicilioRetiro = agenciaActiva.Domicilio,
                CodigoPostal = agenciaActiva.CodigoPostal,
                Localidad = cp?.DescripcionLocalidad,
                Provincia = cp?.DescripcionProvincia
            };
        }

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

            // Buscar el CD origen que corresponde a la agencia activa
            int idCDOrigen = 0;
            foreach (AgenciaEntidad agenciaEntidad in AgenciaAlmacen.agencias)
            {
                if (agenciaEntidad.IdAgencia == agenciaActiva.idAgencia)
                {
                    idCDOrigen = agenciaEntidad.IdCD;
                    break;
                }
            }

            foreach (var bulto in guias)
            {
                // Generar NroTracking: idAgencia + número correlativo
                int nuevoId = GuiaAlmacen.guias.Count + 1;
                string nroTracking = agenciaActiva.idAgencia + "-" + nuevoId.ToString("D8");

                bulto.NroTracking = nroTracking;
                bulto.Destinatario = destinatario;
                bulto.Estado = EstadoGuia.DisponibleParaRetiro;

                // Determinar extras segun tipo de entrega
                // En ImposicionAgencia no hay extra de retiro (el cliente trae el bulto a la agencia)
                bool tieneExtraRetiro = false;
                bool tieneExtraEntregaDomicilio = destinatario.TipoEntrega == TipoEntrega.Domicilio;
                bool tieneExtraEntregaAgencia = destinatario.TipoEntrega == TipoEntrega.Agencia;

                // Determinar idAgenciaDestino e idCDDestino segun tipo de entrega
                int idAgenciaDestino = 0;
                int idCDDestino = 0;

                if (destinatario.TipoEntrega == TipoEntrega.Agencia && destinatario.AgenciaDestino != null)
                    idAgenciaDestino = destinatario.AgenciaDestino.idAgencia;
                else if (destinatario.TipoEntrega == TipoEntrega.CD && destinatario.CDDestino != null)
                    idCDDestino = destinatario.CDDestino.idCD;

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
                    IdAgenciaOrigen = agenciaActiva.idAgencia,
                    IdCDOrigen = idCDOrigen,
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

        internal List<Agencias> ObtenerAgencias()
        {
            var resultado = new List<Agencias>();
            foreach (AgenciaEntidad agenciaEntidad in AgenciaAlmacen.agencias)
            {
                resultado.Add(new Agencias
                {
                    idAgencia = agenciaEntidad.IdAgencia,
                    nombreAgencia = agenciaEntidad.NombreAgencia,
                    CodigoPostal = agenciaEntidad.IdCodPostal,
                    Domicilio = agenciaEntidad.DomicilioAgencia
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
    }
}
