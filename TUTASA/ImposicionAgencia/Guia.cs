using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Enums;

namespace TUTASA.ImposicionAgencia
{
    internal class Guia
    {
        public long idGuia { get; set; }
        public CategoriaBulto Categoria { get; set; }
        public Cliente Remitente { get; set; }
        public Destinatario Destinatario { get; set; }
        public EstadoGuia Estado { get; set; }
        
    }
}
