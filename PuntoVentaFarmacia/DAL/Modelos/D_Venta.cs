using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Modelos
{
    class D_Venta
    {
        private D_Conexion conexion = new D_Conexion();
        public int idVenta { get; set; }
        public float subtotal { get; set; }
        public float iva { get; set; }
        public float total { get; set; }
        public string folio { get; set; }
        public DateTime fecha { get; set; }
        public int stat { get; set; }
        public int idPersonaE { get; set; }
        public int idPesonaC { get; set; }

        public bool Insertar()
        {
            bool success = false;
            try
            {
                conexion.abrir();

                var cmd = new SqlCommand("SP_INSERTARVENTA", conexion.conectarbd);
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
        public bool actualizarVenta()
        {
            bool success = false;
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_ACTUALIZARVENTA", conexion.conectarbd);
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
        public DataTable mostrarVenta()
        {
            var tablaMostrarVenta = new DataTable();
            try
            {
                conexion.abrir();
                var cmd = new SqlCommand("SP_BUSCARVENTA", conexion.conectarbd);
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
        public DataTable BuscarVenta()
        {
            var tablaBuscarVenta = new DataTable();
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_BUSQUEDAVENTA", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@", );
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaBuscarVenta.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaBuscarVenta;

        }
    }
}
