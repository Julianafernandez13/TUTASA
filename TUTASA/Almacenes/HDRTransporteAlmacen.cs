using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class HDRTransporteAlmacen
    {
        public static List<HDRTransporteEntidad> hDRTransportes = new List<HDRTransporteEntidad>();

        static HDRTransporteAlmacen()
        {
            if (File.Exists("hdr_transporte.json"))
            {
                string json = File.ReadAllText("hdr_transporte.json");
                hDRTransportes = JsonSerializer.Deserialize<List<HDRTransporteEntidad>>(json);
            }
        }

        public static List<HDRTransporteEntidad> ObtenerTodos()
        {
            return hDRTransportes;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(hDRTransportes);
            File.WriteAllText("hdr_transporte.json", json);
        }
    }
}
