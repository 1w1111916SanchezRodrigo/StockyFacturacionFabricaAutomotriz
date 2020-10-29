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
    public partial class frmConsulta7 : Form
    {
        ConexionDatos cxDato = new ConexionDatos();
        public frmConsulta7()
        {
            InitializeComponent();
        }

        private void frmConsulta7_Load(object sender, EventArgs e)
        {
            cxDato.CargarCombo(cboTipoProd, "TIPOS_PRODUCTOS", "id_tipo_producto", "descripcion");
            
        }

        private void actualizarInfo() {
            string consultaSQL = "pa_facturas_importe_mayor";
           
            //try
            //{
            //    a = int.Parse(txtImporte.Text);
            //}
            //catch (OverflowException)
            //{
            //    MessageBox.Show("El numero es demasiado grande, Elija otro");
            //    txtImporte.Clear();
            //}

            SqlCommand comandoTipo = new SqlCommand(consultaSQL);
            comandoTipo.CommandType = CommandType.StoredProcedure;
            comandoTipo.Parameters.AddWithValue("@importe", int.Parse(txtImporte.Text));
            comandoTipo.Parameters.AddWithValue("@tipo", cboTipoProd.SelectedValue);

            dgvFacturas.DataSource = cxDato.MostrarDatoCnParametro(comandoTipo);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtImporte.Text))
            {
                MessageBox.Show("Debe ingresar un número");
            }
            else
            {
                
                    actualizarInfo();
                    txtImporte.Clear();
                
            }
          
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

