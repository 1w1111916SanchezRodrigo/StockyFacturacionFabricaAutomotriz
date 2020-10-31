using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraCrelech
{
    class TiposProductos
    {
        int id_tipo_producto;
        string tipoProducto;

        public TiposProductos(int id_tipo_producto, string tipoProducto)
        {
            this.Id_tipo_producto = id_tipo_producto;
            this.TipoProducto = tipoProducto;
        }

        public int Id_tipo_producto { get => id_tipo_producto; set => id_tipo_producto = value; }
        public string TipoProducto { get => tipoProducto; set => tipoProducto = value; }
    }
}
