using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Usuario
    {
        private D_Conexion conexion = new D_Conexion();
        public string alias { get; set; }
        public string correo { get; set; }
        public string contra { get; set; }
        public int stat { get; set; }
        public DateTime fechaCreacion { get; set; }
        public int idRol { get; set; }


        
         public DataTable validarUsuario()
        {
            var tablaValidacionUsuario = new DataTable();
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_VALIDARUSUARIO", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@alias", alias);
                cmd.Parameters.AddWithValue("@contra", contra);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaValidacionUsuario.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaValidacionUsuario;

        }

        public bool Insertar()
        {
            bool success = false;
            try
            {
                conexion.abrir();

                var cmd = new SqlCommand("SP_INSERTARUSUARIO", conexion.conectarbd);
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
        public bool actualizarUsuario()
        {
            bool success = false;
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_ACTUALIZARUSUARIO", conexion.conectarbd);
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
        public DataTable mostrarUsuario()
        {
            var tablaMostrarUsuario = new DataTable();
            try
            {
                conexion.abrir();
                var cmd = new SqlCommand("SP_BUSCARUSUARIO", conexion.conectarbd);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                {
                    reader.Close();
                    return null;
                }


                tablaMostrarUsuario.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaMostrarUsuario;
        }
        public void borrar()
        {

        }
        public DataTable BuscarUsuario()
        {
            var tablaBuscarUsuario = new DataTable();
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_BUSQUEDAUSUARIO", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@", );
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaBuscarUsuario.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaBuscarUsuario;

        }

    }
}
