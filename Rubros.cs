using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraCrelech
{
    class Rubros
    {
        int id_Rubro;
        string descripcionRubros;

        public Rubros(int id_Rubro, string descripcionRubros)
        {
            this.Id_Rubro = id_Rubro;
            this.DescripcionRubros = descripcionRubros;
        }

        public int Id_Rubro { get => id_Rubro; set => id_Rubro = value; }
        public string DescripcionRubros { get => descripcionRubros; set => descripcionRubros = value; }
    }
}
