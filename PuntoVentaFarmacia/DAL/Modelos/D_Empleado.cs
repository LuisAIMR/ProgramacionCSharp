using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Empleado
    {
        private D_Conexion conexion = new D_Conexion();
        private D_Persona dPersona = new D_Persona();
        private D_Usuario dUsuario = new D_Usuario();
        public int idPersonaE { get; set; }
        public byte imagenEmp { get; set; }
        public int stat { get; set; }
        public int idPuesto { get; set; }
        public int idUsuario { get; set; }
        public int idRol { get; set; }

        public bool Insertar()
        {
            bool success = false;
            try
            {
                conexion.abrir();

                var cmd = new SqlCommand("SP_INSERTAREMPLEADO", conexion.conectarbd);
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
        public bool actualizarEmpleado()
        {
            bool success = false;
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_ACTUALIZAREMPLEADO", conexion.conectarbd);
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
        public DataTable mostrarEmpleado()
        {
            var tablaMostrarEmpleado = new DataTable();
            try
            {
                conexion.abrir();
                var cmd = new SqlCommand("SP_BUSCAREMPLEADO", conexion.conectarbd);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }


                tablaMostrarEmpleado.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarEmpleado;
        }
        public void borrar()
        {

        }
        public DataTable BuscarEmpleado()
        {
            var tablaBuscarEmpleado = new DataTable();
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_BUSQUEDAEMPLEADO", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@", );
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaBuscarEmpleado.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaBuscarEmpleado;

        }
        public DataTable CargarDatosEmpleado()
        {
            var tablaDatosEmpleado = new DataTable();
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_MUESTRADATOSEMPLEADO", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@alias", dUsuario.alias);
                cmd.Parameters.AddWithValue("@contra", dUsuario.contra);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaDatosEmpleado.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaDatosEmpleado;

        }

    }
}
