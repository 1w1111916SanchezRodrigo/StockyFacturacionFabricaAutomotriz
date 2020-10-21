using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DistribuidoraCrelech
{
    public partial class Consultas : Form
    {
        ConexionDatos cxDato;
        public Consultas(ConexionDatos cxDato)
        {
            InitializeComponent();
            this.cxDato = cxDato;
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

            dgv1.DataSource = cxDato.MostrarDato(comandoTipPro);
        }

    }
}
