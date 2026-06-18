namespace TUTASA.Forms.Administracion
{
    partial class frmEmitirFactura
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
            this.btnBuscarPeriodo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEmitirFactura = new System.Windows.Forms.Button();
            this.lblMostrarTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupMovimientos = new System.Windows.Forms.GroupBox();
            this.listViewMovimientos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.groupPeriodo = new System.Windows.Forms.GroupBox();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
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
            this.groupMovimientos.SuspendLayout();
            this.groupPeriodo.SuspendLayout();
            this.groupBuscarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupEmitirFactura
            // 
            this.groupEmitirFactura.Controls.Add(this.btnCancelar);
            this.groupEmitirFactura.Controls.Add(this.btnEmitirFactura);
            this.groupEmitirFactura.Controls.Add(this.lblMostrarTotal);
            this.groupEmitirFactura.Controls.Add(this.lblTotal);
            this.groupEmitirFactura.Controls.Add(this.groupMovimientos);
            this.groupEmitirFactura.Controls.Add(this.groupPeriodo);
            this.groupEmitirFactura.Controls.Add(this.groupBuscarCliente);
            this.groupEmitirFactura.Controls.Add(this.label1);
            this.groupEmitirFactura.Location = new System.Drawing.Point(18, 18);
            this.groupEmitirFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupEmitirFactura.Name = "groupEmitirFactura";
            this.groupEmitirFactura.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupEmitirFactura.Size = new System.Drawing.Size(997, 652);
            this.groupEmitirFactura.TabIndex = 0;
            this.groupEmitirFactura.TabStop = false;
            this.groupEmitirFactura.Text = "TUTASA - Emitir Factura";
            // 
            // btnBuscarPeriodo
            // 
            this.btnBuscarPeriodo.Location = new System.Drawing.Point(499, 25);
            this.btnBuscarPeriodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarPeriodo.Name = "btnBuscarPeriodo";
            this.btnBuscarPeriodo.Size = new System.Drawing.Size(117, 33);
            this.btnBuscarPeriodo.TabIndex = 0;
            this.btnBuscarPeriodo.Text = "Buscar";
            this.btnBuscarPeriodo.UseVisualStyleBackColor = true;
            this.btnBuscarPeriodo.Click += new System.EventHandler(this.btnBuscarPeriodo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(869, 608);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEmitirFactura
            // 
            this.btnEmitirFactura.Location = new System.Drawing.Point(705, 608);
            this.btnEmitirFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEmitirFactura.Name = "btnEmitirFactura";
            this.btnEmitirFactura.Size = new System.Drawing.Size(134, 35);
            this.btnEmitirFactura.TabIndex = 6;
            this.btnEmitirFactura.Text = "Emitir Factura";
            this.btnEmitirFactura.UseVisualStyleBackColor = true;
            this.btnEmitirFactura.Click += new System.EventHandler(this.btnEmitirFactura_Click);
            // 
            // lblMostrarTotal
            // 
            this.lblMostrarTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMostrarTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrarTotal.Location = new System.Drawing.Point(428, 546);
            this.lblMostrarTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMostrarTotal.Name = "lblMostrarTotal";
            this.lblMostrarTotal.Size = new System.Drawing.Size(179, 33);
            this.lblMostrarTotal.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(291, 548);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(125, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total a Facturar:";
            // 
            // groupMovimientos
            // 
            this.groupMovimientos.Controls.Add(this.listViewMovimientos);
            this.groupMovimientos.Controls.Add(this.label4);
            this.groupMovimientos.Location = new System.Drawing.Point(28, 338);
            this.groupMovimientos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupMovimientos.Name = "groupMovimientos";
            this.groupMovimientos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupMovimientos.Size = new System.Drawing.Size(961, 219);
            this.groupMovimientos.TabIndex = 3;
            this.groupMovimientos.TabStop = false;
            this.groupMovimientos.Text = "Movimientos a Facturar";
            // 
            // listViewMovimientos
            // 
            this.listViewMovimientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader4});
            this.listViewMovimientos.FullRowSelect = true;
            this.listViewMovimientos.GridLines = true;
            this.listViewMovimientos.HideSelection = false;
            this.listViewMovimientos.Location = new System.Drawing.Point(15, 29);
            this.listViewMovimientos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewMovimientos.Name = "listViewMovimientos";
            this.listViewMovimientos.Size = new System.Drawing.Size(946, 149);
            this.listViewMovimientos.TabIndex = 1;
            this.listViewMovimientos.UseCompatibleStateImageBehavior = false;
            this.listViewMovimientos.View = System.Windows.Forms.View.Details;
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
            this.label4.Location = new System.Drawing.Point(534, 380);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 0;
            // 
            // groupPeriodo
            // 
            this.groupPeriodo.Controls.Add(this.btnBuscarPeriodo);
            this.groupPeriodo.Controls.Add(this.cmbAño);
            this.groupPeriodo.Controls.Add(this.cmbMes);
            this.groupPeriodo.Controls.Add(this.lblAño);
            this.groupPeriodo.Controls.Add(this.lblMes);
            this.groupPeriodo.Controls.Add(this.label3);
            this.groupPeriodo.Location = new System.Drawing.Point(28, 218);
            this.groupPeriodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupPeriodo.Name = "groupPeriodo";
            this.groupPeriodo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupPeriodo.Size = new System.Drawing.Size(953, 91);
            this.groupPeriodo.TabIndex = 2;
            this.groupPeriodo.TabStop = false;
            this.groupPeriodo.Text = "Periodo";
            // 
            // cmbAño
            // 
            this.cmbAño.Items.AddRange(new object[] {
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
            this.cmbAño.Location = new System.Drawing.Point(314, 29);
            this.cmbAño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(96, 28);
            this.cmbAño.TabIndex = 12;
            // 
            // cmbMes
            // 
            this.cmbMes.Items.AddRange(new object[] {
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
            this.cmbMes.Location = new System.Drawing.Point(81, 28);
            this.cmbMes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(97, 28);
            this.cmbMes.TabIndex = 11;
            // 
            // lblAño
            // 
            this.lblAño.Location = new System.Drawing.Point(252, 32);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(43, 22);
            this.lblAño.TabIndex = 10;
            this.lblAño.Text = "Año:";
            // 
            // lblMes
            // 
            this.lblMes.Location = new System.Drawing.Point(22, 32);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(52, 22);
            this.lblMes.TabIndex = 9;
            this.lblMes.Text = "Mes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
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
            this.groupBuscarCliente.Location = new System.Drawing.Point(28, 51);
            this.groupBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBuscarCliente.Name = "groupBuscarCliente";
            this.groupBuscarCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBuscarCliente.Size = new System.Drawing.Size(953, 138);
            this.groupBuscarCliente.TabIndex = 1;
            this.groupBuscarCliente.TabStop = false;
            this.groupBuscarCliente.Text = "Buscar Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(369, 34);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblMostrarCliente
            // 
            this.lblMostrarCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMostrarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMostrarCliente.Location = new System.Drawing.Point(81, 88);
            this.lblMostrarCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMostrarCliente.Name = "lblMostrarCliente";
            this.lblMostrarCliente.Size = new System.Drawing.Size(400, 33);
            this.lblMostrarCliente.TabIndex = 4;
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(81, 38);
            this.txtCUIT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCUIT.MaxLength = 11;
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(258, 26);
            this.txtCUIT.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(9, 89);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(62, 20);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(21, 41);
            this.lblCUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(50, 20);
            this.lblCUIT.TabIndex = 1;
            this.lblCUIT.Text = "CUIT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 380);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // EmitirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 699);
            this.Controls.Add(this.groupEmitirFactura);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmitirFactura";
            this.Text = "Emitir Factura";
            this.Load += new System.EventHandler(this.EmitirFactura_Load);
            this.groupEmitirFactura.ResumeLayout(false);
            this.groupEmitirFactura.PerformLayout();
            this.groupMovimientos.ResumeLayout(false);
            this.groupMovimientos.PerformLayout();
            this.groupPeriodo.ResumeLayout(false);
            this.groupPeriodo.PerformLayout();
            this.groupBuscarCliente.ResumeLayout(false);
            this.groupBuscarCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupEmitirFactura;
        private System.Windows.Forms.GroupBox groupBuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupMovimientos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label lblMostrarTotal;
        private System.Windows.Forms.Label lblMostrarCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEmitirFactura;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView listViewMovimientos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupPeriodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnBuscarPeriodo;
    }
}