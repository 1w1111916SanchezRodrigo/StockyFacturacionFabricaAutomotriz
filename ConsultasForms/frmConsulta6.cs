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
        ConexionDatos cxDato = new ConexionDatos();

        public frmConsulta6()
        {
            InitializeComponent();
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            c
            string secuenciaSql = "sp_vehiculos_entregados";
            SqlCommand comandoTipPro = new SqlCommand(secuenciaSql);
            comandoTipPro.CommandType = CommandType.StoredProcedure;
            comandoTipPro.Parameters.AddWithValue("@fecha1", dtpFecha1.Value);
            //comandoTipPro.Parameters.AddWithValue("@fecha2", dtpFecha2.Value);

            dgvVehiculosEntregados.DataSource = cxDato.MostrarDatoCnParametro(comandoTipPro);
        }
    }
}
