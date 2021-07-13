using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;
using DAL;

namespace Business
{
    public class B_OperacionesProveedor
    {
        public D_Proveedor dProveedor = new D_Proveedor();

        public string insertarProveedor(string nombrePro, string telefono, string descripcion, int stat)
        {
            bool validing = ValidarDatosProveedor(nombrePro,telefono);
            string resultadoEjecucion = "";
            if(validing==true)
            {
                try
                {
                    dProveedor.nombrePro = nombrePro;
                    dProveedor.telefono = telefono;
                    dProveedor.descripcion = descripcion;
                    dProveedor.stat = stat;

                    dProveedor.Insertar();
                    resultadoEjecucion = "El proveedor se dio de alta correctamente";

                    return resultadoEjecucion;
                }
                catch (Exception)
                {
                    throw;
                }
                
            }
            else
            {
                resultadoEjecucion = "Error al validar los datos";
                return resultadoEjecucion;
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
        private bool ValidarDatosProveedor(string nombrePro, string telefono)
        {
            bool success = false;
            int totalValidados = 0;
            Regex reTexto = new Regex("^[a-zA-Z0-9_ ]*$", RegexOptions.Compiled);
            Regex reTelefono = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]", RegexOptions.Compiled);


            if (reTexto.IsMatch(nombrePro))
            {
                totalValidados ++;
            }
            if (reTelefono.IsMatch(telefono))
            {
                totalValidados ++;
            }

            if(totalValidados==2)
            {
                success = true;
            }

            return success;
        }
    }
}
