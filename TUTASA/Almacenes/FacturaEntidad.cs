using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public class FacturaEntidad
    {
        public long IdFactura { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaEmision { get; set; }
        public int CAE { get; set; }
        public TipoFacturaEnum TipoFactura { get; set; }
        public List<int> Movimientos { get; set; } = new List<int>();
    }
}
