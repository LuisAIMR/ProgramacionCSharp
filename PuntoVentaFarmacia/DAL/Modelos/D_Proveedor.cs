using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Proveedor
    {
        private D_Conexion conexion = new D_Conexion();
        public int idProveedor { get; set; }

        public string nombrePro { get; set; }
        public string telefono { get; set; }
        public string descripcion { get; set; }
        public int stat { get; set; }


        public bool Insertar()
        {
            bool success = false;
            try
            {
                conexion.abrir();
                
                var cmd = new SqlCommand("SP_INSERTARPROVEEDORES", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure; 
                cmd.Parameters.AddWithValue("@NombreProveedor", nombrePro);
                cmd.Parameters.AddWithValue("@Telefono",telefono);
                cmd.Parameters.AddWithValue("@Descripcion",descripcion);
                cmd.Parameters.AddWithValue("@stat",stat);
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
        public bool actualizarProveedor()
        {
            bool success = false;
            try
            {
                conexion.abrir();
                //string sql = "UPDATE Proveedor SET nombrePro='" + nombrePro + "',telefono='" + telefono;
                //       sql   += "',descripcion='" + descripcion + "' where idProveedor=" + idProveedor.ToString() ;

                var cmd = new SqlCommand("SP_ACTUALZIZARPROVEEDORES", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idProveedor);
                cmd.Parameters.AddWithValue("@NombreProveedor", nombrePro);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
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
        public DataTable mostrarProveedor()
        {
            var tablaMostrarProveedores = new DataTable();
            try
            {
                conexion.abrir();             
                var cmd = new SqlCommand("SP_BUSCARPROVEEDORES", conexion.conectarbd);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }
                    

                tablaMostrarProveedores.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarProveedores;
        }
        public void borrar()
        {

        }
        public DataTable BuscarProveedores()
        {
            var tablaBuscarProveedores = new DataTable();
            try
            {
                conexion.abrir();
                

                var cmd = new SqlCommand("SP_BUSQUEDAPROVEEDOR", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;               
                cmd.Parameters.AddWithValue("@NombreBuscado", nombrePro);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }

                tablaBuscarProveedores.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaBuscarProveedores;

        }

    }
}
