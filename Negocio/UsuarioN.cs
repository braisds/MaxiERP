using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioN
    {
        UsuarioBD usuarioBD;

        public UsuarioN()
        {
            usuarioBD = new UsuarioBD();
        }

        /// <summary>
        /// Metodo para hacer login y encripta contraseña
        /// </summary>
        /// <param name="login">login</param>
        /// <param name="pass">pass</param>
        /// <returns>el usuario si el login es correcto</returns>
        public Usuario HacerLogin(string login, string pass)
        {
            string hash = SHA256Encrypt(pass);

            Usuario u = usuarioBD.HacerLogin(login, hash);

            return u;
        }

        /// <summary>
        /// Convertir cadena a sha256
        /// </summary>
        /// <param name="input">cadena a convertir</param>
        /// <returns>cadena convertida a sha256</returns>
        public string SHA256Encrypt(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }

        /// <summary>
        /// Metodo obtener listado usuarios
        /// </summary>
        /// <returns>array Usuario</returns>
        public Usuario[] ListadoUsuarios()
        {
            Usuario[] usuarios = null;
            usuarios = usuarioBD.ListadoUsuarios();

            return usuarios;
        }

        /// <summary>
        /// Metodo para buscar usuarios por nombre
        /// </summary>
        /// <param name="nombre">nombre a buscar</param>
        /// <returns>Array Usuario</returns>
        public Usuario[] BuscarUsuarios(string nombre)
        {
            Usuario[] usuarios = null;
            usuarios = usuarioBD.BuscarUsuarios(nombre);

            return usuarios;

        }

        /// <summary>
        /// Metodo para insertar un usuario
        /// </summary>
        /// <param name="usuario">usuario a insertar</param>
        /// <returns>insertado con exito(true), si hubo error(false)</returns>
        public bool InsertarUsuario(Usuario usuario)
        {

            bool ok = false;

            if (usuario != null)
            {
                usuario.Pass = SHA256Encrypt(usuario.Pass);
                ok = usuarioBD.InsertarUsuario(usuario);
            }

            return ok;

        }

        /// <summary>
        /// Metodo para actualizar un usuario
        /// </summary>
        /// <param name="usuario">usuario a actualizar</param>
        /// <returns>insertado con exito(true), si hubo error(false)</returns>
        public bool ActualizarUsuario(Usuario usuario)
        {

            bool ok = false;

            if (usuario != null)
            {
                usuario.Pass = SHA256Encrypt(usuario.Pass);
                ok = usuarioBD.ActualizarUsuario(usuario);
            }

            return ok;

        }

        /// <summary>
        /// Metodo eliminar usuario
        /// </summary>
        /// <param name="codUsuario">codigo del usuario</param>
        /// <returns>eliminado con exito(true), si hubo error(false)</returns>
        public bool EliminarUsuario(int codUsuario)
        {

            bool ok = false;

            if (codUsuario > 0)
            {
                ok = usuarioBD.EliminarUsuario(codUsuario);
            }

            return ok;

        }

    }
}
