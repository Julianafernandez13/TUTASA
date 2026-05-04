namespace TUTASA.Forms.Agencia
{
    partial class frmRecepcionHDRAgencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grpRegistradas = new System.Windows.Forms.GroupBox();
            this.dgvHDR = new System.Windows.Forms.DataGridView();
            this.colNroHDR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpRegistradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleName = "grpFletero";
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificación del fletero";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AccessibleName = "Código / DNI:";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código / DNI:";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "txtFletero\n";
            this.textBox1.Location = new System.Drawing.Point(100, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AccessibleName = "btnBuscarFletero";
            this.button1.Location = new System.Drawing.Point(260, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar fletero";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AccessibleName = "lblNombreFletero";
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(70, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 22);
            this.label3.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleName = "grpHDR";
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la hoja de ruta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "N° de HDR:";
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "txtNroHDR";
            this.textBox2.Location = new System.Drawing.Point(90, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Resultado:";
            // 
            // radioButton1
            // 
            this.radioButton1.AccessibleName = "rbEntregada";
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(310, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Entregada";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AccessibleName = "rbIntentoFallido";
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(400, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Intento fallido";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "DNI receptor:";
            // 
            // textBox3
            // 
            this.textBox3.AccessibleName = "txtDNIReceptor";
            this.textBox3.Location = new System.Drawing.Point(100, 59);
            this.textBox3.MaxLength = 8;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nombre receptor:";
            // 
            // textBox4
            // 
            this.textBox4.AccessibleName = "txtNombreReceptor";
            this.textBox4.Location = new System.Drawing.Point(120, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(250, 22);
            this.textBox4.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Motivo:";
            // 
            // textBox5
            // 
            this.textBox5.AccessibleName = "txtMotivo";
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(70, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(400, 22);
            this.textBox5.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.AccessibleName = "btnRegistrarHDR";
            this.button2.Location = new System.Drawing.Point(578, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Registrar HDR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grpRegistradas
            // 
            this.grpRegistradas.AccessibleName = "grpRegistradas";
            this.grpRegistradas.Controls.Add(this.dgvHDR);
            this.grpRegistradas.Location = new System.Drawing.Point(12, 267);
            this.grpRegistradas.Name = "grpRegistradas";
            this.grpRegistradas.Size = new System.Drawing.Size(700, 190);
            this.grpRegistradas.TabIndex = 2;
            this.grpRegistradas.TabStop = false;
            this.grpRegistradas.Text = "Hojas de ruta registradas";
            // 
            // dgvHDR
            // 
            this.dgvHDR.AccessibleName = "dgvHDR";
            this.dgvHDR.AllowUserToAddRows = false;
            this.dgvHDR.AllowUserToDeleteRows = false;
            this.dgvHDR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNroHDR,
            this.colGuia,
            this.colResultado,
            this.colEstadoGuia});
            this.dgvHDR.Location = new System.Drawing.Point(10, 22);
            this.dgvHDR.Name = "dgvHDR";
            this.dgvHDR.ReadOnly = true;
            this.dgvHDR.RowHeadersVisible = false;
            this.dgvHDR.RowHeadersWidth = 51;
            this.dgvHDR.RowTemplate.Height = 24;
            this.dgvHDR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDR.Size = new System.Drawing.Size(678, 165);
            this.dgvHDR.TabIndex = 0;
            // 
            // colNroHDR
            // 
            this.colNroHDR.HeaderText = "N° HDR";
            this.colNroHDR.MinimumWidth = 6;
            this.colNroHDR.Name = "colNroHDR";
            this.colNroHDR.ReadOnly = true;
            // 
            // colGuia
            // 
            this.colGuia.HeaderText = "N° Guía";
            this.colGuia.MinimumWidth = 6;
            this.colGuia.Name = "colGuia";
            this.colGuia.ReadOnly = true;
            // 
            // colResultado
            // 
            this.colResultado.HeaderText = "Resultado";
            this.colResultado.MinimumWidth = 6;
            this.colResultado.Name = "colResultado";
            this.colResultado.ReadOnly = true;
            // 
            // colEstadoGuia
            // 
            this.colEstadoGuia.HeaderText = "Estado guía";
            this.colEstadoGuia.MinimumWidth = 6;
            this.colEstadoGuia.Name = "colEstadoGuia";
            this.colEstadoGuia.ReadOnly = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AccessibleName = "btnFinalizar";
            this.btnFinalizar.Location = new System.Drawing.Point(480, 467);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(130, 30);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar rendición";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AccessibleName = "btnCancelar";
            this.btnCancelar.Location = new System.Drawing.Point(620, 467);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmRecepcionHDRAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 513);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.grpRegistradas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmRecepcionHDRAgencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA - Recepción de Hoja de Ruta en Agencia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpRegistradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox grpRegistradas;
        private System.Windows.Forms.DataGridView dgvHDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroHDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoGuia;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
    }
}