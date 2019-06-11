using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class ClienteBD
    {

        private MySqlConnection conexion;

        /// <summary>
        /// Consulta insertar un cliente a la BD
        /// </summary>
        private const string INSERTAR_CLIENTE
            = "INSERT INTO cliente (nombre, apellidos, direccion, dni, telefono) VALUES (@nombre, @apellidos, @direccion, @dni, @telefono)";

        /// <summary>
        /// Consulta actualizar un cliente a la BD
        /// </summary>
        private const string ACTUALIZAR_CLIENTE
            = "UPDATE cliente SET nombre = @nombre, apellidos = @apellidos, direccion = @direccion, dni = @dni, telefono = @telefono WHERE codigo = @codigo";

        /// <summary>
        /// Consulta obtener el listado de clientes de la BD
        /// </summary>
        private const string OBTENER_LISTADO_CLIENTE
            = "SELECT codigo, nombre, apellidos, direccion, dni, telefono FROM cliente";

        /// <summary>
        /// Consulta obtener un cliente por codigo de la BD
        /// </summary>
        private const string OBTENER_CLIENTE
            = "SELECT codigo, nombre, apellidos, direccion, dni, telefono FROM cliente where codigo = @codigo";

        /// <summary>
        /// Consulta buscar clientes por nombre de la BD
        /// </summary>
        private const string BUSCAR_CLIENTE
            = "SELECT codigo, nombre, apellidos, direccion, dni, telefono FROM cliente " +
            "   where (nombre is null OR nombre like @nombre) ";

        /// <summary>
        /// Consulta eliminar un cliente clientes de la BD
        /// </summary>
        private const string ELIMINAR_CLIENTE
            = "DELETE FROM cliente WHERE codigo = @codigo";

        public ClienteBD()
        {
            conexion = new MySqlConnection(configuracion.sql);
        }

        /// <summary>
        /// Metodo para insertar un cliente a la BD
        /// </summary>
        /// <param name="cliente"> cliente a insertar</param>
        /// <returns>insertado con exito(true), si hubo error(false)</returns>
        public bool InsertarCliente(Cliente cliente)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(INSERTAR_CLIENTE, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre.Trim());
                cmd.Parameters.AddWithValue("@apellidos", cliente.Apellidos.Trim());
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion.Trim());
                cmd.Parameters.AddWithValue("@dni", cliente.Dni.Trim());
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono.Trim());

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
        /// Metodo para actualizar un cliente de la BD
        /// </summary>
        /// <param name="cliente">cliente a actualizar</param>
        /// <returns>actualizado con exito(true), si hubo error(false)</returns>
        public bool ActualizarCliente(Cliente cliente)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(ACTUALIZAR_CLIENTE, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre.Trim());
                cmd.Parameters.AddWithValue("@apellidos", cliente.Apellidos.Trim());
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion.Trim());
                cmd.Parameters.AddWithValue("@dni", cliente.Dni.Trim());
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono.Trim());

                cmd.Parameters.AddWithValue("@codigo", cliente.Codigo);

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
        /// Metodo para obtener el listado de clientes de la BD
        /// </summary>
        /// <returns>array de clientes</returns>
        public Cliente[] ListadoClientes()
        {

            MySqlCommand cmd = null;
            Cliente[] clientes = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(OBTENER_LISTADO_CLIENTE, conexion);

                MySqlDataReader rs = cmd.ExecuteReader();

                List<Cliente> lista = new List<Cliente>();
                while (rs.Read())
                {
                    Cliente c = new Cliente();
                    c.Codigo = rs.GetInt32("codigo");
                    c.Nombre = rs.GetString("nombre");
                    c.Apellidos = rs.GetString("apellidos");
                    c.Direccion = rs.GetString("direccion");
                    c.Dni = rs.GetString("dni");
                    c.Telefono = rs.GetString("telefono");

                    lista.Add(c);

                }

                if (lista != null && lista.Count > 0)
                {
                    clientes = lista.ToArray();
                }

                return clientes;

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
        /// Metodo para obtener un cliente de la BD
        /// </summary>
        /// <param name="codCliente">codigo del cliente</param>
        /// <returns>objeto Cliente</returns>
        public Cliente ObtenerCliente(int codCliente)
        {

            MySqlCommand cmd = null;
            Cliente cliente = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(OBTENER_CLIENTE, conexion);

                cmd.Parameters.AddWithValue("@codigo", codCliente);

                MySqlDataReader rs = cmd.ExecuteReader();

                if (rs.HasRows)
                {
                    rs.Read();

                    cliente = new Cliente();
                    cliente.Codigo = rs.GetInt32("codigo");
                    cliente.Nombre = rs.GetString("nombre");
                    cliente.Apellidos = rs.GetString("apellidos");
                    cliente.Direccion = rs.GetString("direccion");
                    cliente.Dni = rs.GetString("dni");
                    cliente.Telefono = rs.GetString("telefono");
                }

                return cliente;

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
        /// Metodo para buscar clientes por nombre
        /// </summary>
        /// <param name="nombre">nombre a buscar</param>
        /// <returns>array Cliente</returns>
        public Cliente[] BuscarClientes(string nombre)
        {

            MySqlCommand cmd = null;
            Cliente[] clientes = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(BUSCAR_CLIENTE, conexion);

                if (nombre != null)
                {
                    cmd.Parameters.AddWithValue("@nombre", "%"+nombre.Trim()+ "%");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@nombre", null);
                }


                MySqlDataReader rs = cmd.ExecuteReader();

                List<Cliente> lista = new List<Cliente>();
                while (rs.Read())
                {
                    Cliente c = new Cliente();
                    c.Codigo = rs.GetInt32("codigo");
                    c.Nombre = rs.GetString("nombre");
                    c.Apellidos = rs.GetString("apellidos");
                    c.Direccion = rs.GetString("direccion");
                    c.Dni = rs.GetString("dni");
                    c.Telefono = rs.GetString("telefono");

                    lista.Add(c);

                }

                if (lista != null && lista.Count > 0)
                {
                    clientes = lista.ToArray();
                }
                
                return clientes;

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
        /// Metodo para eliminar un cliente
        /// </summary>
        /// <param name="codCliente">codigo del cliente</param>
        /// <returns>eliminado con exito(true), si hubo error(false)</returns>
        public bool EliminarCliente(int codCliente)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(ELIMINAR_CLIENTE, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@codigo", codCliente);

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
