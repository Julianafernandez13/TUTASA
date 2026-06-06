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
        PreAdmitida,
        Retirada,
        Cancelada,
        Admitida,
        Despachada,
        Trasladada,
        DisponibleParaRetiro,
        PendienteDeDistribucion,
        IntentoDeEntregaFallido,
        CanceladaConDevolucion,
        Entregada
    }
}
