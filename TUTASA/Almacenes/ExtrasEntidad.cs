using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public class ExtrasEntidad
    {
        public int IdExtras { get; set; }
        public decimal ExtraRetiroDomicilio { get; set; }
        public decimal ExtraEntregaAgencia { get; set; }
        public decimal ExtraEntregaDomicilio { get; set; }
        public DateTime FechaVigencia { get; set; }
    }
}
