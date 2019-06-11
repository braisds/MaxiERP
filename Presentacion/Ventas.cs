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
    public partial class Ventas : Form
    {
        private VentaN ventaN;
        private Venta[] ventas;

        public Ventas()
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
            ventas = ventaN.ListadoVentas();

            CargarListado();

        }

        /// <summary>
        /// Carga la venta seleccionado en el bloque
        /// </summary>
        private void CargarVenta()
        {
            if (ventas != null && ventas.Length > 0 && tblVentas.CurrentRow.Index <= ventas.Length -1)
            {
                ModoVer();

            }
        }

        /// <summary>
        /// Limpia y carga el listado de ventas en la tabla
        /// </summary>
        private void CargarListado()
        {
            tblVentas.Rows.Clear();
            if (ventas != null)
            {

                for (int i = 0; i < ventas.Length; i++)
                {
                    tblVentas.Rows.Add();
                    tblVentas.Rows[i].Cells[0].Value = ventas[i].Codigo;
                    tblVentas.Rows[i].Cells[1].Value = ventas[i].NumVenta;
                    if (ventas[i].Cliente != null)
                    { 
                        tblVentas.Rows[i].Cells[2].Value = ventas[i].Cliente.Nombre;
                    }
                    tblVentas.Rows[i].Cells[3].Value = ventas[i].Fecha;

                }

            }

        }

        /// <summary>
        /// Evento Buscar ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtBusNombre.Text.Trim();
            string numVenta = txtNumVenta.Text.Trim();

            ventas = ventaN.BuscarVentas(nombre, numVenta);

            CargarListado();
            
        }

        /// <summary>
        /// Evento cambio seleción en la tabla para cargar datos del ventas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tblVentas_SelectionChanged(object sender, EventArgs e)
        {
            CargarVenta();
        }

        /// <summary>
        /// Evento resetea el buscador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBusNombre.Text = "";
            txtNumVenta.Text = "";

            ventas = ventaN.ListadoVentas();
            CargarListado();
        }

        /// <summary>
        /// Modifica el formulario para adaptar el bloque del venta en Modo ver
        /// </summary>
        private void ModoVer()
        {
            btnVer.Enabled = true;
        }

        /// <summary>
        /// Modifica el formulario para adaptar el bloque del venta en Modo nuevo venta
        /// </summary>
        private void ModoNuevo()
        {
            tblVentas.ClearSelection();
            btnVer.Enabled = false;
        }

        /// <summary>
        /// Abrir una venta existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVer_Click(object sender, EventArgs e)
        {
            int codigo = ventas[tblVentas.CurrentRow.Index].Codigo;

            VentaVer formVentaVer = new VentaVer(codigo);
            formVentaVer.ShowDialog();
        }

        /// <summary>
        /// Evento crear nuevo venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            VentaVer formVentaVer = new VentaVer();
            formVentaVer.ShowDialog();

            if (formVentaVer.VentaCreada)
            {
                ventas = ventaN.ListadoVentas();
                CargarListado();

            }
        }
    }
}
