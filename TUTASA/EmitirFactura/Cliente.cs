using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.EmitirFactura
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string CUIT { get; set; }
        public string CondicionIVA { get; set; }
    }
}
