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
    public partial class frmReportes : Form
    {
        ConexionDatos Conexion = new ConexionDatos();
        public frmReportes()
        {
            InitializeComponent();
            Conexion.CargarComboString(cboTipoProducto, "TIPOS_PRODUCTOS", "id_tipo_producto", "descripcion");
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
         
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string strSQL = "select p.id_producto, p.descripcion, p.precio_venta, p.precio_mayo from PRODUCTOS p join tipos_productos tp on p.id_tipo_producto = tp.id_tipo_producto where tp.descripcion like '"+ cboTipoProducto.Text+"%'";
            if (cboTipoProducto.SelectedIndex >= 0)
            {
                DataTable1BindingSource.DataSource = Conexion.consulta(strSQL);
                reportViewer1.RefreshReport();
            }
            else {
                MessageBox.Show("Seleccione un tipo de producto");
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
               if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void btnImprimirFiltro_Click(object sender, EventArgs e)
        {
            string strSQL = "select p.id_producto, p.descripcion, p.precio_venta, p.precio_mayo from PRODUCTOS p join tipos_productos tp on p.id_tipo_producto = tp.id_tipo_producto where tp.descripcion like '" + cboTipoProducto.Text + "%' and p.precio_venta>"+txtPrecio.Text+"'";
            if (cboTipoProducto.SelectedIndex >= 0 && txtPrecio.Text!=null)
            {
                DataTable1BindingSource.DataSource = Conexion.consulta(strSQL);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de producto y un precio");
            }
        }
    }
}
