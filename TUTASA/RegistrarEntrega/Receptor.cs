using System.Collections.Generic;

namespace TUTASA.RegistrarEntrega
{
    internal class Receptor
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string NombreCompleto { get; set; }
        public List<GuiaEntrega> Guias { get; set; } = new List<GuiaEntrega>();
    }
}