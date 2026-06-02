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
            this.txtNroGuia = new System.Windows.Forms.TextBox();
            this.lblNroGuia = new System.Windows.Forms.Label();
            this.grpEstado = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCDDestinoTitulo = new System.Windows.Forms.Label();
            this.lblCDOrigen = new System.Windows.Forms.Label();
            this.lblCDOrigenTitulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGuia = new System.Windows.Forms.Label();
            this.lblNroGuiaTitulo = new System.Windows.Forms.Label();
            this.lblFechaUltimo = new System.Windows.Forms.Label();
            this.lblEstadoTitulo = new System.Windows.Forms.Label();
            this.lblEstadoActual = new System.Windows.Forms.Label();
            this.btnNuevaConsulta = new System.Windows.Forms.Button();
            this.grpHistorial = new System.Windows.Forms.GroupBox();
            this.lvGuias = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBusquedaGuia.Controls.Add(this.txtNroGuia);
            this.groupBusquedaGuia.Controls.Add(this.lblNroGuia);
            this.groupBusquedaGuia.Location = new System.Drawing.Point(11, 12);
            this.groupBusquedaGuia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBusquedaGuia.Name = "groupBusquedaGuia";
            this.groupBusquedaGuia.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBusquedaGuia.Size = new System.Drawing.Size(593, 61);
            this.groupBusquedaGuia.TabIndex = 0;
            this.groupBusquedaGuia.TabStop = false;
            this.groupBusquedaGuia.Text = "Busqueda de guia";
            this.groupBusquedaGuia.Enter += new System.EventHandler(this.groupBusquedaGuia_Enter);
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
            // txtNroGuia
            // 
            this.txtNroGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroGuia.Location = new System.Drawing.Point(143, 25);
            this.txtNroGuia.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNroGuia.MaxLength = 20;
            this.txtNroGuia.Name = "txtNroGuia";
            this.txtNroGuia.Size = new System.Drawing.Size(236, 20);
            this.txtNroGuia.TabIndex = 1;
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
            this.lblNroGuia.Click += new System.EventHandler(this.lblNroGuia_Click);
            // 
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.label11);
            this.grpEstado.Controls.Add(this.lblCDDestinoTitulo);
            this.grpEstado.Controls.Add(this.lblCDOrigen);
            this.grpEstado.Controls.Add(this.lblCDOrigenTitulo);
            this.grpEstado.Controls.Add(this.label6);
            this.grpEstado.Controls.Add(this.label8);
            this.grpEstado.Controls.Add(this.label7);
            this.grpEstado.Controls.Add(this.label5);
            this.grpEstado.Controls.Add(this.lblCategoria);
            this.grpEstado.Controls.Add(this.label4);
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
            this.grpEstado.Enter += new System.EventHandler(this.grpEstado_Enter);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(344, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 18);
            this.label11.TabIndex = 14;
            // 
            // lblCDDestinoTitulo
            // 
            this.lblCDDestinoTitulo.AutoSize = true;
            this.lblCDDestinoTitulo.Location = new System.Drawing.Point(281, 99);
            this.lblCDDestinoTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCDDestinoTitulo.Name = "lblCDDestinoTitulo";
            this.lblCDDestinoTitulo.Size = new System.Drawing.Size(43, 13);
            this.lblCDDestinoTitulo.TabIndex = 13;
            this.lblCDDestinoTitulo.Text = "Destino";
            this.lblCDDestinoTitulo.Click += new System.EventHandler(this.lblCDDestinoTitulo_Click);
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
            this.lblCDOrigen.Click += new System.EventHandler(this.lblCDOrigen_Click);
            // 
            // lblCDOrigenTitulo
            // 
            this.lblCDOrigenTitulo.AutoSize = true;
            this.lblCDOrigenTitulo.Location = new System.Drawing.Point(281, 61);
            this.lblCDOrigenTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCDOrigenTitulo.Name = "lblCDOrigenTitulo";
            this.lblCDOrigenTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblCDOrigenTitulo.TabIndex = 11;
            this.lblCDOrigenTitulo.Text = "Origen";
            this.lblCDOrigenTitulo.Click += new System.EventHandler(this.lblCDOrigenTitulo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Destinatario";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(76, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 18);
            this.label8.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(76, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 18);
            this.label7.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cliente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategoria.Location = new System.Drawing.Point(76, 98);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(165, 18);
            this.lblCategoria.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGuia
            // 
            this.lblGuia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblGuia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGuia.Location = new System.Drawing.Point(76, 60);
            this.lblGuia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(165, 18);
            this.lblGuia.TabIndex = 5;
            this.lblGuia.Click += new System.EventHandler(this.lblGuia_Click);
            // 
            // lblNroGuiaTitulo
            // 
            this.lblNroGuiaTitulo.AutoSize = true;
            this.lblNroGuiaTitulo.Location = new System.Drawing.Point(13, 61);
            this.lblNroGuiaTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroGuiaTitulo.Name = "lblNroGuiaTitulo";
            this.lblNroGuiaTitulo.Size = new System.Drawing.Size(59, 13);
            this.lblNroGuiaTitulo.TabIndex = 4;
            this.lblNroGuiaTitulo.Text = "N° de guía";
            this.lblNroGuiaTitulo.Click += new System.EventHandler(this.lblNroGuiaTitulo_Click);
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
            this.lblEstadoTitulo.Click += new System.EventHandler(this.lblEstadoTitulo_Click);
            // 
            // lblEstadoActual
            // 
            this.lblEstadoActual.BackColor = System.Drawing.Color.LightGreen;
            this.lblEstadoActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstadoActual.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoActual.Location = new System.Drawing.Point(76, 23);
            this.lblEstadoActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoActual.Name = "lblEstadoActual";
            this.lblEstadoActual.Size = new System.Drawing.Size(165, 27);
            this.lblEstadoActual.TabIndex = 0;
            this.lblEstadoActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstadoActual.Click += new System.EventHandler(this.lblEstadoActual_Click);
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.Location = new System.Drawing.Point(266, 454);
            this.btnNuevaConsulta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(123, 41);
            this.btnNuevaConsulta.TabIndex = 2;
            this.btnNuevaConsulta.Text = "Nueva Consulta";
            this.btnNuevaConsulta.UseVisualStyleBackColor = true;
            this.btnNuevaConsulta.Click += new System.EventHandler(this.btnNuevaConsulta_Click);
            // 
            // grpHistorial
            // 
            this.grpHistorial.Controls.Add(this.lvGuias);
            this.grpHistorial.Location = new System.Drawing.Point(11, 309);
            this.grpHistorial.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpHistorial.Name = "grpHistorial";
            this.grpHistorial.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpHistorial.Size = new System.Drawing.Size(593, 140);
            this.grpHistorial.TabIndex = 1;
            this.grpHistorial.TabStop = false;
            this.grpHistorial.Text = "Historial de eventos";
            // 
            // lvGuias
            // 
            this.lvGuias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvGuias.Enabled = false;
            this.lvGuias.FullRowSelect = true;
            this.lvGuias.GridLines = true;
            this.lvGuias.HideSelection = false;
            this.lvGuias.Location = new System.Drawing.Point(16, 33);
            this.lvGuias.Name = "lvGuias";
            this.lvGuias.Size = new System.Drawing.Size(560, 88);
            this.lvGuias.TabIndex = 3;
            this.lvGuias.UseCompatibleStateImageBehavior = false;
            this.lvGuias.View = System.Windows.Forms.View.Details;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 454);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ConsultaTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 487);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.TextBox txtNroGuia;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.Button btnNuevaConsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCDDestinoTitulo;
        private System.Windows.Forms.Label lblCDOrigen;
        private System.Windows.Forms.Label lblCDOrigenTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.Label lblNroGuiaTitulo;
        private System.Windows.Forms.Label lblFechaUltimo;
        private System.Windows.Forms.Label lblEstadoTitulo;
        private System.Windows.Forms.Label lblEstadoActual;
        private System.Windows.Forms.GroupBox grpHistorial;
        private System.Windows.Forms.ListView lvGuias;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
    }
}