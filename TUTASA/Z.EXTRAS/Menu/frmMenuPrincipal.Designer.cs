namespace TUTASA.Forms.Menu
{
    partial class frmMenuPrincipal
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnImposicionCD = new System.Windows.Forms.Button();
            this.btnAdmision = new System.Windows.Forms.Button();
            this.btnConfeccionHDR = new System.Windows.Forms.Button();
            this.btnRendicionHDR = new System.Windows.Forms.Button();
            this.btnDespacho = new System.Windows.Forms.Button();
            this.btnRecepcionTransporte = new System.Windows.Forms.Button();
            this.btnEntregaCD = new System.Windows.Forms.Button();
            this.btnTracking = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.groupOpcionesDisponibles = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtnCD = new System.Windows.Forms.RadioButton();
            this.radioBtnAgencia = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblAdministrativo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOperativo = new System.Windows.Forms.Label();
            this.btnDomicilio = new System.Windows.Forms.Button();
            this.cmbCD = new System.Windows.Forms.ComboBox();
            this.cmbCDdeAgencia = new System.Windows.Forms.ComboBox();
            this.btnAgencia = new System.Windows.Forms.Button();
            this.lblCentrosdeDistribucion = new System.Windows.Forms.Label();
            this.lblCDAgencias = new System.Windows.Forms.Label();
            this.lblAgencias = new System.Windows.Forms.Label();
            this.cmbAgencias = new System.Windows.Forms.ComboBox();
            this.groupOpcionesDisponibles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBienvenida.Location = new System.Drawing.Point(137, 9);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(101, 21);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido ";
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // btnImposicionCD
            // 
            this.btnImposicionCD.Location = new System.Drawing.Point(42, 91);
            this.btnImposicionCD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImposicionCD.Name = "btnImposicionCD";
            this.btnImposicionCD.Size = new System.Drawing.Size(235, 23);
            this.btnImposicionCD.TabIndex = 0;
            this.btnImposicionCD.Text = "Imposición CD";
            this.btnImposicionCD.UseVisualStyleBackColor = true;
            // 
            // btnAdmision
            // 
            this.btnAdmision.Location = new System.Drawing.Point(42, 172);
            this.btnAdmision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmision.Name = "btnAdmision";
            this.btnAdmision.Size = new System.Drawing.Size(235, 23);
            this.btnAdmision.TabIndex = 1;
            this.btnAdmision.Text = "Admisión";
            this.btnAdmision.UseVisualStyleBackColor = true;
            // 
            // btnConfeccionHDR
            // 
            this.btnConfeccionHDR.Location = new System.Drawing.Point(42, 118);
            this.btnConfeccionHDR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfeccionHDR.Name = "btnConfeccionHDR";
            this.btnConfeccionHDR.Size = new System.Drawing.Size(235, 23);
            this.btnConfeccionHDR.TabIndex = 2;
            this.btnConfeccionHDR.Text = "HDR de Retiro";
            this.btnConfeccionHDR.UseVisualStyleBackColor = true;
            // 
            // btnRendicionHDR
            // 
            this.btnRendicionHDR.Location = new System.Drawing.Point(42, 145);
            this.btnRendicionHDR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRendicionHDR.Name = "btnRendicionHDR";
            this.btnRendicionHDR.Size = new System.Drawing.Size(235, 23);
            this.btnRendicionHDR.TabIndex = 3;
            this.btnRendicionHDR.Text = "Rendición HDR de Retiro";
            this.btnRendicionHDR.UseVisualStyleBackColor = true;
            // 
            // btnDespacho
            // 
            this.btnDespacho.Location = new System.Drawing.Point(42, 199);
            this.btnDespacho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDespacho.Name = "btnDespacho";
            this.btnDespacho.Size = new System.Drawing.Size(235, 23);
            this.btnDespacho.TabIndex = 4;
            this.btnDespacho.Text = "HDR de transporte";
            this.btnDespacho.UseVisualStyleBackColor = true;
            // 
            // btnRecepcionTransporte
            // 
            this.btnRecepcionTransporte.Location = new System.Drawing.Point(42, 226);
            this.btnRecepcionTransporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecepcionTransporte.Name = "btnRecepcionTransporte";
            this.btnRecepcionTransporte.Size = new System.Drawing.Size(235, 23);
            this.btnRecepcionTransporte.TabIndex = 5;
            this.btnRecepcionTransporte.Text = "Rendición HDR de Transporte";
            this.btnRecepcionTransporte.UseVisualStyleBackColor = true;
            // 
            // btnEntregaCD
            // 
            this.btnEntregaCD.Location = new System.Drawing.Point(42, 253);
            this.btnEntregaCD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntregaCD.Name = "btnEntregaCD";
            this.btnEntregaCD.Size = new System.Drawing.Size(235, 23);
            this.btnEntregaCD.TabIndex = 6;
            this.btnEntregaCD.Text = "Entrega de Encomienda";
            this.btnEntregaCD.UseVisualStyleBackColor = true;
            // 
            // btnTracking
            // 
            this.btnTracking.Location = new System.Drawing.Point(42, 366);
            this.btnTracking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(235, 23);
            this.btnTracking.TabIndex = 7;
            this.btnTracking.Text = "Consultar tracking";
            this.btnTracking.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(42, 417);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(235, 23);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // groupOpcionesDisponibles
            // 
            this.groupOpcionesDisponibles.Controls.Add(this.lblOperativo);
            this.groupOpcionesDisponibles.Controls.Add(this.label3);
            this.groupOpcionesDisponibles.Controls.Add(this.lblAdministrativo);
            this.groupOpcionesDisponibles.Controls.Add(this.button4);
            this.groupOpcionesDisponibles.Controls.Add(this.button3);
            this.groupOpcionesDisponibles.Controls.Add(this.button1);
            this.groupOpcionesDisponibles.Controls.Add(this.button2);
            this.groupOpcionesDisponibles.Controls.Add(this.btnImposicionCD);
            this.groupOpcionesDisponibles.Controls.Add(this.btnConfeccionHDR);
            this.groupOpcionesDisponibles.Controls.Add(this.btnCerrarSesion);
            this.groupOpcionesDisponibles.Controls.Add(this.btnTracking);
            this.groupOpcionesDisponibles.Controls.Add(this.btnEntregaCD);
            this.groupOpcionesDisponibles.Controls.Add(this.btnRecepcionTransporte);
            this.groupOpcionesDisponibles.Controls.Add(this.btnDespacho);
            this.groupOpcionesDisponibles.Controls.Add(this.btnAdmision);
            this.groupOpcionesDisponibles.Controls.Add(this.btnRendicionHDR);
            this.groupOpcionesDisponibles.Location = new System.Drawing.Point(33, 354);
            this.groupOpcionesDisponibles.Name = "groupOpcionesDisponibles";
            this.groupOpcionesDisponibles.Size = new System.Drawing.Size(315, 445);
            this.groupOpcionesDisponibles.TabIndex = 9;
            this.groupOpcionesDisponibles.TabStop = false;
            this.groupOpcionesDisponibles.Text = "Opciones Disponibles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAgencias);
            this.groupBox1.Controls.Add(this.lblAgencias);
            this.groupBox1.Controls.Add(this.lblCDAgencias);
            this.groupBox1.Controls.Add(this.lblCentrosdeDistribucion);
            this.groupBox1.Controls.Add(this.btnAgencia);
            this.groupBox1.Controls.Add(this.cmbCDdeAgencia);
            this.groupBox1.Controls.Add(this.cmbCD);
            this.groupBox1.Controls.Add(this.btnDomicilio);
            this.groupBox1.Controls.Add(this.radioBtnAgencia);
            this.groupBox1.Controls.Add(this.radioBtnCD);
            this.groupBox1.Location = new System.Drawing.Point(33, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 294);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Punto Operativo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(175, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(119, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sistema TUTASA";
            // 
            // radioBtnCD
            // 
            this.radioBtnCD.AutoSize = true;
            this.radioBtnCD.Location = new System.Drawing.Point(50, 31);
            this.radioBtnCD.Name = "radioBtnCD";
            this.radioBtnCD.Size = new System.Drawing.Size(129, 17);
            this.radioBtnCD.TabIndex = 0;
            this.radioBtnCD.TabStop = true;
            this.radioBtnCD.Text = "Centro de Distribución";
            this.radioBtnCD.UseVisualStyleBackColor = true;
            // 
            // radioBtnAgencia
            // 
            this.radioBtnAgencia.AutoSize = true;
            this.radioBtnAgencia.Location = new System.Drawing.Point(199, 31);
            this.radioBtnAgencia.Name = "radioBtnAgencia";
            this.radioBtnAgencia.Size = new System.Drawing.Size(64, 17);
            this.radioBtnAgencia.TabIndex = 1;
            this.radioBtnAgencia.TabStop = true;
            this.radioBtnAgencia.Text = "Agencia";
            this.radioBtnAgencia.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Imposición Call Center";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Imposición Agencia";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 296);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Emitir Factura";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(42, 323);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Costos vs Ventas ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblAdministrativo
            // 
            this.lblAdministrativo.AutoSize = true;
            this.lblAdministrativo.Location = new System.Drawing.Point(23, 281);
            this.lblAdministrativo.Name = "lblAdministrativo";
            this.lblAdministrativo.Size = new System.Drawing.Size(75, 13);
            this.lblAdministrativo.TabIndex = 13;
            this.lblAdministrativo.Text = "Administrativo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Informativo:";
            // 
            // lblOperativo
            // 
            this.lblOperativo.AutoSize = true;
            this.lblOperativo.Location = new System.Drawing.Point(23, 22);
            this.lblOperativo.Name = "lblOperativo";
            this.lblOperativo.Size = new System.Drawing.Size(56, 13);
            this.lblOperativo.TabIndex = 15;
            this.lblOperativo.Text = "Operativo:";
            // 
            // btnDomicilio
            // 
            this.btnDomicilio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDomicilio.ForeColor = System.Drawing.Color.White;
            this.btnDomicilio.Location = new System.Drawing.Point(6, 68);
            this.btnDomicilio.Name = "btnDomicilio";
            this.btnDomicilio.Size = new System.Drawing.Size(301, 26);
            this.btnDomicilio.TabIndex = 8;
            this.btnDomicilio.Text = "En centro de distibucion";
            this.btnDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDomicilio.UseVisualStyleBackColor = false;
            // 
            // cmbCD
            // 
            this.cmbCD.FormattingEnabled = true;
            this.cmbCD.Location = new System.Drawing.Point(6, 118);
            this.cmbCD.Name = "cmbCD";
            this.cmbCD.Size = new System.Drawing.Size(301, 21);
            this.cmbCD.TabIndex = 10;
            // 
            // cmbCDdeAgencia
            // 
            this.cmbCDdeAgencia.FormattingEnabled = true;
            this.cmbCDdeAgencia.Location = new System.Drawing.Point(6, 215);
            this.cmbCDdeAgencia.Name = "cmbCDdeAgencia";
            this.cmbCDdeAgencia.Size = new System.Drawing.Size(301, 21);
            this.cmbCDdeAgencia.TabIndex = 11;
            // 
            // btnAgencia
            // 
            this.btnAgencia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgencia.ForeColor = System.Drawing.Color.White;
            this.btnAgencia.Location = new System.Drawing.Point(6, 158);
            this.btnAgencia.Name = "btnAgencia";
            this.btnAgencia.Size = new System.Drawing.Size(301, 26);
            this.btnAgencia.TabIndex = 12;
            this.btnAgencia.Text = "En agencia";
            this.btnAgencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgencia.UseVisualStyleBackColor = false;
            // 
            // lblCentrosdeDistribucion
            // 
            this.lblCentrosdeDistribucion.AutoSize = true;
            this.lblCentrosdeDistribucion.Location = new System.Drawing.Point(6, 102);
            this.lblCentrosdeDistribucion.Name = "lblCentrosdeDistribucion";
            this.lblCentrosdeDistribucion.Size = new System.Drawing.Size(190, 13);
            this.lblCentrosdeDistribucion.TabIndex = 13;
            this.lblCentrosdeDistribucion.Text = "Seleccione el CD donde se encuentra;";
            // 
            // lblCDAgencias
            // 
            this.lblCDAgencias.AutoSize = true;
            this.lblCDAgencias.Location = new System.Drawing.Point(6, 199);
            this.lblCDAgencias.Name = "lblCDAgencias";
            this.lblCDAgencias.Size = new System.Drawing.Size(175, 13);
            this.lblCDAgencias.TabIndex = 14;
            this.lblCDAgencias.Text = "Seleccione el CD al que pertenece:";
            // 
            // lblAgencias
            // 
            this.lblAgencias.AutoSize = true;
            this.lblAgencias.Location = new System.Drawing.Point(6, 239);
            this.lblAgencias.Name = "lblAgencias";
            this.lblAgencias.Size = new System.Drawing.Size(228, 13);
            this.lblAgencias.TabIndex = 16;
            this.lblAgencias.Text = "Seleccione la Agencia en la que se encuentra;";
            // 
            // cmbAgencias
            // 
            this.cmbAgencias.FormattingEnabled = true;
            this.cmbAgencias.Location = new System.Drawing.Point(6, 255);
            this.cmbAgencias.Name = "cmbAgencias";
            this.cmbAgencias.Size = new System.Drawing.Size(301, 21);
            this.cmbAgencias.TabIndex = 17;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(379, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupOpcionesDisponibles);
            this.Controls.Add(this.lblBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA — Menú Principal";
            this.groupOpcionesDisponibles.ResumeLayout(false);
            this.groupOpcionesDisponibles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnImposicionCD;
        private System.Windows.Forms.Button btnAdmision;
        private System.Windows.Forms.Button btnConfeccionHDR;
        private System.Windows.Forms.Button btnRendicionHDR;
        private System.Windows.Forms.Button btnDespacho;
        private System.Windows.Forms.Button btnRecepcionTransporte;
        private System.Windows.Forms.Button btnEntregaCD;
        private System.Windows.Forms.Button btnTracking;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.GroupBox groupOpcionesDisponibles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtnCD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioBtnAgencia;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblAdministrativo;
        private System.Windows.Forms.Label lblOperativo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCDdeAgencia;
        private System.Windows.Forms.ComboBox cmbCD;
        private System.Windows.Forms.Button btnDomicilio;
        private System.Windows.Forms.Button btnAgencia;
        private System.Windows.Forms.Label lblCentrosdeDistribucion;
        private System.Windows.Forms.ComboBox cmbAgencias;
        private System.Windows.Forms.Label lblAgencias;
        private System.Windows.Forms.Label lblCDAgencias;
    }
}