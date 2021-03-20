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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            

            if (txtUsuario.Text == "ADMIN"   )
            {
                if(txtContrasena.Text == "ElAdmin")
                {
                    this.Hide();
                    frmPantallaPrincipal pantalla = new frmPantallaPrincipal();
                    pantalla.Show();
                    usuario = txtUsuario.Text;
                }
                else 
                {
                    MessageBox.Show("Contraseña no valida", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
            else
            {
                MessageBox.Show("Usuario no valido", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;
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

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMostarC_Click(object sender, EventArgs e)
        {
            txtContrasena.ForeColor = Color.White;
            txtContrasena.UseSystemPasswordChar = false;
            btnMostarC.Visible = false;
            btnOcultarC.Visible = true;
        }

        private void btnOcultarC_Click(object sender, EventArgs e)
        {
            txtContrasena.ForeColor = Color.White;
            txtContrasena.UseSystemPasswordChar = true;
            btnMostarC.Visible = true;
            btnOcultarC.Visible = false;
        }

        private void lklOlvidoContra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario:ADMIN \n" +
                "Contraseña:ElAdmin","LOGIN",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void mostrarMensajes()
        {
            this.ttpHelp.SetToolTip(this.txtUsuario, "Ingrese un usuario valido");
            this.ttpHelp.SetToolTip(this.txtContrasena, "Ingrese una contraseña valida");
            this.ttpHelp.SetToolTip(this.lklOlvidoContra, "Seleccione en caso de haber olvidado la contraseña");
            this.ttpHelp.SetToolTip(this.btnAcceder, "Preciona click para acceder");
            this.ttpHelp.SetToolTip(this.btnCerrar, "Preciona click cerrar el programa");
            this.ttpHelp.SetToolTip(this.btnMinimizar, "Preciona click minimizar la ventana");
            this.ttpHelp.SetToolTip(this.btnMostarC, "Preciona click para vizualizar la contraseña");
            this.ttpHelp.SetToolTip(this.btnOcultarC, "Preciona click para ocultar la contraseña");
        }

        
    }
}
