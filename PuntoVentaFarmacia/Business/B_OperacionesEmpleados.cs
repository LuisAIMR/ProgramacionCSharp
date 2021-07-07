using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Business
{
    public class B_OperacionesEmpleados
    {
        private D_Usuario dUsuario = new D_Usuario();
        private D_Empleado dEmpleado = new D_Empleado();
        public DataTable validarUsuario(string alias, string contra)
        {

            try
            {
                dUsuario.alias = alias;
                dUsuario.contra = contra;
                return dUsuario.validarUsuario();

            }
            catch (Exception)
            {
                throw;
            }

        }
        public DataTable MostrarDatosEmpleado(string alias, string contra)
        {

            try
            {
                dUsuario.alias = alias;
                dUsuario.contra = contra;
                return dEmpleado.CargarDatosEmpleado();

            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
