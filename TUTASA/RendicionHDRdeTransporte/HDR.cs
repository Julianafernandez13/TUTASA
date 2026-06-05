using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.RendicionHDRdeTransporte
{
    internal class HDR
    {
        public int Id { get; set; }
        public string NroHDR { get; set; }
        public string CdOrigen { get; set; }
        public string CdDestino { get; set; }
        public int CantBultos { get; set; }
        public string EstadoActual { get; set; }
        public int IdEmpresaTransporte { get; set; }
        public List<Guia> Guias { get; set; }
    }
}
