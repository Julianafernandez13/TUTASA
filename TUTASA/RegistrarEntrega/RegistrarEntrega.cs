using System;
using System.Windows.Forms;
using TUTASA.RegistrarEntrega;

namespace TUTASA.Forms.CD
{
    public partial class frmEntrega : Form
    {
        private RegistrarEntregaModelo modelo = new RegistrarEntregaModelo();

        public frmEntrega()
        {
            InitializeComponent();
        }

        private void frmEntregaCD_Load(object sender, EventArgs e)
        {
            listViewEncomiendas.Columns.Clear();
            listViewEncomiendas.View = View.Details;
            listViewEncomiendas.FullRowSelect = true;
            listViewEncomiendas.GridLines = true;

            listViewEncomiendas.Columns.Add("N° de Guía", 150);
            listViewEncomiendas.Columns.Add("Cliente", 170);
            listViewEncomiendas.Columns.Add("Nombre del Receptor", 180);
            listViewEncomiendas.Columns.Add("DNI del Receptor", 130);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDNIReceptor.Text))
            {
                MessageBox.Show(
                    "Debe ingresar un DNI.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!modelo.BuscarReceptor(txtDNIReceptor.Text))
            {
                txtDNIReceptor.Clear();
                txtDNIReceptor.Focus();
                return;
            }

            listViewEncomiendas.Items.Clear();

            var guias = modelo.ObtenerGuiasDisponibles();

            if (guias.Count == 0)
            {
                MessageBox.Show(
                    "El receptor no tiene encomiendas disponibles para retiro.",
                    "Sin encomiendas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                modelo.LimpiarSeleccion();
                return;
            }

            foreach (var guia in guias)
            {
                var item = new ListViewItem(guia.NroTracking);
                item.SubItems.Add(guia.NombreRemitente);
                item.SubItems.Add(guia.NombreDestinatario);
                item.SubItems.Add(modelo.ReceptorSeleccionado.Dni);
                listViewEncomiendas.Items.Add(item);
            }
        }

        private void btnConfirmarEntrega_Click(object sender, EventArgs e)
        {
            if (!modelo.ConfirmarEntrega())
                return;

            MessageBox.Show(
                "Las encomiendas fueron entregadas correctamente.",
                "Entrega registrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtDNIReceptor.Clear();
            listViewEncomiendas.Items.Clear();
            modelo.LimpiarSeleccion();
            txtDNIReceptor.Focus();
        }
    }
}