using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Enums
{
    internal enum EstadoGuia
    {
        Impuesta,
        ImpuestaPendienteDeRetiro,
        PreAdmitida,
        Retirada,
        Admitida,
        Despachada,
        Trasladada,
        DisponibleParaRetiro,
        PendienteDeDistribucion,
        IntentoDeEntregaFallido,
        Cancelada,
        CanceladaConDevolucion,
        Entregada
    }
}
