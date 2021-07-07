using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Devolucion
    {
        private D_Conexion conexion = new D_Conexion();
        public int idDevolucion { get; set; }
        public string lote { get; set; }
        public string nombre { get; set; }
        public float nuPrecio { get; set; }

        public int cantidad { get; set; }
        public string motivo { get; set; }

        public int stat { get; set; }
        public int idProducto { get; set; }

        public bool Insertar()
        {
            bool success = false;
            try
            {
                conexion.abrir();

                var cmd = new SqlCommand("SP_INSERTARDEVOLUCION", conexion.conectarbd);
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
        public bool actualizarDevolucion()
        {
            bool success = false;
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_ACTUALIZARDEVOLUCION", conexion.conectarbd);
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
        public DataTable mostrarDevolucion()
        {
            var tablaMostrarDevolucion = new DataTable();
            try
            {
                conexion.abrir();
                var cmd = new SqlCommand("SP_BUSCARDEVOLUCION", conexion.conectarbd);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }


                tablaMostrarDevolucion.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarDevolucion;
        }
        public void borrar()
        {

        }
        public DataTable BuscarDevolucion()
        {
            var tablaBuscarDevolucion = new DataTable();
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_BUSQUEDADEVOLUCION", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@", );
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaBuscarDevolucion.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaBuscarDevolucion;

        }
    }
}
