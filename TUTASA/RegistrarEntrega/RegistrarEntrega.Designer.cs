namespace TUTASA.Forms.CD
{
    partial class frmEntrega
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
            this.groupRegistrarEntrega = new System.Windows.Forms.GroupBox();
            this.lblEncomiendasEntregar = new System.Windows.Forms.Label();
            this.listViewEncomiendas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmarEntrega = new System.Windows.Forms.Button();
            this.groupReceptor = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDNIReceptor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDNIReceptor = new System.Windows.Forms.Label();
            this.groupRegistrarEntrega.SuspendLayout();
            this.groupReceptor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupRegistrarEntrega
            // 
            this.groupRegistrarEntrega.Controls.Add(this.lblEncomiendasEntregar);
            this.groupRegistrarEntrega.Controls.Add(this.listViewEncomiendas);
            this.groupRegistrarEntrega.Controls.Add(this.btnCancelar);
            this.groupRegistrarEntrega.Controls.Add(this.btnConfirmarEntrega);
            this.groupRegistrarEntrega.Controls.Add(this.groupReceptor);
            this.groupRegistrarEntrega.Location = new System.Drawing.Point(18, 18);
            this.groupRegistrarEntrega.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupRegistrarEntrega.Name = "groupRegistrarEntrega";
            this.groupRegistrarEntrega.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupRegistrarEntrega.Size = new System.Drawing.Size(690, 648);
            this.groupRegistrarEntrega.TabIndex = 0;
            this.groupRegistrarEntrega.TabStop = false;
            this.groupRegistrarEntrega.Text = "TUTASA - Registrar Entrega";
            // 
            // lblEncomiendasEntregar
            // 
            this.lblEncomiendasEntregar.AutoSize = true;
            this.lblEncomiendasEntregar.Location = new System.Drawing.Point(21, 201);
            this.lblEncomiendasEntregar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncomiendasEntregar.Name = "lblEncomiendasEntregar";
            this.lblEncomiendasEntregar.Size = new System.Drawing.Size(187, 20);
            this.lblEncomiendasEntregar.TabIndex = 14;
            this.lblEncomiendasEntregar.Text = "Encomiendas a entregar:";
            // 
            // listViewEncomiendas
            // 
            this.listViewEncomiendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewEncomiendas.HideSelection = false;
            this.listViewEncomiendas.Location = new System.Drawing.Point(18, 226);
            this.listViewEncomiendas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewEncomiendas.Name = "listViewEncomiendas";
            this.listViewEncomiendas.Size = new System.Drawing.Size(664, 312);
            this.listViewEncomiendas.TabIndex = 5;
            this.listViewEncomiendas.UseCompatibleStateImageBehavior = false;
            this.listViewEncomiendas.View = System.Windows.Forms.View.Details;
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
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(547, 591);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 46);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnConfirmarEntrega.Click += new System.EventHandler(this.btnConfirmarEntrega_Click);
            // 
            // groupReceptor
            // 
            this.groupReceptor.Controls.Add(this.btnBuscar);
            this.groupReceptor.Controls.Add(this.txtDNIReceptor);
            this.groupReceptor.Controls.Add(this.label9);
            this.groupReceptor.Controls.Add(this.lblDNIReceptor);
            this.groupReceptor.Location = new System.Drawing.Point(18, 51);
            this.groupReceptor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupReceptor.Name = "groupReceptor";
            this.groupReceptor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupReceptor.Size = new System.Drawing.Size(664, 109);
            this.groupReceptor.TabIndex = 2;
            this.groupReceptor.TabStop = false;
            this.groupReceptor.Text = "Datos del Receptor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(440, 35);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 46);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDNIReceptor
            // 
            this.txtDNIReceptor.Location = new System.Drawing.Point(176, 42);
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
            // lblDNIReceptor
            // 
            this.lblDNIReceptor.AutoSize = true;
            this.lblDNIReceptor.Location = new System.Drawing.Point(26, 48);
            this.lblDNIReceptor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNIReceptor.Name = "lblDNIReceptor";
            this.lblDNIReceptor.Size = new System.Drawing.Size(111, 20);
            this.lblDNIReceptor.TabIndex = 13;
            this.lblDNIReceptor.Text = "DNI Receptor:";
            // 
            // frmEntregaCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 679);
            this.Controls.Add(this.groupRegistrarEntrega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmEntregaCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Entrega";
            this.Load += new System.EventHandler(this.frmEntregaCD_Load);
            this.groupRegistrarEntrega.ResumeLayout(false);
            this.groupRegistrarEntrega.PerformLayout();
            this.groupReceptor.ResumeLayout(false);
            this.groupReceptor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupRegistrarEntrega;
        private System.Windows.Forms.GroupBox groupReceptor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDNIReceptor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmarEntrega;
        private System.Windows.Forms.TextBox txtDNIReceptor;
        private System.Windows.Forms.ListView listViewEncomiendas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEncomiendasEntregar;
    }
}