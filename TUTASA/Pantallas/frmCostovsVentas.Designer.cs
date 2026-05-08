namespace TUTASA.Forms.Administracion
{
    partial class frmCostovsVentas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTotales = new System.Windows.Forms.Label();
            this.lvBultos = new System.Windows.Forms.ListView();
            this.Empresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clasificación = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(200, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(356, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Costo vs Ventas por Empresa";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.cmbEmpresa);
            this.gbFiltros.Controls.Add(this.lblEmpresa);
            this.gbFiltros.Controls.Add(this.lblDesde);
            this.gbFiltros.Location = new System.Drawing.Point(60, 50);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(660, 120);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros de Consulta";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Items.AddRange(new object[] {
            "Todas",
            "Empresa A",
            "Empresa B",
            "Empresa C"});
            this.cmbEmpresa.Location = new System.Drawing.Point(80, 68);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(200, 28);
            this.cmbEmpresa.TabIndex = 0;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Location = new System.Drawing.Point(20, 70);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(100, 23);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // lblDesde
            // 
            this.lblDesde.Location = new System.Drawing.Point(20, 30);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(100, 23);
            this.lblDesde.TabIndex = 5;
            this.lblDesde.Text = "Mes / año:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(100, 180);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(140, 35);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(260, 180);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(100, 35);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "Exportar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(380, 180);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 35);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotales.Location = new System.Drawing.Point(55, 457);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(359, 25);
            this.lblTotales.TabIndex = 0;
            this.lblTotales.Text = "Totales: Ingresos / Costos / Margen";
            // 
            // lvBultos
            // 
            this.lvBultos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Empresa,
            this.Clasificación,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvBultos.FullRowSelect = true;
            this.lvBultos.GridLines = true;
            this.lvBultos.HideSelection = false;
            this.lvBultos.Location = new System.Drawing.Point(60, 287);
            this.lvBultos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvBultos.Name = "lvBultos";
            this.lvBultos.Size = new System.Drawing.Size(531, 99);
            this.lvBultos.TabIndex = 7;
            this.lvBultos.UseCompatibleStateImageBehavior = false;
            this.lvBultos.View = System.Windows.Forms.View.Details;
            this.lvBultos.SelectedIndexChanged += new System.EventHandler(this.lvBultos_SelectedIndexChanged);
            // 
            // Empresa
            // 
            this.Empresa.Text = "Empresa";
            this.Empresa.Width = 90;
            // 
            // Clasificación
            // 
            this.Clasificación.Text = "Clasificación";
            this.Clasificación.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ingresos";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Costos";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Margen Neto";
            this.columnHeader3.Width = 120;
            // 
            // frmCostovsVentas
            // 
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.lvBultos);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCostovsVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costo vs Ventas";
            this.gbFiltros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.ListView lvBultos;
        private System.Windows.Forms.ColumnHeader Empresa;
        private System.Windows.Forms.ColumnHeader Clasificación;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}