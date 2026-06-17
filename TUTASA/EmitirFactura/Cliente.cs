using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Almacenes;

namespace TUTASA.EmitirFactura
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string CUIT { get; set; }
        public TipoFacturaEnum TipoFactura { get; set; }
    }
}
