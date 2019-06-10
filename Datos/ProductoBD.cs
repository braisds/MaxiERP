using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ProductoBD
    {

        private MySqlConnection conexion;

        /// <summary>
        /// Consulta insertar un producto a la BD
        /// </summary>
        private const string INSERTAR_PRODUCTO
            = "INSERT INTO producto (nombre, descripcion, marca, precio, stock, cod_tipo_producto) VALUES (@nombre, @descripcion,@marca , @precio, @stock, @cod_tipo_producto)";

        /// <summary>
        /// Consulta actualizar un producto de la BD
        /// </summary>
        private const string ACTUALIZAR_PRODUCTO
            = "UPDATE producto SET nombre = @nombre, descripcion = @descripcion, marca = @marca, precio = @precio, stock = @stock, cod_tipo_producto = @cod_tipo_producto WHERE codigo = @codigo";

        /// <summary>
        /// Consulta obtener listado de productos de la BD
        /// </summary>
        private const string OBTENER_LISTADO_PRODUCTOS
            = "SELECT codigo, nombre, descripcion, marca, precio, stock, cod_tipo_producto FROM producto";

        /// <summary>
        /// Consulta obtener un producto de la BD
        /// </summary>
        private const string OBTENER_PRODUCTO
            = "SELECT codigo, nombre, descripcion, marca, precio, stock, cod_tipo_producto FROM producto WHERE codigo = @codigo";

        /// <summary>
        /// Consulta buscar productos por nombre y/o tipo de la BD
        /// </summary>
        private const string BUSCAR_PRODUCTO
            = "SELECT codigo, nombre, descripcion, marca, precio, stock, cod_tipo_producto FROM producto " +
            "   where (@nombre is null OR nombre like @nombre) " +
            "       AND (@cod_tipo = 0 OR cod_tipo_producto = @cod_tipo)";

        /// <summary>
        /// Consulta eliminar un producto de la BD
        /// </summary>
        private const string ELIMINAR_PRODUCTO
            = "DELETE FROM producto WHERE codigo = @codigo";


        public ProductoBD()
        {
            conexion = new MySqlConnection(configuracion.sql);
        }

        /// <summary>
        /// Metodo para insertar un producto a la BD
        /// </summary>
        /// <param name="producto"> producto a insertar</param>
        /// <returns>insertado con exito(true), si hubo error(false)</returns>
        public bool InsertarProducto(Producto producto)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(INSERTAR_PRODUCTO, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@nombre", producto.Nombre.Trim());
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion.Trim());
                cmd.Parameters.AddWithValue("@marca", producto.Marca.Trim());
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                cmd.Parameters.AddWithValue("@cod_tipo_producto", producto.TipoProducto.Codigo);

                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();

                }
                return false;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }

        }

        /// <summary>
        /// Metodo para actualizar un producto de la BD
        /// </summary>
        /// <param name="producto"> producto a actualizar</param>
        /// <returns>actualizado con exito(true), si hubo error(false)</returns>
        public bool ActualizarProducto(Producto producto)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(ACTUALIZAR_PRODUCTO, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@nombre", producto.Nombre.Trim());
                cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion.Trim());
                cmd.Parameters.AddWithValue("@marca", producto.Marca.Trim());
                cmd.Parameters.AddWithValue("@precio", producto.Precio);
                cmd.Parameters.AddWithValue("@stock", producto.Stock);
                cmd.Parameters.AddWithValue("@cod_tipo_producto", producto.TipoProducto.Codigo);

                cmd.Parameters.AddWithValue("@codigo", producto.Codigo);

                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();

                }
                return false;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }

        }

        /// <summary>
        /// Metodo para obtener listado de producto de la BD
        /// </summary>
        /// <returns>array de Producto</returns>
        public Producto[] ListadoProductos()
        {

            MySqlCommand cmd = null;
            Producto[] productos = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(OBTENER_LISTADO_PRODUCTOS, conexion);

                MySqlDataReader rs = cmd.ExecuteReader();

                List<Producto> lista = new List<Producto>();
                while (rs.Read())
                {
                    Producto p = new Producto();
                    p.Codigo = rs.GetInt32("codigo");
                    p.Nombre = rs.GetString("nombre");
                    p.Precio = rs.GetDouble("precio");
                    p.Descripcion = rs.GetString("descripcion");
                    p.Marca = rs.GetString("marca");
                    p.Stock = rs.GetInt32("stock");

                    TipoProducto tp = new TipoProducto();
                    tp.Codigo = rs.GetInt32("cod_tipo_producto");
                    p.TipoProducto = tp;

                    lista.Add(p);

                }

                if (lista != null && lista.Count > 0)
                {
                    productos = lista.ToArray();
                }

                return productos;

            }
            catch (Exception)
            {
                return null;

            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }

            }

        }

        /// <summary>
        /// Metodo para obtener un producto de la BD
        /// </summary>
        /// <param name="codProducto"></param>
        /// <returns>objeto Producto</returns>
        public Producto ObtenerProducto(int codProducto)
        {

            MySqlCommand cmd = null;
            Producto producto = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(OBTENER_PRODUCTO, conexion);

                cmd.Parameters.AddWithValue("@codigo", codProducto);

                MySqlDataReader rs = cmd.ExecuteReader();

                if (rs.HasRows)
                {
                    rs.Read();

                    producto = new Producto();
                    producto.Codigo = rs.GetInt32("codigo");
                    producto.Nombre = rs.GetString("nombre");
                    producto.Precio = rs.GetDouble("precio");
                    producto.Descripcion = rs.GetString("descripcion");
                    producto.Marca = rs.GetString("marca");
                    producto.Stock = rs.GetInt32("stock");

                    TipoProducto tp = new TipoProducto();
                    tp.Codigo = rs.GetInt32("cod_tipo_producto");
                    producto.TipoProducto = tp;
                }

                return producto;

            }
            catch (Exception)
            {
                return null;

            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }

            }

        }

        /// <summary>
        /// Metodo para buscar productos de la BD por nombre y/o tipo
        /// </summary>
        /// <param name="nombre">nombre a buscar</param>
        /// <param name="cod_tipo">codigo del tipo a buscar</param>
        /// <returns>array de Producto</returns>
        public Producto[] BuscarProductos(string nombre, int cod_tipo)
        {

            MySqlCommand cmd = null;
            Producto[] productos = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(BUSCAR_PRODUCTO, conexion);
                if (nombre != null && nombre.Length > 0)
                {
                    cmd.Parameters.AddWithValue("@nombre", "%"+nombre.Trim() + "%");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@nombre", null);
                }

                if (cod_tipo > 0)
                {
                    cmd.Parameters.AddWithValue("@cod_tipo", cod_tipo);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@cod_tipo", 0);
                }

           

                MySqlDataReader rs = cmd.ExecuteReader();

                List<Producto> lista = new List<Producto>();
                while (rs.Read())
                {
                    Producto p = new Producto();
                    p.Codigo = rs.GetInt32("codigo");
                    p.Nombre = rs.GetString("nombre");
                    p.Precio = rs.GetDouble("precio");
                    p.Descripcion = rs.GetString("descripcion");
                    p.Marca = rs.GetString("marca");
                    p.Stock = rs.GetInt32("stock");

                    TipoProducto tp = new TipoProducto();
                    tp.Codigo = rs.GetInt32("cod_tipo_producto");
                    p.TipoProducto = tp;

                    lista.Add(p);

                }

                if (lista != null && lista.Count > 0)
                {
                    productos = lista.ToArray();
                }

                return productos;

            }
            catch (Exception)
            {
                return null;

            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }

            }


        }

        /// <summary>
        /// Metodo para eliminar un producto
        /// </summary>
        /// <param name="codProducto"> codigo del producto</param>
        /// <returns>eliminado con exito(true), si hubo error(false)</returns>
        public bool EliminarProducto(int codProducto)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(ELIMINAR_PRODUCTO, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@codigo", codProducto);

                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();

                }
                return false;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }

        }
    }
}
