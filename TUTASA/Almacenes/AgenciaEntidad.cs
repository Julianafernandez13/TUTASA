using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public class AgenciaEntidad
    {
        public int IdAgencia { get; set; }
        public int IdCD { get; set; }
        public string NombreAgencia { get; set; }
        public string IdCodPostal { get; set; }
        public string DomicilioAgencia { get; set; }
        public long TelefonoAgencia { get; set; }
    }
}
