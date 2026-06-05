using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.RendicionHDRdeTransporte
{
    internal class Guia
    {
        public int Id { get; set; }
        public string NroTracking { get; set; }
        public string EstadoActual { get; set; }
        public string NombreRemitente { get; set; }
        public string NombreDestinatario { get; set; }
        public string Categoria { get; set; }
    }
}
