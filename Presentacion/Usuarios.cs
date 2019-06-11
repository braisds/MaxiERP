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
    public partial class Usuarios : Form
    {
        private UsuarioN usuarioN;
        private Usuario[] usuarios;

        public Usuarios()
        {
            InitializeComponent();

            usuarioN = new UsuarioN();
        }

        /// <summary>
        /// Evento load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Usuarios_Load(object sender, EventArgs e)
        {
            usuarios = usuarioN.ListadoUsuarios();

            CargarListado();

        }

        /// <summary>
        /// Carga el usuario seleccionado en el bloque
        /// </summary>
        private void CargarUsuario()
        {
            LimpiarUsuario();
            if (usuarios != null && usuarios.Length > 0 && tblUsuarios.CurrentRow.Index <= usuarios.Length -1)
            {
                ModoModificar();

                txtNombre.Text = usuarios[tblUsuarios.CurrentRow.Index].Nombre;
                txtApellidos.Text = usuarios[tblUsuarios.CurrentRow.Index].Apellidos;
                txtDireccion.Text = usuarios[tblUsuarios.CurrentRow.Index].Direccion;
                txtLogin.Text = usuarios[tblUsuarios.CurrentRow.Index].Login; ;
                txtDni.Text = usuarios[tblUsuarios.CurrentRow.Index].Dni;
                txtTelefono.Text = usuarios[tblUsuarios.CurrentRow.Index].Telefono;
                chkAdmin.Checked = usuarios[tblUsuarios.CurrentRow.Index].Admin;
            }
            else
            {
                ModoNuevo();
            }
        }

        /// <summary>
        /// Limpia el bloque de usuario selecionado a valores vacios
        /// </summary>
        private void LimpiarUsuario()
        {
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtLogin.Text = "";
            txtPass.Text = "";
            txtDireccion.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            chkAdmin.Checked = false;

        }

        /// <summary>
        /// Limpia y carga el listado de usuarios en la tabla
        /// </summary>
        private void CargarListado()
        {
            tblUsuarios.Rows.Clear();
            if (usuarios != null)
            {

                for (int i = 0; i < usuarios.Length; i++)
                {
                    tblUsuarios.Rows.Add();
                    tblUsuarios.Rows[i].Cells[0].Value = usuarios[i].Codigo;
                    tblUsuarios.Rows[i].Cells[1].Value = usuarios[i].Nombre;
                    tblUsuarios.Rows[i].Cells[2].Value = usuarios[i].Apellidos;
                    tblUsuarios.Rows[i].Cells[3].Value = usuarios[i].Login;
                    tblUsuarios.Rows[i].Cells[4].Value = usuarios[i].Direccion;
                    tblUsuarios.Rows[i].Cells[5].Value = usuarios[i].Dni;
                    tblUsuarios.Rows[i].Cells[6].Value = usuarios[i].Telefono;
                    tblUsuarios.Rows[i].Cells[7].Value = usuarios[i].Admin;

                }

            }

        }

        /// <summary>
        /// Evento Buscar usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtBusNombre.Text.Trim();

            usuarios = usuarioN.BuscarUsuarios(nombre);

            CargarListado();
            
        }

        /// <summary>
        /// Evento cambio seleción en la tabla para cargar datos del usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tblUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            CargarUsuario();
        }

        /// <summary>
        /// Evento resetea el buscador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBusNombre.Text = "";

            usuarios = usuarioN.ListadoUsuarios();
            CargarListado();
        }

        /// <summary>
        /// Evento crear nuevo usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ModoNuevo();
            LimpiarUsuario();
            
        }

        /// <summary>
        /// Modifica el formulario para adaptar el bloque del usuario en Modo editar
        /// </summary>
        private void ModoModificar()
        {
            gbUsuario.Text = "Editar usuario";
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

            btnGuardarNuevo.Enabled = false;
        }

        /// <summary>
        /// Modifica el formulario para adaptar el bloque del usuario en Modo nuevo usuario
        /// </summary>
        private void ModoNuevo()
        {
            tblUsuarios.ClearSelection();
            gbUsuario.Text = "Añadir nuevo usuario";
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            btnGuardarNuevo.Enabled = true;
        }

        /// <summary>
        /// Crear un objeto Usuario con los valores de los textBox
        /// </summary>
        /// <returns></returns>
        private Usuario ObtenerUsuario()
        {
            
            Usuario u = new Usuario();

            if (tblUsuarios.CurrentRow != null)
            {
                u.Codigo = usuarios[tblUsuarios.CurrentRow.Index].Codigo;
            }
            u.Nombre = txtNombre.Text;
            u.Apellidos = txtApellidos.Text;
            u.Login = txtLogin.Text;
            u.Pass = txtPass.Text;
            u.Direccion = txtDireccion.Text;
            u.Dni = txtDni.Text;
            u.Telefono = txtTelefono.Text;
            u.Admin = chkAdmin.Checked;

            return u;

        }

        /// <summary>
        /// Crear un objeto Usuario con los valores de los textBox
        /// </summary>
        /// <returns></returns>
        private bool ValidarUsuario(Usuario usuario)
        {
            if (usuario.Login.Trim() == null || usuario.Login.Trim().Length <= 0)
            {
                MessageBox.Show("El login es necesario", "Error usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (usuario.Pass.Trim() == null || usuario.Pass.Trim().Length < 3 || usuario.Pass.Trim().Length > 20)
            {
                MessageBox.Show("La pass debe tener entre 3 y 20 caracteres", "Error usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }

        /// <summary>
        /// Evento boton guardar un nuevo usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            
            Usuario usuario = ObtenerUsuario();
            if (ValidarUsuario(usuario))
            {
                bool ok = usuarioN.InsertarUsuario(usuario);
                if (ok)
                {
                    usuarios = usuarioN.ListadoUsuarios();
                    CargarListado();
                    MessageBox.Show("Usuario añadido correctamente", "Añadir Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                else
                {
                    MessageBox.Show("Error al añadido el usuario", "Error añadir usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        /// <summary>
        /// Evento modificar un usuario existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario usuario = ObtenerUsuario();

            if (ValidarUsuario(usuario))
            {
                bool ok = usuarioN.ActualizarUsuario(usuario);
                if (ok)
                {
                    usuarios = usuarioN.ListadoUsuarios();
                    CargarListado();
                    MessageBox.Show("Usuario modificado correctamente", "Modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error al modificadar el usuario", "Error modificar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        /// <summary>
        /// Evento eliminar un usuario existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codUsuario = usuarios[tblUsuarios.CurrentRow.Index].Codigo;
            bool ok = usuarioN.EliminarUsuario(codUsuario);
            if (ok)
            {
                usuarios = usuarioN.ListadoUsuarios();
                CargarListado();
                MessageBox.Show("Usuario eliminado correctamente", "Eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al eliminar el usuario",
                    "Error eliminar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       
    }
}
