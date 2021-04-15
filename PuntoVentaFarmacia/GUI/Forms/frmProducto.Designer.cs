
namespace GUI
{
    partial class frmProducto
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
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.nudLote = new System.Windows.Forms.NumericUpDown();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblDesProducto = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.nudPuntosParaCanjeo = new System.Windows.Forms.NumericUpDown();
            this.lblPunParaCanjeo = new System.Windows.Forms.Label();
            this.nudPuntosdeCanjeo = new System.Windows.Forms.NumericUpDown();
            this.lblPunDeCanjeo = new System.Windows.Forms.Label();
            this.lblFechaCad = new System.Windows.Forms.Label();
            this.lblReqReceta = new System.Windows.Forms.Label();
            this.dtpFechaCad = new System.Windows.Forms.DateTimePicker();
            this.rbtnReqPantSi = new System.Windows.Forms.RadioButton();
            this.rbtnReqPantNo = new System.Windows.Forms.RadioButton();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.blProductos = new System.Windows.Forms.Label();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.btnIngresarInfo = new System.Windows.Forms.Button();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.dgvResBusquedaProd = new System.Windows.Forms.DataGridView();
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
            this.cmbBusTipoProducto = new System.Windows.Forms.ComboBox();
            this.lblBusTipoProducto = new System.Windows.Forms.Label();
            this.txtBusNombreProducto = new System.Windows.Forms.TextBox();
            this.lblBusNombreProducto = new System.Windows.Forms.Label();
            this.nudBusLote = new System.Windows.Forms.NumericUpDown();
            this.lblBusLote = new System.Windows.Forms.Label();
            this.ttpHelp = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tmrFech = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosParaCanjeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosdeCanjeo)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.gbxBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResBusquedaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBusLote)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(155, 60);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(171, 20);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreProducto.Location = new System.Drawing.Point(23, 63);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(109, 13);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Nombre del producto:";
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLote.Location = new System.Drawing.Point(101, 21);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(31, 13);
            this.lblLote.TabIndex = 3;
            this.lblLote.Text = "Lote:";
            // 
            // nudLote
            // 
            this.nudLote.Location = new System.Drawing.Point(155, 19);
            this.nudLote.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudLote.Name = "nudLote";
            this.nudLote.Size = new System.Drawing.Size(171, 20);
            this.nudLote.TabIndex = 4;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTipoProducto.Location = new System.Drawing.Point(41, 102);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(91, 13);
            this.lblTipoProducto.TabIndex = 6;
            this.lblTipoProducto.Text = "Tipo de producto:";
            // 
            // lblDesProducto
            // 
            this.lblDesProducto.AutoSize = true;
            this.lblDesProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDesProducto.Location = new System.Drawing.Point(4, 143);
            this.lblDesProducto.Name = "lblDesProducto";
            this.lblDesProducto.Size = new System.Drawing.Size(128, 13);
            this.lblDesProducto.TabIndex = 8;
            this.lblDesProducto.Text = "Descripción del producto:";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(155, 140);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(171, 20);
            this.txtDescripcionProducto.TabIndex = 7;
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(155, 183);
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
            this.nudPrecio.Size = new System.Drawing.Size(171, 20);
            this.nudPrecio.TabIndex = 10;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecioProducto.Location = new System.Drawing.Point(94, 185);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(55, 13);
            this.lblPrecioProducto.TabIndex = 9;
            this.lblPrecioProducto.Text = "Precio:   $";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(155, 223);
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
            this.nudCantidad.Size = new System.Drawing.Size(171, 20);
            this.nudCantidad.TabIndex = 12;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCantidadProducto.Location = new System.Drawing.Point(80, 230);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(52, 13);
            this.lblCantidadProducto.TabIndex = 11;
            this.lblCantidadProducto.Text = "Cantidad:";
            // 
            // nudPuntosParaCanjeo
            // 
            this.nudPuntosParaCanjeo.Location = new System.Drawing.Point(155, 307);
            this.nudPuntosParaCanjeo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPuntosParaCanjeo.Name = "nudPuntosParaCanjeo";
            this.nudPuntosParaCanjeo.Size = new System.Drawing.Size(171, 20);
            this.nudPuntosParaCanjeo.TabIndex = 16;
            // 
            // lblPunParaCanjeo
            // 
            this.lblPunParaCanjeo.AutoSize = true;
            this.lblPunParaCanjeo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPunParaCanjeo.Location = new System.Drawing.Point(30, 309);
            this.lblPunParaCanjeo.Name = "lblPunParaCanjeo";
            this.lblPunParaCanjeo.Size = new System.Drawing.Size(102, 13);
            this.lblPunParaCanjeo.TabIndex = 15;
            this.lblPunParaCanjeo.Text = "Puntos para canjeo:";
            // 
            // nudPuntosdeCanjeo
            // 
            this.nudPuntosdeCanjeo.Location = new System.Drawing.Point(155, 267);
            this.nudPuntosdeCanjeo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPuntosdeCanjeo.Name = "nudPuntosdeCanjeo";
            this.nudPuntosdeCanjeo.Size = new System.Drawing.Size(171, 20);
            this.nudPuntosdeCanjeo.TabIndex = 14;
            // 
            // lblPunDeCanjeo
            // 
            this.lblPunDeCanjeo.AutoSize = true;
            this.lblPunDeCanjeo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPunDeCanjeo.Location = new System.Drawing.Point(39, 274);
            this.lblPunDeCanjeo.Name = "lblPunDeCanjeo";
            this.lblPunDeCanjeo.Size = new System.Drawing.Size(93, 13);
            this.lblPunDeCanjeo.TabIndex = 13;
            this.lblPunDeCanjeo.Text = "Puntos de canjeo:";
            // 
            // lblFechaCad
            // 
            this.lblFechaCad.AutoSize = true;
            this.lblFechaCad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFechaCad.Location = new System.Drawing.Point(24, 358);
            this.lblFechaCad.Name = "lblFechaCad";
            this.lblFechaCad.Size = new System.Drawing.Size(108, 13);
            this.lblFechaCad.TabIndex = 17;
            this.lblFechaCad.Text = "Fecha de caducidad:";
            // 
            // lblReqReceta
            // 
            this.lblReqReceta.AutoSize = true;
            this.lblReqReceta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReqReceta.Location = new System.Drawing.Point(38, 401);
            this.lblReqReceta.Name = "lblReqReceta";
            this.lblReqReceta.Size = new System.Drawing.Size(92, 13);
            this.lblReqReceta.TabIndex = 18;
            this.lblReqReceta.Text = "Requiere patente:";
            // 
            // dtpFechaCad
            // 
            this.dtpFechaCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCad.Location = new System.Drawing.Point(155, 352);
            this.dtpFechaCad.MaxDate = new System.DateTime(2021, 3, 14, 0, 0, 0, 0);
            this.dtpFechaCad.Name = "dtpFechaCad";
            this.dtpFechaCad.Size = new System.Drawing.Size(171, 20);
            this.dtpFechaCad.TabIndex = 19;
            this.dtpFechaCad.Value = new System.DateTime(2021, 3, 14, 0, 0, 0, 0);
            // 
            // rbtnReqPantSi
            // 
            this.rbtnReqPantSi.AutoSize = true;
            this.rbtnReqPantSi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnReqPantSi.Location = new System.Drawing.Point(153, 399);
            this.rbtnReqPantSi.Name = "rbtnReqPantSi";
            this.rbtnReqPantSi.Size = new System.Drawing.Size(34, 17);
            this.rbtnReqPantSi.TabIndex = 20;
            this.rbtnReqPantSi.TabStop = true;
            this.rbtnReqPantSi.Text = "Si";
            this.rbtnReqPantSi.UseVisualStyleBackColor = true;
            // 
            // rbtnReqPantNo
            // 
            this.rbtnReqPantNo.AutoSize = true;
            this.rbtnReqPantNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnReqPantNo.Location = new System.Drawing.Point(273, 401);
            this.rbtnReqPantNo.Name = "rbtnReqPantNo";
            this.rbtnReqPantNo.Size = new System.Drawing.Size(39, 17);
            this.rbtnReqPantNo.TabIndex = 21;
            this.rbtnReqPantNo.TabStop = true;
            this.rbtnReqPantNo.Text = "No";
            this.rbtnReqPantNo.UseVisualStyleBackColor = true;
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Items.AddRange(new object[] {
            "Patente",
            "Generico",
            "Otros"});
            this.cmbTipoProducto.Location = new System.Drawing.Point(155, 94);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(171, 21);
            this.cmbTipoProducto.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.blProductos);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 33);
            this.panel1.TabIndex = 23;
            // 
            // blProductos
            // 
            this.blProductos.AutoSize = true;
            this.blProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.blProductos.Location = new System.Drawing.Point(5, 6);
            this.blProductos.Name = "blProductos";
            this.blProductos.Size = new System.Drawing.Size(104, 24);
            this.blProductos.TabIndex = 24;
            this.blProductos.Text = "Productos";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.btnIngresarInfo);
            this.gbxDatos.Controls.Add(this.nudLote);
            this.gbxDatos.Controls.Add(this.txtNombreProducto);
            this.gbxDatos.Controls.Add(this.cmbTipoProducto);
            this.gbxDatos.Controls.Add(this.lblNombreProducto);
            this.gbxDatos.Controls.Add(this.rbtnReqPantNo);
            this.gbxDatos.Controls.Add(this.lblLote);
            this.gbxDatos.Controls.Add(this.rbtnReqPantSi);
            this.gbxDatos.Controls.Add(this.lblTipoProducto);
            this.gbxDatos.Controls.Add(this.dtpFechaCad);
            this.gbxDatos.Controls.Add(this.txtDescripcionProducto);
            this.gbxDatos.Controls.Add(this.lblReqReceta);
            this.gbxDatos.Controls.Add(this.lblDesProducto);
            this.gbxDatos.Controls.Add(this.lblFechaCad);
            this.gbxDatos.Controls.Add(this.lblPrecioProducto);
            this.gbxDatos.Controls.Add(this.nudPuntosParaCanjeo);
            this.gbxDatos.Controls.Add(this.nudPrecio);
            this.gbxDatos.Controls.Add(this.lblPunParaCanjeo);
            this.gbxDatos.Controls.Add(this.lblCantidadProducto);
            this.gbxDatos.Controls.Add(this.nudPuntosdeCanjeo);
            this.gbxDatos.Controls.Add(this.nudCantidad);
            this.gbxDatos.Controls.Add(this.lblPunDeCanjeo);
            this.gbxDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxDatos.Location = new System.Drawing.Point(12, 59);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(357, 501);
            this.gbxDatos.TabIndex = 24;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "DATOS";
            // 
            // btnIngresarInfo
            // 
            this.btnIngresarInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngresarInfo.FlatAppearance.BorderSize = 0;
            this.btnIngresarInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnIngresarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarInfo.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarInfo.ForeColor = System.Drawing.Color.Transparent;
            this.btnIngresarInfo.Location = new System.Drawing.Point(124, 466);
            this.btnIngresarInfo.Name = "btnIngresarInfo";
            this.btnIngresarInfo.Size = new System.Drawing.Size(227, 27);
            this.btnIngresarInfo.TabIndex = 23;
            this.btnIngresarInfo.Text = "INGRESAR INFORMACIÓN ";
            this.btnIngresarInfo.UseVisualStyleBackColor = false;
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.btnBuscarProducto);
            this.gbxBusqueda.Controls.Add(this.dgvResBusquedaProd);
            this.gbxBusqueda.Controls.Add(this.cmbBusTipoProducto);
            this.gbxBusqueda.Controls.Add(this.lblBusTipoProducto);
            this.gbxBusqueda.Controls.Add(this.txtBusNombreProducto);
            this.gbxBusqueda.Controls.Add(this.lblBusNombreProducto);
            this.gbxBusqueda.Controls.Add(this.nudBusLote);
            this.gbxBusqueda.Controls.Add(this.lblBusLote);
            this.gbxBusqueda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxBusqueda.Location = new System.Drawing.Point(388, 59);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(670, 501);
            this.gbxBusqueda.TabIndex = 25;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Busqueda";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.Location = new System.Drawing.Point(26, 86);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(173, 27);
            this.btnBuscarProducto.TabIndex = 26;
            this.btnBuscarProducto.Text = "BUSCAR PRODUCTO";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // dgvResBusquedaProd
            // 
            this.dgvResBusquedaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResBusquedaProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvResBusquedaProd.Location = new System.Drawing.Point(6, 139);
            this.dgvResBusquedaProd.Name = "dgvResBusquedaProd";
            this.dgvResBusquedaProd.Size = new System.Drawing.Size(650, 104);
            this.dgvResBusquedaProd.TabIndex = 25;
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
            // cmbBusTipoProducto
            // 
            this.cmbBusTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusTipoProducto.FormattingEnabled = true;
            this.cmbBusTipoProducto.Items.AddRange(new object[] {
            "Patente",
            "Generico",
            "Otros"});
            this.cmbBusTipoProducto.Location = new System.Drawing.Point(503, 30);
            this.cmbBusTipoProducto.Name = "cmbBusTipoProducto";
            this.cmbBusTipoProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbBusTipoProducto.TabIndex = 24;
            // 
            // lblBusTipoProducto
            // 
            this.lblBusTipoProducto.AutoSize = true;
            this.lblBusTipoProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBusTipoProducto.Location = new System.Drawing.Point(406, 34);
            this.lblBusTipoProducto.Name = "lblBusTipoProducto";
            this.lblBusTipoProducto.Size = new System.Drawing.Size(91, 13);
            this.lblBusTipoProducto.TabIndex = 23;
            this.lblBusTipoProducto.Text = "Tipo de producto:";
            // 
            // txtBusNombreProducto
            // 
            this.txtBusNombreProducto.Location = new System.Drawing.Point(290, 31);
            this.txtBusNombreProducto.Name = "txtBusNombreProducto";
            this.txtBusNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.txtBusNombreProducto.TabIndex = 7;
            // 
            // lblBusNombreProducto
            // 
            this.lblBusNombreProducto.AutoSize = true;
            this.lblBusNombreProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBusNombreProducto.Location = new System.Drawing.Point(158, 34);
            this.lblBusNombreProducto.Name = "lblBusNombreProducto";
            this.lblBusNombreProducto.Size = new System.Drawing.Size(109, 13);
            this.lblBusNombreProducto.TabIndex = 8;
            this.lblBusNombreProducto.Text = "Nombre del producto:";
            // 
            // nudBusLote
            // 
            this.nudBusLote.Location = new System.Drawing.Point(68, 32);
            this.nudBusLote.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudBusLote.Name = "nudBusLote";
            this.nudBusLote.Size = new System.Drawing.Size(65, 20);
            this.nudBusLote.TabIndex = 6;
            // 
            // lblBusLote
            // 
            this.lblBusLote.AutoSize = true;
            this.lblBusLote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBusLote.Location = new System.Drawing.Point(14, 34);
            this.lblBusLote.Name = "lblBusLote";
            this.lblBusLote.Size = new System.Drawing.Size(31, 13);
            this.lblBusLote.TabIndex = 5;
            this.lblBusLote.Text = "Lote:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Location = new System.Drawing.Point(3, 581);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 33);
            this.panel2.TabIndex = 26;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(5, 6);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(158, 24);
            this.lblUsuario.TabIndex = 24;
            this.lblUsuario.Text = "Usuario: ADMIN";
            // 
            // tmrFech
            // 
            this.tmrFech.Enabled = true;
            this.tmrFech.Tick += new System.EventHandler(this.tmrFech_Tick);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbxBusqueda);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Producto";
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.nudLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosParaCanjeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosdeCanjeo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResBusquedaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBusLote)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.NumericUpDown nudLote;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblDesProducto;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.NumericUpDown nudPuntosParaCanjeo;
        private System.Windows.Forms.Label lblPunParaCanjeo;
        private System.Windows.Forms.NumericUpDown nudPuntosdeCanjeo;
        private System.Windows.Forms.Label lblPunDeCanjeo;
        private System.Windows.Forms.Label lblFechaCad;
        private System.Windows.Forms.Label lblReqReceta;
        private System.Windows.Forms.DateTimePicker dtpFechaCad;
        private System.Windows.Forms.RadioButton rbtnReqPantSi;
        private System.Windows.Forms.RadioButton rbtnReqPantNo;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label blProductos;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.DataGridView dgvResBusquedaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.ComboBox cmbBusTipoProducto;
        private System.Windows.Forms.Label lblBusTipoProducto;
        private System.Windows.Forms.TextBox txtBusNombreProducto;
        private System.Windows.Forms.Label lblBusNombreProducto;
        private System.Windows.Forms.NumericUpDown nudBusLote;
        private System.Windows.Forms.Label lblBusLote;
        private System.Windows.Forms.ToolTip ttpHelp;
        private System.Windows.Forms.Button btnIngresarInfo;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcióndelproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntosParaCanjeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntosDeCanjeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReqPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Timer tmrFech;
    }
}