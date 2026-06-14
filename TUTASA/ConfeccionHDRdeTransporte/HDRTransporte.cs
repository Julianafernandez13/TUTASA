using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Almacenes;

namespace TUTASA.ConfeccionHDRdeTransporte
{
    internal class HDRTransporte
    {
        public long IdHDRdeTransporte { get; set; }
        public int IdCDOrigen { get; set; }
        public int IdCDDestino { get; set; }
        public int IdEmpresaTransporte { get; set; }
        public DateTime Fecha { get; set; }
        public EstadoHDRTransporteEnum EstadoHDR { get; set; }
        public string DetalleDiscrepancias { get; set; }
        public List<int> GuiasDespachadas { get; set; } = new List<int>();
    }
}
