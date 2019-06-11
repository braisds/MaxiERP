using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Venta
    {
        public int Codigo { set; get; }
        public Cliente Cliente { set; get; }
        public string NumVenta { set; get; }
        public DateTime Fecha { set; get; }
        public double Iva { set; get; }
        public VentaProducto[] Productos { set; get; }
    }
}
