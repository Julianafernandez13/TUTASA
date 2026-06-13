using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class CentroDistribucionAlmacen
    {
        public static List<CentroDistribucionEntidad> centroDistribucions = new List<CentroDistribucionEntidad>();

        static CentroDistribucionAlmacen()
        {
            if (File.Exists(@"datos\centros_distribucion.json"))
            {
                string json = File.ReadAllText(@"datos\centros_distribucion.json");
                centroDistribucions = JsonSerializer.Deserialize<List<CentroDistribucionEntidad>>(json);
            }
        }

        public static List<CentroDistribucionEntidad> ObtenerTodos()
        {
            return centroDistribucions;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(centroDistribucions);
            File.WriteAllText(@"datos\centros_distribucion.json", json);
        }
    }
}
