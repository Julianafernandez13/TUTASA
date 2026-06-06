using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.ConfeccionHDRdeUltMilla
{
    internal class ConfeccionHDRdeUltMillaModelo
    {
        // Propiedades de estado 
        public string CdSesion { get; set; } = "CD Buenos Aires"; // Simula el CD de la sesión actual (Hardcodeado)
        public List<Guia> GuiasEncontradas { get; set; } = new List<Guia>();
        public bool Limpiando { get; set; } = false;

        // Listas de HDRs generadas 
        private List<HDRRetiro> hdrsRetiro = new List<HDRRetiro>();
        private List<HDREntrega> hdrsEntrega = new List<HDREntrega>();

        // Datos de prueba: fleteros
        private List<Fletero> fleteros = new List<Fletero>
        {
            new Fletero { Id=1, NombreCompleto="Carlos Rodríguez", Localidad="Buenos Aires" },
            new Fletero { Id=2, NombreCompleto="Diego Martínez",   Localidad="Buenos Aires" },
            new Fletero { Id=3, NombreCompleto="Juan López",       Localidad="Córdoba"      },
        };

        // Datos de prueba: guías
        private List<Guia> guias = new List<Guia>
        {
            // Guías de CD Buenos Aires — Retiro
            new Guia { Id=1, NroTracking="BUE-00000010", EstadoActual="Impuesta",                  NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Ana García",   DomicilioEntrega="Av. Corrientes 1234", Localidad="Buenos Aires", Categoria="M",  TipoEntrega="Domicilio", Agencia="", CdOrigen="CD Buenos Aires" },
            new Guia { Id=2, NroTracking="BUE-00000011", EstadoActual="Impuesta",                  NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Pedro Díaz",   DomicilioEntrega="Av. Rivadavia 456", Localidad="Buenos Aires", Categoria="S",  TipoEntrega="Domicilio", Agencia="", CdOrigen="CD Buenos Aires" },
            new Guia { Id=3, NroTracking="BUE-00000012", EstadoActual="Impuesta",                  NombreRemitente="Juan Pérez",               NombreDestinatario="Laura Sosa",   DomicilioEntrega="Av. Santa Fe 567",    Localidad="Buenos Aires", Categoria="L",  TipoEntrega="Domicilio", Agencia="", CdOrigen="CD Buenos Aires" },

            // Guías de CD Buenos Aires — Entrega
            new Guia { Id=4, NroTracking="BUE-00000020", EstadoActual="Pendiente de Distribución", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Sofía Torres", DomicilioEntrega="Av. Carabobo 1234", Localidad="Buenos Aires", Categoria="M",  TipoEntrega="Domicilio", Agencia="", CdOrigen="CD Buenos Aires" },
            new Guia { Id=5, NroTracking="BUE-00000021", EstadoActual="Pendiente de Distribución", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Diego Molina", DomicilioEntrega="Av. TinoGasta 3777",    Localidad="Buenos Aires", Categoria="XL", TipoEntrega="Domicilio", Agencia="", CdOrigen="CD Buenos Aires" },
            new Guia { Id=6, NroTracking="BUE-00000022", EstadoActual="Pendiente de Distribución", NombreRemitente="Juan Pérez",               NombreDestinatario="Marcos Ruiz",  DomicilioEntrega="Av. Rivadavia 890",   Localidad="Buenos Aires", Categoria="S",  TipoEntrega="Domicilio", Agencia="", CdOrigen="CD Buenos Aires" },
            new Guia { Id=9, NroTracking="BUE-00000023", EstadoActual="Pendiente de Distribución", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Carlos López", DomicilioEntrega="Av. Carabobo 1234", Localidad="Buenos Aires", Categoria="S", TipoEntrega="Domicilio", Agencia="", CdOrigen="CD Buenos Aires" },

            // Guías de CD Córdoba — NO deben aparecer si la sesión es Buenos Aires
            new Guia { Id=7, NroTracking="COR-00000010", EstadoActual="Impuesta",                  NombreRemitente="Empresa XYZ",             NombreDestinatario="Roberto Paz",  DomicilioEntrega="Bv. San Juan 890",    Localidad="Córdoba",      Categoria="M",  TipoEntrega="Domicilio", Agencia="", CdOrigen="CD Córdoba" },
            new Guia { Id=8, NroTracking="COR-00000011", EstadoActual="Pendiente de Distribución", NombreRemitente="Empresa XYZ",             NombreDestinatario="María Gómez",  DomicilioEntrega="Bv. San Juan 890",    Localidad="Córdoba",      Categoria="S",  TipoEntrega="Domicilio", Agencia="", CdOrigen="CD Córdoba" },
        };

        // Métodos 

        // Devuelve el estado correspondiente al tipo de HDR
        private string ObtenerEstado(string tipoHDR)
        {
            if (tipoHDR == "Retiro") return "Impuesta";
            if (tipoHDR == "Entrega") return "Pendiente de Distribución";
            return "";
        }

        // Devuelve las localidades que tienen guías según el tipo de HDR y el CD de sesión
        public List<string> ObtenerLocalidadesPorTipo(string tipoHDR)
        {
            string estado = ObtenerEstado(tipoHDR);
            var localidades = new List<string>();
            foreach (var g in guias)
            {
                if (g.EstadoActual == estado && g.CdOrigen == CdSesion && !localidades.Contains(g.Localidad))
                    localidades.Add(g.Localidad);
            }
            return localidades;
        }

        // Devuelve los domicilios únicos de una localidad según el tipo de HDR y el CD de sesión
        public List<string> ObtenerDomiciliosPorLocalidadYTipo(string localidad, string tipoHDR)
        {
            string estado = ObtenerEstado(tipoHDR);
            var domicilios = new List<string>();
            foreach (var g in guias)
            {
                if (g.Localidad == localidad && g.EstadoActual == estado && g.CdOrigen == CdSesion && !domicilios.Contains(g.DomicilioEntrega))
                    domicilios.Add(g.DomicilioEntrega);
            }
            return domicilios;
        }

        // Devuelve las guías filtradas por localidad, domicilio, tipo de HDR y CD de sesión
        public List<Guia> ObtenerGuiasPendientes(string localidad, string domicilio, string tipoHDR)
        {
            string estado = ObtenerEstado(tipoHDR);
            var resultado = new List<Guia>();
            foreach (var g in guias)
            {
                if (g.Localidad == localidad && g.DomicilioEntrega == domicilio && g.EstadoActual == estado && g.CdOrigen == CdSesion)
                    resultado.Add(g);
            }
            return resultado;
        }

        // Devuelve los fleteros disponibles en una localidad
        public List<Fletero> ObtenerFleterosPorLocalidad(string localidad)
        {
            var resultado = new List<Fletero>();
            foreach (var f in fleteros)
            {
                if (f.Localidad == localidad)
                    resultado.Add(f);
            }
            return resultado;
        }

        // Confirma la HDR
        public void ConfirmarHDR(List<Guia> guiasSeleccionadas, Fletero fletero, string tipoHDR)
        {
            
            if (tipoHDR == "Retiro")  
            {
                HDRRetiro nuevaHDR = new HDRRetiro 
                {
                    Id = hdrsRetiro.Count + 1,
                    FechaEmision = DateTime.Now,
                    Estado = "Pendiente", 
                    IdFletero = fletero.Id,
                    Guias = guiasSeleccionadas
                };
                hdrsRetiro.Add(nuevaHDR);

                // ── VERIFICACIÓN TEMPORAL ─────────────────────────
                string detalle = "HDR Retiro #" + nuevaHDR.Id + "\n";
                detalle += "Fecha: " + nuevaHDR.FechaEmision.ToString("dd/MM/yyyy HH:mm") + "\n";
                detalle += "Estado: " + nuevaHDR.Estado + "\n";
                detalle += "Fletero ID: " + nuevaHDR.IdFletero + "\n";
                detalle += "Guías incluidas:\n";
                foreach (var g in nuevaHDR.Guias)
                    detalle += "  • " + g.NroTracking + " — " + g.NombreDestinatario + " — " + g.Categoria + "\n";
                System.Windows.Forms.MessageBox.Show(detalle, "HDR Retiro creada", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else if (tipoHDR == "Entrega")
            {
                HDREntrega nuevaHDR = new HDREntrega
                {
                    Id = hdrsEntrega.Count + 1,
                    FechaEmision = DateTime.Now,
                    Estado = "Pendiente",
                    IdFletero = fletero.Id,
                    Guias = guiasSeleccionadas
                };
                hdrsEntrega.Add(nuevaHDR);

                // ── VERIFICACIÓN TEMPORAL ─────────────────────────
                string detalle = "HDR Entrega #" + nuevaHDR.Id + "\n";
                detalle += "Fecha: " + nuevaHDR.FechaEmision.ToString("dd/MM/yyyy HH:mm") + "\n";
                detalle += "Estado: " + nuevaHDR.Estado + "\n";
                detalle += "Fletero ID: " + nuevaHDR.IdFletero + "\n";
                detalle += "Guías incluidas:\n";
                foreach (var g in nuevaHDR.Guias)
                    detalle += "  • " + g.NroTracking + " — " + g.NombreDestinatario + " — " + g.Categoria + "\n";
                System.Windows.Forms.MessageBox.Show(detalle, "HDR Entrega creada", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
    }
}
