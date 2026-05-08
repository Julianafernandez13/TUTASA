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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNroHdr = new System.Windows.Forms.TextBox();
            this.gbDatosHdr = new System.Windows.Forms.GroupBox();
            this.txtCategorías = new System.Windows.Forms.TextBox();
            this.lblCategorias = new System.Windows.Forms.Label();
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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbObservaciones = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblOperador = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbBusqueda.SuspendLayout();
            this.gbDatosHdr.SuspendLayout();
            this.gbGuias.SuspendLayout();
            this.gbObservaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.button1);
            this.gbBusqueda.Controls.Add(this.txtNroHdr);
            this.gbBusqueda.Location = new System.Drawing.Point(10, 10);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(700, 70);
            this.gbBusqueda.TabIndex = 0;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda de servicio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar servicio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNroHdr
            // 
            this.txtNroHdr.Location = new System.Drawing.Point(162, 27);
            this.txtNroHdr.Name = "txtNroHdr";
            this.txtNroHdr.Size = new System.Drawing.Size(200, 20);
            this.txtNroHdr.TabIndex = 1;
            // 
            // gbDatosHdr
            // 
            this.gbDatosHdr.Controls.Add(this.txtCategorías);
            this.gbDatosHdr.Controls.Add(this.lblCategorias);
            this.gbDatosHdr.Controls.Add(this.textBox2);
            this.gbDatosHdr.Controls.Add(this.lblCantBultos);
            this.gbDatosHdr.Controls.Add(this.textBox1);
            this.gbDatosHdr.Controls.Add(this.lblFechaDesp);
            this.gbDatosHdr.Controls.Add(this.txtCdOrigen);
            this.gbDatosHdr.Controls.Add(this.lblCdOrigen);
            this.gbDatosHdr.Location = new System.Drawing.Point(10, 90);
            this.gbDatosHdr.Name = "gbDatosHdr";
            this.gbDatosHdr.Size = new System.Drawing.Size(700, 80);
            this.gbDatosHdr.TabIndex = 1;
            this.gbDatosHdr.TabStop = false;
            this.gbDatosHdr.Text = "Datos de la HDR recuperada";
            // 
            // txtCategorías
            // 
            this.txtCategorías.Location = new System.Drawing.Point(424, 52);
            this.txtCategorías.Name = "txtCategorías";
            this.txtCategorías.ReadOnly = true;
            this.txtCategorías.Size = new System.Drawing.Size(270, 20);
            this.txtCategorías.TabIndex = 8;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(345, 55);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(62, 13);
            this.lblCategorias.TabIndex = 2;
            this.lblCategorias.Text = "Categorías:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 7;
            // 
            // lblCantBultos
            // 
            this.lblCantBultos.AutoSize = true;
            this.lblCantBultos.Location = new System.Drawing.Point(10, 55);
            this.lblCantBultos.Name = "lblCantBultos";
            this.lblCantBultos.Size = new System.Drawing.Size(104, 13);
            this.lblCantBultos.TabIndex = 6;
            this.lblCantBultos.Text = "Cant. total de bultos:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(424, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lblFechaDesp
            // 
            this.lblFechaDesp.AutoSize = true;
            this.lblFechaDesp.Location = new System.Drawing.Point(317, 26);
            this.lblFechaDesp.Name = "lblFechaDesp";
            this.lblFechaDesp.Size = new System.Drawing.Size(90, 13);
            this.lblFechaDesp.TabIndex = 4;
            this.lblFechaDesp.Text = "Fecha despacho:";
            this.lblFechaDesp.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCdOrigen
            // 
            this.txtCdOrigen.Location = new System.Drawing.Point(130, 23);
            this.txtCdOrigen.Name = "txtCdOrigen";
            this.txtCdOrigen.ReadOnly = true;
            this.txtCdOrigen.Size = new System.Drawing.Size(150, 20);
            this.txtCdOrigen.TabIndex = 3;
            // 
            // lblCdOrigen
            // 
            this.lblCdOrigen.AutoSize = true;
            this.lblCdOrigen.Location = new System.Drawing.Point(57, 26);
            this.lblCdOrigen.Name = "lblCdOrigen";
            this.lblCdOrigen.Size = new System.Drawing.Size(57, 13);
            this.lblCdOrigen.TabIndex = 2;
            this.lblCdOrigen.Text = "CD origen:";
            this.lblCdOrigen.Click += new System.EventHandler(this.lblCdOrigen_Click);
            // 
            // gbGuias
            // 
            this.gbGuias.Controls.Add(this.lvGuias);
            this.gbGuias.Location = new System.Drawing.Point(10, 180);
            this.gbGuias.Name = "gbGuias";
            this.gbGuias.Size = new System.Drawing.Size(700, 180);
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
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvGuias.Enabled = false;
            this.lvGuias.FullRowSelect = true;
            this.lvGuias.GridLines = true;
            this.lvGuias.HideSelection = false;
            this.lvGuias.Location = new System.Drawing.Point(13, 19);
            this.lvGuias.Name = "lvGuias";
            this.lvGuias.Size = new System.Drawing.Size(665, 155);
            this.lvGuias.TabIndex = 0;
            this.lvGuias.UseCompatibleStateImageBehavior = false;
            this.lvGuias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nº Guía";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Remitente";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Destinatario";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bultos";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Categoría";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Estado";
            this.columnHeader6.Width = 170;
            // 
            // gbObservaciones
            // 
            this.gbObservaciones.Controls.Add(this.txtObservaciones);
            this.gbObservaciones.Controls.Add(this.lblObservaciones);
            this.gbObservaciones.Location = new System.Drawing.Point(10, 370);
            this.gbObservaciones.Name = "gbObservaciones";
            this.gbObservaciones.Size = new System.Drawing.Size(700, 90);
            this.gbObservaciones.TabIndex = 3;
            this.gbObservaciones.TabStop = false;
            this.gbObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(166, 28);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(510, 55);
            this.txtObservaciones.TabIndex = 1;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Location = new System.Drawing.Point(10, 30);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(150, 20);
            this.lblObservaciones.TabIndex = 0;
            this.lblObservaciones.Text = "Detalle de discrepancias:";
            // 
            // lblOperador
            // 
            this.lblOperador.Location = new System.Drawing.Point(10, 475);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(280, 18);
            this.lblOperador.TabIndex = 4;
            this.lblOperador.Text = "Operador: Ratti, Valentino | Sesion activa";
            this.lblOperador.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(430, 470);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 30);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar recepción";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(595, 470);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 511);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.gbObservaciones);
            this.Controls.Add(this.gbGuias);
            this.Controls.Add(this.gbDatosHdr);
            this.Controls.Add(this.gbBusqueda);
            this.Name = "btnBuscar";
            this.Text = "TUTASA - Recepcion HDR de Transporte";
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            this.gbDatosHdr.ResumeLayout(false);
            this.gbDatosHdr.PerformLayout();
            this.gbGuias.ResumeLayout(false);
            this.gbObservaciones.ResumeLayout(false);
            this.gbObservaciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.TextBox txtNroHdr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbDatosHdr;
        private System.Windows.Forms.Label lblCdOrigen;
        private System.Windows.Forms.TextBox txtCdOrigen;
        private System.Windows.Forms.Label lblFechaDesp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCantBultos;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.TextBox txtCategorías;
        private System.Windows.Forms.GroupBox gbGuias;
        private System.Windows.Forms.ListView lvGuias;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox gbObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}