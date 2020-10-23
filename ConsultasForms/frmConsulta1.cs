using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DistribuidoraCrelech.ConsultasForms
{
    public partial class frmConsulta1 : Form
    {
        ConexionDatos cxDato ;
        public frmConsulta1()
        {
            InitializeComponent();
            cxDato = new ConexionDatos();
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            
            cxDato.CargarCombo(cmbTipoProdu, "tipos_productos", "id_tipo_producto", "descripcion");
            

        }
        private void cmbTipoProdu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secuenciaSql = "sp_productos_sn_ventas";
            SqlCommand comandoTipPro = new SqlCommand(secuenciaSql);
            comandoTipPro.CommandType = CommandType.StoredProcedure;
            comandoTipPro.Parameters.AddWithValue("@id_tipo_producto", cmbTipoProdu.SelectedValue);

            dgv1.DataSource = cxDato.MostrarDatoCnParametro(comandoTipPro);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
