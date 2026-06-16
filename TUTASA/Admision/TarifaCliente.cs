using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Enums;

namespace TUTASA.Admision
{
    internal class TarifaCliente
    {
        public int IdTarifaCliente { get; set; }
        public CategoriaBulto CategoriaBulto { get; set; }
        public int IdCDOrigen { get; set; }
        public int IdCDDestino { get; set; }
        public int PrecioBase { get; set; }
        public DateTime FechaVigencia { get; set; }
    }
}
