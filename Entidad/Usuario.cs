using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {
        public int Codigo { set; get; }
        public string Nombre { set; get; }
        public string Login { set; get; }
        public string Pass { set; get; }
        public string Apellidos { set; get; }
        public string Direccion { set; get; }
        public string Dni { set; get; }
        public string Telefono { set; get; }
        public bool Admin { set; get; }
    }
}
