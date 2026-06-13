using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class FleteroAlmacen
    {
        public static List<FleteroEntidad> fleteros = new List<FleteroEntidad>();

        static FleteroAlmacen()
        {
            if (File.Exists(@"datos\fleteros.json"))
            {
                string json = File.ReadAllText(@"datos\fleteros.json");
                fleteros = JsonSerializer.Deserialize<List<FleteroEntidad>>(json);
            }
        }

        public static List<FleteroEntidad> ObtenerTodos()
        {
            return fleteros;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(fleteros);
            File.WriteAllText(@"datos\fleteros.json", json);
        }
    }
}
