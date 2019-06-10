using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductoN
    {
        private ProductoBD productoBD;
        private TipoProductoBD tipoProductoBD;

        public ProductoN()
        {
            productoBD = new ProductoBD();
            tipoProductoBD = new TipoProductoBD();
        }

        /// <summary>
        /// Metodo para obtener el listado de productos
        /// </summary>
        /// <returns>Array Producto</returns>
        public Producto[] ListadoProductos()
        {
            Producto[] productos = null;
            productos = productoBD.ListadoProductos();

            if (productos != null)
            {
                foreach (Producto p in productos)
                {
                    p.TipoProducto = tipoProductoBD.ObtenerTipoProducto(p.TipoProducto.Codigo);
                }

            }


            return productos;
        }

        /// <summary>
        /// Metodo para buscar un producto
        /// </summary>
        /// <param name="nombre">nombre a buscar</param>
        /// <param name="cod_tipo">codigo tipo a buscar</param>
        /// <returns>array Producto</returns>
        public Producto[] BuscarProductos(string nombre, int cod_tipo)
        {
            
            Producto[] productos = null;
            productos = productoBD.BuscarProductos(nombre,cod_tipo);

            if (productos != null)
            {
                foreach (Producto p in productos)
                {
                    p.TipoProducto = tipoProductoBD.ObtenerTipoProducto(p.TipoProducto.Codigo);
                }

            }


            return productos;
            
        }

        /// <summary>
        /// Metodo para insertar un producto
        /// </summary>
        /// <param name="producto"> producto a insertar</param>
        /// <returns>insertado con exito(true), si hubo error(false)</returns>
        public bool InsertarProducto(Producto producto)
        {

            bool ok = false;

            if (producto != null)
            {
                ok = productoBD.InsertarProducto(producto);
            }

            return ok;

        }

        /// <summary>
        /// Metodo para actualizar un producto
        /// </summary>
        /// <param name="producto"> producto a actualizar</param>
        /// <returns>actualizado con exito(true), si hubo error(false)</returns>
        public bool ActualizarProducto(Producto producto)
        {

            bool ok = false;

            if (producto != null)
            {
                ok = productoBD.ActualizarProducto(producto);
            }

            return ok;

        }

        /// <summary>
        /// Metodo para eliminar un producto
        /// </summary>
        /// <param name="codProducto">codigo de producto</param>
        /// <returns>eliminando con exito(true), si hubo error(false)</returns>
        public bool EliminarProducto(int codProducto)
        {

            bool ok = false;

            if (codProducto > 0)
            {
                ok = productoBD.EliminarProducto(codProducto);
            }

            return ok;

        }
    }
}
