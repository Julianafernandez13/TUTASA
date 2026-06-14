using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Almacenes;

namespace TUTASA.ConfeccionHDRdeTransporte
{
    internal class ConfeccionHDRdeTransporteModelo
    {
        // ── Propiedades de estado ─────────────────────────────
        public List<Guia> GuiasSeleccionadas { get; set; } = new List<Guia>();
        public bool Limpiando { get; set; } = false;

        // ── CD Origen hardcodeado por sesión ──────────────────
        public int IdCDOrigen { get; set; } = 1; // CD Buenos Aires

        // ── Lista de HDRs generadas ───────────────────────────
        private List<HDRTransporte> hdrsTransporte = new List<HDRTransporte>();

        // ── Datos de prueba: guías admitidas ─────────────────
        private List<Guia> guias = new List<Guia>
        {
    // CD Córdoba — Flecha Bus (Tipo C, límite 7 XL equiv.)
            new Guia { Id=1,  NroTracking="BUE-00000010", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Ana García",     Localidad="Córdoba",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba"       },
            new Guia { Id=2,  NroTracking="BUE-00000011", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Pedro Díaz",     Localidad="Córdoba",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba"       },
            new Guia { Id=3,  NroTracking="BUE-00000012", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Laura Sosa",     Localidad="Córdoba",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba"       },
            new Guia { Id=4,  NroTracking="BUE-00000013", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Sofía Torres",   Localidad="Córdoba",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba"       },
            new Guia { Id=5,  NroTracking="BUE-00000014", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Diego Molina",   Localidad="Córdoba",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba"       },
            new Guia { Id=6,  NroTracking="BUE-00000015", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Marcos Ruiz",    Localidad="Córdoba",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba"       },
            new Guia { Id=7,  NroTracking="BUE-00000016", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Carlos López",   Localidad="Córdoba",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba"       },
            new Guia { Id=8,  NroTracking="BUE-00000017", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="María Gómez",    Localidad="Córdoba",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Córdoba"       },

    // CD Rosario — Flecha Bus (Tipo C, límite 7 XL equiv.)
            new Guia { Id=9,  NroTracking="BUE-00000018", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Roberto Paz",    Localidad="Rosario",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Rosario"       },
            new Guia { Id=10, NroTracking="BUE-00000019", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Lucía Fernández",Localidad="Rosario",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Rosario"       },
            new Guia { Id=11, NroTracking="BUE-00000020", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Jorge Romero",   Localidad="Rosario",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Rosario"       },
            new Guia { Id=12, NroTracking="BUE-00000021", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Paula Suárez",   Localidad="Rosario",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Rosario"       },
            new Guia { Id=13, NroTracking="BUE-00000022", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Lucas Ramírez",  Localidad="Rosario",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Rosario"       },
            new Guia { Id=14, NroTracking="BUE-00000023", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Martín López",   Localidad="Rosario",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Rosario"       },
            new Guia { Id=15, NroTracking="BUE-00000024", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Carla Gómez",    Localidad="Rosario",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Rosario"       },
            new Guia { Id=16, NroTracking="BUE-00000025", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Diego Sánchez",  Localidad="Rosario",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Rosario"       },

    // CD Mendoza — Andesmar (Tipo B, límite 10 XL equiv.)
            new Guia { Id=17, NroTracking="BUE-00000026", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Carlos Ruiz",    Localidad="Mendoza",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mendoza"       },
            new Guia { Id=18, NroTracking="BUE-00000027", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Sofía Pérez",    Localidad="Mendoza",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mendoza"       },
            new Guia { Id=19, NroTracking="BUE-00000028", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Ana Torres",     Localidad="Mendoza",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mendoza"       },
            new Guia { Id=20, NroTracking="BUE-00000029", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Roberto García", Localidad="Mendoza",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mendoza"       },
            new Guia { Id=21, NroTracking="BUE-00000030", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Laura Díaz",     Localidad="Mendoza",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mendoza"       },
            new Guia { Id=22, NroTracking="BUE-00000031", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Marcos Sosa",    Localidad="Mendoza",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mendoza"       },
            new Guia { Id=23, NroTracking="BUE-00000032", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Ana Molina",     Localidad="Mendoza",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mendoza"       },
            new Guia { Id=24, NroTracking="BUE-00000033", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Pedro López",    Localidad="Mendoza",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mendoza"       },
            new Guia { Id=25, NroTracking="BUE-00000034", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Laura García",   Localidad="Mendoza",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mendoza"       },
            new Guia { Id=26, NroTracking="BUE-00000035", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Carlos García",  Localidad="Mendoza",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mendoza"       },
            new Guia { Id=27, NroTracking="BUE-00000036", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Sofía Molina",   Localidad="Mendoza",       Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mendoza"       },

    // CD Mar del Plata — Chevallier (Tipo D, límite 3 XL equiv.) — el más fácil para probar
            new Guia { Id=28, NroTracking="BUE-00000037", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Marcos Sosa",    Localidad="Mar del Plata", Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mar del Plata" },
            new Guia { Id=29, NroTracking="BUE-00000038", EstadoActual="Admitida", NombreRemitente="Juan Pérez",               NombreDestinatario="Ana Molina",     Localidad="Mar del Plata", Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mar del Plata" },
            new Guia { Id=30, NroTracking="BUE-00000039", EstadoActual="Admitida", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Pedro López",    Localidad="Mar del Plata", Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mar del Plata" },
            new Guia { Id=31, NroTracking="BUE-00000040", EstadoActual="Admitida", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Laura García",   Localidad="Mar del Plata", Categoria="XL", CdOrigen="CD Buenos Aires", CdDestino="CD Mar del Plata" },
};

        // ── Métodos ───────────────────────────────────────────

        // Devuelve los CDs destino disponibles desde el CD de sesión
        public List<CentroDistribucionEntidad> ObtenerDestinosDisponibles()
        {
            // Buscar en rutas las que tienen como origen el CD de sesión
            var idsDestino = new List<int>();
            foreach (var ruta in RutasEmpresaTransporteAlmacen.rutasEmpresaTransportes)
            {
                if (ruta.IdCDOrigen == IdCDOrigen && !idsDestino.Contains(ruta.IdCDDestino))
                    idsDestino.Add(ruta.IdCDDestino);
            }

            // Devolver los CDs que coincidan con esos IDs
            var resultado = new List<CentroDistribucionEntidad>();
            foreach (var cd in CentroDistribucionAlmacen.centroDistribucions)
            {
                if (idsDestino.Contains(cd.IdCD))
                    resultado.Add(cd);
            }
            return resultado;
        }

        // Devuelve las empresas que cubren el tramo origen → destino
        public List<EmpresaTransporte> ObtenerEmpresasPorTramo(int idCDDestino)
        {
            // Buscar en rutas las que coincidan con origen y destino
            var idsEmpresa = new List<int>();
            foreach (var ruta in RutasEmpresaTransporteAlmacen.rutasEmpresaTransportes)
            {
                if (ruta.IdCDOrigen == IdCDOrigen && ruta.IdCDDestino == idCDDestino)
                    idsEmpresa.Add(ruta.IdEmpresaTransporte);
            }

            // Devolver las empresas que coincidan con esos IDs
            var resultado = new List<EmpresaTransporte>();
            foreach (var emp in EmpresaTransporteAlmacen.empresaTransportes)
            {
                if (idsEmpresa.Contains(emp.IdEmpresaTransporte))
                {
                    resultado.Add(new EmpresaTransporte
                    {
                        IdEmpresaTransporte = emp.IdEmpresaTransporte,
                        NombreEmpresa = emp.NombreEmpresa,
                        TipoArrendamiento = emp.TipoArrendamiento
                    });
                }
            }
            return resultado;
        }

        // Devuelve las guías admitidas para un CD destino
        public List<Guia> ObtenerGuiasPorCDDestino(string nombreCDDestino)
        {
            var resultado = new List<Guia>();
            foreach (var g in guias)
            {
                if (g.CdDestino == nombreCDDestino && g.EstadoActual == "Admitida")
                    resultado.Add(g);
            }
            return resultado;
        }

        // Devuelve el límite en XL equivalente según el tipo de arrendamiento
        public decimal ObtenerLimiteXL(TipoArrendamientoEnum tipo)
        {
            switch (tipo)
            {
                case TipoArrendamientoEnum.D: return 3m;
                case TipoArrendamientoEnum.C: return 7m;
                case TipoArrendamientoEnum.B: return 10m;
                case TipoArrendamientoEnum.A: return 20m;
                default: return 0m;
            }
        }

        // Calcula la equivalencia en XL de una lista de guías
        public decimal CalcularEquivalenciaXL(List<Guia> guiasACalcular)
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
            return totalXL;
        }

        // Verifica si agregar una guía supera el límite del tipo de arrendamiento
        public bool SuperaLimite(Guia guiaAAgregar, TipoArrendamientoEnum tipoArrendamiento)
        {
            decimal equivalenciaNueva = 0;
            switch (guiaAAgregar.Categoria)
            {
                case "S": equivalenciaNueva = 0.125m; break;
                case "M": equivalenciaNueva = 0.25m; break;
                case "L": equivalenciaNueva = 0.5m; break;
                case "XL": equivalenciaNueva = 1m; break;
            }

            decimal totalActual = CalcularEquivalenciaXL(GuiasSeleccionadas);
            decimal limite = ObtenerLimiteXL(tipoArrendamiento);

            return (totalActual + equivalenciaNueva) > limite;
        }

        // Guarda la HDR de transporte con fecha, estado y guías seleccionadas
        public void GuardarHDR(EmpresaTransporte empresa, int idCDDestino)
        {
            var idsGuias = new List<int>();
            foreach (var g in GuiasSeleccionadas)
                idsGuias.Add(g.Id);

            HDRTransporte nuevaHDR = new HDRTransporte
            {
                IdHDRdeTransporte = hdrsTransporte.Count + 1,
                IdCDOrigen = IdCDOrigen,
                IdCDDestino = idCDDestino,
                IdEmpresaTransporte = empresa.IdEmpresaTransporte,
                Fecha = DateTime.Now,
                EstadoHDR = EstadoHDRTransporteEnum.Pendiente,
                DetalleDiscrepancias = "",
                GuiasDespachadas = idsGuias
            };

            hdrsTransporte.Add(nuevaHDR);

            // Persistir en el almacén JSON
            HDRTransporteAlmacen.hDRTransportes.Add(new HDRTransporteEntidad
            {
                IdHDRdeTransporte = nuevaHDR.IdHDRdeTransporte,
                IdCDOrigen = nuevaHDR.IdCDOrigen,
                IdCDDestino = nuevaHDR.IdCDDestino,
                IdEmpresaTransporte = nuevaHDR.IdEmpresaTransporte,
                Fecha = nuevaHDR.Fecha,
                EstadoHDR = nuevaHDR.EstadoHDR,
                DetalleDiscrepancias = nuevaHDR.DetalleDiscrepancias,
                GuiasDespachadas = nuevaHDR.GuiasDespachadas
            });
            HDRTransporteAlmacen.Guardar();
            

            // Actualizar estado de las guías
            foreach (var g in GuiasSeleccionadas)
                g.EstadoActual = "HDR Transporte Confeccionada";

            GuiasSeleccionadas.Clear();
        }
    }
}