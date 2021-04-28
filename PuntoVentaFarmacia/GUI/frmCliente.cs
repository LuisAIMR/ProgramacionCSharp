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

namespace GUI
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void tmrFech_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
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

            Regex reAlias = new Regex("[A-Z]{3}[0-9]{2}[A-Z0-9]{1}[.]*", RegexOptions.Compiled);
            if (!reAlias.IsMatch(txtAlias.Text))
            {
                errorProvider1.SetError(txtAlias, "Debe colocar un alias valido");
                txtAlias.Focus();
                return;
            }
            errorProvider1.SetError(txtAlias, "");
            limpiarAgregado();


        }

        private void limpiarAgregado()
        {
            txtNombre.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            txtCurp.Text = "";
            txtTelefono.Text = "";
            txtAlias.Text = "";
        }
        private void limpiarBusqueda()
        {
            txtBusNombreCliente.Text = "";
            txtBusApPaterno.Text = "";
            txtBusAlias.Text = "";
            txtBusCurp.Text = "";
        }
        private void txtAlias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
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

                Regex reAlias = new Regex("[A-Z]{3}[0-9]{2}[A-Z0-9]{1}[.]*", RegexOptions.Compiled);
                if (!reAlias.IsMatch(txtAlias.Text))
                {
                    errorProvider1.SetError(txtAlias, "Debe colocar un alias valido");
                    txtAlias.Focus();
                    return;
                }
                errorProvider1.SetError(txtAlias, "");
                limpiarAgregado();

            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            limpiarBusqueda();
        }
    }
}
