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
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TUTASA.Forms.CallCenter.ImposicionCallCenter());
           
            //antes de que finalice el programa, guardar todos los datos en almacenes
            AgenciaAlmacen.Guardar();
            CentroDistribucionAlmacen.Guardar();
            ClienteAlmacen.Guardar();
            CodigoPostalAlmacen.Guardar();
            GuiaAlmacen.Guardar();
            
            //etc...
        }
    }
}
