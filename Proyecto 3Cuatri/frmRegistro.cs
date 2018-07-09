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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registrado exitosamente");
            frmBienvenido frmBien = new frmBienvenido();
            frmBien.Show();
            this.Hide();
            this.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
