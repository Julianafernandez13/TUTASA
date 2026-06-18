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
    public partial class frmRendicionHDRdeUltMilla : Form
    {
        // ── Instancia del modelo ──────────────────────────────
        private RendicionHDRUltMillaModelo modelo = new RendicionHDRUltMillaModelo();

        public frmRendicionHDRdeUltMilla()
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
            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Debe ingresar un DNI para buscar el fletero.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return;
            }

            if (txtDNI.Text.Trim().Length > 8 || !long.TryParse(txtDNI.Text.Trim(), out _))
            {
                MessageBox.Show("El DNI ingresado es inválido. Debe contener como máximo 8 dígitos numéricos.", "DNI inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Clear();
                txtDNI.Focus();
                return;
            }

            // Buscar fletero por DNI
            modelo.FleteroActual = modelo.BuscarFleteroPorDNI(txtDNI.Text.Trim());

            if (modelo.FleteroActual == null)
            {
                MessageBox.Show("El DNI ingresado no corresponde a ningún fletero registrado en el sistema.", "Fletero no encontrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Clear();
                txtDNI.Focus();
                lblMuestraFletero.Text = "";
                return;
            }

            // Mostrar nombre del fletero
            lblMuestraFletero.Text = modelo.FleteroActual.NombreCompleto;

            // Limpiar controles
            cmbNroHDR.Items.Clear();
            listViewHDRRendidas.Items.Clear();
            listViewHDRaEntregar.Items.Clear();
            modelo.HdrsRendidas.Clear();
            

            // Cargar HDRs en proceso en el ComboBox para rendir
            var hdrsEnProceso = modelo.ObtenerHDRsEnProcesoPorFletero(modelo.FleteroActual.Id);
            foreach (var h in hdrsEnProceso)
                cmbNroHDR.Items.Add(h.NroHDR);

            // Cargar HDRs pendientes en la lista informativa — las que hay que entregarle hoy
            var hdrsPendientes = modelo.ObtenerHDRsPendientesPorFletero(modelo.FleteroActual.Id);
            foreach (var h in hdrsPendientes)
            {
                ListViewItem item = new ListViewItem(h.NroHDR);
                item.SubItems.Add(h.Cliente);
                item.SubItems.Add(h.Localidad);
                item.SubItems.Add(h.Direccion);
                item.SubItems.Add(h.Entrega);
                item.Tag = h;
                listViewHDRaEntregar.Items.Add(item);
            }

            btnConfirmar.Enabled = hdrsPendientes.Count > 0;

            if (hdrsEnProceso.Count == 0 && hdrsPendientes.Count == 0)
            {
                MessageBox.Show("El fletero seleccionado no tiene HDRs pendientes ni en proceso.", "Sin HDRs",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ── ACEPTAR HDR RENDIDA ──────────────────────────────
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbNroHDR.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un Nro de HDR.", "HDR no seleccionada",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!radioBtnCumplida.Checked && !radioBtnNoCumplida.Checked)
            {
                MessageBox.Show("Debe indicar si la HDR fue cumplida o no cumplida.", "Estado no seleccionado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            // Buscar HDR seleccionada por nombre
            var hdrsEnProceso = modelo.ObtenerHDRsEnProcesoPorFletero(modelo.FleteroActual.Id);
            string nroHDRSeleccionada = cmbNroHDR.SelectedItem.ToString();
            HDR hdrSeleccionada = null;

            foreach (var h in hdrsEnProceso)
            {
                if (h.NroHDR == nroHDRSeleccionada)
                {
                    hdrSeleccionada = h;
                    break;
                }
            }

            if (hdrSeleccionada == null)
            {
                MessageBox.Show("No se encontró la HDR seleccionada.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que no esté ya en la lista de rendidas
            foreach (var h in modelo.HdrsRendidas)
            {
                if (h.NroHDR == hdrSeleccionada.NroHDR)
                {
                    MessageBox.Show("Esta HDR ya fue agregada a la lista de rendición.", "HDR duplicada",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            bool cumplida = radioBtnCumplida.Checked;
            modelo.RendirHDR(hdrSeleccionada, cumplida);
            modelo.HdrsRendidas.Add(hdrSeleccionada);

            // Agregar a la ListView de rendidas
            ListViewItem item = new ListViewItem(hdrSeleccionada.NroHDR);
            item.SubItems.Add(hdrSeleccionada.Cliente);
            item.SubItems.Add(hdrSeleccionada.Localidad);
            item.SubItems.Add(hdrSeleccionada.Direccion);
            item.SubItems.Add(cumplida ? "Sí" : "No");
            item.SubItems.Add(hdrSeleccionada.Entrega);
            item.Tag = hdrSeleccionada;
            listViewHDRRendidas.Items.Add(item);

            
            cmbNroHDR.SelectedIndex = -1;
            cmbNroHDR.Items.Remove(nroHDRSeleccionada);
            radioBtnCumplida.Checked = false;
            radioBtnNoCumplida.Checked = false;

            btnConfirmar.Enabled = true;
        }

        // ── QUITAR HDR ───────────────────────────────────────
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (listViewHDRRendidas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una HDR de la lista para quitarla.", "Sin selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HDR hdrAQuitar = (HDR)listViewHDRRendidas.SelectedItems[0].Tag;

            // Revertir el estado a EnProceso para que pueda volver a encontrarse
            modelo.RevertirHDR(hdrAQuitar);

            modelo.HdrsRendidas.Remove(hdrAQuitar);
            listViewHDRRendidas.Items.Remove(listViewHDRRendidas.SelectedItems[0]);

            // Devolver la HDR al ComboBox
            cmbNroHDR.Items.Add(hdrAQuitar.NroHDR);

            if (modelo.HdrsRendidas.Count == 0 && listViewHDRaEntregar.Items.Count == 0)
                btnConfirmar.Enabled = false;
        }

        // ── CONFIRMAR ────────────────────────────────────────
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (modelo.HdrsRendidas.Count == 0 && listViewHDRaEntregar.Items.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos una HDR a la lista de rendición.", "Sin HDRs rendidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Confirma la rendición de " + modelo.HdrsRendidas.Count + " HDR(s) del fletero " +
                modelo.FleteroActual.NombreCompleto + "?",
                "Confirmar rendición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            // Confirmar rendición y pasar HDRs pendientes a EnProceso
            modelo.ConfirmarRendicion(modelo.HdrsRendidas, modelo.FleteroActual.Id);

            MessageBox.Show("La rendición fue confirmada correctamente.", "Rendición confirmada",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar pantalla
            txtDNI.Clear();
            lblMuestraFletero.Text = "";
            cmbNroHDR.Items.Clear();
            cmbNroHDR.Text = "";
            radioBtnCumplida.Checked = false;
            radioBtnNoCumplida.Checked = false;
            listViewHDRRendidas.Items.Clear();
            listViewHDRaEntregar.Items.Clear();
            modelo.HdrsRendidas.Clear();
            modelo.FleteroActual = null;
            btnConfirmar.Enabled = false;
        }

        // ── CANCELAR ─────────────────────────────────────────
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}