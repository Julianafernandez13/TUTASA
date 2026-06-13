using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class GuiaAlmacen
    {
        public static List<GuiaEntidad> guias = new List<GuiaEntidad>();

        static GuiaAlmacen()
        {
            if (File.Exists("guias.json"))
            {
                string json = File.ReadAllText("guias.json");
                guias = JsonSerializer.Deserialize<List<GuiaEntidad>>(json);
            }
        }

        public static List<GuiaEntidad> ObtenerTodos()
        {
            return guias;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(guias);
            File.WriteAllText("guias.json", json);
        }
    }
}
