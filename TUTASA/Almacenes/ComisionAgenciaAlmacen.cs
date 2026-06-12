using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class ComisionAgenciaAlmacen
    {
        private static List<ComisionAgenciaEntidad> comisionAgencias = new List<ComisionAgenciaEntidad>();

        static ComisionAgenciaAlmacen()
        {
            if (File.Exists("comisiones_agencia.json"))
            {
                string json = File.ReadAllText("comisiones_agencia.json");
                comisionAgencias = JsonSerializer.Deserialize<List<ComisionAgenciaEntidad>>(json);
            }
        }

        public static List<ComisionAgenciaEntidad> ObtenerTodos()
        {
            return comisionAgencias;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(comisionAgencias);
            File.WriteAllText("comisiones_agencia.json", json);
        }
    }
}
