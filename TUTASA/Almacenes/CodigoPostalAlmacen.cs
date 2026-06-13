using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class CodigoPostalAlmacen
    {
        public static List<CodigoPostalEntidad> codigoPostals = new List<CodigoPostalEntidad>();

        static CodigoPostalAlmacen()
        {
            if (File.Exists(@"datos\codigos_postales.json"))
            {
                string json = File.ReadAllText(@"datos\codigos_postales.json");
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
            File.WriteAllText(@"datos\codigos_postales.json", json);
        }
    }
}
