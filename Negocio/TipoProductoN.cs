using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TipoProductoN
    {
        private TipoProductoBD tipoProductoBD;

        public TipoProductoN()
        {
            tipoProductoBD = new TipoProductoBD();
        }

        /// <summary>
        /// Metodo obtener el listado tipo Producto
        /// </summary>
        /// <returns>array TipoProducto</returns>
        public TipoProducto[] ListadoTiposProductos()
        {
            TipoProducto[] tiposProducto = tipoProductoBD.ListadoTipoProductos();

            return tiposProducto;
        }

        /// <summary>
        /// Metodo para buscar un tipo producto por nombre
        /// </summary>
        /// <param name="nombre">nombre a buscar</param>
        /// <returns>array TipoProducto</returns>
        public TipoProducto[] BuscarTiposProducto(string nombre)
        {

            TipoProducto[] tiposProducto = null;
            tiposProducto = tipoProductoBD.BuscarTipoProductos(nombre);

            return tiposProducto;

        }

        /// <summary>
        /// Metodo para insertar un producto
        /// </summary>
        /// <param name="tipoProducto">tipoProducto a insertar</param>
        /// <returns>insertado con exito(true), si hubo error(false)</returns>
        public bool InsertarTipoProducto(TipoProducto tipoProducto)
        {

            bool ok = false;

            if (tipoProducto != null)
            {
                ok = tipoProductoBD.InsertarTipoProducto(tipoProducto);
            }

            return ok;

        }

        /// <summary>
        /// Metodo para actualizar un tipo producto
        /// </summary>
        /// <param name="tipoProducto">tipo producto a actualizar</param>
        /// <returns>actualizado con exito(true), si hubo error(false)</returns>
        public bool ActualizarTipoProducto(TipoProducto tipoProducto)
        {

            bool ok = false;

            if (tipoProducto != null)
            {
                ok = tipoProductoBD.ActualizarTipoProducto(tipoProducto);
            }

            return ok;

        }

        /// <summary>
        /// Metodo para eliminar un tipo producto
        /// </summary>
        /// <param name="codTipoProducto">codigo tipo producto</param>
        /// <returns>eliminando con exito(true), si hubo error(false)</returns>
        public bool EliminarTipoProducto(int codTipoProducto)
        {

            bool ok = false;

            if (codTipoProducto > 0)
            {
                ok = tipoProductoBD.EliminarTipoProducto(codTipoProducto);
            }

            return ok;

        }
    }
}
