using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_Tipo
    {
        private  D_Conexion conexion= new D_Conexion();
        public int idTipo { get; set; }
        public string nombreT { get; set; }

        public int stat { get; set; }


        public bool Insertar()
        {
            bool success = false;
            try
            {
                conexion.abrir();               
             var cmd = new SqlCommand("SP_INSERTARTIPO", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreTipo",nombreT );
                cmd.Parameters.AddWithValue("@stat", stat);
                var resultado = cmd.ExecuteNonQuery();

                    if (resultado == 1)
                        success = true;

                conexion.cerrar();
            }
            catch(Exception)
            {
                throw;
            }
            return success;
        }
        public void actualizar()
        {

        }
        public void mostrar()
        {

        }
        public void borrar()
        {

        }
        public DataTable leerTipo()
        {
            var tablaTiposProductos = new DataTable();
            try
            {
                conexion.abrir();
                string sql = "Select idTipo, nombreT from Tipo ";
                
                var cmd = new SqlCommand(sql, conexion.conectarbd);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaTiposProductos.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaTiposProductos;

        } 
    }
}
