namespace TUTASA.Forms.Menu
{
    partial class frmMenuAgencia
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
            this.btnImposicion = new System.Windows.Forms.Button();
            this.btnEntrega = new System.Windows.Forms.Button();
            this.btnRecepcionHDR = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBienvenida.Location = new System.Drawing.Point(106, 25);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(142, 32);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido";
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // btnImposicion
            // 
            this.btnImposicion.Location = new System.Drawing.Point(30, 76);
            this.btnImposicion.Name = "btnImposicion";
            this.btnImposicion.Size = new System.Drawing.Size(280, 40);
            this.btnImposicion.TabIndex = 0;
            this.btnImposicion.Text = "Imposición";
            this.btnImposicion.UseVisualStyleBackColor = true;
            this.btnImposicion.Click += new System.EventHandler(this.btnImposicion_Click);
            // 
            // btnEntrega
            // 
            this.btnEntrega.Location = new System.Drawing.Point(30, 122);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(280, 40);
            this.btnEntrega.TabIndex = 1;
            this.btnEntrega.Text = "Registrar entrega";
            this.btnEntrega.UseVisualStyleBackColor = true;
            // 
            // btnRecepcionHDR
            // 
            this.btnRecepcionHDR.Location = new System.Drawing.Point(30, 168);
            this.btnRecepcionHDR.Name = "btnRecepcionHDR";
            this.btnRecepcionHDR.Size = new System.Drawing.Size(280, 40);
            this.btnRecepcionHDR.TabIndex = 2;
            this.btnRecepcionHDR.Text = "Recepcionar hojas de ruta";
            this.btnRecepcionHDR.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(30, 233);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(280, 40);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // frmMenuAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 307);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnImposicion);
            this.Controls.Add(this.btnEntrega);
            this.Controls.Add(this.btnRecepcionHDR);
            this.Controls.Add(this.btnCerrarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMenuAgencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA — Agencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnImposicion;
        private System.Windows.Forms.Button btnEntrega;
        private System.Windows.Forms.Button btnRecepcionHDR;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}