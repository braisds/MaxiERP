using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidad;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class VentaBD
    {

        private MySqlConnection conexion;

        /// <summary>
        /// Consulta insertar una venta a la BD
        /// </summary>
        private const string INSERTAR_VENTA
            = "INSERT INTO venta (cod_cliente, numVenta, fecha, iva) VALUES (@cod_cliente, @numVenta, @fecha, @iva)";

        /// <summary>
        /// Consulta actualizar una venta de la BD
        /// </summary>
        private const string ACTUALIZAR_VENTA
            = "UPDATE venta SET cod_cliente = @cod_cliente, numVenta = @numVenta, fecha = @fecha, iva = @iva WHERE codigo = @codigo";

        /// <summary>
        /// Consulta obtener listado ventas de la BD
        /// </summary>
        private const string OBTENER_LISTADO_VENTA
            = "SELECT codigo, cod_cliente, numVenta, fecha, iva FROM venta";

        /// <summary>
        /// Consulta obtener una venta de la BD
        /// </summary>
        private const string OBTENER_VENTA
            = "SELECT codigo, cod_cliente, numVenta, fecha, iva FROM venta WHERE codigo = @codigo";

        /// <summary>
        /// Consulta buscar ventas por cliente de la BD
        /// </summary>
        private const string BUSCAR_VENTA
            = "SELECT codigo, cod_cliente, numVenta, fecha, iva FROM venta " +
            "   where (@cod_cliente = 0 OR cod_cliente = @cod_cliente) ";

        public VentaBD()
        {
            conexion = new MySqlConnection(configuracion.sql);
        }

        /// <summary>
        /// Metodo para insertar una venta a la BD
        /// </summary>
        /// <param name="venta"> venta a insertar</param>
        /// <returns>insertado con exito(true), si hubo error(false)</returns>
        public bool InsertarVenta(Venta venta)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(INSERTAR_VENTA, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@cod_cliente", venta.Cliente.Codigo);
                cmd.Parameters.AddWithValue("@numVenta", venta.NumVenta);
                cmd.Parameters.AddWithValue("@fecha", venta.Fecha);
                cmd.Parameters.AddWithValue("@iva", venta.Iva);

                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();

                }
                return false;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }

        }

        /// <summary>
        /// Metodo para actulizar una venta a la BD
        /// </summary>
        /// <param name="venta"> venta a actualiazar</param>
        /// <returns>actualizado con exito(true), si hubo error(false)</returns>
        public bool ActualizarVenta(Venta venta)
        {

            MySqlCommand cmd = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(ACTUALIZAR_VENTA, conexion, conexion.BeginTransaction());

                cmd.Parameters.AddWithValue("@cod_cliente", venta.Cliente.Codigo);
                cmd.Parameters.AddWithValue("@numVenta", venta.NumVenta);
                cmd.Parameters.AddWithValue("@fecha", venta.Fecha);
                cmd.Parameters.AddWithValue("@iva", venta.Iva);

                cmd.Parameters.AddWithValue("@codigo", venta.Codigo);

                cmd.ExecuteNonQuery();

                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();

                }
                return false;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }

        }

        /// <summary>
        /// Metodo para obtener listado ventas de la BD
        /// </summary>
        /// <returns>array Venta</returns>
        public Venta[] ListadoVentas()
        {

            MySqlCommand cmd = null;
            Venta[] ventas = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(OBTENER_LISTADO_VENTA, conexion);

                MySqlDataReader rs = cmd.ExecuteReader();

                List<Venta> lista = new List<Venta>();
                while (rs.Read())
                {
                    Venta u = new Venta();
                    u.Codigo = rs.GetInt32("codigo");
                    u.Cliente.Codigo = rs.GetInt32("cod_cliente");
                    u.NumVenta = rs.GetString("numVenta");
                    u.Fecha = rs.GetDateTime("fecha");
                    u.Iva = rs.GetDouble("iva");

                    lista.Add(u);

                }

                if (lista != null && lista.Count > 0)
                {
                    ventas = lista.ToArray();
                }

                return ventas;

            }
            catch (Exception)
            {
                return null;

            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }

            }

        }

        /// <summary>
        /// Metodo para obtener una venta de la BD
        /// </summary>
        /// <param name="codVenta">codigo de la venta</param>
        /// <returns>objeto Venta</returns>
        public Venta ObtenerVenta(int codVenta)
        {

            MySqlCommand cmd = null;
            Venta venta = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(OBTENER_VENTA, conexion);

                cmd.Parameters.AddWithValue("@codigo", codVenta);

                MySqlDataReader rs = cmd.ExecuteReader();

                if (rs.HasRows)
                {
                    rs.Read();

                    venta = new Venta();
                    venta.Codigo = rs.GetInt32("codigo");
                    venta.Cliente.Codigo = rs.GetInt32("cod_cliente");
                    venta.NumVenta = rs.GetString("numVenta");
                    venta.Fecha = rs.GetDateTime("fecha");
                    venta.Iva = rs.GetDouble("iva");
                }

                return venta;

            }
            catch (Exception)
            {
                return null;

            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }

            }

        }

        /// <summary>
        /// Metodo buscar ventas por cliente de la BD
        /// </summary>
        /// <param name="cod_cliente">codigo cliente</param>
        /// <returns>array Venta</returns>
        public Venta[] BuscarVentas(int cod_cliente)
        {

            MySqlCommand cmd = null;
            Venta[] ventas = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(BUSCAR_VENTA, conexion);

                cmd.Parameters.AddWithValue("@cod_cliente", cod_cliente);

                MySqlDataReader rs = cmd.ExecuteReader();

                List<Venta> lista = new List<Venta>();
                while (rs.Read())
                {
                    Venta c = new Venta();
                    c.Codigo = rs.GetInt32("codigo");
                    c.Cliente.Codigo = rs.GetInt32("cod_cliente");
                    c.NumVenta = rs.GetString("numVenta");
                    c.Fecha = rs.GetDateTime("fecha");
                    c.Iva = rs.GetDouble("iva");

                    lista.Add(c);

                }

                if (lista != null && lista.Count > 0)
                {
                    ventas = lista.ToArray();
                }
                

                return ventas;

            }
            catch (Exception)
            {
                return null;

            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }

            }


        }




    }
}
