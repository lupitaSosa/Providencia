using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_3Cuatri
{
    public partial class frmImprimir : Form
    {
        public frmImprimir()
        {
            InitializeComponent();
        }

        private void btnSI_Click(object sender, EventArgs e)
        {
            frmImprimirVenta frmimpen = new frmImprimirVenta();
            frmimpen.Show();
            this.Hide();
            this.Visible = false;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
            this.Visible = false;
        }
    }
}
