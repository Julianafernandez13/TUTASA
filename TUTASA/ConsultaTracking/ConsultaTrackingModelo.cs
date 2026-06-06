using System;
using System.Collections.Generic;
using System.Drawing;

namespace TUTASA.ConsultaTracking
{
    internal class ConsultaTrackingModelo
    {
        public GuiaTracking GuiaSeleccionada { get; private set; }

        private List<GuiaTracking> guias = new List<GuiaTracking>
        {
            new GuiaTracking { Id = 1, NroTracking = "BUE-00000001", EstadoActual = "Impuesto en agencia — pendiente de admisión en CD", Categoria = "M", CdOrigen = "Buenos Aires", CdDestino = "Rosario",    NombreRemitente = "Industrias López SA",     NombreDestinatario = "Carlos Méndez"   },
            new GuiaTracking { Id = 2, NroTracking = "BUE-00000002", EstadoActual = "Admitida en CD",                                     Categoria = "L", CdOrigen = "Buenos Aires", CdDestino = "Córdoba",    NombreRemitente = "Textiles Garmendia SRL",  NombreDestinatario = "Ana Rodríguez"   },
            new GuiaTracking { Id = 3, NroTracking = "BUE-00000003", EstadoActual = "Impuesto en agencia — pendiente de admisión en CD", Categoria = "S", CdOrigen = "Buenos Aires", CdDestino = "Mendoza",    NombreRemitente = "Distribuidora Norte SA",  NombreDestinatario = "Roberto Fernández"},
            new GuiaTracking { Id = 4, NroTracking = "BUE-00000004", EstadoActual = "Admitida en CD",                                     Categoria = "XL",CdOrigen = "Buenos Aires", CdDestino = "Tucumán",    NombreRemitente = "Comercial del Sur SRL",   NombreDestinatario = "Laura Giménez"   },
            new GuiaTracking { Id = 5, NroTracking = "BUE-00000005", EstadoActual = "Impuesto en agencia — pendiente de admisión en CD", Categoria = "M", CdOrigen = "Buenos Aires", CdDestino = "Mar del Plata", NombreRemitente = "Importadora del Este SA", NombreDestinatario = "Martín Sosa"   }
        };

        internal bool BuscarGuia(string nroTracking)
        {
            GuiaSeleccionada = null;

            foreach (var guia in guias)
            {
                if (guia.NroTracking == nroTracking.Trim().ToUpper())
                {
                    GuiaSeleccionada = guia;
                    break;
                }
            }

            if (GuiaSeleccionada == null)
            {
                System.Windows.Forms.MessageBox.Show(
                    "La guía ingresada no corresponde a ninguna solicitud registrada.",
                    "Guía no encontrada",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public List<EventoHistorial> ObtenerHistorial(GuiaTracking guia)
        {
            var historial = new List<EventoHistorial>();

            historial.Add(new EventoHistorial
            {
                Fecha = DateTime.Now.AddDays(-3).ToString("dd/MM/yyyy"),
                Hora = "09:15",
                Ubicacion = guia.CdOrigen,
                Estado = "Impuesto en agencia"
            });

            historial.Add(new EventoHistorial
            {
                Fecha = DateTime.Now.AddDays(-2).ToString("dd/MM/yyyy"),
                Hora = "14:30",
                Ubicacion = guia.CdOrigen,
                Estado = "Pendiente de admisión en CD"
            });

            if (guia.EstadoActual == "Admitida en CD")
            {
                historial.Add(new EventoHistorial
                {
                    Fecha = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy"),
                    Hora = "08:45",
                    Ubicacion = guia.CdOrigen,
                    Estado = "Admitida en CD"
                });
            }

            return historial;
        }

        public Color ObtenerColorEstado(string estado)
        {
            if (estado == "Admitida en CD")
                return Color.LimeGreen;
            if (estado != null && estado.Contains("pendiente"))
                return Color.Orange;
            return Color.LightYellow;
        }

        internal void LimpiarSeleccion()
        {
            GuiaSeleccionada = null;
        }
    }
}