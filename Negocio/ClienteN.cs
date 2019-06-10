using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteN
    {
        private ClienteBD clienteBD;

        public ClienteN()
        {
            clienteBD = new ClienteBD();
        }

        /// <summary>
        /// Metodo obtiene listado de clientes
        /// </summary>
        /// <returns>Array Cliente</returns>
        public Cliente[] ListadoClientes()
        {
            Cliente[] clientes = null;
            clientes = clienteBD.ListadoClientes();

            return clientes;
        }

        /// <summary>
        /// Metodo buscar clientes por nombre
        /// </summary>
        /// <param name="nombre">nombre a buscar</param>
        /// <returns>Array Cliente</returns>
        public Cliente[] BuscarClientes(string nombre)
        {
            Cliente[] clientes = null;
            clientes = clienteBD.BuscarClientes(nombre);

            return clientes;
            
        }

        /// <summary>
        /// Metodo para insertar un usuario
        /// </summary>
        /// <param name="cliente"> cliente a insertar</param>
        /// <returns>insertado con exito(true), si hubo error(false)</returns>
        public bool InsertarCliente(Cliente cliente)
        {

            bool ok = false;

            if (cliente != null)
            {
                ok = clienteBD.InsertarCliente(cliente);
            }

            return ok;

        }

        /// <summary>
        /// Metodo para actualizar un usuario
        /// </summary>
        /// <param name="cliente"> cliente a actualizar</param>
        /// <returns>actualizado con exito(true), si hubo error(false)</returns>
        public bool ActualizarCiente(Cliente cliente)
        {

            bool ok = false;

            if (cliente != null)
            {
                ok = clienteBD.ActualizarCliente(cliente);
            }

            return ok;

        }

        /// <summary>
        /// Metodo para eliminar un usuario
        /// </summary>
        /// <param name="codCliente"> codigo cliente</param>
        /// <returns>eliminado con exito(true), si hubo error(false)</returns>
        public bool EliminarCliente(int codCliente)
        {

            bool ok = false;

            if (codCliente > 0)
            {
                ok = clienteBD.EliminarCliente(codCliente);
            }

            return ok;

        }
    }
}
