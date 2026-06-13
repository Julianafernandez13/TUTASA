using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public class HDREntregaEntidad
    {
        public long IdHDRdeEntrega { get; set; }
        public int IdFletero { get; set; }
        public DateTime FechaEmisionHDR { get; set; }
        public EstadoHDRUltimaMillaEnum EstadoHDR { get; set; }
        public List<int> GuiasEntrega { get; set; } = new List<int>();
    }
}
