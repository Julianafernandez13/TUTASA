using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TUTASA.ConfeccionHDRdeUltMilla;

namespace TUTASA.Pantallas
{
    public partial class frmConfeccionHDRdeUltMilla : Form
    {
        private ConfeccionHDRdeUltMillaModelo modelo = new ConfeccionHDRdeUltMillaModelo();
        

        public frmConfeccionHDRdeUltMilla()
        {
            InitializeComponent();
        }

        // ── LOAD ─────────────────────────────────────────────

        private void ConfeccionHDRdeUltMilla_Load(object sender, EventArgs e)
        {
            cmbLocalidad.Items.Clear();
            cmbDomicilio.Items.Clear();
            listViewGuiasARutear.Items.Clear();
            cmbFleteros.Items.Clear();
            btnConfirmar.Enabled = false;
        }

        private void radioBtnEntrega_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioBtnEntrega.Checked) return;

            // Limpiar controles dependientes
            modelo.Limpiando = true;
            cmbLocalidad.Items.Clear();
            cmbLocalidad.SelectedIndex = -1;
            cmbLocalidad.Text = "";
            cmbDomicilio.Items.Clear();
            cmbDomicilio.Text = "";
            listViewGuiasARutear.Items.Clear();
            cmbFleteros.Items.Clear();
            cmbFleteros.Text = "";
            btnConfirmar.Enabled = false;
            modelo.Limpiando = false;

            // Cargar localidades que tienen guías en estado Pendiente de Distribución
            foreach (var loc in modelo.ObtenerLocalidadesPorTipo("Entrega"))
                cmbLocalidad.Items.Add(loc);
        }

        private void radioBtnRetiro_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioBtnRetiro.Checked) return;

            // Limpiar controles dependientes
            modelo.Limpiando = true;
            cmbLocalidad.Items.Clear();
            cmbLocalidad.SelectedIndex = -1;
            cmbLocalidad.Text = "";
            cmbDomicilio.Items.Clear();
            cmbDomicilio.Text = "";
            listViewGuiasARutear.Items.Clear();
            cmbFleteros.Items.Clear();
            cmbFleteros.Text = "";
            btnConfirmar.Enabled = false;
            modelo.Limpiando = false;

            // Cargar localidades que tienen guías en estado Impuesta
            foreach (var loc in modelo.ObtenerLocalidadesPorTipo("Retiro"))
                cmbLocalidad.Items.Add(loc);
        }

        // ── CAMBIO DE LOCALIDAD ──────────────────────────────
        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (modelo.Limpiando) return;
            if (cmbLocalidad.SelectedIndex < 0) return;
            if (!radioBtnEntrega.Checked && !radioBtnRetiro.Checked) return;

            string localidad = cmbLocalidad.SelectedItem.ToString();
            string tipoHDR = radioBtnEntrega.Checked ? "Entrega" : "Retiro";

            // Limpiar controles dependientes
            modelo.Limpiando = true;
            cmbDomicilio.Items.Clear();
            cmbDomicilio.Text = "";
            listViewGuiasARutear.Items.Clear();
            cmbFleteros.Items.Clear();
            cmbFleteros.Text = "";
            btnConfirmar.Enabled = false;
            modelo.Limpiando = false;

            // Cargar domicilios de esa localidad según el tipo de HDR
            foreach (var dom in modelo.ObtenerDomiciliosPorLocalidadYTipo(localidad, tipoHDR))
                cmbDomicilio.Items.Add(dom);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado el tipo de HDR
            if (!radioBtnEntrega.Checked && !radioBtnRetiro.Checked)
            {
                MessageBox.Show(
                    "Debe seleccionar el tipo de HDR a confeccionar: Entrega o Retiro.",
                    "Tipo no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validar localidad
            if (cmbLocalidad.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar una localidad.",
                    "Localidad no seleccionada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validar domicilio
            if (cmbDomicilio.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar un domicilio.",
                    "Domicilio no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string localidad = cmbLocalidad.SelectedItem.ToString();
            string domicilio = cmbDomicilio.SelectedItem.ToString();
            string tipoHDR = radioBtnEntrega.Checked ? "Entrega" : "Retiro";

            // Obtener guías pendientes y guardarlas en el modelo
            modelo.GuiasEncontradas = modelo.ObtenerGuiasPendientes(localidad, domicilio, tipoHDR);

            listViewGuiasARutear.Items.Clear();
            cmbFleteros.Items.Clear();
            cmbFleteros.Text = "";
            btnConfirmar.Enabled = false;

            if (modelo.GuiasEncontradas.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron guías pendientes para la localidad y domicilio seleccionados.",
                    "Sin guías",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Cargar guías en la ListView
            foreach (var g in modelo.GuiasEncontradas)
            {
                ListViewItem item = new ListViewItem(g.NroTracking);
                item.SubItems.Add(g.NombreRemitente);
                item.SubItems.Add(g.DomicilioEntrega);
                item.SubItems.Add(g.Localidad);
                item.SubItems.Add(g.Categoria);
                item.SubItems.Add(g.Agencia);
                item.Tag = g;
                listViewGuiasARutear.Items.Add(item);
            }

            // Cargar fleteros disponibles para esa localidad
            foreach (var f in modelo.ObtenerFleterosPorLocalidad(localidad))
                cmbFleteros.Items.Add(f.NombreCompleto);
        }

        // ── SELECCIÓN DE FLETERO ─────────────────────────────
        private void cmbFleteros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilitar confirmar solo si hay guías y fletero seleccionado
            if (listViewGuiasARutear.Items.Count > 0 && cmbFleteros.SelectedIndex >= 0)
                btnConfirmar.Enabled = true;
            else
                btnConfirmar.Enabled = false;
        }

        // ── CONFIRMAR ────────────────────────────────────────
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Obtener guías seleccionadas via CheckBox
            var guiasSeleccionadas = new List<Guia>();
            foreach (ListViewItem item in listViewGuiasARutear.Items)
            {
                if (item.Checked)
                    guiasSeleccionadas.Add((Guia)item.Tag);
            }

            // Validar que haya al menos una guía seleccionada
            if (guiasSeleccionadas.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una guía para confeccionar la HDR.",
                    "Sin guías seleccionadas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obtener fletero seleccionado
            string localidad = cmbLocalidad.SelectedItem.ToString();
            string tipoHDR = radioBtnEntrega.Checked ? "Entrega" : "Retiro";
            Fletero fleteroSeleccionado = modelo.ObtenerFleterosPorLocalidad(localidad)[cmbFleteros.SelectedIndex];

            // Confirmar HDR en el modelo
            modelo.ConfirmarHDR(guiasSeleccionadas, fleteroSeleccionado, tipoHDR);

            MessageBox.Show(
                "La HDR de " + tipoHDR + " fue confeccionada correctamente y asignada al fletero " + fleteroSeleccionado.NombreCompleto + ".",
                "HDR Confeccionada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar pantalla
            modelo.Limpiando = true;
            radioBtnEntrega.Checked = false;
            radioBtnRetiro.Checked = false;
            cmbLocalidad.Items.Clear();
            cmbLocalidad.SelectedIndex = -1;
            cmbLocalidad.Text = "";
            cmbDomicilio.Items.Clear();
            cmbDomicilio.SelectedIndex = -1;
            cmbDomicilio.Text = "";
            listViewGuiasARutear.Items.Clear();
            cmbFleteros.Items.Clear();
            cmbFleteros.SelectedIndex = -1;
            cmbFleteros.Text = "";
            btnConfirmar.Enabled = false;
            modelo.Limpiando = false;
        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
