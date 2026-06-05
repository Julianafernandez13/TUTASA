using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.RendicionHDRdeUltMilla
{
    internal class RendicionHDRUltMillaModelo
    {
        // ── Datos de prueba: fleteros ─────────────────────────
        private List<Fletero> fleteros = new List<Fletero>
        {
            new Fletero { Id=1, NombreCompleto="Carlos Rodríguez", Localidad="Buenos Aires", DNI="12345678" },
            new Fletero { Id=2, NombreCompleto="Diego Martínez",   Localidad="Buenos Aires", DNI="23456789" },
            new Fletero { Id=3, NombreCompleto="Juan López",       Localidad="Córdoba",      DNI="34567890" },
        };

        // ── Datos de prueba: HDRs ─────────────────────────────
        private List<HDR> hdrs = new List<HDR>
        {
            new HDR { Id=1, NroHDR="HDR-UM-001", Cliente="Distribuidora Norte S.A.", Localidad="Buenos Aires", Direccion="Av. Corrientes 1234", Entrega="Domicilio", Cumplida=false, IdFletero=1 },
            new HDR { Id=2, NroHDR="HDR-UM-002", Cliente="Logística del Sur SRL",    Localidad="Buenos Aires", Direccion="Av. Santa Fe 567",    Entrega="Domicilio", Cumplida=false, IdFletero=1 },
            new HDR { Id=3, NroHDR="HDR-UM-003", Cliente="Juan Pérez",               Localidad="Buenos Aires", Direccion="Av. Corrientes 1234", Entrega="Agencia",   Cumplida=false, IdFletero=2 },
            new HDR { Id=4, NroHDR="HDR-UM-004", Cliente="Distribuidora Norte S.A.", Localidad="Córdoba",      Direccion="Bv. San Juan 890",    Entrega="Domicilio", Cumplida=false, IdFletero=3 },
        };

        // ── Métodos ───────────────────────────────────────────

        // Busca un fletero por DNI. Devuelve null si no existe.
        public Fletero BuscarFleteroPorDNI(string dni)
        {
            foreach (var f in fleteros)
            {
                if (f.DNI == dni)
                    return f;
            }
            return null;
        }

        // Devuelve las HDRs pendientes asignadas a un fletero
        public List<HDR> ObtenerHDRsPorFletero(int idFletero)
        {
            var resultado = new List<HDR>();
            foreach (var h in hdrs)
            {
                if (h.IdFletero == idFletero && !h.Cumplida)
                    resultado.Add(h);
            }
            return resultado;
        }

        // Registra la rendición de una HDR
        public void RendirHDR(HDR hdr, bool cumplida)
        {
            hdr.Cumplida = cumplida;
        }

        // Confirma todas las rendiciones
        public void ConfirmarRendicion(List<HDR> hdrsRendidas)
        {
            foreach (var h in hdrsRendidas)
                h.Cumplida = true;
        }
    }
}
