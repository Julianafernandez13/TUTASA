using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Admision
{
    internal class Guia
    {
        public int Id { get; set; }
        public string NroTracking { get; set; }
        public string EstadoActual { get; set; }
        public string NombreRemitente { get; set; }
        public string NombreDestinatario { get; set; }
        public string DomicilioEntrega { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }
        public string Categoria { get; set; }
        public string TipoEntrega { get; set; }
        public decimal TarifaEstimativa { get; set; }
        public decimal TarifaDefinitiva { get; set; }
        public string CdOrigen { get; set; }
        public string CdDestino { get; set; }
    }
}
