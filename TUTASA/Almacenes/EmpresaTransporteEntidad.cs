using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public class EmpresaTransporteEntidad
    {
        public int IdEmpresaTransporte { get; set; }
        public string NombreEmpresa { get; set; }
        public TipoArrendamientoEnum TipoArrendamiento { get; set; }
    }
}