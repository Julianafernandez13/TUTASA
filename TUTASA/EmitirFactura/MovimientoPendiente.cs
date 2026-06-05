using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.EmitirFactura
{
    internal class MovimientoPendiente
    {
        public string NroGuia { get; set; }
        public DateTime Fecha { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Categoria { get; set; }
        public decimal ImporteNeto { get; set; }
        public bool Facturado { get; set; }
        public int IdCliente { get; set; }
    }
}
