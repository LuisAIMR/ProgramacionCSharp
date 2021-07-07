using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class D_Producto
    {
        private D_Conexion conexion = new D_Conexion();
        private D_Especial dEspecial = new D_Especial();
        public int idProducto { get; set; }
        public string lote { get; set; }
        public string nombreP { get; set; }
        public string descripcion { get; set; }
        public float precioP { get; set; }
        public int puntosCanjeo{ get; set; }
        public int cantidadP { get; set; }
        public int puntosP { get; set; }
        public int stat { get; set; }
        public int idTipo { get; set; }

        public bool InsertarProductoForma1()
        {
            bool success = false;
            try
            {
                conexion.abrir();
               

                var cmd = new SqlCommand("SP_INSERTARPRODUCTO1", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Lote", lote);
                cmd.Parameters.AddWithValue("@NombreP", nombreP);
                cmd.Parameters.AddWithValue("@DescripcionP", descripcion);
                cmd.Parameters.AddWithValue("@Precio", precioP);
                cmd.Parameters.AddWithValue("@PuntosCanjeo", puntosCanjeo);
                cmd.Parameters.AddWithValue("@CantidadP", cantidadP);
                cmd.Parameters.AddWithValue("@Puntos", puntosP);
                cmd.Parameters.AddWithValue("@stat", stat);
                cmd.Parameters.AddWithValue("@IdTipo", idTipo);
                
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
        public bool InsertarForma2()
        {
            bool success = false;
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_INSERTARPRODUCTO2", conexion.conectarbd);
                cmd.Parameters.AddWithValue("@Lote", lote);
                cmd.Parameters.AddWithValue("@NombreP", nombreP);
                cmd.Parameters.AddWithValue("@DescripcionP", descripcion);
                cmd.Parameters.AddWithValue("@Precio", precioP);
                cmd.Parameters.AddWithValue("@PuntosCanjeo", puntosCanjeo);
                cmd.Parameters.AddWithValue("@CantidadP", cantidadP);
                cmd.Parameters.AddWithValue("@Puntos", puntosP);
                cmd.Parameters.AddWithValue("@stat", stat);
                cmd.Parameters.AddWithValue("@IdTipo", idTipo);
                cmd.Parameters.AddWithValue("@fechaCad", dEspecial.FechaCad);
                cmd.Parameters.AddWithValue("@ReqReceta", dEspecial.reqReceta);
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
        //public bool actualizarProducto()
        //{
        //    bool success = false;
        //    try
        //    {
        //        conexion.abrir();
        //        //string sql = "UPDATE Proveedor SET nombrePro='" + nombrePro + "',telefono='" + telefono;
        //        //       sql   += "',descripcion='" + descripcion + "' where idProveedor=" + idProveedor.ToString() ;

        //        var cmd = new SqlCommand("SP_ACTUALIZARPRODUCTO", conexion.conectarbd);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@id", idProveedor);
        //        cmd.Parameters.AddWithValue("@NombreProveedor", nombrePro);
        //        cmd.Parameters.AddWithValue("@Telefono", telefono);
        //        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
        //        var resultado = cmd.ExecuteNonQuery();

        //        if (resultado == 1)
        //            success = true;

        //        conexion.cerrar();
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return success;
        //}

        public DataTable BuscarProducto()
        {
            var tablaBuscarProducto = new DataTable();
            try
            {
                conexion.abrir();


                var cmd = new SqlCommand("SP_BUSQUEDAPRODUCTO", conexion.conectarbd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreBuscado", nombreP);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaBuscarProducto.Load(reader);
                conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaBuscarProducto;

        }
        public DataTable mostrarProductos()
        {
            var tablaMostrarProveedores = new DataTable();
            try
            {
                conexion.abrir();
                var cmd = new SqlCommand("SP_MOSTRARPRODUCTOS", conexion.conectarbd);
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
    }
}
