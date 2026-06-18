using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TUTASA.Almacenes;
using TUTASA.Forms.Agencia;
using TUTASA.Forms.CallCenter;
using TUTASA.Forms.CD;
using TUTASA.Forms.Administracion;
using TUTASA.Pantallas;

namespace TUTASA.Forms.Menu
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarCDs();

            // Todo visible pero deshabilitado al inicio
            cmbCD.Enabled = false;
            cmbCDdeAgencia.Enabled = false;
            cmbAgencias.Enabled = false;

            // Headers en gris (ninguno seleccionado aún)
            btnDomicilio.BackColor = System.Drawing.SystemColors.ControlDark;
            btnAgencia.BackColor = System.Drawing.SystemColors.ControlDark;

            // Botones del menú deshabilitados hasta configurar punto operativo
            HabilitarBotones(false);
        }

        private void CargarCDs()
        {
            var cds = CentroDistribucionAlmacen.ObtenerTodos();

            cmbCD.DataSource = null;
            cmbCDdeAgencia.DataSource = null;

            cmbCD.DataSource = new List<CentroDistribucionEntidad>(cds);
            cmbCD.DisplayMember = "NombreCD";
            cmbCD.ValueMember = "IdCD";
            cmbCD.SelectedIndex = -1;

            cmbCDdeAgencia.DataSource = new List<CentroDistribucionEntidad>(cds);
            cmbCDdeAgencia.DisplayMember = "NombreCD";
            cmbCDdeAgencia.ValueMember = "IdCD";
            cmbCDdeAgencia.SelectedIndex = -1;
        }

        private void CargarAgenciasPorCD(int idCD)
        {
            var agencias = AgenciaAlmacen.ObtenerTodos()
                                         .Where(a => a.IdCD == idCD)
                                         .ToList();

            cmbAgencias.DataSource = null;
            cmbAgencias.DataSource = agencias;
            cmbAgencias.DisplayMember = "NombreAgencia";
            cmbAgencias.ValueMember = "IdAgencia";
            cmbAgencias.SelectedIndex = -1;
        }

        // ── Radio buttons ─────────────────────────────────────────────

        private void radioBtnCD_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioBtnCD.Checked) return;

            // Header CD activo (azul), Agencia apagado (gris)
            btnDomicilio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            btnAgencia.BackColor = System.Drawing.SystemColors.ControlDark;

            // Habilitar solo combo de CD
            cmbCD.Enabled = true;
            cmbCDdeAgencia.Enabled = false;
            cmbAgencias.Enabled = false;

            // Limpiar selección de agencia
            cmbCDdeAgencia.SelectedIndex = -1;
            cmbAgencias.DataSource = null;

            ActualizarBotonesSegunTipo();
        }

        private void radioBtnAgencia_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioBtnAgencia.Checked) return;

            // Header Agencia activo (azul), CD apagado (gris)
            btnDomicilio.BackColor = System.Drawing.SystemColors.ControlDark;
            btnAgencia.BackColor = System.Drawing.SystemColors.ActiveCaption;

            // Habilitar combos de agencia, deshabilitar CD
            cmbCD.Enabled = false;
            cmbCDdeAgencia.Enabled = true;
            cmbAgencias.Enabled = false; // se habilita al elegir CD

            // Limpiar selección de CD
            cmbCD.SelectedIndex = -1;
            cmbAgencias.DataSource = null;

            ActualizarBotonesSegunTipo();
        }

        // ── Combo CD de agencia ───────────────────────────────────────

        private void cmbCDdeAgencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCDdeAgencia.SelectedIndex == -1) return;

            // Conversión segura
            if (!int.TryParse(cmbCDdeAgencia.SelectedValue?.ToString(), out int idCD)) return;

            CargarAgenciasPorCD(idCD);
            cmbAgencias.Enabled = true;
        }

        // ── Botones del menú ──────────────────────────────────────────

        private void ActualizarBotonesSegunTipo()
        {
            bool esCD = radioBtnCD.Checked;
            bool esAgencia = radioBtnAgencia.Checked;

            btnImposicionCallCenter.Enabled = esCD;                // Imposición Call Center
            btnImposicionAgencia.Enabled = esAgencia;           // Imposición Agencia
            btnImposicionCD.Enabled = esCD;        // Imposición CD
            btnConfeccionHDR.Enabled = esCD;       // HDR de Retiro
            btnRendicionHDR.Enabled = esCD;        // Rendición HDR de Retiro
            btnAdmision.Enabled = esCD;            // Admisión
            btnDespacho.Enabled = esCD;            // HDR de Transporte
            btnRecepcionTransporte.Enabled = esCD; // Rendición HDR de Transporte
            btnEntregaCD.Enabled = true;           // Entrega de Encomienda: ambos
            btnEmitirFactura.Enabled = esCD;                // Emitir Factura
            btnCostosVentas.Enabled = esCD;                // Costos vs Ventas
            btnTracking.Enabled = esCD;            // Consultar Tracking
        }

        private void HabilitarBotones(bool habilitar)
        {
            btnImposicionCallCenter.Enabled = habilitar;
            btnImposicionAgencia.Enabled = habilitar;
            btnImposicionCD.Enabled = habilitar;
            btnConfeccionHDR.Enabled = habilitar;
            btnRendicionHDR.Enabled = habilitar;
            btnAdmision.Enabled = habilitar;
            btnDespacho.Enabled = habilitar;
            btnRecepcionTransporte.Enabled = habilitar;
            btnEntregaCD.Enabled = habilitar;
            btnEmitirFactura.Enabled = habilitar;
            btnCostosVentas.Enabled = habilitar;
            btnTracking.Enabled = habilitar;
        }

        // ── Validación ────────────────────────────────────────────────

        private bool ValidarSeleccion()
        {
            if (!radioBtnCD.Checked && !radioBtnAgencia.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de punto operativo.",
                    "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (radioBtnCD.Checked && cmbCD.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el CD donde se encuentra.",
                    "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (radioBtnAgencia.Checked)
            {
                if (cmbCDdeAgencia.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar el CD al que pertenece la agencia.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (cmbAgencias.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar la agencia en la que se encuentra.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        // ── Eventos de botones del menú ───────────────────────────────

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                "¿Está seguro que desea cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
                this.Close();
        }

        private void lblBienvenida_Click(object sender, EventArgs e) { }

        private void btnImposicionCallCenter_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;
            var form = new frmImposicionCallCenter();
            form.ShowDialog();
        }

        private void btnImposicionCD_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;
            var form = new frmImposicionCD();
            form.ShowDialog();
        }


        private void btnImposicionAgencia_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;
            var form = new frmImposicionAgencia();
            form.ShowDialog();
        }

        private void btnConfeccionHDR_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;
            var form = new frmConfeccionHDRdeUltMilla();
            form.ShowDialog();
        }

        private void btnRendicionHDR_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;
            var form = new frmRendicionHDRdeUltMilla();
            form.ShowDialog();
        }

        private void btnAdmision_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;
            var form = new frmAdmision();
            form.ShowDialog();
        }

        private void btnDespacho_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;
            var form = new frmConfeccionHDRdeTransporte();
            form.ShowDialog();
        }

        private void btnRecepcionTransporte_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;
            var form = new frmRendicionHDRTransporte();
            form.ShowDialog();
        }

        private void btnEntregaCD_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;
            var form = new frmEntrega();
            form.ShowDialog();
        }

        private void btnEmitirFactura_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;
            var form = new frmEmitirFactura();
            form.ShowDialog();
        }

        private void btnCostosVentas_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;
            var form = new frmCostovsVentas();
            form.ShowDialog();
        }

        private void btnTracking_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;
            var form = new frmConsultaTracking();
            form.ShowDialog();
        }
    }
}