using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class TarifaClienteAlmacen
    {
        public static List<TarifaClienteEntidad> tarifaClientes = new List<TarifaClienteEntidad>();

        static TarifaClienteAlmacen()
        {
            if (File.Exists(@"datos\tarifas_cliente.json"))
            {
                string json = File.ReadAllText(@"datos\tarifas_cliente.json");
                tarifaClientes = JsonSerializer.Deserialize<List<TarifaClienteEntidad>>(json);
            }
        }

        public static List<TarifaClienteEntidad> ObtenerTodos()
        {
            return tarifaClientes;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(tarifaClientes);
            File.WriteAllText(@"datos\tarifas_cliente.json", json);
        }
    }
}
