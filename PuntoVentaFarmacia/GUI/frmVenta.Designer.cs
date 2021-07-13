
namespace GUI
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblIdVentaEnProceso = new System.Windows.Forms.Label();
            this.lblIdEmpleadoVenta = new System.Windows.Forms.Label();
            this.descID = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.tmrFech = new System.Windows.Forms.Timer(this.components);
            this.ttpHelp = new System.Windows.Forms.ToolTip(this.components);
            this.gbxVentas = new System.Windows.Forms.GroupBox();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.lblResIva = new System.Windows.Forms.Label();
            this.lblResTotal = new System.Windows.Forms.Label();
            this.lblResSubtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCantidadDeProductoEnVenta = new System.Windows.Forms.Label();
            this.lblPrecioProductoEnVenta = new System.Windows.Forms.Label();
            this.lblProductoEnVenta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.dgvVenta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmbNombreCliente = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.lblBusTipoProducto = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.btnVender = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProductoElegido = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.gbxDatosCliente = new System.Windows.Forms.GroupBox();
            this.lblPunAcumClienteElegido = new System.Windows.Forms.Label();
            this.lblAliasClienteElegido = new System.Windows.Forms.Label();
            this.lblClienteElegido = new System.Windows.Forms.Label();
            this.btnElegirCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxVentas.SuspendLayout();
            this.gbxBusqueda.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.gbxDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 582);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 33);
            this.panel2.TabIndex = 28;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHora.Location = new System.Drawing.Point(890, 6);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(61, 24);
            this.lblHora.TabIndex = 26;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFecha.Location = new System.Drawing.Point(381, 6);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(75, 24);
            this.lblFecha.TabIndex = 25;
            this.lblFecha.Text = "Fecha:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblIdVentaEnProceso);
            this.panel1.Controls.Add(this.lblIdEmpleadoVenta);
            this.panel1.Controls.Add(this.descID);
            this.panel1.Controls.Add(this.lblIdProducto);
            this.panel1.Controls.Add(this.lblIdCliente);
            this.panel1.Controls.Add(this.lblVentas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 33);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(121, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Venta ID:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(553, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "Cliente ID:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(698, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Producto ID:";
            // 
            // lblIdVentaEnProceso
            // 
            this.lblIdVentaEnProceso.AutoSize = true;
            this.lblIdVentaEnProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVentaEnProceso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIdVentaEnProceso.Location = new System.Drawing.Point(194, 10);
            this.lblIdVentaEnProceso.Name = "lblIdVentaEnProceso";
            this.lblIdVentaEnProceso.Size = new System.Drawing.Size(0, 13);
            this.lblIdVentaEnProceso.TabIndex = 53;
            // 
            // lblIdEmpleadoVenta
            // 
            this.lblIdEmpleadoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdEmpleadoVenta.AutoSize = true;
            this.lblIdEmpleadoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpleadoVenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIdEmpleadoVenta.Location = new System.Drawing.Point(973, 9);
            this.lblIdEmpleadoVenta.Name = "lblIdEmpleadoVenta";
            this.lblIdEmpleadoVenta.Size = new System.Drawing.Size(0, 13);
            this.lblIdEmpleadoVenta.TabIndex = 52;
            // 
            // descID
            // 
            this.descID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descID.AutoSize = true;
            this.descID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.descID.Location = new System.Drawing.Point(888, 9);
            this.descID.Name = "descID";
            this.descID.Size = new System.Drawing.Size(83, 13);
            this.descID.TabIndex = 51;
            this.descID.Text = "Empleado ID:";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIdProducto.Location = new System.Drawing.Point(777, 9);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(0, 13);
            this.lblIdProducto.TabIndex = 26;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIdCliente.Location = new System.Drawing.Point(626, 9);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(0, 13);
            this.lblIdCliente.TabIndex = 25;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVentas.Location = new System.Drawing.Point(5, 6);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(93, 24);
            this.lblVentas.TabIndex = 24;
            this.lblVentas.Text = "VENTAS";
            // 
            // tmrFech
            // 
            this.tmrFech.Enabled = true;
            this.tmrFech.Tick += new System.EventHandler(this.tmrFech_Tick);
            // 
            // gbxVentas
            // 
            this.gbxVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxVentas.Controls.Add(this.gbxBusqueda);
            this.gbxVentas.Controls.Add(this.groupBox1);
            this.gbxVentas.Controls.Add(this.gbxDatosCliente);
            this.gbxVentas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxVentas.Location = new System.Drawing.Point(12, 39);
            this.gbxVentas.Name = "gbxVentas";
            this.gbxVentas.Size = new System.Drawing.Size(1056, 537);
            this.gbxVentas.TabIndex = 30;
            this.gbxVentas.TabStop = false;
            this.gbxVentas.Text = "Ventas";
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxBusqueda.Controls.Add(this.lblResIva);
            this.gbxBusqueda.Controls.Add(this.lblResTotal);
            this.gbxBusqueda.Controls.Add(this.lblResSubtotal);
            this.gbxBusqueda.Controls.Add(this.label5);
            this.gbxBusqueda.Controls.Add(this.groupBox3);
            this.gbxBusqueda.Controls.Add(this.dgvVenta);
            this.gbxBusqueda.Controls.Add(this.label1);
            this.gbxBusqueda.Controls.Add(this.groupBox2);
            this.gbxBusqueda.Controls.Add(this.btnVender);
            this.gbxBusqueda.Controls.Add(this.label2);
            this.gbxBusqueda.Controls.Add(this.btnCancelar);
            this.gbxBusqueda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxBusqueda.Location = new System.Drawing.Point(479, 19);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(571, 512);
            this.gbxBusqueda.TabIndex = 46;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Opciones";
            // 
            // lblResIva
            // 
            this.lblResIva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResIva.AutoSize = true;
            this.lblResIva.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResIva.Location = new System.Drawing.Point(482, 411);
            this.lblResIva.Name = "lblResIva";
            this.lblResIva.Size = new System.Drawing.Size(21, 13);
            this.lblResIva.TabIndex = 68;
            this.lblResIva.Text = "iva";
            // 
            // lblResTotal
            // 
            this.lblResTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResTotal.AutoSize = true;
            this.lblResTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResTotal.Location = new System.Drawing.Point(264, 450);
            this.lblResTotal.Name = "lblResTotal";
            this.lblResTotal.Size = new System.Drawing.Size(27, 13);
            this.lblResTotal.TabIndex = 67;
            this.lblResTotal.Text = "total";
            // 
            // lblResSubtotal
            // 
            this.lblResSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResSubtotal.AutoSize = true;
            this.lblResSubtotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResSubtotal.Location = new System.Drawing.Point(85, 411);
            this.lblResSubtotal.Name = "lblResSubtotal";
            this.lblResSubtotal.Size = new System.Drawing.Size(44, 13);
            this.lblResSubtotal.TabIndex = 66;
            this.lblResSubtotal.Text = "subtotal";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(18, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Subtotal:  $";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblCantidadDeProductoEnVenta);
            this.groupBox3.Controls.Add(this.lblPrecioProductoEnVenta);
            this.groupBox3.Controls.Add(this.lblProductoEnVenta);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnQuitarProducto);
            this.groupBox3.Location = new System.Drawing.Point(6, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(559, 101);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            // 
            // lblCantidadDeProductoEnVenta
            // 
            this.lblCantidadDeProductoEnVenta.AutoSize = true;
            this.lblCantidadDeProductoEnVenta.Location = new System.Drawing.Point(110, 66);
            this.lblCantidadDeProductoEnVenta.Name = "lblCantidadDeProductoEnVenta";
            this.lblCantidadDeProductoEnVenta.Size = new System.Drawing.Size(95, 13);
            this.lblCantidadDeProductoEnVenta.TabIndex = 68;
            this.lblCantidadDeProductoEnVenta.Text = "Cantidad en Venta";
            // 
            // lblPrecioProductoEnVenta
            // 
            this.lblPrecioProductoEnVenta.AutoSize = true;
            this.lblPrecioProductoEnVenta.Location = new System.Drawing.Point(317, 22);
            this.lblPrecioProductoEnVenta.Name = "lblPrecioProductoEnVenta";
            this.lblPrecioProductoEnVenta.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioProductoEnVenta.TabIndex = 67;
            this.lblPrecioProductoEnVenta.Text = "Precio";
            // 
            // lblProductoEnVenta
            // 
            this.lblProductoEnVenta.AutoSize = true;
            this.lblProductoEnVenta.Location = new System.Drawing.Point(124, 22);
            this.lblProductoEnVenta.Name = "lblProductoEnVenta";
            this.lblProductoEnVenta.Size = new System.Drawing.Size(90, 13);
            this.lblProductoEnVenta.TabIndex = 66;
            this.lblProductoEnVenta.Text = "Nombre Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(256, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Precio:   $";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(9, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Nombre del producto:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(7, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Cantidad en venta:";
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnQuitarProducto.FlatAppearance.BorderSize = 0;
            this.btnQuitarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnQuitarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarProducto.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProducto.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuitarProducto.Location = new System.Drawing.Point(382, 61);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(165, 27);
            this.btnQuitarProducto.TabIndex = 42;
            this.btnQuitarProducto.Text = "QUITAR PRODUCTO";
            this.btnQuitarProducto.UseVisualStyleBackColor = false;
            // 
            // dgvVenta
            // 
            this.dgvVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVenta.Location = new System.Drawing.Point(6, 99);
            this.dgvVenta.Name = "dgvVenta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVenta.Size = new System.Drawing.Size(559, 187);
            this.dgvVenta.TabIndex = 65;
            this.dgvVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenta_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(429, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "IVA:   $";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnDetalle);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.cmbNombreCliente);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnBuscarVenta);
            this.groupBox2.Controls.Add(this.lblBusTipoProducto);
            this.groupBox2.Controls.Add(this.dtpFechaFinal);
            this.groupBox2.Controls.Add(this.dtpFechaInicial);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(6, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 79);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDetalle.FlatAppearance.BorderSize = 0;
            this.btnDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.ForeColor = System.Drawing.Color.Transparent;
            this.btnDetalle.Location = new System.Drawing.Point(410, 46);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(143, 27);
            this.btnDetalle.TabIndex = 48;
            this.btnDetalle.Text = "DETALLE";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 47;
            // 
            // cmbNombreCliente
            // 
            this.cmbNombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNombreCliente.FormattingEnabled = true;
            this.cmbNombreCliente.Location = new System.Drawing.Point(256, 15);
            this.cmbNombreCliente.Name = "cmbNombreCliente";
            this.cmbNombreCliente.Size = new System.Drawing.Size(96, 21);
            this.cmbNombreCliente.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(201, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Fecha de Final:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(3, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Fecha de inicial:";
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarVenta.FlatAppearance.BorderSize = 0;
            this.btnBuscarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVenta.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVenta.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarVenta.Location = new System.Drawing.Point(380, 13);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(173, 27);
            this.btnBuscarVenta.TabIndex = 6;
            this.btnBuscarVenta.Text = "BUSCAR VENTA";
            this.btnBuscarVenta.UseVisualStyleBackColor = false;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // lblBusTipoProducto
            // 
            this.lblBusTipoProducto.AutoSize = true;
            this.lblBusTipoProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBusTipoProducto.Location = new System.Drawing.Point(29, 19);
            this.lblBusTipoProducto.Name = "lblBusTipoProducto";
            this.lblBusTipoProducto.Size = new System.Drawing.Size(92, 13);
            this.lblBusTipoProducto.TabIndex = 23;
            this.lblBusTipoProducto.Text = "Buscar en Venta: ";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(287, 52);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaFinal.TabIndex = 5;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(91, 52);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaInicial.TabIndex = 4;
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVender.Enabled = false;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.Transparent;
            this.btnVender.Location = new System.Drawing.Point(6, 479);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(159, 27);
            this.btnVender.TabIndex = 31;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(209, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Total:   $";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(400, 479);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 27);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "CANCELAR VENTA";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblProductoElegido);
            this.groupBox1.Controls.Add(this.dgvProductos);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnAgregarProducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCantidadProducto);
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(6, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 266);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Producto";
            // 
            // lblProductoElegido
            // 
            this.lblProductoElegido.AutoSize = true;
            this.lblProductoElegido.Location = new System.Drawing.Point(122, 189);
            this.lblProductoElegido.Name = "lblProductoElegido";
            this.lblProductoElegido.Size = new System.Drawing.Size(88, 13);
            this.lblProductoElegido.TabIndex = 65;
            this.lblProductoElegido.Text = "Producto Elegido";
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.Location = new System.Drawing.Point(9, 49);
            this.dgvProductos.Name = "dgvProductos";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.Size = new System.Drawing.Size(452, 131);
            this.dgvProductos.TabIndex = 64;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(11, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Buscar Producto:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 60;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 62;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(312, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 27);
            this.button2.TabIndex = 61;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarProducto.Enabled = false;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.Location = new System.Drawing.Point(9, 225);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(124, 27);
            this.btnAgregarProducto.TabIndex = 30;
            this.btnAgregarProducto.Text = "AGREGAR";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nombre del producto:";
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantidadProducto.Location = new System.Drawing.Point(260, 189);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(130, 13);
            this.lblCantidadProducto.TabIndex = 37;
            this.lblCantidadProducto.Text = "Elegir Cantidad a Vender: ";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCantidad.Location = new System.Drawing.Point(393, 187);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(61, 20);
            this.nudCantidad.TabIndex = 38;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gbxDatosCliente
            // 
            this.gbxDatosCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxDatosCliente.Controls.Add(this.lblPunAcumClienteElegido);
            this.gbxDatosCliente.Controls.Add(this.lblAliasClienteElegido);
            this.gbxDatosCliente.Controls.Add(this.lblClienteElegido);
            this.gbxDatosCliente.Controls.Add(this.btnElegirCliente);
            this.gbxDatosCliente.Controls.Add(this.dgvClientes);
            this.gbxDatosCliente.Controls.Add(this.lblBuscarCliente);
            this.gbxDatosCliente.Controls.Add(this.txtBuscarCliente);
            this.gbxDatosCliente.Controls.Add(this.cmbFiltros);
            this.gbxDatosCliente.Controls.Add(this.button1);
            this.gbxDatosCliente.Controls.Add(this.label7);
            this.gbxDatosCliente.Controls.Add(this.label8);
            this.gbxDatosCliente.Controls.Add(this.label4);
            this.gbxDatosCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxDatosCliente.Location = new System.Drawing.Point(6, 19);
            this.gbxDatosCliente.Name = "gbxDatosCliente";
            this.gbxDatosCliente.Size = new System.Drawing.Size(467, 234);
            this.gbxDatosCliente.TabIndex = 39;
            this.gbxDatosCliente.TabStop = false;
            this.gbxDatosCliente.Text = "Datos Del Cliente";
            // 
            // lblPunAcumClienteElegido
            // 
            this.lblPunAcumClienteElegido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPunAcumClienteElegido.AutoSize = true;
            this.lblPunAcumClienteElegido.Location = new System.Drawing.Point(122, 200);
            this.lblPunAcumClienteElegido.Name = "lblPunAcumClienteElegido";
            this.lblPunAcumClienteElegido.Size = new System.Drawing.Size(152, 13);
            this.lblPunAcumClienteElegido.TabIndex = 63;
            this.lblPunAcumClienteElegido.Text = "Puntos Acumulados del cliente";
            // 
            // lblAliasClienteElegido
            // 
            this.lblAliasClienteElegido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAliasClienteElegido.AutoSize = true;
            this.lblAliasClienteElegido.Location = new System.Drawing.Point(332, 165);
            this.lblAliasClienteElegido.Name = "lblAliasClienteElegido";
            this.lblAliasClienteElegido.Size = new System.Drawing.Size(80, 13);
            this.lblAliasClienteElegido.TabIndex = 62;
            this.lblAliasClienteElegido.Text = "Alias del cliente";
            // 
            // lblClienteElegido
            // 
            this.lblClienteElegido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClienteElegido.AutoSize = true;
            this.lblClienteElegido.Location = new System.Drawing.Point(52, 163);
            this.lblClienteElegido.Name = "lblClienteElegido";
            this.lblClienteElegido.Size = new System.Drawing.Size(95, 13);
            this.lblClienteElegido.TabIndex = 61;
            this.lblClienteElegido.Text = "Nombre del cliente";
            // 
            // btnElegirCliente
            // 
            this.btnElegirCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElegirCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnElegirCliente.FlatAppearance.BorderSize = 0;
            this.btnElegirCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnElegirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirCliente.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirCliente.ForeColor = System.Drawing.Color.Transparent;
            this.btnElegirCliente.Location = new System.Drawing.Point(297, 200);
            this.btnElegirCliente.Name = "btnElegirCliente";
            this.btnElegirCliente.Size = new System.Drawing.Size(157, 27);
            this.btnElegirCliente.TabIndex = 60;
            this.btnElegirCliente.Text = "ELEGIR";
            this.btnElegirCliente.UseVisualStyleBackColor = false;
            this.btnElegirCliente.Click += new System.EventHandler(this.btnElegirCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvClientes.Location = new System.Drawing.Point(20, 49);
            this.dgvClientes.Name = "dgvClientes";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvClientes.Size = new System.Drawing.Size(441, 104);
            this.dgvClientes.TabIndex = 59;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBuscarCliente.Location = new System.Drawing.Point(22, 27);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(78, 13);
            this.lblBuscarCliente.TabIndex = 50;
            this.lblBuscarCliente.Text = "Buscar Cliente:";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(106, 23);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(102, 20);
            this.txtBuscarCliente.TabIndex = 46;
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Location = new System.Drawing.Point(214, 22);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(92, 21);
            this.cmbFiltros.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(312, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 27);
            this.button1.TabIndex = 48;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(12, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Cliente:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(18, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Puntos Acumulados:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(294, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Alias:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.gbxVentas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxVentas.ResumeLayout(false);
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.gbxDatosCliente.ResumeLayout(false);
            this.gbxDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Timer tmrFech;
        private System.Windows.Forms.ToolTip ttpHelp;
        private System.Windows.Forms.GroupBox gbxVentas;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxDatosCliente;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.ComboBox cmbNombreCliente;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvVenta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblBusTipoProducto;
        private System.Windows.Forms.Button btnElegirCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblProductoElegido;
        private System.Windows.Forms.Label lblPunAcumClienteElegido;
        private System.Windows.Forms.Label lblAliasClienteElegido;
        private System.Windows.Forms.Label lblClienteElegido;
        private System.Windows.Forms.Label descID;
        public System.Windows.Forms.Label lblIdEmpleadoVenta;
        private System.Windows.Forms.Label lblResIva;
        private System.Windows.Forms.Label lblResTotal;
        private System.Windows.Forms.Label lblResSubtotal;
        private System.Windows.Forms.Label lblCantidadDeProductoEnVenta;
        private System.Windows.Forms.Label lblPrecioProductoEnVenta;
        private System.Windows.Forms.Label lblProductoEnVenta;
        private System.Windows.Forms.Label lblIdVentaEnProceso;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}