using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class TipoProducto
    {
        public int Codigo { set; get; }
        public string Nombre { set; get; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }

}
