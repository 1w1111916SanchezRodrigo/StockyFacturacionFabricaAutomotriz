using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DistribuidoraCrelech.ConsultasForms
{
    public partial class frmConsulta3 : Form
    {
        ConexionDatos cxDato;
        public frmConsulta3()
        {
            InitializeComponent();
            cxDato = new ConexionDatos();
        }

        private void frmConsulta3_Load(object sender, EventArgs e)
        {
            cboLetra1.SelectedIndex = 0;
            cboLetra2.SelectedIndex = 0;
            consulta();
        }



        private void consulta()
        {
            string consultaSql = "SP_Primera_Factura";
            SqlCommand comando2 = new SqlCommand(consultaSql);
            comando2.CommandType = CommandType.StoredProcedure;
            comando2.Parameters.AddWithValue("@letra1", cboLetra1.SelectedItem);
            comando2.Parameters.AddWithValue("@letra2", cboLetra2.SelectedItem);
            dgvCons3.DataSource = cxDato.MostrarDatoCnParametro(comando2);
        }

        

        private void cboLetra1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboLetra2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consulta();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
