namespace TUTASA.Forms.CD
{
    partial class frmRendiciónHDR
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
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
            this.grpFletero.Location = new System.Drawing.Point(12, 12);
            this.grpFletero.Name = "grpFletero";
            this.grpFletero.Size = new System.Drawing.Size(711, 60);
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
            this.txtFletero.Location = new System.Drawing.Point(113, 23);
            this.txtFletero.Name = "txtFletero";
            this.txtFletero.Size = new System.Drawing.Size(150, 26);
            this.txtFletero.TabIndex = 0;
            // 
            // btnBuscarFletero
            // 
            this.btnBuscarFletero.Location = new System.Drawing.Point(269, 22);
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
            this.lblNombreFletero.Location = new System.Drawing.Point(364, 23);
            this.lblNombreFletero.Name = "lblNombreFletero";
            this.lblNombreFletero.Size = new System.Drawing.Size(320, 22);
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
            this.grpHDR.Location = new System.Drawing.Point(12, 82);
            this.grpHDR.Name = "grpHDR";
            this.grpHDR.Size = new System.Drawing.Size(711, 171);
            this.grpHDR.TabIndex = 1;
            this.grpHDR.TabStop = false;
            this.grpHDR.Text = "Datos de la hoja de ruta";
            // 
            // lblNroHDRLabel
            // 
            this.lblNroHDRLabel.AutoSize = true;
            this.lblNroHDRLabel.Location = new System.Drawing.Point(10, 28);
            this.lblNroHDRLabel.Name = "lblNroHDRLabel";
            this.lblNroHDRLabel.Size = new System.Drawing.Size(91, 20);
            this.lblNroHDRLabel.TabIndex = 0;
            this.lblNroHDRLabel.Text = "N° de HDR:";
            // 
            // txtNroHDR
            // 
            this.txtNroHDR.Location = new System.Drawing.Point(104, 25);
            this.txtNroHDR.Name = "txtNroHDR";
            this.txtNroHDR.Size = new System.Drawing.Size(120, 26);
            this.txtNroHDR.TabIndex = 2;
            // 
            // lblResultadoLabel
            // 
            this.lblResultadoLabel.AutoSize = true;
            this.lblResultadoLabel.Location = new System.Drawing.Point(253, 28);
            this.lblResultadoLabel.Name = "lblResultadoLabel";
            this.lblResultadoLabel.Size = new System.Drawing.Size(86, 20);
            this.lblResultadoLabel.TabIndex = 3;
            this.lblResultadoLabel.Text = "Resultado:";
            // 
            // rbEntregada
            // 
            this.rbEntregada.AutoSize = true;
            this.rbEntregada.Checked = true;
            this.rbEntregada.Location = new System.Drawing.Point(353, 26);
            this.rbEntregada.Name = "rbEntregada";
            this.rbEntregada.Size = new System.Drawing.Size(109, 24);
            this.rbEntregada.TabIndex = 3;
            this.rbEntregada.TabStop = true;
            this.rbEntregada.Text = "Entregada";
            // 
            // rbIntentoFallido
            // 
            this.rbIntentoFallido.AutoSize = true;
            this.rbIntentoFallido.Location = new System.Drawing.Point(473, 26);
            this.rbIntentoFallido.Name = "rbIntentoFallido";
            this.rbIntentoFallido.Size = new System.Drawing.Size(130, 24);
            this.rbIntentoFallido.TabIndex = 4;
            this.rbIntentoFallido.Text = "Intento fallido";
            // 
            // lblDNIReceptorLabel
            // 
            this.lblDNIReceptorLabel.AutoSize = true;
            this.lblDNIReceptorLabel.Location = new System.Drawing.Point(10, 65);
            this.lblDNIReceptorLabel.Name = "lblDNIReceptorLabel";
            this.lblDNIReceptorLabel.Size = new System.Drawing.Size(104, 20);
            this.lblDNIReceptorLabel.TabIndex = 5;
            this.lblDNIReceptorLabel.Text = "DNI receptor:";
            // 
            // txtDNIReceptor
            // 
            this.txtDNIReceptor.Location = new System.Drawing.Point(117, 62);
            this.txtDNIReceptor.Name = "txtDNIReceptor";
            this.txtDNIReceptor.Size = new System.Drawing.Size(120, 26);
            this.txtDNIReceptor.TabIndex = 5;
            // 
            // lblNombreRecLabel
            // 
            this.lblNombreRecLabel.AutoSize = true;
            this.lblNombreRecLabel.Location = new System.Drawing.Point(250, 65);
            this.lblNombreRecLabel.Name = "lblNombreRecLabel";
            this.lblNombreRecLabel.Size = new System.Drawing.Size(132, 20);
            this.lblNombreRecLabel.TabIndex = 6;
            this.lblNombreRecLabel.Text = "Nombre receptor:";
            // 
            // txtNombreReceptor
            // 
            this.txtNombreReceptor.Location = new System.Drawing.Point(397, 62);
            this.txtNombreReceptor.Name = "txtNombreReceptor";
            this.txtNombreReceptor.Size = new System.Drawing.Size(200, 26);
            this.txtNombreReceptor.TabIndex = 6;
            // 
            // lblMotivoLabel
            // 
            this.lblMotivoLabel.AutoSize = true;
            this.lblMotivoLabel.Location = new System.Drawing.Point(10, 103);
            this.lblMotivoLabel.Name = "lblMotivoLabel";
            this.lblMotivoLabel.Size = new System.Drawing.Size(157, 20);
            this.lblMotivoLabel.TabIndex = 7;
            this.lblMotivoLabel.Text = "Motivo intento fallido:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Enabled = false;
            this.txtMotivo.Location = new System.Drawing.Point(171, 100);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(427, 26);
            this.txtMotivo.TabIndex = 7;
            // 
            // btnRegistrarHDR
            // 
            this.btnRegistrarHDR.Location = new System.Drawing.Point(582, 130);
            this.btnRegistrarHDR.Name = "btnRegistrarHDR";
            this.btnRegistrarHDR.Size = new System.Drawing.Size(120, 30);
            this.btnRegistrarHDR.TabIndex = 8;
            this.btnRegistrarHDR.Text = "Registrar HDR";
            this.btnRegistrarHDR.UseVisualStyleBackColor = true;
            // 
            // grpGuias
            // 
            this.grpGuias.Controls.Add(this.dgvGuias);
            this.grpGuias.Location = new System.Drawing.Point(12, 259);
            this.grpGuias.Name = "grpGuias";
            this.grpGuias.Size = new System.Drawing.Size(711, 200);
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
            this.dgvGuias.Location = new System.Drawing.Point(9, 24);
            this.dgvGuias.Name = "dgvGuias";
            this.dgvGuias.ReadOnly = true;
            this.dgvGuias.RowHeadersVisible = false;
            this.dgvGuias.RowHeadersWidth = 62;
            this.dgvGuias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuias.Size = new System.Drawing.Size(678, 165);
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
            this.btnFinalizar.Location = new System.Drawing.Point(490, 466);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(120, 30);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Finalizar rendición";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(620, 467);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(735, 22);
            this.statusStrip1.TabIndex = 12;
            // 
            // frmRendiciónHDR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 520);
            this.Controls.Add(this.grpFletero);
            this.Controls.Add(this.grpHDR);
            this.Controls.Add(this.grpGuias);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
            this.PerformLayout();

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
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}