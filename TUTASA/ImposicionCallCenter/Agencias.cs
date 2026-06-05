using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.ImposicionCallCenter
{
    internal class Agencias
    {
        public int idAgencia { get; set; }
        public string nombreAgencia { get; set; }
        // Relación: la agencia pertenece a una localidad identificada por el código postal
        public string CodigoPostal { get; set; }
    }
}
