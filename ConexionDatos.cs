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
            cadenaConexion = "Data Source = localhost; Initial Catalog = FABRICA_AUTOMOTRIZ; Integrated Security = True";
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

        public DataTable MostrarDato(SqlCommand comando)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            comando.Connection = conexion;
            this.comando = comando;
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

    }
}
