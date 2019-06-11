using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class VentaN
    {
        private VentaBD ventaBD;
        private VentaProductoBD ventaProductoBD;
        private ClienteBD clienteBD;
        private ProductoBD productoBD;

        public VentaN()
        {
            ventaBD = new VentaBD();
            ventaProductoBD = new VentaProductoBD();
            clienteBD = new ClienteBD();
            productoBD = new ProductoBD();
        }

        /// <summary>
        /// Obtiene listado de ventas
        /// </summary>
        /// <returns>array Venta</returns>
        public Venta[] ListadoVentas()
        {
            Venta[] ventas = null;
            ventas = ventaBD.ListadoVentas();

            if (ventas != null)
            {
                foreach (Venta v in ventas)
                {
                    v.Cliente = clienteBD.ObtenerCliente(v.Cliente.Codigo);
                }

            }


            return ventas;
        }

        /// <summary>
        /// Metodo para buscar ventas
        /// </summary>
        /// <param name="nombreCliente">nombre cliente</param>
        /// <param name="numVenta">nomVenta</param>
        /// <returns>array Venta</returns>
        public Venta[] BuscarVentas(string nombreCliente, string numVenta)
        {
            
            Venta[] ventas = null;
            Cliente[] clientes = null;

            if (nombreCliente != null && nombreCliente.Length > 0 )
            {
                clientes = clienteBD.BuscarClientes(nombreCliente);
            }
            
            int[] codigosCliente = null;

            if (clientes != null && clientes.Length > 0)
            {
                codigosCliente = new int[clientes.Length];

                for (int i = 0; i < clientes.Length ;i++)
                {
                    codigosCliente[i] = clientes[i].Codigo;
                }
            }


            ventas = ventaBD.BuscarVentas(codigosCliente, numVenta);

            if (ventas != null)
            {
                foreach (Venta v in ventas)
                {
                    v.Cliente = clienteBD.ObtenerCliente(v.Cliente.Codigo);
                }

            }


            return ventas;
            
        }

        /// <summary>
        /// Insertar nueva Venta
        /// </summary>
        /// <param name="venta">objeto Venta</param>
        /// <returns>true correcto false fallo</returns>
        public bool InsertarVenta(Venta venta)
        {

            bool ok = false;

            if (venta != null)
            {
                venta.Codigo = ventaBD.InsertarVenta(venta);
                if (venta.Codigo > 0)
                {
                    ok = ventaProductoBD.InsertarVentaProducto(venta);
                    if (ok)
                    {
                        List<Producto> productos = new List<Producto>();
                        foreach (VentaProducto vp in venta.Productos)
                        {

                            vp.Producto.Stock = vp.Producto.Stock - vp.Cantidad;

                            productos.Add(vp.Producto);
                        }

                        ok = productoBD.ActualizarStock(productos.ToArray());
                    }
                }
                else
                {
                    ok = false;
                }
            }

            return ok;

        }

        /// <summary>
        /// Obtener venta existente
        /// </summary>
        /// <param name="codVenta">codigo de venta</param>
        /// <returns>objeto Venta</returns>
        public Venta ObtenerVenta(int codVenta)
        {

            Venta venta = null;
            if (codVenta > 0)
            {
                venta = ventaBD.ObtenerVenta(codVenta);

                if (venta != null)
                {
                    venta.Cliente = clienteBD.ObtenerCliente(venta.Cliente.Codigo);
                    venta.Productos = ventaProductoBD.ListadoVentasProducto(venta.Codigo);

                    if (venta.Productos != null)
                    {
                        for (int i = 0; i < venta.Productos.Length; i++)
                        {
                            venta.Productos[i].Producto = productoBD.ObtenerProducto(venta.Productos[i].Producto.Codigo);
                        }
                    }
                }
            }

            return venta;

        }

        /// <summary>
        /// obtener el ultimo numVenta de la bd
        /// </summary>
        /// <returns>numVenta</returns>
        public string ObtenerUltimoNumVenta()
        {
            DateTime hoy = DateTime.Today;
            string num = ventaBD.ObtenerUltimoNumVenta();
            // [0] -> V | [1] -> YYMMDD | [2] -> XXXX 

            if (num != null)
            {
                
                string fecha = num.Split('-')[1];
                int dia = Convert.ToInt32(fecha.Substring(6, 2));
                int mes = Convert.ToInt32(fecha.Substring(4, 2));
                int anho = Convert.ToInt32(fecha.Substring(0, 4));

                if (dia == hoy.Day && mes == hoy.Month && anho == hoy.Year)
                {
                    num = string.Format("{0}{1:0000}", num.Substring(0, 11), (Convert.ToInt32(num.Split('-')[2]) + 1));
                }
                else
                {
                    num = string.Format("V-{0:0000}{1:00}{2:00}-0001", hoy.Year, hoy.Month, hoy.Day);
                }
                
            }
            else
            {

                num = string.Format("V-{0:0000}{1:00}{2:00}-0001", hoy.Year, hoy.Month, hoy.Day);
            }

            return num;

        }

    }
}
