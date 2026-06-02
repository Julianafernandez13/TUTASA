using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Admision
{
    internal class AdmisionModelo
    {
        public List<Categoria> Categorias
        {
            get
            {
                return new List<Categoria>
                {
                    new Categoria { Id = 1, Descripcion = "S" },
                    new Categoria { Id = 2, Descripcion = "M" },
                    new Categoria { Id = 3, Descripcion = "L" },
                    new Categoria { Id = 4, Descripcion = "XL" }
                };
            }
        }
    }
}