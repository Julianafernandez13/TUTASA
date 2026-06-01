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
            this.groupDatosDespacho.Location = new System.Drawing.Point(14, 15);
            this.groupDatosDespacho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupDatosDespacho.Name = "groupDatosDespacho";
            this.groupDatosDespacho.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupDatosDespacho.Size = new System.Drawing.Size(691, 163);
            this.groupDatosDespacho.TabIndex = 0;
            this.groupDatosDespacho.TabStop = false;
            this.groupDatosDespacho.Text = "Datos Despacho";
            this.groupDatosDespacho.UseWaitCursor = true;
            this.groupDatosDespacho.Enter += new System.EventHandler(this.groupDatosDespacho_Enter);
            // 
            // labelMuestraCDOrigen
            // 
            this.labelMuestraCDOrigen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelMuestraCDOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMuestraCDOrigen.Location = new System.Drawing.Point(195, 47);
            this.labelMuestraCDOrigen.Name = "labelMuestraCDOrigen";
            this.labelMuestraCDOrigen.Size = new System.Drawing.Size(167, 27);
            this.labelMuestraCDOrigen.TabIndex = 16;
            this.labelMuestraCDOrigen.UseWaitCursor = true;
            this.labelMuestraCDOrigen.Click += new System.EventHandler(this.labelMuestraCDOrigen_Click);
            // 
            // labelCDDestino
            // 
            this.labelCDDestino.AutoSize = true;
            this.labelCDDestino.Location = new System.Drawing.Point(405, 110);
            this.labelCDDestino.Name = "labelCDDestino";
            this.labelCDDestino.Size = new System.Drawing.Size(95, 20);
            this.labelCDDestino.TabIndex = 11;
            this.labelCDDestino.Text = "CD Destino:";
            this.labelCDDestino.UseWaitCursor = true;
            this.labelCDDestino.Click += new System.EventHandler(this.labelCDDestino_Click);
            // 
            // cmbLocalidadDestino
            // 
            this.cmbLocalidadDestino.FormattingEnabled = true;
            this.cmbLocalidadDestino.Location = new System.Drawing.Point(195, 107);
            this.cmbLocalidadDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLocalidadDestino.Name = "cmbLocalidadDestino";
            this.cmbLocalidadDestino.Size = new System.Drawing.Size(167, 28);
            this.cmbLocalidadDestino.TabIndex = 10;
            this.cmbLocalidadDestino.UseWaitCursor = true;
            this.cmbLocalidadDestino.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidadDestino_SelectedIndexChanged);
            // 
            // labelLocalidadDestino
            // 
            this.labelLocalidadDestino.AutoSize = true;
            this.labelLocalidadDestino.Location = new System.Drawing.Point(45, 110);
            this.labelLocalidadDestino.Name = "labelLocalidadDestino";
            this.labelLocalidadDestino.Size = new System.Drawing.Size(140, 20);
            this.labelLocalidadDestino.TabIndex = 9;
            this.labelLocalidadDestino.Text = "Localidad Destino:";
            this.labelLocalidadDestino.UseWaitCursor = true;
            this.labelLocalidadDestino.Click += new System.EventHandler(this.labelLocalidadDestino_Click);
            // 
            // cmbCDDestino
            // 
            this.cmbCDDestino.FormattingEnabled = true;
            this.cmbCDDestino.Location = new System.Drawing.Point(506, 107);
            this.cmbCDDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCDDestino.Name = "cmbCDDestino";
            this.cmbCDDestino.Size = new System.Drawing.Size(132, 28);
            this.cmbCDDestino.TabIndex = 8;
            this.cmbCDDestino.UseWaitCursor = true;
            this.cmbCDDestino.SelectedIndexChanged += new System.EventHandler(this.cmbCDDestino_SelectedIndexChanged);
            // 
            // labelCDOrigen
            // 
            this.labelCDOrigen.AutoSize = true;
            this.labelCDOrigen.Location = new System.Drawing.Point(98, 49);
            this.labelCDOrigen.Name = "labelCDOrigen";
            this.labelCDOrigen.Size = new System.Drawing.Size(87, 20);
            this.labelCDOrigen.TabIndex = 6;
            this.labelCDOrigen.Text = "CD Origen:";
            this.labelCDOrigen.UseWaitCursor = true;
            this.labelCDOrigen.Click += new System.EventHandler(this.labelCDOrigen_Click);
            // 
            // groupServicioTransporte
            // 
            this.groupServicioTransporte.Controls.Add(this.labelMuestraTipoArrendamiento);
            this.groupServicioTransporte.Controls.Add(this.cmbServicio);
            this.groupServicioTransporte.Controls.Add(this.labelTipoArrendamiento);
            this.groupServicioTransporte.Controls.Add(this.labelServicio);
            this.groupServicioTransporte.Location = new System.Drawing.Point(14, 404);
            this.groupServicioTransporte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupServicioTransporte.Name = "groupServicioTransporte";
            this.groupServicioTransporte.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupServicioTransporte.Size = new System.Drawing.Size(691, 87);
            this.groupServicioTransporte.TabIndex = 9;
            this.groupServicioTransporte.TabStop = false;
            this.groupServicioTransporte.Text = "Servicio de Transporte";
            this.groupServicioTransporte.UseWaitCursor = true;
            this.groupServicioTransporte.Enter += new System.EventHandler(this.groupServicioTransporte_Enter);
            // 
            // labelMuestraTipoArrendamiento
            // 
            this.labelMuestraTipoArrendamiento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelMuestraTipoArrendamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMuestraTipoArrendamiento.Location = new System.Drawing.Point(498, 36);
            this.labelMuestraTipoArrendamiento.Name = "labelMuestraTipoArrendamiento";
            this.labelMuestraTipoArrendamiento.Size = new System.Drawing.Size(140, 27);
            this.labelMuestraTipoArrendamiento.TabIndex = 17;
            this.labelMuestraTipoArrendamiento.UseWaitCursor = true;
            this.labelMuestraTipoArrendamiento.Click += new System.EventHandler(this.labelMuestraTipoArrendamiento_Click);
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(159, 35);
            this.cmbServicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(134, 28);
            this.cmbServicio.TabIndex = 7;
            this.cmbServicio.UseWaitCursor = true;
            this.cmbServicio.SelectedIndexChanged += new System.EventHandler(this.cmbServicio_SelectedIndexChanged);
            // 
            // labelTipoArrendamiento
            // 
            this.labelTipoArrendamiento.AutoSize = true;
            this.labelTipoArrendamiento.Location = new System.Drawing.Point(320, 38);
            this.labelTipoArrendamiento.Name = "labelTipoArrendamiento";
            this.labelTipoArrendamiento.Size = new System.Drawing.Size(172, 20);
            this.labelTipoArrendamiento.TabIndex = 3;
            this.labelTipoArrendamiento.Text = "Tipo de arrendamiento:";
            this.labelTipoArrendamiento.UseWaitCursor = true;
            this.labelTipoArrendamiento.Click += new System.EventHandler(this.labelTipoArrendamiento_Click);
            // 
            // labelServicio
            // 
            this.labelServicio.AutoSize = true;
            this.labelServicio.Location = new System.Drawing.Point(78, 38);
            this.labelServicio.Name = "labelServicio";
            this.labelServicio.Size = new System.Drawing.Size(68, 20);
            this.labelServicio.TabIndex = 1;
            this.labelServicio.Text = "Servicio:";
            this.labelServicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelServicio.UseWaitCursor = true;
            this.labelServicio.Click += new System.EventHandler(this.labelServicio_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(596, 527);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 31);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.UseWaitCursor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(443, 527);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 31);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.UseWaitCursor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupListadoEncomiendas
            // 
            this.groupListadoEncomiendas.Controls.Add(this.listViewEncomiendas);
            this.groupListadoEncomiendas.Location = new System.Drawing.Point(14, 195);
            this.groupListadoEncomiendas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupListadoEncomiendas.Name = "groupListadoEncomiendas";
            this.groupListadoEncomiendas.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupListadoEncomiendas.Size = new System.Drawing.Size(691, 174);
            this.groupListadoEncomiendas.TabIndex = 29;
            this.groupListadoEncomiendas.TabStop = false;
            this.groupListadoEncomiendas.Text = "Listado de encomiendas";
            this.groupListadoEncomiendas.UseWaitCursor = true;
            this.groupListadoEncomiendas.Enter += new System.EventHandler(this.groupListadoEncomiendas_Enter);
            // 
            // listViewEncomiendas
            // 
            this.listViewEncomiendas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewEncomiendas.HideSelection = false;
            this.listViewEncomiendas.Location = new System.Drawing.Point(24, 27);
            this.listViewEncomiendas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewEncomiendas.Name = "listViewEncomiendas";
            this.listViewEncomiendas.Size = new System.Drawing.Size(649, 139);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 597);
            this.Controls.Add(this.groupListadoEncomiendas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupServicioTransporte);
            this.Controls.Add(this.groupDatosDespacho);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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