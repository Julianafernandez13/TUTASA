using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Almacenes
{
    internal static class CtaCteAgenciaAlmacen
    {
        private static List<CtaCteAgenciaEntidad> ctaCteAgencias = new List<CtaCteAgenciaEntidad>();

        static CtaCteAgenciaAlmacen()
        {
            if (File.Exists("cta_cte_agencia.json"))
            {
                string json = File.ReadAllText("cta_cte_agencia.json");
                ctaCteAgencias = JsonSerializer.Deserialize<List<CtaCteAgenciaEntidad>>(json);
            }
        }

        public static List<CtaCteAgenciaEntidad> ObtenerTodos()
        {
            return ctaCteAgencias;
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(ctaCteAgencias);
            File.WriteAllText("cta_cte_agencia.json", json);
        }
    }
}
