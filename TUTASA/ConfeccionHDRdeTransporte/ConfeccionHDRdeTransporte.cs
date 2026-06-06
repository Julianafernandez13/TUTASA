using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.ConfeccionHDRdeTransporte;

namespace TUTASA.Pantallas
{
    public partial class ConfeccionHDRdeTransporte : Form
    {
        private ConfeccionHDRdeTransporteModelo modelo = new ConfeccionHDRdeTransporteModelo();
        private List<Guia> guiasSeleccionadas = new List<Guia>();

        public ConfeccionHDRdeTransporte()
        {
            InitializeComponent();
        }

        // ── LOAD ─────────────────────────────────────────────
        private void ConfeccionHDRdeTransporte_Load(object sender, EventArgs e)
        {
            // CD Origen autorrelleno por sesión
            labelMuestraCDOrigen.Text = "CD Buenos Aires";

            // Cargar localidades destino
            cmbLocalidadDestino.Items.Clear();
            foreach (var loc in modelo.ObtenerLocalidades())
                cmbLocalidadDestino.Items.Add(loc.Nombre);

            // Limpiar resto
            cmbCDDestino.Items.Clear();
            listViewEncomiendas.Items.Clear();
            cmbServicio.Items.Clear();
            labelMuestraTipoArrendamiento.Text = "";
            btnGuardar.Enabled = false;
        }
       

        // ── CAMBIO DE LOCALIDAD DESTINO ──────────────────────
        private void cmbLocalidadDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocalidadDestino.SelectedIndex < 0) return;

            string localidad = cmbLocalidadDestino.SelectedItem.ToString();

            // Autorrellenar CD Destino
            cmbCDDestino.Items.Clear();
            cmbCDDestino.Items.Add(modelo.ObtenerCdDestino(localidad));
            cmbCDDestino.SelectedIndex = 0;

            // Cargar guías admitidas para esa localidad
            listViewEncomiendas.Items.Clear();
            guiasSeleccionadas.Clear();
            labelMuestraTipoArrendamiento.Text = "";
            btnGuardar.Enabled = false;

            var guias = modelo.ObtenerGuiasPorLocalidad(localidad);

            if (guias.Count == 0)
            {
                MessageBox.Show(
                    "No existen encomiendas admitidas para la localidad destino seleccionada.",
                    "Sin encomiendas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cmbServicio.Items.Clear();
                return;
            }

            foreach (var g in guias)
            {
                ListViewItem item = new ListViewItem(g.NroTracking);
                item.SubItems.Add(g.Categoria);
                item.SubItems.Add(g.Localidad);
                item.Tag = g;
                listViewEncomiendas.Items.Add(item);
            }

            // Cargar empresas de transporte para esa localidad
            cmbServicio.Items.Clear();
            foreach (var emp in modelo.ObtenerEmpresasPorLocalidad(localidad))
                cmbServicio.Items.Add(emp.Nombre);
        }

  
        // ── SELECCIÓN DE ENCOMIENDAS ─────────────────────────
        private void listViewEncomiendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            guiasSeleccionadas.Clear();
            foreach (ListViewItem item in listViewEncomiendas.SelectedItems)
                guiasSeleccionadas.Add((Guia)item.Tag);

            if (guiasSeleccionadas.Count > 0 && cmbServicio.SelectedIndex >= 0)
            {
                string tipoArrendamiento = modelo.CalcularTipoArrendamiento(guiasSeleccionadas);
                labelMuestraTipoArrendamiento.Text = tipoArrendamiento;
                btnGuardar.Enabled = true;
            }
            else
            {
                labelMuestraTipoArrendamiento.Text = "";
                btnGuardar.Enabled = false;
            }
        }

      
        // ── CAMBIO DE SERVICIO ───────────────────────────────
        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServicio.SelectedIndex < 0) return;

            if (guiasSeleccionadas.Count > 0)
            {
                string tipoArrendamiento = modelo.CalcularTipoArrendamiento(guiasSeleccionadas);
                labelMuestraTipoArrendamiento.Text = tipoArrendamiento;
                btnGuardar.Enabled = true;
            }
        }

     
        // ── GUARDAR ──────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (guiasSeleccionadas.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una encomienda para confeccionar la HDR.",
                    "Sin encomiendas seleccionadas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cmbServicio.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar un servicio de transporte.",
                    "Servicio no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string localidad = cmbLocalidadDestino.SelectedItem.ToString();
            var empresas = modelo.ObtenerEmpresasPorLocalidad(localidad);
            EmpresaTransporte empresaSeleccionada = empresas[cmbServicio.SelectedIndex];
            string tipoArrendamiento = labelMuestraTipoArrendamiento.Text;

            DialogResult confirmacion = MessageBox.Show(
                "¿Confirma la confección de la HDR de transporte con " + guiasSeleccionadas.Count + " encomienda(s) vía " + empresaSeleccionada.Nombre + "?",
                "Confirmar HDR",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            modelo.GuardarHDR(guiasSeleccionadas, empresaSeleccionada, tipoArrendamiento);

            MessageBox.Show(
                "La HDR de transporte fue confeccionada correctamente.",
                "HDR Confeccionada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar pantalla
            cmbLocalidadDestino.SelectedIndex = -1;
            cmbCDDestino.Items.Clear();
            cmbCDDestino.Text = "";
            listViewEncomiendas.Items.Clear();
            cmbServicio.Items.Clear();
            cmbServicio.Text = "";
            labelMuestraTipoArrendamiento.Text = "";
            guiasSeleccionadas.Clear();
            btnGuardar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
