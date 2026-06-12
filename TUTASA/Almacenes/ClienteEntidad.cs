using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal class ClienteEntidad
    {
        public class ClienteEntidad
        {
            public int IdCliente { get; set; }
            public long CuitCliente { get; set; }
            public string NombreCliente { get; set; }
            public string ApellidoCliente { get; set; }
            public string DomicilioCliente { get; set; }
            public long TelefonoCliente { get; set; }
            public TipoFacturaEnum TipoFactura { get; set; }
        }
    }
}
