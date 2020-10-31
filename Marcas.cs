using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraCrelech
{
    class Marcas
    {
        int id_marca;
        string descripcionMarca;

        public Marcas(int id_marca, string descripcionMarca)
        {
            this.Id_marca = id_marca;
            this.DescripcionMarca = descripcionMarca;
        }

        public int Id_marca { get => id_marca; set => id_marca = value; }
        public string DescripcionMarca { get => descripcionMarca; set => descripcionMarca = value; }
    }
}
