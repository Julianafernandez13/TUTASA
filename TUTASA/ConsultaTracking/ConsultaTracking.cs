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
using TUTASA.ConsultaTracking;

namespace TUTASA.Forms.CallCenter
{
    public partial class ConsultaTracking : Form
    {
        //Instancia del modelo de ConsultaTracking
        private ConsultaTrackingModelo modelo = new ConsultaTrackingModelo();
        private Guia guiaSeleccionada;
        public ConsultaTracking()
        {
            InitializeComponent();
        }

        private void frmConsultaTrackingCallCenter_Load(object sender, EventArgs e)
        {
            listViewHistorial.View = View.Details;
            listViewHistorial.FullRowSelect = true;
            listViewHistorial.GridLines = true;

            listViewHistorial.Columns.Add("Fecha", 90);
            listViewHistorial.Columns.Add("Hora", 70);
            listViewHistorial.Columns.Add("Ubicacion", 180);
            listViewHistorial.Columns.Add("Estado", 200);

            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }        
        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


        private void LimpiarFormulario()
        {
            txtNroDeGuia.Clear();

            lblEstadoActual.Text = "";
            lblEstadoActual.BackColor = Color.White;

            txtNroDeGuia.Clear();
            lblGuia.Text = "";
            lblCDOrigen.Text = "";
            lblCategoria.Text = "";
            lblCDDestino.Text = "";
            lblCliente.Text = "";
            lblDestinatario.Text = "";

            listViewHistorial.Items.Clear();

            guiaSeleccionada = null;

            txtNroDeGuia.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
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
            guiaSeleccionada = modelo.BuscarGuia(txtNroDeGuia.Text);

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

            // 4) Autorrellenar los campos con los datos de la guía
            MostrarDatosGuia(guiaSeleccionada);
        }

        private void MostrarDatosGuia(Guia guia)
        {
            // Estado con color
            lblEstadoActual.Text = guia.EstadoActual;
            lblEstadoActual.BackColor = modelo.ObtenerColorEstado(guia.EstadoActual);

            // Campos de datos
            lblGuia.Text = guia.NroTracking;
            lblCDOrigen.Text = guia.CdOrigen;
            lblCategoria.Text = guia.Categoria;
            lblCDDestino.Text = guia.CdDestino;
            lblCliente.Text = guia.NombreRemitente;
            lblDestinatario.Text = guia.NombreDestinatario;

            // Historial
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
