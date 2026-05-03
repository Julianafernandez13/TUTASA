namespace TUTASA.Forms.CallCenter
{
    partial class frmSolicitudRetiro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.grpRetiro = new System.Windows.Forms.GroupBox();
            this.lblDomicilioRetiro = new System.Windows.Forms.Label();
            this.txtDomicilioRetiro = new System.Windows.Forms.TextBox();
            this.lblCantidadCajas = new System.Windows.Forms.Label();
            this.nudCantidadCajas = new System.Windows.Forms.NumericUpDown();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.rbS = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbL = new System.Windows.Forms.RadioButton();
            this.rbXL = new System.Windows.Forms.RadioButton();
            this.grpDestinatario = new System.Windows.Forms.GroupBox();
            this.lblNombreDestinatario = new System.Windows.Forms.Label();
            this.txtNombreDestinatario = new System.Windows.Forms.TextBox();
            this.lblDomicilioEntrega = new System.Windows.Forms.Label();
            this.txtDomicilioEntrega = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpCliente.SuspendLayout();
            this.grpRetiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCajas)).BeginInit();
            this.grpDestinatario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.lblCUIT);
            this.grpCliente.Controls.Add(this.txtCUIT);
            this.grpCliente.Controls.Add(this.btnBuscarCliente);
            this.grpCliente.Controls.Add(this.lblNombreCliente);
            this.grpCliente.Controls.Add(this.txtNombreCliente);
            this.grpCliente.Location = new System.Drawing.Point(12, 12);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(560, 90);
            this.grpCliente.TabIndex = 0;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Datos del Cliente";
            // 
            // lblCUIT
            // 
            this.lblCUIT.Location = new System.Drawing.Point(10, 28);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(40, 20);
            this.lblCUIT.TabIndex = 0;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(55, 25);
            this.txtCUIT.MaxLength = 11;
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(150, 20);
            this.txtCUIT.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(215, 23);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(110, 27);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.Location = new System.Drawing.Point(10, 58);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(120, 20);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre del cliente:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreCliente.Location = new System.Drawing.Point(135, 55);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(410, 20);
            this.txtNombreCliente.TabIndex = 4;
            // 
            // grpRetiro
            // 
            this.grpRetiro.Controls.Add(this.lblDomicilioRetiro);
            this.grpRetiro.Controls.Add(this.txtDomicilioRetiro);
            this.grpRetiro.Controls.Add(this.lblCantidadCajas);
            this.grpRetiro.Controls.Add(this.nudCantidadCajas);
            this.grpRetiro.Controls.Add(this.lblCategoria);
            this.grpRetiro.Controls.Add(this.rbS);
            this.grpRetiro.Controls.Add(this.rbM);
            this.grpRetiro.Controls.Add(this.rbL);
            this.grpRetiro.Controls.Add(this.rbXL);
            this.grpRetiro.Location = new System.Drawing.Point(12, 115);
            this.grpRetiro.Name = "grpRetiro";
            this.grpRetiro.Size = new System.Drawing.Size(560, 120);
            this.grpRetiro.TabIndex = 1;
            this.grpRetiro.TabStop = false;
            this.grpRetiro.Text = "Datos del Retiro";
            // 
            // lblDomicilioRetiro
            // 
            this.lblDomicilioRetiro.Location = new System.Drawing.Point(10, 28);
            this.lblDomicilioRetiro.Name = "lblDomicilioRetiro";
            this.lblDomicilioRetiro.Size = new System.Drawing.Size(120, 20);
            this.lblDomicilioRetiro.TabIndex = 0;
            this.lblDomicilioRetiro.Text = "Domicilio de retiro:";
            // 
            // txtDomicilioRetiro
            // 
            this.txtDomicilioRetiro.Location = new System.Drawing.Point(135, 25);
            this.txtDomicilioRetiro.Name = "txtDomicilioRetiro";
            this.txtDomicilioRetiro.Size = new System.Drawing.Size(410, 20);
            this.txtDomicilioRetiro.TabIndex = 1;
            // 
            // lblCantidadCajas
            // 
            this.lblCantidadCajas.Location = new System.Drawing.Point(10, 65);
            this.lblCantidadCajas.Name = "lblCantidadCajas";
            this.lblCantidadCajas.Size = new System.Drawing.Size(115, 20);
            this.lblCantidadCajas.TabIndex = 2;
            this.lblCantidadCajas.Text = "Cantidad de cajas:";
            // 
            // nudCantidadCajas
            // 
            this.nudCantidadCajas.Location = new System.Drawing.Point(130, 63);
            this.nudCantidadCajas.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudCantidadCajas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadCajas.Name = "nudCantidadCajas";
            this.nudCantidadCajas.Size = new System.Drawing.Size(60, 20);
            this.nudCantidadCajas.TabIndex = 3;
            this.nudCantidadCajas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(210, 65);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(115, 20);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría de caja:";
            // 
            // rbS
            // 
            this.rbS.Checked = true;
            this.rbS.Location = new System.Drawing.Point(330, 63);
            this.rbS.Name = "rbS";
            this.rbS.Size = new System.Drawing.Size(45, 20);
            this.rbS.TabIndex = 5;
            this.rbS.TabStop = true;
            this.rbS.Text = "S";
            // 
            // rbM
            // 
            this.rbM.Location = new System.Drawing.Point(375, 63);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(45, 20);
            this.rbM.TabIndex = 6;
            this.rbM.Text = "M";
            // 
            // rbL
            // 
            this.rbL.Location = new System.Drawing.Point(420, 63);
            this.rbL.Name = "rbL";
            this.rbL.Size = new System.Drawing.Size(45, 20);
            this.rbL.TabIndex = 7;
            this.rbL.Text = "L";
            // 
            // rbXL
            // 
            this.rbXL.Location = new System.Drawing.Point(465, 63);
            this.rbXL.Name = "rbXL";
            this.rbXL.Size = new System.Drawing.Size(50, 20);
            this.rbXL.TabIndex = 8;
            this.rbXL.Text = "XL";
            // 
            // grpDestinatario
            // 
            this.grpDestinatario.Controls.Add(this.lblNombreDestinatario);
            this.grpDestinatario.Controls.Add(this.txtNombreDestinatario);
            this.grpDestinatario.Controls.Add(this.lblDomicilioEntrega);
            this.grpDestinatario.Controls.Add(this.txtDomicilioEntrega);
            this.grpDestinatario.Controls.Add(this.lblLocalidad);
            this.grpDestinatario.Controls.Add(this.txtLocalidad);
            this.grpDestinatario.Controls.Add(this.lblCodigoPostal);
            this.grpDestinatario.Controls.Add(this.txtCodigoPostal);
            this.grpDestinatario.Controls.Add(this.lblTelefono);
            this.grpDestinatario.Controls.Add(this.txtTelefono);
            this.grpDestinatario.Location = new System.Drawing.Point(12, 248);
            this.grpDestinatario.Name = "grpDestinatario";
            this.grpDestinatario.Size = new System.Drawing.Size(560, 163);
            this.grpDestinatario.TabIndex = 2;
            this.grpDestinatario.TabStop = false;
            this.grpDestinatario.Text = "Datos del Destinatario";
            // 
            // lblNombreDestinatario
            // 
            this.lblNombreDestinatario.Location = new System.Drawing.Point(10, 28);
            this.lblNombreDestinatario.Name = "lblNombreDestinatario";
            this.lblNombreDestinatario.Size = new System.Drawing.Size(115, 20);
            this.lblNombreDestinatario.TabIndex = 0;
            this.lblNombreDestinatario.Text = "Nombre y apellido:";
            // 
            // txtNombreDestinatario
            // 
            this.txtNombreDestinatario.Location = new System.Drawing.Point(135, 25);
            this.txtNombreDestinatario.Name = "txtNombreDestinatario";
            this.txtNombreDestinatario.Size = new System.Drawing.Size(410, 20);
            this.txtNombreDestinatario.TabIndex = 1;
            // 
            // lblDomicilioEntrega
            // 
            this.lblDomicilioEntrega.Location = new System.Drawing.Point(10, 63);
            this.lblDomicilioEntrega.Name = "lblDomicilioEntrega";
            this.lblDomicilioEntrega.Size = new System.Drawing.Size(130, 20);
            this.lblDomicilioEntrega.TabIndex = 2;
            this.lblDomicilioEntrega.Text = "Domicilio de entrega:";
            // 
            // txtDomicilioEntrega
            // 
            this.txtDomicilioEntrega.Location = new System.Drawing.Point(145, 60);
            this.txtDomicilioEntrega.Name = "txtDomicilioEntrega";
            this.txtDomicilioEntrega.Size = new System.Drawing.Size(400, 20);
            this.txtDomicilioEntrega.TabIndex = 3;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.Location = new System.Drawing.Point(10, 98);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(65, 20);
            this.lblLocalidad.TabIndex = 4;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(80, 95);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(200, 20);
            this.txtLocalidad.TabIndex = 5;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.Location = new System.Drawing.Point(295, 98);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(90, 20);
            this.lblCodigoPostal.TabIndex = 6;
            this.lblCodigoPostal.Text = "Código postal:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(390, 95);
            this.txtCodigoPostal.MaxLength = 8;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(155, 20);
            this.txtCodigoPostal.TabIndex = 7;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(10, 133);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(135, 20);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Teléfono de contacto:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(150, 130);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(354, 421);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(130, 35);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar Solicitud";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(494, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 35);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            // 
            // frmSolicitudRetiro
            // 
            this.ClientSize = new System.Drawing.Size(611, 468);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpRetiro);
            this.Controls.Add(this.grpDestinatario);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmSolicitudRetiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de Retiro a Domicilio";
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpRetiro.ResumeLayout(false);
            this.grpRetiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCajas)).EndInit();
            this.grpDestinatario.ResumeLayout(false);
            this.grpDestinatario.PerformLayout();
            this.ResumeLayout(false);

        }

        // ── DECLARACIONES ────────────────────────────────────────
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.GroupBox grpRetiro;
        private System.Windows.Forms.GroupBox grpDestinatario;

        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;

        private System.Windows.Forms.Label lblDomicilioRetiro;
        private System.Windows.Forms.TextBox txtDomicilioRetiro;
        private System.Windows.Forms.Label lblCantidadCajas;
        private System.Windows.Forms.NumericUpDown nudCantidadCajas;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.RadioButton rbS;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbL;
        private System.Windows.Forms.RadioButton rbXL;

        private System.Windows.Forms.Label lblNombreDestinatario;
        private System.Windows.Forms.TextBox txtNombreDestinatario;
        private System.Windows.Forms.Label lblDomicilioEntrega;
        private System.Windows.Forms.TextBox txtDomicilioEntrega;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}