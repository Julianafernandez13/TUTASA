namespace TUTASA.Forms.CD
{
    partial class frmConfeccionHDRUltimaMilla
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
            this.grpFletero = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFletero = new System.Windows.Forms.TextBox();
            this.btnBuscarFletero = new System.Windows.Forms.Button();
            this.lblNombreFletero = new System.Windows.Forms.Label();
            this.grpEncomiendas = new System.Windows.Forms.GroupBox();
            this.dgvEncomiendas = new System.Windows.Forms.DataGridView();
            this.colGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpZona = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblZona = new System.Windows.Forms.Label();
            this.btnGenerarHDR = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpFletero.SuspendLayout();
            this.grpEncomiendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomiendas)).BeginInit();
            this.grpZona.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFletero
            // 
            this.grpFletero.AccessibleName = "grpFletero";
            this.grpFletero.Controls.Add(this.lblNombreFletero);
            this.grpFletero.Controls.Add(this.btnBuscarFletero);
            this.grpFletero.Controls.Add(this.txtFletero);
            this.grpFletero.Controls.Add(this.label1);
            this.grpFletero.Location = new System.Drawing.Point(12, 12);
            this.grpFletero.Name = "grpFletero";
            this.grpFletero.Size = new System.Drawing.Size(700, 60);
            this.grpFletero.TabIndex = 0;
            this.grpFletero.TabStop = false;
            this.grpFletero.Text = "Selección del fletero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código / DNI:";
            // 
            // txtFletero
            // 
            this.txtFletero.AccessibleName = "txtFletero";
            this.txtFletero.Location = new System.Drawing.Point(100, 23);
            this.txtFletero.Name = "txtFletero";
            this.txtFletero.Size = new System.Drawing.Size(150, 22);
            this.txtFletero.TabIndex = 1;
            // 
            // btnBuscarFletero
            // 
            this.btnBuscarFletero.AccessibleName = "btnBuscarFletero";
            this.btnBuscarFletero.Location = new System.Drawing.Point(260, 22);
            this.btnBuscarFletero.Name = "btnBuscarFletero";
            this.btnBuscarFletero.Size = new System.Drawing.Size(100, 25);
            this.btnBuscarFletero.TabIndex = 2;
            this.btnBuscarFletero.Text = "Buscar fletero";
            this.btnBuscarFletero.UseVisualStyleBackColor = true;
            // 
            // lblNombreFletero
            // 
            this.lblNombreFletero.AccessibleName = "lblNombreFletero";
            this.lblNombreFletero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreFletero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreFletero.Location = new System.Drawing.Point(370, 23);
            this.lblNombreFletero.Name = "lblNombreFletero";
            this.lblNombreFletero.Size = new System.Drawing.Size(280, 22);
            this.lblNombreFletero.TabIndex = 3;
            // 
            // grpEncomiendas
            // 
            this.grpEncomiendas.AccessibleName = "grpEncomiendas";
            this.grpEncomiendas.Controls.Add(this.dgvEncomiendas);
            this.grpEncomiendas.Location = new System.Drawing.Point(12, 82);
            this.grpEncomiendas.Name = "grpEncomiendas";
            this.grpEncomiendas.Size = new System.Drawing.Size(700, 200);
            this.grpEncomiendas.TabIndex = 1;
            this.grpEncomiendas.TabStop = false;
            this.grpEncomiendas.Text = "Encomiendas pendientes de asignación";
            // 
            // dgvEncomiendas
            // 
            this.dgvEncomiendas.AccessibleName = "dgvEncomiendas";
            this.dgvEncomiendas.AllowUserToAddRows = false;
            this.dgvEncomiendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncomiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncomiendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGuia,
            this.colDomicilio,
            this.colCategoria,
            this.colTipoOp,
            this.colPrioridad});
            this.dgvEncomiendas.Location = new System.Drawing.Point(10, 22);
            this.dgvEncomiendas.Name = "dgvEncomiendas";
            this.dgvEncomiendas.ReadOnly = true;
            this.dgvEncomiendas.RowHeadersVisible = false;
            this.dgvEncomiendas.RowHeadersWidth = 51;
            this.dgvEncomiendas.RowTemplate.Height = 24;
            this.dgvEncomiendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncomiendas.Size = new System.Drawing.Size(678, 165);
            this.dgvEncomiendas.TabIndex = 0;
            // 
            // colGuia
            // 
            this.colGuia.HeaderText = "N° Guía";
            this.colGuia.MinimumWidth = 6;
            this.colGuia.Name = "colGuia";
            this.colGuia.ReadOnly = true;
            // 
            // colDomicilio
            // 
            this.colDomicilio.HeaderText = "Domicilio";
            this.colDomicilio.MinimumWidth = 6;
            this.colDomicilio.Name = "colDomicilio";
            this.colDomicilio.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.MinimumWidth = 6;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colTipoOp
            // 
            this.colTipoOp.HeaderText = "Tipo operación";
            this.colTipoOp.MinimumWidth = 6;
            this.colTipoOp.Name = "colTipoOp";
            this.colTipoOp.ReadOnly = true;
            // 
            // colPrioridad
            // 
            this.colPrioridad.HeaderText = "Prioridad";
            this.colPrioridad.MinimumWidth = 6;
            this.colPrioridad.Name = "colPrioridad";
            this.colPrioridad.ReadOnly = true;
            // 
            // grpZona
            // 
            this.grpZona.AccessibleName = "grpZona";
            this.grpZona.Controls.Add(this.lblZona);
            this.grpZona.Controls.Add(this.label2);
            this.grpZona.Location = new System.Drawing.Point(12, 292);
            this.grpZona.Name = "grpZona";
            this.grpZona.Size = new System.Drawing.Size(700, 60);
            this.grpZona.TabIndex = 2;
            this.grpZona.TabStop = false;
            this.grpZona.Text = "Zona de cobertura del fletero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Zona asignada:";
            // 
            // lblZona
            // 
            this.lblZona.AccessibleName = "lblZona";
            this.lblZona.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblZona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZona.Location = new System.Drawing.Point(117, 26);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(500, 22);
            this.lblZona.TabIndex = 1;
            this.lblZona.Click += new System.EventHandler(this.lblZona_Click);
            // 
            // btnGenerarHDR
            // 
            this.btnGenerarHDR.AccessibleName = "btnGenerarHDR";
            this.btnGenerarHDR.Location = new System.Drawing.Point(450, 370);
            this.btnGenerarHDR.Name = "btnGenerarHDR";
            this.btnGenerarHDR.Size = new System.Drawing.Size(150, 30);
            this.btnGenerarHDR.TabIndex = 3;
            this.btnGenerarHDR.Text = "Generar hojas de ruta";
            this.btnGenerarHDR.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleName = "btnCancelar";
            this.btnCancelar.Location = new System.Drawing.Point(610, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmConfeccionHDRUltimaMilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 473);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerarHDR);
            this.Controls.Add(this.grpZona);
            this.Controls.Add(this.grpEncomiendas);
            this.Controls.Add(this.grpFletero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmConfeccionHDRUltimaMilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfeccionHDRUltimaMilla";
            this.grpFletero.ResumeLayout(false);
            this.grpFletero.PerformLayout();
            this.grpEncomiendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomiendas)).EndInit();
            this.grpZona.ResumeLayout(false);
            this.grpZona.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFletero;
        private System.Windows.Forms.TextBox txtFletero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreFletero;
        private System.Windows.Forms.Button btnBuscarFletero;
        private System.Windows.Forms.GroupBox grpEncomiendas;
        private System.Windows.Forms.DataGridView dgvEncomiendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrioridad;
        private System.Windows.Forms.GroupBox grpZona;
        private System.Windows.Forms.Label lblZona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerarHDR;
        private System.Windows.Forms.Button btnCancelar;
    }
}