using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class CtaCteEmpresaTransporteAlmacen
    {
        public static List<CtaCteEmpresaTransporteEntidad> ctaCteEmpresaTransportes = new List<CtaCteEmpresaTransporteEntidad>();

        static CtaCteEmpresaTransporteAlmacen()
        {
            if (File.Exists("cta_cte_empresa_transporte.json"))
            {
                string json = File.ReadAllText("cta_cte_empresa_transporte.json");
                ctaCteEmpresaTransportes = JsonSerializer.Deserialize<List<CtaCteEmpresaTransporteEntidad>>(json);
            }
        }

        public static List<CtaCteEmpresaTransporteEntidad> ObtenerTodos()
        {
            return ctaCteEmpresaTransportes;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(ctaCteEmpresaTransportes);
            File.WriteAllText("cta_cte_empresa_transporte.json", json);
        }
    }
}
