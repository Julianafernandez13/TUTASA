using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class HDREntregaAlmacen
    {
        public static List<HDREntregaEntidad> hDREntregas = new List<HDREntregaEntidad>();

        static HDREntregaAlmacen()
        {
            if (File.Exists(@"datos\hdr_entrega.json"))
            {
                string json = File.ReadAllText(@"datos\hdr_entrega.json");
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
            File.WriteAllText(@"datos\hdr_entrega.json", json);
        }
    }
}
