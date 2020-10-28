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
    public partial class frmConsulta5 : Form
    {
        ConexionDatos cxDato = new ConexionDatos();
        public frmConsulta5()
        {
            InitializeComponent();
        }

        private void frmConsulta5_Load(object sender, EventArgs e)
        {

            string consultaSql = "select distinct year(fecha)'Fecha' from facturas";
            cxDato.CargarComboString(cmbAnio, consultaSql, "Fecha", "Fecha");
            cxDato.CargarComboOpcTodos(cmbTipoProdu, "tipos_productos", "id_tipo_producto", "descripcion");
            actualizarInfo();
        }

        private void actualizarInfo()
        {
            string consultaSql = "sp_mostrar_facturas";
            SqlCommand comandoTipo = new SqlCommand(consultaSql);
            comandoTipo.CommandType = CommandType.StoredProcedure;
            comandoTipo.Parameters.AddWithValue("@anio", cmbAnio.SelectedValue);
            comandoTipo.Parameters.AddWithValue("@tipo_producto", cmbTipoProdu.SelectedValue);

            dgvFacturas.DataSource = cxDato.MostrarDatoCnParametro(comandoTipo);

            consultaSql = "sp_tot_factu_y_prom";
            comandoTipo.CommandText = consultaSql;

            DataTable tabla = new DataTable();
            tabla = cxDato.MostrarDatoCnParametro(comandoTipo);

            lblImpAnual.Text = tabla.Rows[0][1].ToString() + " $";
            lblPromMensual.Text = tabla.Rows[0][2].ToString()+ " $";
        }

        private void cmbAnio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            actualizarInfo();
        }

        private void cmbTipoProdu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            actualizarInfo();
        }
    }
}
