using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBienvenida : Form
    {
        
        
        public frmBienvenida()
        {
            InitializeComponent();
            
        }

        private void tmrFech_Tick(object sender, EventArgs e)
        {
            lblHora.Text ="Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text ="Fecha: "+ DateTime.Now.ToLongDateString();

           
        }
        

    }
}
