using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class RutasEmpresaTransporteAlmacen
    {
        public static List<RutasEmpresaTransporte> rutasEmpresaTransportes = new List<RutasEmpresaTransporte>();

        static RutasEmpresaTransporteAlmacen()
        {
            if (File.Exists(@"datos\rutas_empresa_transporte.json"))
            {
                string json = File.ReadAllText(@"datos\rutas_empresa_transporte.json");
                rutasEmpresaTransportes = JsonSerializer.Deserialize<List<RutasEmpresaTransporte>>(json);
            }
        }

        public static List<RutasEmpresaTransporte> ObtenerTodos()
        {
            return rutasEmpresaTransportes;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(rutasEmpresaTransportes);
            File.WriteAllText(@"datos\rutas_empresa_transporte.json", json);
        }
    }
}
