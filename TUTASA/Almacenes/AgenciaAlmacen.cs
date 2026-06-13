using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class AgenciaAlmacen
    {
        public static List<AgenciaEntidad> agencias = new List<AgenciaEntidad>();

        static AgenciaAlmacen()
        {
            if (File.Exists("agencias.json"))
            {
                string json = File.ReadAllText("agencias.json");
                agencias = JsonSerializer.Deserialize<List<AgenciaEntidad>>(json);
            }
        }

        public static List<AgenciaEntidad> ObtenerTodos()
        {
            return agencias;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(agencias);
            File.WriteAllText("agencias.json", json);
        }
    }
}
