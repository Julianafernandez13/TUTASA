namespace TUTASA.Forms.Menu
{
    partial class frmMenuCallCenter
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnSolicitudRetiro = new System.Windows.Forms.Button();
            this.btnConsultaTracking = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBienvenida.Location = new System.Drawing.Point(101, 19);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(142, 32);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido";
            // 
            // btnSolicitudRetiro
            // 
            this.btnSolicitudRetiro.Location = new System.Drawing.Point(30, 70);
            this.btnSolicitudRetiro.Name = "btnSolicitudRetiro";
            this.btnSolicitudRetiro.Size = new System.Drawing.Size(280, 40);
            this.btnSolicitudRetiro.TabIndex = 1;
            this.btnSolicitudRetiro.Text = "Solicitud de Retiro";
            this.btnSolicitudRetiro.Click += new System.EventHandler(this.btnSolicitudRetiro_Click);
            // 
            // btnConsultaTracking
            // 
            this.btnConsultaTracking.Location = new System.Drawing.Point(30, 120);
            this.btnConsultaTracking.Name = "btnConsultaTracking";
            this.btnConsultaTracking.Size = new System.Drawing.Size(280, 40);
            this.btnConsultaTracking.TabIndex = 2;
            this.btnConsultaTracking.Text = "Consultar tracking";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(30, 181);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(280, 40);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmMenuCallCenter
            // 
            this.ClientSize = new System.Drawing.Size(337, 244);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnSolicitudRetiro);
            this.Controls.Add(this.btnConsultaTracking);
            this.Controls.Add(this.btnCerrarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMenuCallCenter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TUTASA — Call Center";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnSolicitudRetiro;
        private System.Windows.Forms.Button btnConsultaTracking;
        private System.Windows.Forms.Button btnCerrarSesion;

    }
}