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
    public partial class Principal : Form
    {
        private Usuario usuarioSesion;

        private UsuarioN usuarioN;

        public Principal()
        {
            InitializeComponent();

            usuarioN = new UsuarioN();
        }

        /// <summary>
        /// Load del formulario y LOGIN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Principal_Load(object sender, EventArgs e)
        {
            Login l = new Login();
            bool ok = false;

            do
            {
                DialogResult r = l.ShowDialog();

                if (r == DialogResult.OK)
                {
                    if (l.txtUsuario.Text.Trim() != null && l.txtPass.Text.Trim() != null)
                    {

                        usuarioSesion = usuarioN.HacerLogin(l.txtUsuario.Text.Trim(), l.txtPass.Text.Trim());
                        ok = (usuarioSesion != null) ? true : false;

                        if (!ok)
                        {
                            l.lblError.Text = "Login erroneo";
                        }
                        else
                        {
                            if (usuarioSesion.Nombre != null)
                            {
                                lblUsuario.Text = usuarioSesion.Nombre;
                            }
                            
                            if (usuarioSesion.Admin)
                            {
                                btnUsuario.Visible = true;
                                btnUsuario.Enabled = true;
                            }
                            else
                            {
                                btnUsuario.Visible = false;
                                btnUsuario.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        l.lblError.Text = "Login erroneo";
                    }
                }
                else
                {
                    ok = true; //para acabar el bucle
                    this.Close();
                }
                
            } while (!ok);
 

        }

        /// <summary>
        /// Evento abrir formulario inventario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInventario_Click(object sender, EventArgs e)
        {
            Productos formProductos = new Productos();
            formProductos.ShowDialog();
        }

        /// <summary>
        /// Evento abrir formulario usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuarios formUsuarios = new Usuarios();
            formUsuarios.ShowDialog();
        }

        /// <summary>
        /// Evento abrir formulario clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes formClientes = new Clientes();
            formClientes.ShowDialog();
        }

        /// <summary>
        /// Evento abrir formulario ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas formVentas = new Ventas();
            formVentas.ShowDialog();
        }
    }
}
