using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class frmPantallaPrincipal : Form
    {
        public frmPantallaPrincipal()
        {
            InitializeComponent();
            abrirForm(new Bienvenida());
            mostrarMensajes();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizarV.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMaximizarV_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizarV.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            abrirForm(new Bienvenida());

        }

        private void btnAbMenu_Click(object sender, EventArgs e)
        {
            if(menVertical.Visible==false)
            {
                menVertical.Visible = true;
            }
            else if (menVertical.Visible == true)
            {
                menVertical.Visible = false;
            }


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLog log = new frmLog();
            log.Show();
            

        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (subMenuReportes.Visible == false)
            {
                subMenuReportes.Visible = true;
            }
            else if (subMenuReportes.Visible == true)
            {
                subMenuReportes.Visible = false;
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirForm(new Empleado());
            //if (opEmpleado.Visible == false)
            //{
            //    opEmpleado.Visible = true;
            //}
            //else if (opEmpleado.Visible == true)
            //{
            //    opEmpleado.Visible = false;
            //}
            //subMenuReportes.Visible = false;
        }

        private void btnAbMenu_MouseHover(object sender, EventArgs e)
        {
            
        }
        private void abrirForm(Object formHijo )
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fb= formHijo as Form;
            fb.TopLevel = false;
            fb.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fb);
            this.panelContenedor.Tag=fb;
            fb.Show();

        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            abrirForm(new Producto());

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirForm(new Cliente());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            abrirForm(new Compra());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirForm(new Venta());
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            abrirForm(new Devolucion());
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            abrirForm(new Baja());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLog log = new frmLog();
            log.Show();
        }
        public void mostrarMensajes()
        {
            this.ttpHelp.SetToolTip(this.btnAbMenu, "Preciona click para ocultar o mostrar el menu vertical");
            this.ttpHelp.SetToolTip(this.btnRegresar, "Preciona click para regresar");
            this.ttpHelp.SetToolTip(this.btnCerrar, "Preciona click para cerrar el programa");
            this.ttpHelp.SetToolTip(this.btnMinimizar, "Preciona click para minimizar la ventana");
            this.ttpHelp.SetToolTip(this.btnRestaurar, "Preciona click para restaurar la ventana");
            this.ttpHelp.SetToolTip(this.btnMaximizarV, "Preciona click para maximizar la ventana");
            this.ttpHelp.SetToolTip(this.btnLogo, "Preciona click para ir a la pantalla de inicio");
            this.ttpHelp.SetToolTip(this.btnProducto, "Preciona click para ir a la sección de productos");
            this.ttpHelp.SetToolTip(this.btnEmpleados, "Preciona click para ir a la sección de empleados");
            this.ttpHelp.SetToolTip(this.btnBajas, "Preciona click para ir a la sección de bajas de productos");
            this.ttpHelp.SetToolTip(this.btnClientes, "Preciona click para ir a la sección de clientes");
            this.ttpHelp.SetToolTip(this.btnCompras, "Preciona click para ir a la sección de compras de productos");
            this.ttpHelp.SetToolTip(this.btnVentas, "Preciona click para ir a la sección de ventas de productos");
            this.ttpHelp.SetToolTip(this.btnReporte, "Preciona click para ir a la sección de reportes");
            this.ttpHelp.SetToolTip(this.btnCerrarSesion, "Preciona click para cerrar sesión");
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmLog log = new frmLog();
            log.Show();
        }
    }
}
