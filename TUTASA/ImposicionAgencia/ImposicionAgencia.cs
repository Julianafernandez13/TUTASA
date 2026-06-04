using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.ImposicionAgencia;

namespace TUTASA.Forms.Agencia
{
    //instancia del modelo de imposición de agencia
    public partial class frmImposicionAgencia : Form
    {
        private ImposicionAgenciaModelo modelo = new ImposicionAgenciaModelo();
       
        public frmImposicionAgencia()
        {
            InitializeComponent();
        }

        private void frmImposicionAgencia_Load(object sender, EventArgs e)
        {
            // Los combos cmbAgencia y cmbCD se cargan dinámicamente
            // al buscar por código postal, no al abrir el formulario
        }


        private void txtCUIT_TextChanged(object sender, EventArgs e)
        {
            //1) Validar que se ingresó un número de CUIT
            string input = txtCUIT.Text?.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show(
                    "Debe ingresar un numero de CUIT.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //2) Validar que el CUIT sea numérico y no contenga espacios
            if (!long.TryParse(input, out _))
            {
                MessageBox.Show(
                    "El CUIT debe ser numerico y no puede contener espacios.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            



        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void txtMuestraNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnL_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnXL_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarBulto_Click(object sender, EventArgs e)
        {

        }

        private void listViewBultos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitarBulto_Click(object sender, EventArgs e)
        {

        }

        private void radioBtnDomicilio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnAgencia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnCD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreDom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNIDom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoDom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDomicilioEntrega_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPDom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarLocalidadDom_Click(object sender, EventArgs e)
        {
            string cp = txtCPAg.Text.Trim();

            if (string.IsNullOrWhiteSpace(cp))
            {
                MessageBox.Show(
                    "Debe ingresar un código postal para buscar la agencia.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            

        }

        private void textLocProvDom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreAg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNIAg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoAg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPAg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarLocalidadAg_Click(object sender, EventArgs e)
        {
            // Limpiamos resultado anterior siempre, antes de cualquier validación
            cmbAgencia.DataSource = null;
            cmbAgencia.Items.Clear();

            string cp = txtCPAg.Text.Trim();

            if (string.IsNullOrWhiteSpace(cp))
            {
                MessageBox.Show(
                    "Debe ingresar un código postal para buscar la agencia.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Verificamos que el CP existe
            var localidad = modelo.ObtenerCodigosPostales().FirstOrDefault(c => c.idCodPostal == cp);

            if (localidad == null)
            {
                MessageBox.Show(
                    "No se encontró el código postal ingresado.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                
                return;
            }

            // Filtramos agencias que pertenecen a ese CP
            var agencias = modelo.ObtenerAgencias().Where(a => a.CodigoPostal == cp).ToList();

            if (agencias.Count == 0)
            {
                MessageBox.Show(
                    $"No hay agencias registradas para el código postal {cp}.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                
                return;
            }

            cmbAgencia.DataSource = agencias;
            cmbAgencia.DisplayMember = "nombreAgencia";
            cmbAgencia.ValueMember = "idAgencia";
            cmbAgencia.SelectedIndex = -1;
        }

        private void cmbAgencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNICD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPCD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarLocalidadCD_Click(object sender, EventArgs e)
        {
            // Limpiamos resultado anterior siempre, antes de cualquier validación
            cmbCD.DataSource = null;
            cmbCD.Items.Clear();

            string cp = txtCPCD.Text.Trim();

            if (string.IsNullOrWhiteSpace(cp))
            {
                MessageBox.Show(
                    "Debe ingresar un código postal para buscar el CD.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Verificamos que el CP existe
            var localidad = modelo.ObtenerCodigosPostales().FirstOrDefault(c => c.idCodPostal == cp);

            if (localidad == null)
            {
                MessageBox.Show(
                    "No se encontró el código postal ingresado.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                
                return;
            }

            // Filtramos CDs que tienen ese CP bajo su jurisdicción
            var cds = modelo.ObtenerCentrosDeDistribucion().Where(cd => cd.CodigosPostales.Contains(cp)).ToList();

            if (cds.Count == 0)
            {
                MessageBox.Show(
                    $"No hay centros de distribución para el código postal {cp}.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            cmbCD.DataSource = cds;
            cmbCD.DisplayMember = "nombreCD";
            cmbCD.ValueMember = "idCD";
            cmbCD.SelectedIndex = -1;
        }

        

        private void cmbCD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
