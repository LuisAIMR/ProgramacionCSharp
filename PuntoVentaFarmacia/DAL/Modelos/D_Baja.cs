using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Baja
    {
        private D_Conexion conexion = new D_Conexion();
        public int idBaja { get; set; }
        public int cantidad { get; set; }
        public string motivo { get; set; }
        public bool stat { get; set; }
        public int idProducto { get; set; }

        public bool Insertar()
        {
            bool success = false;
            try
            {
                conexion.abrir();

                var cmd = new SqlCommand("SP_INSERTARBAJA", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@", );
                //cmd.Parameters.AddWithValue("@", );
                //cmd.Parameters.AddWithValue("@", );
                //cmd.Parameters.AddWithValue("@", stat);
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
        public bool actualizarBaja()
        {
            bool success = false;
            try
            {
                conexion.abrir();
                //string sql = "UPDATE Proveedor SET nombrePro='" + nombrePro + "',telefono='" + telefono;
                //       sql   += "',descripcion='" + descripcion + "' where idProveedor=" + idProveedor.ToString() ;

                var cmd = new SqlCommand("SP_ACTUALIZARBAJA", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@", );
                //cmd.Parameters.AddWithValue("@", );
                //cmd.Parameters.AddWithValue("@", );
                //cmd.Parameters.AddWithValue("@", );
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
        public DataTable mostrarBaja()
        {
            var tablaMostrarBaja = new DataTable();
            try
            {
                conexion.abrir();
                var cmd = new SqlCommand("SP_BUSCARBAJAS", conexion.conectarbd);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }


                tablaMostrarBaja.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarBaja;
        }
        public void borrar()
        {

        }
        public DataTable BuscarBaja()
        {
            var tablaBuscarBaja = new DataTable();
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_BUSQUEDABAJAS", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@", );
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaBuscarBaja.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaBuscarBaja;

        }

    }
}
