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
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.grpFletero = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblFleteroLabel = new System.Windows.Forms.Label();
            this.txtFletero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarGuia = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.lblError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpEncomiendas = new System.Windows.Forms.GroupBox();
            this.lvGuias = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.grpFletero.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpEncomiendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMotivo
            // 
            this.txtMotivo.Enabled = false;
            this.txtMotivo.Location = new System.Drawing.Point(196, 222);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(300, 26);
            this.txtMotivo.TabIndex = 7;
            // 
            // grpFletero
            // 
            this.grpFletero.Controls.Add(this.label6);
            this.grpFletero.Controls.Add(this.button2);
            this.grpFletero.Controls.Add(this.lblFleteroLabel);
            this.grpFletero.Controls.Add(this.txtFletero);
            this.grpFletero.Location = new System.Drawing.Point(12, 12);
            this.grpFletero.Name = "grpFletero";
            this.grpFletero.Size = new System.Drawing.Size(535, 98);
            this.grpFletero.TabIndex = 24;
            this.grpFletero.TabStop = false;
            this.grpFletero.Text = "Identificación del fletero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(20, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(359, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "No se encuentra, Verifique ID o DNI nuevamente.";
            this.label6.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(367, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 49);
            this.button2.TabIndex = 24;
            this.button2.Text = "Seleccionar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblFleteroLabel
            // 
            this.lblFleteroLabel.AutoSize = true;
            this.lblFleteroLabel.Location = new System.Drawing.Point(35, 35);
            this.lblFleteroLabel.Name = "lblFleteroLabel";
            this.lblFleteroLabel.Size = new System.Drawing.Size(133, 20);
            this.lblFleteroLabel.TabIndex = 0;
            this.lblFleteroLabel.Text = "Ingresar ID / DNI:";
            // 
            // txtFletero
            // 
            this.txtFletero.Location = new System.Drawing.Point(186, 29);
            this.txtFletero.Name = "txtFletero";
            this.txtFletero.Size = new System.Drawing.Size(136, 26);
            this.txtFletero.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Fletero seleccionado:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(186, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 22);
            this.label4.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnBuscarGuia);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMotivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(535, 402);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendicion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 49);
            this.button1.TabIndex = 25;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBuscarGuia
            // 
            this.btnBuscarGuia.Location = new System.Drawing.Point(367, 31);
            this.btnBuscarGuia.Name = "btnBuscarGuia";
            this.btnBuscarGuia.Size = new System.Drawing.Size(129, 49);
            this.btnBuscarGuia.TabIndex = 23;
            this.btnBuscarGuia.Text = "Seleccionar ";
            this.btnBuscarGuia.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(331, 178);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(135, 24);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.Text = "Intento Fallido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Seleccione una opcion:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(211, 178);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(109, 24);
            this.radioButton4.TabIndex = 20;
            this.radioButton4.Text = "Entregada";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(17, 92);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(503, 20);
            this.lblError.TabIndex = 22;
            this.lblError.Text = "No se ha encontrado una HDR con ese Numero. Intente nuevamente.";
            this.lblError.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(174, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 22);
            this.label8.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Nro de HDR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "HDR Nro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Motivo intento fallido:";
            // 
            // grpEncomiendas
            // 
            this.grpEncomiendas.Controls.Add(this.lvGuias);
            this.grpEncomiendas.Location = new System.Drawing.Point(12, 608);
            this.grpEncomiendas.Name = "grpEncomiendas";
            this.grpEncomiendas.Size = new System.Drawing.Size(535, 190);
            this.grpEncomiendas.TabIndex = 31;
            this.grpEncomiendas.TabStop = false;
            this.grpEncomiendas.Text = "Resumen de HDR Cumplidas";
            // 
            // lvGuias
            // 
            this.lvGuias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvGuias.Enabled = false;
            this.lvGuias.FullRowSelect = true;
            this.lvGuias.GridLines = true;
            this.lvGuias.HideSelection = false;
            this.lvGuias.Location = new System.Drawing.Point(13, 41);
            this.lvGuias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvGuias.Name = "lvGuias";
            this.lvGuias.Size = new System.Drawing.Size(483, 133);
            this.lvGuias.TabIndex = 2;
            this.lvGuias.UseCompatibleStateImageBehavior = false;
            this.lvGuias.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nro HDR";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Localidad";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Direccion";
            this.columnHeader4.Width = 120;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(35, 353);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(333, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Esta HDR tiene 2 intentos fallidos de entrega.";
            this.label9.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.Location = new System.Drawing.Point(367, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 49);
            this.button3.TabIndex = 28;
            this.button3.Text = "Iniciar Devolución";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(198, 819);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 28);
            this.button4.TabIndex = 32;
            this.button4.Text = "Finalizar e Imprimir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(419, 819);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 28);
            this.button5.TabIndex = 33;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // RendiciónHDRdeEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 877);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.grpEncomiendas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpFletero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RendiciónHDRdeEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA — Recepcionar y rendir hojas de ruta";
            this.grpFletero.ResumeLayout(false);
            this.grpFletero.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpEncomiendas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.GroupBox grpFletero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblFleteroLabel;
        private System.Windows.Forms.TextBox txtFletero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscarGuia;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpEncomiendas;
        private System.Windows.Forms.ListView lvGuias;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}