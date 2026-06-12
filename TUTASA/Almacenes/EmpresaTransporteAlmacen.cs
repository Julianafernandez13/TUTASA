using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class EmpresaTransporteAlmacen
    {
        private static List<EmpresaTransporteEntidad> empresaTransportes = new List<EmpresaTransporteEntidad>();

        static EmpresaTransporteAlmacen()
        {
            if (File.Exists("empresas_transporte.json"))
            {
                string json = File.ReadAllText("empresas_transporte.json");
                empresaTransportes = JsonSerializer.Deserialize<List<EmpresaTransporteEntidad>>(json);
            }
        }

        public static List<EmpresaTransporteEntidad> ObtenerTodos()
        {
            return empresaTransportes;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(empresaTransportes);
            File.WriteAllText("empresas_transporte.json", json);
        }
    }
}
