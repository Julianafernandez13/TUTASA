using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class ComisionFleteroAlmacen
    {
        public static List<ComisionFleteroEntidad> comisionFleteros = new List<ComisionFleteroEntidad>();

        static ComisionFleteroAlmacen()
        {
            if (File.Exists("comisiones_fletero.json"))
            {
                string json = File.ReadAllText("comisiones_fletero.json");
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
            File.WriteAllText("comisiones_fletero.json", json);
        }
    }
}
