using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.Almacenes;

namespace TUTASA
{
    internal static class Program
    {
        public static int CdActivoId { get; set; } = 0;
        public static int AgenciaActivaId { get; set; } = 0;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TUTASA.Forms.Menu.frmMenuPrincipal()); 

            //antes de que finalice el programa, guardar todos los datos en almacenes
            AgenciaAlmacen.Guardar();
            CentroDistribucionAlmacen.Guardar();
            ClienteAlmacen.Guardar();
            CodigoPostalAlmacen.Guardar();
            ComisionAgenciaAlmacen.Guardar();
            ComisionFleteroAlmacen.Guardar();
            CtaCteAgenciaAlmacen.Guardar();
            CtaCteClienteAlmacen.Guardar();
            CtaCteEmpresaTransporteAlmacen.Guardar();
            CtaCteFleteroAlmacen.Guardar();
            EmpresaTransporteAlmacen.Guardar();
            ExtrasAlmacen.Guardar();
            FacturaAlmacen.Guardar();
            FleteroAlmacen.Guardar();
            GuiaAlmacen.Guardar();
            HDREntregaAlmacen.Guardar();
            HDRRetiroAlmacen.Guardar();
            HDRTransporteAlmacen.Guardar();
            RutasEmpresaTransporteAlmacen.Guardar();
            TarifaArrendamientoAlmacen.Guardar();
            TarifaClienteAlmacen.Guardar();

        }
    }
}
