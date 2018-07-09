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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            frmIngreso frmingre = new frmIngreso();
            frmingre.Show();
            this.Hide();
            this.Visible = false;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas frmventas = new frmVentas();
            frmventas.Show();
            this.Hide();
            this.Visible = false;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            frmInventario frminven = new frmInventario();
            frminven.Show();
            this.Hide();
            this.Visible = false;
        }

        private void btnCdcaja_Click(object sender, EventArgs e)
        {
            frmCortedecaja frmcodca = new frmCortedecaja();
            frmcodca.Show();
            this.Hide();
            this.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
