using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class CentroDistribucionAlmacen
    {
        private static List<CentroDistribucionEntidad> centroDistribucions = new List<CentroDistribucionEntidad>();

        static CentroDistribucionAlmacen()
        {
            if (File.Exists("centros_distribucion.json"))
            {
                string json = File.ReadAllText("centros_distribucion.json");
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
            File.WriteAllText("centros_distribucion.json", json);
        }
    }
}
