using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraCrelech
{
    class Producto
    {
        int idProducto,tipoProd,idRubro,material,color,stock,stockMinimo;
        string descripcion,observacion;
        float precioVenta, precioMayo;



        public int pIdProducto { get => idProducto; set => idProducto = value; }
        public int pTipoProd { get => tipoProd; set => tipoProd = value; }
        public int pIdRubro { get => idRubro; set => idRubro = value; }
        public int pMaterial { get => material; set => material = value; }
        public int pColor { get => color; set => color = value; }
        public int pStock { get => stock; set => stock = value; }
        public int pStockMinimo { get => stockMinimo; set => stockMinimo = value; }
        public float pPrecioVenta { get => precioVenta; set => precioVenta = value; }
        public float pPrecioMayo { get => precioMayo; set => precioMayo = value; }
        public string pDescripcion { get => descripcion; set => descripcion = value; }
        public string pObservacion { get => observacion; set => observacion = value; }

        public override string ToString()
        {
            return idProducto +"-"+descripcion;
        }
    }
}
