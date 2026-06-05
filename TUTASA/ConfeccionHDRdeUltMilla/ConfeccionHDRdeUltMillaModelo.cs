using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.ConfeccionHDRdeUltMilla
{
    internal class ConfeccionHDRdeUltMillaModelo
    {
        // ── Datos de prueba: localidades ─────────────────────
        private List<Localidad> localidades = new List<Localidad>
        {
            new Localidad { Id=1, Nombre="Buenos Aires" },
            new Localidad { Id=2, Nombre="Córdoba"      },
            new Localidad { Id=3, Nombre="Rosario"      },
            new Localidad { Id=4, Nombre="Mendoza"      },
        };

        // ── Datos de prueba: fleteros ─────────────────────────
        private List<Fletero> fleteros = new List<Fletero>
        {
            new Fletero { Id=1, NombreCompleto="Carlos Rodríguez", Localidad="Buenos Aires" },
            new Fletero { Id=2, NombreCompleto="Diego Martínez",   Localidad="Buenos Aires" },
            new Fletero { Id=3, NombreCompleto="Juan López",       Localidad="Córdoba"      },
            new Fletero { Id=4, NombreCompleto="Pablo Sánchez",    Localidad="Rosario"      },
            new Fletero { Id=5, NombreCompleto="Lucas Pérez",      Localidad="Mendoza"      },
        };

        // ── Datos de prueba: guías ────────────────────────────
        private List<Guia> guias = new List<Guia>
        {
            new Guia { Id=1, NroTracking="BUE-00000010", EstadoActual="Admitida",             NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Ana García",    DomicilioEntrega="Av. Corrientes 1234", Localidad="Buenos Aires", Categoria="M",  TipoEntrega="Domicilio", Agencia=""              },
            new Guia { Id=2, NroTracking="BUE-00000011", EstadoActual="Admitida",             NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Pedro Díaz",    DomicilioEntrega="Av. Corrientes 1234", Localidad="Buenos Aires", Categoria="S",  TipoEntrega="Domicilio", Agencia=""              },
            new Guia { Id=3, NroTracking="BUE-00000012", EstadoActual="Admitida",             NombreRemitente="Juan Pérez",               NombreDestinatario="Laura Sosa",    DomicilioEntrega="Av. Santa Fe 567",    Localidad="Buenos Aires", Categoria="L",  TipoEntrega="Domicilio", Agencia=""              },
            new Guia { Id=4, NroTracking="COR-00000020", EstadoActual="Admitida",             NombreRemitente="Distribuidora Norte S.A.", NombreDestinatario="Marcos Ruiz",   DomicilioEntrega="Bv. San Juan 890",    Localidad="Córdoba",      Categoria="XL", TipoEntrega="Domicilio", Agencia=""              },
            new Guia { Id=5, NroTracking="BUE-00000013", EstadoActual="Admitida",             NombreRemitente="Logística del Sur SRL",    NombreDestinatario="Sofía Torres",  DomicilioEntrega="",                    Localidad="Buenos Aires", Categoria="M",  TipoEntrega="Agencia",   Agencia="Agencia Norte" },
            new Guia { Id=6, NroTracking="ROS-00000030", EstadoActual="Admitida",             NombreRemitente="Juan Pérez",               NombreDestinatario="Diego Molina",  DomicilioEntrega="Pellegrini 321",      Localidad="Rosario",      Categoria="S",  TipoEntrega="Domicilio", Agencia=""              },
        };

        // ── Métodos ───────────────────────────────────────────

        // Devuelve todas las localidades
        public List<Localidad> ObtenerLocalidades()
        {
            return localidades;
        }

        // Devuelve los domicilios únicos de las guías admitidas en una localidad
        public List<string> ObtenerDomiciliosPorLocalidad(string localidad)
        {
            var domicilios = new List<string>();
            foreach (var g in guias)
            {
                if (g.Localidad == localidad && g.EstadoActual == "Admitida" && !domicilios.Contains(g.DomicilioEntrega))
                    domicilios.Add(g.DomicilioEntrega);
            }
            return domicilios;
        }

        // Devuelve las guías admitidas filtradas por localidad y domicilio
        public List<Guia> ObtenerGuiasPendientes(string localidad, string domicilio)
        {
            var resultado = new List<Guia>();
            foreach (var g in guias)
            {
                if (g.Localidad == localidad && g.DomicilioEntrega == domicilio && g.EstadoActual == "Admitida")
                    resultado.Add(g);
            }
            return resultado;
        }

        // Devuelve los fleteros disponibles en una localidad
        public List<Fletero> ObtenerFleterosPorLocalidad(string localidad)
        {
            var resultado = new List<Fletero>();
            foreach (var f in fleteros)
            {
                if (f.Localidad == localidad)
                    resultado.Add(f);
            }
            return resultado;
        }

        // Confirma la HDR — marca las guías seleccionadas
        public void ConfirmarHDR(List<Guia> guiasSeleccionadas, Fletero fletero)
        {
            foreach (var g in guiasSeleccionadas)
                g.EstadoActual = "HDR Confeccionada";
        }
    }
}
