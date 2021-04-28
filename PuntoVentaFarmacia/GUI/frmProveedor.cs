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
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        private void tmrFech_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }

        #region botones

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            Regex reNombre = new Regex("^[a-zA-Z]*$", RegexOptions.Compiled);
            if (!reNombre.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Debe colocar un nombre valido");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            Regex reTelefono = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]", RegexOptions.Compiled);
            if (!reTelefono.IsMatch(txtTelefono.Text))
            {
                errorProvider1.SetError(txtTelefono, "Debe colocar un telefono valido");
                txtTelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            if (txtDescripcion.Text == "")
            {
                errorProvider1.SetError(txtDescripcion, "No debe de dejar el campo nulo");
                txtDescripcion.Focus();
                return;
            }
            errorProvider1.SetError(txtDescripcion, "");
            limpiarAgregado();
        }

        #endregion

        #region limpieza de controles
        private void limpiarAgregado()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDescripcion.Text = "";
        }
        #endregion region 

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            cmbBusProveedor.Text = "";
        }
    }
}
