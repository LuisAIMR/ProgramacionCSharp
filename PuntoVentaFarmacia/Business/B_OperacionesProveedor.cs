using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Business
{
    public class B_OperacionesProveedor
    {
        public D_Proveedor dProveedor = new D_Proveedor();

        public string insertarProveedor(string nombrePro, string telefono, string descripcion, int stat)
        {
            try
            {
                dProveedor.nombrePro = nombrePro;
                dProveedor.telefono = telefono;
                dProveedor.descripcion = descripcion;
                dProveedor.stat = stat;

                dProveedor.Insertar();
                return "El proveedor se dio de alta correctamente";
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string actualizarProveedor(string nombrePro, string telefono, string descripcion, int idProveedor)
        {
            try
            {
                dProveedor.nombrePro = nombrePro;
                dProveedor.telefono = telefono;
                dProveedor.descripcion = descripcion;
                dProveedor.idProveedor = idProveedor;

                dProveedor.actualizarProveedor();
                return "El proveedor se actualizo correctamente";
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable BuscarProveedores(string nombrePro)
        {
            
            try
            {
                dProveedor.nombrePro = nombrePro;
                return dProveedor.BuscarProveedores();

            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public DataTable MostrarProveedores()
        {
            try
            {

                return dProveedor.mostrarProveedor();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

    }
}
