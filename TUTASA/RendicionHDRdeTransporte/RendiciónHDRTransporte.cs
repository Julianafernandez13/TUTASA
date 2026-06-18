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
    public partial class frmRendicionHDRTransporte : Form
    {
        // ── Instancia del modelo ──────────────────────────────
        private RendicionHDRTransporteModelo modelo = new RendicionHDRTransporteModelo();

        public frmRendicionHDRTransporte()
        {
            InitializeComponent();
        }

        // ── LOAD ─────────────────────────────────────────────
        private void RendicionHDRTransporte_Load(object sender, EventArgs e)
        {
            cmbEmpresaTransporte.Items.Clear();
            modelo.ObtenerEmpresas();
            foreach (var emp in modelo.EmpresasActuales)
                cmbEmpresaTransporte.Items.Add(emp.Nombre);

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
            if (modelo.Limpiando) return;

            cmbNroHDR.Items.Clear();
            listViewGuias.Items.Clear();
            lblCDOrigen.Text = "";
            lblCDDestino.Text = "";
            lblCantBultos.Text = "";
            btnConfirmarRecepcion.Enabled = false;
            modelo.HdrActual = null;
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

            int idEmpresa = modelo.EmpresasActuales[cmbEmpresaTransporte.SelectedIndex].Id;
            modelo.ObtenerHDRsPorEmpresa(idEmpresa);

            cmbNroHDR.Items.Clear();
            listViewGuias.Items.Clear();
            lblCDOrigen.Text = "";
            lblCDDestino.Text = "";
            lblCantBultos.Text = "";
            btnConfirmarRecepcion.Enabled = false;
            modelo.HdrActual = null;

            if (modelo.HDRsActuales.Count == 0)
            {
                MessageBox.Show(
                    "No existen HDRs pendientes de recepción para el servicio seleccionado.",
                    "Sin HDRs",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            foreach (var h in modelo.HDRsActuales)
                cmbNroHDR.Items.Add(h.NroHDR);
        }

        // ── SELECCIÓN DE HDR ─────────────────────────────────
        private void cmbNroHDR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNroHDR.SelectedIndex < 0) return;

            int idEmpresa = modelo.EmpresasActuales[cmbEmpresaTransporte.SelectedIndex].Id;
            modelo.HdrActual = modelo.HDRsActuales[cmbNroHDR.SelectedIndex];

            lblCDOrigen.Text = modelo.HdrActual.CdOrigen;
            lblCDDestino.Text = modelo.HdrActual.CdDestino;
            lblCantBultos.Text = modelo.HdrActual.CantBultos.ToString();

            listViewGuias.Items.Clear();
            foreach (var g in modelo.HdrActual.Guias)
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

        // ── CONFIRMAR RECEPCIÓN ──────────────────────────────
        private void btnConfirmarRecepcion_Click(object sender, EventArgs e)
        {
            if (modelo.HdrActual == null) return;

            DialogResult confirmacion = MessageBox.Show(
                "¿Confirma la recepción de la HDR " + modelo.HdrActual.NroHDR +
                " con " + modelo.HdrActual.CantBultos + " bultos?",
                "Confirmar recepción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            modelo.ConfirmarRecepcion(modelo.HdrActual);

            MessageBox.Show(
                "La recepción de la HDR " + modelo.HdrActual.NroHDR + " fue confirmada correctamente.",
                "Recepción confirmada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar pantalla
            modelo.Limpiando = true;
            cmbEmpresaTransporte.SelectedIndex = -1;
            cmbEmpresaTransporte.Text = "";
            cmbNroHDR.Items.Clear();
            cmbNroHDR.SelectedIndex = -1;
            cmbNroHDR.Text = "";
            listViewGuias.Items.Clear();
            lblCDOrigen.Text = "";
            lblCDDestino.Text = "";
            lblCantBultos.Text = "";
            btnConfirmarRecepcion.Enabled = false;
            modelo.HdrActual = null;
            modelo.Limpiando = false;
        }

        // ── CANCELAR ─────────────────────────────────────────
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
