using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_DetalleCP
    {
        public int idProducto { get; set; }
        public int idCompra { get; set; }        
        public int cantidad { get; set; }
        public float precioCompra { get; set; }

        public int idProductoFK { get; set; }
        public int idCompraFK { get; set; }

        public void insertar()
        {

        }

        public void mostrar()
        {

        }
        public void borrar()
        {

        }
        public void actualizar()
        {

        }
    }
}
