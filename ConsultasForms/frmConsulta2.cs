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
    public partial class frmConsulta2 : Form
    {
        ConexionDatos cxDato;
        public frmConsulta2()
        {
            InitializeComponent();
            cxDato = new ConexionDatos();
        }

        private void frmConsulta2_Load(object sender, EventArgs e)
        {
            cxDato.CargarCombo(cboTipoProductoConsult2, "tipos_productos", "id_tipo_producto", "descripcion");
            
            
        }

        private void cboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string consultaSql = "PA_Producto_Mayor_Promedio";
            SqlCommand comandoTipo = new SqlCommand(consultaSql);
            comandoTipo.CommandType = CommandType.StoredProcedure;
            comandoTipo.Parameters.AddWithValue("@tipo", cboTipoProductoConsult2.SelectedValue);
            dgvCon2.DataSource = cxDato.MostrarDatoCnParametro(comandoTipo);

            string consultaSql2 = "PA_Promedio";
            SqlCommand comando = new SqlCommand(consultaSql2);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@tipo", cboTipoProductoConsult2.SelectedValue);

            lstPromedio.DataSource = cxDato.MostrarDatoCnParametro(comando);
            lstPromedio.DisplayMember = "Promedio";





        }
    }
}
