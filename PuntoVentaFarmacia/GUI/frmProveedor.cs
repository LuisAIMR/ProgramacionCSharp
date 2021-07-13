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
    public partial class frmProveedor : Form
    {
        private B_OperacionesProveedor BProveedor = new B_OperacionesProveedor();
        string nombrePro, telefono, descripcion;
        int stat, idProveedor;
        public frmProveedor()
        {
            InitializeComponent();
            cargarProveedores();
            colorDataGridview();
        }

        private void tmrFech_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();

               
           
        }
        public void colorDataGridview()
        {
            dgvResBusquedaProveedor.ForeColor = Color.FromArgb(5, 15, 40);
        }
        #region botones

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            #region validacion en presentación
            Regex reNombre = new Regex("^[a-zA-Z0-9_ ]*$", RegexOptions.Compiled);
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
            #endregion

            conversionesProvedor();
            MessageBox.Show(BProveedor.insertarProveedor(nombrePro, telefono,descripcion,stat), "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarAgregado();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conversionesProvedor();
            idProveedor = Convert.ToInt32(lblIdProveedor.Text);
            MessageBox.Show(BProveedor.actualizarProveedor(nombrePro, telefono, descripcion, idProveedor), "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbBusProveedor.Text = "";
            limpiarAgregado();
            cargarProveedores();
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
        #region busquedaPorcontroles

        private void cmbBusProveedor_TextUpdate(object sender, EventArgs e)
        {
            if(cmbBusProveedor.Text!="")
            {
                nombrePro = cmbBusProveedor.Text;
                dgvResBusquedaProveedor.DataSource = BProveedor.BuscarProveedores(nombrePro);
            }
            else
            {
                cargarProveedores();
            }
            
        }

        #endregion
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            cmbBusProveedor.Text = "";
        }

        private void dgvResBusquedaProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdProveedor.Text = dgvResBusquedaProveedor.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvResBusquedaProveedor.CurrentRow.Cells[1].Value.ToString();
            txtTelefono.Text = dgvResBusquedaProveedor.CurrentRow.Cells[2].Value.ToString();
            txtDescripcion.Text = dgvResBusquedaProveedor.CurrentRow.Cells[3].Value.ToString();
        }

       

        private void conversionesProvedor()
        {
            nombrePro = txtNombre.Text.ToUpper();
            telefono = txtTelefono.Text;
            descripcion = txtDescripcion.Text.ToUpper();
            stat = 1;
            

        }
        public void cargarProveedores()
        {
            dgvResBusquedaProveedor.DataSource = BProveedor.MostrarProveedores();
            dgvResBusquedaProveedor.Columns["idProveedor"].Visible = false;
        }
    }
}
