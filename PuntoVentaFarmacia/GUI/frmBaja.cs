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
    public partial class frmBaja : Form
    {
        public frmBaja()
        {
            InitializeComponent();
        }

        private void tmrFech_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }

        
        private void LimpiarAgregado()
        {
            nudLote.Value = 0;
            txtNombreProducto.Text = "";
            txtMotivo.Text = "";
        }
        private void LimpiarBusquda()
        {
            nudBusLote.Value = 0;
            cmbBusNombreProducto.Text = "";
            cmbBusTipoProducto.Text = "";
        }
        #region botones
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (nudLote.Value == 0)
            {
                errorProvider1.SetError(nudLote, "El campo no debe de quedar en 0");
                nudLote.Focus();
                return;
            }
            errorProvider1.SetError(nudLote, "0");

            if (txtNombreProducto.Text == "")
            {
                errorProvider1.SetError(txtNombreProducto, "El campo no debe de quedar vacio");
                txtNombreProducto.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreProducto, "");


            if (nudCantidad.Value == 0)
            {
                errorProvider1.SetError(nudCantidad, "El campo no debe de quedar en 0");
                nudCantidad.Focus();
                return;
            }
            errorProvider1.SetError(nudCantidad, "0");

            Regex reMotivo = new Regex("[A-Z]{3}[0-9]{2}[A-Z0-9]{1}[.]*", RegexOptions.Compiled);
            if (!reMotivo.IsMatch(txtMotivo.Text))
            {
                errorProvider1.SetError(txtMotivo, "Debe colocar el motivo por el cual se da de baja el producto");
                txtMotivo.Focus();
                return;
            }
            errorProvider1.SetError(txtMotivo, "");

            LimpiarAgregado();
            nudLote.Focus();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            LimpiarBusquda();
            nudBusLote.Focus();
        }
        #endregion
        #region keyPress
        private void cmbBusTipoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LimpiarBusquda();
            }
        }

        private void cmbBusNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LimpiarBusquda();
            }
        }

        private void nudBusLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LimpiarBusquda();
            }
        }
        private void txtMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                LimpiarAgregado();
            }
        }

        #endregion
    }
}
