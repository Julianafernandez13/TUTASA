using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public class CtaCteClienteEntidad
    {
        public int IdMovimientoCliente { get; set; }
        public int IdCliente { get; set; }
        public int IdGuia { get; set; }
        public bool Facturado { get; set; }
        public decimal Importe { get; set; }
        public DateTime FechaMovimiento { get; set; }
    }
}
