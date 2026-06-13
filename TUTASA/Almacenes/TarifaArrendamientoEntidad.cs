using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public class TarifaArrendamientoEntidad
    {
        public int IdTarifaArrendamiento { get; set; }
        public TipoArrendamientoEnum TipoArrendamiento { get; set; }
        public decimal MontoArrendamiento { get; set; }
        public DateTime FechaVigencia { get; set; }
    }
}
