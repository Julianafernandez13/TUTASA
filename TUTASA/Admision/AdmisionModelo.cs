using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTASA.Admision
{
    internal class AdmisionModelo
    {
        //Datos de Prueba para guias.    
        private List<Guia> guias = new List<Guia>
        {
            new Guia
            {
                Id = 1,
                NroTracking = "BUE-00000001",
                EstadoActual = "Impuesto en agencia — pendiente de admisión en CD",
                NombreRemitente = "Industrias López SA",
                NombreDestinatario = "Carlos Méndez",
                DomicilioEntrega = "Av. Pellegrini 420",
                Localidad = "Rosario",
                CodigoPostal = "2000",
                Categoria = "M",
                TipoEntrega = "Domicilio",
                TarifaEstimativa = 1500.00m,
                TarifaDefinitiva = 0,
                CdOrigen = "Buenos Aires",
                CdDestino = "Rosario"
            },

            new Guia
            {
                Id = 2,
                NroTracking = "BUE-00000002",
                EstadoActual = "Impuesto en CD — pendiente de admisión",
                NombreRemitente = "Textiles Garmendia SRL",
                NombreDestinatario = "Ana Rodríguez",
                DomicilioEntrega = "Corrientes 1200",
                Localidad = "Córdoba",
                CodigoPostal = "5000",
                Categoria = "L",
                TipoEntrega = "Domicilio",
                TarifaEstimativa = 2200.00m,
                TarifaDefinitiva = 0,
                CdOrigen = "Buenos Aires",
                CdDestino = "Córdoba"
            },

            new Guia
            {
                Id = 3,
                NroTracking = "BUE-00000003",
                EstadoActual = "Impuesto en agencia — pendiente de admisión en CD",
                NombreRemitente = "Distribuidora Norte SA",
                NombreDestinatario = "Roberto Fernández",
                DomicilioEntrega = "San Martín 580",
                Localidad = "Mendoza",
                CodigoPostal = "5500",
                Categoria = "S",
                TipoEntrega = "Agencia",
                TarifaEstimativa = 900.00m,
                TarifaDefinitiva = 0,
                CdOrigen = "Buenos Aires",
                CdDestino = "Mendoza"
            },

            new Guia
            {
                Id = 4,
                NroTracking = "BUE-00000004",
                EstadoActual = "Impuesto en CD — pendiente de admisión",
                NombreRemitente = "Comercial del Sur SRL",
                NombreDestinatario = "Laura Giménez",
                DomicilioEntrega = "Rivadavia 340",
                Localidad = "Tucumán",
                CodigoPostal = "4000",
                Categoria = "XL",
                TipoEntrega = "Domicilio",
                TarifaEstimativa = 3100.00m,
                TarifaDefinitiva = 0,
                CdOrigen = "Buenos Aires",
                CdDestino = "Tucumán"
            },

            new Guia
            {
                Id = 5,
                NroTracking = "BUE-00000005",
                EstadoActual = "Impuesto en agencia — pendiente de admisión en CD",
                NombreRemitente = "Importadora del Este SA",
                NombreDestinatario = "Martín Sosa",
                DomicilioEntrega = "Belgrano 920",
                Localidad = "Mar del Plata",
                CodigoPostal = "7600",
                Categoria = "M",
                TipoEntrega = "Domicilio",
                TarifaEstimativa = 1800.00m,
                TarifaDefinitiva = 0,
                CdOrigen = "Buenos Aires",
                CdDestino = "Mar del Plata"
            }
        };

        public List<Guia> Guias
        {
            get
            {
                return guias;
            }
        }

        //Datos de Prueba para categorias. 
        public List<Categoria> Categorias
        {
            get
            {
                return new List<Categoria>
                {
                    new Categoria { Id = 1, Descripcion = "S" },
                    new Categoria { Id = 2, Descripcion = "M" },
                    new Categoria { Id = 3, Descripcion = "L" },
                    new Categoria { Id = 4, Descripcion = "XL" }
                };
            }
        }

        internal bool Admitir(Guia guia, Categoria categoria)
        {
            if (guia == null)
            {
                MessageBox.Show(
                    "Debe buscar una guía primero.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            if (categoria == null)
            {
                MessageBox.Show(
                    "Debe seleccionar una categoría.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }


            if (guia.EstadoActual == "Admitida en CD")
            {
                MessageBox.Show(
                    "La guía ya fue admitida.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            guia.Categoria = categoria.Descripcion;

            guia.EstadoActual = "Admitida en CD";

            return true;
        }
    }
}