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
using FontAwesome.Sharp;
using MaterialSkin;

namespace GUI
{
    public partial class frmPantallaPrincipal : Form
    {
        public frmPantallaPrincipal()
        {
            InitializeComponent();
            abrirForm<frmBienvenida>();
            mostrarMensajes();
        }
        #region usos libreria System.Runtime.InteropServices;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Controles de tamaño de ventanas
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
        #endregion

        #region Menu Lateral 
        //Metodo para abrir formularios 

        private void abrirForm<Miform>() where Miform: Form,new()
        {
            Form formulario;
            formulario = pnlContenedor.Controls.OfType<Miform>().FirstOrDefault();

            if(formulario==null)
            {
                formulario = new Miform();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                pnlContenedor.Controls.Add(formulario);
                pnlContenedor.Tag = formulario;
                this.DoubleBuffered = true;
                formulario.Show();
                formulario.BringToFront();
            }
            else 
            {
                formulario.BringToFront();
            }

        }

        //Metodo para mostrar que boton esta seleccionado
        public void SeguirBoton(FontAwesome.Sharp.IconButton sender)
        {
            pnlSeleccionador.Top = sender.Top;
            pnlSeleccionador.Visible = true;
        }
        //Seleccionador de botones
        public void seleccionarBoton(FontAwesome.Sharp.IconButton sender)
        {

            restaurarBotones();
            bool aux = true;
            if (aux == true)
            {
                sender.ForeColor = Color.FromArgb(15, 15, 40);
                sender.BackColor = Color.SlateBlue;
                sender.IconColor = Color.FromArgb(15, 15, 40);
            }
            aux = false;
        }

        //Revierte lo valores predeterminados a los botones del panel 
        private void restaurarBotones()
        {
            btnProducto.ForeColor = Color.White;
            btnClientes.ForeColor = Color.White;
            btnEmpleados.ForeColor = Color.White;
            btnCompras.ForeColor = Color.White;
            btnVentas.ForeColor = Color.White;
            btnReporte.ForeColor = Color.White;
            btnHorarios.ForeColor = Color.White;
            btnDevoluciones.ForeColor = Color.White;
            btnProveedores.ForeColor = Color.White;

            btnProducto.BackColor = Color.FromArgb(26, 32, 40);
            btnClientes.BackColor = Color.FromArgb(26, 32, 40);
            btnEmpleados.BackColor = Color.FromArgb(26, 32, 40);
            btnCompras.BackColor = Color.FromArgb(26, 32, 40);
            btnVentas.BackColor = Color.FromArgb(26, 32, 40);
            btnReporte.BackColor = Color.FromArgb(26, 32, 40);
            btnHorarios.BackColor = Color.FromArgb(26, 32, 40);
            btnDevoluciones.BackColor = Color.FromArgb(26, 32, 40);
            btnProveedores.BackColor = Color.FromArgb(26, 32, 40);


            btnProducto.IconColor = Color.White;
            btnClientes.IconColor = Color.White;
            btnEmpleados.IconColor = Color.White;
            btnCompras.IconColor = Color.White;
            btnVentas.IconColor = Color.White;
            btnReporte.IconColor = Color.White;
            btnHorarios.IconColor = Color.White;
            btnDevoluciones.IconColor = Color.White;
            btnProveedores.IconColor = Color.White;
        }
        private void ocultarTexto()
        {            
            btnProducto.Text ="";
            btnClientes.Text = "";
            btnEmpleados.Text = "";
            btnCompras.Text = "";
            btnVentas.Text = "";
            btnReporte.Text = "";
            btnHorarios.Text = "";
            btnDevoluciones.Text = "";
            btnProveedores.Text = "";
        }
        private void verTexto()
        {
            btnProducto.Text = "productos";
            btnClientes.Text = "Clientes";
            btnEmpleados.Text = "Empleados";
            btnCompras.Text = "Compras";
            btnVentas.Text = "Ventas";
            btnReporte.Text = "Reportes";
            btnHorarios.Text = "Horarios";
            btnDevoluciones.Text = "Devoluciones";
            btnProveedores.Text = "Proveedores";
        }
        private void reducirMenuVertical()
        {
            pnlMenVertical.Width = 46;
            ocultarTexto();
            btnMenu.Location = new Point(0, 40);
            btnMenu.Size = new Size(46, 46);
        }
        private void restaurarMenuVertical()
        {
            pnlMenVertical.Width = 220;
            verTexto();
            btnMenu.Location = new Point(180, 0);
            btnMenu.Size = new Size(40, 40);
        }
        //desplegar menu y minimizar menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenVertical.Width == 220)
            {
                reducirMenuVertical();
                ocultarSubmenus();
            }
            else
            {
                restaurarMenuVertical();
            }
        }
        private void ocultarSubmenus()
        {
            if (pnlSubmenuProductos.Visible == true)
                pnlSubmenuProductos.Visible = false;

            if (pnlSubmenuVentas.Visible == true)
                pnlSubmenuVentas.Visible = false;

            if (pnlSubmenuClientes.Visible == true)
                pnlSubmenuClientes.Visible = false;

            if (pnlSubmenuEmpleados.Visible == true)
                pnlSubmenuEmpleados.Visible = false;

            if (pnlSubmenuCompras.Visible == true)
                pnlSubmenuCompras.Visible = false;

            if (pnlSubmenuReportes.Visible == true)
                pnlSubmenuReportes.Visible = false;

        }

        //Submenu
        private void mostrarSubmenu(Panel submenu)
        {
            if(submenu.Visible==false)
            {
                ocultarSubmenus();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        //Uso de botones\\
        private void btnLogo_Click(object sender, EventArgs e)
        {
            abrirForm<frmBienvenida>();
            

        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            abrirForm<frmProducto>();
            mostrarSubmenu(pnlSubmenuProductos);
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirForm<frmCliente>();
            mostrarSubmenu(pnlSubmenuClientes);
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
           
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            abrirForm<frmCompra>();
            mostrarSubmenu(pnlSubmenuCompras);
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
            
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirForm<frmVenta>();
            mostrarSubmenu(pnlSubmenuVentas);
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
           
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            abrirForm<frmDevolucion>();
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
            //mostrarSubmenu(pnlSubmenuDevoluciones);
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            abrirForm<frmBaja>();
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
            //mostrarSubmenu(pnlSubmenuBajas);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlSubmenuReportes);
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
            
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirForm<frmEmpleado>();
            mostrarSubmenu(pnlSubmenuEmpleados);
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
            
        }
        private void btnHorarios_Click(object sender, EventArgs e)
        {
            abrirForm<frmHorarios>();            
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            abrirForm<frmDevolucion>();
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
        }
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            abrirForm<frmProveedor>();
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
        }

        #endregion

        #region Otras acciones         

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLog log = new frmLog();
            log.Show();
            

        }                
      
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLog log = new frmLog();
            log.Show();
        }

        public void mostrarMensajes()
        {
            this.ttpHelp.SetToolTip(this.btnMenu, "Preciona click para ocultar o mostrar el menu vertical");
            this.ttpHelp.SetToolTip(this.btnRegresar, "Preciona click para regresar");
            this.ttpHelp.SetToolTip(this.btnCerrar, "Preciona click para cerrar el programa");
            this.ttpHelp.SetToolTip(this.btnMinimizar, "Preciona click para minimizar la ventana");
            this.ttpHelp.SetToolTip(this.btnRestaurar, "Preciona click para restaurar la ventana");
            this.ttpHelp.SetToolTip(this.btnMaximizarV, "Preciona click para maximizar la ventana");
            this.ttpHelp.SetToolTip(this.btnLogo, "Preciona click para ir a la pantalla de inicio");
            this.ttpHelp.SetToolTip(this.btnProducto, "Preciona click para ir a la sección de productos");
            this.ttpHelp.SetToolTip(this.btnEmpleados, "Preciona click para ir a la sección de empleados");
            this.ttpHelp.SetToolTip(this.btnHorarios, "Preciona click para ir a la sección de Horarios");
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


        #endregion
       
    }
}
