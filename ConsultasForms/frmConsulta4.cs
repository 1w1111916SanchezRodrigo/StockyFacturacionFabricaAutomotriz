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
    public partial class frmConsulta4 : Form
    {
        ConexionDatos cxDatos = new ConexionDatos();
        public frmConsulta4()
        {
            InitializeComponent();
        }

        private void frmConsulta4_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = cxDatos.LeerTabla("vw_porcentaje_x_tipo_cliente");

            chartDonut.Height = 600;
            chartDonut.Width = 700;
            //chartDonut.Titles.Add("Porcentaje de compras por tipo de cliente");
            chartDonut.Series["s1"]["PieLabelStyle"] = "Disabled";
            //To show the Chart Series label outside of Slice
            chartDonut.Series["s1"]["PieLabelStyle"] = "outside";
           // chartDonut.Series[0]["PieStartAngle"] = "90";
            //If you need a line to point to each values from slice you can use the below code

            chartDonut.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
            chartDonut.Series["s1"].Label = "#PERCENT{0.00 %}";
            chartDonut.Series["s1"].LegendText = "#VALX";


            chartDonut.Series["s1"].IsValueShownAsLabel = true;

            chartDonut.Series["s1"].Points.AddXY(tabla.Rows[0][1], tabla.Rows[0][0]);
            chartDonut.Series["s1"].Points.AddXY(tabla.Rows[1][1], tabla.Rows[1][0]);
            chartDonut.Series["s1"].Points.AddXY(tabla.Rows[2][1], tabla.Rows[2][0]);
            chartDonut.Series["s1"].Points.AddXY(tabla.Rows[3][1], tabla.Rows[3][0]);

        }
    }
}
