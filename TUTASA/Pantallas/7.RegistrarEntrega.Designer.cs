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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarEntrega = new System.Windows.Forms.Button();
            this.grpReceptor = new System.Windows.Forms.GroupBox();
            this.txtDNIReceptor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblReceptor = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpReceptor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnConfirmarEntrega);
            this.groupBox1.Controls.Add(this.grpReceptor);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(690, 647);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TUTASA - Registrar Entrega en CD";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(18, 226);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(664, 312);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(547, 591);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 46);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarEntrega
            // 
            this.btnConfirmarEntrega.Location = new System.Drawing.Point(323, 591);
            this.btnConfirmarEntrega.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmarEntrega.Name = "btnConfirmarEntrega";
            this.btnConfirmarEntrega.Size = new System.Drawing.Size(195, 46);
            this.btnConfirmarEntrega.TabIndex = 3;
            this.btnConfirmarEntrega.Text = "Confirmar Entrega";
            this.btnConfirmarEntrega.UseVisualStyleBackColor = true;
            // 
            // grpReceptor
            // 
            this.grpReceptor.Controls.Add(this.button1);
            this.grpReceptor.Controls.Add(this.txtDNIReceptor);
            this.grpReceptor.Controls.Add(this.label9);
            this.grpReceptor.Controls.Add(this.lblReceptor);
            this.grpReceptor.Location = new System.Drawing.Point(18, 51);
            this.grpReceptor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpReceptor.Name = "grpReceptor";
            this.grpReceptor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpReceptor.Size = new System.Drawing.Size(664, 109);
            this.grpReceptor.TabIndex = 2;
            this.grpReceptor.TabStop = false;
            this.grpReceptor.Text = "Datos del Receptor";
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "N° de Guía";
            this.columnHeader1.Width = 144;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cliente";
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre del Receptor";
            this.columnHeader3.Width = 166;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DNI del Receptor";
            this.columnHeader4.Width = 257;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 46);
            this.button1.TabIndex = 17;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Encomiendas a entregar:";
            // 
            // frmEntregaCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 679);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmEntregaCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Entrega";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}