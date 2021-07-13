using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Venta
    {
        private D_Conexion conexion = new D_Conexion();

        public D_DetalleVP dDetalleVP = new D_DetalleVP();
        public D_Producto dProducto = new D_Producto();
        public D_Empleado dEmpleado = new D_Empleado();
        public D_Cliente dCliente = new D_Cliente();
        public int idVenta { get; set; }
        public float subtotal { get; set; }
        public float iva { get; set; }
        public float total { get; set; }
        public string folio { get; set; }
        public DateTime fecha { get; set; }
        public int stat { get; set; }
        public int idPersonaE { get; set; }
        public int idPesonaC { get; set; }





        public DataTable mostrarClientes()
        {
            var tablaMostrarCliente = new DataTable();
            try
            {
                conexion.abrir();
                var cmd = new SqlCommand("SP_MOSTRARCLIENTEVENTANOMBRE", conexion.conectarbd);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }


                tablaMostrarCliente.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarCliente;
        }
        public DataTable mostrarProductos()
        {
            var tablaMostrarProducto = new DataTable();
            try
            {
                conexion.abrir();
                var cmd = new SqlCommand("SP_MOSTRARPRODUCTOSVENTA", conexion.conectarbd);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }


                tablaMostrarProducto.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarProducto;
        }

        public bool InsertarPrimerProductoVenta()
        {
            bool success = false;
            try
            {
                conexion.abrir();

                var cmd = new SqlCommand("SP_REALIZARVENTA", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", dProducto.idProducto);
                cmd.Parameters.AddWithValue("@cantidad", dDetalleVP.cantidad);
                cmd.Parameters.AddWithValue("@idEmpleado", dEmpleado.idPersonaE);
                cmd.Parameters.AddWithValue("@idCliente", dCliente.idPersonaC);
                var resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                    success = true;

                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return success;
        }
        public bool AñadirMasProducto()
        {
            bool success = false;
            try
            {
                conexion.abrir();

                var cmd = new SqlCommand("SP_AÑADIRPRODUCTOSVENTA", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", dProducto.idProducto);
                cmd.Parameters.AddWithValue("@cantidad", dDetalleVP.cantidad);
                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                var resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                    success = true;

                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return success;
        }

        public DataTable mostrarVentaEnProceso()
        {
            var tablaMostrarVenta = new DataTable();
            try
            {
                conexion.abrir();
                var cmd = new SqlCommand("SP_MOSTRARVENTAENPROCESO", conexion.conectarbd);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }


                tablaMostrarVenta.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarVenta;
        }
        public void borrar()
        {

        }       

    }
}
