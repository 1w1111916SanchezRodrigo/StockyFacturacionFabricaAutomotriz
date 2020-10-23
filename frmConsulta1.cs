using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistribuidoraCrelech.ConsultasForms
{
    public partial class frmConsulta1 : Form
    {
        ConexionDatos cxDato;
        public frmConsulta1()
        {
            InitializeComponent();
            cxDato = new ConexionDatos();
        }
    }
}
