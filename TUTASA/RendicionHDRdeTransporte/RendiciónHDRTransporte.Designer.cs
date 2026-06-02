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
            this.cmbEmpresaTransporte = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbDatosHdr = new System.Windows.Forms.GroupBox();
            this.lblCDDestino = new System.Windows.Forms.Label();
            this.lblCDOrigen = new System.Windows.Forms.Label();
            this.lblCantBultos = new System.Windows.Forms.Label();
            this.cmbNroHDR = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantBultosTitulo = new System.Windows.Forms.Label();
            this.lblCdDestinoTitulo = new System.Windows.Forms.Label();
            this.lblCdOrigenTitulo = new System.Windows.Forms.Label();
            this.gbGuias = new System.Windows.Forms.GroupBox();
            this.listViewGuias = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConfirmarRecepcion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbBusqueda.SuspendLayout();
            this.gbDatosHdr.SuspendLayout();
            this.gbGuias.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.label1);
            this.gbBusqueda.Controls.Add(this.cmbEmpresaTransporte);
            this.gbBusqueda.Controls.Add(this.btnConfirmar);
            this.gbBusqueda.Location = new System.Drawing.Point(10, 10);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(584, 70);
            this.gbBusqueda.TabIndex = 0;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Busqueda de servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Servicio:";
            // 
            // cmbEmpresaTransporte
            // 
            this.cmbEmpresaTransporte.FormattingEnabled = true;
            this.cmbEmpresaTransporte.Location = new System.Drawing.Point(219, 30);
            this.cmbEmpresaTransporte.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmpresaTransporte.Name = "cmbEmpresaTransporte";
            this.cmbEmpresaTransporte.Size = new System.Drawing.Size(113, 21);
            this.cmbEmpresaTransporte.TabIndex = 11;
            this.cmbEmpresaTransporte.UseWaitCursor = true;
            this.cmbEmpresaTransporte.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresaTransporte_SelectedIndexChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(362, 27);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 24);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gbDatosHdr
            // 
            this.gbDatosHdr.Controls.Add(this.lblCDDestino);
            this.gbDatosHdr.Controls.Add(this.lblCDOrigen);
            this.gbDatosHdr.Controls.Add(this.lblCantBultos);
            this.gbDatosHdr.Controls.Add(this.cmbNroHDR);
            this.gbDatosHdr.Controls.Add(this.label2);
            this.gbDatosHdr.Controls.Add(this.lblCantBultosTitulo);
            this.gbDatosHdr.Controls.Add(this.lblCdDestinoTitulo);
            this.gbDatosHdr.Controls.Add(this.lblCdOrigenTitulo);
            this.gbDatosHdr.Location = new System.Drawing.Point(10, 86);
            this.gbDatosHdr.Name = "gbDatosHdr";
            this.gbDatosHdr.Size = new System.Drawing.Size(584, 125);
            this.gbDatosHdr.TabIndex = 1;
            this.gbDatosHdr.TabStop = false;
            this.gbDatosHdr.Text = "Datos de la HDR:";
            this.gbDatosHdr.Enter += new System.EventHandler(this.gbDatosHdr_Enter);
            // 
            // lblCDDestino
            // 
            this.lblCDDestino.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCDDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCDDestino.Location = new System.Drawing.Point(379, 70);
            this.lblCDDestino.Name = "lblCDDestino";
            this.lblCDDestino.Size = new System.Drawing.Size(164, 22);
            this.lblCDDestino.TabIndex = 19;
            // 
            // lblCDOrigen
            // 
            this.lblCDOrigen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCDOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCDOrigen.Location = new System.Drawing.Point(116, 70);
            this.lblCDOrigen.Name = "lblCDOrigen";
            this.lblCDOrigen.Size = new System.Drawing.Size(164, 22);
            this.lblCDOrigen.TabIndex = 18;
            this.lblCDOrigen.Click += new System.EventHandler(this.lblCDOrigen_Click);
            // 
            // lblCantBultos
            // 
            this.lblCantBultos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantBultos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantBultos.Location = new System.Drawing.Point(116, 99);
            this.lblCantBultos.Name = "lblCantBultos";
            this.lblCantBultos.Size = new System.Drawing.Size(164, 22);
            this.lblCantBultos.TabIndex = 17;
            this.lblCantBultos.Click += new System.EventHandler(this.lblCantBultos_Click);
            // 
            // cmbNroHDR
            // 
            this.cmbNroHDR.FormattingEnabled = true;
            this.cmbNroHDR.Location = new System.Drawing.Point(219, 28);
            this.cmbNroHDR.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNroHDR.Name = "cmbNroHDR";
            this.cmbNroHDR.Size = new System.Drawing.Size(113, 21);
            this.cmbNroHDR.TabIndex = 14;
            this.cmbNroHDR.UseWaitCursor = true;
            this.cmbNroHDR.SelectedIndexChanged += new System.EventHandler(this.cmbNroHDR_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selecciona N° de HDR:";
            // 
            // lblCantBultosTitulo
            // 
            this.lblCantBultosTitulo.AutoSize = true;
            this.lblCantBultosTitulo.Location = new System.Drawing.Point(6, 100);
            this.lblCantBultosTitulo.Name = "lblCantBultosTitulo";
            this.lblCantBultosTitulo.Size = new System.Drawing.Size(104, 13);
            this.lblCantBultosTitulo.TabIndex = 6;
            this.lblCantBultosTitulo.Text = "Cant. total de bultos:";
            // 
            // lblCdDestinoTitulo
            // 
            this.lblCdDestinoTitulo.AutoSize = true;
            this.lblCdDestinoTitulo.Location = new System.Drawing.Point(309, 73);
            this.lblCdDestinoTitulo.Name = "lblCdDestinoTitulo";
            this.lblCdDestinoTitulo.Size = new System.Drawing.Size(64, 13);
            this.lblCdDestinoTitulo.TabIndex = 4;
            this.lblCdDestinoTitulo.Text = "CD Destino:";
            // 
            // lblCdOrigenTitulo
            // 
            this.lblCdOrigenTitulo.AutoSize = true;
            this.lblCdOrigenTitulo.Location = new System.Drawing.Point(51, 71);
            this.lblCdOrigenTitulo.Name = "lblCdOrigenTitulo";
            this.lblCdOrigenTitulo.Size = new System.Drawing.Size(59, 13);
            this.lblCdOrigenTitulo.TabIndex = 2;
            this.lblCdOrigenTitulo.Text = "CD Origen:";
            // 
            // gbGuias
            // 
            this.gbGuias.Controls.Add(this.listViewGuias);
            this.gbGuias.Location = new System.Drawing.Point(10, 219);
            this.gbGuias.Name = "gbGuias";
            this.gbGuias.Size = new System.Drawing.Size(584, 180);
            this.gbGuias.TabIndex = 2;
            this.gbGuias.TabStop = false;
            this.gbGuias.Text = "Detalle de Guias incluidas";
            // 
            // listViewGuias
            // 
            this.listViewGuias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewGuias.Enabled = false;
            this.listViewGuias.FullRowSelect = true;
            this.listViewGuias.GridLines = true;
            this.listViewGuias.HideSelection = false;
            this.listViewGuias.Location = new System.Drawing.Point(47, 20);
            this.listViewGuias.Name = "listViewGuias";
            this.listViewGuias.Size = new System.Drawing.Size(478, 155);
            this.listViewGuias.TabIndex = 0;
            this.listViewGuias.UseCompatibleStateImageBehavior = false;
            this.listViewGuias.View = System.Windows.Forms.View.Details;
            this.listViewGuias.SelectedIndexChanged += new System.EventHandler(this.listViewGuias_SelectedIndexChanged);
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
            // btnConfirmarRecepcion
            // 
            this.btnConfirmarRecepcion.Location = new System.Drawing.Point(322, 448);
            this.btnConfirmarRecepcion.Name = "btnConfirmarRecepcion";
            this.btnConfirmarRecepcion.Size = new System.Drawing.Size(150, 30);
            this.btnConfirmarRecepcion.TabIndex = 5;
            this.btnConfirmarRecepcion.Text = "Confirmar recepción";
            this.btnConfirmarRecepcion.UseVisualStyleBackColor = true;
            this.btnConfirmarRecepcion.Click += new System.EventHandler(this.btnConfirmarRecepcion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(504, 448);
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
            this.ClientSize = new System.Drawing.Size(611, 484);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarRecepcion);
            this.Controls.Add(this.gbGuias);
            this.Controls.Add(this.gbDatosHdr);
            this.Controls.Add(this.gbBusqueda);
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
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gbDatosHdr;
        private System.Windows.Forms.Label lblCdOrigenTitulo;
        private System.Windows.Forms.Label lblCdDestinoTitulo;
        private System.Windows.Forms.Label lblCantBultosTitulo;
        private System.Windows.Forms.GroupBox gbGuias;
        private System.Windows.Forms.ListView listViewGuias;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnConfirmarRecepcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmpresaTransporte;
        private System.Windows.Forms.ComboBox cmbNroHDR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCDDestino;
        private System.Windows.Forms.Label lblCDOrigen;
        private System.Windows.Forms.Label lblCantBultos;
    }
}