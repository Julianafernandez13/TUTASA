namespace TUTASA.Forms.Administracion
{
    partial class CostovsVentas
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
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.labelAño = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTotales = new System.Windows.Forms.Label();
            this.listViewResultados = new System.Windows.Forms.ListView();
            this.Clasificación = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(127, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(528, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Costo vs Ventas por Empresa de Transporte";
            
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.cmbAño);
            this.gbFiltros.Controls.Add(this.cmbMes);
            this.gbFiltros.Controls.Add(this.labelAño);
            this.gbFiltros.Controls.Add(this.cmbEmpresa);
            this.gbFiltros.Controls.Add(this.labelEmpresa);
            this.gbFiltros.Controls.Add(this.lblMes);
            this.gbFiltros.Location = new System.Drawing.Point(60, 107);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(660, 120);
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros de Consulta";
            
            // 
            // cmbAño
            // 
            this.cmbAño.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cmbAño.Location = new System.Drawing.Point(279, 27);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(96, 28);
            this.cmbAño.TabIndex = 8;
           
            // 
            // cmbMes
            // 
            this.cmbMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMes.Location = new System.Drawing.Point(126, 27);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(67, 28);
            this.cmbMes.TabIndex = 7;
           
            // 
            // labelAño
            // 
            this.labelAño.Location = new System.Drawing.Point(230, 30);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(43, 23);
            this.labelAño.TabIndex = 6;
            this.labelAño.Text = "Año:";
            
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Items.AddRange(new object[] {
            "Todas",
            "Empresa A",
            "Empresa B",
            "Empresa C"});
            this.cmbEmpresa.Location = new System.Drawing.Point(126, 67);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(200, 28);
            this.cmbEmpresa.TabIndex = 0;
            
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.Location = new System.Drawing.Point(36, 70);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(84, 23);
            this.labelEmpresa.TabIndex = 1;
            this.labelEmpresa.Text = "Empresa:";
            
            // 
            // lblMes
            // 
            this.lblMes.Location = new System.Drawing.Point(68, 32);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(52, 23);
            this.lblMes.TabIndex = 5;
            this.lblMes.Text = "Mes:";
           
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(100, 233);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(140, 35);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(443, 233);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 35);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotales.Location = new System.Drawing.Point(55, 544);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(359, 25);
            this.lblTotales.TabIndex = 0;
            this.lblTotales.Text = "Totales: Ingresos / Costos / Margen";
            
            // 
            // listViewResultados
            // 
            this.listViewResultados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Clasificación,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewResultados.FullRowSelect = true;
            this.listViewResultados.GridLines = true;
            this.listViewResultados.HideSelection = false;
            this.listViewResultados.Location = new System.Drawing.Point(60, 339);
            this.listViewResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewResultados.Name = "listViewResultados";
            this.listViewResultados.Size = new System.Drawing.Size(660, 158);
            this.listViewResultados.TabIndex = 7;
            this.listViewResultados.UseCompatibleStateImageBehavior = false;
            this.listViewResultados.View = System.Windows.Forms.View.Details;
            
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
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(622, 572);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 40);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CostovsVentas
            // 
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.listViewResultados);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.lblTitulo);
            this.Name = "CostovsVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costo vs Ventas";
            this.Load += new System.EventHandler(this.CostovsVentas_Load);
            this.gbFiltros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.ListView listViewResultados;
        private System.Windows.Forms.ColumnHeader Clasificación;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.ComboBox cmbAño;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Button btnSalir;
    }
}