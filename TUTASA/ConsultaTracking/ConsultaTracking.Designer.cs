namespace TUTASA.Forms.CallCenter
{
    partial class ConsultaTracking
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
            this.groupBusquedaGuia = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtNroDeGuia = new System.Windows.Forms.TextBox();
            this.lblNroGuia = new System.Windows.Forms.Label();
            this.grpEstado = new System.Windows.Forms.GroupBox();
            this.lblCDDestino = new System.Windows.Forms.Label();
            this.lblCDDestinoTitulo = new System.Windows.Forms.Label();
            this.lblCDOrigen = new System.Windows.Forms.Label();
            this.lblCDOrigenTitulo = new System.Windows.Forms.Label();
            this.lblDestinatarioTitulo = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblClienteTitulo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCategoriaTitulo = new System.Windows.Forms.Label();
            this.lblGuia = new System.Windows.Forms.Label();
            this.lblNroGuiaTitulo = new System.Windows.Forms.Label();
            this.lblFechaUltimo = new System.Windows.Forms.Label();
            this.lblEstadoTitulo = new System.Windows.Forms.Label();
            this.lblEstadoActual = new System.Windows.Forms.Label();
            this.btnNuevaConsulta = new System.Windows.Forms.Button();
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.listViewHistorial = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBusquedaGuia.SuspendLayout();
            this.grpEstado.SuspendLayout();
            this.grpHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBusquedaGuia
            // 
            this.groupBusquedaGuia.AccessibleName = "grpBusqueda";
            this.groupBusquedaGuia.Controls.Add(this.btnLimpiar);
            this.groupBusquedaGuia.Controls.Add(this.btnConsultar);
            this.groupBusquedaGuia.Controls.Add(this.txtNroDeGuia);
            this.groupBusquedaGuia.Controls.Add(this.lblNroGuia);
            this.groupBusquedaGuia.Location = new System.Drawing.Point(11, 12);
            this.groupBusquedaGuia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBusquedaGuia.Name = "groupBusquedaGuia";
            this.groupBusquedaGuia.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBusquedaGuia.Size = new System.Drawing.Size(593, 61);
            this.groupBusquedaGuia.TabIndex = 0;
            this.groupBusquedaGuia.TabStop = false;
            this.groupBusquedaGuia.Text = "Busqueda de guia";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(488, 23);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 25);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(399, 23);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 25);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtNroDeGuia
            // 
            this.txtNroDeGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroDeGuia.Location = new System.Drawing.Point(143, 25);
            this.txtNroDeGuia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNroDeGuia.MaxLength = 20;
            this.txtNroDeGuia.Name = "txtNroDeGuia";
            this.txtNroDeGuia.Size = new System.Drawing.Size(236, 20);
            this.txtNroDeGuia.TabIndex = 1;
            // 
            // lblNroGuia
            // 
            this.lblNroGuia.AutoSize = true;
            this.lblNroGuia.Location = new System.Drawing.Point(10, 27);
            this.lblNroGuia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroGuia.Name = "lblNroGuia";
            this.lblNroGuia.Size = new System.Drawing.Size(123, 13);
            this.lblNroGuia.TabIndex = 0;
            this.lblNroGuia.Text = "N° de guía (tracking ID):";
            // 
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.lblCDDestino);
            this.grpEstado.Controls.Add(this.lblCDDestinoTitulo);
            this.grpEstado.Controls.Add(this.lblCDOrigen);
            this.grpEstado.Controls.Add(this.lblCDOrigenTitulo);
            this.grpEstado.Controls.Add(this.lblDestinatarioTitulo);
            this.grpEstado.Controls.Add(this.lblDestinatario);
            this.grpEstado.Controls.Add(this.lblCliente);
            this.grpEstado.Controls.Add(this.lblClienteTitulo);
            this.grpEstado.Controls.Add(this.lblCategoria);
            this.grpEstado.Controls.Add(this.lblCategoriaTitulo);
            this.grpEstado.Controls.Add(this.lblGuia);
            this.grpEstado.Controls.Add(this.lblNroGuiaTitulo);
            this.grpEstado.Controls.Add(this.lblFechaUltimo);
            this.grpEstado.Controls.Add(this.lblEstadoTitulo);
            this.grpEstado.Controls.Add(this.lblEstadoActual);
            this.grpEstado.Location = new System.Drawing.Point(11, 88);
            this.grpEstado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpEstado.Size = new System.Drawing.Size(593, 207);
            this.grpEstado.TabIndex = 0;
            this.grpEstado.TabStop = false;
            this.grpEstado.Text = "Estado actual de la guía";
            // 
            // lblCDDestino
            // 
            this.lblCDDestino.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCDDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCDDestino.Location = new System.Drawing.Point(344, 98);
            this.lblCDDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCDDestino.Name = "lblCDDestino";
            this.lblCDDestino.Size = new System.Drawing.Size(165, 18);
            this.lblCDDestino.TabIndex = 14;
            // 
            // lblCDDestinoTitulo
            // 
            this.lblCDDestinoTitulo.AutoSize = true;
            this.lblCDDestinoTitulo.Location = new System.Drawing.Point(286, 98);
            this.lblCDDestinoTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCDDestinoTitulo.Name = "lblCDDestinoTitulo";
            this.lblCDDestinoTitulo.Size = new System.Drawing.Size(46, 13);
            this.lblCDDestinoTitulo.TabIndex = 13;
            this.lblCDDestinoTitulo.Text = "Destino:";
            // 
            // lblCDOrigen
            // 
            this.lblCDOrigen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCDOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCDOrigen.Location = new System.Drawing.Point(344, 60);
            this.lblCDOrigen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCDOrigen.Name = "lblCDOrigen";
            this.lblCDOrigen.Size = new System.Drawing.Size(165, 18);
            this.lblCDOrigen.TabIndex = 12;
            // 
            // lblCDOrigenTitulo
            // 
            this.lblCDOrigenTitulo.AutoSize = true;
            this.lblCDOrigenTitulo.Location = new System.Drawing.Point(286, 61);
            this.lblCDOrigenTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCDOrigenTitulo.Name = "lblCDOrigenTitulo";
            this.lblCDOrigenTitulo.Size = new System.Drawing.Size(41, 13);
            this.lblCDOrigenTitulo.TabIndex = 11;
            this.lblCDOrigenTitulo.Text = "Origen:";
            // 
            // lblDestinatarioTitulo
            // 
            this.lblDestinatarioTitulo.AutoSize = true;
            this.lblDestinatarioTitulo.Location = new System.Drawing.Point(13, 179);
            this.lblDestinatarioTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinatarioTitulo.Name = "lblDestinatarioTitulo";
            this.lblDestinatarioTitulo.Size = new System.Drawing.Size(66, 13);
            this.lblDestinatarioTitulo.TabIndex = 9;
            this.lblDestinatarioTitulo.Text = "Destinatario:";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDestinatario.Location = new System.Drawing.Point(91, 178);
            this.lblDestinatario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(165, 18);
            this.lblDestinatario.TabIndex = 10;
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCliente.Location = new System.Drawing.Point(91, 139);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(165, 18);
            this.lblCliente.TabIndex = 9;
            // 
            // lblClienteTitulo
            // 
            this.lblClienteTitulo.AutoSize = true;
            this.lblClienteTitulo.Location = new System.Drawing.Point(13, 139);
            this.lblClienteTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteTitulo.Name = "lblClienteTitulo";
            this.lblClienteTitulo.Size = new System.Drawing.Size(42, 13);
            this.lblClienteTitulo.TabIndex = 8;
            this.lblClienteTitulo.Text = "Cliente:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategoria.Location = new System.Drawing.Point(91, 98);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(165, 18);
            this.lblCategoria.TabIndex = 7;
            // 
            // lblCategoriaTitulo
            // 
            this.lblCategoriaTitulo.AutoSize = true;
            this.lblCategoriaTitulo.Location = new System.Drawing.Point(13, 99);
            this.lblCategoriaTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoriaTitulo.Name = "lblCategoriaTitulo";
            this.lblCategoriaTitulo.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaTitulo.TabIndex = 6;
            this.lblCategoriaTitulo.Text = "Categoria:";
            this.lblCategoriaTitulo.Click += new System.EventHandler(this.lblCategoriaTitulo_Click);
            // 
            // lblGuia
            // 
            this.lblGuia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblGuia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGuia.Location = new System.Drawing.Point(91, 61);
            this.lblGuia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(165, 18);
            this.lblGuia.TabIndex = 5;
            // 
            // lblNroGuiaTitulo
            // 
            this.lblNroGuiaTitulo.AutoSize = true;
            this.lblNroGuiaTitulo.Location = new System.Drawing.Point(13, 61);
            this.lblNroGuiaTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroGuiaTitulo.Name = "lblNroGuiaTitulo";
            this.lblNroGuiaTitulo.Size = new System.Drawing.Size(62, 13);
            this.lblNroGuiaTitulo.TabIndex = 4;
            this.lblNroGuiaTitulo.Text = "N° de guía:";
            // 
            // lblFechaUltimo
            // 
            this.lblFechaUltimo.AutoSize = true;
            this.lblFechaUltimo.Location = new System.Drawing.Point(310, 23);
            this.lblFechaUltimo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaUltimo.Name = "lblFechaUltimo";
            this.lblFechaUltimo.Size = new System.Drawing.Size(0, 13);
            this.lblFechaUltimo.TabIndex = 3;
            // 
            // lblEstadoTitulo
            // 
            this.lblEstadoTitulo.AutoSize = true;
            this.lblEstadoTitulo.Location = new System.Drawing.Point(10, 23);
            this.lblEstadoTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoTitulo.Name = "lblEstadoTitulo";
            this.lblEstadoTitulo.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoTitulo.TabIndex = 1;
            this.lblEstadoTitulo.Text = "Estado:";
            // 
            // lblEstadoActual
            // 
            this.lblEstadoActual.BackColor = System.Drawing.Color.LightGreen;
            this.lblEstadoActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstadoActual.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoActual.Location = new System.Drawing.Point(91, 23);
            this.lblEstadoActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoActual.Name = "lblEstadoActual";
            this.lblEstadoActual.Size = new System.Drawing.Size(165, 27);
            this.lblEstadoActual.TabIndex = 0;
            this.lblEstadoActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstadoActual.Click += new System.EventHandler(this.lblEstadoActual_Click);
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.Location = new System.Drawing.Point(253, 467);
            this.btnNuevaConsulta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(123, 28);
            this.btnNuevaConsulta.TabIndex = 2;
            this.btnNuevaConsulta.Text = "Nueva Consulta";
            this.btnNuevaConsulta.UseVisualStyleBackColor = true;
            this.btnNuevaConsulta.Click += new System.EventHandler(this.btnNuevaConsulta_Click);
            // 
            // grpHistorial
            // 
            this.grpHistorial.Controls.Add(this.listViewHistorial);
            this.grpHistorial.Location = new System.Drawing.Point(11, 309);
            this.grpHistorial.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpHistorial.Name = "grpHistorial";
            this.grpHistorial.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpHistorial.Size = new System.Drawing.Size(593, 140);
            this.grpHistorial.TabIndex = 1;
            this.grpHistorial.TabStop = false;
            this.grpHistorial.Text = "Historial de eventos";
            // 
            // listViewHistorial
            // 
            this.listViewHistorial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewHistorial.Enabled = false;
            this.listViewHistorial.FullRowSelect = true;
            this.listViewHistorial.GridLines = true;
            this.listViewHistorial.HideSelection = false;
            this.listViewHistorial.Location = new System.Drawing.Point(16, 33);
            this.listViewHistorial.Name = "listViewHistorial";
            this.listViewHistorial.Size = new System.Drawing.Size(560, 88);
            this.listViewHistorial.TabIndex = 3;
            this.listViewHistorial.UseCompatibleStateImageBehavior = false;
            this.listViewHistorial.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hora";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ubicacion";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estado";
            this.columnHeader4.Width = 200;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(539, 467);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 28);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultaTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 503);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevaConsulta);
            this.Controls.Add(this.grpHistorial);
            this.Controls.Add(this.grpEstado);
            this.Controls.Add(this.groupBusquedaGuia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimizeBox = false;
            this.Name = "ConsultaTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA - Consultar estado e historial de guia";
            this.Load += new System.EventHandler(this.frmConsultaTrackingCallCenter_Load);
            this.groupBusquedaGuia.ResumeLayout(false);
            this.groupBusquedaGuia.PerformLayout();
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            this.grpHistorial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBusquedaGuia;
        private System.Windows.Forms.Label lblNroGuia;
        private System.Windows.Forms.TextBox txtNroDeGuia;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.Button btnNuevaConsulta;
        private System.Windows.Forms.Label lblCDDestino;
        private System.Windows.Forms.Label lblCDDestinoTitulo;
        private System.Windows.Forms.Label lblCDOrigen;
        private System.Windows.Forms.Label lblCDOrigenTitulo;
        private System.Windows.Forms.Label lblDestinatarioTitulo;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblClienteTitulo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCategoriaTitulo;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.Label lblNroGuiaTitulo;
        private System.Windows.Forms.Label lblFechaUltimo;
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.Label lblEstadoActual;
        private System.Windows.Forms.GroupBox grpHistorial;
        private System.Windows.Forms.ListView listViewHistorial;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSalir;
    }
}