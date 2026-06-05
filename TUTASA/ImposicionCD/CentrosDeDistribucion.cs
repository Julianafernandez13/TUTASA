using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.ImposicionCD
{
    internal class CentrosDeDistribucion
    {
        public int idCD { get; set; }
        public string nombreCD { get; set; }

        // Lista de códigos postales bajo la jurisdicción de este CD
        public List<string> CodigosPostales { get; set; } = new List<string>();
    }
}
