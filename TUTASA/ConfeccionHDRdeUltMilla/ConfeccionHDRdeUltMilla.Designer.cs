namespace TUTASA.Pantallas
{
    partial class ConfeccionHDRdeUltMilla
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
            this.groupBusquedaGuias = new System.Windows.Forms.GroupBox();
            this.cmbDomicilio = new System.Windows.Forms.ComboBox();
            this.labelDomicilio = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupSeleccionFletero = new System.Windows.Forms.GroupBox();
            this.cmbFleteros = new System.Windows.Forms.ComboBox();
            this.labelFletero = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listViewGuiasARutear = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSeleccionarGuiasRuteo = new System.Windows.Forms.Label();
            this.groupTipoConfeccion = new System.Windows.Forms.GroupBox();
            this.labelSeleccionaTipoHDR = new System.Windows.Forms.Label();
            this.radioBtnEntrega = new System.Windows.Forms.RadioButton();
            this.radioBtnRetiro = new System.Windows.Forms.RadioButton();
            this.groupBusquedaGuias.SuspendLayout();
            this.groupSeleccionFletero.SuspendLayout();
            this.groupTipoConfeccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBusquedaGuias
            // 
            this.groupBusquedaGuias.Controls.Add(this.cmbDomicilio);
            this.groupBusquedaGuias.Controls.Add(this.labelDomicilio);
            this.groupBusquedaGuias.Controls.Add(this.cmbLocalidad);
            this.groupBusquedaGuias.Controls.Add(this.labelLocalidad);
            this.groupBusquedaGuias.Controls.Add(this.btnBuscar);
            this.groupBusquedaGuias.Location = new System.Drawing.Point(16, 144);
            this.groupBusquedaGuias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBusquedaGuias.Name = "groupBusquedaGuias";
            this.groupBusquedaGuias.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBusquedaGuias.Size = new System.Drawing.Size(1104, 122);
            this.groupBusquedaGuias.TabIndex = 0;
            this.groupBusquedaGuias.TabStop = false;
            this.groupBusquedaGuias.Text = "Busqueda de Guías";
            // 
            // cmbDomicilio
            // 
            this.cmbDomicilio.Items.AddRange(new object[] {
            "Todas",
            "Empresa A",
            "Empresa B",
            "Empresa C"});
            this.cmbDomicilio.Location = new System.Drawing.Point(543, 56);
            this.cmbDomicilio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDomicilio.Name = "cmbDomicilio";
            this.cmbDomicilio.Size = new System.Drawing.Size(266, 28);
            this.cmbDomicilio.TabIndex = 12;
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Location = new System.Drawing.Point(461, 56);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(76, 20);
            this.labelDomicilio.TabIndex = 11;
            this.labelDomicilio.Text = "Domicilio:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.Items.AddRange(new object[] {
            "Todas",
            "Empresa A",
            "Empresa B",
            "Empresa C"});
            this.cmbLocalidad.Location = new System.Drawing.Point(124, 56);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(266, 28);
            this.cmbLocalidad.TabIndex = 10;
            this.cmbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidad_SelectedIndexChanged);
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(37, 56);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(81, 20);
            this.labelLocalidad.TabIndex = 9;
            this.labelLocalidad.Text = "Localidad:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(917, 55);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 29);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupSeleccionFletero
            // 
            this.groupSeleccionFletero.Controls.Add(this.cmbFleteros);
            this.groupSeleccionFletero.Controls.Add(this.labelFletero);
            this.groupSeleccionFletero.Location = new System.Drawing.Point(16, 505);
            this.groupSeleccionFletero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupSeleccionFletero.Name = "groupSeleccionFletero";
            this.groupSeleccionFletero.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupSeleccionFletero.Size = new System.Drawing.Size(1104, 149);
            this.groupSeleccionFletero.TabIndex = 11;
            this.groupSeleccionFletero.TabStop = false;
            this.groupSeleccionFletero.Text = "Seleccionar fletero disponible";
            // 
            // cmbFleteros
            // 
            this.cmbFleteros.Items.AddRange(new object[] {
            "Todas",
            "Empresa A",
            "Empresa B",
            "Empresa C"});
            this.cmbFleteros.Location = new System.Drawing.Point(124, 68);
            this.cmbFleteros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFleteros.Name = "cmbFleteros";
            this.cmbFleteros.Size = new System.Drawing.Size(266, 28);
            this.cmbFleteros.TabIndex = 13;
            this.cmbFleteros.SelectedIndexChanged += new System.EventHandler(this.cmbFleteros_SelectedIndexChanged);
            // 
            // labelFletero
            // 
            this.labelFletero.AutoSize = true;
            this.labelFletero.Location = new System.Drawing.Point(37, 71);
            this.labelFletero.Name = "labelFletero";
            this.labelFletero.Size = new System.Drawing.Size(63, 20);
            this.labelFletero.TabIndex = 10;
            this.labelFletero.Text = "Fletero:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(810, 662);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(109, 31);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(966, 662);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 31);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // listViewGuiasARutear
            // 
            this.listViewGuiasARutear.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader1});
            this.listViewGuiasARutear.HideSelection = false;
            this.listViewGuiasARutear.Location = new System.Drawing.Point(16, 312);
            this.listViewGuiasARutear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewGuiasARutear.Name = "listViewGuiasARutear";
            this.listViewGuiasARutear.Size = new System.Drawing.Size(1104, 163);
            this.listViewGuiasARutear.TabIndex = 3;
            this.listViewGuiasARutear.UseCompatibleStateImageBehavior = false;
            this.listViewGuiasARutear.FullRowSelect = true;
            this.listViewGuiasARutear.MultiSelect = true;
            this.listViewGuiasARutear.CheckBoxes = true;
            this.listViewGuiasARutear.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nro de guia";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Cliente";
            this.columnHeader8.Width = 171;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Dirección";
            this.columnHeader10.Width = 206;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Localidad";
            this.columnHeader11.Width = 189;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Categoria";
            this.columnHeader12.Width = 151;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Agencia";
            this.columnHeader1.Width = 335;
            // 
            // labelSeleccionarGuiasRuteo
            // 
            this.labelSeleccionarGuiasRuteo.AutoSize = true;
            this.labelSeleccionarGuiasRuteo.Location = new System.Drawing.Point(17, 289);
            this.labelSeleccionarGuiasRuteo.Name = "labelSeleccionarGuiasRuteo";
            this.labelSeleccionarGuiasRuteo.Size = new System.Drawing.Size(201, 20);
            this.labelSeleccionarGuiasRuteo.TabIndex = 37;
            this.labelSeleccionarGuiasRuteo.Text = "Seleccionar Guías a rutear:";
            // 
            // groupTipoConfeccion
            // 
            this.groupTipoConfeccion.Controls.Add(this.labelSeleccionaTipoHDR);
            this.groupTipoConfeccion.Controls.Add(this.radioBtnEntrega);
            this.groupTipoConfeccion.Controls.Add(this.radioBtnRetiro);
            this.groupTipoConfeccion.Location = new System.Drawing.Point(21, 12);
            this.groupTipoConfeccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupTipoConfeccion.Name = "groupTipoConfeccion";
            this.groupTipoConfeccion.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupTipoConfeccion.Size = new System.Drawing.Size(1104, 106);
            this.groupTipoConfeccion.TabIndex = 38;
            this.groupTipoConfeccion.TabStop = false;
            this.groupTipoConfeccion.Text = "Tipo de Confección";
            // 
            // labelSeleccionaTipoHDR
            // 
            this.labelSeleccionaTipoHDR.AutoSize = true;
            this.labelSeleccionaTipoHDR.Location = new System.Drawing.Point(74, 51);
            this.labelSeleccionaTipoHDR.Name = "labelSeleccionaTipoHDR";
            this.labelSeleccionaTipoHDR.Size = new System.Drawing.Size(291, 20);
            this.labelSeleccionaTipoHDR.TabIndex = 12;
            this.labelSeleccionaTipoHDR.Text = "Selecciona tipo de HDR a confeccionar:";
            // 
            // radioBtnEntrega
            // 
            this.radioBtnEntrega.Location = new System.Drawing.Point(406, 48);
            this.radioBtnEntrega.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnEntrega.Name = "radioBtnEntrega";
            this.radioBtnEntrega.Size = new System.Drawing.Size(126, 26);
            this.radioBtnEntrega.TabIndex = 10;
            this.radioBtnEntrega.Text = "Entrega";
            this.radioBtnEntrega.CheckedChanged += new System.EventHandler(this.radioBtnEntrega_CheckedChanged);
            // 
            // radioBtnRetiro
            // 
            this.radioBtnRetiro.Location = new System.Drawing.Point(577, 48);
            this.radioBtnRetiro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioBtnRetiro.Name = "radioBtnRetiro";
            this.radioBtnRetiro.Size = new System.Drawing.Size(112, 26);
            this.radioBtnRetiro.TabIndex = 11;
            this.radioBtnRetiro.Text = "Retiro";
            this.radioBtnRetiro.CheckedChanged += new System.EventHandler(this.radioBtnRetiro_CheckedChanged);
            // 
            // ConfeccionHDRdeUltMilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 706);
            this.Controls.Add(this.groupTipoConfeccion);
            this.Controls.Add(this.labelSeleccionarGuiasRuteo);
            this.Controls.Add(this.listViewGuiasARutear);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupSeleccionFletero);
            this.Controls.Add(this.groupBusquedaGuias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ConfeccionHDRdeUltMilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA – Confección de Hoja de Ruta ";
            this.Load += new System.EventHandler(this.ConfeccionHDRdeUltMilla_Load);
            this.groupBusquedaGuias.ResumeLayout(false);
            this.groupBusquedaGuias.PerformLayout();
            this.groupSeleccionFletero.ResumeLayout(false);
            this.groupSeleccionFletero.PerformLayout();
            this.groupTipoConfeccion.ResumeLayout(false);
            this.groupTipoConfeccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBusquedaGuias;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupSeleccionFletero;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ListView listViewGuiasARutear;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ComboBox cmbDomicilio;
        private System.Windows.Forms.Label labelDomicilio;
        private System.Windows.Forms.Label labelSeleccionarGuiasRuteo;
        private System.Windows.Forms.ComboBox cmbFleteros;
        private System.Windows.Forms.Label labelFletero;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupTipoConfeccion;
        private System.Windows.Forms.Label labelSeleccionaTipoHDR;
        private System.Windows.Forms.RadioButton radioBtnEntrega;
        private System.Windows.Forms.RadioButton radioBtnRetiro;
    }
}