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

        

        private void AbmProducto_Load(object sender, EventArgs e)
        {
            oDato.CargarCombo(cboRubro, "Rubros", "id_rubro", "descripcion");
            oDato.CargarCombo(cboColor, "Colores", "id_color", "descripcion");
            oDato.CargarCombo(cboTipoProd,"Tipos_Productos", "id_tipo_producto","descripcion");
            oDato.CargarCombo(cboMaterial,"Materiales","id_material","descripcion");
            cargarLista("productos");
            habilitar(true);
            txtIdProd.Enabled = false;
            limpiar();
        }

        private void lblIdProd_Click(object sender, EventArgs e)
        {

        }
        private void cargarLista(string nombreTabla)
        {
            oDato.leerTabla(nombreTabla);
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
                    p.pPrecioVenta = Convert.ToDouble(oDato.pLector.GetDecimal(9));
                if (!oDato.pLector.IsDBNull(10))
                    p.pPrecioMayo = Convert.ToDouble(oDato.pLector.GetDecimal(10));
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
                MessageBox.Show("Debe Ingresar Descripcion","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            if (string.IsNullOrEmpty(txtPrecioVenta.Text))
            {
                MessageBox.Show("Debe ingresar un precio de venta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrEmpty(txtStock.Text))
            {
                MessageBox.Show("Debe ingresar un stock", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtStockMin.Text))
            {
                MessageBox.Show("Debe ingresar un stock minimo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrEmpty(txtPrecioMayo.Text))
            {
                MessageBox.Show("Debe seleccionar un precio por mayor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboColor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un color", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboRubro.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un rubro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboTipoProd.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboMaterial.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un material", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void habilitar(bool x)
        {
            txtDescripcion.Enabled = !x;
            txtObersavacion.Enabled = !x;
            txtPrecioMayo.Enabled = !x;
            txtPrecioVenta.Enabled = !x;
            txtStock.Enabled = !x;
            txtStockMin.Enabled = !x;
            cboColor.Enabled = !x;
            cboRubro.Enabled = !x;
            cboTipoProd.Enabled = !x;
            cboMaterial.Enabled = !x;
            btnNuevo.Enabled = x;
            btnEditar.Enabled = x;
            btnBorrar.Enabled = x;
            btnGrabar.Enabled = !x;
            lstProducto.Enabled = x;
        }

        private void cargarCampo(int p)
        {
            txtDescripcion.Text = aProducto[p].pDescripcion;
            txtIdProd.Text = Convert.ToString(aProducto[p].pIdProducto);
            txtPrecioMayo.Text = Convert.ToString(aProducto[p].pPrecioMayo);
            txtPrecioVenta.Text = Convert.ToString(aProducto[p].pPrecioVenta);
            txtStock.Text = Convert.ToString(aProducto[p].pStock);
            txtStockMin.Text = Convert.ToString(aProducto[p].pStockMinimo);
            txtObersavacion.Text = aProducto[p].pObservacion;
            cboColor.SelectedValue = aProducto[p].pColor;
            cboRubro.SelectedValue = aProducto[p].pIdRubro;
            cboTipoProd.SelectedValue = aProducto[p].pTipoProd;
            cboMaterial.SelectedValue = aProducto[p].pMaterial;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            limpiar();
        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstProducto.SelectedIndex>-1)
            cargarCampo(lstProducto.SelectedIndex);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(false);
            nuevo = true;
            limpiar();
            cargarLista("productos");
            txtDescripcion.Focus();
            
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            txtIdProd.Enabled = false;
            
            txtDescripcion.Focus();
            lstProducto.Enabled = true;

        }

        private void limpiar()
        {
            txtDescripcion.Clear();
            txtIdProd.Clear();
            txtObersavacion.Clear();
            txtPrecioMayo.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
            txtStockMin.Clear();
            cboColor.SelectedIndex = -1;
            cboMaterial.SelectedIndex = -1;
            cboRubro.SelectedIndex = -1;
            cboTipoProd.SelectedIndex = -1;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (validarTexto())
            {
                string consultaSql = "";
                if (nuevo)
                {
                    Producto p = new Producto();
                    p.pDescripcion = txtDescripcion.Text;
                    p.pColor = (int)cboColor.SelectedValue;
                    p.pIdRubro = (int)cboRubro.SelectedValue;
                    p.pTipoProd = (int)cboTipoProd.SelectedValue;
                    p.pObservacion = txtObersavacion.Text;
                    p.pPrecioMayo = double.Parse(txtPrecioMayo.Text);
                    p.pPrecioVenta = double.Parse(txtPrecioVenta.Text);
                    p.pStock = int.Parse(txtStock.Text);
                    p.pStockMinimo = int.Parse(txtStockMin.Text);
                    p.pMaterial = (int)cboMaterial.SelectedValue;
                    consultaSql = $"insert into Productos (descripcion,id_tipo_producto,id_rubro,id_material,observaciones," +
                        $"id_color,stock,stock_minimo,precio_venta,precio_mayo)values('{p.pDescripcion}',{p.pTipoProd},{p.pIdRubro},{p.pMaterial},'{p.pObservacion}',{p.pColor},{p.pStock}," +
                        $"{p.pStockMinimo},{p.pPrecioVenta},{p.pPrecioMayo})";
                    oDato.actualizar(consultaSql);
                    limpiar();
                    habilitar(true);
                    nuevo = false;
                    cargarLista("productos");
                }
                else
                {
                    int i = lstProducto.SelectedIndex;

                    
                    aProducto[i].pDescripcion = txtDescripcion.Text;
                    aProducto[i].pColor = (int)cboColor.SelectedValue;
                    aProducto[i].pIdRubro = (int)cboRubro.SelectedValue;
                    aProducto[i].pTipoProd = (int)cboTipoProd.SelectedValue;
                    aProducto[i].pObservacion = txtObersavacion.Text;
                    aProducto[i].pPrecioMayo = double.Parse(txtPrecioMayo.Text);
                    aProducto[i].pPrecioVenta = double.Parse(txtPrecioVenta.Text);
                    aProducto[i].pStock = int.Parse(txtStock.Text);
                    aProducto[i].pStockMinimo = int.Parse(txtStockMin.Text);
                    aProducto[i].pMaterial = (int)cboMaterial.SelectedValue;

                    consultaSql = $"update productos set descripcion = '{aProducto[i].pDescripcion}',id_tipo_producto= {aProducto[i].pTipoProd},id_rubro = {aProducto[i].pIdRubro},id_material = {aProducto[i].pMaterial}" +
                        $",observaciones = '{aProducto[i].pObservacion}',id_color = {aProducto[i].pColor},stock = {aProducto[i].pStock},stock_minimo = {aProducto[i].pStockMinimo},precio_venta = {aProducto[i].pPrecioVenta}," +
                        $"precio_mayo = {aProducto[i].pPrecioMayo} where id_producto = {aProducto[i].pIdProducto}";
                    oDato.actualizar(consultaSql);
                    habilitar(true);
                    nuevo = false;
                    cargarLista("productos");
                }
                
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a este Producto?", "ELIMINANDO",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Error,
                                                        MessageBoxDefaultButton.Button2)
                                                        == DialogResult.Yes)

            {
                string consultaSQL = "DELETE FROM Productos WHERE id_producto = " + aProducto[lstProducto.SelectedIndex].pIdProducto;
                oDato.actualizar(consultaSQL);
                cargarLista("Productos");
                limpiar();



            }
        }

        

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {

                e.Handled = true;

            }
        }

        

        private void txtPrecioMayo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {

                e.Handled = true;

            }
        }

        private void txtStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {

                e.Handled = true;

            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {

                e.Handled = true;

            }
        }
    }
}
