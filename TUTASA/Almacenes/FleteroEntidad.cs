using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public class FleteroEntidad
    {
        public int IdFletero { get; set; }
        public long DniFletero { get; set; }
        public string NombreFletero { get; set; }
        public string ApellidoFletero { get; set; }
        public List<string> IdCodPostal { get; set; } = new List<string>();
    }
}
