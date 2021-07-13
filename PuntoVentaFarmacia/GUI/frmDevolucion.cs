using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace GUI
{
    public partial class frmDevolucion : Form
    {
        private B_OperacionesDevoluciones BDevolucion = new B_OperacionesDevoluciones();
        public frmDevolucion()
        {
            InitializeComponent();
            cargarDevoluciones();
            colorDataGridview();
        }

        private void tmrFech_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }
        #region botones

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            limpiarAgregado();
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            limpiarBusqueda();
        }
        #endregion

        #region limpiar controles
        private void limpiarAgregado()
        {
            nudLote.Value = 0;
            cmbNombreProducto.Text = "";
            nudNuevoPrecio.Value = 0;
            nudCantidad.Value = 0;
            txtMotivo.Text = "";
        }
        private void limpiarBusqueda()
        {
            nudBusLote.Value = 0;
            cmbBusNombreProducto.Text = "";
            cmbBusNombreProducto.Text = "";
            cmbBusTipoProducto.Text = "";
        }
        #endregion

        public void cargarDevoluciones()
        {
            dgvResBusquedaDevoluciones.DataSource = BDevolucion.MostrarDevoluciones();
            //dgvResBusquedaProveedor.Columns["idProveedor"].Visible = false;
        }
        public void colorDataGridview()
        {
            dgvResBusquedaDevoluciones.ForeColor = Color.FromArgb(5, 15, 40);
        }
    }
}
