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

        internal void AsignarDestinatarioAGuias(Destinatario destinatario)
        {
            System.DateTime ahora = System.DateTime.Now;

            foreach (var bulto in guias)
            {
                // Generar NroTracking: idCD + número correlativo
                int nuevoId = GuiaAlmacen.guias.Count + 1;
                string nroTracking = cdActivo.idCD + "-" + nuevoId.ToString("D8");

                bulto.NroTracking = nroTracking;
                bulto.Destinatario = destinatario;
                bulto.Estado = EstadoGuia.Admitida;

                // Determinar idAgenciaDestino e idCDDestino según tipo de entrega
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
                    EstadoGuia = EstadoGuiaEnum.Admitida,
                    Historial = new List<HistorialGuia>
                    {
                        new HistorialGuia { Estado = EstadoGuiaEnum.Impuesta,  Fecha = ahora },
                        new HistorialGuia { Estado = EstadoGuiaEnum.Admitida,  Fecha = ahora }
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
    }
}
