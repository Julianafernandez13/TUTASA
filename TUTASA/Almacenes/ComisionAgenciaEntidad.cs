using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public class ComisionAgenciaEntidad
    {
        public int IdComisionAgencia { get; set; }
        public CategoriaBultoEnum CategoriaBulto { get; set; }
        public int MontoComision { get; set; }
        public DateTime FechaVigencia { get; set; }
    }
}
