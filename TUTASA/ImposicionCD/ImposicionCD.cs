using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.Enums;
using TUTASA.ImposicionCD;

namespace TUTASA.Forms.CD
{
    public partial class frmImposicionCD : Form
    {
        //instancia del modelo de ImposicionCD
        private ImposicionCDModelo modelo = new ImposicionCDModelo();
        public frmImposicionCD()
        {
            InitializeComponent();
        }


        private void frmImposicionCD_Load(object sender, EventArgs e)
        {
            // Los combos cmbAgencia y cmbCD se cargan dinámicamente
            // al buscar por código postal, no al abrir el formulario

            //al cargar la pantalla, los grupos de domicilio, agencia y CD están deshabilitados hasta que se seleccione uno
            grpDomicilio.Enabled = false;
            grpAgencia.Enabled = false;
            grpCD.Enabled = false;

            lblMuestraNombre.Text = "";
            lblMuestraLocProv.Text = "";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //1) Validar que se ingresó un número de CUIT
            string input = txtCUIT.Text?.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show(
                    "Debe ingresar un numero de CUIT.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            //2) Validar que el CUIT sea numérico y no contenga espacios
            if (!long.TryParse(input, out _))
            {
                MessageBox.Show(
                    "El CUIT debe ser numerico y no puede contener espacios.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // 3) Validar que el CUIT tenga exactamente 11 dígitos
            if (input.Length != 11)
            {
                MessageBox.Show("El CUIT debe tener exactamente 11 dígitos.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4) Buscar el cliente por CUIT
            var cliente = modelo.ObtenerClientes().FirstOrDefault(c => c.CUIT == input);


            if (cliente == null)
            {
                MessageBox.Show(
                    $"No se encontró ningún cliente con CUIT {input}.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                lblMuestraNombre.Text = "";
                return;
            }

            // 5) Mostrar el nombre en el campo de solo lectura
            modelo.SetClienteSeleccionado(cliente);
            lblMuestraNombre.Text = cliente.NombreCompleto;
        }

        private void btnAgregarBulto_Click(object sender, EventArgs e)
        {
            // Validamos que se haya seleccionado un cliente remitente antes de agregar bultos
            if (modelo.GetClienteSeleccionado() == null)
            {
                MessageBox.Show("Debe buscar un cliente remitente antes de agregar bultos.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validamos que se haya seleccionado una categoría de bulto
            CategoriaBulto categoria;
            if (radioBtnS.Checked) categoria = CategoriaBulto.S;
            else if (radioBtnM.Checked) categoria = CategoriaBulto.M;
            else if (radioBtnL.Checked) categoria = CategoriaBulto.L;
            else if (radioBtnXL.Checked) categoria = CategoriaBulto.XL;
            else
            {
                MessageBox.Show("Debe seleccionar una categoría de bulto.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregamos el bulto al modelo
            modelo.AgregarBulto(categoria);

            // Actualizamos la lista de bultos en la interfaz
            var bulto = modelo.GetBultos().Last();
            var item = new ListViewItem(bulto.idGuia.ToString());
            item.SubItems.Add(bulto.Categoria.ToString());
            listViewBultos.Items.Add(item);
        }

        private void btnQuitarBulto_Click(object sender, EventArgs e)
        {
            // Validamos que se haya seleccionado un bulto para quitar
            if (listViewBultos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un bulto para quitar.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtenemos el índice del bulto seleccionado
            int indice = listViewBultos.SelectedIndices[0];
            modelo.QuitarBulto(indice);
            listViewBultos.Items.RemoveAt(indice);

            // Actualizamos los números de guía en la lista después de quitar
            for (int i = 0; i < listViewBultos.Items.Count; i++)
                listViewBultos.Items[i].Text = (i + 1).ToString();
        }

        private void radioBtnDomicilio_CheckedChanged(object sender, EventArgs e)
        {
            grpDomicilio.Enabled = true;
            grpAgencia.Enabled = false;
            grpCD.Enabled = false;

            btnDomicilio.BackColor = SystemColors.ActiveCaption;
            btnAgencia.BackColor = SystemColors.ControlDark;
            btnCD.BackColor = SystemColors.ControlDark;
        }

        private void radioBtnAgencia_CheckedChanged(object sender, EventArgs e)
        {
            grpDomicilio.Enabled = false;
            grpAgencia.Enabled = true;
            grpCD.Enabled = false;

            btnDomicilio.BackColor = SystemColors.ControlDark;
            btnAgencia.BackColor = SystemColors.ActiveCaption;
            btnCD.BackColor = SystemColors.ControlDark;
        
        }

        private void radioBtnCD_CheckedChanged(object sender, EventArgs e)
        {
            grpDomicilio.Enabled = false;
            grpAgencia.Enabled = false;
            grpCD.Enabled = true;

            btnDomicilio.BackColor = SystemColors.ControlDark;
            btnAgencia.BackColor = SystemColors.ControlDark;
            btnCD.BackColor = SystemColors.ActiveCaption;
        }      

        private void btnBuscarLocalidadDom_Click(object sender, EventArgs e)
        {
            string cp = txtCPDom.Text.Trim();

            if (string.IsNullOrWhiteSpace(cp))
            {
                MessageBox.Show("Debe ingresar un código postal para buscar la localidad.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var localidad = modelo.ObtenerCodigosPostales().FirstOrDefault(c => c.idCodPostal == cp);

            if (localidad == null)
            {
                MessageBox.Show("No se encontró el código postal ingresado.", "Sin resultados",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblMuestraLocProv.Text = "";
                return;
            }

            lblMuestraLocProv.Text = $"{localidad.DescripcionLocalidad}, {localidad.DescripcionProvincia}";
        }   

        private void btnBuscarLocalidadAg_Click(object sender, EventArgs e)
        {
            // Limpiamos resultado anterior siempre, antes de cualquier validación
            cmbAgencia.DataSource = null;
            cmbAgencia.Items.Clear();

            string cp = txtCPAg.Text.Trim();

            if (string.IsNullOrWhiteSpace(cp))
            {
                MessageBox.Show(
                    "Debe ingresar un código postal para buscar la agencia.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Verificamos que el CP existe
            var localidad = modelo.ObtenerCodigosPostales().FirstOrDefault(c => c.idCodPostal == cp);

            if (localidad == null)
            {
                MessageBox.Show(
                    "No se encontró el código postal ingresado.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Filtramos agencias que pertenecen a ese CP
            var agencias = modelo.ObtenerAgencias().Where(a => a.CodigoPostal == cp).ToList();

            if (agencias.Count == 0)
            {
                MessageBox.Show(
                    $"No hay agencias registradas para el código postal {cp}.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            cmbAgencia.DataSource = agencias;
            cmbAgencia.DisplayMember = "nombreAgencia";
            cmbAgencia.ValueMember = "idAgencia";
            cmbAgencia.SelectedIndex = -1;
        } 

        private void btnBuscarLocalidadCD_Click(object sender, EventArgs e)
        {
            // Limpiamos resultado anterior siempre, antes de cualquier validación
            cmbCD.DataSource = null;
            cmbCD.Items.Clear();

            string cp = txtCPCD.Text.Trim();

            if (string.IsNullOrWhiteSpace(cp))
            {
                MessageBox.Show(
                    "Debe ingresar un código postal para buscar el CD.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Verificamos que el CP existe
            var localidad = modelo.ObtenerCodigosPostales().FirstOrDefault(c => c.idCodPostal == cp);

            if (localidad == null)
            {
                MessageBox.Show(
                    "No se encontró el código postal ingresado.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Filtramos CDs que tienen ese CP bajo su jurisdicción
            var cds = modelo.ObtenerCentrosDeDistribucion().Where(cd => cd.CodigosPostales.Contains(cp)).ToList();

            if (cds.Count == 0)
            {
                MessageBox.Show(
                    $"No hay centros de distribución para el código postal {cp}.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            cmbCD.DataSource = cds;
            cmbCD.DisplayMember = "nombreCD";
            cmbCD.ValueMember = "idCD";
            cmbCD.SelectedIndex = -1;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // 1) Validar que haya un cliente seleccionado
            if (modelo.GetClienteSeleccionado() == null)
            {
                MessageBox.Show("Debe buscar un cliente remitente antes de confirmar.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2) Validar que haya al menos un bulto
            if (modelo.GetBultos().Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un bulto antes de confirmar.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3) Validar que se haya seleccionado un tipo de entrega
            if (!radioBtnDomicilio.Checked && !radioBtnAgencia.Checked && !radioBtnCD.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de entrega.", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4) Validar campos según tipo de entrega
            if (radioBtnDomicilio.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtNombreDom.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre del destinatario.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDNIDom.Text))
                {
                    MessageBox.Show("Debe ingresar el DNI del destinatario.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTelefonoDom.Text))
                {
                    MessageBox.Show("Debe ingresar el teléfono del destinatario.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDomicilioEntrega.Text))
                {
                    MessageBox.Show("Debe ingresar el domicilio de entrega.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(lblMuestraLocProv.Text))
                {
                    MessageBox.Show("Debe buscar el código postal del destinatario.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (radioBtnAgencia.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtNombreAg.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre del destinatario.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDNIAg.Text))
                {
                    MessageBox.Show("Debe ingresar el DNI del destinatario.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTelefonoAg.Text))
                {
                    MessageBox.Show("Debe ingresar el teléfono del destinatario.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbAgencia.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una agencia de destino.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (radioBtnCD.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtNombreCD.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre del destinatario.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtDNICD.Text))
                {
                    MessageBox.Show("Debe ingresar el DNI del destinatario.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtTelefonoCD.Text))
                {
                    MessageBox.Show("Debe ingresar el teléfono del destinatario.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbCD.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un CD de destino.", "Error de validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // 5) Confirmación antes de procesar
            var resultado = MessageBox.Show(
                $"Está por realizar una imposición de {modelo.GetBultos().Count} bulto(s) " +
                $"a nombre de {modelo.GetClienteSeleccionado().NombreCompleto}.\n\n¿Desea confirmar?",
                "Confirmar imposición",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Cancel)
                return;

            // 6) Armar el destinatario según tipo de entrega y asignarlo a los bultos
            Destinatario destinatario;

            if (radioBtnDomicilio.Checked)
            {
                destinatario = modelo.ConstruirDestinatario(
                    nombre: txtNombreDom.Text.Trim(),
                    dni: txtDNIDom.Text.Trim(),
                    telefono: txtTelefonoDom.Text.Trim(),
                    tipo: TipoEntrega.Domicilio,
                    domicilio: txtDomicilioEntrega.Text.Trim(),
                    codigoPostal: txtCPDom.Text.Trim()
                );
            }
            else if (radioBtnAgencia.Checked)
            {
                destinatario = modelo.ConstruirDestinatario(
                    nombre: txtNombreAg.Text.Trim(),
                    dni: txtDNIAg.Text.Trim(),
                    telefono: txtTelefonoAg.Text.Trim(),
                    tipo: TipoEntrega.Agencia,
                    agencia: (Agencias)cmbAgencia.SelectedItem
                );
            }
            else
            {
                destinatario = modelo.ConstruirDestinatario(
                    nombre: txtNombreCD.Text.Trim(),
                    dni: txtDNICD.Text.Trim(),
                    telefono: txtTelefonoCD.Text.Trim(),
                    tipo: TipoEntrega.CD,
                    cd: (CentrosDeDistribucion)cmbCD.SelectedItem
                );
            }

            modelo.AsignarDestinatarioAGuias(destinatario);

            MessageBox.Show("Imposición registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro que desea cancelar la imposición? Se perderán todos los datos ingresados.", "Cancelar imposición",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
                this.Close();
        }
    }
}
