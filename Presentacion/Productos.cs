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
    public partial class Productos : Form
    {
        private ProductoN productoN;
        private TipoProductoN tipoProductoN;
        private Producto[] productos = null;//tabla de productos
        private TipoProducto[] cbTiposProducto = null;//combo tipos
        private TipoProducto[] tiposProducto = null;//tabla de tipos

        public Productos()
        {
            InitializeComponent();

            productoN = new ProductoN();
            tipoProductoN = new TipoProductoN();
        }

        /// <summary>
        /// Evento load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Productos_Load(object sender, EventArgs e)
        {
            productos = productoN.ListadoProductos();
            tiposProducto = tipoProductoN.ListadoTiposProductos();

            CargarListado();
            CargarListadoTipos();
            CargarCBTipos();

        }

        /// <summary>
        /// Actualizar los combobox de tipos de producto
        /// </summary>
        private void CargarCBTipos()
        {
            cbTiposProducto = tipoProductoN.ListadoTiposProductos();
            if (cbTiposProducto != null)
            {
                //Combo producto seleccionado
                cbTipo.DataSource = cbTiposProducto.ToList();
                cbTipo.DisplayMember = "Nombre";
                cbTipo.ValueMember = "Codigo";

                //Combo buscador
                TipoProducto tpTodos = new TipoProducto();
                tpTodos.Codigo = 0;
                tpTodos.Nombre = "TODOS";

                List<TipoProducto> tiposBuscar = cbTiposProducto.ToList();
                tiposBuscar.Insert(0, tpTodos);

                cbBusTipo.DataSource = tiposBuscar;
                cbBusTipo.DisplayMember = "Nombre";
                cbBusTipo.ValueMember = "Codigo";
            }
        }

        /// <summary>
        /// Carga el producto seleccionado en el bloque
        /// </summary>
        private void CargarProducto()
        {
            LimpiarProducto();
            if (productos != null && productos.Length > 0 && tblProductos.CurrentRow.Index <= productos.Length -1)
            {
                ModoModificar();

                txtNombre.Text = productos[tblProductos.CurrentRow.Index].Nombre;
                txtStock.Text = productos[tblProductos.CurrentRow.Index].Stock + "";
                txtPrecio.Text = productos[tblProductos.CurrentRow.Index].Precio + "";
                txtDescripcion.Text = productos[tblProductos.CurrentRow.Index].Descripcion;
                txtMarca.Text = productos[tblProductos.CurrentRow.Index].Marca;

                cbTipo.SelectedValue = productos[tblProductos.CurrentRow.Index].TipoProducto.Codigo;
            }
        }

        /// <summary>
        /// Limpia el bloque de producto selecionado a valores vacios
        /// </summary>
        private void LimpiarProducto()
        {
            txtNombre.Text = "";
            txtStock.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            if(cbTipo.Items.Count > 0)
            {
                cbTipo.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// Limpia y carga el listado de productos en la tabla
        /// </summary>
        private void CargarListado()
        {
            tblProductos.Rows.Clear();
            if (productos != null)
            {

                for (int i = 0; i < productos.Length; i++)
                {
                    tblProductos.Rows.Add();
                    tblProductos.Rows[i].Cells[0].Value = productos[i].Codigo;
                    tblProductos.Rows[i].Cells[1].Value = productos[i].Nombre;
                    tblProductos.Rows[i].Cells[2].Value = productos[i].Descripcion;
                    tblProductos.Rows[i].Cells[3].Value = productos[i].Marca;
                    tblProductos.Rows[i].Cells[4].Value = productos[i].Stock;
                    tblProductos.Rows[i].Cells[5].Value = productos[i].Precio;
                    if (productos[i].TipoProducto != null)
                    {
                        tblProductos.Rows[i].Cells[6].Value = productos[i].TipoProducto.Nombre;
                    }

                }

            }

        }

        /// <summary>
        /// Evento Buscar productos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtBusNombre.Text.Trim();
            int codTipo = 0;
            if (cbBusTipo.SelectedValue != null)
            {
                codTipo = (int)cbBusTipo.SelectedValue;
            } 

            productos = productoN.BuscarProductos(nombre, codTipo);

            CargarListado();
            
        }

        /// <summary>
        /// Evento cambio seleción en la tabla para cargar datos del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tblProductos_SelectionChanged(object sender, EventArgs e)
        {
            CargarProducto();
        }

        /// <summary>
        /// Evento resetea el buscador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (cbBusTipo.Items.Count > 0)
            {
                cbBusTipo.SelectedIndex = 0;
            }
            txtBusNombre.Text = "";

            productos = productoN.ListadoProductos();
            CargarListado();
        }

        /// <summary>
        /// Evento crear nuevo producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ModoNuevo();
            LimpiarProducto();
            
        }

        /// <summary>
        /// Modifica el formulario para adaptar el bloque del producto en Modo editar
        /// </summary>
        private void ModoModificar()
        {
            gbProducto.Text = "Editar producto";
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

            btnGuardarNuevo.Enabled = false;
        }

        /// <summary>
        /// Modifica el formulario para adaptar el bloque del producto en Modo nuevo producto
        /// </summary>
        private void ModoNuevo()
        {
            tblProductos.ClearSelection();
            gbProducto.Text = "Añadir nuevo producto";
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            btnGuardarNuevo.Enabled = true;
        }

        /// <summary>
        /// Crear un objeto Producto con los valores de los textBox
        /// </summary>
        /// <returns></returns>
        private Producto ObtenerProducto()
        {
            
            Producto p = new Producto();

            if (tblProductos.CurrentRow != null)
            {
                p.Codigo = productos[tblProductos.CurrentRow.Index].Codigo;
            }
            p.Nombre = txtNombre.Text;
            p.Descripcion = txtDescripcion.Text;
            if (txtPrecio.Text != null && txtPrecio.Text.Length>0)
            {
                p.Precio = Convert.ToDouble(txtPrecio.Text);
            }
            if (txtStock.Text != null && txtStock.Text.Length > 0)
            {
                p.Stock = Convert.ToInt32(txtStock.Text);
            }
            
            p.Marca = txtMarca.Text;
            p.TipoProducto = (TipoProducto)cbTipo.SelectedItem;

            return p;

        }

        /// <summary>
        /// Evento boton guardar un nuevo producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = ObtenerProducto();

                bool ok = productoN.InsertarProducto(producto);
                if (ok)
                {
                    productos = productoN.ListadoProductos();
                    CargarListado();
                    MessageBox.Show("Producto añadido correctamente", "Añadir producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                else
                {
                    MessageBox.Show("Error al añadido el producto", "Error añadir producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de formato en precio o stock.", "Error añadir producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error de formato en precio o stock.", "Error añadir producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento modificar un producto existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try{ 

                Producto producto = ObtenerProducto();

                bool ok = productoN.ActualizarProducto(producto);
                if (ok)
                {
                    productos = productoN.ListadoProductos();
                    CargarListado();
                    MessageBox.Show("Producto modificado correctamente", "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error al modificadar el producto", "Error modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de formato en precio o stock.","Error modificar producto",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error de formato en precio o stock.", "Error añadir producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Evento eliminar un producto existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codProducto = productos[tblProductos.CurrentRow.Index].Codigo;
            bool ok = productoN.EliminarProducto(codProducto);
            if (ok)
            {
                productos = productoN.ListadoProductos();
                CargarListado();
                MessageBox.Show("Producto eliminado correctamente", "Eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al eliminar el producto. Nota: no se puede eliminar un producto si esta vinculado a alguna venta.",
                    "Error eliminar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*TIPOS PRODUCTO*/

        /// <summary>
        /// Limpia y carga el listado de tipos productos en la tabla
        /// </summary>
        private void CargarListadoTipos()
        {
            tblTipos.Rows.Clear();
            if (tiposProducto != null)
            {
                for (int i = 0; i < tiposProducto.Length; i++)
                {
                    tblTipos.Rows.Add();
                    tblTipos.Rows[i].Cells[0].Value = tiposProducto[i].Codigo;
                    tblTipos.Rows[i].Cells[1].Value = tiposProducto[i].Nombre;
                }

            }

        }

        /// <summary>
        /// Evento buscar tipos producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBusTNombre.Text.Trim();

            tiposProducto = tipoProductoN.BuscarTiposProducto(nombre);

            CargarListadoTipos();
        }

        /// <summary>
        /// Evento resetea el buscador de tipos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTRest_Click(object sender, EventArgs e)
        {
            txtBusTNombre.Text = "";

            tiposProducto = tipoProductoN.ListadoTiposProductos();
            CargarListadoTipos();
        }


        /// <summary>
        /// Carga el producto seleccionado en el bloque
        /// </summary>
        private void CargarTipoProducto()
        {
            LimpiarTipoProducto();
            if (tiposProducto != null && tiposProducto.Length > 0 && tblTipos.CurrentRow.Index <= tiposProducto.Length - 1)
            {
                ModoTipoModificar();

                txtTNombre.Text = tiposProducto[tblTipos.CurrentRow.Index].Nombre;
            }
        }

        /// <summary>
        /// Limpia el bloque de tipo producto selecionado a valores vacios
        /// </summary>
        private void LimpiarTipoProducto()
        {
            txtTNombre.Text = "";
        }

        /// <summary>
        /// Modifica el formulario para adaptar el bloque del tipo producto en Modo editar y eliminar
        /// </summary>
        private void ModoTipoModificar()
        {
            gbTipo.Text = "Editar tipo producto";
            btnTModificar.Enabled = true;
            btnTEliminar.Enabled = true;

            btnTGuardar.Enabled = false;
        }

        /// <summary>
        /// Modifica el formulario para adaptar el bloque del tipo producto en Modo nuevo producto
        /// </summary>
        private void ModoTipoNuevo()
        {
            tblTipos.ClearSelection();
            gbTipo.Text = "Añadir nuevo tipo producto";
            btnTModificar.Enabled = false;
            btnTEliminar.Enabled = false;

            btnTGuardar.Enabled = true;
        }

        /// <summary>
        /// Crear un objeto TipoProducto con los valores de los textBox
        /// </summary>
        /// <returns></returns>
        private TipoProducto ObtenerTipoProducto()
        {

            TipoProducto tp = new TipoProducto();

            if (tblTipos.CurrentRow != null)
            {
                tp.Codigo = tiposProducto[tblTipos.CurrentRow.Index].Codigo;
            }
            tp.Nombre = txtTNombre.Text;

            return tp;

        }

        /// <summary>
        /// Evento crear nuevo tipo producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTNuevo_Click(object sender, EventArgs e)
        {
            ModoTipoNuevo();
            LimpiarTipoProducto();
        }

        /// <summary>
        /// Evento guardar nuevo tipo producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTGuardar_Click(object sender, EventArgs e)
        {
            TipoProducto tipoProducto = ObtenerTipoProducto();

            bool ok = tipoProductoN.InsertarTipoProducto(tipoProducto);
            if (ok)
            {
                tiposProducto = tipoProductoN.ListadoTiposProductos();
                CargarListadoTipos();
                CargarCBTipos();
                MessageBox.Show("Tipo Producto añadido correctamente", "Añadir Tipo producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al añadido el tipo producto", "Error añadir tipo producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Evento modifica un tipo producto existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTModificar_Click(object sender, EventArgs e)
        {
            TipoProducto tipoProducto = ObtenerTipoProducto();

            bool ok = tipoProductoN.ActualizarTipoProducto(tipoProducto);
            if (ok)
            {
                tiposProducto = tipoProductoN.ListadoTiposProductos();
                CargarListadoTipos();
                CargarCBTipos();
                MessageBox.Show("Tipo producto modificado correctamente", "Modificar tipo producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al modificadar el tipo producto", "Error modificar tipo producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento eliminar tipo producto existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTEliminar_Click(object sender, EventArgs e)
        {
            int codTipoProducto = tiposProducto[tblTipos.CurrentRow.Index].Codigo;
            bool ok = tipoProductoN.EliminarTipoProducto(codTipoProducto);
            if (ok)
            {
                tiposProducto = tipoProductoN.ListadoTiposProductos();
                CargarListadoTipos();
                CargarCBTipos();
                MessageBox.Show("Tipo producto eliminado correctamente", "Eliminar tipo producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error al eliminar el tipo producto. Nota: no se puede eliminar un tipo producto si esta vinculado a alguna producto.",
                    "Error eliminar tipo producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento carga el tipo producto seleccionado cuando se cambia la seleccion en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tblTipos_SelectionChanged(object sender, EventArgs e)
        {
            CargarTipoProducto();
        }

       
    }
}
