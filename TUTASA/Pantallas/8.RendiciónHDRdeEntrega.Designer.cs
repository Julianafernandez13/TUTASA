namespace TUTASA.Forms.CD
{
    partial class RendiciónHDRdeEntrega
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
            this.grpHDR = new System.Windows.Forms.GroupBox();
            this.lblNroHDRLabel = new System.Windows.Forms.Label();
            this.txtNroHDR = new System.Windows.Forms.TextBox();
            this.lblResultadoLabel = new System.Windows.Forms.Label();
            this.rbEntregada = new System.Windows.Forms.RadioButton();
            this.rbIntentoFallido = new System.Windows.Forms.RadioButton();
            this.lblDNIReceptorLabel = new System.Windows.Forms.Label();
            this.txtDNIReceptor = new System.Windows.Forms.TextBox();
            this.lblNombreRecLabel = new System.Windows.Forms.Label();
            this.txtNombreReceptor = new System.Windows.Forms.TextBox();
            this.lblMotivoLabel = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnRegistrarHDR = new System.Windows.Forms.Button();
            this.grpGuias = new System.Windows.Forms.GroupBox();
            this.dgvGuias = new System.Windows.Forms.DataGridView();
            this.colNroHDR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReceptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpFletero.SuspendLayout();
            this.grpHDR.SuspendLayout();
            this.grpGuias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuias)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFletero
            // 
            this.grpFletero.Controls.Add(this.lblFleteroLabel);
            this.grpFletero.Controls.Add(this.txtFletero);
            this.grpFletero.Controls.Add(this.btnBuscarFletero);
            this.grpFletero.Controls.Add(this.lblNombreFletero);
            this.grpFletero.Location = new System.Drawing.Point(8, 8);
            this.grpFletero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFletero.Name = "grpFletero";
            this.grpFletero.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFletero.Size = new System.Drawing.Size(474, 64);
            this.grpFletero.TabIndex = 0;
            this.grpFletero.TabStop = false;
            this.grpFletero.Text = "Identificación del fletero";
            // 
            // lblFleteroLabel
            // 
            this.lblFleteroLabel.AutoSize = true;
            this.lblFleteroLabel.Location = new System.Drawing.Point(7, 17);
            this.lblFleteroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFleteroLabel.Name = "lblFleteroLabel";
            this.lblFleteroLabel.Size = new System.Drawing.Size(73, 13);
            this.lblFleteroLabel.TabIndex = 0;
            this.lblFleteroLabel.Text = "Código / DNI:";
            // 
            // txtFletero
            // 
            this.txtFletero.Location = new System.Drawing.Point(75, 15);
            this.txtFletero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFletero.Name = "txtFletero";
            this.txtFletero.Size = new System.Drawing.Size(101, 20);
            this.txtFletero.TabIndex = 0;
            // 
            // btnBuscarFletero
            // 
            this.btnBuscarFletero.Location = new System.Drawing.Point(179, 14);
            this.btnBuscarFletero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarFletero.Name = "btnBuscarFletero";
            this.btnBuscarFletero.Size = new System.Drawing.Size(60, 21);
            this.btnBuscarFletero.TabIndex = 1;
            this.btnBuscarFletero.Text = "Buscar fletero";
            this.btnBuscarFletero.UseVisualStyleBackColor = true;
            // 
            // lblNombreFletero
            // 
            this.lblNombreFletero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreFletero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreFletero.Location = new System.Drawing.Point(243, 15);
            this.lblNombreFletero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreFletero.Name = "lblNombreFletero";
            this.lblNombreFletero.Size = new System.Drawing.Size(214, 15);
            this.lblNombreFletero.TabIndex = 2;
            // 
            // grpHDR
            // 
            this.grpHDR.Controls.Add(this.lblNroHDRLabel);
            this.grpHDR.Controls.Add(this.txtNroHDR);
            this.grpHDR.Controls.Add(this.lblResultadoLabel);
            this.grpHDR.Controls.Add(this.rbEntregada);
            this.grpHDR.Controls.Add(this.rbIntentoFallido);
            this.grpHDR.Controls.Add(this.lblDNIReceptorLabel);
            this.grpHDR.Controls.Add(this.txtDNIReceptor);
            this.grpHDR.Controls.Add(this.lblNombreRecLabel);
            this.grpHDR.Controls.Add(this.txtNombreReceptor);
            this.grpHDR.Controls.Add(this.lblMotivoLabel);
            this.grpHDR.Controls.Add(this.txtMotivo);
            this.grpHDR.Controls.Add(this.btnRegistrarHDR);
            this.grpHDR.Location = new System.Drawing.Point(8, 88);
            this.grpHDR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpHDR.Name = "grpHDR";
            this.grpHDR.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpHDR.Size = new System.Drawing.Size(474, 140);
            this.grpHDR.TabIndex = 1;
            this.grpHDR.TabStop = false;
            this.grpHDR.Text = "Datos de la hoja de ruta";
            // 
            // lblNroHDRLabel
            // 
            this.lblNroHDRLabel.AutoSize = true;
            this.lblNroHDRLabel.Location = new System.Drawing.Point(27, 32);
            this.lblNroHDRLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNroHDRLabel.Name = "lblNroHDRLabel";
            this.lblNroHDRLabel.Size = new System.Drawing.Size(64, 13);
            this.lblNroHDRLabel.TabIndex = 0;
            this.lblNroHDRLabel.Text = "N° de HDR:";
            // 
            // txtNroHDR
            // 
            this.txtNroHDR.Location = new System.Drawing.Point(89, 30);
            this.txtNroHDR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNroHDR.Name = "txtNroHDR";
            this.txtNroHDR.Size = new System.Drawing.Size(81, 20);
            this.txtNroHDR.TabIndex = 2;
            // 
            // lblResultadoLabel
            // 
            this.lblResultadoLabel.AutoSize = true;
            this.lblResultadoLabel.Location = new System.Drawing.Point(189, 32);
            this.lblResultadoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultadoLabel.Name = "lblResultadoLabel";
            this.lblResultadoLabel.Size = new System.Drawing.Size(58, 13);
            this.lblResultadoLabel.TabIndex = 3;
            this.lblResultadoLabel.Text = "Resultado:";
            // 
            // rbEntregada
            // 
            this.rbEntregada.AutoSize = true;
            this.rbEntregada.Checked = true;
            this.rbEntregada.Location = new System.Drawing.Point(255, 31);
            this.rbEntregada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEntregada.Name = "rbEntregada";
            this.rbEntregada.Size = new System.Drawing.Size(74, 17);
            this.rbEntregada.TabIndex = 3;
            this.rbEntregada.TabStop = true;
            this.rbEntregada.Text = "Entregada";
            // 
            // rbIntentoFallido
            // 
            this.rbIntentoFallido.AutoSize = true;
            this.rbIntentoFallido.Location = new System.Drawing.Point(335, 31);
            this.rbIntentoFallido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbIntentoFallido.Name = "rbIntentoFallido";
            this.rbIntentoFallido.Size = new System.Drawing.Size(88, 17);
            this.rbIntentoFallido.TabIndex = 4;
            this.rbIntentoFallido.Text = "Intento fallido";
            // 
            // lblDNIReceptorLabel
            // 
            this.lblDNIReceptorLabel.AutoSize = true;
            this.lblDNIReceptorLabel.Location = new System.Drawing.Point(27, 56);
            this.lblDNIReceptorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNIReceptorLabel.Name = "lblDNIReceptorLabel";
            this.lblDNIReceptorLabel.Size = new System.Drawing.Size(71, 13);
            this.lblDNIReceptorLabel.TabIndex = 5;
            this.lblDNIReceptorLabel.Text = "DNI receptor:";
            // 
            // txtDNIReceptor
            // 
            this.txtDNIReceptor.Location = new System.Drawing.Point(98, 54);
            this.txtDNIReceptor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDNIReceptor.Name = "txtDNIReceptor";
            this.txtDNIReceptor.Size = new System.Drawing.Size(81, 20);
            this.txtDNIReceptor.TabIndex = 5;
            // 
            // lblNombreRecLabel
            // 
            this.lblNombreRecLabel.AutoSize = true;
            this.lblNombreRecLabel.Location = new System.Drawing.Point(187, 56);
            this.lblNombreRecLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreRecLabel.Name = "lblNombreRecLabel";
            this.lblNombreRecLabel.Size = new System.Drawing.Size(89, 13);
            this.lblNombreRecLabel.TabIndex = 6;
            this.lblNombreRecLabel.Text = "Nombre receptor:";
            // 
            // txtNombreReceptor
            // 
            this.txtNombreReceptor.Location = new System.Drawing.Point(285, 54);
            this.txtNombreReceptor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreReceptor.Name = "txtNombreReceptor";
            this.txtNombreReceptor.Size = new System.Drawing.Size(135, 20);
            this.txtNombreReceptor.TabIndex = 6;
            // 
            // lblMotivoLabel
            // 
            this.lblMotivoLabel.AutoSize = true;
            this.lblMotivoLabel.Location = new System.Drawing.Point(27, 81);
            this.lblMotivoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotivoLabel.Name = "lblMotivoLabel";
            this.lblMotivoLabel.Size = new System.Drawing.Size(107, 13);
            this.lblMotivoLabel.TabIndex = 7;
            this.lblMotivoLabel.Text = "Motivo intento fallido:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Enabled = false;
            this.txtMotivo.Location = new System.Drawing.Point(134, 79);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(286, 20);
            this.txtMotivo.TabIndex = 7;
            // 
            // btnRegistrarHDR
            // 
            this.btnRegistrarHDR.Location = new System.Drawing.Point(357, 107);
            this.btnRegistrarHDR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarHDR.Name = "btnRegistrarHDR";
            this.btnRegistrarHDR.Size = new System.Drawing.Size(80, 20);
            this.btnRegistrarHDR.TabIndex = 8;
            this.btnRegistrarHDR.Text = "Registrar HDR";
            this.btnRegistrarHDR.UseVisualStyleBackColor = true;
            // 
            // grpGuias
            // 
            this.grpGuias.Controls.Add(this.dgvGuias);
            this.grpGuias.Location = new System.Drawing.Point(8, 244);
            this.grpGuias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpGuias.Name = "grpGuias";
            this.grpGuias.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpGuias.Size = new System.Drawing.Size(540, 259);
            this.grpGuias.TabIndex = 2;
            this.grpGuias.TabStop = false;
            this.grpGuias.Text = "Hojas de ruta registradas en esta sesión";
            // 
            // dgvGuias
            // 
            this.dgvGuias.AllowUserToAddRows = false;
            this.dgvGuias.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvGuias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGuias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuias.ColumnHeadersHeight = 34;
            this.dgvGuias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroHDR,
            this.colGuia,
            this.colResultado,
            this.colReceptor,
            this.colEstado});
            this.dgvGuias.Location = new System.Drawing.Point(30, 32);
            this.dgvGuias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGuias.Name = "dgvGuias";
            this.dgvGuias.ReadOnly = true;
            this.dgvGuias.RowHeadersVisible = false;
            this.dgvGuias.RowHeadersWidth = 62;
            this.dgvGuias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuias.Size = new System.Drawing.Size(464, 195);
            this.dgvGuias.TabIndex = 0;
            // 
            // colNroHDR
            // 
            this.colNroHDR.FillWeight = 15F;
            this.colNroHDR.HeaderText = "N° HDR";
            this.colNroHDR.MinimumWidth = 8;
            this.colNroHDR.Name = "colNroHDR";
            this.colNroHDR.ReadOnly = true;
            // 
            // colGuia
            // 
            this.colGuia.FillWeight = 20F;
            this.colGuia.HeaderText = "N° Guía";
            this.colGuia.MinimumWidth = 8;
            this.colGuia.Name = "colGuia";
            this.colGuia.ReadOnly = true;
            // 
            // colResultado
            // 
            this.colResultado.FillWeight = 20F;
            this.colResultado.HeaderText = "Resultado";
            this.colResultado.MinimumWidth = 8;
            this.colResultado.Name = "colResultado";
            this.colResultado.ReadOnly = true;
            // 
            // colReceptor
            // 
            this.colReceptor.FillWeight = 25F;
            this.colReceptor.HeaderText = "Receptor";
            this.colReceptor.MinimumWidth = 8;
            this.colReceptor.Name = "colReceptor";
            this.colReceptor.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.FillWeight = 20F;
            this.colEstado.HeaderText = "Estado guía";
            this.colEstado.MinimumWidth = 8;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(402, 553);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(80, 20);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Finalizar rendición";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(488, 554);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 20);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmRendiciónHDR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 601);
            this.Controls.Add(this.grpFletero);
            this.Controls.Add(this.grpHDR);
            this.Controls.Add(this.grpGuias);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmRendiciónHDR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA — Recepcionar y rendir hojas de ruta";
            this.grpFletero.ResumeLayout(false);
            this.grpFletero.PerformLayout();
            this.grpHDR.ResumeLayout(false);
            this.grpHDR.PerformLayout();
            this.grpGuias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuias)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpFletero;
        private System.Windows.Forms.Label lblFleteroLabel;
        private System.Windows.Forms.TextBox txtFletero;
        private System.Windows.Forms.Button btnBuscarFletero;
        private System.Windows.Forms.Label lblNombreFletero;

        private System.Windows.Forms.GroupBox grpHDR;
        private System.Windows.Forms.Label lblNroHDRLabel;
        private System.Windows.Forms.TextBox txtNroHDR;
        private System.Windows.Forms.Label lblResultadoLabel;
        private System.Windows.Forms.RadioButton rbEntregada;
        private System.Windows.Forms.RadioButton rbIntentoFallido;
        private System.Windows.Forms.Label lblDNIReceptorLabel;
        private System.Windows.Forms.TextBox txtDNIReceptor;
        private System.Windows.Forms.Label lblNombreRecLabel;
        private System.Windows.Forms.TextBox txtNombreReceptor;
        private System.Windows.Forms.Label lblMotivoLabel;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnRegistrarHDR;

        private System.Windows.Forms.GroupBox grpGuias;
        private System.Windows.Forms.DataGridView dgvGuias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroHDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;

        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
    }
}