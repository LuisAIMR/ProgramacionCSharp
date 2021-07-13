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
    public partial class frmCliente : Form
    {
        private B_OperacionesClientes BCliente = new B_OperacionesClientes();
        string nombre, apPat, apMat, curp, telefono, alias;
        int punAcum, stat, idCliente;
        DateTime fechaNac;
        public frmCliente()
        {
            InitializeComponent();
            cargarClientes();
            colorDataGridview();
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

            //Regex reAlias = new Regex("[A-Z]{3}[0-9]{2}[A-Z0-9]{1}[.]*", RegexOptions.Compiled);
            //if (!reAlias.IsMatch(txtAlias.Text))
            //{
            //    errorProvider1.SetError(txtAlias, "Debe colocar un alias valido");
            //    txtAlias.Focus();
            //    return;
            //}
            //errorProvider1.SetError(txtAlias, "");
            conversionesCliente();
            MessageBox.Show(BCliente.insertarCliente(nombre, apPat, apMat, fechaNac, curp,  telefono,  alias,  punAcum, stat), "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarAgregado();          


        }

        private void dgvBusquedaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdCliente.Text = dgvBusquedaClientes.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text= dgvBusquedaClientes.CurrentRow.Cells[1].Value.ToString();
            txtApPaterno.Text= dgvBusquedaClientes.CurrentRow.Cells[2].Value.ToString();
            txtApMaterno.Text= dgvBusquedaClientes.CurrentRow.Cells[3].Value.ToString();
            dtpFechaNac.Value= Convert.ToDateTime (dgvBusquedaClientes.CurrentRow.Cells[4].Value.ToString());
            txtCurp.Text= dgvBusquedaClientes.CurrentRow.Cells[5].Value.ToString();
            txtTelefono.Text= dgvBusquedaClientes.CurrentRow.Cells[6].Value.ToString();
            txtAlias.Text= dgvBusquedaClientes.CurrentRow.Cells[7].Value.ToString();
        }
        #region busquedaPorcontroles
        private void txtBusNombreCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtBusNombreCliente.Text != "")
            {
                nombre = txtBusNombreCliente.Text;
                apPat = txtBusApPaterno.Text;
                curp = txtBusCurp.Text;
                alias = txtBusAlias.Text;
                dgvBusquedaClientes.DataSource = BCliente.BuscarClientes(nombre,apPat,curp,alias);
            }
            
        }

        #endregion
        private void btnTerminarBusqueda_Click(object sender, EventArgs e)
        {
            limpiarBusqueda();
            cargarClientes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conversionesCliente();
            MessageBox.Show(BCliente.ActualizarCliente(idCliente,nombre, apPat, apMat, fechaNac, curp, telefono, alias, punAcum, stat), "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
        }
        
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            limpiarBusqueda();
        }



        private void conversionesCliente()
        {
          nombre = txtNombre.Text.ToUpper();
          apPat = txtApPaterno.Text.ToUpper();
          apMat= txtApMaterno.Text.ToUpper();
          fechaNac = dtpFechaNac.Value.Date;
          curp = txtCurp.Text.ToUpper();
          telefono= txtTelefono.Text.ToUpper();
          alias= txtAlias.Text.ToUpper();
          punAcum = 0;
          stat = 1;
          idCliente=Convert.ToInt32(lblIdCliente.Text);

          
        }
        public void cargarClientes()
        {
            dgvBusquedaClientes.DataSource = BCliente.MostrarClientes();
            dgvBusquedaClientes.Columns["idPersona"].Visible = false;
        }
        public void colorDataGridview()
        {
            dgvBusquedaClientes.ForeColor = Color.FromArgb(5, 15, 40);
        }
    }
}
