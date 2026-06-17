using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.RendicionHDRdeUltMilla
{
    internal class HDR
    {
        public int Id { get; set; }
        public string NroHDR { get; set; }
        public string Cliente { get; set; }
        public string Localidad { get; set; }
        public string Direccion { get; set; }
        public string Entrega { get; set; }
        public string Estado { get; set; }
        public string TipoHDR { get; set; }
        public int IdFletero { get; set; }
    }
}
