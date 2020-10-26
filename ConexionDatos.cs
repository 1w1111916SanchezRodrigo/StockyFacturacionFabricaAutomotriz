using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DistribuidoraCrelech
{
    public class ConexionDatos
    {
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        string cadenaConexion;

        public ConexionDatos()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            cadenaConexion = "Data Source=fabricaautomotriz.cbqr9awpp7z2.us-east-1.rds.amazonaws.com,1433;Initial Catalog=FABRICA_AUTOMOTRIZ;User ID=admin;password=fabricaautomotriz";
            //  cadenaConexion = "Data Source = localhost; Initial Catalog = FABRICA_AUTOMOTRIZ; Integrated Security = True"; //Rodri
            
        }
        public ConexionDatos (string cadenaConexion)
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            this.cadenaConexion = cadenaConexion;
        }

        public SqlDataReader pLector { get => lector; set => lector = value; }

        public void Conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        public void Desconectar()
        {
            conexion.Close();
        }

        public DataTable MostrarDatoCnParametro(SqlCommand comando)
        {
            
            DataTable tabla = new DataTable();
            
            comando.Connection = conexion;
            conexion.ConnectionString = cadenaConexion;
            this.comando = comando;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            conexion.Open();
            adapter.Fill(tabla);
            Desconectar();
            return tabla;
        }

        public void CargarCombo(ComboBox combo, string nombreTabla , string pk , string campoDisplay)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = "SELECT * FROM "+ @nombreTabla;
            comando.Parameters.AddWithValue(@nombreTabla, nombreTabla);
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            combo.ValueMember = pk;
            combo.DataSource = tabla;
            combo.DisplayMember = campoDisplay;
           // combo.SelectedIndex = 0;
        }

        

        public DataTable LeerTabla(string nombreTabla)
        {

            DataTable tabla = new DataTable();
            comando.Connection = conexion;
            Conectar();
            comando.CommandText = "SELECT * FROM " + @nombreTabla;
            comando.Parameters.AddWithValue(@nombreTabla, nombreTabla);
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }
    }
}
