using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Business;

namespace GUI
{
    public partial class frmEmpleado : Form
    {
        private B_OperacionesEmpleados BEmpleado = new B_OperacionesEmpleados();
        public frmEmpleado()
        {
            InitializeComponent();
            cargarEmpleados();
            colorDataGridview();
        }

        private void tmrFech_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }

        #region botones
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Regex reNombre = new Regex("^[a-zA-Z]*$", RegexOptions.Compiled);
            if (!reNombre.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Debe colocar un nombre valido");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            Regex reApellido = new Regex("^[a-zA-Z]*$", RegexOptions.Compiled);
            if (!reApellido.IsMatch(txtApPaterno.Text))
            {
                errorProvider1.SetError(txtApPaterno, "Debe colocar un apellido valido");
                txtApPaterno.Focus();
                return;
            }
            errorProvider1.SetError(txtApPaterno, "");

            if (!reApellido.IsMatch(txtApMaterno.Text))
            {
                errorProvider1.SetError(txtApMaterno, "Debe colocar un apellido valido");
                txtApMaterno.Focus();
                return;
            }
            errorProvider1.SetError(txtApMaterno, "");

            Regex reCurp = new Regex("^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$", RegexOptions.Compiled);
            if (!reCurp.IsMatch(txtCurp.Text))
            {
                errorProvider1.SetError(txtCurp, "Debe colocar una curp  valida");
                txtCurp.Focus();
                return;
            }
            errorProvider1.SetError(txtCurp, "");

            Regex reTelefono = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]", RegexOptions.Compiled);
            if (!reTelefono.IsMatch(txtTelefono.Text))
            {
                errorProvider1.SetError(txtTelefono, "Debe colocar un telefono valido");
                txtTelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            Regex reUsuario = new Regex("[A-Z]{3}[0-9]{2}[A-Z0-9]{1}[.]*", RegexOptions.Compiled);
            if (!reUsuario.IsMatch(txtUsuarioRegistrado.Text))
            {
                errorProvider1.SetError(txtUsuarioRegistrado, "Debe colocar un nombre de usuario valido");
                txtUsuarioRegistrado.Focus();
                return;
            }
            errorProvider1.SetError(txtUsuarioRegistrado, "");

            Regex reEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                    + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                    + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                    + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                    + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!reEmail.IsMatch(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Debe colocar una una direccion de correo valida");
                txtCorreo.Focus();
                return;
            }
            errorProvider1.SetError(txtCorreo, "");

            if (txtContrasenaRegistrada.Text != txtConfirmarContra.Text)
            {
                errorProvider1.SetError(txtConfirmarContra, "Las contraseñas no coinciden");
                txtConfirmarContra.Focus();
                return;
            }
            errorProvider1.SetError(txtConfirmarContra, "");

            LimpiarValidacion();
        }
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            LimpiarBusqueda();
        }
        #endregion

        #region limpieza de controles
        private void LimpiarValidacion()
        {
            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            txtCurp.Text = "";
            txtTelefono.Text = "";
            txtUsuarioRegistrado.Text = "";
            txtCorreo.Text = "";
            txtContrasenaRegistrada.Text = "";
            txtConfirmarContra.Text = "";
        }
        private void LimpiarBusqueda()
        {
            txtBusNombreEmpleado.Text = "";
            txtBusApellidoPerno.Text = "";
            txtBusNombreUsuario.Text = "";
            txtBusCurp.Text = "";
        }

        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void cargarEmpleados()
        {
            dgvBusquedaEmpleados.DataSource = BEmpleado.MostrarEmpleados();
           // dgvBusquedaEmpleados.Columns["idProveedor"].Visible = false;
        }
        public void colorDataGridview()
        {
            dgvBusquedaEmpleados.ForeColor = Color.FromArgb(5, 15, 40);
        }
    }
}
