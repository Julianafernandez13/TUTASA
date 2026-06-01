namespace TUTASA.Forms.Menu
{
    partial class frmMenuCD
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
            this.btnImposicionCD = new System.Windows.Forms.Button();
            this.btnAdmision = new System.Windows.Forms.Button();
            this.btnConfeccionHDR = new System.Windows.Forms.Button();
            this.btnRendicionHDR = new System.Windows.Forms.Button();
            this.btnDespacho = new System.Windows.Forms.Button();
            this.btnRecepcionTransporte = new System.Windows.Forms.Button();
            this.btnEntregaCD = new System.Windows.Forms.Button();
            this.btnTracking = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBienvenida.Location = new System.Drawing.Point(131, 19);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(142, 32);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido";
            // 
            // btnImposicionCD
            // 
            this.btnImposicionCD.Location = new System.Drawing.Point(30, 70);
            this.btnImposicionCD.Name = "btnImposicionCD";
            this.btnImposicionCD.Size = new System.Drawing.Size(352, 35);
            this.btnImposicionCD.TabIndex = 0;
            this.btnImposicionCD.Text = "Imposición";
            this.btnImposicionCD.UseVisualStyleBackColor = true;
            // 
            // btnAdmision
            // 
            this.btnAdmision.Location = new System.Drawing.Point(30, 206);
            this.btnAdmision.Name = "btnAdmision";
            this.btnAdmision.Size = new System.Drawing.Size(352, 35);
            this.btnAdmision.TabIndex = 1;
            this.btnAdmision.Text = "Admisión";
            this.btnAdmision.UseVisualStyleBackColor = true;
            // 
            // btnConfeccionHDR
            // 
            this.btnConfeccionHDR.Location = new System.Drawing.Point(30, 114);
            this.btnConfeccionHDR.Name = "btnConfeccionHDR";
            this.btnConfeccionHDR.Size = new System.Drawing.Size(352, 35);
            this.btnConfeccionHDR.TabIndex = 2;
            this.btnConfeccionHDR.Text = "HDR de Retiro";
            this.btnConfeccionHDR.UseVisualStyleBackColor = true;
            // 
            // btnRendicionHDR
            // 
            this.btnRendicionHDR.Location = new System.Drawing.Point(30, 161);
            this.btnRendicionHDR.Name = "btnRendicionHDR";
            this.btnRendicionHDR.Size = new System.Drawing.Size(352, 35);
            this.btnRendicionHDR.TabIndex = 3;
            this.btnRendicionHDR.Text = "Rendición HDR de Retiro";
            this.btnRendicionHDR.UseVisualStyleBackColor = true;
            // 
            // btnDespacho
            // 
            this.btnDespacho.Location = new System.Drawing.Point(30, 250);
            this.btnDespacho.Name = "btnDespacho";
            this.btnDespacho.Size = new System.Drawing.Size(352, 35);
            this.btnDespacho.TabIndex = 4;
            this.btnDespacho.Text = "HDR de transporte";
            this.btnDespacho.UseVisualStyleBackColor = true;
            // 
            // btnRecepcionTransporte
            // 
            this.btnRecepcionTransporte.Location = new System.Drawing.Point(30, 295);
            this.btnRecepcionTransporte.Name = "btnRecepcionTransporte";
            this.btnRecepcionTransporte.Size = new System.Drawing.Size(352, 35);
            this.btnRecepcionTransporte.TabIndex = 5;
            this.btnRecepcionTransporte.Text = "Rendición HDR de Transporte";
            this.btnRecepcionTransporte.UseVisualStyleBackColor = true;
            // 
            // btnEntregaCD
            // 
            this.btnEntregaCD.Location = new System.Drawing.Point(30, 340);
            this.btnEntregaCD.Name = "btnEntregaCD";
            this.btnEntregaCD.Size = new System.Drawing.Size(352, 35);
            this.btnEntregaCD.TabIndex = 6;
            this.btnEntregaCD.Text = "Entrega en CD";
            this.btnEntregaCD.UseVisualStyleBackColor = true;
            // 
            // btnTracking
            // 
            this.btnTracking.Location = new System.Drawing.Point(30, 385);
            this.btnTracking.Name = "btnTracking";
            this.btnTracking.Size = new System.Drawing.Size(352, 35);
            this.btnTracking.TabIndex = 7;
            this.btnTracking.Text = "Consultar tracking";
            this.btnTracking.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(30, 450);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(352, 35);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 520);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnImposicionCD);
            this.Controls.Add(this.btnAdmision);
            this.Controls.Add(this.btnConfeccionHDR);
            this.Controls.Add(this.btnRendicionHDR);
            this.Controls.Add(this.btnDespacho);
            this.Controls.Add(this.btnRecepcionTransporte);
            this.Controls.Add(this.btnEntregaCD);
            this.Controls.Add(this.btnTracking);
            this.Controls.Add(this.btnCerrarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA — Centro de Distribución";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnImposicionCD;
        private System.Windows.Forms.Button btnAdmision;
        private System.Windows.Forms.Button btnConfeccionHDR;
        private System.Windows.Forms.Button btnRendicionHDR;
        private System.Windows.Forms.Button btnDespacho;
        private System.Windows.Forms.Button btnRecepcionTransporte;
        private System.Windows.Forms.Button btnEntregaCD;
        private System.Windows.Forms.Button btnTracking;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}