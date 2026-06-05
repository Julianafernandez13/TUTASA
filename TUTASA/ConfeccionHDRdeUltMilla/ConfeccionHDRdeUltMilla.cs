using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.ConfeccionHDRdeUltMilla;

namespace TUTASA.Pantallas
{
    public partial class ConfeccionHDRdeUltMilla : Form
    {
        private ConfeccionHDRdeUltMillaModelo modelo = new ConfeccionHDRdeUltMillaModelo();
        private List<Guia> guiasEncontradas = new List<Guia>();
        private bool limpiando = false;

        public ConfeccionHDRdeUltMilla()
        {
            InitializeComponent();
        }

        // ── LOAD ─────────────────────────────────────────────

    

        private void ConfeccionHDRdeUltMilla_Load(object sender, EventArgs e)
        {
            // Cargar localidades en el ComboBox
            cmbLocalidad.Items.Clear();
            foreach (var loc in modelo.ObtenerLocalidades())
                cmbLocalidad.Items.Add(loc.Nombre);

            // Limpiar domicilio y lista
            cmbDomicilio.Items.Clear();
            listViewGuiasARutear.Items.Clear();
            cmbFleteros.Items.Clear();

            // Deshabilitar botón confirmar hasta que haya guías y fletero
            btnConfirmar.Enabled = false;
        }
   
        // ── CAMBIO DE LOCALIDAD ──────────────────────────────
        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (limpiando) return;
            if (cmbLocalidad.SelectedIndex < 0) return;

            string localidad = cmbLocalidad.SelectedItem.ToString();

            // Cargar domicilios de esa localidad
            cmbDomicilio.Items.Clear();
            foreach (var dom in modelo.ObtenerDomiciliosPorLocalidad(localidad))
                cmbDomicilio.Items.Add(dom);

            // Limpiar lista y fleteros
            listViewGuiasARutear.Items.Clear();
            cmbFleteros.Items.Clear();
            btnConfirmar.Enabled = false;
        }
             
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar tipo de confección
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

            // Buscar guías pendientes
            guiasEncontradas = modelo.ObtenerGuiasPendientes(localidad, domicilio);

            listViewGuiasARutear.Items.Clear();
            cmbFleteros.Items.Clear();
            btnConfirmar.Enabled = false;

            if (guiasEncontradas.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron guías pendientes para la localidad y domicilio seleccionados.",
                    "Sin guías",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // Cargar guías en la ListView
            foreach (var g in guiasEncontradas)
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
            // Validar que haya al menos una guía seleccionada
            if (listViewGuiasARutear.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una guía para confeccionar la HDR.",
                    "Sin guías seleccionadas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obtener guías seleccionadas
            var guiasSeleccionadas = new List<Guia>();
            foreach (ListViewItem item in listViewGuiasARutear.SelectedItems)
                guiasSeleccionadas.Add((Guia)item.Tag);

            // Obtener fletero seleccionado
            Fletero fleteroSeleccionado = modelo.ObtenerFleterosPorLocalidad(
                cmbLocalidad.SelectedItem.ToString())[cmbFleteros.SelectedIndex];

            // Confirmar
            modelo.ConfirmarHDR(guiasSeleccionadas, fleteroSeleccionado);

            MessageBox.Show(
                "La HDR fue confeccionada correctamente y asignada al fletero " + fleteroSeleccionado.NombreCompleto + ".",
                "HDR Confeccionada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar pantalla
            limpiando = true;
            radioBtnEntrega.Checked = false;
            radioBtnRetiro.Checked = false;
            cmbLocalidad.SelectedIndex = -1;
            cmbDomicilio.Items.Clear();
            cmbDomicilio.SelectedIndex =-1;
            listViewGuiasARutear.Items.Clear();
            cmbFleteros.Items.Clear();
            cmbFleteros.SelectedIndex = -1;
            btnConfirmar.Enabled = false;
            limpiando = false;
            cmbDomicilio.Text = "";
            cmbFleteros.Text = "";
        }
        // ── CANCELAR ─────────────────────────────────────────
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
