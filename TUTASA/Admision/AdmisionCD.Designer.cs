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
            this.txtNroDeGuia = new System.Windows.Forms.TextBox();
            this.lblBuscarNrodeGuia = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAdmitir = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoriaLabel = new System.Windows.Forms.Label();
            this.lblNroGuiaLabel = new System.Windows.Forms.Label();
            this.labelNrodeGuia = new System.Windows.Forms.Label();
            this.grpAdmision = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpAdmision.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNroDeGuia
            // 
            this.txtNroDeGuia.Location = new System.Drawing.Point(249, 21);
            this.txtNroDeGuia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNroDeGuia.Name = "txtNroDeGuia";
            this.txtNroDeGuia.Size = new System.Drawing.Size(133, 20);
            this.txtNroDeGuia.TabIndex = 0;
            // 
            // lblBuscarNrodeGuia
            // 
            this.lblBuscarNrodeGuia.AutoSize = true;
            this.lblBuscarNrodeGuia.Location = new System.Drawing.Point(132, 23);
            this.lblBuscarNrodeGuia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarNrodeGuia.Name = "lblBuscarNrodeGuia";
            this.lblBuscarNrodeGuia.Size = new System.Drawing.Size(87, 13);
            this.lblBuscarNrodeGuia.TabIndex = 0;
            this.lblBuscarNrodeGuia.Text = "Número de guía:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(424, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 20);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAdmitir
            // 
            this.btnAdmitir.Location = new System.Drawing.Point(265, 72);
            this.btnAdmitir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdmitir.Name = "btnAdmitir";
            this.btnAdmitir.Size = new System.Drawing.Size(80, 20);
            this.btnAdmitir.TabIndex = 6;
            this.btnAdmitir.Text = "Admitir";
            this.btnAdmitir.UseVisualStyleBackColor = true;
            this.btnAdmitir.Click += new System.EventHandler(this.btnAdmitir_Click);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cmbCategoria.Location = new System.Drawing.Point(446, 28);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(55, 21);
            this.cmbCategoria.TabIndex = 7;
            // 
            // lblCategoriaLabel
            // 
            this.lblCategoriaLabel.AutoSize = true;
            this.lblCategoriaLabel.Location = new System.Drawing.Point(340, 30);
            this.lblCategoriaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoriaLabel.Name = "lblCategoriaLabel";
            this.lblCategoriaLabel.Size = new System.Drawing.Size(106, 13);
            this.lblCategoriaLabel.TabIndex = 3;
            this.lblCategoriaLabel.Text = "Categoría verificada:";
            // 
            // lblNroGuiaLabel
            // 
            this.lblNroGuiaLabel.AutoSize = true;
            this.lblNroGuiaLabel.Location = new System.Drawing.Point(62, 29);
            this.lblNroGuiaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroGuiaLabel.Name = "lblNroGuiaLabel";
            this.lblNroGuiaLabel.Size = new System.Drawing.Size(87, 13);
            this.lblNroGuiaLabel.TabIndex = 0;
            this.lblNroGuiaLabel.Text = "Número de guía:";
            // 
            // labelNrodeGuia
            // 
            this.labelNrodeGuia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelNrodeGuia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNrodeGuia.Location = new System.Drawing.Point(149, 28);
            this.labelNrodeGuia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNrodeGuia.Name = "labelNrodeGuia";
            this.labelNrodeGuia.Size = new System.Drawing.Size(112, 15);
            this.labelNrodeGuia.TabIndex = 15;
            // 
            // grpAdmision
            // 
            this.grpAdmision.Controls.Add(this.labelNrodeGuia);
            this.grpAdmision.Controls.Add(this.lblNroGuiaLabel);
            this.grpAdmision.Controls.Add(this.lblCategoriaLabel);
            this.grpAdmision.Controls.Add(this.cmbCategoria);
            this.grpAdmision.Controls.Add(this.btnAdmitir);
            this.grpAdmision.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpAdmision.Location = new System.Drawing.Point(11, 72);
            this.grpAdmision.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAdmision.Name = "grpAdmision";
            this.grpAdmision.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAdmision.Size = new System.Drawing.Size(613, 107);
            this.grpAdmision.TabIndex = 1;
            this.grpAdmision.TabStop = false;
            this.grpAdmision.Text = "Admision ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(544, 213);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 20);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAdmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(639, 241);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNroDeGuia);
            this.Controls.Add(this.lblBuscarNrodeGuia);
            this.Controls.Add(this.grpAdmision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmAdmision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA — Registrar admisión de encomiendas";
            this.Load += new System.EventHandler(this.frmAdmision_Load);
            this.grpAdmision.ResumeLayout(false);
            this.grpAdmision.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox txtNroDeGuia;
        private System.Windows.Forms.Label lblBuscarNrodeGuia;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAdmitir;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoriaLabel;
        private System.Windows.Forms.Label lblNroGuiaLabel;
        private System.Windows.Forms.Label labelNrodeGuia;
        private System.Windows.Forms.GroupBox grpAdmision;
        private System.Windows.Forms.Button btnCancelar;
    }
}