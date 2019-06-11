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
    public partial class VentaVer : Form
    {
        public const double IVA_DEFECTO = 21;
        private VentaN ventaN;
        private Venta venta;

        public bool VentaCreada;//saber si la venta se creo bien

        private int codVenta;//saber si es una visializacion de una venta existente(bloquear modificacion) o es un a nueva

        /// <summary>
        /// visializacion de una venta existente(bloquear modificacion)
        /// </summary>
        /// <param name="codVenta">codigo venta</param>
        public VentaVer(int codVenta)
        {
            InitializeComponent();
            this.codVenta = codVenta;
            ventaN = new VentaN();
        }

        /// <summary>
        /// Para creacion de una nueva venta
        /// </summary>
        public VentaVer()
        {
            InitializeComponent();
            ventaN = new VentaN();
        }

        /// <summary>
        /// Evento load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ventas_Load(object sender, EventArgs e)
        {

            if (codVenta > 0)//ver venta existente
            {
                venta = ventaN.ObtenerVenta(codVenta);
                ModoVer();
                CargarProductos();
                CargarVenta();
                
            }
            else//venta nueva
            {
                venta = new Venta();
                venta.NumVenta = ventaN.ObtenerUltimoNumVenta();
                venta.Fecha = DateTime.Now;
                venta.Iva = IVA_DEFECTO;

                lblNumVenta.Text = "Num. Venta: " + venta.NumVenta;
                lblFecha.Text = venta.Fecha.ToShortDateString();
                txtIva.Text = venta.Iva+"";
            }

        }

        /// <summary>
        /// cargar datos de una venta existente para visializacion
        /// </summary>
        private void CargarVenta()
        {
            txtCliente.Text = venta.Cliente.Nombre;
            txtIva.Text = venta.Iva+"";
            lblNumVenta.Text = "Num. Venta: " +venta.NumVenta;
            lblFecha.Text = venta.Fecha.ToShortDateString();

            double subTotal = 0;
            foreach (VentaProducto n in venta.Productos){
                subTotal += n.PrecioUnidad * n.Cantidad;
            }

            txtSubTotal.Text = string.Format("{0:0.00}", subTotal);

            txtTotal.Text = string.Format("{0:0.00}", subTotal + (subTotal * venta.Iva / 100)) ;
        }


        /// <summary>
        /// Limpia y carga el listado de ventas en la tabla
        /// </summary>
        private void CargarProductos()
        {
            tblProductos.Rows.Clear();

            if (venta.Productos != null)
            {
                double subTotal = 0;
                for (int i = 0; i < venta.Productos.Length; i++)
                {
                    tblProductos.Rows.Add();
                    tblProductos.Rows[i].Cells[0].Value = venta.Productos[i].Producto.Nombre;
                    tblProductos.Rows[i].Cells[1].Value = venta.Productos[i].PrecioUnidad;
                    tblProductos.Rows[i].Cells[2].Value = venta.Productos[i].Cantidad;

                    subTotal += venta.Productos[i].PrecioUnidad * venta.Productos[i].Cantidad;
                }

                txtSubTotal.Text = string.Format("{0:0.00}", subTotal);

                txtTotal.Text = string.Format("{0:0.00}", subTotal + (subTotal * venta.Iva / 100));

            }

        }

        /// <summary>
        /// Modifica el formulario al modo ver venta existente(bloquear modificar)
        /// </summary>
        private void ModoVer()
        {
            btnGuardar.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.Enabled = false;
            btnModificar.Enabled = false;
            txtCantidad.Enabled = false;
            txtPrecioUnidad.Enabled = false;
            txtIva.Enabled = false;
        }

        /// <summary>
        /// Evento Buscar cliente para añadirlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Clientes formClientes = new Clientes(true);
            formClientes.ShowDialog();

            if(formClientes.clienteDevolver != null)
            {
                venta.Cliente = formClientes.clienteDevolver;
                txtCliente.Text = venta.Cliente.Nombre;
            }
            
        }

        /// <summary>
        /// Evento agregar producto a la venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Productos formProductos = new Productos(true);
            formProductos.ShowDialog();

            Producto p = formProductos.ProductoDevolver;

            if (p != null)
            {
                List<VentaProducto> tempProduct=null;
                VentaProducto vp = null;

                bool existe = false;

                if (venta.Productos != null && venta.Productos.Length > 0)
                {
                    //Comprobar si el producto ya esta en la lista
                    tempProduct = venta.Productos.ToList();
                    foreach (VentaProducto ventaP in venta.Productos)
                    {
                        if (ventaP.Producto.Codigo == p.Codigo)
                        {
                            existe = true;
                            break;
                        } 
                    }
                }
                else
                {
                    tempProduct = new List<VentaProducto>();
                }

                if (!existe)
                {
                    vp = new VentaProducto();
                    vp.Producto = p;
                    vp.PrecioUnidad = p.Precio;
                    vp.Cantidad = 1;

                    tempProduct.Add(vp);

                    venta.Productos = tempProduct.ToArray();
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show("El producto ya existe", "Error al añadir producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        /// <summary>
        /// Evento eliminar un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tblProductos.CurrentRow != null)
            {
                List<VentaProducto> tempProduct = null;

                if (venta.Productos != null)
                {
                    tempProduct = venta.Productos.ToList();
                    tempProduct.RemoveAt(tblProductos.CurrentRow.Index);

                    venta.Productos = tempProduct.ToArray();
                }

                CargarProductos();
                
            }
            
        }

        /// <summary>
        /// Evento modificar la cantidad y el precio del prodcuto selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblProductos.CurrentRow != null)
                {
                    venta.Productos[tblProductos.CurrentRow.Index].PrecioUnidad = Convert.ToDouble(txtPrecioUnidad.Text);
                    venta.Productos[tblProductos.CurrentRow.Index].Cantidad = Convert.ToInt32(txtCantidad.Text);
                }
                CargarProductos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error de formato en precio Unidad o cantidad", "Error modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error de formato en precio Unidad o cantidad", "Error modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Evento cambio selecion tabla productos para mostrar los datos en los textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tblProductos_SelectionChanged(object sender, EventArgs e)
        {
            
            if (tblProductos.CurrentRow != null && venta.Productos != null && venta.Productos.Length > 0 && tblProductos.Rows.Count == venta.Productos.Length)
            {
                txtPrecioUnidad.Text = venta.Productos[tblProductos.CurrentRow.Index].PrecioUnidad + "";
                txtCantidad.Text = venta.Productos[tblProductos.CurrentRow.Index].Cantidad + "";
                if (codVenta == 0)
                {
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                }
            }
            else
            {
                txtPrecioUnidad.Text = "";
                txtCantidad.Text = "";
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            
        }

        /// <summary>
        /// Validar venta
        /// </summary>
        /// <returns>true correcto false fallo</returns>
        private bool ValidarVenta()
        {
            if (venta.Cliente == null)
            {
                MessageBox.Show("Hay que selecionar un cliente", "Error guardar venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (venta.Productos == null || venta.Productos.Length == 0)
            {
                MessageBox.Show("Hay que añadir algún producto", "Error guardar venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (venta.Productos != null && venta.Productos.Length > 0)
            {
                foreach (VentaProducto vp in venta.Productos){
                    if (vp.Producto.Stock - vp.Cantidad < 0){
                        MessageBox.Show("Hay productos que no tienen el suficiente stock", "Error guardar venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }

            }
            

            return true;

        }

        /// <summary>
        /// Guardar venta y 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ValidarVenta())
            {
                VentaCreada = ventaN.InsertarVenta(venta);
                if (VentaCreada)
                {
                    ModoVer();
                    MessageBox.Show("Venta añadida correctamente", "Añadir Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                else
                {
                    MessageBox.Show("Error al añadir la venta", "Error añadir venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
