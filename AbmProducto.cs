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
    }
}
