using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class FacturaAlmacen
    {
        public static List<FacturaEntidad> facturas = new List<FacturaEntidad>();

        static FacturaAlmacen()
        {
            if (File.Exists("facturas.json"))
            {
                string json = File.ReadAllText("facturas.json");
                facturas = JsonSerializer.Deserialize<List<FacturaEntidad>>(json);
            }
        }

        public static List<FacturaEntidad> ObtenerTodos()
        {
            return facturas;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(facturas);
            File.WriteAllText("facturas.json", json);
        }
    }
}
