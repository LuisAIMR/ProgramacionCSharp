using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class D_Conexion
    {
        private readonly string cadenaConexion = "Data Source=LAPTOP-5TMMPCQ2\\SQLEXPRESS;Initial Catalog=dbFarmaciaE;Integrated Security=True";

        
        public SqlConnection conectarbd = new SqlConnection();

        //constructor
        public D_Conexion()
        {
            conectarbd.ConnectionString = cadenaConexion;
        }
        //metodo abrir
        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la DB: " + ex.Message);
            }
        }
        //metodo cerrar

        public void cerrar()
        {
            conectarbd.Close();
        }
    }
}
