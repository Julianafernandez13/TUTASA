using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.ConfeccionHDRdeTransporte
{
    internal class HDRTransporte
    {
        public int Id { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Estado { get; set; }
        public int IdEmpresaTransporte { get; set; }
        public string TipoArrendamiento { get; set; }
        public List<Guia> Guias { get; set; }
    }
}
