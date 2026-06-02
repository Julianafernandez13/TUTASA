namespace TUTASA.Forms.Administracion
{
    partial class EmitirFactura
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
            this.groupEmitirFactura = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvGuias = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBuscarCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblMostrarCliente = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupEmitirFactura.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBuscarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupEmitirFactura
            // 
            this.groupEmitirFactura.Controls.Add(this.button3);
            this.groupEmitirFactura.Controls.Add(this.button2);
            this.groupEmitirFactura.Controls.Add(this.label11);
            this.groupEmitirFactura.Controls.Add(this.label9);
            this.groupEmitirFactura.Controls.Add(this.groupBox4);
            this.groupEmitirFactura.Controls.Add(this.groupBox3);
            this.groupEmitirFactura.Controls.Add(this.groupBuscarCliente);
            this.groupEmitirFactura.Controls.Add(this.label1);
            this.groupEmitirFactura.Location = new System.Drawing.Point(16, 14);
            this.groupEmitirFactura.Margin = new System.Windows.Forms.Padding(4);
            this.groupEmitirFactura.Name = "groupEmitirFactura";
            this.groupEmitirFactura.Padding = new System.Windows.Forms.Padding(4);
            this.groupEmitirFactura.Size = new System.Drawing.Size(886, 522);
            this.groupEmitirFactura.TabIndex = 0;
            this.groupEmitirFactura.TabStop = false;
            this.groupEmitirFactura.Text = "TUTASA - Emitir Factura";
            this.groupEmitirFactura.Enter += new System.EventHandler(this.groupEmitirFactura_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(418, 486);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 486);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Emitir Factura";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(380, 437);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 27);
            this.label11.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 438);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Total a Facturar:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvGuias);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(25, 270);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(854, 140);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Movimientos a Facturar";
            // 
            // lvGuias
            // 
            this.lvGuias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader4});
            this.lvGuias.Enabled = false;
            this.lvGuias.FullRowSelect = true;
            this.lvGuias.GridLines = true;
            this.lvGuias.HideSelection = false;
            this.lvGuias.Location = new System.Drawing.Point(7, 23);
            this.lvGuias.Margin = new System.Windows.Forms.Padding(4);
            this.lvGuias.Name = "lvGuias";
            this.lvGuias.Size = new System.Drawing.Size(840, 87);
            this.lvGuias.TabIndex = 1;
            this.lvGuias.UseCompatibleStateImageBehavior = false;
            this.lvGuias.View = System.Windows.Forms.View.Details;
            this.lvGuias.SelectedIndexChanged += new System.EventHandler(this.lvGuias_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Número Guía";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Origen";
            this.columnHeader3.Width = 191;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Destino";
            this.columnHeader5.Width = 169;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Categoria";
            this.columnHeader6.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblDesde);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(25, 174);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(325, 73);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Periodo";
            // 
            // comboBox2
            // 
            this.comboBox2.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.comboBox2.Location = new System.Drawing.Point(208, 22);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(86, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(72, 22);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(164, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Año:";
            // 
            // lblDesde
            // 
            this.lblDesde.Location = new System.Drawing.Point(20, 26);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(46, 18);
            this.lblDesde.TabIndex = 9;
            this.lblDesde.Text = "Mes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 0;
            // 
            // groupBuscarCliente
            // 
            this.groupBuscarCliente.Controls.Add(this.btnBuscar);
            this.groupBuscarCliente.Controls.Add(this.lblMostrarCliente);
            this.groupBuscarCliente.Controls.Add(this.txtCUIT);
            this.groupBuscarCliente.Controls.Add(this.lblCliente);
            this.groupBuscarCliente.Controls.Add(this.lblCUIT);
            this.groupBuscarCliente.Controls.Add(this.label2);
            this.groupBuscarCliente.Location = new System.Drawing.Point(25, 41);
            this.groupBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.groupBuscarCliente.Name = "groupBuscarCliente";
            this.groupBuscarCliente.Padding = new System.Windows.Forms.Padding(4);
            this.groupBuscarCliente.Size = new System.Drawing.Size(847, 110);
            this.groupBuscarCliente.TabIndex = 1;
            this.groupBuscarCliente.TabStop = false;
            this.groupBuscarCliente.Text = "Buscar Cliente";
            this.groupBuscarCliente.Enter += new System.EventHandler(this.groupBuscarCliente_Enter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(328, 27);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMostrarCliente
            // 
            this.lblMostrarCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMostrarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrarCliente.Location = new System.Drawing.Point(72, 70);
            this.lblMostrarCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMostrarCliente.Name = "lblMostrarCliente";
            this.lblMostrarCliente.Size = new System.Drawing.Size(373, 27);
            this.lblMostrarCliente.TabIndex = 4;
            this.lblMostrarCliente.Click += new System.EventHandler(this.lblMostrarCliente_Click);
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(62, 30);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(4);
            this.txtCUIT.MaxLength = 11;
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(230, 22);
            this.txtCUIT.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(8, 71);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 16);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(8, 34);
            this.lblCUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(41, 16);
            this.lblCUIT.TabIndex = 1;
            this.lblCUIT.Text = "CUIT:";
            this.lblCUIT.Click += new System.EventHandler(this.lblCUIT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // EmitirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 720);
            this.Controls.Add(this.groupEmitirFactura);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmitirFactura";
            this.Text = "Emitir Factura";
            this.Load += new System.EventHandler(this.EmitirFactura_Load);
            this.groupEmitirFactura.ResumeLayout(false);
            this.groupEmitirFactura.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBuscarCliente.ResumeLayout(false);
            this.groupBuscarCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupEmitirFactura;
        private System.Windows.Forms.GroupBox groupBuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMostrarCliente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView lvGuias;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}