using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public class GuiaEntidad
    {
        public int IdGuia { get; set; }
        public string NroTracking { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaImposicion { get; set; }
        public TipoEntregaEnum TipoEntrega { get; set; }
        public int IdAgenciaOrigen { get; set; }
        public int IdCDOrigen { get; set; }
        public CategoriaBultoEnum CategoriaBulto { get; set; }
        public int RemDni { get; set; }
        public string RemDomicilioRetiro { get; set; }
        public string RemCodPostal { get; set; }
        public long DniDestinatario { get; set; }
        public string NombreApellidoDestinatario { get; set; }
        public long TelefonoDestinatario { get; set; }
        public string DomicilioEntrega { get; set; }
        public string DomicilioEntregaCodPostal { get; set; }
        public int IdAgenciaDestino { get; set; }
        public int IdCDDestino { get; set; }
        public int IdTarifaCliente { get; set; }
        public int IdExtras { get; set; }
        public bool TieneExtraRetiro { get; set; }
        public bool TieneExtraEntregaDomicilio { get; set; }
        public bool TieneExtraEntregaAgencia { get; set; }
        public int IdComisionAgencia { get; set; }
        public int IdComisionFletero { get; set; }
        public EstadoGuiaEnum EstadoGuia { get; set; }
        public List<HistorialGuia> Historial { get; set; } = new List<HistorialGuia>();
    }
}
