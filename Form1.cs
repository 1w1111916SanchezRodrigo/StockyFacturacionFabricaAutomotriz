﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistribuidoraCrelech
{
    public partial class DistribuidoraCrelech : Form
    {
        public DistribuidoraCrelech()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btNuevaFact_Click(object sender, EventArgs e)
        {
            Form NuevaFactura = new NuevaFactura();
            NuevaFactura.Show();
        }
    }
}
