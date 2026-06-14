using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TUTASA.Almacenes;

namespace TUTASA.ConfeccionHDRdeTransporte
{
    internal class EmpresaTransporte
        {
            public int IdEmpresaTransporte { get; set; }
            public string NombreEmpresa { get; set; }
            public TipoArrendamientoEnum TipoArrendamiento { get; set; }
        }
    
}
