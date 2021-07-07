using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Cliente
    {
        private D_Conexion conexion = new D_Conexion();
        private D_Persona dPersona = new D_Persona();
        public int idPersonaC { get; set; }
        public string alias { get; set; }
        public int punAcum { get; set; }
        public bool stat { get; set; }
        public int idPersona { get; set; }

        public bool Insertar()
        {
            bool success = false;
            try
            {
                conexion.abrir();

                var cmd = new SqlCommand("SP_INSERTARCLIENTE", conexion.conectarbd);
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
        public bool actualizaRCliente()
        {
            bool success = false;
            try
            {
                conexion.abrir();
               

                var cmd = new SqlCommand("SP_ACTUALIZARCLIENTE", conexion.conectarbd);
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
        public DataTable mostrarCliente()
        {
            var tablaMostrarCliente = new DataTable();
            try
            {
                conexion.abrir();
                var cmd = new SqlCommand("SP_BUSCARCLIENTE", conexion.conectarbd);
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
        public void borrar()
        {

        }
        public DataTable BuscarCliente()
        {
            var tablaBuscarCliente = new DataTable();
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_BUSQUEDACLIENTE", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@", );
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaBuscarCliente.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaBuscarCliente;

        }
    }
}
