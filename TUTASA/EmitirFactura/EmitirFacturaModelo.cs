using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.EmitirFactura
{
    internal class EmitirFacturaModelo
    {
        // ── Datos de prueba: clientes ────────────────────────
        private List<Cliente> clientes = new List<Cliente>
        {
            new Cliente { Id=1, NombreCompleto="Distribuidora Norte S.A.", CUIT="20304050607", CondicionIVA="Responsable Inscripto" },
            new Cliente { Id=2, NombreCompleto="Logística del Sur SRL",    CUIT="27112233445", CondicionIVA="Responsable Inscripto" },
            new Cliente { Id=3, NombreCompleto="Juan Pérez",               CUIT="20987654321", CondicionIVA="Monotributista"        },
        };

        // ── Datos de prueba: movimientos ─────────────────────
        private List<MovimientoPendiente> movimientos = new List<MovimientoPendiente>
        {
            new MovimientoPendiente { NroGuia="BUE-00000010", Fecha=new DateTime(2026,5,3),  Origen="Buenos Aires", Destino="Córdoba",          Categoria="M",  ImporteNeto=1500m, Facturado=false, IdCliente=1 },
            new MovimientoPendiente { NroGuia="BUE-00000011", Fecha=new DateTime(2026,5,10), Origen="Buenos Aires", Destino="Rosario",           Categoria="S",  ImporteNeto=900m,  Facturado=false, IdCliente=1 },
            new MovimientoPendiente { NroGuia="BUE-00000012", Fecha=new DateTime(2026,5,15), Origen="Buenos Aires", Destino="Mendoza",           Categoria="L",  ImporteNeto=2200m, Facturado=false, IdCliente=1 },
            new MovimientoPendiente { NroGuia="BUE-00000013", Fecha=new DateTime(2026,4,20), Origen="Buenos Aires", Destino="Córdoba",           Categoria="M",  ImporteNeto=1500m, Facturado=true,  IdCliente=1 },
            new MovimientoPendiente { NroGuia="BUE-00000014", Fecha=new DateTime(2026,5,7),  Origen="Rosario",      Destino="Buenos Aires",      Categoria="XL", ImporteNeto=3100m, Facturado=false, IdCliente=2 },
            new MovimientoPendiente { NroGuia="BUE-00000015", Fecha=new DateTime(2026,5,18), Origen="Rosario",      Destino="Córdoba",           Categoria="S",  ImporteNeto=900m,  Facturado=false, IdCliente=2 },
            new MovimientoPendiente { NroGuia="BUE-00000016", Fecha=new DateTime(2026,5,22), Origen="Córdoba",      Destino="Buenos Aires",      Categoria="M",  ImporteNeto=1500m, Facturado=false, IdCliente=3 },
        };

        // ── Métodos ──────────────────────────────────────────

        // Busca un cliente por CUIT. Devuelve null si no existe.
        public Cliente BuscarClientePorCUIT(string cuit)
        {
            foreach (var c in clientes)
            {
                if (c.CUIT == cuit)
                    return c;
            }
            return null;
        }

        // Devuelve los movimientos pendientes (no facturados) de un cliente en un período.
        public List<MovimientoPendiente> ObtenerMovimientosPendientes(int idCliente, int mes, int anio)
        {
            var resultado = new List<MovimientoPendiente>();
            foreach (var m in movimientos)
            {
                if (m.IdCliente == idCliente && m.Fecha.Month == mes && m.Fecha.Year == anio && !m.Facturado)
                    resultado.Add(m);
            }
            return resultado;
        }

        // Calcula el total con IVA según la condición fiscal del cliente.
        public decimal CalcularTotal(List<MovimientoPendiente> movs, string condicionIVA)
        {
            decimal subtotal = 0;
            foreach (var m in movs)
                subtotal += m.ImporteNeto;

            if (condicionIVA == "Responsable Inscripto")
                return subtotal * 1.21m; // agrega 21% de IVA
            else
                return subtotal; // Monotributista: no agrega IVA
        }

        // Marca los movimientos como facturados.
        public void MarcarComoFacturados(List<MovimientoPendiente> movs)
        {
            foreach (var m in movs)
                m.Facturado = true;
        }
    }
}
