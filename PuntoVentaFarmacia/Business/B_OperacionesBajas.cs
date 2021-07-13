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
    public class B_OperacionesBajas
    {
        private D_Baja dBaja = new D_Baja();
        public DataTable MostrarBajas()
        {
            try
            {

                return dBaja.mostrarBajas();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
