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
    public partial class frmLog : Form
    {
        public string usuario = "";
        public frmLog()
        {
            InitializeComponent();
            mostrarMensajes();
        }
        #region movimiento de ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pbxlogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region tamaño de ventana
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region controles de acceso y registro de usuario
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "ADMIN")
            {
                if (txtContrasena.Text == "ElAdmin")
                {                    
                    this.Hide();
                    frmPantallaPrincipal pantalla = new frmPantallaPrincipal();
                    pantalla.Show();
                    pbxContra.IconColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Contraseña no valida", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pbxContra.IconColor = Color.Red;
                }
                pbxUser.IconColor = Color.Green;

            }
            else
            {
                MessageBox.Show("Usuario no valido", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbxUser.IconColor = Color.Red;
            }
        }

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            pnlDeAcceso.Visible = false;
            pnlRegistro.Visible = true;

        }
        private void btnRegistrarNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (iconContrasena.IconColor == Color.Green)
            {
                pnlDeAcceso.Visible = true;
                pnlRegistro.Visible = false;
            }

        }
        private void lklOlvidoContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Usuario:ADMIN \n" +
                "Contraseña:ElAdmin", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region funciones extra

        //Mostrar contraseña o ocultarla       
        private void btnMostarC_Click(object sender, EventArgs e)
        {
            txtContrasena.ForeColor = Color.White;
            txtContrasena.UseSystemPasswordChar = false;
            btnMostarC.Visible = false;
            btnOcultarC.Visible = true;
        }

        private void btnOcultarC_Click(object sender, EventArgs e)
        {
            txtContrasena.ForeColor = Color.Gray;
            if (txtContrasena.Text != "CONTRASEÑA")
                txtContrasena.UseSystemPasswordChar = true;
            btnMostarC.Visible = true;
            btnOcultarC.Visible = false;
        }        
        
        //Mensajes de ayuda al usuario
        public void mostrarMensajes()
        {
            this.ttpHelp.SetToolTip(this.txtUsuario, "Ingrese un usuario valido");
            this.ttpHelp.SetToolTip(this.txtContrasena, "Ingrese una contraseña valida");
            this.ttpHelp.SetToolTip(this.lklOlvidoContra, "Seleccione en caso de haber olvidado la contraseña");
            this.ttpHelp.SetToolTip(this.btnAcceder, "Preciona click para acceder");
            this.ttpHelp.SetToolTip(this.btnMostarC, "Preciona click para vizualizar la contraseña");
            this.ttpHelp.SetToolTip(this.btnOcultarC, "Preciona click para ocultar la contraseña");
            this.ttpHelp.SetToolTip(this.btnCerrar, "Preciona click cerrar el programa");
            this.ttpHelp.SetToolTip(this.btnMinimizar, "Preciona click minimizar la ventana");
        }

        #endregion        

        #region metodos
        public void abrirForm<Miform>() where Miform : Form, new()
        {
            pnlDeAcceso.Visible = false;
            Form formulario=null;
            formulario = pnlContenedor.Controls.OfType<Miform>().FirstOrDefault();

            if (formulario == null)
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
        private void comparacionContrasenaR()            
        {            

            if(txtContrasenaRegistrada.Text == txtConfirmarContra.Text)
            {
                iconContrasena.IconColor = Color.Green;
                
            }
            else if(txtConfirmarContra.Text == "CONTRASEÑA" & txtContrasenaRegistrada.Text == "CONFIRMAR CONTRASEÑA" )
            {
                iconContrasena.IconColor = Color.White;
                
            }
            else if (txtConfirmarContra.Text == "" & txtContrasenaRegistrada.Text == "")
            {
                iconContrasena.IconColor = Color.White;                ;
            }
            else if(txtConfirmarContra.Text != txtContrasenaRegistrada.Text)
            {                     
                MessageBox.Show("Las contraseñas no coinciden", "LOGIN",MessageBoxButtons.OK, MessageBoxIcon.Error);
                iconContrasena.IconColor = Color.Red;
            }
            
            


        }


        #endregion

        
        #region enter y leave
        //enter
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }       
        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.White;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }
        
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.White;
                
            }
        }

        private void txtApPaterno_Enter(object sender, EventArgs e)
        {
            if (txtApPaterno.Text == "APELLIDO PATERNO")
            {
                txtApPaterno.Text = "";
                txtApPaterno.ForeColor = Color.White;
                
            }
        }

        private void txtApMaterno_Enter(object sender, EventArgs e)
        {
            if (txtApMaterno.Text == "APELLIDO MATERNO")
            {
                txtApMaterno.Text = "";
                txtApMaterno.ForeColor = Color.White;
                
            }
        }

        private void txtUsuarioRegistrado_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioRegistrado.Text == "USUARIO")
            {
                txtUsuarioRegistrado.Text = "";
                txtUsuarioRegistrado.ForeColor = Color.White;

            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "CORREO")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.White;

            }
        }

        private void txtContraseñaRegistrada_Enter(object sender, EventArgs e)
        {
            if (txtContrasenaRegistrada.Text == "CONTRASEÑA")
            {
                txtContrasenaRegistrada.Text = "";
                txtContrasenaRegistrada.ForeColor = Color.White;
                txtContrasenaRegistrada.UseSystemPasswordChar = false;

            }
        }

        private void txtConfirmarContra_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarContra.Text == "CONFIRMAR CONTRASEÑA")
            {
                txtConfirmarContra.Text = "";
                txtConfirmarContra.ForeColor = Color.White;
                txtConfirmarContra.UseSystemPasswordChar = false;
            }
        }
        //leave
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }
        private void txtNombre_Leave(object sender, EventArgs e)
        {

            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
                txtNombre.ForeColor = Color.Gray;
            }
        }

        private void txtApPaterno_Leave(object sender, EventArgs e)
        {
            if (txtApPaterno.Text == "")
            {
                txtApPaterno.Text = "APELLIDO PATERNO";
                txtApPaterno.ForeColor = Color.Gray;
            }
        }

        private void txtApMaterno_Leave(object sender, EventArgs e)
        {
            if (txtApMaterno.Text == "")
            {
                txtApMaterno.Text = "APELLIDO MATERNO";
                txtApMaterno.ForeColor = Color.Gray;
            }
        }

        private void txtUsuarioRegistrado_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioRegistrado.Text == "")
            {
                txtUsuarioRegistrado.Text = "USUARIO";
                txtUsuarioRegistrado.ForeColor = Color.Gray;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "CORREO";
                txtCorreo.ForeColor = Color.Gray;
            }
        }

        private void txtContraseñaRegistrada_Leave(object sender, EventArgs e)
        {
            if (txtContrasenaRegistrada.Text == "")
            {
                txtContrasenaRegistrada.Text = "CONTRASEÑA";
                txtContrasenaRegistrada.ForeColor = Color.Gray;
                txtContrasenaRegistrada.UseSystemPasswordChar = false;
            }
            else
            {                
                txtConfirmarContra.Focus();
            }
        }

        private void txtConfirmarContra_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarContra.Text == "")
            {
                txtConfirmarContra.Text = "CONFIRMAR CONTRASEÑA";
                txtConfirmarContra.ForeColor = Color.Gray;
                txtConfirmarContra.UseSystemPasswordChar = false;
            }
            else
            {
                
                btnRegistrarNuevoUsuario.Focus();
            }

            if(txtConfirmarContra.Text != "CONFIRMAR CONTRASEÑA"& txtConfirmarContra.Text != " ")
            {                               
                comparacionContrasenaR();               
            }
           
        }
        #endregion

        
    }
}
