using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.ConfeccionHDRdeUltMilla
{
    internal class HDREntrega
    {
        public int Id { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Estado { get; set; }
        public int IdFletero { get; set; }
        public List<Guia> Guias { get; set; }
    }
}
