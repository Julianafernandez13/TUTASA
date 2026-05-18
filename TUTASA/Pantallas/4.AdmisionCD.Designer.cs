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
            this.button2 = new System.Windows.Forms.Button();
            this.grpEncomienda.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFletero
            // 
            this.txtFletero.Location = new System.Drawing.Point(374, 32);
            this.txtFletero.Name = "txtFletero";
            this.txtFletero.Size = new System.Drawing.Size(198, 26);
            this.txtFletero.TabIndex = 0;
            // 
            // lblBuscarNrodeGuia
            // 
            this.lblBuscarNrodeGuia.AutoSize = true;
            this.lblBuscarNrodeGuia.Location = new System.Drawing.Point(198, 35);
            this.lblBuscarNrodeGuia.Name = "lblBuscarNrodeGuia";
            this.lblBuscarNrodeGuia.Size = new System.Drawing.Size(125, 20);
            this.lblBuscarNrodeGuia.TabIndex = 0;
            this.lblBuscarNrodeGuia.Text = "Número de guía:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(398, 111);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 31);
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
            this.cmbCategoria.Location = new System.Drawing.Point(669, 43);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(80, 28);
            this.cmbCategoria.TabIndex = 7;
            // 
            // lblCategoriaLabel
            // 
            this.lblCategoriaLabel.AutoSize = true;
            this.lblCategoriaLabel.Location = new System.Drawing.Point(510, 46);
            this.lblCategoriaLabel.Name = "lblCategoriaLabel";
            this.lblCategoriaLabel.Size = new System.Drawing.Size(153, 20);
            this.lblCategoriaLabel.TabIndex = 3;
            this.lblCategoriaLabel.Text = "Categoría verificada:";
            this.lblCategoriaLabel.Click += new System.EventHandler(this.lblCategoriaLabel_Click);
            // 
            // lblNroGuiaLabel
            // 
            this.lblNroGuiaLabel.AutoSize = true;
            this.lblNroGuiaLabel.Location = new System.Drawing.Point(93, 44);
            this.lblNroGuiaLabel.Name = "lblNroGuiaLabel";
            this.lblNroGuiaLabel.Size = new System.Drawing.Size(125, 20);
            this.lblNroGuiaLabel.TabIndex = 0;
            this.lblNroGuiaLabel.Text = "Número de guía:";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(224, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 22);
            this.label15.TabIndex = 15;
            // 
            // grpEncomienda
            // 
            this.grpEncomienda.Controls.Add(this.label15);
            this.grpEncomienda.Controls.Add(this.lblNroGuiaLabel);
            this.grpEncomienda.Controls.Add(this.lblCategoriaLabel);
            this.grpEncomienda.Controls.Add(this.cmbCategoria);
            this.grpEncomienda.Controls.Add(this.btnRegistrar);
            this.grpEncomienda.Location = new System.Drawing.Point(16, 111);
            this.grpEncomienda.Name = "grpEncomienda";
            this.grpEncomienda.Size = new System.Drawing.Size(920, 165);
            this.grpEncomienda.TabIndex = 1;
            this.grpEncomienda.TabStop = false;
            this.grpEncomienda.Text = "Admision ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmAdmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(958, 371);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFletero);
            this.Controls.Add(this.lblBuscarNrodeGuia);
            this.Controls.Add(this.grpEncomienda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Button button2;
    }
}