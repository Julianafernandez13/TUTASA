using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUTASA.ImposicionCD;

namespace TUTASA.Forms.CD
{
    public partial class frmImposicionCD : Form
    {
        //instancia del modelo de ImposicionCD
        private ImposicionCDModelo modelo = new ImposicionCDModelo();
        public frmImposicionCD()
        {
            InitializeComponent();
        }

        private void lvBultos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreRemitente_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmImposicionCD_Load(object sender, EventArgs e)
        {

        }
    }
}
