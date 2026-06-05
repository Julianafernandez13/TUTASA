using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.RendicionHDRdeTransporte;

namespace TUTASA.Forms.CD
{
    public partial class RendicionHDRTransporte : Form
    {
        //instancia del modelo de Rendicion HDR Transporte
        private RendicionHDRTransporteModelo modelo = new RendicionHDRTransporteModelo();
        private HDR hdrActual = null;
        private bool limpiando = false;
        public RendicionHDRTransporte()
        {
            InitializeComponent();
        }
        // ── LOAD ─────────────────────────────────────────────
        private void RendicionHDRTransporte_Load(object sender, EventArgs e)
        {
            // Cargar empresas de transporte
            cmbEmpresaTransporte.Items.Clear();
            foreach (var emp in modelo.ObtenerEmpresas())
                cmbEmpresaTransporte.Items.Add(emp.Nombre);

            // Deshabilitar sección HDR hasta que se confirme empresa
            cmbNroHDR.Items.Clear();
            listViewGuias.Items.Clear();
            lblCDOrigen.Text = "";
            lblCDDestino.Text = "";
            lblCantBultos.Text = "";
            btnConfirmarRecepcion.Enabled = false;
        }
      

        // ── SELECCIÓN DE EMPRESA ─────────────────────────────

        private void cmbEmpresaTransporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar sección HDR
            if (limpiando) return;
            cmbNroHDR.Items.Clear();
            listViewGuias.Items.Clear();
            lblCDOrigen.Text = "";
            lblCDDestino.Text = "";
            lblCantBultos.Text = "";
            btnConfirmarRecepcion.Enabled = false;
            hdrActual = null;
        }
        // ── CONFIRMAR RECEPCIÓN ──────────────────────────────

        private void btnConfirmarRecepcion_Click(object sender, EventArgs e)
        {
            if (hdrActual == null) return;

            DialogResult confirmacion = MessageBox.Show(
                "¿Confirma la recepción de la HDR " + hdrActual.NroHDR + " con " + hdrActual.CantBultos + " bultos?",
                "Confirmar recepción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            modelo.ConfirmarRecepcion(hdrActual);

            MessageBox.Show(
                "La recepción de la HDR " + hdrActual.NroHDR + " fue confirmada correctamente.",
                "Recepción confirmada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar pantalla
            limpiando = true;
            cmbEmpresaTransporte.SelectedIndex = -1;
            cmbNroHDR.Items.Clear();
            cmbNroHDR.SelectedIndex = -1;
            listViewGuias.Items.Clear();
            lblCDOrigen.Text = "";
            lblCDDestino.Text = "";
            lblCantBultos.Text = "";
            btnConfirmarRecepcion.Enabled = false;
            hdrActual = null;
            limpiando = false;
            cmbNroHDR.Text = "";
            cmbEmpresaTransporte.Text = "";
        }

        // ── CONFIRMAR EMPRESA ────────────────────────────────
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbEmpresaTransporte.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Debe seleccionar un servicio de transporte.",
                    "Servicio no seleccionado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int idEmpresa = cmbEmpresaTransporte.SelectedIndex + 1;
            var hdrs = modelo.ObtenerHDRsPorEmpresa(idEmpresa);

            cmbNroHDR.Items.Clear();
            listViewGuias.Items.Clear();
            lblCDOrigen.Text = "";
            lblCDDestino.Text = "";
            lblCantBultos.Text = "";
            btnConfirmarRecepcion.Enabled = false;
            hdrActual = null;

            if (hdrs.Count == 0)
            {
                MessageBox.Show(
                    "No existen HDRs pendientes de recepción para el servicio seleccionado.",
                    "Sin HDRs",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            foreach (var h in hdrs)
                cmbNroHDR.Items.Add(h.NroHDR);
        }

        // ── SELECCIÓN DE HDR ─────────────────────────────────
        private void cmbNroHDR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNroHDR.SelectedIndex < 0) return;

            int idEmpresa = cmbEmpresaTransporte.SelectedIndex + 1;
            var hdrs = modelo.ObtenerHDRsPorEmpresa(idEmpresa);
            hdrActual = hdrs[cmbNroHDR.SelectedIndex];

            // Autorrellenar datos de la HDR
            lblCDOrigen.Text = hdrActual.CdOrigen;
            lblCDDestino.Text = hdrActual.CdDestino;
            lblCantBultos.Text = hdrActual.CantBultos.ToString();

            // Cargar guías en la ListView
            listViewGuias.Items.Clear();
            foreach (var g in hdrActual.Guias)
            {
                ListViewItem item = new ListViewItem(g.NroTracking);
                item.SubItems.Add(g.NombreRemitente);
                item.SubItems.Add(g.NombreDestinatario);
                item.SubItems.Add(g.Categoria);
                item.Tag = g;
                listViewGuias.Items.Add(item);
            }

            btnConfirmarRecepcion.Enabled = true;
        }

      

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
