using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TUTASA.Almacenes
{
    internal static class ComisionAgenciaAlmacen
    {
        public static List<ComisionAgenciaEntidad> comisionAgencias = new List<ComisionAgenciaEntidad>();

        static ComisionAgenciaAlmacen()
        {
            if (File.Exists(@"datos\comisiones_agencia.json"))
            {
                string json = File.ReadAllText(@"datos\comisiones_agencia.json");
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
            File.WriteAllText(@"datos\comisiones_agencia.json", json);
        }
    }
}
