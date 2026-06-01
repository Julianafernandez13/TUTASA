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
            this.txtNroDeGuia.Location = new System.Drawing.Point(374, 32);
            this.txtNroDeGuia.Name = "txtNroDeGuia";
            this.txtNroDeGuia.Size = new System.Drawing.Size(198, 26);
            this.txtNroDeGuia.TabIndex = 0;
            this.txtNroDeGuia.TextChanged += new System.EventHandler(this.txtNroDeGuia_TextChanged);
            // 
            // lblBuscarNrodeGuia
            // 
            this.lblBuscarNrodeGuia.AutoSize = true;
            this.lblBuscarNrodeGuia.Location = new System.Drawing.Point(198, 35);
            this.lblBuscarNrodeGuia.Name = "lblBuscarNrodeGuia";
            this.lblBuscarNrodeGuia.Size = new System.Drawing.Size(125, 20);
            this.lblBuscarNrodeGuia.TabIndex = 0;
            this.lblBuscarNrodeGuia.Text = "Número de guía:";
            this.lblBuscarNrodeGuia.Click += new System.EventHandler(this.lblBuscarNrodeGuia_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(636, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 31);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAdmitir
            // 
            this.btnAdmitir.Location = new System.Drawing.Point(398, 111);
            this.btnAdmitir.Name = "btnAdmitir";
            this.btnAdmitir.Size = new System.Drawing.Size(120, 31);
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
            this.cmbCategoria.Location = new System.Drawing.Point(669, 43);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(80, 28);
            this.cmbCategoria.TabIndex = 7;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
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
            this.lblNroGuiaLabel.Click += new System.EventHandler(this.lblNroGuiaLabel_Click);
            // 
            // labelNrodeGuia
            // 
            this.labelNrodeGuia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelNrodeGuia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNrodeGuia.Location = new System.Drawing.Point(224, 43);
            this.labelNrodeGuia.Name = "labelNrodeGuia";
            this.labelNrodeGuia.Size = new System.Drawing.Size(167, 22);
            this.labelNrodeGuia.TabIndex = 15;
            this.labelNrodeGuia.Click += new System.EventHandler(this.labelNrodeGuia_Click);
            // 
            // grpAdmision
            // 
            this.grpAdmision.Controls.Add(this.labelNrodeGuia);
            this.grpAdmision.Controls.Add(this.lblNroGuiaLabel);
            this.grpAdmision.Controls.Add(this.lblCategoriaLabel);
            this.grpAdmision.Controls.Add(this.cmbCategoria);
            this.grpAdmision.Controls.Add(this.btnAdmitir);
            this.grpAdmision.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpAdmision.Location = new System.Drawing.Point(16, 111);
            this.grpAdmision.Name = "grpAdmision";
            this.grpAdmision.Size = new System.Drawing.Size(920, 165);
            this.grpAdmision.TabIndex = 1;
            this.grpAdmision.TabStop = false;
            this.grpAdmision.Text = "Admision ";
            this.grpAdmision.Enter += new System.EventHandler(this.grpAdmision_Enter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(816, 328);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 31);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAdmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(958, 371);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNroDeGuia);
            this.Controls.Add(this.lblBuscarNrodeGuia);
            this.Controls.Add(this.grpAdmision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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