using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Admision;

namespace TUTASA.ConsultaTracking
{
    internal class ConsultaTrackingModelo
    {
        private AdmisionModelo admisionModelo = new AdmisionModelo();

        public List<Guia> Guias => admisionModelo.Guias;

        public Guia BuscarGuia(string nroTracking)
        {
            foreach (var guia in admisionModelo.Guias)
            {
                if (guia.NroTracking == nroTracking.Trim().ToUpper())
                    return guia;
            }
            return null;
        }

        // Historial simulado por guía
        public List<EventoHistorial> ObtenerHistorial(Guia guia)
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
    }
}
