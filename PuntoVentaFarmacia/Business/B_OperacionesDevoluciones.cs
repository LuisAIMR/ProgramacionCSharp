using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Business
{
    public class B_OperacionesDevoluciones
    {
        private D_Devolucion dDevolucion = new D_Devolucion();

        public DataTable MostrarDevoluciones()
        {
            try
            {

                return dDevolucion.mostrarDevoluciones();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
