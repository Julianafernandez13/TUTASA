namespace TUTASA.Forms.CD
{
    partial class frmDespacho
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvEncomiendas = new System.Windows.Forms.DataGridView();
            this.colGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCDDestino = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.btnGenerarHDR = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGenerarHDR);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TUTASA - Confeccionar HDR Transporte y Despachos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEncomiendas);
            this.groupBox2.Location = new System.Drawing.Point(15, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encomiendas Pendientes de Despacho";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarServicio);
            this.groupBox3.Controls.Add(this.txtServicio);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblCDDestino);
            this.groupBox3.Location = new System.Drawing.Point(15, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(671, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Despacho";
            // 
            // dgvEncomiendas
            // 
            this.dgvEncomiendas.AllowUserToAddRows = false;
            this.dgvEncomiendas.AllowUserToDeleteRows = false;
            this.dgvEncomiendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncomiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncomiendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGuia,
            this.colDestino,
            this.colCategoria,
            this.colPrioridad});
            this.dgvEncomiendas.Location = new System.Drawing.Point(6, 25);
            this.dgvEncomiendas.Name = "dgvEncomiendas";
            this.dgvEncomiendas.ReadOnly = true;
            this.dgvEncomiendas.RowHeadersVisible = false;
            this.dgvEncomiendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncomiendas.Size = new System.Drawing.Size(659, 129);
            this.dgvEncomiendas.TabIndex = 0;
            // 
            // colGuia
            // 
            this.colGuia.HeaderText = "N° Guía";
            this.colGuia.Name = "colGuia";
            this.colGuia.ReadOnly = true;
            // 
            // colDestino
            // 
            this.colDestino.HeaderText = "Destino";
            this.colDestino.Name = "colDestino";
            this.colDestino.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colPrioridad
            // 
            this.colPrioridad.HeaderText = "Prioridad";
            this.colPrioridad.Name = "colPrioridad";
            this.colPrioridad.ReadOnly = true;
            // 
            // lblCDDestino
            // 
            this.lblCDDestino.Location = new System.Drawing.Point(40, 34);
            this.lblCDDestino.Name = "lblCDDestino";
            this.lblCDDestino.Size = new System.Drawing.Size(64, 23);
            this.lblCDDestino.TabIndex = 0;
            this.lblCDDestino.Text = "CD Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Servicio:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(110, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 4;
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(110, 62);
            this.txtServicio.MaxLength = 50;
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(160, 20);
            this.txtServicio.TabIndex = 0;
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.Location = new System.Drawing.Point(300, 59);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(110, 25);
            this.btnBuscarServicio.TabIndex = 5;
            this.btnBuscarServicio.Text = "Buscar Servicio";
            this.btnBuscarServicio.UseVisualStyleBackColor = true;
            // 
            // btnGenerarHDR
            // 
            this.btnGenerarHDR.Location = new System.Drawing.Point(240, 342);
            this.btnGenerarHDR.Name = "btnGenerarHDR";
            this.btnGenerarHDR.Size = new System.Drawing.Size(110, 30);
            this.btnGenerarHDR.TabIndex = 6;
            this.btnGenerarHDR.Text = "Generar HDR";
            this.btnGenerarHDR.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(367, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmDespacho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 411);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmDespacho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDespacho";
            this.Load += new System.EventHandler(this.frmDespacho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomiendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEncomiendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrioridad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCDDestino;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarHDR;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarServicio;
    }
}