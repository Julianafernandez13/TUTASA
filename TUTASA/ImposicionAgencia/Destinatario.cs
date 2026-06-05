using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.ImposicionAgencia
{
    internal class Destinatario
    {
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public TipoEntrega TipoEntrega { get; set; }

        // Solo si TipoEntrega == Domicilio
        public string DomicilioEntrega { get; set; }
        public string CodigoPostal { get; set; }

        // Solo si TipoEntrega == Agencia
        public Agencias AgenciaDestino { get; set; }

        // Solo si TipoEntrega == CD
        public CentrosDeDistribucion CDDestino { get; set; }

    }
}
