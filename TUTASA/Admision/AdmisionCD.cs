using System;
using System.Windows.Forms;
using TUTASA.Admision;

namespace TUTASA.Forms.CD
{
    public partial class frmAdmision : Form
    {
        private AdmisionModelo modelo = new AdmisionModelo();

        public frmAdmision()
        {
            InitializeComponent();
        }

        private void frmAdmision_Load(object sender, EventArgs e)
        {
            cmbCategoria.DisplayMember = "Descripcion";
            cmbCategoria.Items.Clear();
            foreach (var categoria in modelo.Categorias)
            {
                cmbCategoria.Items.Add(categoria);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNroDeGuia.Text))
            {
                MessageBox.Show(
                    "Debe ingresar un número de guía.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!modelo.BuscarGuia(txtNroDeGuia.Text))
            {
                txtNroDeGuia.Clear();
                txtNroDeGuia.Focus();
                return;
            }

            labelNrodeGuia.Text = modelo.GuiaSeleccionada.NroTracking;
        }

        private void btnAdmitir_Click(object sender, EventArgs e)
        {
            if (modelo.GuiaSeleccionada == null)
            {
                MessageBox.Show(
                    "Debe buscar una guía primero.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show(
                    "Debe seleccionar una categoría.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return ;
            }

            var categoria = (Categoria)cmbCategoria.SelectedItem;

            if (!modelo.Admitir(categoria))
                return;

            MessageBox.Show(
                "La guía fue admitida correctamente.",
                "Admisión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro que desea cancelar la admisión? Se perderán todos los datos ingresados.", "Cancelar Admision",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
                this.Close();
        }

        private void LimpiarFormulario()
        {
            txtNroDeGuia.Clear();
            labelNrodeGuia.Text = "";
            cmbCategoria.SelectedIndex = -1;
            modelo.LimpiarSeleccion();
            txtNroDeGuia.Focus();
        }
    }
}