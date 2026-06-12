using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public class CtaCteAgenciaEntidad
    {
        public int IdMovimientoAgencia { get; set; }
        public int IdAgencia { get; set; }
        public int IdGuia { get; set; }
        public bool Pagado { get; set; }
        public decimal Importe { get; set; }
        public DateTime FechaMovimiento { get; set; }
    }
}
