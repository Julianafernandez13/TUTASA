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
            this.lblOperativo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdministrativo = new System.Windows.Forms.Label();
            this.btnCostosVentas = new System.Windows.Forms.Button();
            this.btnEmitirFactura = new System.Windows.Forms.Button();
            this.btnImposicionCallCenter = new System.Windows.Forms.Button();
            this.btnImposicionAgencia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAgencias = new System.Windows.Forms.ComboBox();
            this.lblAgencias = new System.Windows.Forms.Label();
            this.lblCDAgencias = new System.Windows.Forms.Label();
            this.lblCentrosdeDistribucion = new System.Windows.Forms.Label();
            this.btnAgencia = new System.Windows.Forms.Button();
            this.cmbCDdeAgencia = new System.Windows.Forms.ComboBox();
            this.cmbCD = new System.Windows.Forms.ComboBox();
            this.btnDomicilio = new System.Windows.Forms.Button();
            this.radioBtnAgencia = new System.Windows.Forms.RadioButton();
            this.radioBtnCD = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupOpcionesDisponibles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBienvenida.Location = new System.Drawing.Point(303, 9);
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
            this.btnImposicionCD.Margin = new System.Windows.Forms.Padding(2);
            this.btnImposicionCD.Name = "btnImposicionCD";
            this.btnImposicionCD.Size = new System.Drawing.Size(235, 23);
            this.btnImposicionCD.TabIndex = 0;
            this.btnImposicionCD.Text = "Imposición CD";
            this.btnImposicionCD.UseVisualStyleBackColor = true;
            this.btnImposicionCD.Click += new System.EventHandler(this.btnImposicionCD_Click);
            // 
            // btnAdmision
            // 
            this.btnAdmision.Location = new System.Drawing.Point(42, 172);
            this.btnAdmision.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmision.Name = "btnAdmision";
            this.btnAdmision.Size = new System.Drawing.Size(235, 23);
            this.btnAdmision.TabIndex = 1;
            this.btnAdmision.Text = "Admisión";
            this.btnAdmision.UseVisualStyleBackColor = true;
            this.btnAdmision.Click += new System.EventHandler(this.btnAdmision_Click);
            // 
            // btnConfeccionHDR
            // 
            this.btnConfeccionHDR.Location = new System.Drawing.Point(42, 118);
            this.btnConfeccionHDR.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfeccionHDR.Name = "btnConfeccionHDR";
            this.btnConfeccionHDR.Size = new System.Drawing.Size(235, 23);
            this.btnConfeccionHDR.TabIndex = 2;
            this.btnConfeccionHDR.Text = "HDR de Ultima Milla";
            this.btnConfeccionHDR.UseVisualStyleBackColor = true;
            this.btnConfeccionHDR.Click += new System.EventHandler(this.btnConfeccionHDR_Click);
            // 
            // btnRendicionHDR
            // 
            this.btnRendicionHDR.Location = new System.Drawing.Point(42, 145);
            this.btnRendicionHDR.Margin = new System.Windows.Forms.Padding(2);
            this.btnRendicionHDR.Name = "btnRendicionHDR";
            this.btnRendicionHDR.Size = new System.Drawing.Size(235, 23);
            this.btnRendicionHDR.TabIndex = 3;
            this.btnRendicionHDR.Text = "Rendición HDR de Ultima Milla";
            this.btnRendicionHDR.UseVisualStyleBackColor = true;
            this.btnRendicionHDR.Click += new System.EventHandler(this.btnRendicionHDR_Click);
            // 
            // btnDespacho
            // 
            this.btnDespacho.Location = new System.Drawing.Point(42, 199);
            this.btnDespacho.Margin = new System.Windows.Forms.Padding(2);
            this.btnDespacho.Name = "btnDespacho";
            this.btnDespacho.Size = new System.Drawing.Size(235, 23);
            this.btnDespacho.TabIndex = 4;
            this.btnDespacho.Text = "HDR de transporte";
            this.btnDespacho.UseVisualStyleBackColor = true;
            this.btnDespacho.Click += new System.EventHandler(this.btnDespacho_Click);
            // 
            // btnRecepcionTransporte
            // 
            this.btnRecepcionTransporte.Location = new System.Drawing.Point(42, 226);
            this.btnRecepcionTransporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecepcionTransporte.Name = "btnRecepcionTransporte";
            this.btnRecepcionTransporte.Size = new System.Drawing.Size(235, 23);
            this.btnRecepcionTransporte.TabIndex = 5;
            this.btnRecepcionTransporte.Text = "Rendición HDR de Transporte";
            this.btnRecepcionTransporte.UseVisualStyleBackColor = true;
            this.btnRecepcionTransporte.Click += new System.EventHandler(this.btnRecepcionTransporte_Click);
            // 
            // btnEntregaCD
            // 
            this.btnEntregaCD.Location = new System.Drawing.Point(42, 253);
            this.btnEntregaCD.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntregaCD.Name = "btnEntregaCD";
            this.btnEntregaCD.Size = new System.Drawing.Size(235, 23);
            this.btnEntregaCD.TabIndex = 6;
            this.btnEntregaCD.Text = "Entrega de Encomienda";
            this.btnEntregaCD.UseVisualStyleBackColor = true;
            this.btnEntregaCD.Click += new System.EventHandler(this.btnEntregaCD_Click);
            // 
            // btnTracking
            // 
            this.btnTracking.Location = new System.Drawing.Point(42, 366);
            this.btnTracking.Margin = new System.Windows.Forms.Padding(2);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(235, 23);
            this.btnTracking.TabIndex = 7;
            this.btnTracking.Text = "Consultar tracking";
            this.btnTracking.UseVisualStyleBackColor = true;
            this.btnTracking.Click += new System.EventHandler(this.btnTracking_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(232, 469);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(235, 23);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // groupOpcionesDisponibles
            // 
            this.groupOpcionesDisponibles.Controls.Add(this.lblOperativo);
            this.groupOpcionesDisponibles.Controls.Add(this.label3);
            this.groupOpcionesDisponibles.Controls.Add(this.lblAdministrativo);
            this.groupOpcionesDisponibles.Controls.Add(this.btnCostosVentas);
            this.groupOpcionesDisponibles.Controls.Add(this.btnEmitirFactura);
            this.groupOpcionesDisponibles.Controls.Add(this.btnImposicionCallCenter);
            this.groupOpcionesDisponibles.Controls.Add(this.btnImposicionAgencia);
            this.groupOpcionesDisponibles.Controls.Add(this.btnImposicionCD);
            this.groupOpcionesDisponibles.Controls.Add(this.btnConfeccionHDR);
            this.groupOpcionesDisponibles.Controls.Add(this.btnTracking);
            this.groupOpcionesDisponibles.Controls.Add(this.btnEntregaCD);
            this.groupOpcionesDisponibles.Controls.Add(this.btnRecepcionTransporte);
            this.groupOpcionesDisponibles.Controls.Add(this.btnDespacho);
            this.groupOpcionesDisponibles.Controls.Add(this.btnAdmision);
            this.groupOpcionesDisponibles.Controls.Add(this.btnRendicionHDR);
            this.groupOpcionesDisponibles.Location = new System.Drawing.Point(358, 54);
            this.groupOpcionesDisponibles.Name = "groupOpcionesDisponibles";
            this.groupOpcionesDisponibles.Size = new System.Drawing.Size(315, 398);
            this.groupOpcionesDisponibles.TabIndex = 9;
            this.groupOpcionesDisponibles.TabStop = false;
            this.groupOpcionesDisponibles.Text = "Opciones Disponibles";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Informativo:";
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
            // btnCostosVentas
            // 
            this.btnCostosVentas.Location = new System.Drawing.Point(42, 323);
            this.btnCostosVentas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCostosVentas.Name = "btnCostosVentas";
            this.btnCostosVentas.Size = new System.Drawing.Size(235, 23);
            this.btnCostosVentas.TabIndex = 12;
            this.btnCostosVentas.Text = "Costos vs Ventas ";
            this.btnCostosVentas.UseVisualStyleBackColor = true;
            this.btnCostosVentas.Click += new System.EventHandler(this.btnCostosVentas_Click);
            // 
            // btnEmitirFactura
            // 
            this.btnEmitirFactura.Location = new System.Drawing.Point(42, 296);
            this.btnEmitirFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmitirFactura.Name = "btnEmitirFactura";
            this.btnEmitirFactura.Size = new System.Drawing.Size(235, 23);
            this.btnEmitirFactura.TabIndex = 11;
            this.btnEmitirFactura.Text = "Emitir Factura";
            this.btnEmitirFactura.UseVisualStyleBackColor = true;
            this.btnEmitirFactura.Click += new System.EventHandler(this.btnEmitirFactura_Click);
            // 
            // btnImposicionCallCenter
            // 
            this.btnImposicionCallCenter.Location = new System.Drawing.Point(42, 37);
            this.btnImposicionCallCenter.Margin = new System.Windows.Forms.Padding(2);
            this.btnImposicionCallCenter.Name = "btnImposicionCallCenter";
            this.btnImposicionCallCenter.Size = new System.Drawing.Size(235, 23);
            this.btnImposicionCallCenter.TabIndex = 9;
            this.btnImposicionCallCenter.Text = "Imposición Call Center";
            this.btnImposicionCallCenter.UseVisualStyleBackColor = true;
            this.btnImposicionCallCenter.Click += new System.EventHandler(this.btnImposicionCallCenter_Click);
            // 
            // btnImposicionAgencia
            // 
            this.btnImposicionAgencia.Location = new System.Drawing.Point(42, 64);
            this.btnImposicionAgencia.Margin = new System.Windows.Forms.Padding(2);
            this.btnImposicionAgencia.Name = "btnImposicionAgencia";
            this.btnImposicionAgencia.Size = new System.Drawing.Size(235, 23);
            this.btnImposicionAgencia.TabIndex = 10;
            this.btnImposicionAgencia.Text = "Imposición Agencia";
            this.btnImposicionAgencia.UseVisualStyleBackColor = true;
            this.btnImposicionAgencia.Click += new System.EventHandler(this.btnImposicionAgencia_Click);
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
            this.groupBox1.Size = new System.Drawing.Size(313, 398);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Punto Operativo";
            // 
            // cmbAgencias
            // 
            this.cmbAgencias.FormattingEnabled = true;
            this.cmbAgencias.Location = new System.Drawing.Point(6, 334);
            this.cmbAgencias.Name = "cmbAgencias";
            this.cmbAgencias.Size = new System.Drawing.Size(301, 21);
            this.cmbAgencias.TabIndex = 17;
            // 
            // lblAgencias
            // 
            this.lblAgencias.AutoSize = true;
            this.lblAgencias.Location = new System.Drawing.Point(6, 310);
            this.lblAgencias.Name = "lblAgencias";
            this.lblAgencias.Size = new System.Drawing.Size(228, 13);
            this.lblAgencias.TabIndex = 16;
            this.lblAgencias.Text = "Seleccione la Agencia en la que se encuentra;";
            // 
            // lblCDAgencias
            // 
            this.lblCDAgencias.AutoSize = true;
            this.lblCDAgencias.Location = new System.Drawing.Point(3, 262);
            this.lblCDAgencias.Name = "lblCDAgencias";
            this.lblCDAgencias.Size = new System.Drawing.Size(175, 13);
            this.lblCDAgencias.TabIndex = 14;
            this.lblCDAgencias.Text = "Seleccione el CD al que pertenece:";
            // 
            // lblCentrosdeDistribucion
            // 
            this.lblCentrosdeDistribucion.AutoSize = true;
            this.lblCentrosdeDistribucion.Location = new System.Drawing.Point(6, 145);
            this.lblCentrosdeDistribucion.Name = "lblCentrosdeDistribucion";
            this.lblCentrosdeDistribucion.Size = new System.Drawing.Size(190, 13);
            this.lblCentrosdeDistribucion.TabIndex = 13;
            this.lblCentrosdeDistribucion.Text = "Seleccione el CD donde se encuentra;";
            // 
            // btnAgencia
            // 
            this.btnAgencia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgencia.ForeColor = System.Drawing.Color.White;
            this.btnAgencia.Location = new System.Drawing.Point(6, 223);
            this.btnAgencia.Name = "btnAgencia";
            this.btnAgencia.Size = new System.Drawing.Size(301, 26);
            this.btnAgencia.TabIndex = 12;
            this.btnAgencia.Text = "En agencia";
            this.btnAgencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgencia.UseVisualStyleBackColor = false;
            // 
            // cmbCDdeAgencia
            // 
            this.cmbCDdeAgencia.FormattingEnabled = true;
            this.cmbCDdeAgencia.Location = new System.Drawing.Point(6, 282);
            this.cmbCDdeAgencia.Name = "cmbCDdeAgencia";
            this.cmbCDdeAgencia.Size = new System.Drawing.Size(301, 21);
            this.cmbCDdeAgencia.TabIndex = 11;
            this.cmbCDdeAgencia.SelectedIndexChanged += new System.EventHandler(this.cmbCDdeAgencia_SelectedIndexChanged);
            // 
            // cmbCD
            // 
            this.cmbCD.FormattingEnabled = true;
            this.cmbCD.Location = new System.Drawing.Point(9, 163);
            this.cmbCD.Name = "cmbCD";
            this.cmbCD.Size = new System.Drawing.Size(301, 21);
            this.cmbCD.TabIndex = 10;
            // 
            // btnDomicilio
            // 
            this.btnDomicilio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDomicilio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDomicilio.ForeColor = System.Drawing.Color.White;
            this.btnDomicilio.Location = new System.Drawing.Point(6, 105);
            this.btnDomicilio.Name = "btnDomicilio";
            this.btnDomicilio.Size = new System.Drawing.Size(301, 26);
            this.btnDomicilio.TabIndex = 8;
            this.btnDomicilio.Text = "En centro de distibucion";
            this.btnDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDomicilio.UseVisualStyleBackColor = false;
            // 
            // radioBtnAgencia
            // 
            this.radioBtnAgencia.AutoSize = true;
            this.radioBtnAgencia.Location = new System.Drawing.Point(199, 52);
            this.radioBtnAgencia.Name = "radioBtnAgencia";
            this.radioBtnAgencia.Size = new System.Drawing.Size(64, 17);
            this.radioBtnAgencia.TabIndex = 1;
            this.radioBtnAgencia.TabStop = true;
            this.radioBtnAgencia.Text = "Agencia";
            this.radioBtnAgencia.UseVisualStyleBackColor = true;
            this.radioBtnAgencia.CheckedChanged += new System.EventHandler(this.radioBtnAgencia_CheckedChanged);
            // 
            // radioBtnCD
            // 
            this.radioBtnCD.AutoSize = true;
            this.radioBtnCD.Location = new System.Drawing.Point(37, 52);
            this.radioBtnCD.Name = "radioBtnCD";
            this.radioBtnCD.Size = new System.Drawing.Size(129, 17);
            this.radioBtnCD.TabIndex = 0;
            this.radioBtnCD.TabStop = true;
            this.radioBtnCD.Text = "Centro de Distribución";
            this.radioBtnCD.UseVisualStyleBackColor = true;
            this.radioBtnCD.CheckedChanged += new System.EventHandler(this.radioBtnCD_CheckedChanged);
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
            this.label2.Location = new System.Drawing.Point(289, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sistema TUTASA";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(709, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupOpcionesDisponibles);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnCerrarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA — Menú Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
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
        private System.Windows.Forms.Button btnImposicionAgencia;
        private System.Windows.Forms.Button btnImposicionCallCenter;
        private System.Windows.Forms.RadioButton radioBtnAgencia;
        private System.Windows.Forms.Button btnCostosVentas;
        private System.Windows.Forms.Button btnEmitirFactura;
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