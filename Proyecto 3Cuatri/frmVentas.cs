﻿using System;
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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmMenu frmmenu = new frmMenu();
            frmmenu.Show();
            this.Hide();
            this.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmImprimir frmimprimir = new frmImprimir();
            frmimprimir.Show();
            this.Hide();
            this.Visible = false;
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
