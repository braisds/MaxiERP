using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class VentaProducto
    {
        public int Codigo { set; get; }
        public Producto Producto { set; get; }
        public int Cantidad { set; get; }
        public double PrecioUnidad { set; get; }
        public Venta Venta { set; get; }
    }
}
