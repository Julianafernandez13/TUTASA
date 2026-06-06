using System;
using System.Drawing;
using System.Windows.Forms;
using TUTASA.ConsultaTracking;

namespace TUTASA.Forms.CallCenter
{
    public partial class ConsultaTracking : Form
    {
        private ConsultaTrackingModelo modelo = new ConsultaTrackingModelo();

        public ConsultaTracking()
        {
            InitializeComponent();
        }

        private void frmConsultaTrackingCallCenter_Load(object sender, EventArgs e)
        {
            listViewHistorial.Columns.Clear();
            listViewHistorial.View = View.Details;
            listViewHistorial.FullRowSelect = true;
            listViewHistorial.GridLines = true;

            listViewHistorial.Columns.Add("Fecha", 90);
            listViewHistorial.Columns.Add("Hora", 70);
            listViewHistorial.Columns.Add("Ubicacion", 180);
            listViewHistorial.Columns.Add("Estado", 200);

            LimpiarFormulario();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
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

            MostrarDatosGuia(modelo.GuiaSeleccionada);
        }

        private void MostrarDatosGuia(GuiaTracking guia)
        {
            lblEstadoActual.Text = guia.EstadoActual;
            lblEstadoActual.BackColor = modelo.ObtenerColorEstado(guia.EstadoActual);

            lblGuia.Text = guia.NroTracking;
            lblCDOrigen.Text = guia.CdOrigen;
            lblCategoria.Text = guia.Categoria;
            lblCDDestino.Text = guia.CdDestino;
            lblCliente.Text = guia.NombreRemitente;
            lblDestinatario.Text = guia.NombreDestinatario;

            listViewHistorial.Items.Clear();
            var historial = modelo.ObtenerHistorial(guia);
            foreach (var evento in historial)
            {
                var item = new ListViewItem(evento.Fecha);
                item.SubItems.Add(evento.Hora);
                item.SubItems.Add(evento.Ubicacion);
                item.SubItems.Add(evento.Estado);
                listViewHistorial.Items.Add(item);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro que desea salir? Se perderán todos los datos ingresados.", "Salir",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
                this.Close();
        }

        private void LimpiarFormulario()
        {
            txtNroDeGuia.Clear();

            lblEstadoActual.Text = "";
            lblEstadoActual.BackColor = Color.White;

            lblGuia.Text = "";
            lblCDOrigen.Text = "";
            lblCategoria.Text = "";
            lblCDDestino.Text = "";
            lblCliente.Text = "";
            lblDestinatario.Text = "";

            listViewHistorial.Items.Clear();

            modelo.LimpiarSeleccion();

            txtNroDeGuia.Focus();
        }
    }
}