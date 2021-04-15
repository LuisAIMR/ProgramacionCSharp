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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
            mostrarMensajes();
        }
       
        public void mostrarMensajes()
        {
            this.ttpHelp.SetToolTip(this.btnIngresarInfo, "Dar click para ingresar la información que se coloco en los controles de la sección de datos");
            this.ttpHelp.SetToolTip(this.btnBuscarProducto, "Da click para buscar la información de los productos");
            this.ttpHelp.SetToolTip(this.cmbBusTipoProducto, "selecciona un tipo de producto que se encuentra en el control");
            this.ttpHelp.SetToolTip(this.cmbTipoProducto, "Selecciona un tipo de producto");
            this.ttpHelp.SetToolTip(this.txtBusNombreProducto, "Introduce el nombre del producto");
            this.ttpHelp.SetToolTip(this.txtDescripcionProducto, "Introduce la descripción del producto");
            this.ttpHelp.SetToolTip(this.txtNombreProducto, "Introduce el nombre del producto");
            this.ttpHelp.SetToolTip(this.nudCantidad, "Ingresa la cantidad");
            this.ttpHelp.SetToolTip(this.nudLote, "Ingresa el numero de lote");
            this.ttpHelp.SetToolTip(this.nudPrecio, "Ingresa la cantidad");
            this.ttpHelp.SetToolTip(this.nudPuntosdeCanjeo, "Ingresa la cantidad");
            this.ttpHelp.SetToolTip(this.nudPuntosParaCanjeo, "Ingresa la cantidad");
            this.ttpHelp.SetToolTip(this.nudBusLote, "Ingresa la cantidad");
            this.ttpHelp.SetToolTip(this.rbtnReqPantSi, "Define que el producto que se esta ingresando requiere receta para ser comprado");
            this.ttpHelp.SetToolTip(this.rbtnReqPantNo, "Define que el producto que se esta ingresando no requiere receta para ser comprado");
            this.ttpHelp.SetToolTip(this.dtpFechaCad, "Ingrese una fecha");
            this.ttpHelp.SetToolTip(this.dgvResBusquedaProd, "Muestra la información resultante de la busqueda");

        }

        private void tmrFech_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }
    }
}
