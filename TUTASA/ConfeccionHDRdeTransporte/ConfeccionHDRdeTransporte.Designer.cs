namespace TUTASA.Pantallas
{
    partial class ConfeccionHDRdeTransporte
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
            this.groupDatosDespacho = new System.Windows.Forms.GroupBox();
            this.labelMuestraCDOrigen = new System.Windows.Forms.Label();
            this.labelCDDestino = new System.Windows.Forms.Label();
            this.cmbLocalidadDestino = new System.Windows.Forms.ComboBox();
            this.labelLocalidadDestino = new System.Windows.Forms.Label();
            this.cmbCDDestino = new System.Windows.Forms.ComboBox();
            this.labelCDOrigen = new System.Windows.Forms.Label();
            this.groupServicioTransporte = new System.Windows.Forms.GroupBox();
            this.labelMuestraTipoArrendamiento = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.labelTipoArrendamiento = new System.Windows.Forms.Label();
            this.labelServicio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupListadoEncomiendas = new System.Windows.Forms.GroupBox();
            this.listViewEncomiendas = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupDatosDespacho.SuspendLayout();
            this.groupServicioTransporte.SuspendLayout();
            this.groupListadoEncomiendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDatosDespacho
            // 
            this.groupDatosDespacho.Controls.Add(this.labelMuestraCDOrigen);
            this.groupDatosDespacho.Controls.Add(this.labelCDDestino);
            this.groupDatosDespacho.Controls.Add(this.cmbLocalidadDestino);
            this.groupDatosDespacho.Controls.Add(this.labelLocalidadDestino);
            this.groupDatosDespacho.Controls.Add(this.cmbCDDestino);
            this.groupDatosDespacho.Controls.Add(this.labelCDOrigen);
            this.groupDatosDespacho.Location = new System.Drawing.Point(12, 12);
            this.groupDatosDespacho.Name = "groupDatosDespacho";
            this.groupDatosDespacho.Size = new System.Drawing.Size(614, 130);
            this.groupDatosDespacho.TabIndex = 0;
            this.groupDatosDespacho.TabStop = false;
            this.groupDatosDespacho.Text = "Datos Despacho";
            this.groupDatosDespacho.UseWaitCursor = true;
           
            // 
            // labelMuestraCDOrigen
            // 
            this.labelMuestraCDOrigen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelMuestraCDOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMuestraCDOrigen.Location = new System.Drawing.Point(173, 38);
            this.labelMuestraCDOrigen.Name = "labelMuestraCDOrigen";
            this.labelMuestraCDOrigen.Size = new System.Drawing.Size(149, 22);
            this.labelMuestraCDOrigen.TabIndex = 16;
            this.labelMuestraCDOrigen.UseWaitCursor = true;
           
            // 
            // labelCDDestino
            // 
            this.labelCDDestino.AutoSize = true;
            this.labelCDDestino.Location = new System.Drawing.Point(360, 88);
            this.labelCDDestino.Name = "labelCDDestino";
            this.labelCDDestino.Size = new System.Drawing.Size(78, 16);
            this.labelCDDestino.TabIndex = 11;
            this.labelCDDestino.Text = "CD Destino:";
            this.labelCDDestino.UseWaitCursor = true;
           
            // 
            // cmbLocalidadDestino
            // 
            this.cmbLocalidadDestino.FormattingEnabled = true;
            this.cmbLocalidadDestino.Location = new System.Drawing.Point(173, 86);
            this.cmbLocalidadDestino.Name = "cmbLocalidadDestino";
            this.cmbLocalidadDestino.Size = new System.Drawing.Size(149, 24);
            this.cmbLocalidadDestino.TabIndex = 10;
            this.cmbLocalidadDestino.UseWaitCursor = true;
            this.cmbLocalidadDestino.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidadDestino_SelectedIndexChanged);
            // 
            // labelLocalidadDestino
            // 
            this.labelLocalidadDestino.AutoSize = true;
            this.labelLocalidadDestino.Location = new System.Drawing.Point(40, 88);
            this.labelLocalidadDestino.Name = "labelLocalidadDestino";
            this.labelLocalidadDestino.Size = new System.Drawing.Size(119, 16);
            this.labelLocalidadDestino.TabIndex = 9;
            this.labelLocalidadDestino.Text = "Localidad Destino:";
            this.labelLocalidadDestino.UseWaitCursor = true;
            
            // 
            // cmbCDDestino
            // 
            this.cmbCDDestino.FormattingEnabled = true;
            this.cmbCDDestino.Location = new System.Drawing.Point(450, 86);
            this.cmbCDDestino.Name = "cmbCDDestino";
            this.cmbCDDestino.Size = new System.Drawing.Size(118, 24);
            this.cmbCDDestino.TabIndex = 8;
            this.cmbCDDestino.UseWaitCursor = true;
     
            // 
            // labelCDOrigen
            // 
            this.labelCDOrigen.AutoSize = true;
            this.labelCDOrigen.Location = new System.Drawing.Point(87, 39);
            this.labelCDOrigen.Name = "labelCDOrigen";
            this.labelCDOrigen.Size = new System.Drawing.Size(72, 16);
            this.labelCDOrigen.TabIndex = 6;
            this.labelCDOrigen.Text = "CD Origen:";
            this.labelCDOrigen.UseWaitCursor = true;
           
            // 
            // groupServicioTransporte
            // 
            this.groupServicioTransporte.Controls.Add(this.labelMuestraTipoArrendamiento);
            this.groupServicioTransporte.Controls.Add(this.cmbServicio);
            this.groupServicioTransporte.Controls.Add(this.labelTipoArrendamiento);
            this.groupServicioTransporte.Controls.Add(this.labelServicio);
            this.groupServicioTransporte.Location = new System.Drawing.Point(12, 323);
            this.groupServicioTransporte.Name = "groupServicioTransporte";
            this.groupServicioTransporte.Size = new System.Drawing.Size(614, 70);
            this.groupServicioTransporte.TabIndex = 9;
            this.groupServicioTransporte.TabStop = false;
            this.groupServicioTransporte.Text = "Servicio de Transporte";
            this.groupServicioTransporte.UseWaitCursor = true;
           
            // 
            // labelMuestraTipoArrendamiento
            // 
            this.labelMuestraTipoArrendamiento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelMuestraTipoArrendamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMuestraTipoArrendamiento.Location = new System.Drawing.Point(443, 29);
            this.labelMuestraTipoArrendamiento.Name = "labelMuestraTipoArrendamiento";
            this.labelMuestraTipoArrendamiento.Size = new System.Drawing.Size(125, 22);
            this.labelMuestraTipoArrendamiento.TabIndex = 17;
            this.labelMuestraTipoArrendamiento.UseWaitCursor = true;
            
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(141, 28);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(120, 24);
            this.cmbServicio.TabIndex = 7;
            this.cmbServicio.UseWaitCursor = true;
            this.cmbServicio.SelectedIndexChanged += new System.EventHandler(this.cmbServicio_SelectedIndexChanged);
            // 
            // labelTipoArrendamiento
            // 
            this.labelTipoArrendamiento.AutoSize = true;
            this.labelTipoArrendamiento.Location = new System.Drawing.Point(284, 30);
            this.labelTipoArrendamiento.Name = "labelTipoArrendamiento";
            this.labelTipoArrendamiento.Size = new System.Drawing.Size(147, 16);
            this.labelTipoArrendamiento.TabIndex = 3;
            this.labelTipoArrendamiento.Text = "Tipo de arrendamiento:";
            this.labelTipoArrendamiento.UseWaitCursor = true;
            
            // 
            // labelServicio
            // 
            this.labelServicio.AutoSize = true;
            this.labelServicio.Location = new System.Drawing.Point(69, 30);
            this.labelServicio.Name = "labelServicio";
            this.labelServicio.Size = new System.Drawing.Size(59, 16);
            this.labelServicio.TabIndex = 1;
            this.labelServicio.Text = "Servicio:";
            this.labelServicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelServicio.UseWaitCursor = true;
           
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(530, 422);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 25);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.UseWaitCursor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(394, 422);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 25);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.UseWaitCursor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupListadoEncomiendas
            // 
            this.groupListadoEncomiendas.Controls.Add(this.listViewEncomiendas);
            this.groupListadoEncomiendas.Location = new System.Drawing.Point(12, 156);
            this.groupListadoEncomiendas.Name = "groupListadoEncomiendas";
            this.groupListadoEncomiendas.Size = new System.Drawing.Size(614, 139);
            this.groupListadoEncomiendas.TabIndex = 29;
            this.groupListadoEncomiendas.TabStop = false;
            this.groupListadoEncomiendas.Text = "Listado de encomiendas";
            this.groupListadoEncomiendas.UseWaitCursor = true;
           
            // 
            // listViewEncomiendas
            // 
            this.listViewEncomiendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewEncomiendas.HideSelection = false;
            this.listViewEncomiendas.Location = new System.Drawing.Point(21, 22);
            this.listViewEncomiendas.Name = "listViewEncomiendas";
            this.listViewEncomiendas.Size = new System.Drawing.Size(577, 112);
            this.listViewEncomiendas.TabIndex = 2;
            this.listViewEncomiendas.UseCompatibleStateImageBehavior = false;
            this.listViewEncomiendas.UseWaitCursor = true;
            this.listViewEncomiendas.View = System.Windows.Forms.View.Details;
            this.listViewEncomiendas.SelectedIndexChanged += new System.EventHandler(this.listViewEncomiendas_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nro de guia";
            this.columnHeader7.Width = 128;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Categoria";
            this.columnHeader11.Width = 90;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Localidad Destino";
            this.columnHeader12.Width = 491;
            // 
            // ConfeccionHDRdeTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 541);
            this.Controls.Add(this.groupListadoEncomiendas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupServicioTransporte);
            this.Controls.Add(this.groupDatosDespacho);
            this.Name = "ConfeccionHDRdeTransporte";
            this.Text = "TUTASA – Confección de Hoja de Ruta de Transporte";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.ConfeccionHDRdeTransporte_Load);
            this.groupDatosDespacho.ResumeLayout(false);
            this.groupDatosDespacho.PerformLayout();
            this.groupServicioTransporte.ResumeLayout(false);
            this.groupServicioTransporte.PerformLayout();
            this.groupListadoEncomiendas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDatosDespacho;
        private System.Windows.Forms.ComboBox cmbCDDestino;
        private System.Windows.Forms.Label labelCDOrigen;
        private System.Windows.Forms.GroupBox groupServicioTransporte;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Label labelTipoArrendamiento;
        private System.Windows.Forms.Label labelServicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelLocalidadDestino;
        private System.Windows.Forms.Label labelCDDestino;
        private System.Windows.Forms.ComboBox cmbLocalidadDestino;
        private System.Windows.Forms.GroupBox groupListadoEncomiendas;
        private System.Windows.Forms.ListView listViewEncomiendas;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label labelMuestraCDOrigen;
        private System.Windows.Forms.Label labelMuestraTipoArrendamiento;
    }
}