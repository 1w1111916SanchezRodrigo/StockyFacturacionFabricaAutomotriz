using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraCrelech
{
    class Stock
    {
        int id_stock;
        int stockProducto;
        int strockMinimo;

        public Stock(int id_stock, int stockProducto, int strockMinimo)
        {
            this.Id_stock = id_stock;
            this.StockProducto = stockProducto;
            this.StrockMinimo = strockMinimo;
        }

        public int Id_stock { get => id_stock; set => id_stock = value; }
        public int StockProducto { get => stockProducto; set => stockProducto = value; }
        public int StrockMinimo { get => strockMinimo; set => strockMinimo = value; }
    }
}
