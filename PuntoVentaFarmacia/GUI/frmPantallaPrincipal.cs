﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;
using FontAwesome.Sharp;
using MaterialSkin;
using System.Data.SqlClient;
using Business;

namespace GUI
{
    public partial class frmPantallaPrincipal : Form
    {
        private B_OperacionesEmpleados BEmpleado = new B_OperacionesEmpleados();
        public frmPantallaPrincipal( int ID)
        {            
            InitializeComponent();
            abrirForm<frmBienvenida>();
            mostrarMensajes();
            cargarDatosEmpleado(ID);

            //Convert.ToInt32(lblIdEmpleado.Text);
        }
        
        private void frmPantallaPrincipal_Load(object sender, EventArgs e)
        {
            lblIdEmpleado.Text = dgvCargarDatosEmpleado.CurrentRow.Cells[0].Value.ToString();
            lblNombre.Text = dgvCargarDatosEmpleado.CurrentRow.Cells[1].Value.ToString();
            lblPuesto.Text = dgvCargarDatosEmpleado.CurrentRow.Cells[2].Value.ToString();               
            dgvCargarDatosEmpleado.Visible = false;
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
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }            
        }
        #endregion

        #region Menu Lateral 
        //Metodo para abrir formularios 

        public void abrirForm<Miform>() where Miform: Form,new()
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
            btnBajas.ForeColor = Color.White;

            btnProducto.BackColor = Color.FromArgb(26, 32, 40);
            btnClientes.BackColor = Color.FromArgb(26, 32, 40);
            btnEmpleados.BackColor = Color.FromArgb(26, 32, 40);
            btnCompras.BackColor = Color.FromArgb(26, 32, 40);
            btnVentas.BackColor = Color.FromArgb(26, 32, 40);
            btnReporte.BackColor = Color.FromArgb(26, 32, 40);
            btnHorarios.BackColor = Color.FromArgb(26, 32, 40);
            btnDevoluciones.BackColor = Color.FromArgb(26, 32, 40);
            btnProveedores.BackColor = Color.FromArgb(26, 32, 40);
            btnBajas.BackColor = Color.FromArgb(26, 32, 40);

            btnProducto.IconColor = Color.White;
            btnClientes.IconColor = Color.White;
            btnEmpleados.IconColor = Color.White;
            btnCompras.IconColor = Color.White;
            btnVentas.IconColor = Color.White;
            btnReporte.IconColor = Color.White;
            btnHorarios.IconColor = Color.White;
            btnDevoluciones.IconColor = Color.White;
            btnProveedores.IconColor = Color.White;
            btnBajas.IconColor = Color.White;
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
            btnBajas.Text = "";
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
            btnBajas.Text = "Bajas";
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
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirForm<frmCliente>();
            
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
           
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            abrirForm<frmCompra>();
           
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
            
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            abrirForm <frmVenta>();          
            SeguirBoton((FontAwesome.Sharp.IconButton)sender);
            seleccionarBoton((FontAwesome.Sharp.IconButton)sender);

            frmVenta f1 = Application.OpenForms.OfType<frmVenta>().SingleOrDefault();
            if (f1 != null)
            { 
                f1.lblIdEmpleadoVenta.Text = lblIdEmpleado.Text;
            }
            //IForm formInterface = this.Owner as IForm;

            //if (formInterface != null)
            //    formInterface.ChangeTextBoxText(lblIdEmpleado.Text);


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
        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            abrirForm<frmReportesVentas>();
        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            abrirForm<frmReportesCompras>();
        }

        private void btnReporteProductos_Click(object sender, EventArgs e)
        {
            abrirForm<frmReportesProveedores>();
        }

        private void btnReporteEmpleados_Click(object sender, EventArgs e)
        {
            abrirForm<frmReportesEmpleados>();
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            abrirForm<frmReportesClientes>();
        }
        #endregion

        #region Eventos key press
        private void btnVentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.N))            
            {
                abrirForm<frmVenta>();
                SeguirBoton((FontAwesome.Sharp.IconButton)sender);
                seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
            }
        }

        //private void btnProducto_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Shift) + Convert.ToChar(Keys.NumPad2))
        //    {
        //        abrirForm<frmProducto>();
        //        SeguirBoton((FontAwesome.Sharp.IconButton)sender);
        //        seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
        //    }
        //}

        //private void btnClientes_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Shift) + Convert.ToChar(Keys.NumPad3))
        //    {
        //        abrirForm<frmCliente>();

        //        SeguirBoton((FontAwesome.Sharp.IconButton)sender);
        //        seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
        //    }
        //}

        //private void btnEmpleados_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Shift) + Convert.ToChar(Keys.NumPad4))
        //    {
        //        abrirForm<frmEmpleado>();
        //        SeguirBoton((FontAwesome.Sharp.IconButton)sender);
        //        seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
        //    }
        //}

        //private void btnCompras_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Shift) + Convert.ToChar(Keys.NumPad5))
        //    {
        //        abrirForm<frmCompra>();

        //        SeguirBoton((FontAwesome.Sharp.IconButton)sender);
        //        seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
        //    }
        //}

        //private void btnReporte_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Shift) + Convert.ToChar(Keys.NumPad6))
        //    {
        //        mostrarSubmenu(pnlSubmenuReportes);
        //        SeguirBoton((FontAwesome.Sharp.IconButton)sender);
        //        seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
        //    }
        //}

        //private void btnHorarios_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Shift) + Convert.ToChar(Keys.NumPad7))
        //    {
        //        abrirForm<frmHorarios>();
        //        SeguirBoton((FontAwesome.Sharp.IconButton)sender);
        //        seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
        //    }
        //}

        //private void btnDevoluciones_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Shift) + Convert.ToChar(Keys.NumPad8))
        //    {
        //        abrirForm<frmDevolucion>();
        //        SeguirBoton((FontAwesome.Sharp.IconButton)sender);
        //        seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
        //    }
        //}

        //private void btnProveedores_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Shift) + Convert.ToChar(Keys.NumPad9))
        //    {
        //        abrirForm<frmProveedor>();
        //        SeguirBoton((FontAwesome.Sharp.IconButton)sender);
        //        seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
        //    }
        //}
        //private void btnBajas_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Shift) + Convert.ToChar(Keys.NumPad0))
        //    {
        //        abrirForm<frmBaja>();
        //        SeguirBoton((FontAwesome.Sharp.IconButton)sender);
        //        seleccionarBoton((FontAwesome.Sharp.IconButton)sender);
        //    }
        //}
        #endregion

        #region Otras acciones         

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
                frmLog log = new frmLog();
                log.Show();
            }

        }                
      
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
                frmLog log = new frmLog();
                log.Show();
            }
            
        }

        public void mostrarMensajes()
        {
            this.ttpHelp.SetToolTip(this.btnMenu, "Preciona click para ocultar o mostrar el menu vertical");            
            this.ttpHelp.SetToolTip(this.btnCerrar, "Preciona click para cerrar el programa");
            this.ttpHelp.SetToolTip(this.btnMinimizar, "Preciona click para minimizar la ventana");
            this.ttpHelp.SetToolTip(this.btnRestaurar, "Preciona click para restaurar la ventana");
            this.ttpHelp.SetToolTip(this.btnMaximizarV, "Preciona click para maximizar la ventana");
            this.ttpHelp.SetToolTip(this.btnLogo, "Preciona click para ir a la pantalla de inicio");       
            this.ttpHelp.SetToolTip(this.btnVentas, "Preciona click para ir a la sección de ventas de productos" + "\n" + "F1");
            this.ttpHelp.SetToolTip(this.btnProducto, "Preciona click para ir a la sección de productos" + "\n" + "F2");
            this.ttpHelp.SetToolTip(this.btnClientes, "Preciona click para ir a la sección de clientes" + "\n" + "F3");
            this.ttpHelp.SetToolTip(this.btnEmpleados, "Preciona click para ir a la sección de empleados" + "\n" + "F4");
            this.ttpHelp.SetToolTip(this.btnCompras, "Preciona click para ir a la sección de compras de productos" + "\n" + "F5");
            this.ttpHelp.SetToolTip(this.btnReporte, "Preciona click para ir a la sección de reportes" + "\n" + "F6");
            this.ttpHelp.SetToolTip(this.btnHorarios, "Preciona click para ir a la sección de Horarios" + "\n" + "F7");
            this.ttpHelp.SetToolTip(this.btnDevoluciones, "Preciona click para ir a la sección de Devoluciones" + "\n" + "F8");
            this.ttpHelp.SetToolTip(this.btnProveedores, "Preciona click para ir a la sección de Proveedores" + "\n" + "F9");
            this.ttpHelp.SetToolTip(this.btnBajas, "Preciona click para ir a la sección de Bajas" + "\n" + "F10");
            this.ttpHelp.SetToolTip(this.btnCerrarSesion, "Preciona click para cerrar sesión");
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                frmLog log = new frmLog();
                log.Show();
            }           
        }





        #endregion

        private void btnVentas_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        public void cargarDatosEmpleado( int idEmpleado)
        {
            dgvCargarDatosEmpleado.DataSource = BEmpleado.MostrarDatosEmpleado(idEmpleado);
            dgvCargarDatosEmpleado.Columns["idPersona"].Visible = false;
        }        
    }
}
