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
            this.txtDNIReceptor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblReceptor = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.grpReceptor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnConfirmarEntrega);
            this.groupBox1.Controls.Add(this.grpReceptor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TUTASA - Registrar Entrega en CD";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(241, 418);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarEntrega
            // 
            this.btnConfirmarEntrega.Location = new System.Drawing.Point(106, 418);
            this.btnConfirmarEntrega.Name = "btnConfirmarEntrega";
            this.btnConfirmarEntrega.Size = new System.Drawing.Size(130, 30);
            this.btnConfirmarEntrega.TabIndex = 3;
            this.btnConfirmarEntrega.Text = "Confirmar Entrega";
            this.btnConfirmarEntrega.UseVisualStyleBackColor = true;
            // 
            // grpReceptor
            // 
            this.grpReceptor.Controls.Add(this.txtDNIReceptor);
            this.grpReceptor.Controls.Add(this.label9);
            this.grpReceptor.Controls.Add(this.lblReceptor);
            this.grpReceptor.Location = new System.Drawing.Point(12, 33);
            this.grpReceptor.Name = "grpReceptor";
            this.grpReceptor.Size = new System.Drawing.Size(448, 71);
            this.grpReceptor.TabIndex = 2;
            this.grpReceptor.TabStop = false;
            this.grpReceptor.Text = "Datos del Receptor";
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
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(117, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1, 1);
            this.label9.TabIndex = 15;
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(46, 121);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(366, 204);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmEntregaCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 475);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmEntregaCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEntregaCD";
            this.groupBox1.ResumeLayout(false);
            this.grpReceptor.ResumeLayout(false);
            this.grpReceptor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpReceptor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblReceptor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarEntrega;
        private System.Windows.Forms.TextBox txtDNIReceptor;
        private System.Windows.Forms.ListView listView1;
    }
}