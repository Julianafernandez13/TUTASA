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
            this.txtFletero = new System.Windows.Forms.TextBox();
            this.lblBuscarNrodeGuia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoriaLabel = new System.Windows.Forms.Label();
            this.lblNroGuiaLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.grpEncomienda = new System.Windows.Forms.GroupBox();
            this.grpEncomienda.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFletero
            // 
            this.txtFletero.Location = new System.Drawing.Point(139, 21);
            this.txtFletero.Margin = new System.Windows.Forms.Padding(2);
            this.txtFletero.Name = "txtFletero";
            this.txtFletero.Size = new System.Drawing.Size(133, 20);
            this.txtFletero.TabIndex = 0;
            // 
            // lblBuscarNrodeGuia
            // 
            this.lblBuscarNrodeGuia.AutoSize = true;
            this.lblBuscarNrodeGuia.Location = new System.Drawing.Point(34, 21);
            this.lblBuscarNrodeGuia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarNrodeGuia.Name = "lblBuscarNrodeGuia";
            this.lblBuscarNrodeGuia.Size = new System.Drawing.Size(82, 13);
            this.lblBuscarNrodeGuia.TabIndex = 0;
            this.lblBuscarNrodeGuia.Text = "Numero de guia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 20);
            this.button1.TabIndex = 20;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(265, 72);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(80, 20);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Admitir";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cmbCategoria.Location = new System.Drawing.Point(453, 16);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(55, 21);
            this.cmbCategoria.TabIndex = 7;
            // 
            // lblCategoriaLabel
            // 
            this.lblCategoriaLabel.AutoSize = true;
            this.lblCategoriaLabel.Location = new System.Drawing.Point(342, 19);
            this.lblCategoriaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoriaLabel.Name = "lblCategoriaLabel";
            this.lblCategoriaLabel.Size = new System.Drawing.Size(106, 13);
            this.lblCategoriaLabel.TabIndex = 3;
            this.lblCategoriaLabel.Text = "Categoría verificada:";
            this.lblCategoriaLabel.Click += new System.EventHandler(this.lblCategoriaLabel_Click);
            // 
            // lblNroGuiaLabel
            // 
            this.lblNroGuiaLabel.AutoSize = true;
            this.lblNroGuiaLabel.Location = new System.Drawing.Point(89, 19);
            this.lblNroGuiaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroGuiaLabel.Name = "lblNroGuiaLabel";
            this.lblNroGuiaLabel.Size = new System.Drawing.Size(62, 13);
            this.lblNroGuiaLabel.TabIndex = 0;
            this.lblNroGuiaLabel.Text = "N° de guía:";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(149, 18);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 15);
            this.label15.TabIndex = 15;
            // 
            // grpEncomienda
            // 
            this.grpEncomienda.Controls.Add(this.label15);
            this.grpEncomienda.Controls.Add(this.lblNroGuiaLabel);
            this.grpEncomienda.Controls.Add(this.lblCategoriaLabel);
            this.grpEncomienda.Controls.Add(this.cmbCategoria);
            this.grpEncomienda.Controls.Add(this.btnRegistrar);
            this.grpEncomienda.Location = new System.Drawing.Point(11, 72);
            this.grpEncomienda.Margin = new System.Windows.Forms.Padding(2);
            this.grpEncomienda.Name = "grpEncomienda";
            this.grpEncomienda.Padding = new System.Windows.Forms.Padding(2);
            this.grpEncomienda.Size = new System.Drawing.Size(613, 107);
            this.grpEncomienda.TabIndex = 1;
            this.grpEncomienda.TabStop = false;
            this.grpEncomienda.Text = "Admision ";
            // 
            // frmAdmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(639, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFletero);
            this.Controls.Add(this.lblBuscarNrodeGuia);
            this.Controls.Add(this.grpEncomienda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmAdmision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA — Registrar admisión de encomiendas";
            this.grpEncomienda.ResumeLayout(false);
            this.grpEncomienda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox txtFletero;
        private System.Windows.Forms.Label lblBuscarNrodeGuia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoriaLabel;
        private System.Windows.Forms.Label lblNroGuiaLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grpEncomienda;
    }
}