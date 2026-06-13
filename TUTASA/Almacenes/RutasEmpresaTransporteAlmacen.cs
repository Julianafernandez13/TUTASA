using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class RutasEmpresaTransporteAlmacen
    {
        public static List<RutasEmpresaTransporte> rutasEmpresaTransportes = new List<RutasEmpresaTransporte>();

        static RutasEmpresaTransporteAlmacen()
        {
            if (File.Exists("rutas_empresa_transporte.json"))
            {
                string json = File.ReadAllText("rutas_empresa_transporte.json");
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
            File.WriteAllText("rutas_empresa_transporte.json", json);
        }
    }
}
