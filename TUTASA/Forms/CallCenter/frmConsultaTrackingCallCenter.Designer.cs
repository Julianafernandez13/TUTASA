namespace TUTASA.Forms.CallCenter
{
    partial class frmConsultaTrackingCallCenter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroGuia = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.grpEstado = new System.Windows.Forms.GroupBox();
            this.lblEstadoActual = new System.Windows.Forms.Label();
            this.lblEstadoTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaUltimo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.grpEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleName = "grpBusqueda";
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtNroGuia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de guia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° de guía (tracking ID):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNroGuia
            // 
            this.txtNroGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroGuia.Location = new System.Drawing.Point(213, 29);
            this.txtNroGuia.MaxLength = 20;
            this.txtNroGuia.Name = "txtNroGuia";
            this.txtNroGuia.Size = new System.Drawing.Size(313, 28);
            this.txtNroGuia.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(532, 28);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(113, 31);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(651, 29);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 31);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pnlResultado
            // 
            this.pnlResultado.Controls.Add(this.grpEstado);
            this.pnlResultado.Location = new System.Drawing.Point(15, 100);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(860, 536);
            this.pnlResultado.TabIndex = 1;
            this.pnlResultado.Visible = false;
            // 
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.lblFechaUltimo);
            this.grpEstado.Controls.Add(this.label2);
            this.grpEstado.Controls.Add(this.lblEstadoTitulo);
            this.grpEstado.Controls.Add(this.lblEstadoActual);
            this.grpEstado.Location = new System.Drawing.Point(3, 3);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Size = new System.Drawing.Size(804, 133);
            this.grpEstado.TabIndex = 0;
            this.grpEstado.TabStop = false;
            this.grpEstado.Text = "Estado actual de la guía";
            this.grpEstado.Enter += new System.EventHandler(this.grpEstado_Enter);
            // 
            // lblEstadoActual
            // 
            this.lblEstadoActual.BackColor = System.Drawing.Color.LightGreen;
            this.lblEstadoActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstadoActual.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoActual.Location = new System.Drawing.Point(85, 28);
            this.lblEstadoActual.Name = "lblEstadoActual";
            this.lblEstadoActual.Size = new System.Drawing.Size(225, 33);
            this.lblEstadoActual.TabIndex = 0;
            this.lblEstadoActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstadoActual.Click += new System.EventHandler(this.lblEstadoActual_Click);
            // 
            // lblEstadoTitulo
            // 
            this.lblEstadoTitulo.AutoSize = true;
            this.lblEstadoTitulo.Location = new System.Drawing.Point(13, 28);
            this.lblEstadoTitulo.Name = "lblEstadoTitulo";
            this.lblEstadoTitulo.Size = new System.Drawing.Size(66, 20);
            this.lblEstadoTitulo.TabIndex = 1;
            this.lblEstadoTitulo.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Actualizado:";
            // 
            // lblFechaUltimo
            // 
            this.lblFechaUltimo.AutoSize = true;
            this.lblFechaUltimo.Location = new System.Drawing.Point(413, 28);
            this.lblFechaUltimo.Name = "lblFechaUltimo";
            this.lblFechaUltimo.Size = new System.Drawing.Size(0, 20);
            this.lblFechaUltimo.TabIndex = 3;
            // 
            // frmConsultaTrackingCallCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 522);
            this.Controls.Add(this.pnlResultado);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "frmConsultaTrackingCallCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA - Consultar estado e historial de guia";
            this.Load += new System.EventHandler(this.frmConsultaTrackingCallCenter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlResultado.ResumeLayout(false);
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroGuia;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.Label lblEstadoActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.Label lblFechaUltimo;
    }
}