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
            this.groupBusquedaGuias.Location = new System.Drawing.Point(14, 115);
            this.groupBusquedaGuias.Name = "groupBusquedaGuias";
            this.groupBusquedaGuias.Size = new System.Drawing.Size(981, 98);
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
            this.cmbDomicilio.Location = new System.Drawing.Point(483, 45);
            this.cmbDomicilio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDomicilio.Name = "cmbDomicilio";
            this.cmbDomicilio.Size = new System.Drawing.Size(237, 24);
            this.cmbDomicilio.TabIndex = 12;
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Location = new System.Drawing.Point(410, 45);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(66, 16);
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
            this.cmbLocalidad.Location = new System.Drawing.Point(110, 45);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(237, 24);
            this.cmbLocalidad.TabIndex = 10;
            this.cmbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidad_SelectedIndexChanged);
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(33, 45);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(70, 16);
            this.labelLocalidad.TabIndex = 9;
            this.labelLocalidad.Text = "Localidad:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(815, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupSeleccionFletero
            // 
            this.groupSeleccionFletero.Controls.Add(this.cmbFleteros);
            this.groupSeleccionFletero.Controls.Add(this.labelFletero);
            this.groupSeleccionFletero.Location = new System.Drawing.Point(14, 404);
            this.groupSeleccionFletero.Name = "groupSeleccionFletero";
            this.groupSeleccionFletero.Size = new System.Drawing.Size(981, 119);
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
            this.cmbFleteros.Location = new System.Drawing.Point(110, 54);
            this.cmbFleteros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFleteros.Name = "cmbFleteros";
            this.cmbFleteros.Size = new System.Drawing.Size(237, 24);
            this.cmbFleteros.TabIndex = 13;
            this.cmbFleteros.SelectedIndexChanged += new System.EventHandler(this.cmbFleteros_SelectedIndexChanged);
            // 
            // labelFletero
            // 
            this.labelFletero.AutoSize = true;
            this.labelFletero.Location = new System.Drawing.Point(33, 57);
            this.labelFletero.Name = "labelFletero";
            this.labelFletero.Size = new System.Drawing.Size(52, 16);
            this.labelFletero.TabIndex = 10;
            this.labelFletero.Text = "Fletero:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(720, 530);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(97, 25);
            this.btnConfirmar.TabIndex = 23;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(859, 530);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 25);
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
            this.listViewGuiasARutear.Location = new System.Drawing.Point(14, 250);
            this.listViewGuiasARutear.Name = "listViewGuiasARutear";
            this.listViewGuiasARutear.Size = new System.Drawing.Size(982, 131);
            this.listViewGuiasARutear.TabIndex = 3;
            this.listViewGuiasARutear.UseCompatibleStateImageBehavior = false;
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
            this.labelSeleccionarGuiasRuteo.Location = new System.Drawing.Point(15, 231);
            this.labelSeleccionarGuiasRuteo.Name = "labelSeleccionarGuiasRuteo";
            this.labelSeleccionarGuiasRuteo.Size = new System.Drawing.Size(168, 16);
            this.labelSeleccionarGuiasRuteo.TabIndex = 37;
            this.labelSeleccionarGuiasRuteo.Text = "Seleccionar Guías a rutear:";
            // 
            // groupTipoConfeccion
            // 
            this.groupTipoConfeccion.Controls.Add(this.labelSeleccionaTipoHDR);
            this.groupTipoConfeccion.Controls.Add(this.radioBtnEntrega);
            this.groupTipoConfeccion.Controls.Add(this.radioBtnRetiro);
            this.groupTipoConfeccion.Location = new System.Drawing.Point(19, 10);
            this.groupTipoConfeccion.Name = "groupTipoConfeccion";
            this.groupTipoConfeccion.Size = new System.Drawing.Size(981, 85);
            this.groupTipoConfeccion.TabIndex = 38;
            this.groupTipoConfeccion.TabStop = false;
            this.groupTipoConfeccion.Text = "Tipo de Confección";
            // 
            // labelSeleccionaTipoHDR
            // 
            this.labelSeleccionaTipoHDR.AutoSize = true;
            this.labelSeleccionaTipoHDR.Location = new System.Drawing.Point(66, 41);
            this.labelSeleccionaTipoHDR.Name = "labelSeleccionaTipoHDR";
            this.labelSeleccionaTipoHDR.Size = new System.Drawing.Size(246, 16);
            this.labelSeleccionaTipoHDR.TabIndex = 12;
            this.labelSeleccionaTipoHDR.Text = "Selecciona tipo de HDR a confeccionar:";
            // 
            // radioBtnEntrega
            // 
            this.radioBtnEntrega.Location = new System.Drawing.Point(361, 38);
            this.radioBtnEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtnEntrega.Name = "radioBtnEntrega";
            this.radioBtnEntrega.Size = new System.Drawing.Size(112, 21);
            this.radioBtnEntrega.TabIndex = 10;
            this.radioBtnEntrega.Text = "Entrega";
            // 
            // radioBtnRetiro
            // 
            this.radioBtnRetiro.Location = new System.Drawing.Point(513, 38);
            this.radioBtnRetiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioBtnRetiro.Name = "radioBtnRetiro";
            this.radioBtnRetiro.Size = new System.Drawing.Size(100, 21);
            this.radioBtnRetiro.TabIndex = 11;
            this.radioBtnRetiro.Text = "Retiro";
            // 
            // ConfeccionHDRdeUltMilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 565);
            this.Controls.Add(this.groupTipoConfeccion);
            this.Controls.Add(this.labelSeleccionarGuiasRuteo);
            this.Controls.Add(this.listViewGuiasARutear);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.groupSeleccionFletero);
            this.Controls.Add(this.groupBusquedaGuias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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