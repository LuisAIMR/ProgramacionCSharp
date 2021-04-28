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
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void tmrFech_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }
        #region botones
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbNombre.Text == "")
            {
                errorProvider1.SetError(cmbNombre, "El campo no puede quedar vacio");
                cmbNombre.Focus();
                return;
            }
            errorProvider1.SetError(cmbNombre, "");

            if (cmbApPaterno.Text == "")
            {
                errorProvider1.SetError(cmbApPaterno, "El campo no puede quedar vacio");
                cmbApPaterno.Focus();
                return;
            }
            errorProvider1.SetError(cmbApPaterno, "");
            if (cmbApMaterno.Text == "")
            {
                errorProvider1.SetError(cmbApMaterno, "El campo no puede quedar vacio");
                cmbApMaterno.Focus();
                return;
            }
            errorProvider1.SetError(cmbApMaterno, "");

            if (cmbAlias.Text == "")
            {
                errorProvider1.SetError(cmbAlias, "El campo no puede quedar vacio");
                cmbAlias.Focus();
                return;
            }
            errorProvider1.SetError(cmbAlias, "");

            if (cmbNombreProducto.Text == "")
            {
                errorProvider1.SetError(cmbNombreProducto, "El campo no puede quedar vacio");
                cmbNombreProducto.Focus();
                return;
            }
            errorProvider1.SetError(cmbNombreProducto, "");

            if (nudCantidad.Value==0)
            {
                errorProvider1.SetError(nudCantidad, "El campo no puede quedar vacio");
                nudCantidad.Focus();
                return;
            }
            errorProvider1.SetError(nudCantidad, "");
            

            limpiarProducto();
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            limpiarProducto();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            LimpiarVenta();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LimpiarVenta();
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            limpiarBubsqueda();
        }
        #endregion

        #region limpieza de controles

        private void limpiarCliente()
        {
            cmbNombre.Text = "";
            cmbApPaterno.Text = "";
            cmbApMaterno.Text = "";
            cmbAlias.Text = "";
        }

        private void limpiarProducto()
        {
            cmbNombreProducto.Text = "";
            nudCantidad.Value = 0;
            nudPrecio.Value = 0;
            nudPuntosParaCanjeo.Value = 0;
        }

        private void LimpiarVenta()
        {
            nudSubtotal.Value = 0;
            nudIva.Value = 0;
            nudTotal.Value = 0;
            limpiarCliente();

        }

        private void limpiarBubsqueda()
        {
            nudBusFolio.Value = 0;
            cmbNombreCliente.Text = "";
            cmbBusUsuarioEmpleado.Text = "";
        }

        #endregion
    }
}
