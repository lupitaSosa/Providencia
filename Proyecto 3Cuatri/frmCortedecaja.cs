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
    public partial class frmCortedecaja : Form
    {
        public frmCortedecaja()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmImprimirCortedeCaja frmimcodca = new frmImprimirCortedeCaja();
            frmimcodca.Show();
            this.Hide();
            this.Visible = false;
        }

        private void frmCortedecaja_Load(object sender, EventArgs e)
        {

        }
    }
}
