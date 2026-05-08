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
            this.lblError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNroHdr = new System.Windows.Forms.TextBox();
            this.lblNroHdr = new System.Windows.Forms.Label();
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
            this.gbBusqueda.Controls.Add(this.lblError);
            this.gbBusqueda.Controls.Add(this.button1);
            this.gbBusqueda.Controls.Add(this.txtNroHdr);
            this.gbBusqueda.Controls.Add(this.lblNroHdr);
            this.gbBusqueda.Location = new System.Drawing.Point(15, 15);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBusqueda.Size = new System.Drawing.Size(1050, 108);
            this.gbBusqueda.TabIndex = 0;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda de HDR";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(15, 80);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(645, 20);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "La HDR ingresada no corresponde a ningun despacho registrado. Verifique el docume" +
    "nto.";
            this.lblError.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar HDR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNroHdr
            // 
            this.txtNroHdr.Location = new System.Drawing.Point(243, 42);
            this.txtNroHdr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNroHdr.Name = "txtNroHdr";
            this.txtNroHdr.Size = new System.Drawing.Size(298, 26);
            this.txtNroHdr.TabIndex = 1;
            // 
            // lblNroHdr
            // 
            this.lblNroHdr.AutoSize = true;
            this.lblNroHdr.Location = new System.Drawing.Point(15, 46);
            this.lblNroHdr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroHdr.Name = "lblNroHdr";
            this.lblNroHdr.Size = new System.Drawing.Size(199, 20);
            this.lblNroHdr.TabIndex = 0;
            this.lblNroHdr.Text = "Nº de HDR de Transporte: ";
            this.lblNroHdr.Click += new System.EventHandler(this.label2_Click);
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
            this.gbDatosHdr.Location = new System.Drawing.Point(15, 138);
            this.gbDatosHdr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDatosHdr.Name = "gbDatosHdr";
            this.gbDatosHdr.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDatosHdr.Size = new System.Drawing.Size(1050, 123);
            this.gbDatosHdr.TabIndex = 1;
            this.gbDatosHdr.TabStop = false;
            this.gbDatosHdr.Text = "Datos de la HDR recuperada";
            // 
            // txtCategorías
            // 
            this.txtCategorías.Location = new System.Drawing.Point(636, 80);
            this.txtCategorías.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategorías.Name = "txtCategorías";
            this.txtCategorías.ReadOnly = true;
            this.txtCategorías.Size = new System.Drawing.Size(403, 26);
            this.txtCategorías.TabIndex = 8;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(518, 85);
            this.lblCategorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(90, 20);
            this.lblCategorias.TabIndex = 2;
            this.lblCategorias.Text = "Categorías:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 80);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(73, 26);
            this.textBox2.TabIndex = 7;
            // 
            // lblCantBultos
            // 
            this.lblCantBultos.AutoSize = true;
            this.lblCantBultos.Location = new System.Drawing.Point(15, 85);
            this.lblCantBultos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantBultos.Name = "lblCantBultos";
            this.lblCantBultos.Size = new System.Drawing.Size(155, 20);
            this.lblCantBultos.TabIndex = 6;
            this.lblCantBultos.Text = "Cant. total de bultos:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(636, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 5;
            // 
            // lblFechaDesp
            // 
            this.lblFechaDesp.AutoSize = true;
            this.lblFechaDesp.Location = new System.Drawing.Point(476, 40);
            this.lblFechaDesp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesp.Name = "lblFechaDesp";
            this.lblFechaDesp.Size = new System.Drawing.Size(132, 20);
            this.lblFechaDesp.TabIndex = 4;
            this.lblFechaDesp.Text = "Fecha despacho:";
            this.lblFechaDesp.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCdOrigen
            // 
            this.txtCdOrigen.Location = new System.Drawing.Point(195, 35);
            this.txtCdOrigen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCdOrigen.Name = "txtCdOrigen";
            this.txtCdOrigen.ReadOnly = true;
            this.txtCdOrigen.Size = new System.Drawing.Size(223, 26);
            this.txtCdOrigen.TabIndex = 3;
            // 
            // lblCdOrigen
            // 
            this.lblCdOrigen.AutoSize = true;
            this.lblCdOrigen.Location = new System.Drawing.Point(86, 40);
            this.lblCdOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCdOrigen.Name = "lblCdOrigen";
            this.lblCdOrigen.Size = new System.Drawing.Size(84, 20);
            this.lblCdOrigen.TabIndex = 2;
            this.lblCdOrigen.Text = "CD origen:";
            this.lblCdOrigen.Click += new System.EventHandler(this.lblCdOrigen_Click);
            // 
            // gbGuias
            // 
            this.gbGuias.Controls.Add(this.lvGuias);
            this.gbGuias.Location = new System.Drawing.Point(15, 277);
            this.gbGuias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbGuias.Name = "gbGuias";
            this.gbGuias.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbGuias.Size = new System.Drawing.Size(1050, 277);
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
            this.lvGuias.Location = new System.Drawing.Point(20, 29);
            this.lvGuias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvGuias.Name = "lvGuias";
            this.lvGuias.Size = new System.Drawing.Size(996, 236);
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
            this.gbObservaciones.Location = new System.Drawing.Point(15, 569);
            this.gbObservaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbObservaciones.Name = "gbObservaciones";
            this.gbObservaciones.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbObservaciones.Size = new System.Drawing.Size(1050, 138);
            this.gbObservaciones.TabIndex = 3;
            this.gbObservaciones.TabStop = false;
            this.gbObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(249, 43);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(763, 82);
            this.txtObservaciones.TabIndex = 1;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.Location = new System.Drawing.Point(15, 46);
            this.lblObservaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(225, 31);
            this.lblObservaciones.TabIndex = 0;
            this.lblObservaciones.Text = "Detalle de discrepancias:";
            // 
            // lblOperador
            // 
            this.lblOperador.Location = new System.Drawing.Point(15, 731);
            this.lblOperador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(420, 28);
            this.lblOperador.TabIndex = 4;
            this.lblOperador.Text = "Operador: Ratti, Valentino | Sesion activa";
            this.lblOperador.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(645, 723);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(225, 46);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar recepción";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(892, 723);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 46);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 786);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.gbObservaciones);
            this.Controls.Add(this.gbGuias);
            this.Controls.Add(this.gbDatosHdr);
            this.Controls.Add(this.gbBusqueda);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label lblNroHdr;
        private System.Windows.Forms.TextBox txtNroHdr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblError;
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