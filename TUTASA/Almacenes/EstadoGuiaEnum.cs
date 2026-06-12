using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    public enum EstadoGuiaEnum
    {
        Impuesta,
        DisponibleParaRetiro,
        IncluidaEnHDRRetiro,
        PendienteDeRetiro,
        PreAdmitida,
        Admitida,
        IncluidaEnHDRTransporte,
        PendienteDeDistribucion,
        IncluidaEnHDREntrega,
        IntentoDeEntregaFallido,
        DisponibleParaEntrega,
        Devolucion,
        Cancelada,
        Entregada
    }
}
