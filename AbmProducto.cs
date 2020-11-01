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
    public partial class AbmProducto : Form
    {
        ConexionDatos oDato = new ConexionDatos();
        bool nuevo;

        const int tam = 9999;
        Producto[] aProducto = new Producto[tam];

        public AbmProducto()
        {
            InitializeComponent();
            for (int i = 0; i < tam; i++)
            {
                aProducto[i] = null;
            }
            nuevo = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AbmProducto_Load(object sender, EventArgs e)
        {
            oDato.CargarCombo(cboRubro, "Rubros", "id_rubro", "descripcion");
            oDato.CargarCombo(cboColor, "Colores", "id_color", "descripcion");
            oDato.CargarCombo(cboTipoProd,"Tipos_Productos", "id_tipo_producto","descripcion");
        }

        private void lblIdProd_Click(object sender, EventArgs e)
        {

        }

        private bool validarTexto()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe Ingresar Descripcion");
                return false;
            }
            if (string.IsNullOrEmpty(txtIdProd.Text))
            {
                MessageBox.Show("Debe Ingresar id Producto");
                return false;
            }
            if(string.IsNullOrEmpty(txtPrecioVenta.Text))
            {
                MessageBox.Show("Debe ingresar un precio de venta");
                return false;
            }
            if(string.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("Debe ingresar un stock");
                return false;
            }
            if (string.IsNullOrEmpty(txtStockMin.Text))
            {
                MessageBox.Show("Debe ingresar un stock minimo");
                return false;
            }
            if(string.IsNullOrEmpty(txtPrecioMayo.Text))
            {
                MessageBox.Show("debe seleccionar un precio por mayor");
                return false;
            }
            if (cboColor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un color");
                return false;
            }
            if (cboRubro.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un rubro");
                return false;
            }
            if (cboTipoProd.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de producto");
                return false;
            }
            return true;
        }
    }
}
