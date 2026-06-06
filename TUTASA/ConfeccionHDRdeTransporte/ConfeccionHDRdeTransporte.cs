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
        // ── Instancia del modelo ──────────────────────────────
        private ConfeccionHDRdeTransporteModelo modelo = new ConfeccionHDRdeTransporteModelo();

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
            if (modelo.Limpiando) return;
            if (cmbLocalidadDestino.SelectedIndex < 0) return;

            string localidad = cmbLocalidadDestino.SelectedItem.ToString();

            // Autorrellenar CD Destino
            cmbCDDestino.Items.Clear();
            cmbCDDestino.Items.Add(modelo.ObtenerCdDestino(localidad));
            cmbCDDestino.SelectedIndex = 0;

            // Limpiar selección anterior
            modelo.GuiasSeleccionadas.Clear();
            listViewEncomiendas.Items.Clear();
            cmbServicio.Items.Clear();
            cmbServicio.SelectedIndex = -1;
            cmbServicio.Text = "";
            labelMuestraTipoArrendamiento.Text = "";
            btnGuardar.Enabled = false;

            // Buscar guías admitidas para esa localidad
            var guias = modelo.ObtenerGuiasPorLocalidad(localidad);

            if (guias.Count == 0)
            {
                MessageBox.Show(
                    "No existen encomiendas admitidas para la localidad destino seleccionada.",
                    "Sin encomiendas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Cargar guías en la ListView con CheckBoxes
            foreach (var g in guias)
            {
                ListViewItem item = new ListViewItem(g.NroTracking);
                item.SubItems.Add(g.Categoria);
                item.SubItems.Add(g.Localidad);
                item.Tag = g;
                listViewEncomiendas.Items.Add(item);
            }

            // Cargar empresas de transporte para esa localidad
            foreach (var emp in modelo.ObtenerEmpresasPorLocalidad(localidad))
                cmbServicio.Items.Add(emp.Nombre);
        }

        // ── SELECCIÓN DE ENCOMIENDAS VIA CHECKBOX ────────────
        private void listViewEncomiendas_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            // Recalcular guías seleccionadas
            modelo.GuiasSeleccionadas.Clear();
            foreach (ListViewItem item in listViewEncomiendas.Items)
            {
                if (item.Checked)
                    modelo.GuiasSeleccionadas.Add((Guia)item.Tag);
            }

            if (modelo.GuiasSeleccionadas.Count > 0 && cmbServicio.SelectedIndex >= 0)
            {
                labelMuestraTipoArrendamiento.Text = modelo.CalcularTipoArrendamiento(modelo.GuiasSeleccionadas);
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

            if (modelo.GuiasSeleccionadas.Count > 0)
            {
                // Recalcular tipo de arrendamiento con el nuevo servicio
                labelMuestraTipoArrendamiento.Text = modelo.CalcularTipoArrendamiento(modelo.GuiasSeleccionadas);
                btnGuardar.Enabled = true;
            }
        }

        // ── GUARDAR ──────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Recalcular guías seleccionadas via CheckBox
            modelo.GuiasSeleccionadas.Clear();
            foreach (ListViewItem item in listViewEncomiendas.Items)
            {
                if (item.Checked)
                    modelo.GuiasSeleccionadas.Add((Guia)item.Tag);
            }

            // Validar que haya al menos una encomienda seleccionada
            if (modelo.GuiasSeleccionadas.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una encomienda para confeccionar la HDR.",
                    "Sin encomiendas seleccionadas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado un servicio
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
            EmpresaTransporte empresaSeleccionada = modelo.ObtenerEmpresasPorLocalidad(localidad)[cmbServicio.SelectedIndex];
            string tipoArrendamiento = labelMuestraTipoArrendamiento.Text;

            DialogResult confirmacion = MessageBox.Show(
                "¿Confirma la confección de la HDR de transporte con " + modelo.GuiasSeleccionadas.Count + " encomienda(s) vía " + empresaSeleccionada.Nombre + "?",
                "Confirmar HDR",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            // Guardar HDR en el modelo
            modelo.GuardarHDR(empresaSeleccionada, tipoArrendamiento);

            MessageBox.Show(
                "La HDR de transporte fue confeccionada correctamente.",
                "HDR Confeccionada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar pantalla
            modelo.Limpiando = true;
            cmbLocalidadDestino.SelectedIndex = -1;
            cmbLocalidadDestino.Text = "";
            cmbCDDestino.Items.Clear();
            cmbCDDestino.Text = "";
            listViewEncomiendas.Items.Clear();
            cmbServicio.Items.Clear();
            cmbServicio.Text = "";
            labelMuestraTipoArrendamiento.Text = "";
            btnGuardar.Enabled = false;
            modelo.Limpiando = false;
        }

        // ── CANCELAR ─────────────────────────────────────────
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}