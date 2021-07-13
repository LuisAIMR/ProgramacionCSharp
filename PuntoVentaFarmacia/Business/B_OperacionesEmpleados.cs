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
        private D_Empleado dEmpleado = new D_Empleado();
        public DataTable validarUsuario(string alias, string contra)
        {

            try
            {
                dEmpleado.dUsuario.alias = alias;
                dEmpleado.dUsuario.contra = contra;
                return dEmpleado.validarEmpleado();

            }
            catch (Exception)
            {
                throw;
            }

        }
        public DataTable MostrarDatosEmpleado(int idEmpleado)
        {

            try
            {
                dEmpleado.dPersona.idPersona = idEmpleado;
                return dEmpleado.CargarDatosEmpleado();

            }
            catch (Exception)
            {
                throw;
            }

        }
        public DataTable MostrarEmpleados()
        {
            try
            {

                return dEmpleado.mostrarEmpleados();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public DataTable MostrarTurnos()
        {
            try
            {

                return dEmpleado.mostrarTurnos();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public DataTable MostrarPuestos()
        {
            try
            {

                return dEmpleado.mostrarPuestos();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
