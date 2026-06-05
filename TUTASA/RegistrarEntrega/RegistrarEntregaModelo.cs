using System.Collections.Generic;
using System.Windows.Forms;
using TUTASA.Admision;

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
                        EstadoActual = "Admitida en CD"
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

        internal bool BuscarReceptor(string dni)
        {
            ReceptorSeleccionado = null;

            foreach (var receptor in receptores)
            {
                if (receptor.Dni == dni.Trim())
                {
                    ReceptorSeleccionado = receptor;
                    break;
                }
            }

            if (ReceptorSeleccionado == null)
            {
                MessageBox.Show(
                    "No se encontró ningún receptor con el DNI ingresado.",
                    "Receptor no encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public List<Guia> ObtenerGuiasDisponibles()
        {
            var disponibles = new List<Guia>();

            if (ReceptorSeleccionado == null)
                return disponibles;

            foreach (var guia in ReceptorSeleccionado.Guias)
            {
                if (guia.EstadoActual == ESTADO_DISPONIBLE)
                    disponibles.Add(guia);
            }

            return disponibles;
        }

        internal bool ConfirmarEntrega()
        {
            if (ReceptorSeleccionado == null)
            {
                MessageBox.Show(
                    "Debe buscar un receptor primero.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            var disponibles = ObtenerGuiasDisponibles();

            if (disponibles.Count == 0)
            {
                MessageBox.Show(
                    "El receptor no tiene encomiendas disponibles para retiro.",
                    "Sin encomiendas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return false;
            }

            foreach (var guia in disponibles)
            {
                guia.EstadoActual = "Entregada en CD";
            }

            ReceptorSeleccionado = null;

            return true;
        }

        internal void LimpiarSeleccion()
        {
            ReceptorSeleccionado = null;
        }
    }
}