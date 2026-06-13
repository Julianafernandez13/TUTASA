using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class FleteroAlmacen
    {
        public static List<FleteroEntidad> fleteros = new List<FleteroEntidad>();

        static FleteroAlmacen()
        {
            if (File.Exists("fleteros.json"))
            {
                string json = File.ReadAllText("fleteros.json");
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
            File.WriteAllText("fleteros.json", json);
        }
    }
}
