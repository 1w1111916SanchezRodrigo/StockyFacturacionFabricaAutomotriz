using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DistribuidoraCrelech.ConsultasForms;

namespace DistribuidoraCrelech
{
    public partial class frmConsultas : Form
    {
        //private Button currentButton;
        //private Random random;
        //private int tempIndex;

        private Form activeForm;
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            picMiniLogo.Visible = true;
            picLogo.Visible = false;

            if (activeForm!= null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Productos que no se vendieron";
            OpenChildForm(new frmConsulta1(), sender);
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Mostrar el producto cuyo precio sea mayor al promedio de precio de los productos";  
            OpenChildForm(new frmConsulta2(), sender);
        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Primer factura emitida y el importe de la factura de cada cliente cuyo apellido no empieza con";
            OpenChildForm(new frmConsulta3(), sender);
        }

        private void btnConsulta4_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Porcentaje de compras por tipo de cliente";
            OpenChildForm(new frmConsulta4(), sender);
        }

        private void btnConsulta5_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Total anual y promedio de facturación mensual de producto";
            OpenChildForm(new frmConsulta5(), sender);
        }

        private void btnConsulta6_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Cantidad de vehiculos entregados";
            OpenChildForm(new frmConsulta6(), sender);
        }

        private void btnConsulta7_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Facturas cuyo importe es mayor al ingresado por tipo de producto";
            OpenChildForm(new frmConsulta7(), sender);
        }

        private void btnConsulta8_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Autopartes con Stock por debajo del mínimo";
            OpenChildForm(new frmConsulta8(), sender);
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {
            picMiniLogo.Visible = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void frmConsultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        //private Color SelectThemeColor()
        //{
        //    int index = random.Next(ThemeColor.ColorList.Count);
        //    while (tempIndex == index)
        //    {
        //        index = random.Next(ThemeColor.ColorList.Count);
        //    }
        //    tempIndex = index;
        //    string color = ThemeColor.ColorList[index];
        //    return ColorTranslator.FromHtml(color);
        //}
    }
}
