using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace TUTASA.ConfeccionHDRdeTransporte
{
    internal class ConfeccionHDRdeTransporteModelo
    {
        // ── Datos de prueba: localidades ─────────────────────
        private List<Localidad> localidades = new List<Localidad>
        {
            new Localidad { Id=1, Nombre="Córdoba",      CdDestino="CD Córdoba"      },
            new Localidad { Id=2, Nombre="Rosario",      CdDestino="CD Rosario"      },
            new Localidad { Id=3, Nombre="Mendoza",      CdDestino="CD Mendoza"      },
            new Localidad { Id=4, Nombre="Mar del Plata", CdDestino="CD Mar del Plata" },
        };

        // ── Datos de prueba: empresas de transporte ──────────
        private List<EmpresaTransporte> empresas = new List<EmpresaTransporte>
        {
            new EmpresaTransporte { Id=1, Nombre="Flecha Bus", Localidad="Córdoba"       },
            new EmpresaTransporte { Id=2, Nombre="Flecha Bus", Localidad="Rosario"       },
            new EmpresaTransporte { Id=3, Nombre="Andesmar",   Localidad="Mendoza"       },
            new EmpresaTransporte { Id=4, Nombre="Chevallier", Localidad="Mar del Plata" },
        };

        // ── Datos de prueba: guías admitidas ─────────────────
        private List<Guia> guias = new List<Guia>
        {
            new Guia { Id=1, NroTracking="BUE-00000010", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Ana García",    Localidad="Córdoba",       Categoria="M",  CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba"       },
            new Guia { Id=2, NroTracking="BUE-00000011", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Pedro Díaz",    Localidad="Córdoba",       Categoria="S",  CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba"       },
            new Guia { Id=3, NroTracking="BUE-00000012", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Laura Sosa",    Localidad="Rosario",       Categoria="L",  CdOrigen="CD Buenos Aires", CdDestino="CD Rosario"       },
            new Guia { Id=4, NroTracking="BUE-00000013", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Sofía Torres",  Localidad="Mendoza",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mendoza"       },
            new Guia { Id=5, NroTracking="BUE-00000014", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Diego Molina",  Localidad="Mar del Plata", Categoria="M",  CdOrigen="CD Buenos Aires", CdDestino="CD Mar del Plata" },
        };

        // ── Métodos ───────────────────────────────────────────

        // Devuelve todas las localidades
        public List<Localidad> ObtenerLocalidades()
        {
            return localidades;
        }

        // Devuelve el CD destino de una localidad
        public string ObtenerCdDestino(string localidad)
        {
            foreach (var l in localidades)
            {
                if (l.Nombre == localidad)
                    return l.CdDestino;
            }
            return "";
        }

        // Devuelve las empresas que cubren una localidad destino
        public List<EmpresaTransporte> ObtenerEmpresasPorLocalidad(string localidad)
        {
            var resultado = new List<EmpresaTransporte>();
            foreach (var e in empresas)
            {
                if (e.Localidad == localidad)
                    resultado.Add(e);
            }
            return resultado;
        }

        // Devuelve las guías admitidas para una localidad destino
        public List<Guia> ObtenerGuiasPorLocalidad(string localidad)
        {
            var resultado = new List<Guia>();
            foreach (var g in guias)
            {
                if (g.Localidad == localidad && g.EstadoActual == "Admitida")
                    resultado.Add(g);
            }
            return resultado;
        }

        // Calcula el tipo de arrendamiento según el total de XLs
        public string CalcularTipoArrendamiento(List<Guia> guiasSeleccionadas)
        {
            decimal totalXL = 0;
            foreach (var g in guiasSeleccionadas)
            {
                switch (g.Categoria)
                {
                    case "S": totalXL += 0.25m; break;
                    case "M": totalXL += 0.5m; break;
                    case "L": totalXL += 1m; break;
                    case "XL": totalXL += 2m; break;
                }
            }

            if (totalXL <= 5) return "Cuarto de bodega";
            if (totalXL <= 10) return "Media bodega";
            return "Bodega completa";
        }

        // Guarda la HDR
        public void GuardarHDR(List<Guia> guiasSeleccionadas, EmpresaTransporte empresa, string tipoArrendamiento)
        {
            foreach (var g in guiasSeleccionadas)
                g.EstadoActual = "HDR Transporte Confeccionada";
        }
    }
}
