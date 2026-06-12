using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public class CentroDistribucionEntidad
    {
        public int IdCD { get; set; }
        public List<string> IdCodPostal { get; set; } = new List<string>();
        public string NombreCD { get; set; }
        public string DomicilioCD { get; set; }
        public decimal CapacidadAlmacenamiento { get; set; }
    }
}
