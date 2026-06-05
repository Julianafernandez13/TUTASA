namespace TUTASA.Forms.Agencia
{
    partial class frmImposicionAgencia
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
            this.groupRemitente = new System.Windows.Forms.GroupBox();
            this.txtMuestraNombre = new System.Windows.Forms.TextBox();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblNombreRemitente = new System.Windows.Forms.Label();
            this.grpBultos = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.radioBtnS = new System.Windows.Forms.RadioButton();
            this.radioBtnM = new System.Windows.Forms.RadioButton();
            this.radioBtnL = new System.Windows.Forms.RadioButton();
            this.radioBtnXL = new System.Windows.Forms.RadioButton();
            this.btnAgregarBulto = new System.Windows.Forms.Button();
            this.listViewBultos = new System.Windows.Forms.ListView();
            this.colNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnQuitarBulto = new System.Windows.Forms.Button();
            this.btnDomicilio = new System.Windows.Forms.Button();
            this.grpDomicilio = new System.Windows.Forms.GroupBox();
            this.textLocProvDom = new System.Windows.Forms.TextBox();
            this.lblProvinciaRetiro = new System.Windows.Forms.Label();
            this.lblNombreDom = new System.Windows.Forms.Label();
            this.txtNombreDom = new System.Windows.Forms.TextBox();
            this.lblDNIDom = new System.Windows.Forms.Label();
            this.txtDNIDom = new System.Windows.Forms.TextBox();
            this.lblTelefonoDom = new System.Windows.Forms.Label();
            this.txtTelefonoDom = new System.Windows.Forms.TextBox();
            this.lblDomicilioEntrega = new System.Windows.Forms.Label();
            this.txtDomicilioEntrega = new System.Windows.Forms.TextBox();
            this.lblCPDom = new System.Windows.Forms.Label();
            this.txtCPDom = new System.Windows.Forms.TextBox();
            this.btnBuscarLocalidadDom = new System.Windows.Forms.Button();
            this.btnAgencia = new System.Windows.Forms.Button();
            this.grpAgencia = new System.Windows.Forms.GroupBox();
            this.lblNombreAg = new System.Windows.Forms.Label();
            this.txtNombreAg = new System.Windows.Forms.TextBox();
            this.lblDNIAg = new System.Windows.Forms.Label();
            this.txtDNIAg = new System.Windows.Forms.TextBox();
            this.lblTelefonoAg = new System.Windows.Forms.Label();
            this.txtTelefonoAg = new System.Windows.Forms.TextBox();
            this.lblCPAg = new System.Windows.Forms.Label();
            this.txtCPAg = new System.Windows.Forms.TextBox();
            this.btnBuscarLocalidadAg = new System.Windows.Forms.Button();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.cmbAgencia = new System.Windows.Forms.ComboBox();
            this.btnCD = new System.Windows.Forms.Button();
            this.grpCD = new System.Windows.Forms.GroupBox();
            this.lblNombreCD = new System.Windows.Forms.Label();
            this.txtNombreCD = new System.Windows.Forms.TextBox();
            this.lblDNICD = new System.Windows.Forms.Label();
            this.txtDNICD = new System.Windows.Forms.TextBox();
            this.lblTelefonoCD = new System.Windows.Forms.Label();
            this.txtTelefonoCD = new System.Windows.Forms.TextBox();
            this.lblCPCD = new System.Windows.Forms.Label();
            this.txtCPCD = new System.Windows.Forms.TextBox();
            this.btnBuscarLocalidadCD = new System.Windows.Forms.Button();
            this.lblCD = new System.Windows.Forms.Label();
            this.cmbCD = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.radioBtnCD = new System.Windows.Forms.RadioButton();
            this.radioBtnAgencia = new System.Windows.Forms.RadioButton();
            this.radioBtnDomicilio = new System.Windows.Forms.RadioButton();
            this.lblDestino = new System.Windows.Forms.Label();
            this.groupRemitente.SuspendLayout();
            this.grpBultos.SuspendLayout();
            this.grpDomicilio.SuspendLayout();
            this.grpAgencia.SuspendLayout();
            this.grpCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupRemitente
            // 
            this.groupRemitente.Controls.Add(this.txtMuestraNombre);
            this.groupRemitente.Controls.Add(this.lblCUIT);
            this.groupRemitente.Controls.Add(this.txtCUIT);
            this.groupRemitente.Controls.Add(this.btnBuscarCliente);
            this.groupRemitente.Controls.Add(this.lblNombreRemitente);
            this.groupRemitente.Location = new System.Drawing.Point(15, 15);
            this.groupRemitente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupRemitente.Name = "groupRemitente";
            this.groupRemitente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupRemitente.Size = new System.Drawing.Size(976, 106);
            this.groupRemitente.TabIndex = 0;
            this.groupRemitente.TabStop = false;
            this.groupRemitente.Text = "Datos del Remitente";
            // 
            // txtMuestraNombre
            // 
            this.txtMuestraNombre.Location = new System.Drawing.Point(104, 72);
            this.txtMuestraNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMuestraNombre.Name = "txtMuestraNombre";
            this.txtMuestraNombre.ReadOnly = true;
            this.txtMuestraNombre.Size = new System.Drawing.Size(223, 26);
            this.txtMuestraNombre.TabIndex = 4;
            
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(14, 34);
            this.lblCUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(50, 20);
            this.lblCUIT.TabIndex = 0;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(104, 29);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(205, 26);
            this.txtCUIT.TabIndex = 1;
           
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(320, 28);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(141, 34);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar cliente";
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblNombreRemitente
            // 
            this.lblNombreRemitente.AutoSize = true;
            this.lblNombreRemitente.Location = new System.Drawing.Point(14, 69);
            this.lblNombreRemitente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreRemitente.Name = "lblNombreRemitente";
            this.lblNombreRemitente.Size = new System.Drawing.Size(69, 20);
            this.lblNombreRemitente.TabIndex = 3;
            this.lblNombreRemitente.Text = "Nombre:";
            // 
            // grpBultos
            // 
            this.grpBultos.Controls.Add(this.lblCategoria);
            this.grpBultos.Controls.Add(this.radioBtnS);
            this.grpBultos.Controls.Add(this.radioBtnM);
            this.grpBultos.Controls.Add(this.radioBtnL);
            this.grpBultos.Controls.Add(this.radioBtnXL);
            this.grpBultos.Controls.Add(this.btnAgregarBulto);
            this.grpBultos.Controls.Add(this.listViewBultos);
            this.grpBultos.Controls.Add(this.btnQuitarBulto);
            this.grpBultos.Location = new System.Drawing.Point(15, 140);
            this.grpBultos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBultos.Name = "grpBultos";
            this.grpBultos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBultos.Size = new System.Drawing.Size(976, 186);
            this.grpBultos.TabIndex = 1;
            this.grpBultos.TabStop = false;
            this.grpBultos.Text = "Bultos";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(14, 34);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(82, 20);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría:";
            // 
            // radioBtnS
            // 
            this.radioBtnS.Checked = true;
            this.radioBtnS.Location = new System.Drawing.Point(104, 31);
            this.radioBtnS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnS.Name = "radioBtnS";
            this.radioBtnS.Size = new System.Drawing.Size(58, 26);
            this.radioBtnS.TabIndex = 1;
            this.radioBtnS.TabStop = true;
            this.radioBtnS.Text = "S";
            
            // 
            // radioBtnM
            // 
            this.radioBtnM.Location = new System.Drawing.Point(166, 31);
            this.radioBtnM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnM.Name = "radioBtnM";
            this.radioBtnM.Size = new System.Drawing.Size(58, 26);
            this.radioBtnM.TabIndex = 2;
            this.radioBtnM.Text = "M";
            
            // 
            // radioBtnL
            // 
            this.radioBtnL.Location = new System.Drawing.Point(231, 31);
            this.radioBtnL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnL.Name = "radioBtnL";
            this.radioBtnL.Size = new System.Drawing.Size(58, 26);
            this.radioBtnL.TabIndex = 3;
            this.radioBtnL.Text = "L";
            
            // 
            // radioBtnXL
            // 
            this.radioBtnXL.Location = new System.Drawing.Point(296, 31);
            this.radioBtnXL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnXL.Name = "radioBtnXL";
            this.radioBtnXL.Size = new System.Drawing.Size(64, 26);
            this.radioBtnXL.TabIndex = 4;
            this.radioBtnXL.Text = "XL";
            
            // 
            // btnAgregarBulto
            // 
            this.btnAgregarBulto.Location = new System.Drawing.Point(380, 28);
            this.btnAgregarBulto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarBulto.Name = "btnAgregarBulto";
            this.btnAgregarBulto.Size = new System.Drawing.Size(141, 34);
            this.btnAgregarBulto.TabIndex = 5;
            this.btnAgregarBulto.Text = "Agregar bulto";
            this.btnAgregarBulto.Click += new System.EventHandler(this.btnAgregarBulto_Click);
            // 
            // listViewBultos
            // 
            this.listViewBultos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum,
            this.colCategoria});
            this.listViewBultos.FullRowSelect = true;
            this.listViewBultos.GridLines = true;
            this.listViewBultos.HideSelection = false;
            this.listViewBultos.Location = new System.Drawing.Point(14, 74);
            this.listViewBultos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewBultos.Name = "listViewBultos";
            this.listViewBultos.Size = new System.Drawing.Size(810, 99);
            this.listViewBultos.TabIndex = 6;
            this.listViewBultos.UseCompatibleStateImageBehavior = false;
            this.listViewBultos.View = System.Windows.Forms.View.Details;
            
            // 
            // colNum
            // 
            this.colNum.Text = "#";
            this.colNum.Width = 50;
            // 
            // colCategoria
            // 
            this.colCategoria.Text = "Categoría";
            this.colCategoria.Width = 120;
            // 
            // btnQuitarBulto
            // 
            this.btnQuitarBulto.Location = new System.Drawing.Point(836, 74);
            this.btnQuitarBulto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitarBulto.Name = "btnQuitarBulto";
            this.btnQuitarBulto.Size = new System.Drawing.Size(129, 54);
            this.btnQuitarBulto.TabIndex = 7;
            this.btnQuitarBulto.Text = "Quitar seleccionado";
            this.btnQuitarBulto.Click += new System.EventHandler(this.btnQuitarBulto_Click);
            // 
            // btnDomicilio
            // 
            this.btnDomicilio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDomicilio.ForeColor = System.Drawing.Color.White;
            this.btnDomicilio.Location = new System.Drawing.Point(15, 397);
            this.btnDomicilio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDomicilio.Name = "btnDomicilio";
            this.btnDomicilio.Size = new System.Drawing.Size(976, 40);
            this.btnDomicilio.TabIndex = 6;
            this.btnDomicilio.Text = "A domicilio";
            this.btnDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDomicilio.UseVisualStyleBackColor = false;
            // 
            // grpDomicilio
            // 
            this.grpDomicilio.Controls.Add(this.textLocProvDom);
            this.grpDomicilio.Controls.Add(this.lblProvinciaRetiro);
            this.grpDomicilio.Controls.Add(this.lblNombreDom);
            this.grpDomicilio.Controls.Add(this.txtNombreDom);
            this.grpDomicilio.Controls.Add(this.lblDNIDom);
            this.grpDomicilio.Controls.Add(this.txtDNIDom);
            this.grpDomicilio.Controls.Add(this.lblTelefonoDom);
            this.grpDomicilio.Controls.Add(this.txtTelefonoDom);
            this.grpDomicilio.Controls.Add(this.lblDomicilioEntrega);
            this.grpDomicilio.Controls.Add(this.txtDomicilioEntrega);
            this.grpDomicilio.Controls.Add(this.lblCPDom);
            this.grpDomicilio.Controls.Add(this.txtCPDom);
            this.grpDomicilio.Controls.Add(this.btnBuscarLocalidadDom);
            this.grpDomicilio.Location = new System.Drawing.Point(15, 442);
            this.grpDomicilio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDomicilio.Name = "grpDomicilio";
            this.grpDomicilio.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDomicilio.Size = new System.Drawing.Size(976, 186);
            this.grpDomicilio.TabIndex = 7;
            this.grpDomicilio.TabStop = false;
            // 
            // textLocProvDom
            // 
            this.textLocProvDom.Location = new System.Drawing.Point(665, 143);
            this.textLocProvDom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textLocProvDom.Name = "textLocProvDom";
            this.textLocProvDom.ReadOnly = true;
            this.textLocProvDom.Size = new System.Drawing.Size(223, 26);
            this.textLocProvDom.TabIndex = 12;
            
            // 
            // lblProvinciaRetiro
            // 
            this.lblProvinciaRetiro.AutoSize = true;
            this.lblProvinciaRetiro.Location = new System.Drawing.Point(501, 145);
            this.lblProvinciaRetiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvinciaRetiro.Name = "lblProvinciaRetiro";
            this.lblProvinciaRetiro.Size = new System.Drawing.Size(156, 20);
            this.lblProvinciaRetiro.TabIndex = 11;
            this.lblProvinciaRetiro.Text = "Localidad / Provincia:";
            // 
            // lblNombreDom
            // 
            this.lblNombreDom.AutoSize = true;
            this.lblNombreDom.Location = new System.Drawing.Point(14, 25);
            this.lblNombreDom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDom.Name = "lblNombreDom";
            this.lblNombreDom.Size = new System.Drawing.Size(138, 20);
            this.lblNombreDom.TabIndex = 0;
            this.lblNombreDom.Text = "Nombre y apellido:";
            // 
            // txtNombreDom
            // 
            this.txtNombreDom.Location = new System.Drawing.Point(180, 20);
            this.txtNombreDom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreDom.Name = "txtNombreDom";
            this.txtNombreDom.Size = new System.Drawing.Size(770, 26);
            this.txtNombreDom.TabIndex = 1;
            
            // 
            // lblDNIDom
            // 
            this.lblDNIDom.AutoSize = true;
            this.lblDNIDom.Location = new System.Drawing.Point(14, 65);
            this.lblDNIDom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNIDom.Name = "lblDNIDom";
            this.lblDNIDom.Size = new System.Drawing.Size(41, 20);
            this.lblDNIDom.TabIndex = 2;
            this.lblDNIDom.Text = "DNI:";
            // 
            // txtDNIDom
            // 
            this.txtDNIDom.Location = new System.Drawing.Point(180, 60);
            this.txtDNIDom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDNIDom.Name = "txtDNIDom";
            this.txtDNIDom.Size = new System.Drawing.Size(180, 26);
            this.txtDNIDom.TabIndex = 3;
            
            // 
            // lblTelefonoDom
            // 
            this.lblTelefonoDom.AutoSize = true;
            this.lblTelefonoDom.Location = new System.Drawing.Point(386, 65);
            this.lblTelefonoDom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoDom.Name = "lblTelefonoDom";
            this.lblTelefonoDom.Size = new System.Drawing.Size(163, 20);
            this.lblTelefonoDom.TabIndex = 4;
            this.lblTelefonoDom.Text = "Teléfono de contacto:";
            // 
            // txtTelefonoDom
            // 
            this.txtTelefonoDom.Location = new System.Drawing.Point(579, 60);
            this.txtTelefonoDom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefonoDom.Name = "txtTelefonoDom";
            this.txtTelefonoDom.Size = new System.Drawing.Size(372, 26);
            this.txtTelefonoDom.TabIndex = 5;
            
            // 
            // lblDomicilioEntrega
            // 
            this.lblDomicilioEntrega.AutoSize = true;
            this.lblDomicilioEntrega.Location = new System.Drawing.Point(14, 105);
            this.lblDomicilioEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomicilioEntrega.Name = "lblDomicilioEntrega";
            this.lblDomicilioEntrega.Size = new System.Drawing.Size(157, 20);
            this.lblDomicilioEntrega.TabIndex = 6;
            this.lblDomicilioEntrega.Text = "Domicilio de entrega:";
            // 
            // txtDomicilioEntrega
            // 
            this.txtDomicilioEntrega.Location = new System.Drawing.Point(180, 100);
            this.txtDomicilioEntrega.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDomicilioEntrega.Name = "txtDomicilioEntrega";
            this.txtDomicilioEntrega.Size = new System.Drawing.Size(770, 26);
            this.txtDomicilioEntrega.TabIndex = 7;
            
            // 
            // lblCPDom
            // 
            this.lblCPDom.AutoSize = true;
            this.lblCPDom.Location = new System.Drawing.Point(14, 145);
            this.lblCPDom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPDom.Name = "lblCPDom";
            this.lblCPDom.Size = new System.Drawing.Size(110, 20);
            this.lblCPDom.TabIndex = 8;
            this.lblCPDom.Text = "Código postal:";
            // 
            // txtCPDom
            // 
            this.txtCPDom.Location = new System.Drawing.Point(180, 140);
            this.txtCPDom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPDom.Name = "txtCPDom";
            this.txtCPDom.Size = new System.Drawing.Size(127, 26);
            this.txtCPDom.TabIndex = 9;
            
            // 
            // btnBuscarLocalidadDom
            // 
            this.btnBuscarLocalidadDom.Location = new System.Drawing.Point(320, 138);
            this.btnBuscarLocalidadDom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarLocalidadDom.Name = "btnBuscarLocalidadDom";
            this.btnBuscarLocalidadDom.Size = new System.Drawing.Size(154, 34);
            this.btnBuscarLocalidadDom.TabIndex = 10;
            this.btnBuscarLocalidadDom.Text = "Buscar localidad";
            this.btnBuscarLocalidadDom.Click += new System.EventHandler(this.btnBuscarLocalidadDom_Click);
            // 
            // btnAgencia
            // 
            this.btnAgencia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgencia.ForeColor = System.Drawing.Color.White;
            this.btnAgencia.Location = new System.Drawing.Point(15, 642);
            this.btnAgencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgencia.Name = "btnAgencia";
            this.btnAgencia.Size = new System.Drawing.Size(976, 40);
            this.btnAgencia.TabIndex = 8;
            this.btnAgencia.Text = "En agencia";
            this.btnAgencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgencia.UseVisualStyleBackColor = false;
            // 
            // grpAgencia
            // 
            this.grpAgencia.Controls.Add(this.lblNombreAg);
            this.grpAgencia.Controls.Add(this.txtNombreAg);
            this.grpAgencia.Controls.Add(this.lblDNIAg);
            this.grpAgencia.Controls.Add(this.txtDNIAg);
            this.grpAgencia.Controls.Add(this.lblTelefonoAg);
            this.grpAgencia.Controls.Add(this.txtTelefonoAg);
            this.grpAgencia.Controls.Add(this.lblCPAg);
            this.grpAgencia.Controls.Add(this.txtCPAg);
            this.grpAgencia.Controls.Add(this.btnBuscarLocalidadAg);
            this.grpAgencia.Controls.Add(this.lblAgencia);
            this.grpAgencia.Controls.Add(this.cmbAgencia);
            this.grpAgencia.Location = new System.Drawing.Point(15, 685);
            this.grpAgencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAgencia.Name = "grpAgencia";
            this.grpAgencia.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAgencia.Size = new System.Drawing.Size(976, 151);
            this.grpAgencia.TabIndex = 9;
            this.grpAgencia.TabStop = false;
            // 
            // lblNombreAg
            // 
            this.lblNombreAg.AutoSize = true;
            this.lblNombreAg.Location = new System.Drawing.Point(14, 25);
            this.lblNombreAg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreAg.Name = "lblNombreAg";
            this.lblNombreAg.Size = new System.Drawing.Size(138, 20);
            this.lblNombreAg.TabIndex = 0;
            this.lblNombreAg.Text = "Nombre y apellido:";
            // 
            // txtNombreAg
            // 
            this.txtNombreAg.Location = new System.Drawing.Point(180, 20);
            this.txtNombreAg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreAg.Name = "txtNombreAg";
            this.txtNombreAg.Size = new System.Drawing.Size(770, 26);
            this.txtNombreAg.TabIndex = 1;
            
            // 
            // lblDNIAg
            // 
            this.lblDNIAg.AutoSize = true;
            this.lblDNIAg.Location = new System.Drawing.Point(14, 65);
            this.lblDNIAg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNIAg.Name = "lblDNIAg";
            this.lblDNIAg.Size = new System.Drawing.Size(41, 20);
            this.lblDNIAg.TabIndex = 2;
            this.lblDNIAg.Text = "DNI:";
            // 
            // txtDNIAg
            // 
            this.txtDNIAg.Location = new System.Drawing.Point(180, 60);
            this.txtDNIAg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDNIAg.Name = "txtDNIAg";
            this.txtDNIAg.Size = new System.Drawing.Size(180, 26);
            this.txtDNIAg.TabIndex = 3;
            
            // 
            // lblTelefonoAg
            // 
            this.lblTelefonoAg.AutoSize = true;
            this.lblTelefonoAg.Location = new System.Drawing.Point(386, 65);
            this.lblTelefonoAg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoAg.Name = "lblTelefonoAg";
            this.lblTelefonoAg.Size = new System.Drawing.Size(163, 20);
            this.lblTelefonoAg.TabIndex = 4;
            this.lblTelefonoAg.Text = "Teléfono de contacto:";
            // 
            // txtTelefonoAg
            // 
            this.txtTelefonoAg.Location = new System.Drawing.Point(579, 60);
            this.txtTelefonoAg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefonoAg.Name = "txtTelefonoAg";
            this.txtTelefonoAg.Size = new System.Drawing.Size(372, 26);
            this.txtTelefonoAg.TabIndex = 5;
            
            // 
            // lblCPAg
            // 
            this.lblCPAg.AutoSize = true;
            this.lblCPAg.Location = new System.Drawing.Point(14, 105);
            this.lblCPAg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPAg.Name = "lblCPAg";
            this.lblCPAg.Size = new System.Drawing.Size(110, 20);
            this.lblCPAg.TabIndex = 6;
            this.lblCPAg.Text = "Código postal:";
            // 
            // txtCPAg
            // 
            this.txtCPAg.Location = new System.Drawing.Point(180, 100);
            this.txtCPAg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPAg.Name = "txtCPAg";
            this.txtCPAg.Size = new System.Drawing.Size(127, 26);
            this.txtCPAg.TabIndex = 7;
            
            // 
            // btnBuscarLocalidadAg
            // 
            this.btnBuscarLocalidadAg.Location = new System.Drawing.Point(320, 98);
            this.btnBuscarLocalidadAg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarLocalidadAg.Name = "btnBuscarLocalidadAg";
            this.btnBuscarLocalidadAg.Size = new System.Drawing.Size(154, 34);
            this.btnBuscarLocalidadAg.TabIndex = 8;
            this.btnBuscarLocalidadAg.Text = "Buscar localidad";
            this.btnBuscarLocalidadAg.Click += new System.EventHandler(this.btnBuscarLocalidadAg_Click);
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(495, 106);
            this.lblAgencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(71, 20);
            this.lblAgencia.TabIndex = 9;
            this.lblAgencia.Text = "Agencia:";
            // 
            // cmbAgencia
            // 
            this.cmbAgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgencia.Location = new System.Drawing.Point(579, 102);
            this.cmbAgencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbAgencia.Name = "cmbAgencia";
            this.cmbAgencia.Size = new System.Drawing.Size(372, 28);
            this.cmbAgencia.TabIndex = 10;
            
            // 
            // btnCD
            // 
            this.btnCD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCD.ForeColor = System.Drawing.Color.White;
            this.btnCD.Location = new System.Drawing.Point(15, 845);
            this.btnCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCD.Name = "btnCD";
            this.btnCD.Size = new System.Drawing.Size(976, 40);
            this.btnCD.TabIndex = 10;
            this.btnCD.Text = "En CD";
            this.btnCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCD.UseVisualStyleBackColor = false;
            // 
            // grpCD
            // 
            this.grpCD.Controls.Add(this.lblNombreCD);
            this.grpCD.Controls.Add(this.txtNombreCD);
            this.grpCD.Controls.Add(this.lblDNICD);
            this.grpCD.Controls.Add(this.txtDNICD);
            this.grpCD.Controls.Add(this.lblTelefonoCD);
            this.grpCD.Controls.Add(this.txtTelefonoCD);
            this.grpCD.Controls.Add(this.lblCPCD);
            this.grpCD.Controls.Add(this.txtCPCD);
            this.grpCD.Controls.Add(this.btnBuscarLocalidadCD);
            this.grpCD.Controls.Add(this.lblCD);
            this.grpCD.Controls.Add(this.cmbCD);
            this.grpCD.Location = new System.Drawing.Point(15, 889);
            this.grpCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCD.Name = "grpCD";
            this.grpCD.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCD.Size = new System.Drawing.Size(976, 151);
            this.grpCD.TabIndex = 11;
            this.grpCD.TabStop = false;
            // 
            // lblNombreCD
            // 
            this.lblNombreCD.AutoSize = true;
            this.lblNombreCD.Location = new System.Drawing.Point(14, 25);
            this.lblNombreCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCD.Name = "lblNombreCD";
            this.lblNombreCD.Size = new System.Drawing.Size(138, 20);
            this.lblNombreCD.TabIndex = 0;
            this.lblNombreCD.Text = "Nombre y apellido:";
            // 
            // txtNombreCD
            // 
            this.txtNombreCD.Location = new System.Drawing.Point(180, 20);
            this.txtNombreCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreCD.Name = "txtNombreCD";
            this.txtNombreCD.Size = new System.Drawing.Size(770, 26);
            this.txtNombreCD.TabIndex = 1;
            
            // 
            // lblDNICD
            // 
            this.lblDNICD.AutoSize = true;
            this.lblDNICD.Location = new System.Drawing.Point(14, 65);
            this.lblDNICD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNICD.Name = "lblDNICD";
            this.lblDNICD.Size = new System.Drawing.Size(41, 20);
            this.lblDNICD.TabIndex = 2;
            this.lblDNICD.Text = "DNI:";
            // 
            // txtDNICD
            // 
            this.txtDNICD.Location = new System.Drawing.Point(180, 60);
            this.txtDNICD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDNICD.Name = "txtDNICD";
            this.txtDNICD.Size = new System.Drawing.Size(180, 26);
            this.txtDNICD.TabIndex = 3;
            
            // 
            // lblTelefonoCD
            // 
            this.lblTelefonoCD.AutoSize = true;
            this.lblTelefonoCD.Location = new System.Drawing.Point(386, 65);
            this.lblTelefonoCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoCD.Name = "lblTelefonoCD";
            this.lblTelefonoCD.Size = new System.Drawing.Size(163, 20);
            this.lblTelefonoCD.TabIndex = 4;
            this.lblTelefonoCD.Text = "Teléfono de contacto:";
            // 
            // txtTelefonoCD
            // 
            this.txtTelefonoCD.Location = new System.Drawing.Point(579, 60);
            this.txtTelefonoCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefonoCD.Name = "txtTelefonoCD";
            this.txtTelefonoCD.Size = new System.Drawing.Size(372, 26);
            this.txtTelefonoCD.TabIndex = 5;
            
            // 
            // lblCPCD
            // 
            this.lblCPCD.AutoSize = true;
            this.lblCPCD.Location = new System.Drawing.Point(14, 105);
            this.lblCPCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPCD.Name = "lblCPCD";
            this.lblCPCD.Size = new System.Drawing.Size(110, 20);
            this.lblCPCD.TabIndex = 6;
            this.lblCPCD.Text = "Código postal:";
            // 
            // txtCPCD
            // 
            this.txtCPCD.Location = new System.Drawing.Point(180, 100);
            this.txtCPCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCPCD.Name = "txtCPCD";
            this.txtCPCD.Size = new System.Drawing.Size(127, 26);
            this.txtCPCD.TabIndex = 7;
            
            // 
            // btnBuscarLocalidadCD
            // 
            this.btnBuscarLocalidadCD.Location = new System.Drawing.Point(320, 98);
            this.btnBuscarLocalidadCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarLocalidadCD.Name = "btnBuscarLocalidadCD";
            this.btnBuscarLocalidadCD.Size = new System.Drawing.Size(154, 34);
            this.btnBuscarLocalidadCD.TabIndex = 8;
            this.btnBuscarLocalidadCD.Text = "Buscar localidad";
            this.btnBuscarLocalidadCD.Click += new System.EventHandler(this.btnBuscarLocalidadCD_Click);
            // 
            // lblCD
            // 
            this.lblCD.AutoSize = true;
            this.lblCD.Location = new System.Drawing.Point(526, 105);
            this.lblCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(36, 20);
            this.lblCD.TabIndex = 9;
            this.lblCD.Text = "CD:";
            // 
            // cmbCD
            // 
            this.cmbCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCD.Location = new System.Drawing.Point(579, 98);
            this.cmbCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCD.Name = "cmbCD";
            this.cmbCD.Size = new System.Drawing.Size(372, 28);
            this.cmbCD.TabIndex = 10;
            
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(666, 1049);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(194, 40);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar imposición";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(887, 1049);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 40);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // radioBtnCD
            // 
            this.radioBtnCD.AutoSize = true;
            this.radioBtnCD.Location = new System.Drawing.Point(412, 346);
            this.radioBtnCD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnCD.Name = "radioBtnCD";
            this.radioBtnCD.Size = new System.Drawing.Size(57, 24);
            this.radioBtnCD.TabIndex = 22;
            this.radioBtnCD.TabStop = true;
            this.radioBtnCD.Text = "CD";
            this.radioBtnCD.UseVisualStyleBackColor = true;
            this.radioBtnCD.CheckedChanged += new System.EventHandler(this.radioBtnCD_CheckedChanged);
            // 
            // radioBtnAgencia
            // 
            this.radioBtnAgencia.AutoSize = true;
            this.radioBtnAgencia.Location = new System.Drawing.Point(290, 346);
            this.radioBtnAgencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnAgencia.Name = "radioBtnAgencia";
            this.radioBtnAgencia.Size = new System.Drawing.Size(92, 24);
            this.radioBtnAgencia.TabIndex = 21;
            this.radioBtnAgencia.TabStop = true;
            this.radioBtnAgencia.Text = "Agencia";
            this.radioBtnAgencia.UseVisualStyleBackColor = true;
            this.radioBtnAgencia.CheckedChanged += new System.EventHandler(this.radioBtnAgencia_CheckedChanged);
            // 
            // radioBtnDomicilio
            // 
            this.radioBtnDomicilio.AutoSize = true;
            this.radioBtnDomicilio.Location = new System.Drawing.Point(156, 346);
            this.radioBtnDomicilio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnDomicilio.Name = "radioBtnDomicilio";
            this.radioBtnDomicilio.Size = new System.Drawing.Size(97, 24);
            this.radioBtnDomicilio.TabIndex = 20;
            this.radioBtnDomicilio.TabStop = true;
            this.radioBtnDomicilio.Text = "Domicilio";
            this.radioBtnDomicilio.UseVisualStyleBackColor = true;
            this.radioBtnDomicilio.CheckedChanged += new System.EventHandler(this.radioBtnDomicilio_CheckedChanged);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(20, 349);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(124, 20);
            this.lblDestino.TabIndex = 19;
            this.lblDestino.Text = "Tipo de entrega:";
            // 
            // frmImposicionAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1052, 1050);
            this.Controls.Add(this.radioBtnCD);
            this.Controls.Add(this.radioBtnAgencia);
            this.Controls.Add(this.radioBtnDomicilio);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.groupRemitente);
            this.Controls.Add(this.grpBultos);
            this.Controls.Add(this.btnDomicilio);
            this.Controls.Add(this.grpDomicilio);
            this.Controls.Add(this.btnAgencia);
            this.Controls.Add(this.grpAgencia);
            this.Controls.Add(this.btnCD);
            this.Controls.Add(this.grpCD);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmImposicionAgencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imposición en Agencia";
            this.Load += new System.EventHandler(this.frmImposicionAgencia_Load);
            this.groupRemitente.ResumeLayout(false);
            this.groupRemitente.PerformLayout();
            this.grpBultos.ResumeLayout(false);
            this.grpBultos.PerformLayout();
            this.grpDomicilio.ResumeLayout(false);
            this.grpDomicilio.PerformLayout();
            this.grpAgencia.ResumeLayout(false);
            this.grpAgencia.PerformLayout();
            this.grpCD.ResumeLayout(false);
            this.grpCD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Datos del remitente
        private System.Windows.Forms.GroupBox groupRemitente;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblNombreRemitente;

        // Bultos
        private System.Windows.Forms.GroupBox grpBultos;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.RadioButton radioBtnS;
        private System.Windows.Forms.RadioButton radioBtnM;
        private System.Windows.Forms.RadioButton radioBtnL;
        private System.Windows.Forms.RadioButton radioBtnXL;
        private System.Windows.Forms.Button btnAgregarBulto;
        private System.Windows.Forms.ListView listViewBultos;
        private System.Windows.Forms.ColumnHeader colNum;
        private System.Windows.Forms.ColumnHeader colCategoria;
        private System.Windows.Forms.Button btnQuitarBulto;

        // Bloque domicilio
        private System.Windows.Forms.Button btnDomicilio;
        private System.Windows.Forms.GroupBox grpDomicilio;
        private System.Windows.Forms.Label lblNombreDom;
        private System.Windows.Forms.TextBox txtNombreDom;
        private System.Windows.Forms.Label lblDNIDom;
        private System.Windows.Forms.TextBox txtDNIDom;
        private System.Windows.Forms.Label lblTelefonoDom;
        private System.Windows.Forms.TextBox txtTelefonoDom;
        private System.Windows.Forms.Label lblDomicilioEntrega;
        private System.Windows.Forms.TextBox txtDomicilioEntrega;
        private System.Windows.Forms.Label lblCPDom;
        private System.Windows.Forms.TextBox txtCPDom;
        private System.Windows.Forms.Button btnBuscarLocalidadDom;

        // Bloque agencia
        private System.Windows.Forms.Button btnAgencia;
        private System.Windows.Forms.GroupBox grpAgencia;
        private System.Windows.Forms.Label lblNombreAg;
        private System.Windows.Forms.TextBox txtNombreAg;
        private System.Windows.Forms.Label lblDNIAg;
        private System.Windows.Forms.TextBox txtDNIAg;
        private System.Windows.Forms.Label lblTelefonoAg;
        private System.Windows.Forms.TextBox txtTelefonoAg;
        private System.Windows.Forms.Label lblCPAg;
        private System.Windows.Forms.TextBox txtCPAg;
        private System.Windows.Forms.Button btnBuscarLocalidadAg;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.ComboBox cmbAgencia;

        // Bloque CD
        private System.Windows.Forms.Button btnCD;
        private System.Windows.Forms.GroupBox grpCD;
        private System.Windows.Forms.Label lblNombreCD;
        private System.Windows.Forms.TextBox txtNombreCD;
        private System.Windows.Forms.Label lblDNICD;
        private System.Windows.Forms.TextBox txtDNICD;
        private System.Windows.Forms.Label lblTelefonoCD;
        private System.Windows.Forms.TextBox txtTelefonoCD;
        private System.Windows.Forms.Label lblCPCD;
        private System.Windows.Forms.TextBox txtCPCD;
        private System.Windows.Forms.Button btnBuscarLocalidadCD;
        private System.Windows.Forms.Label lblCD;
        private System.Windows.Forms.ComboBox cmbCD;

        // Botones
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblProvinciaRetiro;
        private System.Windows.Forms.RadioButton radioBtnCD;
        private System.Windows.Forms.RadioButton radioBtnAgencia;
        private System.Windows.Forms.RadioButton radioBtnDomicilio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtMuestraNombre;
        private System.Windows.Forms.TextBox textLocProvDom;
    }
}