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
        int c;
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
            c = 0;
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
        private void cargarLista(string nombreTabla)
        {
            oDato.LeerTabla(nombreTabla);
            c = 0;
            while (oDato.pLector.Read())
            {
                Producto p = new Producto();
                if (!oDato.pLector.IsDBNull(0))
                    p.pIdProducto = oDato.pLector.GetInt32(0);
                if (!oDato.pLector.IsDBNull(1))
                    p.pDescripcion = oDato.pLector.GetString(1);
                if (!oDato.pLector.IsDBNull(2))
                    p.pTipoProd = oDato.pLector.GetInt32(2);
                if (!oDato.pLector.IsDBNull(3))
                    p.pIdRubro = oDato.pLector.GetInt32(3);
                if (!oDato.pLector.IsDBNull(4))
                    p.pMaterial = oDato.pLector.GetInt32(4);
                if (!oDato.pLector.IsDBNull(5))
                    p.pObservacion = oDato.pLector.GetString(5);
                if (!oDato.pLector.IsDBNull(6))
                    p.pColor = oDato.pLector.GetInt32(6);
                if (!oDato.pLector.IsDBNull(7))
                    p.pStock = oDato.pLector.GetInt32(7);
                if (!oDato.pLector.IsDBNull(8))
                    p.pStockMinimo = oDato.pLector.GetInt32(8);
                if (!oDato.pLector.IsDBNull(9))
                    p.pPrecioVenta = oDato.pLector.GetFloat(9);
                if (!oDato.pLector.IsDBNull(10))
                    p.pPrecioMayo = oDato.pLector.GetFloat(10);
                aProducto[c] = p;
                c++;

            }
            oDato.pLector.Close();
            oDato.Desconectar();
            lstProducto.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                lstProducto.Items.Add(aProducto[i].ToString());
            }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
