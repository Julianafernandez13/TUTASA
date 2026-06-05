using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Admision;

namespace TUTASA.RegistrarEntrega
{
    internal class Receptor
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string NombreCompleto { get; set; }
        public List<Guia> Guias { get; set; } = new List<Guia>();
    }
}
