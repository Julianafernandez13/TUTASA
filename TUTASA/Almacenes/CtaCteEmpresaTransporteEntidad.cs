using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public class CtaCteEmpresaTransporteEntidad
    {
        public int IdMovimientoTransporte { get; set; }
        public int IdEmpresaTransporte { get; set; }
        public long IdHDRdeTransporte { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public decimal Importe { get; set; }
        public bool Pagado { get; set; }
    }
}
