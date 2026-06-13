using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class ComisionFleteroAlmacen
    {
        public static List<ComisionFleteroEntidad> comisionFleteros = new List<ComisionFleteroEntidad>();

        static ComisionFleteroAlmacen()
        {
            if (File.Exists(@"datos\comisiones_fletero.json"))
            {
                string json = File.ReadAllText(@"datos\comisiones_fletero.json");
                comisionFleteros = JsonSerializer.Deserialize<List<ComisionFleteroEntidad>>(json);
            }
        }

        public static List<ComisionFleteroEntidad> ObtenerTodos()
        {
            return comisionFleteros;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(comisionFleteros);
            File.WriteAllText(@"datos\comisiones_fletero.json", json);
        }
    }
}
