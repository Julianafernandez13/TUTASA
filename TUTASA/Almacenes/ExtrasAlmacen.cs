using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class ExtrasAlmacen
    {
        public static List<ExtrasEntidad> extrass = new List<ExtrasEntidad>();

        static ExtrasAlmacen()
        {
            if (File.Exists("extras.json"))
            {
                string json = File.ReadAllText("extras.json");
                extrass = JsonSerializer.Deserialize<List<ExtrasEntidad>>(json);
            }
        }

        public static List<ExtrasEntidad> ObtenerTodos()
        {
            return extrass;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(extrass);
            File.WriteAllText("extras.json", json);
        }
    }
}
