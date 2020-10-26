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
    public partial class frmConsulta6 : Form
    {
        ConexionDatos cxDato;

        public frmConsulta6()
        {
            InitializeComponent();
            cxDato = new ConexionDatos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            string consultaSql = "sp_vehiculos_entregados";
            SqlCommand comandoTipo = new SqlCommand(consultaSql);
            comandoTipo.CommandType = CommandType.StoredProcedure;
            comandoTipo.Parameters.AddWithValue("@fecha1", dtpFecha1.Value);
            comandoTipo.Parameters.AddWithValue("@fecha2", dtpFecha2.Value);

            dgvVehiculosEntregados.DataSource = cxDato.MostrarDatoCnParametro(comandoTipo);
        }

        private void frmConsulta6_Load(object sender, EventArgs e)
        {

        }
    }
}
