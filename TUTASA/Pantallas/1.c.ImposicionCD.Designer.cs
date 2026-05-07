namespace TUTASA.Forms.CD
{
    partial class frmImposicionCD
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
            this.grpRemitente = new System.Windows.Forms.GroupBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblNombreRemitente = new System.Windows.Forms.Label();
            this.txtNombreRemitente = new System.Windows.Forms.TextBox();
            this.grpEncomienda = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.rbS = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbL = new System.Windows.Forms.RadioButton();
            this.rbXL = new System.Windows.Forms.RadioButton();
            this.lblCantidadBultos = new System.Windows.Forms.Label();
            this.nudCantidadBultos = new System.Windows.Forms.NumericUpDown();
            this.lblTipoEntrega = new System.Windows.Forms.Label();
            this.rbDomicilio = new System.Windows.Forms.RadioButton();
            this.rbAgenciaCD = new System.Windows.Forms.RadioButton();
            this.grpDestinatario = new System.Windows.Forms.GroupBox();
            this.lblNombreDestinatario = new System.Windows.Forms.Label();
            this.txtNombreDestinatario = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
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
            this.grpRemitente.SuspendLayout();
            this.grpEncomienda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadBultos)).BeginInit();
            this.grpDestinatario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRemitente
            // 
            this.grpRemitente.Controls.Add(this.lblCUIT);
            this.grpRemitente.Controls.Add(this.txtCUIT);
            this.grpRemitente.Controls.Add(this.btnBuscarCliente);
            this.grpRemitente.Controls.Add(this.lblNombreRemitente);
            this.grpRemitente.Controls.Add(this.txtNombreRemitente);
            this.grpRemitente.Location = new System.Drawing.Point(12, 12);
            this.grpRemitente.Name = "grpRemitente";
            this.grpRemitente.Size = new System.Drawing.Size(560, 90);
            this.grpRemitente.TabIndex = 0;
            this.grpRemitente.TabStop = false;
            this.grpRemitente.Text = "Datos del Remitente";
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
            this.txtCUIT.Size = new System.Drawing.Size(150, 26);
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
            // lblNombreRemitente
            // 
            this.lblNombreRemitente.Location = new System.Drawing.Point(10, 58);
            this.lblNombreRemitente.Name = "lblNombreRemitente";
            this.lblNombreRemitente.Size = new System.Drawing.Size(130, 20);
            this.lblNombreRemitente.TabIndex = 3;
            this.lblNombreRemitente.Text = "Nombre del remitente:";
            // 
            // txtNombreRemitente
            // 
            this.txtNombreRemitente.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreRemitente.Location = new System.Drawing.Point(145, 55);
            this.txtNombreRemitente.Name = "txtNombreRemitente";
            this.txtNombreRemitente.ReadOnly = true;
            this.txtNombreRemitente.Size = new System.Drawing.Size(400, 26);
            this.txtNombreRemitente.TabIndex = 4;
            // 
            // grpEncomienda
            // 
            this.grpEncomienda.Controls.Add(this.lblCategoria);
            this.grpEncomienda.Controls.Add(this.rbS);
            this.grpEncomienda.Controls.Add(this.rbM);
            this.grpEncomienda.Controls.Add(this.rbL);
            this.grpEncomienda.Controls.Add(this.rbXL);
            this.grpEncomienda.Controls.Add(this.lblCantidadBultos);
            this.grpEncomienda.Controls.Add(this.nudCantidadBultos);
            this.grpEncomienda.Controls.Add(this.lblTipoEntrega);
            this.grpEncomienda.Controls.Add(this.rbDomicilio);
            this.grpEncomienda.Controls.Add(this.rbAgenciaCD);
            this.grpEncomienda.Location = new System.Drawing.Point(12, 115);
            this.grpEncomienda.Name = "grpEncomienda";
            this.grpEncomienda.Size = new System.Drawing.Size(560, 137);
            this.grpEncomienda.TabIndex = 1;
            this.grpEncomienda.TabStop = false;
            this.grpEncomienda.Text = "Datos de la Encomienda";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(10, 28);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(115, 20);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría de caja:";
            // 
            // rbS
            // 
            this.rbS.Checked = true;
            this.rbS.Location = new System.Drawing.Point(130, 26);
            this.rbS.Name = "rbS";
            this.rbS.Size = new System.Drawing.Size(45, 20);
            this.rbS.TabIndex = 1;
            this.rbS.TabStop = true;
            this.rbS.Text = "S";
            // 
            // rbM
            // 
            this.rbM.Location = new System.Drawing.Point(178, 26);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(45, 20);
            this.rbM.TabIndex = 2;
            this.rbM.Text = "M";
            // 
            // rbL
            // 
            this.rbL.Location = new System.Drawing.Point(226, 26);
            this.rbL.Name = "rbL";
            this.rbL.Size = new System.Drawing.Size(45, 20);
            this.rbL.TabIndex = 3;
            this.rbL.Text = "L";
            // 
            // rbXL
            // 
            this.rbXL.Location = new System.Drawing.Point(274, 26);
            this.rbXL.Name = "rbXL";
            this.rbXL.Size = new System.Drawing.Size(50, 20);
            this.rbXL.TabIndex = 4;
            this.rbXL.Text = "XL";
            // 
            // lblCantidadBultos
            // 
            this.lblCantidadBultos.Location = new System.Drawing.Point(10, 63);
            this.lblCantidadBultos.Name = "lblCantidadBultos";
            this.lblCantidadBultos.Size = new System.Drawing.Size(120, 20);
            this.lblCantidadBultos.TabIndex = 5;
            this.lblCantidadBultos.Text = "Cantidad de bultos:";
            // 
            // nudCantidadBultos
            // 
            this.nudCantidadBultos.Location = new System.Drawing.Point(135, 61);
            this.nudCantidadBultos.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudCantidadBultos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadBultos.Name = "nudCantidadBultos";
            this.nudCantidadBultos.Size = new System.Drawing.Size(60, 26);
            this.nudCantidadBultos.TabIndex = 6;
            this.nudCantidadBultos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTipoEntrega
            // 
            this.lblTipoEntrega.Location = new System.Drawing.Point(10, 98);
            this.lblTipoEntrega.Name = "lblTipoEntrega";
            this.lblTipoEntrega.Size = new System.Drawing.Size(105, 20);
            this.lblTipoEntrega.TabIndex = 7;
            this.lblTipoEntrega.Text = "Tipo de entrega:";
            // 
            // rbDomicilio
            // 
            this.rbDomicilio.Checked = true;
            this.rbDomicilio.Location = new System.Drawing.Point(120, 96);
            this.rbDomicilio.Name = "rbDomicilio";
            this.rbDomicilio.Size = new System.Drawing.Size(100, 20);
            this.rbDomicilio.TabIndex = 8;
            this.rbDomicilio.TabStop = true;
            this.rbDomicilio.Text = "A domicilio";
            // 
            // rbAgenciaCD
            // 
            this.rbAgenciaCD.Location = new System.Drawing.Point(228, 96);
            this.rbAgenciaCD.Name = "rbAgenciaCD";
            this.rbAgenciaCD.Size = new System.Drawing.Size(170, 20);
            this.rbAgenciaCD.TabIndex = 9;
            this.rbAgenciaCD.Text = "En agencia o CD destino";
            // 
            // grpDestinatario
            // 
            this.grpDestinatario.Controls.Add(this.lblNombreDestinatario);
            this.grpDestinatario.Controls.Add(this.txtNombreDestinatario);
            this.grpDestinatario.Controls.Add(this.lblDNI);
            this.grpDestinatario.Controls.Add(this.txtDNI);
            this.grpDestinatario.Controls.Add(this.lblDomicilioEntrega);
            this.grpDestinatario.Controls.Add(this.txtDomicilioEntrega);
            this.grpDestinatario.Controls.Add(this.lblLocalidad);
            this.grpDestinatario.Controls.Add(this.txtLocalidad);
            this.grpDestinatario.Controls.Add(this.lblCodigoPostal);
            this.grpDestinatario.Controls.Add(this.txtCodigoPostal);
            this.grpDestinatario.Controls.Add(this.lblTelefono);
            this.grpDestinatario.Controls.Add(this.txtTelefono);
            this.grpDestinatario.Location = new System.Drawing.Point(12, 258);
            this.grpDestinatario.Name = "grpDestinatario";
            this.grpDestinatario.Size = new System.Drawing.Size(560, 207);
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
            this.txtNombreDestinatario.Size = new System.Drawing.Size(410, 26);
            this.txtNombreDestinatario.TabIndex = 1;
            // 
            // lblDNI
            // 
            this.lblDNI.Location = new System.Drawing.Point(10, 63);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(40, 20);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(55, 60);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(150, 26);
            this.txtDNI.TabIndex = 3;
            // 
            // lblDomicilioEntrega
            // 
            this.lblDomicilioEntrega.Location = new System.Drawing.Point(10, 98);
            this.lblDomicilioEntrega.Name = "lblDomicilioEntrega";
            this.lblDomicilioEntrega.Size = new System.Drawing.Size(130, 20);
            this.lblDomicilioEntrega.TabIndex = 4;
            this.lblDomicilioEntrega.Text = "Domicilio de entrega:";
            // 
            // txtDomicilioEntrega
            // 
            this.txtDomicilioEntrega.Location = new System.Drawing.Point(145, 95);
            this.txtDomicilioEntrega.Name = "txtDomicilioEntrega";
            this.txtDomicilioEntrega.Size = new System.Drawing.Size(400, 26);
            this.txtDomicilioEntrega.TabIndex = 5;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.Location = new System.Drawing.Point(10, 133);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(65, 20);
            this.lblLocalidad.TabIndex = 6;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(80, 130);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(200, 26);
            this.txtLocalidad.TabIndex = 7;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.Location = new System.Drawing.Point(295, 133);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(90, 20);
            this.lblCodigoPostal.TabIndex = 8;
            this.lblCodigoPostal.Text = "Código postal:";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(390, 130);
            this.txtCodigoPostal.MaxLength = 8;
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(155, 26);
            this.txtCodigoPostal.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(10, 168);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(135, 20);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Teléfono de contacto:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(150, 165);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 26);
            this.txtTelefono.TabIndex = 11;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(351, 485);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(135, 35);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar Imposición";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(492, 485);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 35);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            // 
            // frmImposicionCD
            // 
            this.ClientSize = new System.Drawing.Size(584, 524);
            this.Controls.Add(this.grpRemitente);
            this.Controls.Add(this.grpEncomienda);
            this.Controls.Add(this.grpDestinatario);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmImposicionCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Imposición en CD";
            this.grpRemitente.ResumeLayout(false);
            this.grpRemitente.PerformLayout();
            this.grpEncomienda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadBultos)).EndInit();
            this.grpDestinatario.ResumeLayout(false);
            this.grpDestinatario.PerformLayout();
            this.ResumeLayout(false);

        }

        // ── DECLARACIONES ────────────────────────────────────────
        private System.Windows.Forms.GroupBox grpRemitente;
        private System.Windows.Forms.GroupBox grpEncomienda;
        private System.Windows.Forms.GroupBox grpDestinatario;

        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblNombreRemitente;
        private System.Windows.Forms.TextBox txtNombreRemitente;

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.RadioButton rbS;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbL;
        private System.Windows.Forms.RadioButton rbXL;
        private System.Windows.Forms.Label lblCantidadBultos;
        private System.Windows.Forms.NumericUpDown nudCantidadBultos;
        private System.Windows.Forms.Label lblTipoEntrega;
        private System.Windows.Forms.RadioButton rbDomicilio;
        private System.Windows.Forms.RadioButton rbAgenciaCD;

        private System.Windows.Forms.Label lblNombreDestinatario;
        private System.Windows.Forms.TextBox txtNombreDestinatario;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
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