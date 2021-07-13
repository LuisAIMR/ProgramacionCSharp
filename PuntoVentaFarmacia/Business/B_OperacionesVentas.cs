using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Business
{
    public class B_OperacionesVentas
    {
        private D_Venta dVenta = new D_Venta();  
        
        public DataTable MostrarClientes()
        {
            try
            {

                return dVenta.mostrarClientes();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public DataTable MostrarProductos()
        {
            try
            {

                return dVenta.mostrarProductos();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public DataTable MostrarVentaEnProceso()
        {
            try
            {

                return dVenta.mostrarVentaEnProceso();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public string insertarProductoUnoVenta(int idProducto,int cantidad,int idEmpleado,int idCliente)
        {
            try
            {
                dVenta.dProducto.idProducto = idProducto;
                dVenta.dDetalleVP.cantidad = cantidad;
                dVenta.dEmpleado.idPersonaE = idEmpleado;
                dVenta.dCliente.idPersonaC = idCliente;

                dVenta.InsertarPrimerProductoVenta();
                return "Se agrego un producto para venderse";
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string AñadirMasProducto(int idProducto, int cantidad, int idVenta)
        {
            try
            {
                dVenta.dProducto.idProducto = idProducto;
                dVenta.dDetalleVP.cantidad = cantidad;
                dVenta.idVenta = idVenta;
                dVenta.AñadirMasProducto();
                return "Se agrego otro un producto para venderse";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
