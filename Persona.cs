using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraCrelech
{
    abstract class Persona
    {
        private string Nombre;
        private int Dni;
        private bool Sexo;

        public Persona()
        {
            Nombre = "";
            Dni = 0;
            Sexo = true;
        }
        public Persona (string Nombre, int Dni, bool Sexo)
        {
            this.Nombre = Nombre;
            this.Dni = Dni;
            this.Sexo = Sexo;
        }
        public string pNombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }

        public int pDni
        {
            set { Dni = value; }
            get { return Dni; }
        }
        public bool pSexo
        {
            set { Sexo = value; }
            get { return Sexo; }
        }

        public override string ToString()
        {
            string StringSexo = "";
            if (Sexo)
                StringSexo = "Masculino";
            else
                StringSexo = "Femenino";
            return "Nombre: " + Nombre + "\n DNI: " + Dni + "\n Sexo:" + StringSexo ; 
        }
    }
}
