namespace TUTASA.Forms.Agencia
{
    partial class frmEntregaAgencia
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpDatosguia = new System.Windows.Forms.GroupBox();
            this.lblNumeroguia = new System.Windows.Forms.Label();
            this.txtNumeroguia = new System.Windows.Forms.TextBox();
            this.lblRemitente = new System.Windows.Forms.Label();
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.grpReceptor = new System.Windows.Forms.GroupBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNIreceptor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombrereceptor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirmarentrega = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatosguia.SuspendLayout();
            this.grpReceptor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.14F);
            this.lblTitulo.Location = new System.Drawing.Point(250, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Entrega a Agencia ";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.Location = new System.Drawing.Point(50, 80);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(120, 20);
            this.lblBusqueda.TabIndex = 1;
            this.lblBusqueda.Text = "N° Guia o DNI";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(180, 80);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(200, 22);
            this.txtBusqueda.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(400, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 25);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // grpDatosguia
            // 
            this.grpDatosguia.Controls.Add(this.txtEstado);
            this.grpDatosguia.Controls.Add(this.lblEstado);
            this.grpDatosguia.Controls.Add(this.txtDestinatario);
            this.grpDatosguia.Controls.Add(this.lblDestinatario);
            this.grpDatosguia.Controls.Add(this.txtRemitente);
            this.grpDatosguia.Controls.Add(this.lblRemitente);
            this.grpDatosguia.Controls.Add(this.txtNumeroguia);
            this.grpDatosguia.Controls.Add(this.lblNumeroguia);
            this.grpDatosguia.Enabled = false;
            this.grpDatosguia.Location = new System.Drawing.Point(50, 120);
            this.grpDatosguia.Name = "grpDatosguia";
            this.grpDatosguia.Size = new System.Drawing.Size(700, 150);
            this.grpDatosguia.TabIndex = 4;
            this.grpDatosguia.TabStop = false;
            this.grpDatosguia.Text = "Datos de la encomienda";
            // 
            // lblNumeroguia
            // 
            this.lblNumeroguia.AutoSize = true;
            this.lblNumeroguia.Enabled = false;
            this.lblNumeroguia.Location = new System.Drawing.Point(20, 30);
            this.lblNumeroguia.Name = "lblNumeroguia";
            this.lblNumeroguia.Size = new System.Drawing.Size(52, 16);
            this.lblNumeroguia.TabIndex = 0;
            this.lblNumeroguia.Text = "N° Guia";
            // 
            // txtNumeroguia
            // 
            this.txtNumeroguia.Enabled = false;
            this.txtNumeroguia.Location = new System.Drawing.Point(120, 30);
            this.txtNumeroguia.Name = "txtNumeroguia";
            this.txtNumeroguia.Size = new System.Drawing.Size(150, 22);
            this.txtNumeroguia.TabIndex = 1;
            // 
            // lblRemitente
            // 
            this.lblRemitente.AutoSize = true;
            this.lblRemitente.Enabled = false;
            this.lblRemitente.Location = new System.Drawing.Point(20, 70);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(68, 16);
            this.lblRemitente.TabIndex = 2;
            this.lblRemitente.Text = "Remitente";
            // 
            // txtRemitente
            // 
            this.txtRemitente.Enabled = false;
            this.txtRemitente.Location = new System.Drawing.Point(120, 70);
            this.txtRemitente.Name = "txtRemitente";
            this.txtRemitente.Size = new System.Drawing.Size(150, 22);
            this.txtRemitente.TabIndex = 3;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Enabled = false;
            this.lblDestinatario.Location = new System.Drawing.Point(350, 30);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(79, 16);
            this.lblDestinatario.TabIndex = 4;
            this.lblDestinatario.Text = "Destinatario";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Enabled = false;
            this.txtDestinatario.Location = new System.Drawing.Point(460, 30);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(150, 22);
            this.txtDestinatario.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Enabled = false;
            this.lblEstado.Location = new System.Drawing.Point(350, 70);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 16);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(460, 70);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(150, 22);
            this.txtEstado.TabIndex = 6;
            // 
            // grpReceptor
            // 
            this.grpReceptor.Controls.Add(this.button1);
            this.grpReceptor.Controls.Add(this.txtNombrereceptor);
            this.grpReceptor.Controls.Add(this.lblNombre);
            this.grpReceptor.Controls.Add(this.txtDNIreceptor);
            this.grpReceptor.Controls.Add(this.lblDNI);
            this.grpReceptor.Location = new System.Drawing.Point(50, 290);
            this.grpReceptor.Name = "grpReceptor";
            this.grpReceptor.Size = new System.Drawing.Size(700, 120);
            this.grpReceptor.TabIndex = 5;
            this.grpReceptor.TabStop = false;
            this.grpReceptor.Text = "Datos del receptor";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(20, 40);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(30, 16);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI";
            // 
            // txtDNIreceptor
            // 
            this.txtDNIreceptor.Location = new System.Drawing.Point(120, 40);
            this.txtDNIreceptor.Name = "txtDNIreceptor";
            this.txtDNIreceptor.Size = new System.Drawing.Size(150, 22);
            this.txtDNIreceptor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(350, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombrereceptor
            // 
            this.txtNombrereceptor.Location = new System.Drawing.Point(460, 40);
            this.txtNombrereceptor.Name = "txtNombrereceptor";
            this.txtNombrereceptor.Size = new System.Drawing.Size(150, 22);
            this.txtNombrereceptor.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarentrega
            // 
            this.btnConfirmarentrega.Location = new System.Drawing.Point(450, 450);
            this.btnConfirmarentrega.Name = "btnConfirmarentrega";
            this.btnConfirmarentrega.Size = new System.Drawing.Size(120, 40);
            this.btnConfirmarentrega.TabIndex = 7;
            this.btnConfirmarentrega.Text = "Confirmar Entrega";
            this.btnConfirmarentrega.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(610, 450);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar Entrega";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmEntregaAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarentrega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpReceptor);
            this.Controls.Add(this.grpDatosguia);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.Enabled = false;
            this.Name = "frmEntregaAgencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrega en Agencia";
            this.Load += new System.EventHandler(this.frmEntregaAgencia_Load);
            this.grpDatosguia.ResumeLayout(false);
            this.grpDatosguia.PerformLayout();
            this.grpReceptor.ResumeLayout(false);
            this.grpReceptor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grpDatosguia;
        private System.Windows.Forms.Label lblNumeroguia;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.TextBox txtRemitente;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.TextBox txtNumeroguia;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox grpReceptor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombrereceptor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDNIreceptor;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarentrega;
        private System.Windows.Forms.Button btnCancelar;
    }
}