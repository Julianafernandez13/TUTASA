namespace TUTASA.Forms.CD
{
    partial class frmEntregaCD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarEntrega = new System.Windows.Forms.Button();
            this.grpReceptor = new System.Windows.Forms.GroupBox();
            this.txtNombreReceptor = new System.Windows.Forms.TextBox();
            this.txtDNIReceptor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblReceptor = new System.Windows.Forms.Label();
            this.grpEncomienda = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblRemitente = new System.Windows.Forms.Label();
            this.lblGuia = new System.Windows.Forms.Label();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpReceptor.SuspendLayout();
            this.grpEncomienda.SuspendLayout();
            this.grpBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnConfirmarEntrega);
            this.groupBox1.Controls.Add(this.grpReceptor);
            this.groupBox1.Controls.Add(this.grpEncomienda);
            this.groupBox1.Controls.Add(this.grpBusqueda);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(690, 699);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TUTASA - Registrar Entrega en CD";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(362, 643);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 46);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarEntrega
            // 
            this.btnConfirmarEntrega.Location = new System.Drawing.Point(159, 643);
            this.btnConfirmarEntrega.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmarEntrega.Name = "btnConfirmarEntrega";
            this.btnConfirmarEntrega.Size = new System.Drawing.Size(195, 46);
            this.btnConfirmarEntrega.TabIndex = 3;
            this.btnConfirmarEntrega.Text = "Confirmar Entrega";
            this.btnConfirmarEntrega.UseVisualStyleBackColor = true;
            // 
            // grpReceptor
            // 
            this.grpReceptor.Controls.Add(this.txtNombreReceptor);
            this.grpReceptor.Controls.Add(this.txtDNIReceptor);
            this.grpReceptor.Controls.Add(this.label9);
            this.grpReceptor.Controls.Add(this.label8);
            this.grpReceptor.Controls.Add(this.lblReceptor);
            this.grpReceptor.Location = new System.Drawing.Point(8, 483);
            this.grpReceptor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpReceptor.Name = "grpReceptor";
            this.grpReceptor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpReceptor.Size = new System.Drawing.Size(672, 138);
            this.grpReceptor.TabIndex = 2;
            this.grpReceptor.TabStop = false;
            this.grpReceptor.Text = "Datos del Receptor";
            // 
            // txtNombreReceptor
            // 
            this.txtNombreReceptor.Location = new System.Drawing.Point(176, 83);
            this.txtNombreReceptor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreReceptor.MaxLength = 100;
            this.txtNombreReceptor.Name = "txtNombreReceptor";
            this.txtNombreReceptor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNombreReceptor.Size = new System.Drawing.Size(418, 26);
            this.txtNombreReceptor.TabIndex = 17;
            // 
            // txtDNIReceptor
            // 
            this.txtDNIReceptor.Location = new System.Drawing.Point(176, 43);
            this.txtDNIReceptor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDNIReceptor.MaxLength = 8;
            this.txtDNIReceptor.Name = "txtDNIReceptor";
            this.txtDNIReceptor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDNIReceptor.Size = new System.Drawing.Size(178, 26);
            this.txtDNIReceptor.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(176, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 0);
            this.label9.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombre Receptor:";
            // 
            // lblReceptor
            // 
            this.lblReceptor.AutoSize = true;
            this.lblReceptor.Location = new System.Drawing.Point(26, 48);
            this.lblReceptor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceptor.Name = "lblReceptor";
            this.lblReceptor.Size = new System.Drawing.Size(111, 20);
            this.lblReceptor.TabIndex = 13;
            this.lblReceptor.Text = "DNI Receptor:";
            // 
            // grpEncomienda
            // 
            this.grpEncomienda.Controls.Add(this.label6);
            this.grpEncomienda.Controls.Add(this.label5);
            this.grpEncomienda.Controls.Add(this.label4);
            this.grpEncomienda.Controls.Add(this.label3);
            this.grpEncomienda.Controls.Add(this.label2);
            this.grpEncomienda.Controls.Add(this.lblTarifa);
            this.grpEncomienda.Controls.Add(this.lblEstado);
            this.grpEncomienda.Controls.Add(this.lblDestinatario);
            this.grpEncomienda.Controls.Add(this.lblRemitente);
            this.grpEncomienda.Controls.Add(this.lblGuia);
            this.grpEncomienda.Location = new System.Drawing.Point(9, 227);
            this.grpEncomienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEncomienda.Name = "grpEncomienda";
            this.grpEncomienda.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEncomienda.Size = new System.Drawing.Size(672, 246);
            this.grpEncomienda.TabIndex = 1;
            this.grpEncomienda.TabStop = false;
            this.grpEncomienda.Text = "Datos de la Encomienda";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(150, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(449, 33);
            this.label6.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(150, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(449, 33);
            this.label5.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(150, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(449, 33);
            this.label4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(150, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 33);
            this.label3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(150, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 33);
            this.label2.TabIndex = 8;
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(26, 205);
            this.lblTarifa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(53, 20);
            this.lblTarifa.TabIndex = 7;
            this.lblTarifa.Text = "Tarifa:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(26, 165);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(26, 123);
            this.lblDestinatario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(99, 20);
            this.lblDestinatario.TabIndex = 5;
            this.lblDestinatario.Text = "Destinatario:";
            // 
            // lblRemitente
            // 
            this.lblRemitente.AutoSize = true;
            this.lblRemitente.Location = new System.Drawing.Point(26, 82);
            this.lblRemitente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(87, 20);
            this.lblRemitente.TabIndex = 4;
            this.lblRemitente.Text = "Remitente:";
            // 
            // lblGuia
            // 
            this.lblGuia.AutoSize = true;
            this.lblGuia.Location = new System.Drawing.Point(26, 45);
            this.lblGuia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(67, 20);
            this.lblGuia.TabIndex = 3;
            this.lblGuia.Text = "N° Guia:";
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.lblError);
            this.grpBusqueda.Controls.Add(this.btnBuscar);
            this.grpBusqueda.Controls.Add(this.txtBusqueda);
            this.grpBusqueda.Controls.Add(this.label1);
            this.grpBusqueda.Location = new System.Drawing.Point(9, 51);
            this.grpBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBusqueda.Size = new System.Drawing.Size(672, 129);
            this.grpBusqueda.TabIndex = 1;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Buscar Encomienda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(450, 37);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Seleccionar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(150, 42);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusqueda.MaxLength = 20;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBusqueda.Size = new System.Drawing.Size(268, 26);
            this.txtBusqueda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Guia:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(46, 83);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(378, 20);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "No existe una Guía con ese N°. Intente nuevamente.";
            this.lblError.Visible = false;
            this.lblError.Click += new System.EventHandler(this.lblError_Click);
            // 
            // frmEntregaCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 731);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmEntregaCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEntregaCD";
            this.groupBox1.ResumeLayout(false);
            this.grpReceptor.ResumeLayout(false);
            this.grpReceptor.PerformLayout();
            this.grpEncomienda.ResumeLayout(false);
            this.grpEncomienda.PerformLayout();
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.GroupBox grpEncomienda;
        private System.Windows.Forms.GroupBox grpReceptor;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblReceptor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarEntrega;
        private System.Windows.Forms.TextBox txtNombreReceptor;
        private System.Windows.Forms.TextBox txtDNIReceptor;
        private System.Windows.Forms.Label lblError;
    }
}