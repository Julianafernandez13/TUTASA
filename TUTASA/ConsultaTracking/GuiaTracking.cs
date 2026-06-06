using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.ConsultaTracking
{
    internal class GuiaTracking
    {
        public int Id { get; set; }
        public string NroTracking { get; set; }
        public string EstadoActual { get; set; }
        public string Categoria { get; set; }
        public string CdOrigen { get; set; }
        public string CdDestino { get; set; }
        public string NombreRemitente { get; set; }
        public string NombreDestinatario { get; set; }
    }
}