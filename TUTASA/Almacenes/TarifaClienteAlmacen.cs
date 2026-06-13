using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class TarifaClienteAlmacen
    {
        private static List<TarifaClienteEntidad> tarifaClientes = new List<TarifaClienteEntidad>();

        static TarifaClienteAlmacen()
        {
            if (File.Exists("tarifas_cliente.json"))
            {
                string json = File.ReadAllText("tarifas_cliente.json");
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
            File.WriteAllText("tarifas_cliente.json", json);
        }
    }
}
