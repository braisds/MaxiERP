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
        /// Consulta obtener listado de ventaProducto por codigo de la venta a la BD
        /// </summary>
        private const string OBTENER_LISTADO_VENTA_PRODUCTO
            = "SELECT codigo, cod_venta, cod_producto, precio_unidad, cantidad FROM venta_producto  WHERE cod_venta = @cod_venta";

        /// <summary>
        /// Consulta obtener un ventaProducto de la BD
        /// </summary>
        private const string OBTENER_VENTA_PRODUCTO
            = "SELECT codigo, cod_venta, cod_producto, precio_unidad, cantidad FROM venta_producto WHERE codigo = @codigo";

        public VentaProductoBD()
        {
            conexion = new MySqlConnection(configuracion.sql);
        }

        /// <summary>
        /// Metodo para insertar un array ventaProducto a la BD
        /// </summary>
        /// <param name="venta">objeto Venta con los VentaProducto a insertar</param>
        /// <returns>insertado con exito(true), si hubo error(false)</returns>
        public bool InsertarVentaProducto(Venta venta)
        {

            MySqlCommand cmd = null;
            MySqlTransaction trans = null;
            try
            {

                conexion.Open();
                trans = conexion.BeginTransaction();
                
                foreach (VentaProducto vp in venta.Productos)
                {
                    cmd = new MySqlCommand(INSERTAR_VENTA_PRODUCTO, conexion);
                    cmd.Parameters.AddWithValue("@cod_venta", venta.Codigo);
                    cmd.Parameters.AddWithValue("@cod_producto", vp.Producto.Codigo);
                    cmd.Parameters.AddWithValue("@precio_unidad", vp.PrecioUnidad);
                    cmd.Parameters.AddWithValue("@cantidad", vp.Cantidad);

                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                
                return true;
            }
            catch (Exception)
            {
                if (trans != null)
                {
                    trans.Rollback();

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
                    vp.PrecioUnidad = rs.GetDouble("precio_unidad");
                    vp.Cantidad = rs.GetInt32("cantidad");

                    Venta v = new Venta();
                    v.Codigo = rs.GetInt32("cod_venta");
                    vp.Venta = v;

                    Producto p = new Producto();
                    p.Codigo = rs.GetInt32("cod_producto");
                    vp.Producto = p;

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


    }
}
