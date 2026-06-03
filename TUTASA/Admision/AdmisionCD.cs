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
        //instancia del modelo de admision
        private AdmisionModelo modelo = new AdmisionModelo();
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
            Guia guiaEncontrada = null;

            foreach (var guia in guias)
            {
                if (guia.NroTracking == txtNroDeGuia.Text.Trim().ToUpper())
                {
                    guiaEncontrada = guia;
                    break;
                }
            }

            // 3) Si no existe mostrar error
            if (guiaEncontrada == null)
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

            // 4) Autorrellenar los campos con los datos de la guía
            labelNrodeGuia.Text = guiaEncontrada.NroTracking;
        }

        private void grpAdmision_Enter(object sender, EventArgs e)
        {

        }

        private void txtNroDeGuia_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNrodeGuia_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdmitir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
