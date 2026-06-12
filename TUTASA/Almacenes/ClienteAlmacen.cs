using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class ClienteAlmacen
    {
        private static List<ClienteEntidad> clientes = new List<ClienteEntidad>();

        static ClienteAlmacen()
        {
            if (File.Exists("clientes.json"))
            {
                string json = File.ReadAllText("clientes.json");
                clientes = JsonSerializer.Deserialize<List<ClienteEntidad>>(json);
            }
        }

        public static List<ClienteEntidad> ObtenerTodos()
        {
            return clientes;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(clientes);
            File.WriteAllText("clientes.json", json);
        }
    }
}
