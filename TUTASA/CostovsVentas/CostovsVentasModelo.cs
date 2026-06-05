using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.CostovsVentas
{
    internal class CostovsVentasModelo
    {
        private List<(int Id, string Nombre, string Clasificacion)> empresas =
           new List<(int, string, string)>
           {
                (1, "Fletes del Norte S.A.",   "A"),
                (2, "TransSur Logística SRL",  "B"),
                (3, "El Rápido Cargas",        "C"),
                (4, "Transporte Litoral S.A.", "D"),
           };

        private List<(int Id, int IdEmpresa, int Mes, int Anio, decimal Costo)> hdrs =
            new List<(int, int, int, int, decimal)>
            {
                (1, 1, 4, 2026, 85000m),
                (2, 1, 4, 2026, 42500m),
                (3, 1, 5, 2026, 85000m),
                (4, 2, 4, 2026, 60000m),
                (5, 2, 5, 2026, 30000m),
                (6, 3, 4, 2026, 40000m),
                (7, 3, 5, 2026, 40000m),
                (8, 4, 5, 2026, 18000m),
            };

        private List<(int IdHdr, string NroGuia, decimal Tarifa)> guias =
            new List<(int, string, decimal)>
            {
                (1, "G-001", 12500m), (1, "G-002", 8000m),  (1, "G-003", 15000m),
                (1, "G-004", 9500m),  (1, "G-005", 11000m),
                (2, "G-006", 7200m),  (2, "G-007", 6800m),
                (3, "G-008", 13000m), (3, "G-009", 9000m),  (3, "G-010", 11500m),
                (3, "G-011", 8800m),
                (4, "G-012", 18000m), (4, "G-013", 14000m), (4, "G-014", 16500m),
                (5, "G-015", 9500m),  (5, "G-016", 8200m),
                (6, "G-017", 22000m), (6, "G-018", 19000m),
                (7, "G-019", 17500m), (7, "G-020", 14800m), (7, "G-021", 12200m),
                (8, "G-022", 6500m),  (8, "G-023", 5800m),
            };

        public List<string> ObtenerEmpresas()
        {
            var lista = new List<string>();
            foreach (var e in empresas)
                lista.Add(e.Nombre);
            return lista;
        }

        public List<ResultadoEmpresa> GenerarReporte(int mes, int anio, string empresaSeleccionada)
        {
            var hdrsPeriodo = hdrs.Where(h => h.Mes == mes && h.Anio == anio).ToList();

            if (empresaSeleccionada != "Todas")
            {
                var emp = empresas.FirstOrDefault(e => e.Nombre == empresaSeleccionada);
                hdrsPeriodo = hdrsPeriodo.Where(h => h.IdEmpresa == emp.Id).ToList();
            }

            var resultados = new List<ResultadoEmpresa>();

            foreach (int idEmp in hdrsPeriodo.Select(h => h.IdEmpresa).Distinct())
            {
                var empData = empresas.First(e => e.Id == idEmp);
                var hdrsEmp = hdrsPeriodo.Where(h => h.IdEmpresa == idEmp).ToList();
                decimal costos = hdrsEmp.Sum(h => h.Costo);
                decimal ingresos = hdrsEmp.Sum(h =>
                    guias.Where(g => g.IdHdr == h.Id).Sum(g => g.Tarifa));

                resultados.Add(new ResultadoEmpresa
                {
                    Empresa = empData.Nombre,
                    Clasificacion = empData.Clasificacion,
                    Ingresos = ingresos,
                    Costos = costos
                });
            }

            return resultados;
        }

    }

}

