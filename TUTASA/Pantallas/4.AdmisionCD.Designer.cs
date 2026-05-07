namespace TUTASA.Forms.CD
{
    partial class frmAdmision
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
            this.grpEncomienda = new System.Windows.Forms.GroupBox();
            this.lblNroGuiaLabel = new System.Windows.Forms.Label();
            this.lblCategoriaLabel = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblDestinoLabel = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grpEncomiendas = new System.Windows.Forms.GroupBox();
            this.btnFinalizarAdmision = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscarGuia = new System.Windows.Forms.Button();
            this.txtFletero = new System.Windows.Forms.TextBox();
            this.lblBuscarNrodeGuia = new System.Windows.Forms.Label();
            this.grpBusquedaDeGuia = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblCargosLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCargos = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lvGuias = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.grpEncomienda.SuspendLayout();
            this.grpEncomiendas.SuspendLayout();
            this.grpBusquedaDeGuia.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEncomienda
            // 
            this.grpEncomienda.Controls.Add(this.comboBox2);
            this.grpEncomienda.Controls.Add(this.label5);
            this.grpEncomienda.Controls.Add(this.comboBox1);
            this.grpEncomienda.Controls.Add(this.label15);
            this.grpEncomienda.Controls.Add(this.lblNroGuiaLabel);
            this.grpEncomienda.Controls.Add(this.lblCategoriaLabel);
            this.grpEncomienda.Controls.Add(this.cmbCategoria);
            this.grpEncomienda.Controls.Add(this.lblDestinoLabel);
            this.grpEncomienda.Controls.Add(this.btnRegistrar);
            this.grpEncomienda.Location = new System.Drawing.Point(14, 426);
            this.grpEncomienda.Name = "grpEncomienda";
            this.grpEncomienda.Size = new System.Drawing.Size(920, 164);
            this.grpEncomienda.TabIndex = 1;
            this.grpEncomienda.TabStop = false;
            this.grpEncomienda.Text = "Admision ";
            // 
            // lblNroGuiaLabel
            // 
            this.lblNroGuiaLabel.AutoSize = true;
            this.lblNroGuiaLabel.Location = new System.Drawing.Point(133, 29);
            this.lblNroGuiaLabel.Name = "lblNroGuiaLabel";
            this.lblNroGuiaLabel.Size = new System.Drawing.Size(85, 20);
            this.lblNroGuiaLabel.TabIndex = 0;
            this.lblNroGuiaLabel.Text = "N° de guía:";
            // 
            // lblCategoriaLabel
            // 
            this.lblCategoriaLabel.AutoSize = true;
            this.lblCategoriaLabel.Location = new System.Drawing.Point(513, 29);
            this.lblCategoriaLabel.Name = "lblCategoriaLabel";
            this.lblCategoriaLabel.Size = new System.Drawing.Size(153, 20);
            this.lblCategoriaLabel.TabIndex = 3;
            this.lblCategoriaLabel.Text = "Categoría verificada:";
            this.lblCategoriaLabel.Click += new System.EventHandler(this.lblCategoriaLabel_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cmbCategoria.Location = new System.Drawing.Point(680, 25);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(80, 28);
            this.cmbCategoria.TabIndex = 7;
            // 
            // lblDestinoLabel
            // 
            this.lblDestinoLabel.AutoSize = true;
            this.lblDestinoLabel.Location = new System.Drawing.Point(545, 84);
            this.lblDestinoLabel.Name = "lblDestinoLabel";
            this.lblDestinoLabel.Size = new System.Drawing.Size(117, 20);
            this.lblDestinoLabel.TabIndex = 8;
            this.lblDestinoLabel.Text = "CD de Destino:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(415, 123);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 31);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Admitir";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // grpEncomiendas
            // 
            this.grpEncomiendas.Controls.Add(this.lvGuias);
            this.grpEncomiendas.Location = new System.Drawing.Point(14, 605);
            this.grpEncomiendas.Name = "grpEncomiendas";
            this.grpEncomiendas.Size = new System.Drawing.Size(914, 191);
            this.grpEncomiendas.TabIndex = 2;
            this.grpEncomiendas.TabStop = false;
            this.grpEncomiendas.Text = "Encomiendas registradas en esta sesión";
            // 
            // btnFinalizarAdmision
            // 
            this.btnFinalizarAdmision.Location = new System.Drawing.Point(644, 1008);
            this.btnFinalizarAdmision.Name = "btnFinalizarAdmision";
            this.btnFinalizarAdmision.Size = new System.Drawing.Size(130, 31);
            this.btnFinalizarAdmision.TabIndex = 10;
            this.btnFinalizarAdmision.Text = "Finalizar admisión";
            this.btnFinalizarAdmision.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(804, 1005);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 31);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarGuia
            // 
            this.btnBuscarGuia.Location = new System.Drawing.Point(415, 44);
            this.btnBuscarGuia.Name = "btnBuscarGuia";
            this.btnBuscarGuia.Size = new System.Drawing.Size(129, 49);
            this.btnBuscarGuia.TabIndex = 1;
            this.btnBuscarGuia.Text = "Buscar Cliente";
            this.btnBuscarGuia.UseVisualStyleBackColor = true;
            // 
            // txtFletero
            // 
            this.txtFletero.Location = new System.Drawing.Point(186, 36);
            this.txtFletero.Name = "txtFletero";
            this.txtFletero.Size = new System.Drawing.Size(197, 26);
            this.txtFletero.TabIndex = 0;
            // 
            // lblBuscarNrodeGuia
            // 
            this.lblBuscarNrodeGuia.AutoSize = true;
            this.lblBuscarNrodeGuia.Location = new System.Drawing.Point(32, 39);
            this.lblBuscarNrodeGuia.Name = "lblBuscarNrodeGuia";
            this.lblBuscarNrodeGuia.Size = new System.Drawing.Size(150, 20);
            this.lblBuscarNrodeGuia.TabIndex = 0;
            this.lblBuscarNrodeGuia.Text = "Buscar por Nombre:";
            // 
            // grpBusquedaDeGuia
            // 
            this.grpBusquedaDeGuia.Controls.Add(this.textBox1);
            this.grpBusquedaDeGuia.Controls.Add(this.label25);
            this.grpBusquedaDeGuia.Controls.Add(this.lblError);
            this.grpBusquedaDeGuia.Controls.Add(this.lblBuscarNrodeGuia);
            this.grpBusquedaDeGuia.Controls.Add(this.txtFletero);
            this.grpBusquedaDeGuia.Controls.Add(this.btnBuscarGuia);
            this.grpBusquedaDeGuia.Location = new System.Drawing.Point(14, 12);
            this.grpBusquedaDeGuia.Name = "grpBusquedaDeGuia";
            this.grpBusquedaDeGuia.Size = new System.Drawing.Size(925, 123);
            this.grpBusquedaDeGuia.TabIndex = 0;
            this.grpBusquedaDeGuia.TabStop = false;
            this.grpBusquedaDeGuia.Text = "Busqueda de Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(20, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(914, 133);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Guía Seleccionada";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "N° de guía:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Categoría declarada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(218, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 22);
            this.label10.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(674, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 22);
            this.label11.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(674, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 22);
            this.label6.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Domicilio de Entrega:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(218, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 22);
            this.label8.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(496, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Localidad de Entrega:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Tipo de servicio de entrega:";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(218, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 22);
            this.label14.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(224, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 22);
            this.label15.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.comboBox1.Location = new System.Drawing.Point(680, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 28);
            this.comboBox1.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.lblTarifa);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblCargos);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblCargosLabel);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Location = new System.Drawing.Point(14, 812);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(914, 175);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Importes Calculados";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(139, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 20);
            this.label19.TabIndex = 11;
            this.label19.Text = "TARIFA FINAL:";
            // 
            // lblCargosLabel
            // 
            this.lblCargosLabel.AutoSize = true;
            this.lblCargosLabel.Location = new System.Drawing.Point(469, 69);
            this.lblCargosLabel.Name = "lblCargosLabel";
            this.lblCargosLabel.Size = new System.Drawing.Size(197, 20);
            this.lblCargosLabel.TabIndex = 13;
            this.lblCargosLabel.Text = "Cargos a pagar a Agencia:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(477, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(189, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Cargos a pagar a Fletero:";
            // 
            // lblCargos
            // 
            this.lblCargos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCargos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCargos.Location = new System.Drawing.Point(283, 58);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(100, 22);
            this.lblCargos.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(283, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 22);
            this.label17.TabIndex = 21;
            // 
            // lblTarifa
            // 
            this.lblTarifa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTarifa.Location = new System.Drawing.Point(672, 38);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(167, 22);
            this.lblTarifa.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(51, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(209, 20);
            this.label20.TabIndex = 23;
            this.label20.Text = "Extras por Retiro a domicilio:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(37, 82);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(223, 20);
            this.label21.TabIndex = 24;
            this.label21.Text = "Extras por Entrega a domicilio:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(166, 36);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 20);
            this.label22.TabIndex = 25;
            this.label22.Text = "Tarifa Base:";
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Location = new System.Drawing.Point(283, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 22);
            this.label23.TabIndex = 26;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(30, 104);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(230, 20);
            this.label24.TabIndex = 27;
            this.label24.Text = "Extras por Entrega en Agencia:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(69, 73);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(111, 20);
            this.label25.TabIndex = 3;
            this.label25.Text = "Buscar por ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 26);
            this.textBox1.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(558, 58);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(356, 20);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "No se ha encontrado cliente con ese Nombre / ID";
            this.lblError.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(96, 190);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(199, 20);
            this.label26.TabIndex = 3;
            this.label26.Text = "Seleccionar Tipo de Retiro:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(233, 153);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(66, 20);
            this.label28.TabIndex = 0;
            this.label28.Text = "Cliente: ";
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.Location = new System.Drawing.Point(308, 153);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(197, 22);
            this.label29.TabIndex = 17;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(305, 188);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 24);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.Text = "Agencia";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(49, 228);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(249, 20);
            this.label27.TabIndex = 20;
            this.label27.Text = "Seleccionar Nro de Guía a admitir:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.comboBox3.Location = new System.Drawing.Point(305, 225);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(197, 28);
            this.comboBox3.TabIndex = 21;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(520, 188);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(93, 24);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.Text = "Ninguno";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(408, 188);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(97, 24);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.Text = "Domicilio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "CD de Origen:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.comboBox2.Location = new System.Drawing.Point(224, 78);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 28);
            this.comboBox2.TabIndex = 19;
            // 
            // lvGuias
            // 
            this.lvGuias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvGuias.Enabled = false;
            this.lvGuias.FullRowSelect = true;
            this.lvGuias.GridLines = true;
            this.lvGuias.HideSelection = false;
            this.lvGuias.Location = new System.Drawing.Point(13, 41);
            this.lvGuias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvGuias.Name = "lvGuias";
            this.lvGuias.Size = new System.Drawing.Size(894, 133);
            this.lvGuias.TabIndex = 2;
            this.lvGuias.UseCompatibleStateImageBehavior = false;
            this.lvGuias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nº Guía";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cliente";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CD Origen";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CD Destino";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Categoría";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tipo de Entrega";
            this.columnHeader6.Width = 170;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(283, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(283, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(672, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 22);
            this.label18.TabIndex = 30;
            // 
            // frmAdmision
            // 
            this.AutoScroll = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 1050);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBusquedaDeGuia);
            this.Controls.Add(this.grpEncomienda);
            this.Controls.Add(this.grpEncomiendas);
            this.Controls.Add(this.btnFinalizarAdmision);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAdmision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA — Registrar admisión de encomiendas";
            this.grpEncomienda.ResumeLayout(false);
            this.grpEncomienda.PerformLayout();
            this.grpEncomiendas.ResumeLayout(false);
            this.grpBusquedaDeGuia.ResumeLayout(false);
            this.grpBusquedaDeGuia.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox grpEncomienda;
        private System.Windows.Forms.Label lblNroGuiaLabel;
        private System.Windows.Forms.Label lblCategoriaLabel;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblDestinoLabel;
        private System.Windows.Forms.Button btnRegistrar;

        private System.Windows.Forms.GroupBox grpEncomiendas;

        private System.Windows.Forms.Button btnFinalizarAdmision;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarGuia;
        private System.Windows.Forms.TextBox txtFletero;
        private System.Windows.Forms.Label lblBuscarNrodeGuia;
        private System.Windows.Forms.GroupBox grpBusquedaDeGuia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCargos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCargosLabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListView lvGuias;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}