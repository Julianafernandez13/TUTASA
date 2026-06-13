using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class TarifaArrendamientoAlmacen
    {
        private static List<TarifaArrendamientoEntidad> tarifaArrendamientos = new List<TarifaArrendamientoEntidad>();

        static TarifaArrendamientoAlmacen()
        {
            if (File.Exists("tarifas_arrendamiento.json"))
            {
                string json = File.ReadAllText("tarifas_arrendamiento.json");
                tarifaArrendamientos = JsonSerializer.Deserialize<List<TarifaArrendamientoEntidad>>(json);
            }
        }

        public static List<TarifaArrendamientoEntidad> ObtenerTodos()
        {
            return tarifaArrendamientos;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(tarifaArrendamientos);
            File.WriteAllText("tarifas_arrendamiento.json", json);
        }
    }
}
