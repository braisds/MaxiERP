using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Clientes : Form
    {
        private ClienteN clienteN;
        private Cliente[] clientes;


        private bool devolverCliente;//Para añadirlo a una venta
        public Cliente clienteDevolver;//Para añadirlo a una venta

        /// <summary>
        /// Constructor clientes
        /// </summary>
        public Clientes()
        {
            InitializeComponent();

            clienteN = new ClienteN();
        }

        /// <summary>
        /// Constructor para abrirlo desde ventas para selecionar el cliente
        /// </summary>
        /// <param name="obtener">true para decir que viene de ventas</param>
        public Clientes(bool devolverCliente)
        {
            InitializeComponent();
            this.devolverCliente = devolverCliente;
            clienteN = new ClienteN();
        }

        /// <summary>
        /// Evento load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clientes_Load(object sender, EventArgs e)
        {
            clientes = clienteN.ListadoClientes();

            CargarListado();

            if (devolverCliente)
            {
                btnAgregarVenta.Visible = true;
                if (clientes != null && clientes.Length > 0)
                {
                    btnAgregarVenta.Enabled = true;
                }
            }

        }

        /// <summary>
        /// Carga el cliente seleccionado en el bloque
        /// </summary>
        private void CargarCliente()
        {
            LimpiarCliente();
            if (clientes != null && clientes.Length > 0 && tblClientes.CurrentRow.Index <= clientes.Length -1)
            {
                ModoModificar();

                txtNombre.Text = clientes[tblClientes.CurrentRow.Index].Nombre;
                txtApellidos.Text = clientes[tblClientes.CurrentRow.Index].Apellidos;
                txtDireccion.Text = clientes[tblClientes.CurrentRow.Index].Direccion;
                txtDni.Text = clientes[tblClientes.CurrentRow.Index].Dni;
                txtTelefono.Text = clientes[tblClientes.CurrentRow.Index].Telefono;
            }
            else
            {
                ModoNuevo();
            }
        }

        /// <summary>
        /// Limpia el bloque de cliente selecionado a valores vacios
        /// </summary>
        private void LimpiarCliente()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";

        }

        /// <summary>
        /// Limpia y carga el listado de clientes en la tabla
        /// </summary>
        private void CargarListado()
        {
            tblClientes.Rows.Clear();
            if (clientes != null)
            {

                for (int i = 0; i < clientes.Length; i++)
                {
                    tblClientes.Rows.Add();
                    tblClientes.Rows[i].Cells[0].Value = clientes[i].Codigo;
                    tblClientes.Rows[i].Cells[1].Value = clientes[i].Nombre;
                    tblClientes.Rows[i].Cells[2].Value = clientes[i].Apellidos;
                    tblClientes.Rows[i].Cells[3].Value = clientes[i].Direccion;
                    tblClientes.Rows[i].Cells[4].Value = clientes[i].Dni;
                    tblClientes.Rows[i].Cells[5].Value = clientes[i].Telefono;

                }

            }

        }

        /// <summary>
        /// Evento Buscar clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtBusNombre.Text.Trim();

            clientes = clienteN.BuscarClientes(nombre);

            CargarListado();
            
        }

        /// <summary>
        /// Evento cambio seleción en la tabla para cargar datos del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tblClientes_SelectionChanged(object sender, EventArgs e)
        {
            CargarCliente();
        }

        /// <summary>
        /// Evento resetea el buscador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBusNombre.Text = "";

            clientes = clienteN.ListadoClientes();
            CargarListado();
        }

        /// <summary>
        /// Evento crear nuevo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ModoNuevo();
            LimpiarCliente();
            
        }

        /// <summary>
        /// Modifica el formulario para adaptar el bloque del cliente en Modo editar
        /// </summary>
        private void ModoModificar()
        {
            gbCliente.Text = "Editar cliente";
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

            btnGuardarNuevo.Enabled = false;

            if (devolverCliente)
            {
                btnAgregarVenta.Enabled = true;
            }
        }

        /// <summary>
        /// Modifica el formulario para adaptar el bloque del cliente en Modo nuevo cliente
        /// </summary>
        private void ModoNuevo()
        {
            tblClientes.ClearSelection();
            gbCliente.Text = "Añadir nuevo cliente";
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            btnGuardarNuevo.Enabled = true;

            if (devolverCliente)
            {
                btnAgregarVenta.Enabled = false;
            }
        }

        /// <summary>
        /// Crear un objeto Cliente con los valores de los textBox
        /// </summary>
        /// <returns></returns>
        private Cliente ObtenerCliente()
        {
            
            Cliente c = new Cliente();

            if (tblClientes.CurrentRow != null)
            {
                c.Codigo = clientes[tblClientes.CurrentRow.Index].Codigo;
            }
            c.Nombre = txtNombre.Text;
            c.Apellidos = txtApellidos.Text;
            c.Direccion = txtDireccion.Text;
            c.Dni = txtDni.Text;
            c.Telefono = txtTelefono.Text;

            return c;

        }

        /// <summary>
        /// Evento boton guardar un nuevo cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            
            Cliente cliente = ObtenerCliente();

            bool ok = clienteN.InsertarCliente(cliente);
            if (ok)
            {
                clientes = clienteN.ListadoClientes();
                CargarListado();
                MessageBox.Show("Cliente añadido correctamente", "Añadir Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Error al añadido el cliente", "Error añadir cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Evento modificar un cliente existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente cliente = ObtenerCliente();

            bool ok = clienteN.ActualizarCiente(cliente);
            if (ok)
            {
                clientes = clienteN.ListadoClientes();
                CargarListado();
                MessageBox.Show("Cliente modificado correctamente", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al modificadar el cliente", "Error modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Evento eliminar un cliente existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codCliente = clientes[tblClientes.CurrentRow.Index].Codigo;
            bool ok = clienteN.EliminarCliente(codCliente);
            if (ok)
            {
                clientes = clienteN.ListadoClientes();
                CargarListado();
                MessageBox.Show("Cliente eliminado correctamente", "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al eliminar el cliente. Nota: no se puede eliminar un cliente si esta vinculado a alguna venta.",
                    "Error eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Devuelve el cliente selecionado para añadirlo a la nueva venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (tblClientes.CurrentRow != null)
            {
                clienteDevolver = clientes[tblClientes.CurrentRow.Index];
            }
            
        }
    }
}
