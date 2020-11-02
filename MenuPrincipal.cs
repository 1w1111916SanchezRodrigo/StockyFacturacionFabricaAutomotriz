using System;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            menuStrip1.ForeColor = Color.BlanchedAlmond;

        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbmProducto abm = new AbmProducto();
            abm.Show();
            this.Close();

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultas Consulta = new frmConsultas();
            Consulta.Show();
            this.Close();
        }



        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
