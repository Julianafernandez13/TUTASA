using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class HDREntregaAlmacen
    {
        private static List<HDREntregaEntidad> hDREntregas = new List<HDREntregaEntidad>();

        static HDREntregaAlmacen()
        {
            if (File.Exists("hdr_entrega.json"))
            {
                string json = File.ReadAllText("hdr_entrega.json");
                hDREntregas = JsonSerializer.Deserialize<List<HDREntregaEntidad>>(json);
            }
        }

        public static List<HDREntregaEntidad> ObtenerTodos()
        {
            return hDREntregas;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(hDREntregas);
            File.WriteAllText("hdr_entrega.json", json);
        }
    }
}
