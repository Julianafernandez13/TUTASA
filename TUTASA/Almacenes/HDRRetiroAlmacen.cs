using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class HDRRetiroAlmacen
    {
        public static List<HDRRetiroEntidad> hDRRetiros = new List<HDRRetiroEntidad>();

        static HDRRetiroAlmacen()
        {
            if (File.Exists(@"datos\hdr_retiro.json"))
            {
                string json = File.ReadAllText(@"datos\hdr_retiro.json");
                hDRRetiros = JsonSerializer.Deserialize<List<HDRRetiroEntidad>>(json);
            }
        }

        public static List<HDRRetiroEntidad> ObtenerTodos()
        {
            return hDRRetiros;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(hDRRetiros);
            File.WriteAllText(@"datos\hdr_retiro.json", json);
        }
    }
}
