namespace TUTASA.Forms.CD
{
    partial class btnBuscar
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
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbDatosHdr = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblCantBultos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFechaDesp = new System.Windows.Forms.Label();
            this.txtCdOrigen = new System.Windows.Forms.TextBox();
            this.lblCdOrigen = new System.Windows.Forms.Label();
            this.gbGuias = new System.Windows.Forms.GroupBox();
            this.lvGuias = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbBusqueda.SuspendLayout();
            this.gbDatosHdr.SuspendLayout();
            this.gbGuias.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.label1);
            this.gbBusqueda.Controls.Add(this.comboBox5);
            this.gbBusqueda.Controls.Add(this.button1);
            this.gbBusqueda.Location = new System.Drawing.Point(13, 12);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBusqueda.Size = new System.Drawing.Size(779, 86);
            this.gbBusqueda.TabIndex = 0;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda de servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Empresa de Transporte:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(369, 38);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(149, 24);
            this.comboBox5.TabIndex = 11;
            this.comboBox5.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbDatosHdr
            // 
            this.gbDatosHdr.Controls.Add(this.comboBox1);
            this.gbDatosHdr.Controls.Add(this.label2);
            this.gbDatosHdr.Controls.Add(this.textBox2);
            this.gbDatosHdr.Controls.Add(this.lblCantBultos);
            this.gbDatosHdr.Controls.Add(this.textBox1);
            this.gbDatosHdr.Controls.Add(this.lblFechaDesp);
            this.gbDatosHdr.Controls.Add(this.txtCdOrigen);
            this.gbDatosHdr.Controls.Add(this.lblCdOrigen);
            this.gbDatosHdr.Location = new System.Drawing.Point(13, 106);
            this.gbDatosHdr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatosHdr.Name = "gbDatosHdr";
            this.gbDatosHdr.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDatosHdr.Size = new System.Drawing.Size(779, 154);
            this.gbDatosHdr.TabIndex = 1;
            this.gbDatosHdr.TabStop = false;
            this.gbDatosHdr.Text = "Datos de la HDR:";
            this.gbDatosHdr.Enter += new System.EventHandler(this.gbDatosHdr_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(369, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selecciona N° de HDR:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(224, 119);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(65, 22);
            this.textBox2.TabIndex = 7;
            // 
            // lblCantBultos
            // 
            this.lblCantBultos.AutoSize = true;
            this.lblCantBultos.Location = new System.Drawing.Point(64, 123);
            this.lblCantBultos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantBultos.Name = "lblCantBultos";
            this.lblCantBultos.Size = new System.Drawing.Size(126, 16);
            this.lblCantBultos.TabIndex = 6;
            this.lblCantBultos.Text = "Cant. total de bultos:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(613, 83);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 5;
            // 
            // lblFechaDesp
            // 
            this.lblFechaDesp.AutoSize = true;
            this.lblFechaDesp.Location = new System.Drawing.Point(504, 88);
            this.lblFechaDesp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesp.Name = "lblFechaDesp";
            this.lblFechaDesp.Size = new System.Drawing.Size(78, 16);
            this.lblFechaDesp.TabIndex = 4;
            this.lblFechaDesp.Text = "CD Destino:";
            this.lblFechaDesp.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCdOrigen
            // 
            this.txtCdOrigen.Location = new System.Drawing.Point(221, 83);
            this.txtCdOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCdOrigen.Name = "txtCdOrigen";
            this.txtCdOrigen.ReadOnly = true;
            this.txtCdOrigen.Size = new System.Drawing.Size(199, 22);
            this.txtCdOrigen.TabIndex = 3;
            // 
            // lblCdOrigen
            // 
            this.lblCdOrigen.AutoSize = true;
            this.lblCdOrigen.Location = new System.Drawing.Point(124, 87);
            this.lblCdOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCdOrigen.Name = "lblCdOrigen";
            this.lblCdOrigen.Size = new System.Drawing.Size(72, 16);
            this.lblCdOrigen.TabIndex = 2;
            this.lblCdOrigen.Text = "CD Origen:";
            this.lblCdOrigen.Click += new System.EventHandler(this.lblCdOrigen_Click);
            // 
            // gbGuias
            // 
            this.gbGuias.Controls.Add(this.lvGuias);
            this.gbGuias.Location = new System.Drawing.Point(13, 269);
            this.gbGuias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGuias.Name = "gbGuias";
            this.gbGuias.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGuias.Size = new System.Drawing.Size(779, 222);
            this.gbGuias.TabIndex = 2;
            this.gbGuias.TabStop = false;
            this.gbGuias.Text = "Detalle de Guias incluidas";
            // 
            // lvGuias
            // 
            this.lvGuias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.lvGuias.Enabled = false;
            this.lvGuias.FullRowSelect = true;
            this.lvGuias.GridLines = true;
            this.lvGuias.HideSelection = false;
            this.lvGuias.Location = new System.Drawing.Point(63, 25);
            this.lvGuias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvGuias.Name = "lvGuias";
            this.lvGuias.Size = new System.Drawing.Size(636, 190);
            this.lvGuias.TabIndex = 0;
            this.lvGuias.UseCompatibleStateImageBehavior = false;
            this.lvGuias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nº Guía";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Remitente";
            this.columnHeader2.Width = 179;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Destinatario";
            this.columnHeader3.Width = 191;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Categoría";
            this.columnHeader5.Width = 181;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "";
            this.columnHeader6.Width = 170;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(430, 551);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(200, 37);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar recepción";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(672, 551);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 37);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 596);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gbGuias);
            this.Controls.Add(this.gbDatosHdr);
            this.Controls.Add(this.gbBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "btnBuscar";
            this.Text = "TUTASA - Recepcion HDR de Transporte";
            this.Load += new System.EventHandler(this.btnBuscar_Load);
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbDatosHdr.ResumeLayout(false);
            this.gbDatosHdr.PerformLayout();
            this.gbGuias.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbDatosHdr;
        private System.Windows.Forms.Label lblCdOrigen;
        private System.Windows.Forms.TextBox txtCdOrigen;
        private System.Windows.Forms.Label lblFechaDesp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCantBultos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gbGuias;
        private System.Windows.Forms.ListView lvGuias;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}