using System;
using System.Windows.Forms;

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
            // Estado inicial: nada seleccionado, combos vacíos y deshabilitados
            cmbCD.Enabled = false;
            cmbCDdeAgencia.Enabled = false;
            cmbAgencias.Enabled = false;

            // Cargar los CDs en ambos combos
            CargarCDs();

            // Ocultar secciones hasta que se seleccione un radio
            btnDomicilio.Visible = false;
            cmbCD.Visible = false;
            lblCentrosdeDistribucion.Visible = false;

            btnAgencia.Visible = false;
            cmbCDdeAgencia.Visible = false;
            lblCDAgencias.Visible = false;
            cmbAgencias.Visible = false;
            lblAgencias.Visible = false;

            // Botones del menú deshabilitados hasta que se configure el punto operativo
            HabilitarBotones(false);
        }

        private void CargarCDs()
        {
            // TODO: reemplazar por carga desde modelo/base de datos
            var cds = new[] { "Buenos Aires - Retiro", "Córdoba", "Rosario", "Mendoza" };
            cmbCD.Items.Clear();
            cmbCDdeAgencia.Items.Clear();
            foreach (var cd in cds)
            {
                cmbCD.Items.Add(cd);
                cmbCDdeAgencia.Items.Add(cd);
            }
        }

        private void CargarAgenciasPorCD(string nombreCD)
        {
            // TODO: reemplazar por carga desde modelo/base de datos filtrando por CD
            cmbAgencias.Items.Clear();
            cmbAgencias.Items.Add($"Agencia 1 de {nombreCD}");
            cmbAgencias.Items.Add($"Agencia 2 de {nombreCD}");
        }

        // ── Radio buttons ────────────────────────────────────────────

        private void radioBtnCD_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioBtnCD.Checked) return;

            // Mostrar sección CD, ocultar sección Agencia
            btnDomicilio.Visible = true;
            btnDomicilio.BackColor = System.Drawing.SystemColors.ActiveCaption;

            cmbCD.Visible = true;
            cmbCD.Enabled = true;
            lblCentrosdeDistribucion.Visible = true;

            btnAgencia.Visible = false;
            cmbCDdeAgencia.Visible = false;
            lblCDAgencias.Visible = false;
            cmbAgencias.Visible = false;
            lblAgencias.Visible = false;

            cmbCDdeAgencia.SelectedIndex = -1;
            cmbAgencias.Items.Clear();

            ActualizarBotonesSegunTipo();
        }

        private void radioBtnAgencia_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioBtnAgencia.Checked) return;

            // Ocultar sección CD, mostrar sección Agencia
            btnDomicilio.Visible = false;
            cmbCD.Visible = false;
            lblCentrosdeDistribucion.Visible = false;
            cmbCD.SelectedIndex = -1;

            btnAgencia.Visible = true;
            btnAgencia.BackColor = System.Drawing.SystemColors.ActiveCaption;

            cmbCDdeAgencia.Visible = true;
            cmbCDdeAgencia.Enabled = true;
            lblCDAgencias.Visible = true;

            cmbAgencias.Visible = true;
            cmbAgencias.Enabled = false; // se habilita al elegir CD
            lblAgencias.Visible = true;

            cmbCDdeAgencia.SelectedIndex = -1;
            cmbAgencias.Items.Clear();

            ActualizarBotonesSegunTipo();
        }

        // ── Combo de CD para agencias ────────────────────────────────

        private void cmbCDdeAgencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCDdeAgencia.SelectedIndex == -1) return;

            CargarAgenciasPorCD(cmbCDdeAgencia.SelectedItem.ToString());
            cmbAgencias.Enabled = true;
            cmbAgencias.SelectedIndex = -1;
        }

        // ── Habilitar/deshabilitar botones del menú ──────────────────

        private void ActualizarBotonesSegunTipo()
        {
            bool esCD = radioBtnCD.Checked;
            bool esAgencia = radioBtnAgencia.Checked;

            // Operativo
            button1.Enabled = esCD;        // Imposición Call Center
            button2.Enabled = esAgencia;   // Imposición Agencia
            btnImposicionCD.Enabled = esCD;
            btnConfeccionHDR.Enabled = esCD;
            btnRendicionHDR.Enabled = esCD;
            btnAdmision.Enabled = esCD;
            btnDespacho.Enabled = esCD;
            btnRecepcionTransporte.Enabled = esCD;
            btnEntregaCD.Enabled = true;   // Entrega de Encomienda: ambos

            // Administrativo
            button3.Enabled = esCD;        // Emitir Factura
            button4.Enabled = esCD;        // Costos vs Ventas

            // Informativo
            btnTracking.Enabled = esCD;    // Consultar Tracking
        }

        private void HabilitarBotones(bool habilitar)
        {
            button1.Enabled = habilitar;
            button2.Enabled = habilitar;
            btnImposicionCD.Enabled = habilitar;
            btnConfeccionHDR.Enabled = habilitar;
            btnRendicionHDR.Enabled = habilitar;
            btnAdmision.Enabled = habilitar;
            btnDespacho.Enabled = habilitar;
            btnRecepcionTransporte.Enabled = habilitar;
            btnEntregaCD.Enabled = habilitar;
            button3.Enabled = habilitar;
            button4.Enabled = habilitar;
            btnTracking.Enabled = habilitar;
        }

        // ── Validación al navegar ────────────────────────────────────

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

        // ── Botones del menú (ejemplo con validación) ─────────────────

        private void btnImposicionCD_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccion()) return;
            // TODO: abrir frmImposicionCD
        }

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
    }
}
