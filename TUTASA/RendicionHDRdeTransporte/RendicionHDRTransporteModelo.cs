using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.RendicionHDRdeTransporte
{
    internal class RendicionHDRTransporteModelo
    {
        // ── Propiedades de estado ─────────────────────────────
        public HDR HdrActual { get; set; } = null;
        public bool Limpiando { get; set; } = false;

        // ── Datos de prueba: empresas de transporte ──────────
        private List<EmpresaTransporte> empresas = new List<EmpresaTransporte>
        {
            new EmpresaTransporte { Id=1, Nombre="Flecha Bus"   },
            new EmpresaTransporte { Id=2, Nombre="Andesmar"     },
            new EmpresaTransporte { Id=3, Nombre="Chevallier"   },
        };

        // ── Datos de prueba: HDRs ────────────────────────────
        private List<HDR> hdrs = new List<HDR>
        {
            new HDR
            {
                Id=1, NroHDR="HDR-001", CdOrigen="Buenos Aires", CdDestino="Córdoba",
                CantBultos=3, EstadoActual="Pendiente", IdEmpresaTransporte=1,
                Guias = new List<Guia>
                {
                    new Guia { Id=1, NroTracking="BUE-00000010", EstadoActual="En tránsito", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Ana García",   Categoria="M"  },
                    new Guia { Id=2, NroTracking="BUE-00000011", EstadoActual="En tránsito", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Pedro Díaz",   Categoria="S"  },
                    new Guia { Id=3, NroTracking="BUE-00000012", EstadoActual="En tránsito", NombreRemitente="Juan Pérez",               NombreDestinatario="Laura Sosa",   Categoria="L"  },
                }
            },
            new HDR
            {
                Id=2, NroHDR="HDR-002", CdOrigen="Buenos Aires", CdDestino="Rosario",
                CantBultos=2, EstadoActual="Pendiente", IdEmpresaTransporte=1,
                Guias = new List<Guia>
                {
                    new Guia { Id=4, NroTracking="BUE-00000013", EstadoActual="En tránsito", NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Sofía Torres", Categoria="M"  },
                    new Guia { Id=5, NroTracking="BUE-00000014", EstadoActual="En tránsito", NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Diego Molina", Categoria="XL" },
                }
            },
            new HDR
            {
                Id=3, NroHDR="HDR-003", CdOrigen="Córdoba", CdDestino="Mendoza",
                CantBultos=1, EstadoActual="Pendiente", IdEmpresaTransporte=2,
                Guias = new List<Guia>
                {
                    new Guia { Id=6, NroTracking="COR-00000020", EstadoActual="En tránsito", NombreRemitente="Juan Pérez",               NombreDestinatario="Marcos Ruiz",  Categoria="XL" },
                }
            },
        };

        // ── Métodos ──────────────────────────────────────────

        // Devuelve todas las empresas de transporte
        public List<EmpresaTransporte> ObtenerEmpresas()
        {
            return empresas;
        }

        // Devuelve las HDRs pendientes de una empresa
        public List<HDR> ObtenerHDRsPorEmpresa(int idEmpresa)
        {
            var resultado = new List<HDR>();
            foreach (var h in hdrs)
            {
                if (h.IdEmpresaTransporte == idEmpresa && h.EstadoActual == "Pendiente")
                    resultado.Add(h);
            }
            return resultado;
        }

        // Devuelve una HDR por su Id
        public HDR ObtenerHDRPorId(int idHDR)
        {
            foreach (var h in hdrs)
            {
                if (h.Id == idHDR)
                    return h;
            }
            return null;
        }

        // Confirma la recepción de una HDR
        public void ConfirmarRecepcion(HDR hdr)
        {
            hdr.EstadoActual = "Recibida";
            foreach (var g in hdr.Guias)
                g.EstadoActual = "Recibida en CD destino";
        }
    }
}
