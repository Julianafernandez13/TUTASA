using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class CodigoPostalAlmacen
    {
        public static List<CodigoPostalEntidad> codigoPostals = new List<CodigoPostalEntidad>();

        static CodigoPostalAlmacen()
        {
            if (File.Exists("codigos_postales.json"))
            {
                string json = File.ReadAllText("codigos_postales.json");
                codigoPostals = JsonSerializer.Deserialize<List<CodigoPostalEntidad>>(json);
            }
        }

        public static List<CodigoPostalEntidad> ObtenerTodos()
        {
            return codigoPostals;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(codigoPostals);
            File.WriteAllText("codigos_postales.json", json);
        }
    }
}
