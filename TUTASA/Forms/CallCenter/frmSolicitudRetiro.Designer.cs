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
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grpCliente.SuspendLayout();
            this.grpRetiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadCajas)).BeginInit();
            this.grpDestinatario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.grpRetiro.Controls.Add(this.button4);
            this.grpRetiro.Controls.Add(this.lblDomicilioRetiro);
            this.grpRetiro.Controls.Add(this.label11);
            this.grpRetiro.Controls.Add(this.textBox9);
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
            this.lblDomicilioRetiro.Location = new System.Drawing.Point(10, 51);
            this.lblDomicilioRetiro.Name = "lblDomicilioRetiro";
            this.lblDomicilioRetiro.Size = new System.Drawing.Size(120, 20);
            this.lblDomicilioRetiro.TabIndex = 0;
            this.lblDomicilioRetiro.Text = "Domicilio de retiro:";
            // 
            // txtDomicilioRetiro
            // 
            this.txtDomicilioRetiro.Location = new System.Drawing.Point(135, 48);
            this.txtDomicilioRetiro.Name = "txtDomicilioRetiro";
            this.txtDomicilioRetiro.Size = new System.Drawing.Size(410, 20);
            this.txtDomicilioRetiro.TabIndex = 1;
            // 
            // lblCantidadCajas
            // 
            this.lblCantidadCajas.Location = new System.Drawing.Point(10, 88);
            this.lblCantidadCajas.Name = "lblCantidadCajas";
            this.lblCantidadCajas.Size = new System.Drawing.Size(115, 20);
            this.lblCantidadCajas.TabIndex = 2;
            this.lblCantidadCajas.Text = "Cantidad de cajas:";
            // 
            // nudCantidadCajas
            // 
            this.nudCantidadCajas.Location = new System.Drawing.Point(130, 86);
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
            this.lblCategoria.Location = new System.Drawing.Point(210, 88);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(115, 20);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría de caja:";
            // 
            // rbS
            // 
            this.rbS.Checked = true;
            this.rbS.Location = new System.Drawing.Point(330, 86);
            this.rbS.Name = "rbS";
            this.rbS.Size = new System.Drawing.Size(45, 20);
            this.rbS.TabIndex = 5;
            this.rbS.TabStop = true;
            this.rbS.Text = "S";
            // 
            // rbM
            // 
            this.rbM.Location = new System.Drawing.Point(375, 86);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(45, 20);
            this.rbM.TabIndex = 6;
            this.rbM.Text = "M";
            // 
            // rbL
            // 
            this.rbL.Location = new System.Drawing.Point(420, 86);
            this.rbL.Name = "rbL";
            this.rbL.Size = new System.Drawing.Size(45, 20);
            this.rbL.TabIndex = 7;
            this.rbL.Text = "L";
            // 
            // rbXL
            // 
            this.rbXL.Location = new System.Drawing.Point(465, 86);
            this.rbXL.Name = "rbXL";
            this.rbXL.Size = new System.Drawing.Size(50, 20);
            this.rbXL.TabIndex = 8;
            this.rbXL.Text = "XL";
            // 
            // grpDestinatario
            // 
            this.grpDestinatario.Controls.Add(this.comboBox1);
            this.grpDestinatario.Controls.Add(this.label6);
            this.grpDestinatario.Controls.Add(this.button1);
            this.grpDestinatario.Controls.Add(this.lblNombreDestinatario);
            this.grpDestinatario.Controls.Add(this.txtNombreDestinatario);
            this.grpDestinatario.Controls.Add(this.label5);
            this.grpDestinatario.Controls.Add(this.textBox5);
            this.grpDestinatario.Controls.Add(this.lblTelefono);
            this.grpDestinatario.Controls.Add(this.txtTelefono);
            this.grpDestinatario.Location = new System.Drawing.Point(12, 289);
            this.grpDestinatario.Name = "grpDestinatario";
            this.grpDestinatario.Size = new System.Drawing.Size(560, 213);
            this.grpDestinatario.TabIndex = 2;
            this.grpDestinatario.TabStop = false;
            this.grpDestinatario.Text = "CD";
            // 
            // lblNombreDestinatario
            // 
            this.lblNombreDestinatario.Location = new System.Drawing.Point(5, 112);
            this.lblNombreDestinatario.Name = "lblNombreDestinatario";
            this.lblNombreDestinatario.Size = new System.Drawing.Size(115, 20);
            this.lblNombreDestinatario.TabIndex = 0;
            this.lblNombreDestinatario.Text = "Nombre y apellido:";
            // 
            // txtNombreDestinatario
            // 
            this.txtNombreDestinatario.Location = new System.Drawing.Point(125, 109);
            this.txtNombreDestinatario.Name = "txtNombreDestinatario";
            this.txtNombreDestinatario.Size = new System.Drawing.Size(410, 20);
            this.txtNombreDestinatario.TabIndex = 1;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Location = new System.Drawing.Point(6, 138);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(135, 20);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Teléfono de contacto:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(147, 135);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(337, 525);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(130, 35);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar Solicitud";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(477, 525);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 35);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Buscar localidad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(36, 257);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Domicilio";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(159, 257);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Agencia";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(319, 257);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(40, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "CD";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(613, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 213);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domicilio";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Buscar localidad";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y apellido:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Domicilio de entrega:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código postal:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 129);
            this.textBox3.MaxLength = 8;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(27, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teléfono de contacto:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(167, 167);
            this.textBox4.MaxLength = 15;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(117, 22);
            this.textBox5.MaxLength = 8;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 20);
            this.textBox5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(21, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Código postal:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(27, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "CD";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(405, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Location = new System.Drawing.Point(615, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 213);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agencia";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(123, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(405, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(27, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Agencia:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Buscar localidad";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(5, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre y apellido:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(125, 109);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(410, 20);
            this.textBox6.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(21, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Código postal:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(117, 22);
            this.textBox7.MaxLength = 8;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(155, 20);
            this.textBox7.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Teléfono de contacto:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(125, 135);
            this.textBox8.MaxLength = 15;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(200, 20);
            this.textBox8.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(286, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Buscar localidad";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(21, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Código postal:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(125, 19);
            this.textBox9.MaxLength = 8;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(155, 20);
            this.textBox9.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(531, 475);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(385, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "En las tres opciones falta DNI p/entregar";
            // 
            // frmSolicitudRetiro
            // 
            this.ClientSize = new System.Drawing.Size(992, 582);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.grpRetiro);
            this.Controls.Add(this.radioButton1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
    }
}