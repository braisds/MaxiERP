using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {
        public int Codigo { set; get; }
        public string Nombre { set; get; }
        public double Precio { set; get; }
        public string Descripcion { set; get; }
        public int Stock { set; get; }
        public TipoProducto TipoProducto { set; get; }
        public string Marca { set; get; }
    }
}
