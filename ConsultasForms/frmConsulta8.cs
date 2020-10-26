using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistribuidoraCrelech.ConsultasForms
{
    public partial class frmConsulta8 : Form
    {
        ConexionDatos cxDato;
        public frmConsulta8()
        {
            InitializeComponent();
            cxDato = new ConexionDatos();
        }

        private void frmConsulta8_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select * from Vs_autoparte_stock");
            dgvStock.DataSource = cxDato.MostrarDatoCnParametro(comando);
            
        }
    }
}
