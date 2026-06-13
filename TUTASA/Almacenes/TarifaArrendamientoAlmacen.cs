using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class TarifaArrendamientoAlmacen
    {
        public static List<TarifaArrendamientoEntidad> tarifaArrendamientos = new List<TarifaArrendamientoEntidad>();

        static TarifaArrendamientoAlmacen()
        {
            if (File.Exists(@"datos\tarifas_arrendamiento.json"))
            {
                string json = File.ReadAllText(@"datos\tarifas_arrendamiento.json");
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
            File.WriteAllText(@"datos\tarifas_arrendamiento.json", json);
        }
    }
}
