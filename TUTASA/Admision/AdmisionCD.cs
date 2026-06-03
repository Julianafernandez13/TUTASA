using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.Admision;

namespace TUTASA.Forms.CD
{
    public partial class frmAdmision : Form
    {
        // Instancia del modelo de admision
        private AdmisionModelo modelo = new AdmisionModelo();
        private Guia guiaSeleccionada;
        public frmAdmision()
        {
            InitializeComponent();
        }
        private void frmAdmision_Load(object sender, EventArgs e)
        {
            // Aca se cargan las categorías en el ComboBox de Categoria
            var categorias = modelo.Categorias;
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.Items.Clear();
            foreach (var categoria in categorias)
            {
                cmbCategoria.Items.Add(categoria);
            }
        } 
         
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // 1) Validar que se ingresó un número de guía
            if (string.IsNullOrWhiteSpace(txtNroDeGuia.Text))
            {
                MessageBox.Show(
                    "Debe ingresar un número de guía.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // 2) Buscar la guía en el modelo
            var guias = modelo.Guias;
            guiaSeleccionada = null;

            foreach (var guia in guias)
            {
                if (guia.NroTracking == txtNroDeGuia.Text.Trim().ToUpper())
                {
                    guiaSeleccionada = guia;
                    break;
                }
            }

            // 3) Si no existe mostrar error
            if (guiaSeleccionada == null)
            {
                MessageBox.Show(
                    "La guía ingresada no corresponde a ninguna solicitud registrada.",
                    "Guía no encontrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtNroDeGuia.Clear();
                txtNroDeGuia.Focus();
                return;
            }

            // 4) Autorrellenar los campos con los datos de la guía (nro de tracking)
            labelNrodeGuia.Text = guiaSeleccionada.NroTracking;
        }

        private void btnAdmitir_Click(object sender, EventArgs e)
        {
            // 1) Pasa por aca cuando no se busco ninguna guia.
            if (guiaSeleccionada == null)
            {
                MessageBox.Show(
                    "Debe buscar una guía.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // 2) Pasa por aca cuando validar que se seleccionó una categoría, esto con una guia ya buscada.
            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show(
                    "Debe seleccionar una categoría.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            var categoria = (Categoria)cmbCategoria.SelectedItem;

            if (!modelo.Admitir(guiaSeleccionada, categoria))
            {
                return;
            }

            MessageBox.Show(
                "La guía fue admitida correctamente.",
                "Admisión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNroDeGuia.Clear();

            labelNrodeGuia.Text = "";

            cmbCategoria.SelectedIndex = -1;

            guiaSeleccionada = null;

            txtNroDeGuia.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
