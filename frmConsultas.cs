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
       
        private Form activeForm;
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm!= null)
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
            OpenChildForm(new frmConsulta7(), sender);
        }

        private void btnConsulta8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmConsulta8(), sender);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {

        }
    }
}
