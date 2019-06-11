using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class UsuarioBD
    {

        private MySqlConnection conexion;

        /// <summary>
        /// Consulta para hacer login en la aplicacion
        /// </summary>
        private const string HACER_LOGIN
            = "SELECT codigo, nombre, login, apellidos, direccion, dni, telefono, admin FROM usuario WHERE login = @login AND pass = @pass";

        /// <summary>
        /// Consulta insertar un usuario a la BD
        /// </summary>
        private const string INSERTAR_USUARIO
            = "INSERT INTO usuario (nombre, login, pass, apellidos, direccion, dni, telefono, admin) VALUES (@nombre, @login, @pass, @apellidos, @direccion, @dni, @telefono, @admin)";

        /// <summary>
        /// Consulta actualizar un usuario de la BD
        /// </summary>
        private const string ACTUALIZAR_USUARIO
            = "UPDATE usuario SET nombre = @nombre, login = @login, pass = @pass, apellidos = @apellidos, direccion = @direccion, dni = @dni, telefono = @telefono, admin = @admin WHERE codigo = @codigo";

        /// <summary>
        /// Consulta obtener listado usuarios de la BD
        /// </summary>
        private const string OBTENER_LISTADO_USUARIO
            = "SELECT codigo, nombre, login, apellidos, direccion, dni, telefono, admin FROM usuario";

        /// <summary>
        /// Consulta obtener un usuario de la BD
        /// </summary>
        private const string OBTENER_USUARIO
            = "SELECT codigo, nombre, login, apellidos, direccion, dni, telefono, admin FROM usuario where codigo = @codigo";

        /// <summary>
        /// Consulta buscar usuarios por nombre de la BD
        /// </summary>
        private const string BUSCAR_USUARIO
            = "SELECT codigo, nombre, login, apellidos, direccion, dni, telefono, admin FROM usuario " +
            "   where (nombre is null OR nombre like @nombre) ";

        /// <summary>
        /// Consulta eliminar un usuario de la BD
        /// </summary>
        private const string ELIMINAR_USUARIO
            = "DELETE FROM usuario WHERE codigo = @codigo";

        public UsuarioBD()
        {
            conexion = new MySqlConnection(configuracion.sql);
        }

        /// <summary>
        /// Metodo para hacer login en la aplicacion
        /// </summary>
        /// <param name="login">login del usuario</param>
        /// <param name="pass">contraseña hash</param>
        /// <returns>Objeto usuario si el login y pass son correctos</returns>
        public Usuario HacerLogin(string login, string pass)
        {
            MySqlCommand cmd = null;
            Usuario u = null;
            try
            {
                conexion.Open();

                cmd = new MySqlCommand(HACER_LOGIN, conexion);

                cmd.Parameters.AddWithValue("@login", login.Trim());
                cmd.Parameters.AddWithValue("@pass", pass.Trim());

                MySqlDataReader rs = cmd.ExecuteReader();

                if (rs.HasRows)
                {
                    rs.Read();
                    u = new Usuario();
                    u.Codigo = rs.GetInt32("codigo");
                    u.Nombre = rs.GetString("nombre");
                    u.Login = rs.GetString("login");
                    u.Apellidos = rs.GetString("apellidos");
                    u.Direccion = rs.GetString("direccion");
                    u.Dni = rs.GetString("dni");
                    u.Telefono = rs.GetString("telefono");
                    u.Admin = rs.GetBoolean("admin");
                }
                

                return u;

            }
            catch (Exception e)
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
        /// Metodo para insertar un usuario a la BD
        /// </summary>
        /// <param name="usuario"> usuario a insertar</param>
        /// <returns>insertado con exito(true), si hubo error(false)</returns>
        public bool InsertarUsuario(Usuario usuario)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(INSERTAR_USUARIO, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@nombre", usuario.Nombre.Trim());
                cmd.Parameters.AddWithValue("@login", usuario.Login.Trim());
                cmd.Parameters.AddWithValue("@pass", usuario.Pass);
                cmd.Parameters.AddWithValue("@apellidos", usuario.Apellidos.Trim());
                cmd.Parameters.AddWithValue("@direccion", usuario.Direccion.Trim());
                cmd.Parameters.AddWithValue("@dni", usuario.Dni.Trim());
                cmd.Parameters.AddWithValue("@telefono", usuario.Telefono.Trim());
                cmd.Parameters.AddWithValue("@admin", usuario.Admin);

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
        /// Metodo para actualizar un usuario a la BD
        /// </summary>
        /// <param name="usuario"> usuario a actulizar</param>
        /// <returns>actualizado con exito(true), si hubo error(false)</returns>
        public bool ActualizarUsuario(Usuario usuario)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(ACTUALIZAR_USUARIO, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@nombre", usuario.Nombre.Trim());
                cmd.Parameters.AddWithValue("@login", usuario.Login.Trim());
                cmd.Parameters.AddWithValue("@pass", usuario.Pass);
                cmd.Parameters.AddWithValue("@apellidos", usuario.Apellidos.Trim());
                cmd.Parameters.AddWithValue("@direccion", usuario.Direccion.Trim());
                cmd.Parameters.AddWithValue("@dni", usuario.Dni.Trim());
                cmd.Parameters.AddWithValue("@telefono", usuario.Telefono.Trim());
                cmd.Parameters.AddWithValue("@admin", usuario.Admin);

                cmd.Parameters.AddWithValue("@codigo", usuario.Codigo);

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
        /// Metodo para obtener listado usuarios de la BD
        /// </summary>
        /// <returns>array Usuario</returns>
        public Usuario[] ListadoUsuarios()
        {

            MySqlCommand cmd = null;
            Usuario[] usuarios = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(OBTENER_LISTADO_USUARIO, conexion);

                MySqlDataReader rs = cmd.ExecuteReader();

                List<Usuario> lista = new List<Usuario>();
                while (rs.Read())
                {
                    Usuario u = new Usuario();
                    u.Codigo = rs.GetInt32("codigo");
                    u.Nombre = rs.GetString("nombre");
                    u.Login = rs.GetString("login");
                    u.Apellidos = rs.GetString("apellidos");
                    u.Direccion = rs.GetString("direccion");
                    u.Dni = rs.GetString("dni");
                    u.Telefono = rs.GetString("telefono");
                    u.Admin = rs.GetBoolean("admin");

                    lista.Add(u);

                }

                if (lista != null && lista.Count > 0)
                {
                    usuarios = lista.ToArray();
                }
                
                return usuarios;

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
        /// Metodo para obtener un usuario de la BD
        /// </summary>
        /// <param name="codUsuario">codigo del usuario</param>
        /// <returns>Objeto Usuario</returns>
        public Usuario ObtenerUsuario(int codUsuario)
        {

            MySqlCommand cmd = null;
            Usuario usuario = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(OBTENER_USUARIO, conexion);

                cmd.Parameters.AddWithValue("@codigo", codUsuario);

                MySqlDataReader rs = cmd.ExecuteReader();

                if (rs.HasRows)
                {
                    rs.Read();

                    usuario = new Usuario();
                    usuario.Codigo = rs.GetInt32("codigo");
                    usuario.Nombre = rs.GetString("nombre");
                    usuario.Login = rs.GetString("login");
                    usuario.Apellidos = rs.GetString("apellidos");
                    usuario.Direccion = rs.GetString("direccion");
                    usuario.Dni = rs.GetString("dni");
                    usuario.Telefono = rs.GetString("telefono");
                    usuario.Admin = rs.GetBoolean("admin");
                }
                return usuario;

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
        /// Metodo para buscar usuarios de la BD por nombre
        /// </summary>
        /// <param name="nombre">nombre a buscar</param>
        /// <returns>array Usuario</returns>
        public Usuario[] BuscarUsuarios(string nombre)
        {

            MySqlCommand cmd = null;
            Usuario[] usuarios = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(BUSCAR_USUARIO, conexion);

                if (nombre != null)
                {
                    cmd.Parameters.AddWithValue("@nombre", "%"+nombre.Trim() + "%");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@nombre", null);
                }


                MySqlDataReader rs = cmd.ExecuteReader();

                List<Usuario> lista = new List<Usuario>();
                while (rs.Read())
                {
                    Usuario u = new Usuario();
                    u.Codigo = rs.GetInt32("codigo");
                    u.Nombre = rs.GetString("nombre");
                    u.Login = rs.GetString("login");
                    u.Apellidos = rs.GetString("apellidos");
                    u.Direccion = rs.GetString("direccion");
                    u.Dni = rs.GetString("dni");
                    u.Telefono = rs.GetString("telefono");
                    u.Admin = rs.GetBoolean("admin");

                    lista.Add(u);

                }

                if (lista != null && lista.Count > 0)
                {
                    usuarios = lista.ToArray();
                }

                return usuarios;

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
        /// Metodo para eliminar un usuario de la BD
        /// </summary>
        /// <param name="codUsuario">codigo del usuario</param>
        /// <returns>eliminar con exito(true), si hubo error(false)</returns>
        public bool EliminarUsuario(int codUsuario)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(ELIMINAR_USUARIO, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@codigo", codUsuario);

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
