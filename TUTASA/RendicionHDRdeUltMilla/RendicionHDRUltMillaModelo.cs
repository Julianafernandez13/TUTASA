using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.RendicionHDRdeUltMilla
{
    internal class RendicionHDRUltMillaModelo
    {
        // ── Propiedades de estado ─────────────────────────────
        public Fletero FleteroActual { get; set; } = null;
        public List<HDR> HdrsRendidas { get; set; } = new List<HDR>();

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
            // HDRs en estado Pendiente — aparecen en listViewHDRaEntregar
            new HDR { Id=1, NroHDR="HDR-UM-001", Cliente="Distribuidora Norte S.A.", Localidad="Buenos Aires", Direccion="Av. Corrientes 1234", Entrega="Domicilio", Estado=EstadoHDRUltMillaEnum.Pendiente,  IdFletero=1 },
            new HDR { Id=2, NroHDR="HDR-UM-002", Cliente="Logística del Sur SRL",    Localidad="Buenos Aires", Direccion="Av. Santa Fe 567",    Entrega="Domicilio", Estado=EstadoHDRUltMillaEnum.Pendiente,  IdFletero=1 },
            new HDR { Id=3, NroHDR="HDR-UM-003", Cliente="Juan Pérez",               Localidad="Buenos Aires", Direccion="Av. Corrientes 1234", Entrega="Agencia",   Estado=EstadoHDRUltMillaEnum.Pendiente,  IdFletero=2 },

            // HDRs en estado EnProceso — aparecen en cmbNroHDR para rendir
            new HDR { Id=4, NroHDR="HDR-UM-004", Cliente="Distribuidora Norte S.A.", Localidad="Buenos Aires", Direccion="Av. Rivadavia 890",   Entrega="Domicilio", Estado=EstadoHDRUltMillaEnum.EnProceso,  IdFletero=1 },
            new HDR { Id=5, NroHDR="HDR-UM-005", Cliente="Logística del Sur SRL",    Localidad="Buenos Aires", Direccion="Av. Santa Fe 567",    Entrega="Domicilio", Estado=EstadoHDRUltMillaEnum.EnProceso,  IdFletero=1 },
            new HDR { Id=6, NroHDR="HDR-UM-006", Cliente="Juan Pérez",               Localidad="Córdoba",      Direccion="Bv. San Juan 890",    Entrega="Domicilio", Estado=EstadoHDRUltMillaEnum.EnProceso,  IdFletero=3 },
        };

        // ── Métodos ───────────────────────────────────────────

        // Busca un fletero por DNI
        public Fletero BuscarFleteroPorDNI(string dni)
        {
            foreach (var f in fleteros)
            {
                if (f.DNI == dni)
                    return f;
            }
            return null;
        }

        // Devuelve las HDRs en estado Pendiente asignadas a un fletero
        // Estas son las que hay que entregarle al fletero hoy
        public List<HDR> ObtenerHDRsPendientesPorFletero(int idFletero)
        {
            var resultado = new List<HDR>();
            foreach (var h in hdrs)
            {
                if (h.IdFletero == idFletero && h.Estado == EstadoHDRUltMillaEnum.Pendiente)
                    resultado.Add(h);
            }
            return resultado;
        }

        // Devuelve las HDRs en estado EnProceso asignadas a un fletero
        // Estas son las que el fletero viene a rendir
        public List<HDR> ObtenerHDRsEnProcesoPorFletero(int idFletero)
        {
            var resultado = new List<HDR>();
            foreach (var h in hdrs)
            {
                if (h.IdFletero == idFletero && h.Estado == EstadoHDRUltMillaEnum.EnProceso)
                    resultado.Add(h);
            }
            return resultado;
        }

        // Registra la rendición de una HDR — la marca como Cumplida o NoCumplida
        public void RendirHDR(HDR hdr, bool cumplida)
        {
            hdr.Estado = cumplida ? EstadoHDRUltMillaEnum.Cumplida : EstadoHDRUltMillaEnum.NoCumplida;
        }

        // Revierte el estado de una HDR a EnProceso cuando es quitada de la lista de rendición
        public void RevertirHDR(HDR hdr)
        {
            hdr.Estado = EstadoHDRUltMillaEnum.EnProceso;
        }

        // Confirma la rendición — pasa las HDRs pendientes a EnProceso
        public void ConfirmarRendicion(List<HDR> hdrsAConfirmar, int idFletero)
        {
            // Confirmar las HDRs rendidas (ya fueron marcadas como Cumplida o NoCumplida en RendirHDR)

            // Pasar las HDRs pendientes del fletero a EnProceso
            foreach (var h in hdrs)
            {
                if (h.IdFletero == idFletero && h.Estado == EstadoHDRUltMillaEnum.Pendiente)
                    h.Estado = EstadoHDRUltMillaEnum.EnProceso;
            }
        }
    }
}
