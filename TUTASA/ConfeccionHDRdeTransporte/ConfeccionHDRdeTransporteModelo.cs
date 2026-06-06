using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.ConfeccionHDRdeTransporte
{
    internal class ConfeccionHDRdeTransporteModelo
    {
        // ── Propiedades de estado ─────────────────────────────
        public List<Guia> GuiasSeleccionadas { get; set; } = new List<Guia>();
        public bool Limpiando { get; set; } = false;

        // ── Lista de HDRs generadas ───────────────────────────
        private List<HDRTransporte> hdrsTransporte = new List<HDRTransporte>();

        // ── Datos de prueba: localidades ─────────────────────
        private List<Localidad> localidades = new List<Localidad>
        {
            new Localidad { Id=1, Nombre="Córdoba",       CdDestino="CD Córdoba"       },
            new Localidad { Id=2, Nombre="Rosario",       CdDestino="CD Rosario"       },
            new Localidad { Id=3, Nombre="Mendoza",       CdDestino="CD Mendoza"       },
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
            new Guia { Id=1,  NroTracking="BUE-00000010", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Ana García",    Localidad="Córdoba", Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba" },
            new Guia { Id=2,  NroTracking="BUE-00000011", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Pedro Díaz",    Localidad="Córdoba", Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba" },
            new Guia { Id=3,  NroTracking="BUE-00000012", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Laura Sosa",    Localidad="Córdoba", Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba" },
            new Guia { Id=4,  NroTracking="BUE-00000013", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Sofía Torres",  Localidad="Córdoba", Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba" },
            new Guia { Id=5,  NroTracking="BUE-00000014", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Diego Molina",  Localidad="Córdoba", Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba" },
            new Guia { Id=6,  NroTracking="BUE-00000015", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Marcos Ruiz",   Localidad="Córdoba", Categoria="L",  CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba" },
            new Guia { Id=7,  NroTracking="BUE-00000016", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Carlos López",  Localidad="Córdoba", Categoria="L",  CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba" },
            new Guia { Id=8,  NroTracking="BUE-00000017", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="María Gómez",   Localidad="Córdoba", Categoria="M",  CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba" },
            new Guia { Id=9,  NroTracking="BUE-00000018", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Roberto Paz",   Localidad="Córdoba", Categoria="M",  CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba" },
            new Guia { Id=10, NroTracking="BUE-00000019", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Lucía Fernández",Localidad="Córdoba", Categoria="S",  CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba" },
            new Guia { Id=11, NroTracking="BUE-00000020", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Jorge Romero",  Localidad="Rosario", Categoria="L",  CdOrigen="CD Buenos Aires", CdDestino="CD Rosario" },
            new Guia { Id=12, NroTracking="BUE-00000021", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Paula Suárez",  Localidad="Mendoza", Categoria="M",  CdOrigen="CD Buenos Aires", CdDestino="CD Mendoza" },
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

        // Calcula el tipo de arrendamiento según equivalencia en XL
        // Equivalencias: S=0.125 XL, M=0.25 XL, L=0.5 XL, XL=1 XL
        // Rangos: D=hasta 3 XL, C=hasta 7 XL, B=hasta 10 XL, A=hasta 20 XL
        public string CalcularTipoArrendamiento(List<Guia> guiasACalcular)
        {
            decimal totalXL = 0;
            foreach (var g in guiasACalcular)
            {
                switch (g.Categoria)
                {
                    case "S": totalXL += 0.125m; break;
                    case "M": totalXL += 0.25m; break;
                    case "L": totalXL += 0.5m; break;
                    case "XL": totalXL += 1m; break;
                }
            }

            if (totalXL <= 3)
                return "D";
            else if (totalXL > 3 && totalXL <= 7)
                return "C";
            else if (totalXL > 7 && totalXL <= 10)
                return "B";
            else if (totalXL > 10 && totalXL <= 20)
                return "A";
            else
                return "Excede capacidad máxima";
        }

        // Guarda la HDR de transporte con fecha, estado y guías seleccionadas
        public void GuardarHDR(EmpresaTransporte empresa, string tipoArrendamiento)
        {
            HDRTransporte nuevaHDR = new HDRTransporte
            {
                Id = hdrsTransporte.Count + 1,
                FechaEmision = DateTime.Now,
                Estado = "Pendiente",
                IdEmpresaTransporte = empresa.Id,
                TipoArrendamiento = tipoArrendamiento,
                Guias = new List<Guia>(GuiasSeleccionadas)
            };

            hdrsTransporte.Add(nuevaHDR);

            // Actualizar estado de las guías incluidas en la HDR
            foreach (var g in GuiasSeleccionadas)
                g.EstadoActual = "HDR Transporte Confeccionada";

            // Limpiar selección
            GuiasSeleccionadas.Clear();
        }
    }
}