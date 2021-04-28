
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
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductos = new System.Windows.Forms.Label();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.gbxDatosComun = new System.Windows.Forms.GroupBox();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbtnReqPantNo = new System.Windows.Forms.RadioButton();
            this.rbtnReqPantSi = new System.Windows.Forms.RadioButton();
            this.gbxEspecial = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaCad = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPuntosParaCanjeo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPuntosdeCanjeo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.cmbBusNombreProducto = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
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
            this.lblBusNombreProducto = new System.Windows.Forms.Label();
            this.nudBusLote = new System.Windows.Forms.NumericUpDown();
            this.lblBusLote = new System.Windows.Forms.Label();
            this.ttpHelp = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tmrFech = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.gbxDatosComun.SuspendLayout();
            this.gbxEspecial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosParaCanjeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosdeCanjeo)).BeginInit();
            this.gbxBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResBusquedaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBusLote)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(121, 79);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(171, 20);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreProducto.Location = new System.Drawing.Point(8, 82);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(109, 13);
            this.lblNombreProducto.TabIndex = 2;
            this.lblNombreProducto.Text = "Nombre del producto:";
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLote.Location = new System.Drawing.Point(84, 46);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(31, 13);
            this.lblLote.TabIndex = 3;
            this.lblLote.Text = "Lote:";
            // 
            // nudLote
            // 
            this.nudLote.Location = new System.Drawing.Point(121, 44);
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
            this.lblTipoProducto.Location = new System.Drawing.Point(31, 20);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(91, 13);
            this.lblTipoProducto.TabIndex = 6;
            this.lblTipoProducto.Text = "Tipo de producto:";
            // 
            // nudPrecio
            // 
            this.nudPrecio.Location = new System.Drawing.Point(121, 156);
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
            this.lblPrecioProducto.Location = new System.Drawing.Point(62, 158);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(55, 13);
            this.lblPrecioProducto.TabIndex = 9;
            this.lblPrecioProducto.Text = "Precio:   $";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(121, 194);
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
            this.lblCantidadProducto.Location = new System.Drawing.Point(71, 196);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(52, 13);
            this.lblCantidadProducto.TabIndex = 11;
            this.lblCantidadProducto.Text = "Cantidad:";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Items.AddRange(new object[] {
            "Patente",
            "Generico",
            "Otros"});
            this.cmbTipoProducto.Location = new System.Drawing.Point(121, 17);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(171, 21);
            this.cmbTipoProducto.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 33);
            this.panel1.TabIndex = 23;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductos.Location = new System.Drawing.Point(5, 6);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(137, 24);
            this.lblProductos.TabIndex = 24;
            this.lblProductos.Text = "PRODUCTOS";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDatos.Controls.Add(this.gbxDatosComun);
            this.gbxDatos.Controls.Add(this.gbxBusqueda);
            this.gbxDatos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxDatos.Location = new System.Drawing.Point(12, 39);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(1056, 537);
            this.gbxDatos.TabIndex = 24;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "DATOS";
            // 
            // gbxDatosComun
            // 
            this.gbxDatosComun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxDatosComun.Controls.Add(this.btnCancelarProducto);
            this.gbxDatosComun.Controls.Add(this.btnAgregar);
            this.gbxDatosComun.Controls.Add(this.rbtnReqPantNo);
            this.gbxDatosComun.Controls.Add(this.rbtnReqPantSi);
            this.gbxDatosComun.Controls.Add(this.gbxEspecial);
            this.gbxDatosComun.Controls.Add(this.label5);
            this.gbxDatosComun.Controls.Add(this.nudPuntosParaCanjeo);
            this.gbxDatosComun.Controls.Add(this.label2);
            this.gbxDatosComun.Controls.Add(this.nudPuntosdeCanjeo);
            this.gbxDatosComun.Controls.Add(this.label1);
            this.gbxDatosComun.Controls.Add(this.label3);
            this.gbxDatosComun.Controls.Add(this.rtxtDescripcion);
            this.gbxDatosComun.Controls.Add(this.label4);
            this.gbxDatosComun.Controls.Add(this.lblLote);
            this.gbxDatosComun.Controls.Add(this.nudCantidad);
            this.gbxDatosComun.Controls.Add(this.lblCantidadProducto);
            this.gbxDatosComun.Controls.Add(this.nudLote);
            this.gbxDatosComun.Controls.Add(this.txtNombreProducto);
            this.gbxDatosComun.Controls.Add(this.nudPrecio);
            this.gbxDatosComun.Controls.Add(this.cmbTipoProducto);
            this.gbxDatosComun.Controls.Add(this.lblNombreProducto);
            this.gbxDatosComun.Controls.Add(this.lblPrecioProducto);
            this.gbxDatosComun.Controls.Add(this.lblTipoProducto);
            this.gbxDatosComun.Location = new System.Drawing.Point(6, 19);
            this.gbxDatosComun.Name = "gbxDatosComun";
            this.gbxDatosComun.Size = new System.Drawing.Size(358, 512);
            this.gbxDatosComun.TabIndex = 31;
            this.gbxDatosComun.TabStop = false;
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
            this.btnCancelarProducto.Location = new System.Drawing.Point(5, 471);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(341, 27);
            this.btnCancelarProducto.TabIndex = 34;
            this.btnCancelarProducto.Text = "CANCELAR";
            this.btnCancelarProducto.UseVisualStyleBackColor = false;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Location = new System.Drawing.Point(5, 438);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(341, 27);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "AGREGAR PRODUCTO";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbtnReqPantNo
            // 
            this.rbtnReqPantNo.AutoSize = true;
            this.rbtnReqPantNo.Location = new System.Drawing.Point(212, 306);
            this.rbtnReqPantNo.Name = "rbtnReqPantNo";
            this.rbtnReqPantNo.Size = new System.Drawing.Size(41, 17);
            this.rbtnReqPantNo.TabIndex = 48;
            this.rbtnReqPantNo.TabStop = true;
            this.rbtnReqPantNo.Text = "NO";
            this.rbtnReqPantNo.UseVisualStyleBackColor = true;
            this.rbtnReqPantNo.CheckedChanged += new System.EventHandler(this.rbtnReqPantNo_CheckedChanged);
            // 
            // rbtnReqPantSi
            // 
            this.rbtnReqPantSi.AutoSize = true;
            this.rbtnReqPantSi.Location = new System.Drawing.Point(121, 306);
            this.rbtnReqPantSi.Name = "rbtnReqPantSi";
            this.rbtnReqPantSi.Size = new System.Drawing.Size(35, 17);
            this.rbtnReqPantSi.TabIndex = 47;
            this.rbtnReqPantSi.TabStop = true;
            this.rbtnReqPantSi.Text = "SI";
            this.rbtnReqPantSi.UseVisualStyleBackColor = true;
            this.rbtnReqPantSi.CheckedChanged += new System.EventHandler(this.rbtnReqPantSi_CheckedChanged);
            // 
            // gbxEspecial
            // 
            this.gbxEspecial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxEspecial.Controls.Add(this.radioButton2);
            this.gbxEspecial.Controls.Add(this.radioButton1);
            this.gbxEspecial.Controls.Add(this.label7);
            this.gbxEspecial.Controls.Add(this.dtpFechaCad);
            this.gbxEspecial.Controls.Add(this.label6);
            this.gbxEspecial.Location = new System.Drawing.Point(11, 321);
            this.gbxEspecial.Name = "gbxEspecial";
            this.gbxEspecial.Size = new System.Drawing.Size(341, 100);
            this.gbxEspecial.TabIndex = 32;
            this.gbxEspecial.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(187, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 17);
            this.radioButton2.TabIndex = 53;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "NO";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(128, 57);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 17);
            this.radioButton1.TabIndex = 52;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "SI";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(29, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Requiere Receta:";
            // 
            // dtpFechaCad
            // 
            this.dtpFechaCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCad.Location = new System.Drawing.Point(125, 19);
            this.dtpFechaCad.Name = "dtpFechaCad";
            this.dtpFechaCad.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaCad.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(11, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Fecha de caducidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(27, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Articulo Especial:";
            // 
            // nudPuntosParaCanjeo
            // 
            this.nudPuntosParaCanjeo.Location = new System.Drawing.Point(121, 269);
            this.nudPuntosParaCanjeo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPuntosParaCanjeo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPuntosParaCanjeo.Name = "nudPuntosParaCanjeo";
            this.nudPuntosParaCanjeo.Size = new System.Drawing.Size(171, 20);
            this.nudPuntosParaCanjeo.TabIndex = 45;
            this.nudPuntosParaCanjeo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(11, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Puntos Para Canjeo:";
            // 
            // nudPuntosdeCanjeo
            // 
            this.nudPuntosdeCanjeo.Location = new System.Drawing.Point(121, 231);
            this.nudPuntosdeCanjeo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPuntosdeCanjeo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPuntosdeCanjeo.Name = "nudPuntosdeCanjeo";
            this.nudPuntosdeCanjeo.Size = new System.Drawing.Size(171, 20);
            this.nudPuntosdeCanjeo.TabIndex = 43;
            this.nudPuntosdeCanjeo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(38, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Puntos Canjeo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(126, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "100/100";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.Location = new System.Drawing.Point(121, 105);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(171, 26);
            this.rtxtDescripcion.TabIndex = 40;
            this.rtxtDescripcion.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(49, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Descripción:";
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxBusqueda.Controls.Add(this.cmbBusNombreProducto);
            this.gbxBusqueda.Controls.Add(this.btnEliminar);
            this.gbxBusqueda.Controls.Add(this.btnBuscarProducto);
            this.gbxBusqueda.Controls.Add(this.btnActualizar);
            this.gbxBusqueda.Controls.Add(this.dgvResBusquedaProd);
            this.gbxBusqueda.Controls.Add(this.cmbBusTipoProducto);
            this.gbxBusqueda.Controls.Add(this.lblBusTipoProducto);
            this.gbxBusqueda.Controls.Add(this.lblBusNombreProducto);
            this.gbxBusqueda.Controls.Add(this.nudBusLote);
            this.gbxBusqueda.Controls.Add(this.lblBusLote);
            this.gbxBusqueda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxBusqueda.Location = new System.Drawing.Point(373, 16);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(670, 515);
            this.gbxBusqueda.TabIndex = 25;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Opciones";
            // 
            // cmbBusNombreProducto
            // 
            this.cmbBusNombreProducto.FormattingEnabled = true;
            this.cmbBusNombreProducto.Location = new System.Drawing.Point(273, 31);
            this.cmbBusNombreProducto.Name = "cmbBusNombreProducto";
            this.cmbBusNombreProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbBusNombreProducto.TabIndex = 27;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Location = new System.Drawing.Point(429, 474);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(235, 27);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "ELIMINAR PRODUCTO";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.Location = new System.Drawing.Point(17, 89);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(173, 27);
            this.btnBuscarProducto.TabIndex = 26;
            this.btnBuscarProducto.Text = "BUSCAR PRODUCTO";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnActualizar.Location = new System.Drawing.Point(17, 474);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(250, 27);
            this.btnActualizar.TabIndex = 29;
            this.btnActualizar.Text = "ACTUALIZAR PRODUCTO";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // dgvResBusquedaProd
            // 
            this.dgvResBusquedaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvResBusquedaProd.Location = new System.Drawing.Point(14, 122);
            this.dgvResBusquedaProd.Name = "dgvResBusquedaProd";
            this.dgvResBusquedaProd.Size = new System.Drawing.Size(650, 323);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 582);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 33);
            this.panel2.TabIndex = 26;
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
            // tmrFech
            // 
            this.tmrFech.Enabled = true;
            this.tmrFech.Tick += new System.EventHandler(this.tmrFech_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducto";
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.nudLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatosComun.ResumeLayout(false);
            this.gbxDatosComun.PerformLayout();
            this.gbxEspecial.ResumeLayout(false);
            this.gbxEspecial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosParaCanjeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntosdeCanjeo)).EndInit();
            this.gbxBusqueda.ResumeLayout(false);
            this.gbxBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResBusquedaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBusLote)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.NumericUpDown nudLote;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.DataGridView dgvResBusquedaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.ComboBox cmbBusTipoProducto;
        private System.Windows.Forms.Label lblBusTipoProducto;
        private System.Windows.Forms.Label lblBusNombreProducto;
        private System.Windows.Forms.NumericUpDown nudBusLote;
        private System.Windows.Forms.Label lblBusLote;
        private System.Windows.Forms.ToolTip ttpHelp;
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
        private System.Windows.Forms.Timer tmrFech;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbBusNombreProducto;
        private System.Windows.Forms.GroupBox gbxDatosComun;
        private System.Windows.Forms.RadioButton rbtnReqPantNo;
        private System.Windows.Forms.RadioButton rbtnReqPantSi;
        private System.Windows.Forms.NumericUpDown nudPuntosParaCanjeo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPuntosdeCanjeo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxEspecial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaCad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}