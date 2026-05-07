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
            this.lblDNIRemitente = new System.Windows.Forms.Label();
            this.txtDNIRemitente = new System.Windows.Forms.TextBox();
            this.lblDomicilioRetiro = new System.Windows.Forms.Label();
            this.txtDomicilioRetiro = new System.Windows.Forms.TextBox();
            this.lblCPRetiro = new System.Windows.Forms.Label();
            this.txtCPRetiro = new System.Windows.Forms.TextBox();
            this.btnBuscarLocalidadRetiro = new System.Windows.Forms.Button();
            this.lblProvinciaRetiro = new System.Windows.Forms.Label();
            this.txtProvinciaRetiro = new System.Windows.Forms.TextBox();
            this.grpBultos = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.rbS = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbL = new System.Windows.Forms.RadioButton();
            this.rbXL = new System.Windows.Forms.RadioButton();
            this.btnAgregarBulto = new System.Windows.Forms.Button();
            this.lvBultos = new System.Windows.Forms.ListView();
            this.colNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnQuitarBulto = new System.Windows.Forms.Button();
            this.btnDomicilio = new System.Windows.Forms.Button();
            this.grpDomicilio = new System.Windows.Forms.GroupBox();
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
            this.lblProvinciaDom = new System.Windows.Forms.Label();
            this.txtProvinciaDom = new System.Windows.Forms.TextBox();
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
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnSelDomicilio = new System.Windows.Forms.Button();
            this.btnSelAgencia = new System.Windows.Forms.Button();
            this.btnSelCD = new System.Windows.Forms.Button();
            this.grpCliente.SuspendLayout();
            this.grpRetiro.SuspendLayout();
            this.grpBultos.SuspendLayout();
            this.grpDomicilio.SuspendLayout();
            this.grpAgencia.SuspendLayout();
            this.grpCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.lblCUIT);
            this.grpCliente.Controls.Add(this.txtCUIT);
            this.grpCliente.Controls.Add(this.btnBuscarCliente);
            this.grpCliente.Controls.Add(this.lblNombreCliente);
            this.grpCliente.Controls.Add(this.txtNombreCliente);
            this.grpCliente.Location = new System.Drawing.Point(10, 1);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(651, 69);
            this.grpCliente.TabIndex = 0;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Datos del Cliente";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(9, 22);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(35, 13);
            this.lblCUIT.TabIndex = 0;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(69, 19);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(138, 20);
            this.txtCUIT.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(213, 18);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(94, 22);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar cliente";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(9, 45);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(47, 13);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreCliente.Location = new System.Drawing.Point(69, 42);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(566, 20);
            this.txtNombreCliente.TabIndex = 4;
            this.txtNombreCliente.TextChanged += new System.EventHandler(this.txtNombreCliente_TextChanged);
            // 
            // grpRetiro
            // 
            this.grpRetiro.Controls.Add(this.lblDNIRemitente);
            this.grpRetiro.Controls.Add(this.txtDNIRemitente);
            this.grpRetiro.Controls.Add(this.lblDomicilioRetiro);
            this.grpRetiro.Controls.Add(this.txtDomicilioRetiro);
            this.grpRetiro.Controls.Add(this.lblCPRetiro);
            this.grpRetiro.Controls.Add(this.txtCPRetiro);
            this.grpRetiro.Controls.Add(this.btnBuscarLocalidadRetiro);
            this.grpRetiro.Controls.Add(this.lblProvinciaRetiro);
            this.grpRetiro.Controls.Add(this.txtProvinciaRetiro);
            this.grpRetiro.Location = new System.Drawing.Point(10, 71);
            this.grpRetiro.Name = "grpRetiro";
            this.grpRetiro.Size = new System.Drawing.Size(651, 95);
            this.grpRetiro.TabIndex = 1;
            this.grpRetiro.TabStop = false;
            this.grpRetiro.Text = "Datos del Retiro";
            // 
            // lblDNIRemitente
            // 
            this.lblDNIRemitente.AutoSize = true;
            this.lblDNIRemitente.Location = new System.Drawing.Point(9, 22);
            this.lblDNIRemitente.Name = "lblDNIRemitente";
            this.lblDNIRemitente.Size = new System.Drawing.Size(92, 13);
            this.lblDNIRemitente.TabIndex = 0;
            this.lblDNIRemitente.Text = "DNI del remitente:";
            // 
            // txtDNIRemitente
            // 
            this.txtDNIRemitente.Location = new System.Drawing.Point(111, 19);
            this.txtDNIRemitente.Name = "txtDNIRemitente";
            this.txtDNIRemitente.Size = new System.Drawing.Size(121, 20);
            this.txtDNIRemitente.TabIndex = 1;
            // 
            // lblDomicilioRetiro
            // 
            this.lblDomicilioRetiro.AutoSize = true;
            this.lblDomicilioRetiro.Location = new System.Drawing.Point(9, 48);
            this.lblDomicilioRetiro.Name = "lblDomicilioRetiro";
            this.lblDomicilioRetiro.Size = new System.Drawing.Size(93, 13);
            this.lblDomicilioRetiro.TabIndex = 2;
            this.lblDomicilioRetiro.Text = "Domicilio de retiro:";
            // 
            // txtDomicilioRetiro
            // 
            this.txtDomicilioRetiro.Location = new System.Drawing.Point(111, 45);
            this.txtDomicilioRetiro.Name = "txtDomicilioRetiro";
            this.txtDomicilioRetiro.Size = new System.Drawing.Size(523, 20);
            this.txtDomicilioRetiro.TabIndex = 3;
            // 
            // lblCPRetiro
            // 
            this.lblCPRetiro.AutoSize = true;
            this.lblCPRetiro.Location = new System.Drawing.Point(9, 72);
            this.lblCPRetiro.Name = "lblCPRetiro";
            this.lblCPRetiro.Size = new System.Drawing.Size(74, 13);
            this.lblCPRetiro.TabIndex = 4;
            this.lblCPRetiro.Text = "Código postal:";
            // 
            // txtCPRetiro
            // 
            this.txtCPRetiro.Location = new System.Drawing.Point(111, 69);
            this.txtCPRetiro.Name = "txtCPRetiro";
            this.txtCPRetiro.Size = new System.Drawing.Size(86, 20);
            this.txtCPRetiro.TabIndex = 5;
            // 
            // btnBuscarLocalidadRetiro
            // 
            this.btnBuscarLocalidadRetiro.Location = new System.Drawing.Point(204, 68);
            this.btnBuscarLocalidadRetiro.Name = "btnBuscarLocalidadRetiro";
            this.btnBuscarLocalidadRetiro.Size = new System.Drawing.Size(103, 22);
            this.btnBuscarLocalidadRetiro.TabIndex = 6;
            this.btnBuscarLocalidadRetiro.Text = "Buscar localidad";
            // 
            // lblProvinciaRetiro
            // 
            this.lblProvinciaRetiro.AutoSize = true;
            this.lblProvinciaRetiro.Location = new System.Drawing.Point(317, 72);
            this.lblProvinciaRetiro.Name = "lblProvinciaRetiro";
            this.lblProvinciaRetiro.Size = new System.Drawing.Size(54, 13);
            this.lblProvinciaRetiro.TabIndex = 7;
            this.lblProvinciaRetiro.Text = "Provincia:";
            // 
            // txtProvinciaRetiro
            // 
            this.txtProvinciaRetiro.BackColor = System.Drawing.SystemColors.Control;
            this.txtProvinciaRetiro.Location = new System.Drawing.Point(369, 69);
            this.txtProvinciaRetiro.Name = "txtProvinciaRetiro";
            this.txtProvinciaRetiro.ReadOnly = true;
            this.txtProvinciaRetiro.Size = new System.Drawing.Size(172, 20);
            this.txtProvinciaRetiro.TabIndex = 8;
            // 
            // grpBultos
            // 
            this.grpBultos.Controls.Add(this.lblCategoria);
            this.grpBultos.Controls.Add(this.rbS);
            this.grpBultos.Controls.Add(this.rbM);
            this.grpBultos.Controls.Add(this.rbL);
            this.grpBultos.Controls.Add(this.rbXL);
            this.grpBultos.Controls.Add(this.btnAgregarBulto);
            this.grpBultos.Controls.Add(this.lvBultos);
            this.grpBultos.Controls.Add(this.btnQuitarBulto);
            this.grpBultos.Location = new System.Drawing.Point(10, 166);
            this.grpBultos.Name = "grpBultos";
            this.grpBultos.Size = new System.Drawing.Size(651, 121);
            this.grpBultos.TabIndex = 2;
            this.grpBultos.TabStop = false;
            this.grpBultos.Text = "Bultos";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(9, 22);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoría:";
            // 
            // rbS
            // 
            this.rbS.Checked = true;
            this.rbS.Location = new System.Drawing.Point(69, 20);
            this.rbS.Name = "rbS";
            this.rbS.Size = new System.Drawing.Size(39, 17);
            this.rbS.TabIndex = 1;
            this.rbS.TabStop = true;
            this.rbS.Text = "S";
            // 
            // rbM
            // 
            this.rbM.Location = new System.Drawing.Point(111, 20);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(39, 17);
            this.rbM.TabIndex = 2;
            this.rbM.Text = "M";
            // 
            // rbL
            // 
            this.rbL.Location = new System.Drawing.Point(154, 20);
            this.rbL.Name = "rbL";
            this.rbL.Size = new System.Drawing.Size(39, 17);
            this.rbL.TabIndex = 3;
            this.rbL.Text = "L";
            // 
            // rbXL
            // 
            this.rbXL.Location = new System.Drawing.Point(197, 20);
            this.rbXL.Name = "rbXL";
            this.rbXL.Size = new System.Drawing.Size(43, 17);
            this.rbXL.TabIndex = 4;
            this.rbXL.Text = "XL";
            // 
            // btnAgregarBulto
            // 
            this.btnAgregarBulto.Location = new System.Drawing.Point(253, 18);
            this.btnAgregarBulto.Name = "btnAgregarBulto";
            this.btnAgregarBulto.Size = new System.Drawing.Size(94, 22);
            this.btnAgregarBulto.TabIndex = 5;
            this.btnAgregarBulto.Text = "Agregar bulto";
            // 
            // lvBultos
            // 
            this.lvBultos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum,
            this.colCategoria});
            this.lvBultos.FullRowSelect = true;
            this.lvBultos.GridLines = true;
            this.lvBultos.HideSelection = false;
            this.lvBultos.Location = new System.Drawing.Point(9, 48);
            this.lvBultos.Name = "lvBultos";
            this.lvBultos.Size = new System.Drawing.Size(541, 66);
            this.lvBultos.TabIndex = 6;
            this.lvBultos.UseCompatibleStateImageBehavior = false;
            this.lvBultos.View = System.Windows.Forms.View.Details;
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
            this.btnQuitarBulto.Location = new System.Drawing.Point(557, 48);
            this.btnQuitarBulto.Name = "btnQuitarBulto";
            this.btnQuitarBulto.Size = new System.Drawing.Size(86, 35);
            this.btnQuitarBulto.TabIndex = 7;
            this.btnQuitarBulto.Text = "Quitar seleccionado";
            // 
            // btnDomicilio
            // 
            this.btnDomicilio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDomicilio.ForeColor = System.Drawing.Color.White;
            this.btnDomicilio.Location = new System.Drawing.Point(10, 324);
            this.btnDomicilio.Name = "btnDomicilio";
            this.btnDomicilio.Size = new System.Drawing.Size(651, 26);
            this.btnDomicilio.TabIndex = 3;
            this.btnDomicilio.Text = "A domicilio";
            this.btnDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDomicilio.UseVisualStyleBackColor = false;
            // 
            // grpDomicilio
            // 
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
            this.grpDomicilio.Controls.Add(this.lblProvinciaDom);
            this.grpDomicilio.Controls.Add(this.txtProvinciaDom);
            this.grpDomicilio.Location = new System.Drawing.Point(10, 347);
            this.grpDomicilio.Name = "grpDomicilio";
            this.grpDomicilio.Size = new System.Drawing.Size(651, 121);
            this.grpDomicilio.TabIndex = 4;
            this.grpDomicilio.TabStop = false;
            // 
            // lblNombreDom
            // 
            this.lblNombreDom.AutoSize = true;
            this.lblNombreDom.Location = new System.Drawing.Point(9, 16);
            this.lblNombreDom.Name = "lblNombreDom";
            this.lblNombreDom.Size = new System.Drawing.Size(94, 13);
            this.lblNombreDom.TabIndex = 0;
            this.lblNombreDom.Text = "Nombre y apellido:";
            // 
            // txtNombreDom
            // 
            this.txtNombreDom.Location = new System.Drawing.Point(120, 13);
            this.txtNombreDom.Name = "txtNombreDom";
            this.txtNombreDom.Size = new System.Drawing.Size(515, 20);
            this.txtNombreDom.TabIndex = 1;
            // 
            // lblDNIDom
            // 
            this.lblDNIDom.AutoSize = true;
            this.lblDNIDom.Location = new System.Drawing.Point(9, 42);
            this.lblDNIDom.Name = "lblDNIDom";
            this.lblDNIDom.Size = new System.Drawing.Size(29, 13);
            this.lblDNIDom.TabIndex = 2;
            this.lblDNIDom.Text = "DNI:";
            // 
            // txtDNIDom
            // 
            this.txtDNIDom.Location = new System.Drawing.Point(120, 39);
            this.txtDNIDom.Name = "txtDNIDom";
            this.txtDNIDom.Size = new System.Drawing.Size(121, 20);
            this.txtDNIDom.TabIndex = 3;
            // 
            // lblTelefonoDom
            // 
            this.lblTelefonoDom.AutoSize = true;
            this.lblTelefonoDom.Location = new System.Drawing.Point(257, 42);
            this.lblTelefonoDom.Name = "lblTelefonoDom";
            this.lblTelefonoDom.Size = new System.Drawing.Size(112, 13);
            this.lblTelefonoDom.TabIndex = 4;
            this.lblTelefonoDom.Text = "Teléfono de contacto:";
            // 
            // txtTelefonoDom
            // 
            this.txtTelefonoDom.Location = new System.Drawing.Point(386, 39);
            this.txtTelefonoDom.Name = "txtTelefonoDom";
            this.txtTelefonoDom.Size = new System.Drawing.Size(249, 20);
            this.txtTelefonoDom.TabIndex = 5;
            // 
            // lblDomicilioEntrega
            // 
            this.lblDomicilioEntrega.AutoSize = true;
            this.lblDomicilioEntrega.Location = new System.Drawing.Point(9, 68);
            this.lblDomicilioEntrega.Name = "lblDomicilioEntrega";
            this.lblDomicilioEntrega.Size = new System.Drawing.Size(106, 13);
            this.lblDomicilioEntrega.TabIndex = 6;
            this.lblDomicilioEntrega.Text = "Domicilio de entrega:";
            // 
            // txtDomicilioEntrega
            // 
            this.txtDomicilioEntrega.Location = new System.Drawing.Point(120, 65);
            this.txtDomicilioEntrega.Name = "txtDomicilioEntrega";
            this.txtDomicilioEntrega.Size = new System.Drawing.Size(515, 20);
            this.txtDomicilioEntrega.TabIndex = 7;
            // 
            // lblCPDom
            // 
            this.lblCPDom.AutoSize = true;
            this.lblCPDom.Location = new System.Drawing.Point(9, 94);
            this.lblCPDom.Name = "lblCPDom";
            this.lblCPDom.Size = new System.Drawing.Size(74, 13);
            this.lblCPDom.TabIndex = 8;
            this.lblCPDom.Text = "Código postal:";
            // 
            // txtCPDom
            // 
            this.txtCPDom.Location = new System.Drawing.Point(120, 91);
            this.txtCPDom.Name = "txtCPDom";
            this.txtCPDom.Size = new System.Drawing.Size(86, 20);
            this.txtCPDom.TabIndex = 9;
            // 
            // btnBuscarLocalidadDom
            // 
            this.btnBuscarLocalidadDom.Location = new System.Drawing.Point(213, 90);
            this.btnBuscarLocalidadDom.Name = "btnBuscarLocalidadDom";
            this.btnBuscarLocalidadDom.Size = new System.Drawing.Size(103, 22);
            this.btnBuscarLocalidadDom.TabIndex = 10;
            this.btnBuscarLocalidadDom.Text = "Buscar localidad";
            // 
            // lblProvinciaDom
            // 
            this.lblProvinciaDom.AutoSize = true;
            this.lblProvinciaDom.Location = new System.Drawing.Point(326, 94);
            this.lblProvinciaDom.Name = "lblProvinciaDom";
            this.lblProvinciaDom.Size = new System.Drawing.Size(54, 13);
            this.lblProvinciaDom.TabIndex = 11;
            this.lblProvinciaDom.Text = "Provincia:";
            // 
            // txtProvinciaDom
            // 
            this.txtProvinciaDom.BackColor = System.Drawing.SystemColors.Control;
            this.txtProvinciaDom.Location = new System.Drawing.Point(377, 91);
            this.txtProvinciaDom.Name = "txtProvinciaDom";
            this.txtProvinciaDom.ReadOnly = true;
            this.txtProvinciaDom.Size = new System.Drawing.Size(258, 20);
            this.txtProvinciaDom.TabIndex = 12;
            // 
            // btnAgencia
            // 
            this.btnAgencia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgencia.ForeColor = System.Drawing.Color.White;
            this.btnAgencia.Location = new System.Drawing.Point(10, 472);
            this.btnAgencia.Name = "btnAgencia";
            this.btnAgencia.Size = new System.Drawing.Size(651, 34);
            this.btnAgencia.TabIndex = 5;
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
            this.grpAgencia.Location = new System.Drawing.Point(10, 500);
            this.grpAgencia.Name = "grpAgencia";
            this.grpAgencia.Size = new System.Drawing.Size(651, 93);
            this.grpAgencia.TabIndex = 6;
            this.grpAgencia.TabStop = false;
            // 
            // lblNombreAg
            // 
            this.lblNombreAg.AutoSize = true;
            this.lblNombreAg.Location = new System.Drawing.Point(9, 16);
            this.lblNombreAg.Name = "lblNombreAg";
            this.lblNombreAg.Size = new System.Drawing.Size(94, 13);
            this.lblNombreAg.TabIndex = 0;
            this.lblNombreAg.Text = "Nombre y apellido:";
            // 
            // txtNombreAg
            // 
            this.txtNombreAg.Location = new System.Drawing.Point(120, 13);
            this.txtNombreAg.Name = "txtNombreAg";
            this.txtNombreAg.Size = new System.Drawing.Size(515, 20);
            this.txtNombreAg.TabIndex = 1;
            // 
            // lblDNIAg
            // 
            this.lblDNIAg.AutoSize = true;
            this.lblDNIAg.Location = new System.Drawing.Point(9, 42);
            this.lblDNIAg.Name = "lblDNIAg";
            this.lblDNIAg.Size = new System.Drawing.Size(29, 13);
            this.lblDNIAg.TabIndex = 2;
            this.lblDNIAg.Text = "DNI:";
            // 
            // txtDNIAg
            // 
            this.txtDNIAg.Location = new System.Drawing.Point(120, 39);
            this.txtDNIAg.Name = "txtDNIAg";
            this.txtDNIAg.Size = new System.Drawing.Size(121, 20);
            this.txtDNIAg.TabIndex = 3;
            // 
            // lblTelefonoAg
            // 
            this.lblTelefonoAg.AutoSize = true;
            this.lblTelefonoAg.Location = new System.Drawing.Point(257, 42);
            this.lblTelefonoAg.Name = "lblTelefonoAg";
            this.lblTelefonoAg.Size = new System.Drawing.Size(112, 13);
            this.lblTelefonoAg.TabIndex = 4;
            this.lblTelefonoAg.Text = "Teléfono de contacto:";
            // 
            // txtTelefonoAg
            // 
            this.txtTelefonoAg.Location = new System.Drawing.Point(386, 39);
            this.txtTelefonoAg.Name = "txtTelefonoAg";
            this.txtTelefonoAg.Size = new System.Drawing.Size(249, 20);
            this.txtTelefonoAg.TabIndex = 5;
            // 
            // lblCPAg
            // 
            this.lblCPAg.AutoSize = true;
            this.lblCPAg.Location = new System.Drawing.Point(9, 68);
            this.lblCPAg.Name = "lblCPAg";
            this.lblCPAg.Size = new System.Drawing.Size(74, 13);
            this.lblCPAg.TabIndex = 6;
            this.lblCPAg.Text = "Código postal:";
            // 
            // txtCPAg
            // 
            this.txtCPAg.Location = new System.Drawing.Point(120, 65);
            this.txtCPAg.Name = "txtCPAg";
            this.txtCPAg.Size = new System.Drawing.Size(86, 20);
            this.txtCPAg.TabIndex = 7;
            // 
            // btnBuscarLocalidadAg
            // 
            this.btnBuscarLocalidadAg.Location = new System.Drawing.Point(213, 64);
            this.btnBuscarLocalidadAg.Name = "btnBuscarLocalidadAg";
            this.btnBuscarLocalidadAg.Size = new System.Drawing.Size(103, 22);
            this.btnBuscarLocalidadAg.TabIndex = 8;
            this.btnBuscarLocalidadAg.Text = "Buscar localidad";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(331, 67);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(49, 13);
            this.lblAgencia.TabIndex = 9;
            this.lblAgencia.Text = "Agencia:";
            this.lblAgencia.Click += new System.EventHandler(this.lblAgencia_Click);
            // 
            // cmbAgencia
            // 
            this.cmbAgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgencia.Location = new System.Drawing.Point(386, 64);
            this.cmbAgencia.Name = "cmbAgencia";
            this.cmbAgencia.Size = new System.Drawing.Size(249, 21);
            this.cmbAgencia.TabIndex = 10;
            // 
            // btnCD
            // 
            this.btnCD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCD.ForeColor = System.Drawing.Color.White;
            this.btnCD.Location = new System.Drawing.Point(10, 597);
            this.btnCD.Name = "btnCD";
            this.btnCD.Size = new System.Drawing.Size(651, 26);
            this.btnCD.TabIndex = 7;
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
            this.grpCD.Location = new System.Drawing.Point(10, 618);
            this.grpCD.Name = "grpCD";
            this.grpCD.Size = new System.Drawing.Size(651, 94);
            this.grpCD.TabIndex = 8;
            this.grpCD.TabStop = false;
            // 
            // lblNombreCD
            // 
            this.lblNombreCD.AutoSize = true;
            this.lblNombreCD.Location = new System.Drawing.Point(9, 16);
            this.lblNombreCD.Name = "lblNombreCD";
            this.lblNombreCD.Size = new System.Drawing.Size(94, 13);
            this.lblNombreCD.TabIndex = 0;
            this.lblNombreCD.Text = "Nombre y apellido:";
            // 
            // txtNombreCD
            // 
            this.txtNombreCD.Location = new System.Drawing.Point(120, 13);
            this.txtNombreCD.Name = "txtNombreCD";
            this.txtNombreCD.Size = new System.Drawing.Size(515, 20);
            this.txtNombreCD.TabIndex = 1;
            // 
            // lblDNICD
            // 
            this.lblDNICD.AutoSize = true;
            this.lblDNICD.Location = new System.Drawing.Point(9, 42);
            this.lblDNICD.Name = "lblDNICD";
            this.lblDNICD.Size = new System.Drawing.Size(29, 13);
            this.lblDNICD.TabIndex = 2;
            this.lblDNICD.Text = "DNI:";
            // 
            // txtDNICD
            // 
            this.txtDNICD.Location = new System.Drawing.Point(120, 39);
            this.txtDNICD.Name = "txtDNICD";
            this.txtDNICD.Size = new System.Drawing.Size(121, 20);
            this.txtDNICD.TabIndex = 3;
            // 
            // lblTelefonoCD
            // 
            this.lblTelefonoCD.AutoSize = true;
            this.lblTelefonoCD.Location = new System.Drawing.Point(257, 42);
            this.lblTelefonoCD.Name = "lblTelefonoCD";
            this.lblTelefonoCD.Size = new System.Drawing.Size(112, 13);
            this.lblTelefonoCD.TabIndex = 4;
            this.lblTelefonoCD.Text = "Teléfono de contacto:";
            // 
            // txtTelefonoCD
            // 
            this.txtTelefonoCD.Location = new System.Drawing.Point(386, 39);
            this.txtTelefonoCD.Name = "txtTelefonoCD";
            this.txtTelefonoCD.Size = new System.Drawing.Size(249, 20);
            this.txtTelefonoCD.TabIndex = 5;
            // 
            // lblCPCD
            // 
            this.lblCPCD.AutoSize = true;
            this.lblCPCD.Location = new System.Drawing.Point(9, 68);
            this.lblCPCD.Name = "lblCPCD";
            this.lblCPCD.Size = new System.Drawing.Size(74, 13);
            this.lblCPCD.TabIndex = 6;
            this.lblCPCD.Text = "Código postal:";
            // 
            // txtCPCD
            // 
            this.txtCPCD.Location = new System.Drawing.Point(120, 65);
            this.txtCPCD.Name = "txtCPCD";
            this.txtCPCD.Size = new System.Drawing.Size(86, 20);
            this.txtCPCD.TabIndex = 7;
            // 
            // btnBuscarLocalidadCD
            // 
            this.btnBuscarLocalidadCD.Location = new System.Drawing.Point(213, 64);
            this.btnBuscarLocalidadCD.Name = "btnBuscarLocalidadCD";
            this.btnBuscarLocalidadCD.Size = new System.Drawing.Size(103, 22);
            this.btnBuscarLocalidadCD.TabIndex = 8;
            this.btnBuscarLocalidadCD.Text = "Buscar localidad";
            // 
            // lblCD
            // 
            this.lblCD.AutoSize = true;
            this.lblCD.Location = new System.Drawing.Point(346, 67);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(25, 13);
            this.lblCD.TabIndex = 9;
            this.lblCD.Text = "CD:";
            // 
            // cmbCD
            // 
            this.cmbCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCD.Location = new System.Drawing.Point(386, 64);
            this.cmbCD.Name = "cmbCD";
            this.cmbCD.Size = new System.Drawing.Size(248, 21);
            this.cmbCD.TabIndex = 10;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(504, 712);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(111, 26);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar solicitud";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(622, 712);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 26);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(10, 296);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(85, 13);
            this.lblDestino.TabIndex = 11;
            this.lblDestino.Text = "Tipo de entrega:";
            // 
            // btnSelDomicilio
            // 
            this.btnSelDomicilio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelDomicilio.ForeColor = System.Drawing.Color.White;
            this.btnSelDomicilio.Location = new System.Drawing.Point(103, 292);
            this.btnSelDomicilio.Name = "btnSelDomicilio";
            this.btnSelDomicilio.Size = new System.Drawing.Size(171, 26);
            this.btnSelDomicilio.TabIndex = 12;
            this.btnSelDomicilio.Text = "A domicilio";
            this.btnSelDomicilio.UseVisualStyleBackColor = false;
            // 
            // btnSelAgencia
            // 
            this.btnSelAgencia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSelAgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelAgencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelAgencia.ForeColor = System.Drawing.Color.White;
            this.btnSelAgencia.Location = new System.Drawing.Point(283, 292);
            this.btnSelAgencia.Name = "btnSelAgencia";
            this.btnSelAgencia.Size = new System.Drawing.Size(171, 26);
            this.btnSelAgencia.TabIndex = 13;
            this.btnSelAgencia.Text = "En agencia";
            this.btnSelAgencia.UseVisualStyleBackColor = false;
            // 
            // btnSelCD
            // 
            this.btnSelCD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSelCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelCD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelCD.ForeColor = System.Drawing.Color.White;
            this.btnSelCD.Location = new System.Drawing.Point(463, 292);
            this.btnSelCD.Name = "btnSelCD";
            this.btnSelCD.Size = new System.Drawing.Size(171, 26);
            this.btnSelCD.TabIndex = 14;
            this.btnSelCD.Text = "En CD";
            this.btnSelCD.UseVisualStyleBackColor = false;
            // 
            // frmSolicitudRetiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(701, 649);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.btnSelDomicilio);
            this.Controls.Add(this.btnSelAgencia);
            this.Controls.Add(this.btnSelCD);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.grpRetiro);
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
            this.MaximizeBox = false;
            this.Name = "frmSolicitudRetiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud de Retiro a Domicilio";
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpRetiro.ResumeLayout(false);
            this.grpRetiro.PerformLayout();
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

        // Datos del cliente
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;

        // Datos del retiro
        private System.Windows.Forms.GroupBox grpRetiro;
        private System.Windows.Forms.Label lblDNIRemitente;
        private System.Windows.Forms.TextBox txtDNIRemitente;
        private System.Windows.Forms.Label lblDomicilioRetiro;
        private System.Windows.Forms.TextBox txtDomicilioRetiro;
        private System.Windows.Forms.Label lblCPRetiro;
        private System.Windows.Forms.TextBox txtCPRetiro;
        private System.Windows.Forms.Button btnBuscarLocalidadRetiro;
        private System.Windows.Forms.Label lblProvinciaRetiro;
        private System.Windows.Forms.TextBox txtProvinciaRetiro;

        // Bultos
        private System.Windows.Forms.GroupBox grpBultos;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.RadioButton rbS;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbL;
        private System.Windows.Forms.RadioButton rbXL;
        private System.Windows.Forms.Button btnAgregarBulto;
        private System.Windows.Forms.ListView lvBultos;
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
        private System.Windows.Forms.Label lblProvinciaDom;
        private System.Windows.Forms.TextBox txtProvinciaDom;

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
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnSelDomicilio;
        private System.Windows.Forms.Button btnSelAgencia;
        private System.Windows.Forms.Button btnSelCD;
    }
}