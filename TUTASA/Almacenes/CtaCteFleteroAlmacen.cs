using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class CtaCteFleteroAlmacen
    {
        public static List<CtaCteFleteroEntidad> ctaCteFleteros = new List<CtaCteFleteroEntidad>();

        static CtaCteFleteroAlmacen()
        {
            if (File.Exists("cta_cte_fletero.json"))
            {
                string json = File.ReadAllText("cta_cte_fletero.json");
                ctaCteFleteros = JsonSerializer.Deserialize<List<CtaCteFleteroEntidad>>(json);
            }
        }

        public static List<CtaCteFleteroEntidad> ObtenerTodos()
        {
            return ctaCteFleteros;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(ctaCteFleteros);
            File.WriteAllText("cta_cte_fletero.json", json);
        }
    }
}
