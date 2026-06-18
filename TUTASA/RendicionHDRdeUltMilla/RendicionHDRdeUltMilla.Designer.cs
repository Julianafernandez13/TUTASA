namespace TUTASA.Pantallas
{
    partial class frmRendicionHDRdeUltMilla
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
            this.groupRendicion = new System.Windows.Forms.GroupBox();
            this.cmbNroHDR = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.radioBtnNoCumplida = new System.Windows.Forms.RadioButton();
            this.radioBtnCumplida = new System.Windows.Forms.RadioButton();
            this.lblNroHDR = new System.Windows.Forms.Label();
            this.groupResumenHDRRendidas = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.listViewHDRRendidas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpFletero = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblDNIFletero = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblMuestraFletero = new System.Windows.Forms.Label();
            this.lblFleteroSeleccionado = new System.Windows.Forms.Label();
            this.groupHDRaEntregar = new System.Windows.Forms.GroupBox();
            this.listViewHDRaEntregar = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupRendicion.SuspendLayout();
            this.groupResumenHDRRendidas.SuspendLayout();
            this.grpFletero.SuspendLayout();
            this.groupHDRaEntregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupRendicion
            // 
            this.groupRendicion.Controls.Add(this.cmbNroHDR);
            this.groupRendicion.Controls.Add(this.btnAceptar);
            this.groupRendicion.Controls.Add(this.radioBtnNoCumplida);
            this.groupRendicion.Controls.Add(this.radioBtnCumplida);
            this.groupRendicion.Controls.Add(this.lblNroHDR);
            this.groupRendicion.Location = new System.Drawing.Point(12, 192);
            this.groupRendicion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupRendicion.Name = "groupRendicion";
            this.groupRendicion.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupRendicion.Size = new System.Drawing.Size(819, 182);
            this.groupRendicion.TabIndex = 1;
            this.groupRendicion.TabStop = false;
            this.groupRendicion.Text = "Rendicion";
            // 
            // cmbNroHDR
            // 
            this.cmbNroHDR.Items.AddRange(new object[] {
            "Todas",
            "Empresa A",
            "Empresa B",
            "Empresa C"});
            this.cmbNroHDR.Location = new System.Drawing.Point(123, 39);
            this.cmbNroHDR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNroHDR.Name = "cmbNroHDR";
            this.cmbNroHDR.Size = new System.Drawing.Size(321, 28);
            this.cmbNroHDR.TabIndex = 27;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(346, 112);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(129, 49);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // radioBtnNoCumplida
            // 
            this.radioBtnNoCumplida.AutoSize = true;
            this.radioBtnNoCumplida.Location = new System.Drawing.Point(622, 40);
            this.radioBtnNoCumplida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnNoCumplida.Name = "radioBtnNoCumplida";
            this.radioBtnNoCumplida.Size = new System.Drawing.Size(121, 24);
            this.radioBtnNoCumplida.TabIndex = 21;
            this.radioBtnNoCumplida.Text = "No cumplida";
            // 
            // radioBtnCumplida
            // 
            this.radioBtnCumplida.AutoSize = true;
            this.radioBtnCumplida.Location = new System.Drawing.Point(480, 40);
            this.radioBtnCumplida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnCumplida.Name = "radioBtnCumplida";
            this.radioBtnCumplida.Size = new System.Drawing.Size(100, 24);
            this.radioBtnCumplida.TabIndex = 20;
            this.radioBtnCumplida.Text = "Cumplida";
            // 
            // lblNroHDR
            // 
            this.lblNroHDR.AutoSize = true;
            this.lblNroHDR.Location = new System.Drawing.Point(16, 42);
            this.lblNroHDR.Name = "lblNroHDR";
            this.lblNroHDR.Size = new System.Drawing.Size(100, 20);
            this.lblNroHDR.TabIndex = 0;
            this.lblNroHDR.Text = "Nro de HDR:";
            // 
            // groupResumenHDRRendidas
            // 
            this.groupResumenHDRRendidas.Controls.Add(this.btnQuitar);
            this.groupResumenHDRRendidas.Controls.Add(this.listViewHDRRendidas);
            this.groupResumenHDRRendidas.Location = new System.Drawing.Point(12, 395);
            this.groupResumenHDRRendidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupResumenHDRRendidas.Name = "groupResumenHDRRendidas";
            this.groupResumenHDRRendidas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupResumenHDRRendidas.Size = new System.Drawing.Size(819, 269);
            this.groupResumenHDRRendidas.TabIndex = 22;
            this.groupResumenHDRRendidas.TabStop = false;
            this.groupResumenHDRRendidas.Text = "Resumen de HDR rendidas";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(687, 202);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(112, 49);
            this.btnQuitar.TabIndex = 30;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // listViewHDRRendidas
            // 
            this.listViewHDRRendidas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader11,
            this.columnHeader2});
            this.listViewHDRRendidas.FullRowSelect = true;
            this.listViewHDRRendidas.GridLines = true;
            this.listViewHDRRendidas.HideSelection = false;
            this.listViewHDRRendidas.Location = new System.Drawing.Point(14, 28);
            this.listViewHDRRendidas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewHDRRendidas.Name = "listViewHDRRendidas";
            this.listViewHDRRendidas.Size = new System.Drawing.Size(785, 153);
            this.listViewHDRRendidas.TabIndex = 2;
            this.listViewHDRRendidas.UseCompatibleStateImageBehavior = false;
            this.listViewHDRRendidas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nro HDR";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cliente";
            this.columnHeader3.Width = 142;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Localidad";
            this.columnHeader4.Width = 132;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dirección";
            this.columnHeader5.Width = 164;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Cumplida S/N";
            this.columnHeader11.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Entrega / Retiro";
            this.columnHeader2.Width = 132;
            // 
            // grpFletero
            // 
            this.grpFletero.Controls.Add(this.btnSeleccionar);
            this.grpFletero.Controls.Add(this.lblDNIFletero);
            this.grpFletero.Controls.Add(this.txtDNI);
            this.grpFletero.Location = new System.Drawing.Point(22, 11);
            this.grpFletero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFletero.Name = "grpFletero";
            this.grpFletero.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpFletero.Size = new System.Drawing.Size(809, 98);
            this.grpFletero.TabIndex = 23;
            this.grpFletero.TabStop = false;
            this.grpFletero.Text = "Identificación del fletero";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(490, 43);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(129, 34);
            this.btnSeleccionar.TabIndex = 24;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblDNIFletero
            // 
            this.lblDNIFletero.AutoSize = true;
            this.lblDNIFletero.Location = new System.Drawing.Point(34, 50);
            this.lblDNIFletero.Name = "lblDNIFletero";
            this.lblDNIFletero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDNIFletero.Size = new System.Drawing.Size(104, 20);
            this.lblDNIFletero.TabIndex = 0;
            this.lblDNIFletero.Text = "Ingresar DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(174, 47);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(223, 26);
            this.txtDNI.TabIndex = 0;
            // 
            // lblMuestraFletero
            // 
            this.lblMuestraFletero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMuestraFletero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMuestraFletero.Location = new System.Drawing.Point(196, 128);
            this.lblMuestraFletero.Name = "lblMuestraFletero";
            this.lblMuestraFletero.Size = new System.Drawing.Size(260, 22);
            this.lblMuestraFletero.TabIndex = 26;
            // 
            // lblFleteroSeleccionado
            // 
            this.lblFleteroSeleccionado.AutoSize = true;
            this.lblFleteroSeleccionado.Location = new System.Drawing.Point(32, 129);
            this.lblFleteroSeleccionado.Name = "lblFleteroSeleccionado";
            this.lblFleteroSeleccionado.Size = new System.Drawing.Size(160, 20);
            this.lblFleteroSeleccionado.TabIndex = 27;
            this.lblFleteroSeleccionado.Text = "Fletero seleccionado:";
            // 
            // groupHDRaEntregar
            // 
            this.groupHDRaEntregar.Controls.Add(this.listViewHDRaEntregar);
            this.groupHDRaEntregar.Location = new System.Drawing.Point(12, 682);
            this.groupHDRaEntregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupHDRaEntregar.Name = "groupHDRaEntregar";
            this.groupHDRaEntregar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupHDRaEntregar.Size = new System.Drawing.Size(819, 219);
            this.groupHDRaEntregar.TabIndex = 31;
            this.groupHDRaEntregar.TabStop = false;
            this.groupHDRaEntregar.Text = "Hojas de ruta a entregar al fletero (informativo)";
            // 
            // listViewHDRaEntregar
            // 
            this.listViewHDRaEntregar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listViewHDRaEntregar.Enabled = true;
            this.listViewHDRaEntregar.FullRowSelect = true;
            this.listViewHDRaEntregar.GridLines = true;
            this.listViewHDRaEntregar.HideSelection = false;
            this.listViewHDRaEntregar.Location = new System.Drawing.Point(14, 28);
            this.listViewHDRaEntregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewHDRaEntregar.Name = "listViewHDRaEntregar";
            this.listViewHDRaEntregar.Size = new System.Drawing.Size(785, 153);
            this.listViewHDRaEntregar.TabIndex = 2;
            this.listViewHDRaEntregar.UseCompatibleStateImageBehavior = false;
            this.listViewHDRaEntregar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nro HDR";
            this.columnHeader6.Width = 145;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Cliente";
            this.columnHeader7.Width = 159;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Localidad";
            this.columnHeader8.Width = 161;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Direccion";
            this.columnHeader9.Width = 180;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Entrega/Retiro";
            this.columnHeader10.Width = 135;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(556, 951);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 38);
            this.btnConfirmar.TabIndex = 32;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(719, 951);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 38);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // RendicionHDRdeUltMilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(848, 1050);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupHDRaEntregar);
            this.Controls.Add(this.lblMuestraFletero);
            this.Controls.Add(this.lblFleteroSeleccionado);
            this.Controls.Add(this.grpFletero);
            this.Controls.Add(this.groupResumenHDRRendidas);
            this.Controls.Add(this.groupRendicion);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RendicionHDRdeUltMilla";
            this.Text = "Rendicion de HDR Ultima Milla";
            this.Load += new System.EventHandler(this.RendicionHDRdeUltMilla_Load);
            this.groupRendicion.ResumeLayout(false);
            this.groupRendicion.PerformLayout();
            this.groupResumenHDRRendidas.ResumeLayout(false);
            this.grpFletero.ResumeLayout(false);
            this.grpFletero.PerformLayout();
            this.groupHDRaEntregar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupRendicion;
        private System.Windows.Forms.Label lblNroHDR;
        private System.Windows.Forms.RadioButton radioBtnNoCumplida;
        private System.Windows.Forms.RadioButton radioBtnCumplida;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupResumenHDRRendidas;
        private System.Windows.Forms.GroupBox grpFletero;
        private System.Windows.Forms.Label lblDNIFletero;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblFleteroSeleccionado;
        private System.Windows.Forms.Label lblMuestraFletero;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.GroupBox groupHDRaEntregar;
        private System.Windows.Forms.ListView listViewHDRaEntregar;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ComboBox cmbNroHDR;
        private System.Windows.Forms.ListView listViewHDRRendidas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}