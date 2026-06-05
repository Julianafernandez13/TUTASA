using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUTASA.RegistrarEntrega
{
    internal class RegistrarEntregaModelo
    {
        public const string ESTADO_DISPONIBLE = "Disponible para Retiro";
        public Receptor ReceptorSeleccionado { get; private set; }
        private List<Receptor> receptores = new List<Receptor>
        {
            new Receptor
            {
                Id = 1,
                Dni = "12345678",
                NombreCompleto = "Carlos Méndez",
                Guias = new List<Guia>
                {
                    new Guia
                    {
                        Id = 1,
                        NroTracking = "BUE-00000001",
                        NombreRemitente = "Industrias López SA",
                        NombreDestinatario = "Carlos Méndez",
                        EstadoActual = "Disponible para Retiro"
                    },
                    new Guia
                    {
                        Id = 6,
                        NroTracking = "BUE-00000006",
                        NombreRemitente = "Logística del Centro SA",
                        NombreDestinatario = "Carlos Méndez",
                        EstadoActual = "Admitida en CD"  // Esta NO debe aparecer
                    }
                }
            },
            new Receptor
            {
                Id = 2,
                Dni = "87654321",
                NombreCompleto = "Ana Rodríguez",
                Guias = new List<Guia>
                {
                    new Guia
                    {
                        Id = 2,
                        NroTracking = "BUE-00000002",
                        NombreRemitente = "Textiles Garmendia SRL",
                        NombreDestinatario = "Ana Rodríguez",
                        EstadoActual = "Disponible para Retiro"
                    },
                    new Guia
                    {
                        Id = 5,
                        NroTracking = "BUE-00000005",
                        NombreRemitente = "Importadora del Este SA",
                        NombreDestinatario = "Ana Rodríguez",
                        EstadoActual = "Disponible para Retiro"
                    }
                }
            },
            new Receptor
            {
                Id = 3,
                Dni = "11223344",
                NombreCompleto = "Roberto Fernández",
                Guias = new List<Guia>
                {
                    new Guia
                    {
                        Id = 3,
                        NroTracking = "BUE-00000003",
                        NombreRemitente = "Distribuidora Norte SA",
                        NombreDestinatario = "Roberto Fernández",
                        EstadoActual = "Disponible para Retiro"
                    }
                }
            }
        };

        public Receptor BuscarReceptor(string dni)
        {
            foreach (var receptor in receptores)
            {
                if (receptor.Dni == dni.Trim())
                    return receptor;
            }
            return null;
        }

        public Receptor BuscarReceptor(string dni)
        {
            foreach (var receptor in receptores)
            {
                if (receptor.Dni == dni.Trim())
                    return receptor;
            }
            return null;
        }

        internal bool ConfirmarEntrega(Receptor receptor)
        {
            if (receptor == null)
            {
                MessageBox.Show(
                    "Debe buscar un receptor primero.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (receptor.Guias == null || receptor.Guias.Count == 0)
            {
                MessageBox.Show(
                    "El receptor no tiene encomiendas para entregar.",
                    "Sin encomiendas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            foreach (var guia in receptor.Guias)
            {
                guia.EstadoActual = "Entregada en CD";
            }

            return true;
        }
    }
}
