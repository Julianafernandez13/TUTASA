namespace TUTASA.Forms.CD
{
    partial class frmAdmision
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpFletero = new System.Windows.Forms.GroupBox();
            this.lblFleteroLabel = new System.Windows.Forms.Label();
            this.txtFletero = new System.Windows.Forms.TextBox();
            this.btnBuscarFletero = new System.Windows.Forms.Button();
            this.lblNombreFletero = new System.Windows.Forms.Label();
            this.grpEncomienda = new System.Windows.Forms.GroupBox();
            this.lblNroGuiaLabel = new System.Windows.Forms.Label();
            this.txtNroGuia = new System.Windows.Forms.TextBox();
            this.lblCategoriaLabel = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblDestinoLabel = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblTipoServLabel = new System.Windows.Forms.Label();
            this.rbSucursal = new System.Windows.Forms.RadioButton();
            this.rbDomicilio = new System.Windows.Forms.RadioButton();
            this.lblTarifaLabel = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.lblCargosLabel = new System.Windows.Forms.Label();
            this.lblCargos = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.grpEncomiendas = new System.Windows.Forms.GroupBox();
            this.dgvEncomiendas = new System.Windows.Forms.DataGridView();
            this.colGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizarAdmision = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpFletero.SuspendLayout();
            this.grpEncomienda.SuspendLayout();
            this.grpEncomiendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFletero
            // 
            this.grpFletero.Controls.Add(this.lblFleteroLabel);
            this.grpFletero.Controls.Add(this.txtFletero);
            this.grpFletero.Controls.Add(this.btnBuscarFletero);
            this.grpFletero.Controls.Add(this.lblNombreFletero);
            this.grpFletero.Location = new System.Drawing.Point(14, 12);
            this.grpFletero.Name = "grpFletero";
            this.grpFletero.Size = new System.Drawing.Size(700, 60);
            this.grpFletero.TabIndex = 0;
            this.grpFletero.TabStop = false;
            this.grpFletero.Text = "Identificación del fletero";
            // 
            // lblFleteroLabel
            // 
            this.lblFleteroLabel.AutoSize = true;
            this.lblFleteroLabel.Location = new System.Drawing.Point(10, 26);
            this.lblFleteroLabel.Name = "lblFleteroLabel";
            this.lblFleteroLabel.Size = new System.Drawing.Size(103, 20);
            this.lblFleteroLabel.TabIndex = 0;
            this.lblFleteroLabel.Text = "Código / DNI:";
            // 
            // txtFletero
            // 
            this.txtFletero.Location = new System.Drawing.Point(100, 23);
            this.txtFletero.Name = "txtFletero";
            this.txtFletero.Size = new System.Drawing.Size(150, 26);
            this.txtFletero.TabIndex = 0;
            // 
            // btnBuscarFletero
            // 
            this.btnBuscarFletero.Location = new System.Drawing.Point(260, 22);
            this.btnBuscarFletero.Name = "btnBuscarFletero";
            this.btnBuscarFletero.Size = new System.Drawing.Size(90, 25);
            this.btnBuscarFletero.TabIndex = 1;
            this.btnBuscarFletero.Text = "Buscar fletero";
            this.btnBuscarFletero.UseVisualStyleBackColor = true;
            // 
            // lblNombreFletero
            // 
            this.lblNombreFletero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreFletero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreFletero.Location = new System.Drawing.Point(360, 23);
            this.lblNombreFletero.Name = "lblNombreFletero";
            this.lblNombreFletero.Size = new System.Drawing.Size(320, 22);
            this.lblNombreFletero.TabIndex = 2;
            // 
            // grpEncomienda
            // 
            this.grpEncomienda.Controls.Add(this.lblNroGuiaLabel);
            this.grpEncomienda.Controls.Add(this.txtNroGuia);
            this.grpEncomienda.Controls.Add(this.lblCategoriaLabel);
            this.grpEncomienda.Controls.Add(this.cmbCategoria);
            this.grpEncomienda.Controls.Add(this.lblDestinoLabel);
            this.grpEncomienda.Controls.Add(this.txtDestino);
            this.grpEncomienda.Controls.Add(this.lblTipoServLabel);
            this.grpEncomienda.Controls.Add(this.rbSucursal);
            this.grpEncomienda.Controls.Add(this.rbDomicilio);
            this.grpEncomienda.Controls.Add(this.lblTarifaLabel);
            this.grpEncomienda.Controls.Add(this.lblTarifa);
            this.grpEncomienda.Controls.Add(this.lblCargosLabel);
            this.grpEncomienda.Controls.Add(this.lblCargos);
            this.grpEncomienda.Controls.Add(this.btnRegistrar);
            this.grpEncomienda.Location = new System.Drawing.Point(14, 82);
            this.grpEncomienda.Name = "grpEncomienda";
            this.grpEncomienda.Size = new System.Drawing.Size(700, 171);
            this.grpEncomienda.TabIndex = 1;
            this.grpEncomienda.TabStop = false;
            this.grpEncomienda.Text = "Datos de la encomienda";
            // 
            // lblNroGuiaLabel
            // 
            this.lblNroGuiaLabel.AutoSize = true;
            this.lblNroGuiaLabel.Location = new System.Drawing.Point(10, 28);
            this.lblNroGuiaLabel.Name = "lblNroGuiaLabel";
            this.lblNroGuiaLabel.Size = new System.Drawing.Size(85, 20);
            this.lblNroGuiaLabel.TabIndex = 0;
            this.lblNroGuiaLabel.Text = "N° de guía:";
            // 
            // txtNroGuia
            // 
            this.txtNroGuia.Location = new System.Drawing.Point(165, 24);
            this.txtNroGuia.Name = "txtNroGuia";
            this.txtNroGuia.Size = new System.Drawing.Size(143, 26);
            this.txtNroGuia.TabIndex = 2;
            // 
            // lblCategoriaLabel
            // 
            this.lblCategoriaLabel.AutoSize = true;
            this.lblCategoriaLabel.Location = new System.Drawing.Point(329, 27);
            this.lblCategoriaLabel.Name = "lblCategoriaLabel";
            this.lblCategoriaLabel.Size = new System.Drawing.Size(82, 20);
            this.lblCategoriaLabel.TabIndex = 3;
            this.lblCategoriaLabel.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.cmbCategoria.Location = new System.Drawing.Point(470, 25);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(80, 28);
            this.cmbCategoria.TabIndex = 7;
            // 
            // lblDestinoLabel
            // 
            this.lblDestinoLabel.AutoSize = true;
            this.lblDestinoLabel.Location = new System.Drawing.Point(10, 62);
            this.lblDestinoLabel.Name = "lblDestinoLabel";
            this.lblDestinoLabel.Size = new System.Drawing.Size(151, 20);
            this.lblDestinoLabel.TabIndex = 8;
            this.lblDestinoLabel.Text = "Destino confirmado:";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(164, 57);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(144, 26);
            this.txtDestino.TabIndex = 3;
            // 
            // lblTipoServLabel
            // 
            this.lblTipoServLabel.AutoSize = true;
            this.lblTipoServLabel.Location = new System.Drawing.Point(326, 62);
            this.lblTipoServLabel.Name = "lblTipoServLabel";
            this.lblTipoServLabel.Size = new System.Drawing.Size(121, 20);
            this.lblTipoServLabel.TabIndex = 9;
            this.lblTipoServLabel.Text = "Tipo de servicio:";
            // 
            // rbSucursal
            // 
            this.rbSucursal.AutoSize = true;
            this.rbSucursal.Location = new System.Drawing.Point(461, 60);
            this.rbSucursal.Name = "rbSucursal";
            this.rbSucursal.Size = new System.Drawing.Size(96, 24);
            this.rbSucursal.TabIndex = 4;
            this.rbSucursal.Text = "Sucursal";
            // 
            // rbDomicilio
            // 
            this.rbDomicilio.AutoSize = true;
            this.rbDomicilio.Location = new System.Drawing.Point(573, 60);
            this.rbDomicilio.Name = "rbDomicilio";
            this.rbDomicilio.Size = new System.Drawing.Size(97, 24);
            this.rbDomicilio.TabIndex = 5;
            this.rbDomicilio.Text = "Domicilio";
            this.rbDomicilio.CheckedChanged += new System.EventHandler(this.rbDomicilio_CheckedChanged);
            // 
            // lblTarifaLabel
            // 
            this.lblTarifaLabel.AutoSize = true;
            this.lblTarifaLabel.Location = new System.Drawing.Point(10, 106);
            this.lblTarifaLabel.Name = "lblTarifaLabel";
            this.lblTarifaLabel.Size = new System.Drawing.Size(119, 20);
            this.lblTarifaLabel.TabIndex = 10;
            this.lblTarifaLabel.Text = "Tarifa definitiva:";
            // 
            // lblTarifa
            // 
            this.lblTarifa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTarifa.Location = new System.Drawing.Point(136, 106);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(100, 22);
            this.lblTarifa.TabIndex = 11;
            // 
            // lblCargosLabel
            // 
            this.lblCargosLabel.AutoSize = true;
            this.lblCargosLabel.Location = new System.Drawing.Point(327, 105);
            this.lblCargosLabel.Name = "lblCargosLabel";
            this.lblCargosLabel.Size = new System.Drawing.Size(143, 20);
            this.lblCargosLabel.TabIndex = 12;
            this.lblCargosLabel.Text = "Cargos calculados:";
            // 
            // lblCargos
            // 
            this.lblCargos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCargos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCargos.Location = new System.Drawing.Point(474, 105);
            this.lblCargos.Name = "lblCargos";
            this.lblCargos.Size = new System.Drawing.Size(100, 22);
            this.lblCargos.TabIndex = 13;
            this.lblCargos.Click += new System.EventHandler(this.lblCargos_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(562, 133);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 30);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar encomienda";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // grpEncomiendas
            // 
            this.grpEncomiendas.Controls.Add(this.dgvEncomiendas);
            this.grpEncomiendas.Location = new System.Drawing.Point(13, 264);
            this.grpEncomiendas.Name = "grpEncomiendas";
            this.grpEncomiendas.Size = new System.Drawing.Size(700, 188);
            this.grpEncomiendas.TabIndex = 2;
            this.grpEncomiendas.TabStop = false;
            this.grpEncomiendas.Text = "Encomiendas registradas en esta sesión";
            // 
            // dgvEncomiendas
            // 
            this.dgvEncomiendas.AllowUserToAddRows = false;
            this.dgvEncomiendas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvEncomiendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEncomiendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncomiendas.ColumnHeadersHeight = 34;
            this.dgvEncomiendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGuia,
            this.colCategoria,
            this.colDestino,
            this.colTarifa,
            this.colEstado});
            this.dgvEncomiendas.Location = new System.Drawing.Point(15, 42);
            this.dgvEncomiendas.Name = "dgvEncomiendas";
            this.dgvEncomiendas.ReadOnly = true;
            this.dgvEncomiendas.RowHeadersVisible = false;
            this.dgvEncomiendas.RowHeadersWidth = 62;
            this.dgvEncomiendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncomiendas.Size = new System.Drawing.Size(678, 190);
            this.dgvEncomiendas.TabIndex = 0;
            // 
            // colGuia
            // 
            this.colGuia.FillWeight = 20F;
            this.colGuia.HeaderText = "N° de guía";
            this.colGuia.MinimumWidth = 8;
            this.colGuia.Name = "colGuia";
            this.colGuia.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.FillWeight = 15F;
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.MinimumWidth = 8;
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colDestino
            // 
            this.colDestino.FillWeight = 25F;
            this.colDestino.HeaderText = "Destino";
            this.colDestino.MinimumWidth = 8;
            this.colDestino.Name = "colDestino";
            this.colDestino.ReadOnly = true;
            // 
            // colTarifa
            // 
            this.colTarifa.FillWeight = 20F;
            this.colTarifa.HeaderText = "Tarifa definitiva";
            this.colTarifa.MinimumWidth = 8;
            this.colTarifa.Name = "colTarifa";
            this.colTarifa.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.FillWeight = 20F;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 8;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // btnFinalizarAdmision
            // 
            this.btnFinalizarAdmision.Location = new System.Drawing.Point(485, 490);
            this.btnFinalizarAdmision.Name = "btnFinalizarAdmision";
            this.btnFinalizarAdmision.Size = new System.Drawing.Size(130, 30);
            this.btnFinalizarAdmision.TabIndex = 10;
            this.btnFinalizarAdmision.Text = "Finalizar admisión";
            this.btnFinalizarAdmision.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(620, 491);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAdmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 543);
            this.Controls.Add(this.grpFletero);
            this.Controls.Add(this.grpEncomienda);
            this.Controls.Add(this.grpEncomiendas);
            this.Controls.Add(this.btnFinalizarAdmision);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAdmision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA — Registrar admisión de encomiendas";
            this.grpFletero.ResumeLayout(false);
            this.grpFletero.PerformLayout();
            this.grpEncomienda.ResumeLayout(false);
            this.grpEncomienda.PerformLayout();
            this.grpEncomiendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncomiendas)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpFletero;
        private System.Windows.Forms.Label lblFleteroLabel;
        private System.Windows.Forms.TextBox txtFletero;
        private System.Windows.Forms.Button btnBuscarFletero;
        private System.Windows.Forms.Label lblNombreFletero;

        private System.Windows.Forms.GroupBox grpEncomienda;
        private System.Windows.Forms.Label lblNroGuiaLabel;
        private System.Windows.Forms.TextBox txtNroGuia;
        private System.Windows.Forms.Label lblCategoriaLabel;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblDestinoLabel;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblTipoServLabel;
        private System.Windows.Forms.RadioButton rbSucursal;
        private System.Windows.Forms.RadioButton rbDomicilio;
        private System.Windows.Forms.Label lblTarifaLabel;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.Label lblCargosLabel;
        private System.Windows.Forms.Label lblCargos;
        private System.Windows.Forms.Button btnRegistrar;

        private System.Windows.Forms.GroupBox grpEncomiendas;
        private System.Windows.Forms.DataGridView dgvEncomiendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;

        private System.Windows.Forms.Button btnFinalizarAdmision;
        private System.Windows.Forms.Button btnCancelar;
    }
}