using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TUTASA.Admision
{
    internal class AdmisionModelo
    {
        public Guia GuiaSeleccionada { get; private set; }

        private List<Guia> guias = new List<Guia>
        {
            new Guia { Id = 1, NroTracking = "BUE-00000001", EstadoActual = "Impuesto en agencia — pendiente de admisión en CD", Categoria = "M", TarifaDefinitiva = 0 },
            new Guia { Id = 2, NroTracking = "BUE-00000002", EstadoActual = "Impuesto en CD — pendiente de admisión",            Categoria = "L", TarifaDefinitiva = 0 },
            new Guia { Id = 3, NroTracking = "BUE-00000003", EstadoActual = "Impuesto en agencia — pendiente de admisión en CD", Categoria = "S", TarifaDefinitiva = 0 },
            new Guia { Id = 4, NroTracking = "BUE-00000004", EstadoActual = "Impuesto en CD — pendiente de admisión",            Categoria = "XL", TarifaDefinitiva = 0 },
            new Guia { Id = 5, NroTracking = "BUE-00000005", EstadoActual = "Impuesto en agencia — pendiente de admisión en CD", Categoria = "M", TarifaDefinitiva = 0 }
        };

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

        internal bool BuscarGuia(string nroTracking)
        {
            GuiaSeleccionada = null;

            foreach (var guia in guias)
            {
                if (guia.NroTracking == nroTracking.Trim().ToUpper())
                {
                    GuiaSeleccionada = guia;
                    break;
                }
            }

            if (GuiaSeleccionada == null)
            {
                MessageBox.Show(
                    "La guía ingresada no corresponde a ninguna solicitud registrada.",
                    "Guía no encontrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        internal bool Admitir(Categoria categoria)
        {
            if (GuiaSeleccionada == null)
            {
                MessageBox.Show(
                    "Debe buscar una guía primero.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (categoria == null)
            {
                MessageBox.Show(
                    "Debe seleccionar una categoría.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            if (GuiaSeleccionada.EstadoActual == "Admitida en CD")
            {
                MessageBox.Show(
                    "La guía ya fue admitida.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            // 3) Si la categoría es diferente a la que ya tenía, pedir confirmación
            if (GuiaSeleccionada.Categoria != categoria.Descripcion)
            {
                var resultado = MessageBox.Show(
                    $"La guía tiene la categoría \"{GuiaSeleccionada.Categoria}\" asignada.\n¿Desea cambiarla a \"{categoria.Descripcion}\"?",
                    "Confirmar cambio de categoría",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                    return false;
            }

            GuiaSeleccionada.Categoria = categoria.Descripcion;
            GuiaSeleccionada.EstadoActual = "Admitida en CD";

            return true;
        }

        internal void LimpiarSeleccion()
        {
            GuiaSeleccionada = null;
        }
    }
}