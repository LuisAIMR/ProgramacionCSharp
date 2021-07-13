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
    public partial class frmVenta : Form
    {
        private B_OperacionesVentas BVenta = new B_OperacionesVentas();
        private B_OperacionesEmpleados BEmpleado = new B_OperacionesEmpleados();

        bool inicioVenta =true;
        int idProducto, cantidad, idEmpleado, idCliente, idVenta;
        public frmVenta()
        {
            InitializeComponent();
            colorDataGridview();
            cargarClientes();
            cargarProductos();
        }
        //public void ChangeTextBoxText(string text)
        //{
        //    lblIdEmpleadoVenta.Text = text;
        //}
        private void tmrFech_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }
        #region botones
       

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Venta Realizada con exito", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                inicioVenta = true;
                limpiarVenta();
                btnAgregarProducto.Enabled = false;
                btnElegirCliente.Enabled = true;
                btnVender.Enabled = false;
                cargarClientes();
                cargarProductos();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region limpieza de controles




        private void limpiarVenta()
        {
            lblResSubtotal.Text = "subtotal";
            lblResTotal.Text= "total";
            lblResIva.Text = "iva";
            dgvVenta.DataSource = null;

            lblClienteElegido.Text = "Nombre del cliente";
            lblAliasClienteElegido.Text = "Alias del cliente";
            lblPunAcumClienteElegido.Text = "Puntos Acumulados del cliente";
            lblIdCliente.Text = "";
            LimpiarAgregadoDeProducto();
        }


        private void LimpiarAgregadoDeProducto()
        {
            nudCantidad.Value = 1;
            lblProductoElegido.Text = "Producto Elegido";
            lblIdProducto.Text = "";
        }
        #endregion

        private void dgvResBusquedaVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbAlias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void cargarClientes()
        {
            dgvClientes.DataSource = BVenta.MostrarClientes();
            dgvClientes.Columns["idPersona"].Visible = false;
        }
        public void cargarProductos()
        {
            dgvProductos.DataSource = BVenta.MostrarProductos();
            dgvProductos.Columns["idProducto"].Visible = false;
        }
        public void cargarVentaProceso()
        {
            dgvVenta.DataSource = BVenta.MostrarVentaEnProceso();

            

            dgvVenta.Columns["idVenta"].Visible = false;
            dgvVenta.Columns["Total"].Visible = false;
            dgvVenta.Columns["iva"].Visible = false;
            dgvVenta.Columns["Subtotal"].Visible = false;
            dgvVenta.Columns["idProducto"].Visible = false;
        }
        public void colorDataGridview()
        {
            dgvClientes.ForeColor = Color.FromArgb(5, 15, 40);
            dgvProductos.ForeColor = Color.FromArgb(5, 15, 40);
            dgvVenta.ForeColor = Color.FromArgb(5, 15, 40);
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            lblClienteElegido.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            lblAliasClienteElegido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            lblPunAcumClienteElegido.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdProducto.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            lblProductoElegido.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
          
        }

        private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdVentaEnProceso.Text = dgvVenta.CurrentRow.Cells[0].Value.ToString();
            lblResTotal.Text = dgvVenta.CurrentRow.Cells[1].Value.ToString();
            lblResIva.Text = dgvVenta.CurrentRow.Cells[2].Value.ToString();
            lblResSubtotal.Text = dgvVenta.CurrentRow.Cells[3].Value.ToString();           
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {            
            //lblIdVentaEnProceso.Text = dgvVenta.CurrentRow.Cells[0].Value.ToString();
            //lblResTotal.Text= dgvVenta.CurrentRow.Cells[1].Value.ToString();
            //lblResIva.Text = dgvVenta.CurrentRow.Cells[2].Value.ToString();
            //lblResSubtotal.Text= dgvVenta.CurrentRow.Cells[3].Value.ToString();
            
        }
        private void btnElegirCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cliente seleccionado", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                btnElegirCliente.Enabled = false;
                btnAgregarProducto.Enabled = true;
            }
           
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            if (nudCantidad.Value == 0)
            {
                errorProvider1.SetError(nudCantidad, "El campo no puede quedar vacio");
                nudCantidad.Focus();
                return;
            }
            errorProvider1.SetError(nudCantidad, "");

            
            if (inicioVenta == true)
            {
                if (MessageBox.Show("ProductoSeleccionado", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    conversionesParaVenta();
                    MessageBox.Show(BVenta.insertarProductoUnoVenta(idProducto, cantidad, idEmpleado, idCliente), "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inicioVenta = false;
                    btnVender.Enabled = true;
                    cargarVentaProceso();                   
                }                
            }
            //else if (inicioVenta == false)
            //{
            //    conversionesParaVenta();
            //    idVenta = Convert.ToInt32(lblIdVentaEnProceso.Text);
            //    MessageBox.Show(BVenta.AñadirMasProducto(idProducto, idVenta, cantidad), "Venta en proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cargarVentaProceso();
            //}

            LimpiarAgregadoDeProducto();
        }
        private void conversionesParaVenta()
        {
            idProducto = Convert.ToInt32(lblIdProducto.Text);
            cantidad = Convert.ToInt32(nudCantidad.Value);
            idEmpleado = Convert.ToInt32(lblIdEmpleadoVenta.Text);
            idCliente = Convert.ToInt32(lblIdCliente.Text);
        }       
    }
}
