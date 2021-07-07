using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Business
{
    public class B_OperacionesProductos
    {
        public D_Tipo dTipo = new D_Tipo();
        public D_Producto dProducto = new D_Producto();
        public D_Especial dEspecial = new D_Especial();
        public string insertarTipo(string nombre, int stat)
        {
            try
            {
                dTipo.nombreT = nombre;
                dTipo.stat = stat;

                dTipo.Insertar();
                return "El tipo de producto de dio de alta correctamente";
            }
            catch(Exception)
            {
                throw;
            }           
        }
        public DataTable cargarTipos()
        {
            try
            {
                return dTipo.leerTipo();

            }
            catch (Exception)
            {
                throw;
            }            
        }
        public string insertarProducto(string lote, string nombreP, string descripcion, float precio, int puntosCanejo, int cantidadP,int PuntosP, int stat, int idTipo)
        {
            try
            {
                dProducto.lote = lote;
                dProducto.nombreP = nombreP;
                dProducto.descripcion = descripcion;
                dProducto.precioP = precio;
                dProducto.puntosCanjeo = puntosCanejo;
                dProducto.cantidadP = cantidadP;
                dProducto.puntosP = PuntosP;
                dProducto.stat = stat;
                dProducto.idTipo = idTipo;
               

                dProducto.InsertarProductoForma1();
                return "El producto se dio de alta correctamente";
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string insertarProductoTipo2(string lote, string nombreP, string descripcion, float precio, int puntosCanejo, int cantidadP, int PuntosP, int stat, int idTipo, string fechaCad, int ReqReceta )
        {
            try
            {
                dProducto.lote = lote;
                dProducto.nombreP = nombreP;
                dProducto.descripcion = descripcion;
                dProducto.precioP = precio;
                dProducto.puntosCanjeo = puntosCanejo;
                dProducto.cantidadP = cantidadP;
                dProducto.puntosP = PuntosP;
                dProducto.stat = stat;
                dProducto.idTipo = idTipo;
                dEspecial.FechaCad = fechaCad;
                dEspecial.reqReceta = ReqReceta;               

                dProducto.InsertarForma2();
                return "El producto y su información extra se dieron de alta correctamente";
            }
            catch (Exception)
            {
                throw;
            }
        }
        //public string ActualizarProductos()
        //{
        //    try
        //    {
        //        dTipo.nombreT = nombre;
        //        dTipo.stat = stat;

        //        dTipo.Insertar();
        //        return "El tipo de producto de dio de alta correctamente";
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
      

    }

}
