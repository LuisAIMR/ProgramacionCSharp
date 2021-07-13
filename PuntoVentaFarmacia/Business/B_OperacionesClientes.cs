using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace Business
{
    public class B_OperacionesClientes
    {
        private D_Persona dPersona = new D_Persona();
        private D_Cliente dCliente = new D_Cliente();

        public string insertarCliente(string nombre, string apPat, string apMat, DateTime fechaNac, string curp, string telefono, string alias, int punAcum ,int stat)
        {
            try
            {
                dCliente.dPersona.nombre = nombre;
                dCliente.dPersona.apPat = apPat;
                dCliente.dPersona.apMat = apMat;
                dCliente.dPersona.fechaNac = fechaNac;
                dCliente.dPersona.curp = curp;
                dCliente.dPersona.telefono = telefono;
                dCliente.alias = alias;
                dCliente.punAcum = punAcum;                                
                dCliente.stat = stat;

                dCliente.Insertar();
                return "El Cliente se dio de alta correctamente";
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string ActualizarCliente(int idPersona,string nombre, string apPat, string apMat, DateTime fechaNac, string curp, string telefono, string alias, int punAcum, int stat)
        {
            try
            {
                dCliente.dPersona.idPersona = idPersona;
                dCliente.dPersona.nombre = nombre;
                dCliente.dPersona.apPat = apPat;
                dCliente.dPersona.apMat = apMat;
                dCliente.dPersona.fechaNac = fechaNac;
                dCliente.dPersona.curp = curp;
                dCliente.dPersona.telefono = telefono;
                dCliente.alias = alias;
                dCliente.punAcum = punAcum;
                dCliente.stat = stat;

                dCliente.Actualizar();
                return "La actualización de la información del Cliente se realizo correctamente correctamente";
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable MostrarClientes()
        {
            try
            {

                return dCliente.mostrarClientes();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public DataTable BuscarClientes(string nombre, string apPat, string curp, string alias)
        {

            try
            {
                dCliente.dPersona.nombre = nombre;
                dCliente.dPersona.apPat = apPat;
                dCliente.dPersona.curp = curp;
                dCliente.alias = alias;
                return dCliente.BuscarCliente();

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
