using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.RendicionHDRdeUltMilla;

namespace TUTASA.Pantallas
{
    public partial class RendicionHDRdeUltMilla : Form
    {
        private RendicionHDRUltMillaModelo modelo = new RendicionHDRUltMillaModelo();
        private Fletero fleteroActual = null;
        private List<HDR> hdrsRendidas = new List<HDR>();
        public RendicionHDRdeUltMilla()
        {
            InitializeComponent();
        }

        // ── LOAD ─────────────────────────────────────────────
        private void RendicionHDRdeUltMilla_Load(object sender, EventArgs e)
        {
            listViewHDRRendidas.Items.Clear();
            listViewHDRaEntregar.Items.Clear();
            cmbNroHDR.Items.Clear();
            lblMuestraFletero.Text = "";
            btnConfirmar.Enabled = false;
        }

        // ── SELECCIONAR FLETERO ──────────────────────────────
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // Validar DNI no vacío
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show(
                    "Debe ingresar un DNI para buscar el fletero.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDNI.Focus();
                return;
            }

            // Validar que el DNI sea numérico y no supere 8 dígitos
            if (txtDNI.Text.Trim().Length > 8 || !long.TryParse(txtDNI.Text.Trim(), out _))
            {
                MessageBox.Show(
                    "El DNI ingresado es inválido. Debe contener como máximo 8 dígitos numéricos.",
                    "DNI inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDNI.Clear();
                txtDNI.Focus();
                return;
            }

            // Buscar fletero
            fleteroActual = modelo.BuscarFleteroPorDNI(txtDNI.Text.Trim());

            if (fleteroActual == null)
            {
                MessageBox.Show(
                    "El DNI ingresado no corresponde a ningún fletero registrado en el sistema.",
                    "Fletero no encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDNI.Clear();
                txtDNI.Focus();
                lblMuestraFletero.Text = "";
                return;
            }

            // Mostrar nombre del fletero
            lblMuestraFletero.Text = fleteroActual.NombreCompleto;

            // Cargar HDRs pendientes del fletero
            cmbNroHDR.Items.Clear();
            listViewHDRRendidas.Items.Clear();
            listViewHDRaEntregar.Items.Clear();
            hdrsRendidas.Clear();
            btnConfirmar.Enabled = false;

            var hdrs = modelo.ObtenerHDRsPorFletero(fleteroActual.Id);

            if (hdrs.Count == 0)
            {
                MessageBox.Show(
                    "El fletero seleccionado no tiene HDRs pendientes de rendición.",
                    "Sin HDRs pendientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            foreach (var h in hdrs)
                cmbNroHDR.Items.Add(h.NroHDR);

            // Cargar lista informativa de HDRs a entregar
            foreach (var h in hdrs)
            {
                ListViewItem item = new ListViewItem(h.NroHDR);
                item.SubItems.Add(h.Cliente);
                item.SubItems.Add(h.Localidad);
                item.SubItems.Add(h.Direccion);
                item.SubItems.Add(h.Entrega);
                item.Tag = h;
                listViewHDRaEntregar.Items.Add(item);
            }
        }

        // ── ACEPTAR HDR RENDIDA ──────────────────────────────
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbNroHDR.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar un Nro de HDR.",
                    "HDR no seleccionada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!radioBtnCumplida.Checked && !radioBtnNoCumplida.Checked)
            {
                MessageBox.Show(
                    "Debe indicar si la HDR fue cumplida o no cumplida.",
                    "Estado no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obtener HDR seleccionada
            var hdrs = modelo.ObtenerHDRsPorFletero(fleteroActual.Id);
            string nroHDRSeleccionada = cmbNroHDR.SelectedItem.ToString();
            HDR hdrSeleccionada = null;
            foreach (var h in hdrs)
            {
                if (h.NroHDR == nroHDRSeleccionada)
                {
                    hdrSeleccionada = h;
                    break;
                }
            }

            if (hdrSeleccionada == null)
            {
                MessageBox.Show(
                    "No se encontró la HDR seleccionada.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Verificar que no esté ya en la lista
            foreach (var h in hdrsRendidas)
            {
                if (h.NroHDR == hdrSeleccionada.NroHDR)
                {
                    MessageBox.Show(
                        "Esta HDR ya fue agregada a la lista de rendición.",
                        "HDR duplicada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            bool cumplida = radioBtnCumplida.Checked;
            modelo.RendirHDR(hdrSeleccionada, cumplida);
            hdrsRendidas.Add(hdrSeleccionada);

            // Agregar a la ListView de rendidas
            ListViewItem item = new ListViewItem(hdrSeleccionada.NroHDR);
            item.SubItems.Add(hdrSeleccionada.Cliente);
            item.SubItems.Add(hdrSeleccionada.Localidad);
            item.SubItems.Add(hdrSeleccionada.Direccion);
            item.SubItems.Add(cumplida ? "Sí" : "No");
            item.SubItems.Add(hdrSeleccionada.Entrega);
            item.Tag = hdrSeleccionada;
            listViewHDRRendidas.Items.Add(item);

            // Limpiar selección
            cmbNroHDR.SelectedIndex = -1;
            radioBtnCumplida.Checked = false;
            radioBtnNoCumplida.Checked = false;

            btnConfirmar.Enabled = true;
        }

   

        // ── QUITAR HDR ───────────────────────────────────────
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (listViewHDRRendidas.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Debe seleccionar una HDR de la lista para quitarla.",
                    "Sin selección",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            HDR hdrAQuitar = (HDR)listViewHDRRendidas.SelectedItems[0].Tag;
            hdrsRendidas.Remove(hdrAQuitar);
            listViewHDRRendidas.Items.Remove(listViewHDRRendidas.SelectedItems[0]);

            if (hdrsRendidas.Count == 0)
                btnConfirmar.Enabled = false;
        }


        // ── CONFIRMAR ────────────────────────────────────────
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (hdrsRendidas.Count == 0)
            {
                MessageBox.Show(
                    "Debe agregar al menos una HDR a la lista de rendición.",
                    "Sin HDRs rendidas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Confirma la rendición de " + hdrsRendidas.Count + " HDR(s) del fletero " + fleteroActual.NombreCompleto + "?",
                "Confirmar rendición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            modelo.ConfirmarRendicion(hdrsRendidas);

            MessageBox.Show(
                "La rendición fue confirmada correctamente.",
                "Rendición confirmada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar pantalla
            txtDNI.Clear();
            lblMuestraFletero.Text = "";
            cmbNroHDR.Items.Clear();
            cmbNroHDR.Text = "";
            radioBtnCumplida.Checked = false;
            radioBtnNoCumplida.Checked = false;
            listViewHDRRendidas.Items.Clear();
            listViewHDRaEntregar.Items.Clear();
            hdrsRendidas.Clear();
            fleteroActual = null;
            btnConfirmar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
