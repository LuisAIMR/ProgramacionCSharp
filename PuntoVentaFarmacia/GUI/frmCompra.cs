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
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        private void tmrFech_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }

        #region botones
        private void btnListoProveedor_Click(object sender, EventArgs e)
        {
            if (cmbNombreProveedor.Text == "")
            {
                errorProvider1.SetError(cmbNombre, "El campo no puede quedar vacio");
                cmbNombre.Focus();
                return;
            }
            errorProvider1.SetError(cmbNombre, "");

            if (cmbTelefono.Text == "")
            {
                errorProvider1.SetError(cmbTelefono, "El campo no puede quedar vacio");
                cmbTelefono.Focus();
                return;
            }
            errorProvider1.SetError(cmbTelefono, "");
            proveedorCompra();
        }
        private void btnCancelarProveedor_Click(object sender, EventArgs e)
        {
            liberarProveedorCompra();
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            if (nudLoteDeProducto.Value == 0)
            {
                errorProvider1.SetError(nudLoteDeProducto, "El campo no puede quedar vacio");
                nudLoteDeProducto.Focus();
                return;
            }
            errorProvider1.SetError(nudLoteDeProducto, "");

            if (cmbNombreProducto.Text == "")
            {
                errorProvider1.SetError(cmbNombreProducto, "El campo no puede quedar vacio");
                cmbNombreProducto.Focus();
                return;
            }
            errorProvider1.SetError(cmbNombreProducto, "");

            if (nudPrecio.Value == 0)
            {
                errorProvider1.SetError(nudPrecio, "El campo no puede quedar vacio");
                nudPrecio.Focus();
                return;
            }
            errorProvider1.SetError(nudPrecio, "");


            if (nudCantidad.Value == 0)
            {
                errorProvider1.SetError(nudCantidad, "El campo no puede quedar vacio");
                nudCantidad.Focus();
                return;
            }
            errorProvider1.SetError(nudCantidad, "");

            LimpiarProducto();
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            LimpiarProducto();
        }
        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            limpiezaFinal();
            liberarProveedorCompra();
        }
        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            limpiezaFinal();
            liberarProveedorCompra();
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            LimpiarBusqueda();
        }
        #endregion

        #region limpieza de controles
        private void LimpiarBusqueda()
        {
            nudBusLote.Value = 0;
            cmbNombreProveedor.Text = "";
            cmbUsuarioEmpleado.Text = "";
        }
        private void limpiezaFinal()
        {
            cmbNombre.Text = "";
            cmbTelefono.Text = "";
            txtDescripcionProveedor.Text = "";
            nudSubtotal.Value = 0;
            nudIva.Value = 0;
            NudTotal.Value = 0;
        }
        private void proveedorCompra()
        {
            cmbNombre.Enabled = false;
            cmbTelefono.Enabled = false;
            txtDescripcionProveedor.Enabled = false;
        }
        private void liberarProveedorCompra()
        {
            cmbNombre.Enabled = true;
            cmbTelefono.Enabled = true;
            txtDescripcionProveedor.Enabled = true;
        }
        private void LimpiarProducto()
        {
            nudLoteDeProducto.Value = 0;
            nudPrecio.Value = 0;
            cmbNombreProducto.Text = "";
            nudCantidad.Value = 0;
        }


        #endregion

       
    }
}
