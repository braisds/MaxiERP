using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class TipoProductoBD
    {
        private MySqlConnection conexion;

        /// <summary>
        /// Consulta insertar un tipo producto a la BD
        /// </summary>
        private const string INSERTAR_TIPO_PRODUCTO 
            = "INSERT INTO tipo_producto (nombre) VALUES (@nombre)";

        /// <summary>
        /// Consulta actualizar un tipo producto de la BD
        /// </summary>
        private const string ACTUALIZAR_TIPO_PRODUCTO
            = "UPDATE tipo_producto SET nombre = @nombre WHERE codigo = @codigo";

        /// <summary>
        /// Consulta obtener listado de tipo producto de la BD
        /// </summary>
        private const string OBTENER_LISTADO_TIPO_PRODUCTOS
            = "SELECT codigo, nombre FROM tipo_producto";

        /// <summary>
        /// Consulta obtener un tipo producto de la BD
        /// </summary>
        private const string OBTENER_TIPO_PRODUCTO
            = "SELECT codigo, nombre FROM tipo_producto WHERE codigo = @codigo";

        /// <summary>
        /// Consulta buscar tipos producto de la BD por nombre
        /// </summary>
        private const string BUSCAR_TIPO_PRODUCTO
           = "SELECT codigo, nombre FROM tipo_producto " +
           "   where (nombre is null OR nombre like @nombre) ";

        /// <summary>
        /// Consulta eliminar tipo producto de la BD
        /// </summary>
        private const string ELIMINAR_TIPO_PRODUCTO
            = "DELETE FROM tipo_producto WHERE codigo = @codigo";

        public TipoProductoBD()
        {
            conexion = new MySqlConnection(configuracion.sql);
        }

        /// <summary>
        /// Metodo para insertar un tipo producto a la BD
        /// </summary>
        /// <param name="tipoProducto">tipo producto a insertar</param>
        /// <returns>insertado con exito(true), si hubo error(false)</returns>
        public bool InsertarTipoProducto(TipoProducto tipoProducto)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(INSERTAR_TIPO_PRODUCTO, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@nombre", tipoProducto.Nombre.Trim());

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
        /// Metodo para actualizar un tipo producto a la BD
        /// </summary>
        /// <param name="tipoProducto">tipo producto a actualizar</param>
        /// <returns>actualizar con exito(true), si hubo error(false)</returns>
        public bool ActualizarTipoProducto(TipoProducto tipoProducto)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(ACTUALIZAR_TIPO_PRODUCTO, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@nombre", tipoProducto.Nombre.Trim());

                cmd.Parameters.AddWithValue("@codigo", tipoProducto.Codigo);

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
        /// Metodo para obtener listado de tipos producto de la BD
        /// </summary>
        /// <returns>array TipoProducto</returns>
        public TipoProducto[] ListadoTipoProductos()
        {

            MySqlCommand cmd = null;
            TipoProducto[] tipoProductos = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(OBTENER_LISTADO_TIPO_PRODUCTOS, conexion);

                MySqlDataReader rs = cmd.ExecuteReader();

                List<TipoProducto> lista = new List<TipoProducto>();
                while (rs.Read())
                {
                    TipoProducto tipoProducto = new TipoProducto();
                    tipoProducto.Codigo = rs.GetInt32("codigo");
                    tipoProducto.Nombre = rs.GetString("nombre");

                    lista.Add(tipoProducto);

                }

                if (lista != null && lista.Count > 0)
                {
                    tipoProductos = lista.ToArray();
                }
                

                return tipoProductos;

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
        /// Metodo para obtener un tipo producto de la BD
        /// </summary>
        /// <param name="codTipoProducto">codigo del tipo producto</param>
        /// <returns>objeto TipoProducto</returns>
        public TipoProducto ObtenerTipoProducto(int codTipoProducto)
        {

            MySqlCommand cmd = null;
            TipoProducto tipoProducto = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(OBTENER_TIPO_PRODUCTO, conexion);

                cmd.Parameters.AddWithValue("@codigo", codTipoProducto);

                MySqlDataReader rs = cmd.ExecuteReader();

                if (rs.HasRows)
                {
                    rs.Read();
                    
                    tipoProducto = new TipoProducto();
                    tipoProducto.Codigo = rs.GetInt32("codigo");
                    tipoProducto.Nombre = rs.GetString("nombre");
                }

                return tipoProducto;

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
        /// Metodo para buscar tipos producto de la BD
        /// </summary>
        /// <param name="nombre">nombre a buscar</param>
        /// <returns>array TipoProducto</returns>
        public TipoProducto[] BuscarTipoProductos(string nombre)
        {

            MySqlCommand cmd = null;
            TipoProducto[] tipoProductos = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(BUSCAR_TIPO_PRODUCTO, conexion);

                if (nombre != null)
                {
                    cmd.Parameters.AddWithValue("@nombre", "%"+nombre.Trim() + "%");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@nombre", null);
                }


                MySqlDataReader rs = cmd.ExecuteReader();

                List<TipoProducto> lista = new List<TipoProducto>();
                while (rs.Read())
                {
                    TipoProducto p = new TipoProducto();
                    p.Codigo = rs.GetInt32("codigo");
                    p.Nombre = rs.GetString("nombre");

                    lista.Add(p);

                }

                if (lista != null && lista.Count > 0)
                {
                    tipoProductos = lista.ToArray();
                }

                return tipoProductos;

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
        /// Metodo eliminar un tipoProducto de la BD
        /// </summary>
        /// <param name="codTipoProducto">codigo del TipoProducto</param>
        /// <returns>actualizar con exito(true), si hubo error(false)</returns>
        public bool EliminarTipoProducto(int codTipoProducto)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(ELIMINAR_TIPO_PRODUCTO, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@codigo", codTipoProducto);

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
