using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.RegistrarEntrega
{
    internal class GuiaEntrega
    {
        public int Id { get; set; }
        public string NroTracking { get; set; }
        public string Categoria { get; set; }
        public string NombreCliente { get; set; }
        public string NombreDestinatario { get; set; }
    }
}