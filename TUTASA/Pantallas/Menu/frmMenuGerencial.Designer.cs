namespace TUTASA.Forms.Menu
{
    partial class frmMenuGerencial
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnEmitirFactura = new System.Windows.Forms.Button();
            this.btnCostoVsVentas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBienvenida.Location = new System.Drawing.Point(131, 20);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(142, 32);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido";
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // btnEmitirFactura
            // 
            this.btnEmitirFactura.Location = new System.Drawing.Point(30, 74);
            this.btnEmitirFactura.Name = "btnEmitirFactura";
            this.btnEmitirFactura.Size = new System.Drawing.Size(331, 40);
            this.btnEmitirFactura.TabIndex = 0;
            this.btnEmitirFactura.Text = "Emitir factura y consultar cuenta corriente";
            this.btnEmitirFactura.UseVisualStyleBackColor = true;
            // 
            // btnCostoVsVentas
            // 
            this.btnCostoVsVentas.Location = new System.Drawing.Point(30, 120);
            this.btnCostoVsVentas.Name = "btnCostoVsVentas";
            this.btnCostoVsVentas.Size = new System.Drawing.Size(331, 40);
            this.btnCostoVsVentas.TabIndex = 1;
            this.btnCostoVsVentas.Text = "Consultar resultado costo vs ventas";
            this.btnCostoVsVentas.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(30, 182);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(331, 41);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // frmMenuGerencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 261);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnEmitirFactura);
            this.Controls.Add(this.btnCostoVsVentas);
            this.Controls.Add(this.btnCerrarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMenuGerencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA — Gerencia";
            this.Load += new System.EventHandler(this.frmMenuGerencial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnEmitirFactura;
        private System.Windows.Forms.Button btnCostoVsVentas;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}