using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class EmpresaTransporteAlmacen
    {
        public static List<EmpresaTransporteEntidad> empresaTransportes = new List<EmpresaTransporteEntidad>();

        static EmpresaTransporteAlmacen()
        {
            if (File.Exists(@"datos\empresas_transporte.json"))
            {
                string json = File.ReadAllText(@"datos\empresas_transporte.json");
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
            File.WriteAllText(@"datos\empresas_transporte.json", json);
        }
    }
}
