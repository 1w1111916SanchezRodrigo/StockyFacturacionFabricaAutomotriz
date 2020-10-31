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
    public partial class NuevaFactura : Form
    {
        ConexionDatos cxDatos = new ConexionDatos();
        public NuevaFactura()
        {
            InitializeComponent();
        }

        private void NuevaFactura_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn comboColumnCod = dataGridView1.Columns["cod_prod"] as DataGridViewComboBoxColumn;
            cxDatos.CargarCombo(comboColumnCod, "productos", "id_producto", "id_producto");

            DataGridViewComboBoxColumn comboColumnDesc = dataGridView1.Columns["descripcion"] as DataGridViewComboBoxColumn;
            cxDatos.CargarCombo(comboColumnDesc, "productos", "id_producto", "descripcion");

            cxDatos.CargarComboCl(cmbCliente, "clientes", "id_cliente");

            label6.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
