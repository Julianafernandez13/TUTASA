using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class CtaCteClienteAlmacen
    {
        public static List<CtaCteClienteEntidad> ctaCteClientes = new List<CtaCteClienteEntidad>();

        static CtaCteClienteAlmacen()
        {
            if (File.Exists("cta_cte_cliente.json"))
            {
                string json = File.ReadAllText("cta_cte_cliente.json");
                ctaCteClientes = JsonSerializer.Deserialize<List<CtaCteClienteEntidad>>(json);
            }
        }

        public static List<CtaCteClienteEntidad> ObtenerTodos()
        {
            return ctaCteClientes;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(ctaCteClientes);
            File.WriteAllText("cta_cte_cliente.json", json);
        }
    }
}
