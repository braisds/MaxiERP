using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class VentaProductoBD
    {

        private MySqlConnection conexion;

        /// <summary>
        /// Consulta insertar un ventaProducto a la BD
        /// </summary>
        private const string INSERTAR_VENTA_PRODUCTO
            = "INSERT INTO venta_producto (cod_venta, cod_producto, precio_unidad, cantidad) VALUES (@cod_venta, @cod_producto, @precio_unidad, @cantidad)";

        /// <summary>
        /// Consulta actualizar un ventaProducto a la BD
        /// </summary>
        private const string ACTUALIZAR_VENTA_PRODUCTO
            = "UPDATE venta_producto SET cod_venta = @cod_venta, cod_producto = @cod_producto, precio_unidad = @precio_unidad, cantidad = @cantidad WHERE codigo = @codigo";

        /// <summary>
        /// Consulta obtener listado de ventaProducto por codigo de la venta a la BD
        /// </summary>
        private const string OBTENER_LISTADO_VENTA_PRODUCTO
            = "SELECT codigo, cod_venta, cod_producto, precio_unidad, cantidad FROM venta  WHERE cod_venta = @cod_venta";

        /// <summary>
        /// Consulta obtener un ventaProducto de la BD
        /// </summary>
        private const string OBTENER_VENTA_PRODUCTO
            = "SELECT codigo, cod_venta, cod_producto, precio_unidad, cantidad FROM venta WHERE codigo = @codigo";

        public VentaProductoBD()
        {
            conexion = new MySqlConnection(configuracion.sql);
        }

        /// <summary>
        /// Metodo para insertar una ventaProducto a la BD
        /// </summary>
        /// <param name="ventaProducto"> ventaProducto a insertar</param>
        /// <returns>insertado con exito(true), si hubo error(false)</returns>
        public bool InsertarVentaProducto(VentaProducto ventaProducto)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(INSERTAR_VENTA_PRODUCTO, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@cod_venta", ventaProducto.Venta.Codigo);
                cmd.Parameters.AddWithValue("@cod_producto", ventaProducto.Producto.Codigo);
                cmd.Parameters.AddWithValue("@precio_unidad", ventaProducto.PrecioUnidad);
                cmd.Parameters.AddWithValue("@cantidad", ventaProducto.Cantidad);

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
        /// Metodo para actualizar una ventaProducto a la BD
        /// </summary>
        /// <param name="ventaProducto"> ventaProducto a actualizar</param>
        /// <returns>actualizado con exito(true), si hubo error(false)</returns>
        public bool ActualizarVentaProducto(VentaProducto ventaProducto)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(ACTUALIZAR_VENTA_PRODUCTO, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@cod_venta", ventaProducto.Venta.Codigo);
                cmd.Parameters.AddWithValue("@cod_producto", ventaProducto.Producto.Codigo);
                cmd.Parameters.AddWithValue("@precio_unidad", ventaProducto.PrecioUnidad);
                cmd.Parameters.AddWithValue("@cantidad", ventaProducto.Cantidad);

                cmd.Parameters.AddWithValue("@codigo", ventaProducto.Codigo);

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
        /// Metodo para obtener listado de ventaProducto por codigo de la venta a la BD
        /// </summary>
        /// <param name="codVenta"> codigo de la venta</param>
        /// <returns>array VentaProducto</returns>
        public VentaProducto[] ListadoVentasProducto(int codVenta)
        {

            MySqlCommand cmd = null;
            VentaProducto[] ventaProductos = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(OBTENER_LISTADO_VENTA_PRODUCTO, conexion);

                cmd.Parameters.AddWithValue("@cod_venta", codVenta);

                MySqlDataReader rs = cmd.ExecuteReader();

                List<VentaProducto> lista = new List<VentaProducto>();
                while (rs.Read())
                {
                    VentaProducto vp = new VentaProducto();
                    vp.Codigo = rs.GetInt32("codigo");
                    vp.Venta.Codigo = rs.GetInt32("cod_venta");
                    vp.Producto.Codigo = rs.GetInt32("cod_producto");
                    vp.PrecioUnidad = rs.GetDouble("precio_unidad");
                    vp.Cantidad = rs.GetInt32("cantidad");

                    lista.Add(vp);

                }

                if (lista != null && lista.Count > 0)
                {
                    ventaProductos = lista.ToArray();
                }

                return ventaProductos;

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
        /// Metodo obtener ventaProducto
        /// </summary>
        /// <param name="codigo">codigo de la ventaProducto</param>
        /// <returns>objeto VentaProducto</returns>
        public VentaProducto ObtenerVentaProducto(int codigo)
        {

            MySqlCommand cmd = null;
            VentaProducto ventaProducto = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(OBTENER_VENTA_PRODUCTO, conexion);

                cmd.Parameters.AddWithValue("@codigo", codigo);

                MySqlDataReader rs = cmd.ExecuteReader();

                if (rs.HasRows)
                {
                    rs.Read();

                    ventaProducto = new VentaProducto();
                    ventaProducto.Codigo = rs.GetInt32("codigo");
                    ventaProducto.Venta.Codigo = rs.GetInt32("cod_venta");
                    ventaProducto.Producto.Codigo = rs.GetInt32("cod_producto");
                    ventaProducto.PrecioUnidad = rs.GetDouble("precio_unidad");
                    ventaProducto.Cantidad = rs.GetInt32("cantidad");
                }

                return ventaProducto;

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

    }
}
