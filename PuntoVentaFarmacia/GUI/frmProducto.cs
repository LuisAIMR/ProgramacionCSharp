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
using System.Data.SqlClient;
using Business;

namespace GUI
{
    public partial class frmProducto : Form
    {
        public B_OperacionesProductos BTipo = new B_OperacionesProductos();
        string nombreTipo;
        int statTipo;

        public B_OperacionesProductos BProducto = new B_OperacionesProductos();
        string lote, nombreP, descripcion;
        DateTime fechaCad;
        float precio;
        int ProductoStat, idTipo, cantidadP, puntosCanejo, Puntos, reqReceta;        
        public frmProducto()
        {
            InitializeComponent();
            mostrarMensajes();
            cargarTipos();
            cargarProductos();
            colorDataGridview();
        }
        private void frmProducto_Load(object sender, EventArgs e)
        {
            //D_Conexion conexionDB = new D_Conexion();
            //conexionDB.abrir();
            //string cadena = "select * from Producto";
            //SqlCommand comando = new SqlCommand(cadena, conexionDB.conectarbd);
            //SqlDataAdapter adapdator = new SqlDataAdapter(comando);
            //DataTable TablaProducto = new DataTable();
            //adapdator.Fill(TablaProducto);
            //dgvResBusquedaProd.DataSource = TablaProducto;
        }
        public void mostrarMensajes()
        {
            this.ttpHelp.SetToolTip(this.btnAgregar, "Dar click para ingresar la información que se coloco en los controles de la sección de datos");
            this.ttpHelp.SetToolTip(this.btnBuscarProducto, "Da click para buscar la información de los productos");
            this.ttpHelp.SetToolTip(this.cmbBusTipoProducto, "selecciona un tipo de producto que se encuentra en el control");
            this.ttpHelp.SetToolTip(this.cmbTipoProducto, "Selecciona un tipo de producto");
            this.ttpHelp.SetToolTip(this.cmbBusNombreProducto, "Introduce el nombre del producto");
            this.ttpHelp.SetToolTip(this.rtxtDescripcion, "Introduce la descripción del producto");
            this.ttpHelp.SetToolTip(this.txtNombreProducto, "Introduce el nombre del producto");
            this.ttpHelp.SetToolTip(this.nudCantidad, "Ingresa la cantidad");
            this.ttpHelp.SetToolTip(this.nudLote, "Ingresa el numero de lote");
            this.ttpHelp.SetToolTip(this.nudPrecio, "Ingresa la cantidad");
            this.ttpHelp.SetToolTip(this.nudPuntosdeCanjeo, "Ingresa la cantidad");
            this.ttpHelp.SetToolTip(this.nudPuntosParaCanjeo, "Ingresa la cantidad");
            this.ttpHelp.SetToolTip(this.nudBusLote, "Ingresa la cantidad");
            this.ttpHelp.SetToolTip(this.rbtnEspecialSi, "Define que el producto que se esta ingresando requiere receta para ser comprado");
            this.ttpHelp.SetToolTip(this.rbtnEspecialNo, "Define que el producto que se esta ingresando no requiere receta para ser comprado");
            this.ttpHelp.SetToolTip(this.dtpFechaCad, "Ingrese una fecha");
            this.ttpHelp.SetToolTip(this.dgvResBusquedaProd, "Muestra la información resultante de la busqueda");

        }

        private void tmrFech_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }
       

        private void rbtnReqPantSi_CheckedChanged(object sender, EventArgs e)
        {
            gbxEspecial.Enabled = true;
        }

        private void rbtnReqPantNo_CheckedChanged(object sender, EventArgs e)
        {
            gbxEspecial.Enabled = false;
        }
        #region botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (cmbTipoProducto.Text == "")
            {
                errorProvider1.SetError(cmbTipoProducto, "El campo no puede quedar vacio");
                cmbTipoProducto.Focus();
                return;
            }
            errorProvider1.SetError(cmbTipoProducto, "");

            if (nudLote.Value == 0)
            {
                errorProvider1.SetError(nudLote, "El campo no puede quedar vacio");
                nudLote.Focus();
                return;
            }
            errorProvider1.SetError(nudLote, "");

            if (txtNombreProducto.Text == "")
            {
                errorProvider1.SetError(txtNombreProducto, "El campo no puede quedar vacio");
                txtNombreProducto.Focus();
                return;
            }
            errorProvider1.SetError(txtNombreProducto, "");

            if (rtxtDescripcion.Text == "")
            {
                errorProvider1.SetError(rtxtDescripcion, "El campo no puede quedar vacio");
                rtxtDescripcion.Focus();
                return;
            }
            errorProvider1.SetError(rtxtDescripcion, "");

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

            if (nudPuntosdeCanjeo.Value == 0)
            {
                errorProvider1.SetError(nudPuntosdeCanjeo, "El campo no puede quedar vacio");
                nudPuntosdeCanjeo.Focus();
                return;
            }
            errorProvider1.SetError(nudPuntosdeCanjeo, "");
            if (nudPuntosParaCanjeo.Value == 0)
            {
                errorProvider1.SetError(nudPuntosParaCanjeo, "El campo no puede quedar vacio");
                nudPuntosParaCanjeo.Focus();
                return;
            }
            errorProvider1.SetError(nudPuntosParaCanjeo, "");

            if(rbtnEspecialNo.Checked == true)
            {
                conversionesProducto();
                MessageBox.Show(BProducto.insertarProducto(lote, nombreP, descripcion, precio, puntosCanejo, cantidadP, Puntos, ProductoStat, idTipo));
            }
            else if(rbtnEspecialSi.Checked == true)
            {
                conversionesProducto();
                fechaCad = dtpFechaCad.Value.Date;
                if (rbtnReqPantSi.Checked == true)
                {
                    reqReceta = 1;
                }
                else
                {
                    reqReceta = 0;
                }
                MessageBox.Show(BProducto.insertarProductoTipo2(lote, nombreP, descripcion, precio, puntosCanejo, cantidadP, Puntos, ProductoStat, idTipo,fechaCad,reqReceta));
            }
            else
            {

                conversionesProducto();
                MessageBox.Show(BProducto.insertarProducto(lote, nombreP, descripcion, precio, puntosCanejo, cantidadP, Puntos, ProductoStat, idTipo));

            }

            gbxEspecial.Enabled = false;
            limpiarAgregado();
        }
        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            limpiarAgregado();
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            limpiarBusqueda();
        }

        private void nudLote_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvResBusquedaProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdProducto.Text= dgvResBusquedaProd.CurrentRow.Cells[0].Value.ToString();


        }
        #endregion

        #region limpiar controles

        private void limpiarAgregado()
        {
            cmbTipoProducto.Text = "";
            nudLote.Value = 0;
            txtNombreProducto.Text = "";
            rtxtDescripcion.Text = "";
            nudPrecio.Value = 1;
            nudCantidad.Value = 1;
            nudPuntosdeCanjeo.Value=0;
            nudPuntosParaCanjeo.Value = 0;
                
        }

        private void limpiarBusqueda()
        {
            nudBusLote.Value = 0;
            cmbBusNombreProducto.Text = "";
            cmbBusTipoProducto.Text = "";
        }



        #endregion

        
        //Ejemplo de a
        private void btnAgregarTipoProducto_Click(object sender, EventArgs e)
        {
            conversionesTipo();
            MessageBox.Show(BTipo.insertarTipo(nombreTipo,statTipo));
    
        }


        private void conversionesTipo()
        {
            nombreTipo = cmbAgregarTipo.Text.ToUpper();
            statTipo = 1;
        }
        private void conversionesProducto()
        {
            string fmt = "00000000.##";
            lote = nudLote.Value.ToString(fmt);                       
            nombreP = txtNombreProducto.Text.ToUpper();
            descripcion = rtxtDescripcion.Text.ToUpper();
            precio =Convert.ToSingle(nudPrecio.Value);
            puntosCanejo =Convert.ToInt32( nudPuntosParaCanjeo.Value);
            cantidadP = Convert.ToInt32(nudCantidad.Value);
            Puntos = Convert.ToInt32(nudPuntosdeCanjeo.Value);
            ProductoStat = 1;        
            idTipo = Convert.ToInt32(cmbTipoProducto.SelectedValue);
            

        }
        public void cargarTipos()
        {
            var lista = BTipo.cargarTipos();
            cmbTipoProducto.DataSource = lista;
            cmbTipoProducto.DisplayMember = "nombreT";
            cmbTipoProducto.ValueMember = "idTipo";
        }
        public void cargarProductos()
        {
            dgvResBusquedaProd.DataSource = BProducto.MostrarProductos();
            //dgvResBusquedaProd.Columns["idProveedor"].Visible = false;
        }
        public void colorDataGridview()
        {
            dgvResBusquedaProd.ForeColor = Color.FromArgb(5, 15, 40);
        }
    }
}
