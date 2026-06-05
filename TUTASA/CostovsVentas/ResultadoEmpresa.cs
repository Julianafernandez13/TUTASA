using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.CostovsVentas
{
    internal class ResultadoEmpresa
    {
        public string Empresa { get; set; }
        public string Clasificacion { get; set; }
        public decimal Ingresos { get; set; }
        public decimal Costos { get; set; }
        public decimal MargenNeto => Ingresos - Costos;

    }
}
