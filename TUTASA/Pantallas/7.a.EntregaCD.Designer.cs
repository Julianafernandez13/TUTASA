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
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.grpEncomienda = new System.Windows.Forms.GroupBox();
            this.grpReceptor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblGuia = new System.Windows.Forms.Label();
            this.lblRemitente = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblReceptor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDNIReceptor = new System.Windows.Forms.TextBox();
            this.txtNombreReceptor = new System.Windows.Forms.TextBox();
            this.btnConfirmarEntrega = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpBusqueda.SuspendLayout();
            this.grpEncomienda.SuspendLayout();
            this.grpReceptor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnConfirmarEntrega);
            this.groupBox1.Controls.Add(this.grpReceptor);
            this.groupBox1.Controls.Add(this.grpEncomienda);
            this.groupBox1.Controls.Add(this.grpBusqueda);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TUTASA - Registrar Entrega en CD";
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.btnBuscar);
            this.grpBusqueda.Controls.Add(this.txtBusqueda);
            this.grpBusqueda.Controls.Add(this.label1);
            this.grpBusqueda.Location = new System.Drawing.Point(6, 33);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(448, 60);
            this.grpBusqueda.TabIndex = 1;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Buscar Encomienda";
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
            this.grpEncomienda.Location = new System.Drawing.Point(6, 99);
            this.grpEncomienda.Name = "grpEncomienda";
            this.grpEncomienda.Size = new System.Drawing.Size(448, 160);
            this.grpEncomienda.TabIndex = 1;
            this.grpEncomienda.TabStop = false;
            this.grpEncomienda.Text = "Datos de la Encomienda";
            // 
            // grpReceptor
            // 
            this.grpReceptor.Controls.Add(this.txtNombreReceptor);
            this.grpReceptor.Controls.Add(this.txtDNIReceptor);
            this.grpReceptor.Controls.Add(this.label9);
            this.grpReceptor.Controls.Add(this.label8);
            this.grpReceptor.Controls.Add(this.lblReceptor);
            this.grpReceptor.Location = new System.Drawing.Point(6, 265);
            this.grpReceptor.Name = "grpReceptor";
            this.grpReceptor.Size = new System.Drawing.Size(448, 90);
            this.grpReceptor.TabIndex = 2;
            this.grpReceptor.TabStop = false;
            this.grpReceptor.Text = "Datos del Receptor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Guia / DNI:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(100, 27);
            this.txtBusqueda.MaxLength = 20;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBusqueda.Size = new System.Drawing.Size(180, 20);
            this.txtBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(300, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblGuia
            // 
            this.lblGuia.AutoSize = true;
            this.lblGuia.Location = new System.Drawing.Point(17, 29);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(47, 13);
            this.lblGuia.TabIndex = 3;
            this.lblGuia.Text = "N° Guia:";
            // 
            // lblRemitente
            // 
            this.lblRemitente.AutoSize = true;
            this.lblRemitente.Location = new System.Drawing.Point(17, 53);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(58, 13);
            this.lblRemitente.TabIndex = 4;
            this.lblRemitente.Text = "Remitente:";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(17, 80);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(66, 13);
            this.lblDestinatario.TabIndex = 5;
            this.lblDestinatario.Text = "Destinatario:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(17, 107);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Location = new System.Drawing.Point(17, 133);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(37, 13);
            this.lblTarifa.TabIndex = 7;
            this.lblTarifa.Text = "Tarifa:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(100, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 22);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(100, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 22);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(100, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 22);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(100, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 22);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(100, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 22);
            this.label6.TabIndex = 12;
            // 
            // lblReceptor
            // 
            this.lblReceptor.AutoSize = true;
            this.lblReceptor.Location = new System.Drawing.Point(17, 31);
            this.lblReceptor.Name = "lblReceptor";
            this.lblReceptor.Size = new System.Drawing.Size(76, 13);
            this.lblReceptor.TabIndex = 13;
            this.lblReceptor.Text = "DNI Receptor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombre Receptor:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(117, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 0);
            this.label9.TabIndex = 15;
            // 
            // txtDNIReceptor
            // 
            this.txtDNIReceptor.Location = new System.Drawing.Point(117, 28);
            this.txtDNIReceptor.MaxLength = 8;
            this.txtDNIReceptor.Name = "txtDNIReceptor";
            this.txtDNIReceptor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDNIReceptor.Size = new System.Drawing.Size(120, 20);
            this.txtDNIReceptor.TabIndex = 16;
            // 
            // txtNombreReceptor
            // 
            this.txtNombreReceptor.Location = new System.Drawing.Point(117, 54);
            this.txtNombreReceptor.MaxLength = 100;
            this.txtNombreReceptor.Name = "txtNombreReceptor";
            this.txtNombreReceptor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNombreReceptor.Size = new System.Drawing.Size(280, 20);
            this.txtNombreReceptor.TabIndex = 17;
            // 
            // btnConfirmarEntrega
            // 
            this.btnConfirmarEntrega.Location = new System.Drawing.Point(107, 380);
            this.btnConfirmarEntrega.Name = "btnConfirmarEntrega";
            this.btnConfirmarEntrega.Size = new System.Drawing.Size(130, 30);
            this.btnConfirmarEntrega.TabIndex = 3;
            this.btnConfirmarEntrega.Text = "Confirmar Entrega";
            this.btnConfirmarEntrega.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(243, 380);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmEntregaCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 441);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmEntregaCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEntregaCD";
            this.groupBox1.ResumeLayout(false);
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.grpEncomienda.ResumeLayout(false);
            this.grpEncomienda.PerformLayout();
            this.grpReceptor.ResumeLayout(false);
            this.grpReceptor.PerformLayout();
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
    }
}