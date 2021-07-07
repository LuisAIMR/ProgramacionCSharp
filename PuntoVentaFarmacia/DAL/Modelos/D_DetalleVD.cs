using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_DetalleVD
    {
        public int idDevolucion { get; set; }
        public int idVenta { get; set; }

        public float precioVenta { get; set; }

        public int cantidad { get; set; }

        public float subtotal { get; set; }
    }
}
