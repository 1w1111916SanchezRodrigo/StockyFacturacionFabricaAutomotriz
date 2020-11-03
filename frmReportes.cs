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
            Conexion.CargarCombo(cboTipoProducto, "TIPOS_PRODUCTOS", "id_tipo_producto", "descripcion");
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
         
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string strSQL = "select pr.id_producto 'Codigo',pr.descripcion 'Descripcion', tp.descripcion 'Tipo', ru.descripcion 'Rubro', ma.descripcion 'Material',"
                           + "co.descripcion 'Color', pr.stock 'Stock', pr.stock_minimo 'StockMinimo', precio_mayo 'PrecioMayo', pr.precio_venta 'PrecioVenta'"
                            + " from productos pr join tipos_productos tp on pr.id_tipo_producto = tp.id_tipo_producto join RUBROS ru on ru.id_rubro = pr.id_rubro left"
                            + " join MATERIALES ma on ma.id_material = pr.id_producto left join COLORES co on co.id_color = pr.id_color";
            //string strSQL = "select p.id_producto, p.descripcion, p.precio_venta, p.precio_mayo from PRODUCTOS p join tipos_productos tp on p.id_tipo_producto = tp.id_tipo_producto where tp.descripcion like '"+ cboTipoProducto.Text+"%'";
            //if (cboTipoProducto.SelectedIndex >= 0)
            //{
            DataTable1BindingSource.DataSource = Conexion.consulta(strSQL);
            reportViewer1.RefreshReport();
            //}
            //else 
            //{
            //    MessageBox.Show("Seleccione un tipo de producto");
            //}
            //this.DataTable1TableAdapter.Fill(this.DataSetPrincipal.DataTable1);

            //this.reportViewer1.RefreshReport();

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

            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                string strSQL = $"select pr.id_producto 'Codigo',pr.descripcion 'Descripcion', tp.descripcion 'Tipo', ru.descripcion 'Rubro', ma.descripcion 'Material',"
                + $"co.descripcion 'Color', pr.stock 'Stock', pr.stock_minimo 'StockMinimo', pr.precio_mayo 'PrecioMayo', pr.precio_venta 'PrecioVenta'"
                + $" from productos pr join tipos_productos tp on pr.id_tipo_producto = tp.id_tipo_producto join RUBROS ru on ru.id_rubro = pr.id_rubro left"
                + $" join MATERIALES ma on ma.id_material = pr.id_producto left join COLORES co on co.id_color = pr.id_color"
                + $" where tp.descripcion like '{cboTipoProducto.Text}%'";
                
                DataTable1BindingSource.DataSource = Conexion.consulta(strSQL);
                reportViewer1.RefreshReport();
            }
            else
            {
                string strSQL = $"select pr.id_producto 'Codigo',pr.descripcion 'Descripcion', tp.descripcion 'Tipo', ru.descripcion 'Rubro', ma.descripcion 'Material',"
                + $"co.descripcion 'Color', pr.stock 'Stock', pr.stock_minimo 'StockMinimo', pr.precio_mayo 'PrecioMayo', pr.precio_venta 'PrecioVenta'"
                + $" from productos pr join tipos_productos tp on pr.id_tipo_producto = tp.id_tipo_producto join RUBROS ru on ru.id_rubro = pr.id_rubro left"
                + $" join MATERIALES ma on ma.id_material = pr.id_producto left join COLORES co on co.id_color = pr.id_color"
                + $" where tp.descripcion like '{cboTipoProducto.Text}%' and pr.precio_venta > {txtPrecio.Text}";

                DataTable1BindingSource.DataSource = Conexion.consulta(strSQL);
                reportViewer1.RefreshReport();
            }


        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
