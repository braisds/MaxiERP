using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            = "INSERT INTO venta (cod_cliente, num_venta, fecha, iva) VALUES (@cod_cliente, @numVenta, @fecha, @iva)";

        /// <summary>
        /// Consulta obtener listado ventas de la BD
        /// </summary>
        private const string OBTENER_LISTADO_VENTA
            = "SELECT codigo, cod_cliente, num_venta, fecha, iva FROM venta";

        /// <summary>
        /// Consulta obtener una venta de la BD
        /// </summary>
        private const string OBTENER_VENTA
            = "SELECT codigo, cod_cliente, num_venta, fecha, iva FROM venta WHERE codigo = @codigo";
        
        /// <summary>
        /// Consulta buscar ventas por cliente de la BD
        /// </summary>
        private const string BUSCAR_VENTA
            = "SELECT codigo, cod_cliente, num_venta, fecha, iva FROM venta " +
            "   where (@numVenta is null OR num_venta like @numVenta) "+
            "       #cliente#";

        /// <summary>
        /// Consulta buscar ventas por cliente de la BD
        /// </summary>
        private const string OBTENER_ULTIMO_NUMVENTA
            = "SELECT  num_venta FROM venta " +
            "    order by num_venta desc limit 1";

        private const string OBTENER_ULTIMO_CODIGO_INSERTADO
            = "SELECT LAST_INSERT_ID() as codigo";

        public VentaBD()
        {
            conexion = new MySqlConnection(configuracion.sql);
        }

        /// <summary>
        /// Metodo para insertar una venta a la BD
        /// </summary>
        /// <param name="venta"> venta a insertar</param>
        /// <returns>codigo de la venta, 0 si hay error</returns>
        public int InsertarVenta(Venta venta)
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

                cmd = new MySqlCommand(OBTENER_ULTIMO_CODIGO_INSERTADO, conexion);

                MySqlDataReader rs = cmd.ExecuteReader();
                int codigo = 0;
                if (rs.Read())
                {
                    codigo = rs.GetInt32("codigo");
                }

                return codigo;


            }
            catch (Exception)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();

                }
                return 0;
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
                    Venta v = new Venta();
                    Cliente c = new Cliente();

                    v.Codigo = rs.GetInt32("codigo");
                    c.Codigo = rs.GetInt32("cod_cliente");
                    v.Cliente = c;
                    v.NumVenta = rs.GetString("num_venta");
                    v.Fecha = rs.GetDateTime("fecha");
                    v.Iva = rs.GetDouble("iva");
                    
                    

                    lista.Add(v);

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
                    Cliente c = new Cliente();

                    venta.Codigo = rs.GetInt32("codigo");
                    c.Codigo = rs.GetInt32("cod_cliente");
                    venta.Cliente = c;
                    venta.NumVenta = rs.GetString("num_venta");
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
        /// Metodo buscar ventas por cliente o numventan de la BD
        /// </summary>
        /// <param name="nombreCliente">nombre cliente</param>
        /// <param name="numVenta">numVenta</param>
        /// <returns>array Venta</returns>
        public Venta[] BuscarVentas(int[] codCliente, string numVenta)
        {

            MySqlCommand cmd = null;
            Venta[] ventas = null;
            try
            {

                conexion.Open();
                string consulta = BUSCAR_VENTA;


                if (codCliente != null && codCliente.Length > 0)
                {
                    string codigos = "";
                    for (int i = 0; i < codCliente.Length; i++)
                    {
                        if (i < codCliente.Length - 1)
                        {
                            codigos += codCliente[i] + ",";
                        }
                        else
                        {
                            codigos += codCliente[i];
                        }

                    }

                    consulta = consulta.Replace("#cliente#", "AND cod_cliente in (" + codigos + ")");
                }
                else
                {
                    consulta = consulta.Replace("#cliente#", "");
                }

                
                cmd = new MySqlCommand(consulta, conexion);

                if (numVenta != null && numVenta.Length > 0)
                {
                    cmd.Parameters.AddWithValue("@numVenta", "%"+numVenta+"%");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@numVenta", null);
                }

                MySqlDataReader rs = cmd.ExecuteReader();

                List<Venta> lista = new List<Venta>();
                while (rs.Read())
                {
                    Venta v = new Venta();
                    Cliente c = new Cliente();
                    v.Codigo = rs.GetInt32("codigo");
                    c.Codigo = rs.GetInt32("cod_cliente");
                    v.Cliente = c;
                    v.NumVenta = rs.GetString("num_venta");
                    v.Fecha = rs.GetDateTime("fecha");
                    v.Iva = rs.GetDouble("iva");

                    lista.Add(v);

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
        /// Metodo para obtener el ultimo numVenta
        /// </summary>
        /// <returns>ultimo num venta</returns>
        public string ObtenerUltimoNumVenta()
        {

            MySqlCommand cmd = null;
            string num = null;
            try
            {

                conexion.Open();

                cmd = new MySqlCommand(OBTENER_ULTIMO_NUMVENTA, conexion);

                MySqlDataReader rs = cmd.ExecuteReader();

                if (rs.HasRows)
                {
                    rs.Read();

                    num = rs.GetString("num_venta");
                    
                }

                return num;

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
