using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using DistribuidoraCrelech;

namespace DistribuidoraCrelech
{
    class Cliente
    {
        private string Nombre;
        private bool Sexo;
        private int Dni;
        private int Codigo;
        public Cliente(string nombre,int Codigo, bool sexo, int dni)
        {
            Nombre = nombre;
            this.Codigo = Codigo;
            Sexo = sexo;
            Dni = dni;
        }

        public Cliente()
        {
            Nombre = "";
            Codigo = 0;
            Sexo = true;
            Dni = 0;
        }

        public string pNombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        public bool pSexo
        {
            set { Sexo = value; }
            get { return Sexo; }
        }
        public int pDni
        {
            set { Dni = value; }
            get { return Dni; }
        }

        public int pCodigo
        {
            set { Codigo = value; }
            get { return Codigo; }
        }

        //public Alquiler pAlquilerCliente
        //{
        //    set { AlquilerCliente = value; }
        //    get { return AlquilerCliente; }
        //}
        public string toStringSexo()
        {
            //string SexoString = "";
            if (Sexo == true)
                // SexoString = "Masculino";
                return "Masculino";
            else
                return "femenino";
               // SexoString = "Femenino";
            //return SexoString;
        }
        
        public string tostring()
        {
            return "Nombre: " + Nombre + "\nCodigo: "+ Codigo + "\nSexo" + toStringSexo() + "\nDni: " + Dni;
        }
    }
}
