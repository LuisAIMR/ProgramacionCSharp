
namespace GUI
{
    partial class frmCompra
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
            this.nudSubtotal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudIva = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NudTotal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCompras = new System.Windows.Forms.Label();
            this.ttpHelp = new System.Windows.Forms.ToolTip(this.components);
            this.tmrFech = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxDatosCliente = new System.Windows.Forms.GroupBox();
            this.btnCancelarProveedor = new System.Windows.Forms.Button();
            this.btnListoProveedor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudLoteDeProducto = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNombreProducto = new System.Windows.Forms.ComboBox();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnRegistrarCompra = new System.Windows.Forms.Button();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.cmbUsuarioEmpleado = new System.Windows.Forms.ComboBox();
            this.lblBusLote = new System.Windows.Forms.Label();
            this.nudBusLote = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBusNombreProducto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblBusTipoProducto = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.cmbNombreProveedor = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.btnActualizarCompra = new System.Windows.Forms.Button();
            this.btnEliminarCompra = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.dgvResBusquedaCompra = new System.Windows.Forms.DataGridView();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcióndelproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntosParaCanjeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntosDeCanjeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReqPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescripcionProveedor = new System.Windows.Forms.TextBox();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.cmbTelefono = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudSubtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTotal)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbxDatosCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoteDeProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.gbxBusqueda.SuspendLayout();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBusLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResBusquedaCompra)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSubtotal
            // 
            this.nudSubtotal.Location = new System.Drawing.Point(88, 399);
            this.nudSubtotal.Name = "nudSubtotal";
            this.nudSubtotal.Size = new System.Drawing.Size(117, 20);
            this.nudSubtotal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(18, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Subtotal:   $";
            // 
            // nudIva
            // 
            this.nudIva.Location = new System.Drawing.Point(267, 401);
            this.nudIva.Name = "nudIva";
            this.nudIva.Size = new System.Drawing.Size(112, 20);
            this.nudIva.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(219, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "IVA:   $";
            // 
            // NudTotal
            // 
            this.NudTotal.Enabled = false;
            this.NudTotal.Location = new System.Drawing.Point(73, 442);
            this.NudTotal.Name = "NudTotal";
            this.NudTotal.Size = new System.Drawing.Size(306, 20);
            this.NudTotal.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(18, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total:   $";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.lblCompras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 33);
            this.panel1.TabIndex = 27;
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCompras.Location = new System.Drawing.Point(5, 6);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(111, 24);
            this.lblCompras.TabIndex = 24;
            this.lblCompras.Text = "COMPRAS";
            // 
            // tmrFech
            // 
            this.tmrFech.Enabled = true;
            this.tmrFech.Tick += new System.EventHandler(this.tmrFech_Tick);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(36, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(41, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Nombre:";
            // 
            // gbxDatosCliente
            // 
            this.gbxDatosCliente.Controls.Add(this.cmbTelefono);
            this.gbxDatosCliente.Controls.Add(this.cmbNombre);
            this.gbxDatosCliente.Controls.Add(this.btnCancelarProveedor);
            this.gbxDatosCliente.Controls.Add(this.btnListoProveedor);
            this.gbxDatosCliente.Controls.Add(this.label7);
            this.gbxDatosCliente.Controls.Add(this.label9);
            this.gbxDatosCliente.Controls.Add(this.label10);
            this.gbxDatosCliente.Controls.Add(this.txtDescripcionProveedor);
            this.gbxDatosCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxDatosCliente.Location = new System.Drawing.Point(11, 19);
            this.gbxDatosCliente.Name = "gbxDatosCliente";
            this.gbxDatosCliente.Size = new System.Drawing.Size(368, 169);
            this.gbxDatosCliente.TabIndex = 40;
            this.gbxDatosCliente.TabStop = false;
            this.gbxDatosCliente.Text = "Datos Del Proveedor";
            // 
            // btnCancelarProveedor
            // 
            this.btnCancelarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarProveedor.FlatAppearance.BorderSize = 0;
            this.btnCancelarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProveedor.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProveedor.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelarProveedor.Location = new System.Drawing.Point(222, 132);
            this.btnCancelarProveedor.Name = "btnCancelarProveedor";
            this.btnCancelarProveedor.Size = new System.Drawing.Size(118, 27);
            this.btnCancelarProveedor.TabIndex = 45;
            this.btnCancelarProveedor.Text = "CANCELAR";
            this.btnCancelarProveedor.UseVisualStyleBackColor = false;
            this.btnCancelarProveedor.Click += new System.EventHandler(this.btnCancelarProveedor_Click);
            // 
            // btnListoProveedor
            // 
            this.btnListoProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnListoProveedor.FlatAppearance.BorderSize = 0;
            this.btnListoProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnListoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListoProveedor.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListoProveedor.ForeColor = System.Drawing.Color.Transparent;
            this.btnListoProveedor.Location = new System.Drawing.Point(94, 132);
            this.btnListoProveedor.Name = "btnListoProveedor";
            this.btnListoProveedor.Size = new System.Drawing.Size(90, 26);
            this.btnListoProveedor.TabIndex = 44;
            this.btnListoProveedor.Text = "LISTO";
            this.btnListoProveedor.UseVisualStyleBackColor = false;
            this.btnListoProveedor.Click += new System.EventHandler(this.btnListoProveedor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudLoteDeProducto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCancelarProducto);
            this.groupBox1.Controls.Add(this.btnAgregarProducto);
            this.groupBox1.Controls.Add(this.lblPrecioProducto);
            this.groupBox1.Controls.Add(this.nudPrecio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbNombreProducto);
            this.groupBox1.Controls.Add(this.lblCantidadProducto);
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(11, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 163);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Producto";
            // 
            // nudLoteDeProducto
            // 
            this.nudLoteDeProducto.Location = new System.Drawing.Point(106, 29);
            this.nudLoteDeProducto.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudLoteDeProducto.Name = "nudLoteDeProducto";
            this.nudLoteDeProducto.Size = new System.Drawing.Size(80, 20);
            this.nudLoteDeProducto.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Lote del producto:";
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarProducto.FlatAppearance.BorderSize = 0;
            this.btnCancelarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarProducto.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProducto.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelarProducto.Location = new System.Drawing.Point(240, 130);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(118, 27);
            this.btnCancelarProducto.TabIndex = 43;
            this.btnCancelarProducto.Text = "CANCELAR";
            this.btnCancelarProducto.UseVisualStyleBackColor = false;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.Location = new System.Drawing.Point(10, 130);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(202, 27);
            this.btnAgregarProducto.TabIndex = 42;
            this.btnAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecioProducto.Location = new System.Drawing.Point(208, 32);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(55, 13);
            this.lblPrecioProducto.TabIndex = 40;
            this.lblPrecioProducto.Text = "Precio:   $";
            // 
            // nudPrecio
            // 
            this.nudPrecio.Enabled = false;
            this.nudPrecio.Location = new System.Drawing.Point(269, 29);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(73, 20);
            this.nudPrecio.TabIndex = 41;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nombre del producto:";
            // 
            // cmbNombreProducto
            // 
            this.cmbNombreProducto.FormattingEnabled = true;
            this.cmbNombreProducto.Location = new System.Drawing.Point(122, 68);
            this.cmbNombreProducto.Name = "cmbNombreProducto";
            this.cmbNombreProducto.Size = new System.Drawing.Size(86, 21);
            this.cmbNombreProducto.TabIndex = 34;
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantidadProducto.Location = new System.Drawing.Point(247, 74);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(52, 13);
            this.lblCantidadProducto.TabIndex = 37;
            this.lblCantidadProducto.Text = "Cantidad:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(305, 69);
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
            this.nudCantidad.Size = new System.Drawing.Size(37, 20);
            this.nudCantidad.TabIndex = 38;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelarCompra.FlatAppearance.BorderSize = 0;
            this.btnCancelarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCompra.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelarCompra.Location = new System.Drawing.Point(196, 485);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(183, 27);
            this.btnCancelarCompra.TabIndex = 36;
            this.btnCancelarCompra.Text = "CANCELAR COMPRA";
            this.btnCancelarCompra.UseVisualStyleBackColor = false;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarCompra.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCompra.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCompra.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(6, 485);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Size = new System.Drawing.Size(184, 27);
            this.btnRegistrarCompra.TabIndex = 30;
            this.btnRegistrarCompra.Text = "REGISTRAR COMPRA";
            this.btnRegistrarCompra.UseVisualStyleBackColor = false;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxBusqueda.Controls.Add(this.gbxFiltro);
            this.gbxBusqueda.Controls.Add(this.btnActualizarCompra);
            this.gbxBusqueda.Controls.Add(this.btnEliminarCompra);
            this.gbxBusqueda.Controls.Add(this.btnBuscarProducto);
            this.gbxBusqueda.Controls.Add(this.dgvResBusquedaCompra);
            this.gbxBusqueda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxBusqueda.Location = new System.Drawing.Point(404, 45);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(664, 531);
            this.gbxBusqueda.TabIndex = 47;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Opciones";
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxFiltro.Controls.Add(this.cmbUsuarioEmpleado);
            this.gbxFiltro.Controls.Add(this.lblBusLote);
            this.gbxFiltro.Controls.Add(this.nudBusLote);
            this.gbxFiltro.Controls.Add(this.label12);
            this.gbxFiltro.Controls.Add(this.lblBusNombreProducto);
            this.gbxFiltro.Controls.Add(this.label11);
            this.gbxFiltro.Controls.Add(this.lblBusTipoProducto);
            this.gbxFiltro.Controls.Add(this.dtpFechaFinal);
            this.gbxFiltro.Controls.Add(this.cmbNombreProveedor);
            this.gbxFiltro.Controls.Add(this.dtpFechaInicial);
            this.gbxFiltro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxFiltro.Location = new System.Drawing.Point(14, 21);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(641, 100);
            this.gbxFiltro.TabIndex = 49;
            this.gbxFiltro.TabStop = false;
            this.gbxFiltro.Text = "Filtros";
            // 
            // cmbUsuarioEmpleado
            // 
            this.cmbUsuarioEmpleado.FormattingEnabled = true;
            this.cmbUsuarioEmpleado.Items.AddRange(new object[] {
            "Patente",
            "Generico",
            "Otros"});
            this.cmbUsuarioEmpleado.Location = new System.Drawing.Point(523, 19);
            this.cmbUsuarioEmpleado.Name = "cmbUsuarioEmpleado";
            this.cmbUsuarioEmpleado.Size = new System.Drawing.Size(112, 21);
            this.cmbUsuarioEmpleado.TabIndex = 3;
            // 
            // lblBusLote
            // 
            this.lblBusLote.AutoSize = true;
            this.lblBusLote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBusLote.Location = new System.Drawing.Point(9, 19);
            this.lblBusLote.Name = "lblBusLote";
            this.lblBusLote.Size = new System.Drawing.Size(93, 13);
            this.lblBusLote.TabIndex = 5;
            this.lblBusLote.Text = "Lote del producto:";
            // 
            // nudBusLote
            // 
            this.nudBusLote.Location = new System.Drawing.Point(108, 15);
            this.nudBusLote.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudBusLote.Name = "nudBusLote";
            this.nudBusLote.Size = new System.Drawing.Size(65, 20);
            this.nudBusLote.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(328, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Fecha de Final:";
            // 
            // lblBusNombreProducto
            // 
            this.lblBusNombreProducto.AutoSize = true;
            this.lblBusNombreProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBusNombreProducto.Location = new System.Drawing.Point(189, 19);
            this.lblBusNombreProducto.Name = "lblBusNombreProducto";
            this.lblBusNombreProducto.Size = new System.Drawing.Size(113, 13);
            this.lblBusNombreProducto.TabIndex = 8;
            this.lblBusNombreProducto.Text = "Nombre del Proveedor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(130, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Fecha de inicial:";
            // 
            // lblBusTipoProducto
            // 
            this.lblBusTipoProducto.AutoSize = true;
            this.lblBusTipoProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBusTipoProducto.Location = new System.Drawing.Point(411, 22);
            this.lblBusTipoProducto.Name = "lblBusTipoProducto";
            this.lblBusTipoProducto.Size = new System.Drawing.Size(112, 13);
            this.lblBusTipoProducto.TabIndex = 23;
            this.lblBusTipoProducto.Text = "Usuario del empleado:";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(414, 66);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaFinal.TabIndex = 5;
            // 
            // cmbNombreProveedor
            // 
            this.cmbNombreProveedor.FormattingEnabled = true;
            this.cmbNombreProveedor.Location = new System.Drawing.Point(308, 16);
            this.cmbNombreProveedor.Name = "cmbNombreProveedor";
            this.cmbNombreProveedor.Size = new System.Drawing.Size(104, 21);
            this.cmbNombreProveedor.TabIndex = 2;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(218, 66);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaInicial.TabIndex = 4;
            // 
            // btnActualizarCompra
            // 
            this.btnActualizarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizarCompra.FlatAppearance.BorderSize = 0;
            this.btnActualizarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnActualizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCompra.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCompra.ForeColor = System.Drawing.Color.Transparent;
            this.btnActualizarCompra.Location = new System.Drawing.Point(14, 485);
            this.btnActualizarCompra.Name = "btnActualizarCompra";
            this.btnActualizarCompra.Size = new System.Drawing.Size(211, 27);
            this.btnActualizarCompra.TabIndex = 48;
            this.btnActualizarCompra.Text = "ACTUALIZAR COMPRA";
            this.btnActualizarCompra.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCompra
            // 
            this.btnEliminarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarCompra.FlatAppearance.BorderSize = 0;
            this.btnEliminarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCompra.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCompra.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminarCompra.Location = new System.Drawing.Point(454, 485);
            this.btnEliminarCompra.Name = "btnEliminarCompra";
            this.btnEliminarCompra.Size = new System.Drawing.Size(204, 27);
            this.btnEliminarCompra.TabIndex = 47;
            this.btnEliminarCompra.Text = "ELIMINAR COMPRA";
            this.btnEliminarCompra.UseVisualStyleBackColor = false;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.Location = new System.Drawing.Point(14, 127);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(173, 27);
            this.btnBuscarProducto.TabIndex = 6;
            this.btnBuscarProducto.Text = "BUSCAR COMPRA";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // dgvResBusquedaCompra
            // 
            this.dgvResBusquedaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResBusquedaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResBusquedaCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lote,
            this.Nombre,
            this.Tipo,
            this.Descripcióndelproducto,
            this.Precio,
            this.Cantidad,
            this.PuntosParaCanjeo,
            this.PuntosDeCanjeo,
            this.FechaCad,
            this.ReqPatente,
            this.Status});
            this.dgvResBusquedaCompra.Location = new System.Drawing.Point(14, 160);
            this.dgvResBusquedaCompra.Name = "dgvResBusquedaCompra";
            this.dgvResBusquedaCompra.Size = new System.Drawing.Size(644, 302);
            this.dgvResBusquedaCompra.TabIndex = 25;
            // 
            // Lote
            // 
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Descripcióndelproducto
            // 
            this.Descripcióndelproducto.HeaderText = "Descripción del producto";
            this.Descripcióndelproducto.Name = "Descripcióndelproducto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PuntosParaCanjeo
            // 
            this.PuntosParaCanjeo.HeaderText = "Puntos para canjeo";
            this.PuntosParaCanjeo.Name = "PuntosParaCanjeo";
            // 
            // PuntosDeCanjeo
            // 
            this.PuntosDeCanjeo.HeaderText = "Puntos de canjeo";
            this.PuntosDeCanjeo.Name = "PuntosDeCanjeo";
            // 
            // FechaCad
            // 
            this.FechaCad.HeaderText = "Fecha de caducidad";
            this.FechaCad.Name = "FechaCad";
            // 
            // ReqPatente
            // 
            this.ReqPatente.HeaderText = "Requiere patente";
            this.ReqPatente.Name = "ReqPatente";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnCancelarCompra);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.gbxDatosCliente);
            this.groupBox2.Controls.Add(this.nudSubtotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnRegistrarCompra);
            this.groupBox2.Controls.Add(this.nudIva);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.NudTotal);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(9, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 531);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE COMPRA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(22, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Descripción:";
            // 
            // txtDescripcionProveedor
            // 
            this.txtDescripcionProveedor.Location = new System.Drawing.Point(94, 72);
            this.txtDescripcionProveedor.Multiline = true;
            this.txtDescripcionProveedor.Name = "txtDescripcionProveedor";
            this.txtDescripcionProveedor.Size = new System.Drawing.Size(248, 54);
            this.txtDescripcionProveedor.TabIndex = 42;
            // 
            // cmbNombre
            // 
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(94, 13);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(248, 21);
            this.cmbNombre.TabIndex = 46;
            // 
            // cmbTelefono
            // 
            this.cmbTelefono.FormattingEnabled = true;
            this.cmbTelefono.Location = new System.Drawing.Point(94, 45);
            this.cmbTelefono.Name = "cmbTelefono";
            this.cmbTelefono.Size = new System.Drawing.Size(248, 21);
            this.cmbTelefono.TabIndex = 47;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxBusqueda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompra";
            this.Text = "Compra";
            ((System.ComponentModel.ISupportInitialize)(this.nudSubtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudTotal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbxDatosCliente.ResumeLayout(false);
            this.gbxDatosCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLoteDeProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBusLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResBusquedaCompra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudIva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.ToolTip ttpHelp;
        private System.Windows.Forms.Timer tmrFech;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxDatosCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Button btnRegistrarCompra;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNombreProducto;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.Button btnEliminarCompra;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.ComboBox cmbNombreProveedor;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.DataGridView dgvResBusquedaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcióndelproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntosParaCanjeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntosDeCanjeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReqPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox cmbUsuarioEmpleado;
        private System.Windows.Forms.Label lblBusTipoProducto;
        private System.Windows.Forms.Label lblBusNombreProducto;
        private System.Windows.Forms.NumericUpDown nudBusLote;
        private System.Windows.Forms.Label lblBusLote;
        private System.Windows.Forms.Button btnActualizarCompra;
        private System.Windows.Forms.NumericUpDown nudLoteDeProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelarProveedor;
        private System.Windows.Forms.Button btnListoProveedor;
        private System.Windows.Forms.GroupBox gbxFiltro;
        private System.Windows.Forms.ComboBox cmbTelefono;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescripcionProveedor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}