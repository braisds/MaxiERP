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

        public VentaN()
        {
            ventaBD = new VentaBD();
            ventaProductoBD = new VentaProductoBD();
            clienteBD = new ClienteBD();
        }

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

        public Venta[] BuscarVentas(int cod_cliente)
        {
            
            Venta[] ventas = null;
            ventas = ventaBD.BuscarVentas(cod_cliente);

            if (ventas != null)
            {
                foreach (Venta v in ventas)
                {
                    v.Cliente = clienteBD.ObtenerCliente(v.Cliente.Codigo);
                }

            }


            return ventas;
            
        }

        public bool InsertarVenta(Venta venta)
        {

            bool ok = false;

            if (venta != null)
            {
                ok = ventaBD.InsertarVenta(venta);
                if (ok)
                {
                    //TODO PRODUCTOS
                    
                }
            }

            return ok;

        }

        //todo
        public bool ActualizarVenta(Venta venta)
        {

            bool ok = false;

            if (venta != null)
            {
                ok = ventaBD.ActualizarVenta(venta);
            }

            return ok;

        }

    }
}
