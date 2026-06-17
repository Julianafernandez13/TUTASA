using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.EmitirFactura;

namespace TUTASA.Forms.Administracion
{
    public partial class EmitirFactura : Form
    {
        //instancia del modelo de EmitirFactura
        private EmitirFacturaModelo modelo = new EmitirFacturaModelo();
        private Cliente clienteActual = null;
        private List<MovimientoPendiente> movimientosActuales = new List<MovimientoPendiente>();
        public EmitirFactura()
        {
            InitializeComponent();
        }

        // ── LOAD ─────────────────────────────────────────────
        private void EmitirFactura_Load(object sender, EventArgs e)
        {
            // Cargar meses
            cmbMes.Items.Clear();
            cmbMes.Items.Add("Enero");
            cmbMes.Items.Add("Febrero");
            cmbMes.Items.Add("Marzo");
            cmbMes.Items.Add("Abril");
            cmbMes.Items.Add("Mayo");
            cmbMes.Items.Add("Junio");
            cmbMes.Items.Add("Julio");
            cmbMes.Items.Add("Agosto");
            cmbMes.Items.Add("Septiembre");
            cmbMes.Items.Add("Octubre");
            cmbMes.Items.Add("Noviembre");
            cmbMes.Items.Add("Diciembre");

            // Cargar años
            cmbAño.Items.Clear();
            cmbAño.Items.Add("2025");
            cmbAño.Items.Add("2026");
            cmbAño.Items.Add("2027");

            // Seleccionar mes y año actual por defecto
            cmbMes.SelectedIndex = DateTime.Now.Month - 1;
            cmbAño.SelectedItem = DateTime.Now.Year.ToString();

            // Deshabilitar botón emitir hasta que haya movimientos
            btnEmitirFactura.Enabled = false;

            // Limpiar tabla y total
            listViewMovimientos.Items.Clear();
            lblMostrarTotal.Text = "";

        }

        // ── BUSCAR ───────────────────────────────────────────

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar que el CUIT no esté vacío
            if (string.IsNullOrWhiteSpace(txtCUIT.Text))
            {
                MessageBox.Show(
                    "Debe ingresar un CUIT para buscar.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCUIT.Focus();
                return;
            }

            // Validar que el CUIT tenga exactamente 11 dígitos numéricos
            if (txtCUIT.Text.Trim().Length != 11 || !long.TryParse(txtCUIT.Text.Trim(), out _))
            {
                MessageBox.Show(
                    "El CUIT ingresado es inválido. Debe contener 11 dígitos numéricos.",
                    "CUIT inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCUIT.Clear();
                txtCUIT.Focus();
                return;
            }

            // Buscar cliente
            clienteActual = modelo.BuscarClientePorCUIT(txtCUIT.Text.Trim());

            if (clienteActual == null)
            {
                MessageBox.Show(
                    "El CUIT ingresado no corresponde a ningún cliente registrado en el sistema.",
                    "Cliente no encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCUIT.Clear();
                txtCUIT.Focus();
                lblMostrarCliente.Text = "";
                return;
            }

            // Mostrar nombre del cliente
            lblMostrarCliente.Text = clienteActual.NombreCompleto;

  
        }

        
        

        // ── EMITIR FACTURA ───────────────────────────────────

        private void btnEmitirFactura_Click(object sender, EventArgs e)
        {
            // Confirmación antes de emitir
            DialogResult confirmacion = MessageBox.Show(
                "¿Confirma la emisión de la factura por $" + lblMostrarTotal.Text + " para el cliente " + clienteActual.NombreCompleto + "?",
                "Confirmar emisión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            // Marcar movimientos como facturados
            modelo.EmitirFactura(movimientosActuales, clienteActual.Id, clienteActual.TipoFactura);

            MessageBox.Show(
                "La factura fue emitida correctamente y los movimientos quedaron registrados como facturados.",
                "Factura emitida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar pantalla
            txtCUIT.Clear();
            lblMostrarCliente.Text = "";
            listViewMovimientos.Items.Clear();
            lblMostrarTotal.Text = "";
            btnEmitirFactura.Enabled = false;
            clienteActual = null;
            movimientosActuales.Clear();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ── BUSCAR PERÍODO ───────────────────────────────────
        private void btnBuscarPeriodo_Click(object sender, EventArgs e)
        {
            if (clienteActual == null)
            {
                MessageBox.Show("Primero debe buscar un cliente ingresando el CUIT.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbMes.SelectedIndex < 0 || cmbAño.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un mes y un año.", "Período incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int mes = cmbMes.SelectedIndex + 1;
            int anio = int.Parse(cmbAño.SelectedItem.ToString());

            movimientosActuales = modelo.ObtenerMovimientosPendientes(clienteActual.Id, mes, anio);

            listViewMovimientos.Items.Clear();
            lblMostrarTotal.Text = "";
            btnEmitirFactura.Enabled = false;

            if (movimientosActuales.Count == 0)
            {
                MessageBox.Show("No existen movimientos pendientes para este cliente en el período.", "Sin movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var m in movimientosActuales)
            {
                decimal totalConIVA = modelo.CalcularTotal(new List<MovimientoPendiente> { m }, clienteActual.TipoFactura);
                ListViewItem item = new ListViewItem(m.NroGuia);
                item.SubItems.Add(m.Fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(m.Origen);
                item.SubItems.Add(m.Destino);
                item.SubItems.Add(m.Categoria);
                item.SubItems.Add("$" + totalConIVA.ToString("N2"));
                item.Tag = m;
                listViewMovimientos.Items.Add(item);
            }

            decimal totalGeneral = modelo.CalcularTotal(movimientosActuales, clienteActual.TipoFactura);
            lblMostrarTotal.Text = "$" + totalGeneral.ToString("N2");
            btnEmitirFactura.Enabled = true;
        }
    }
}
