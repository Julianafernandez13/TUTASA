namespace TUTASA.Forms.CallCenter
{
    partial class frmConsultaTracking
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtNroGuia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEstado = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGuia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.grpEstado.SuspendLayout();
            this.grpHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleName = "grpBusqueda";
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtNroGuia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(890, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de guia";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(732, 35);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 38);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(598, 35);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(128, 38);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtNroGuia
            // 
            this.txtNroGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroGuia.Location = new System.Drawing.Point(214, 38);
            this.txtNroGuia.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNroGuia.MaxLength = 20;
            this.txtNroGuia.Name = "txtNroGuia";
            this.txtNroGuia.Size = new System.Drawing.Size(352, 26);
            this.txtNroGuia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° de guía (tracking ID):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.label11);
            this.grpEstado.Controls.Add(this.label12);
            this.grpEstado.Controls.Add(this.label13);
            this.grpEstado.Controls.Add(this.label14);
            this.grpEstado.Controls.Add(this.label6);
            this.grpEstado.Controls.Add(this.label8);
            this.grpEstado.Controls.Add(this.label7);
            this.grpEstado.Controls.Add(this.label5);
            this.grpEstado.Controls.Add(this.lblCategoria);
            this.grpEstado.Controls.Add(this.label4);
            this.grpEstado.Controls.Add(this.lblGuia);
            this.grpEstado.Controls.Add(this.label3);
            this.grpEstado.Controls.Add(this.lblFechaUltimo);
            this.grpEstado.Controls.Add(this.lblEstadoTitulo);
            this.grpEstado.Controls.Add(this.lblEstadoActual);
            this.grpEstado.Location = new System.Drawing.Point(16, 135);
            this.grpEstado.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpEstado.Size = new System.Drawing.Size(890, 318);
            this.grpEstado.TabIndex = 0;
            this.grpEstado.TabStop = false;
            this.grpEstado.Text = "Estado actual de la guía";
            this.grpEstado.Enter += new System.EventHandler(this.grpEstado_Enter);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(516, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(246, 27);
            this.label11.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(422, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Destino";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(516, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(246, 27);
            this.label13.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(422, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Origen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Destinatario";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(114, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 27);
            this.label8.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(114, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 27);
            this.label7.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cliente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategoria.Location = new System.Drawing.Point(114, 151);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(246, 27);
            this.lblCategoria.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGuia
            // 
            this.lblGuia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblGuia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGuia.Location = new System.Drawing.Point(114, 92);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(246, 27);
            this.lblGuia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "N° de guía";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFechaUltimo
            // 
            this.lblFechaUltimo.AutoSize = true;
            this.lblFechaUltimo.Location = new System.Drawing.Point(465, 35);
            this.lblFechaUltimo.Name = "lblFechaUltimo";
            this.lblFechaUltimo.Size = new System.Drawing.Size(0, 20);
            this.lblFechaUltimo.TabIndex = 3;
            // 
            // lblEstadoTitulo
            // 
            this.lblEstadoTitulo.AutoSize = true;
            this.lblEstadoTitulo.Location = new System.Drawing.Point(15, 35);
            this.lblEstadoTitulo.Name = "lblEstadoTitulo";
            this.lblEstadoTitulo.Size = new System.Drawing.Size(64, 20);
            this.lblEstadoTitulo.TabIndex = 1;
            this.lblEstadoTitulo.Text = "Estado:";
            // 
            // lblEstadoActual
            // 
            this.lblEstadoActual.BackColor = System.Drawing.Color.LightGreen;
            this.lblEstadoActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEstadoActual.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoActual.Location = new System.Drawing.Point(114, 35);
            this.lblEstadoActual.Name = "lblEstadoActual";
            this.lblEstadoActual.Size = new System.Drawing.Size(246, 40);
            this.lblEstadoActual.TabIndex = 0;
            this.lblEstadoActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstadoActual.Click += new System.EventHandler(this.lblEstadoActual_Click);
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.Location = new System.Drawing.Point(399, 698);
            this.btnNuevaConsulta.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(184, 63);
            this.btnNuevaConsulta.TabIndex = 2;
            this.btnNuevaConsulta.Text = "Nueva Consulta";
            this.btnNuevaConsulta.UseVisualStyleBackColor = true;
            this.btnNuevaConsulta.Click += new System.EventHandler(this.btnNuevaConsulta_Click);
            // 
            // grpHistorial
            // 
            this.grpHistorial.Controls.Add(this.lvGuias);
            this.grpHistorial.Location = new System.Drawing.Point(16, 475);
            this.grpHistorial.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpHistorial.Name = "grpHistorial";
            this.grpHistorial.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpHistorial.Size = new System.Drawing.Size(890, 215);
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
            this.lvGuias.Location = new System.Drawing.Point(24, 51);
            this.lvGuias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvGuias.Name = "lvGuias";
            this.lvGuias.Size = new System.Drawing.Size(838, 133);
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
            this.button1.Location = new System.Drawing.Point(810, 698);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmConsultaTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 772);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevaConsulta);
            this.Controls.Add(this.grpHistorial);
            this.Controls.Add(this.grpEstado);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimizeBox = false;
            this.Name = "frmConsultaTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA - Consultar estado e historial de guia";
            this.Load += new System.EventHandler(this.frmConsultaTrackingCallCenter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            this.grpHistorial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroGuia;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.Button btnNuevaConsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.Label label3;
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