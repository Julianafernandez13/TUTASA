using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.ImposicionAgencia
{
    internal class ImposicionAgenciaModelo
    {
        internal List<Agencias> ObtenerAgencias()
        {
            return new List<Agencias>()
            {
                new Agencias { idAgencia = 1, nombreAgencia = "Agencia La Plata Centro", CodigoPostal = "1900" },
                new Agencias { idAgencia = 2, nombreAgencia = "Agencia La Plata Norte",  CodigoPostal = "1900" },
                new Agencias { idAgencia = 3, nombreAgencia = "Agencia Quilmes",         CodigoPostal = "1800" },
                new Agencias { idAgencia = 4, nombreAgencia = "Agencia Morón",           CodigoPostal = "1700" },
                new Agencias { idAgencia = 5, nombreAgencia = "Agencia CABA Centro",     CodigoPostal = "1000" },
                new Agencias { idAgencia = 6, nombreAgencia = "Agencia Córdoba",         CodigoPostal = "5000" },
            };

        }

        internal List<CentrosDeDistribucion> ObtenerCentrosDeDistribucion()
        {
            return new List<CentrosDeDistribucion>();
            {
                new CentrosDeDistribucion
                {
                    idCD = 1,
                    nombreCD = "CD Gran Buenos Aires",
                    CodigosPostales = new List<string> { "1900", "1800", "1700" }
                };
                new CentrosDeDistribucion
                {
                    idCD = 2,
                    nombreCD = "CD CABA",
                    CodigosPostales = new List<string> { "1000" }
                };
                new CentrosDeDistribucion
                {
                    idCD = 3,
                    nombreCD = "CD Centro",
                    CodigosPostales = new List<string> { "5000", "1900" } // 1900 cae en dos CDs
                };
            };
        }

        internal List<CodigoPostal> ObtenerCodigosPostales()
        {
            return new List<CodigoPostal>()
            {
                new CodigoPostal { idCodPostal = "1900", DescripcionLocalidad = "La Plata", DescripcionProvincia = "Buenos Aires" },
                new CodigoPostal { idCodPostal = "1800", DescripcionLocalidad = "Quilmes", DescripcionProvincia = "Buenos Aires" },
                new CodigoPostal { idCodPostal = "1700", DescripcionLocalidad = "Morón", DescripcionProvincia = "Buenos Aires" },
                new CodigoPostal { idCodPostal = "1000", DescripcionLocalidad = "Buenos Aires", DescripcionProvincia = "CABA" },
                new CodigoPostal { idCodPostal = "5000", DescripcionLocalidad = "Córdoba", DescripcionProvincia = "Córdoba" },
            };
            
        }
    }
}
