using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Enums;
using TUTASA.ImposicionAgencia;

namespace TUTASA.ImposicionCD
{
    internal class ImposicionCDModelo
    {
        private List<Guia> guias = new List<Guia>();
        private Cliente clienteSeleccionado = null;

        // Métodos para manejar el cliente seleccionado y los bultos
        internal void SetClienteSeleccionado(Cliente cliente)
        {
            clienteSeleccionado = cliente;
        }

        // Método para obtener el cliente seleccionado
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

        // Método para quitar un bulto por su índice
        internal void QuitarBulto(int indice)
        {
            guias.RemoveAt(indice);
            for (int i = 0; i < guias.Count; i++)
                guias[i].idGuia = i + 1;
        }

        // Método para obtener la lista de bultos
        internal List<Guia> GetBultos()
        {
            return guias;
        }

        internal Destinatario ConstruirDestinatario(string nombre, string dni, string telefono, TipoEntrega tipo, string domicilio = null, string codigoPostal = null, Agencias agencia = null, CentrosDeDistribucion cd = null)
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
            foreach (var bulto in guias)
            {
                bulto.Destinatario = destinatario;

                bulto.Estado = EstadoGuia.Impuesta;
                    
            }
        }

        internal List<Agencias> ObtenerAgencias()
        {
            return new List<Agencias>()
            {
                new Agencias { idAgencia = 1, nombreAgencia = "Agencia La Plata Centro", CodigoPostal = "1900" },
                new Agencias { idAgencia = 2, nombreAgencia = "Agencia La Plata Norte",  CodigoPostal = "1900" },
                new Agencias { idAgencia = 3, nombreAgencia = "Agencia Quilmes",         CodigoPostal = "1800" },
                new Agencias { idAgencia = 4, nombreAgencia = "Agencia Morón",           CodigoPostal = "1700" },
                new Agencias { idAgencia = 5, nombreAgencia = "Agencia CABA Centro",     CodigoPostal = "1000" },
                new Agencias { idAgencia = 6, nombreAgencia = "Agencia Córdoba",         CodigoPostal = "5000" },
            };

        }

        internal List<CentrosDeDistribucion> ObtenerCentrosDeDistribucion()
        {
            return new List<CentrosDeDistribucion>()
            {
                new CentrosDeDistribucion
                {
                    idCD = 1,
                    nombreCD = "CD Gran Buenos Aires",
                    CodigosPostales = new List<string> { "1900", "1800", "1700" }
                },
                new CentrosDeDistribucion
                {
                    idCD = 2,
                    nombreCD = "CD CABA",
                    CodigosPostales = new List<string> { "1000" }
                },
                new CentrosDeDistribucion
                {
                    idCD = 3,
                    nombreCD = "CD Centro",
                    CodigosPostales = new List<string> { "5000", "1900" } // 1900 cae en dos CDs
                },
            };
        }

        internal List<CodigoPostal> ObtenerCodigosPostales()
        {
            return new List<CodigoPostal>()
            {
                new CodigoPostal { idCodPostal = "1900", DescripcionLocalidad = "La Plata", DescripcionProvincia = "Buenos Aires" },
                new CodigoPostal { idCodPostal = "1800", DescripcionLocalidad = "Quilmes", DescripcionProvincia = "Buenos Aires" },
                new CodigoPostal { idCodPostal = "1700", DescripcionLocalidad = "Morón", DescripcionProvincia = "Buenos Aires" },
                new CodigoPostal { idCodPostal = "1000", DescripcionLocalidad = "Buenos Aires", DescripcionProvincia = "CABA" },
                new CodigoPostal { idCodPostal = "5000", DescripcionLocalidad = "Córdoba", DescripcionProvincia = "Córdoba" },
            };

        }

        internal List<Cliente> ObtenerClientes()
        {

            return new List<Cliente>()
            {
                new Cliente { Id = 1, NombreCompleto = "Juan Pérez", CUIT = "20304050607" },
                new Cliente { Id = 2, NombreCompleto = "María González", CUIT = "27333311122" },
                new Cliente { Id = 3, NombreCompleto = "Carlos Sosa", CUIT = "20111222333" },
                new Cliente { Id = 4, NombreCompleto = "Lucía Fernández", CUIT = "27222333444" }
            };
        }
    }
}
