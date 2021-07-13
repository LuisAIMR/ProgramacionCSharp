
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblProductos = new System.Windows.Forms.Label();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.gbxTipoProducto = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btActualizarTipo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarTipoProducto = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmbAgregarTipo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxDatosComun = new System.Windows.Forms.GroupBox();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbtnEspecialNo = new System.Windows.Forms.RadioButton();
            this.rbtnEspecialSi = new System.Windows.Forms.RadioButton();
            this.gbxEspecial = new System.Windows.Forms.GroupBox();
            this.rbtnReqPantNo = new System.Windows.Forms.RadioButton();
            this.rbtnReqPantSi = new System.Windows.Forms.RadioButton();
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
            this.dgvResBusquedaProd = new System.Windows.Forms.DataGridView();
            this.cmbBusNombreProducto = new System.Windows.Forms.ComboBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
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
            this.lblIdProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.gbxTipoProducto.SuspendLayout();
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
            this.nudLote.ValueChanged += new System.EventHandler(this.nudLote_ValueChanged);
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
            100000,
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
            ""});
            this.cmbTipoProducto.Location = new System.Drawing.Point(121, 17);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(171, 21);
            this.cmbTipoProducto.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.lblIdProducto);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.lblProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 33);
            this.panel1.TabIndex = 23;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(186, 19);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 13);
            this.lblTipo.TabIndex = 25;
            this.lblTipo.Visible = false;
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
            this.gbxDatos.Controls.Add(this.gbxTipoProducto);
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
            // gbxTipoProducto
            // 
            this.gbxTipoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTipoProducto.Controls.Add(this.button4);
            this.gbxTipoProducto.Controls.Add(this.btActualizarTipo);
            this.gbxTipoProducto.Controls.Add(this.button3);
            this.gbxTipoProducto.Controls.Add(this.button1);
            this.gbxTipoProducto.Controls.Add(this.btnAgregarTipoProducto);
            this.gbxTipoProducto.Controls.Add(this.comboBox2);
            this.gbxTipoProducto.Controls.Add(this.cmbAgregarTipo);
            this.gbxTipoProducto.Controls.Add(this.label8);
            this.gbxTipoProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxTipoProducto.Location = new System.Drawing.Point(373, 19);
            this.gbxTipoProducto.Name = "gbxTipoProducto";
            this.gbxTipoProducto.Size = new System.Drawing.Size(670, 91);
            this.gbxTipoProducto.TabIndex = 32;
            this.gbxTipoProducto.TabStop = false;
            this.gbxTipoProducto.Text = "Tipo de producto";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(503, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 27);
            this.button4.TabIndex = 56;
            this.button4.Text = "ELIMINAR";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btActualizarTipo
            // 
            this.btActualizarTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btActualizarTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btActualizarTipo.FlatAppearance.BorderSize = 0;
            this.btActualizarTipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btActualizarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActualizarTipo.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizarTipo.ForeColor = System.Drawing.Color.Transparent;
            this.btActualizarTipo.Location = new System.Drawing.Point(503, 17);
            this.btActualizarTipo.Name = "btActualizarTipo";
            this.btActualizarTipo.Size = new System.Drawing.Size(152, 27);
            this.btActualizarTipo.TabIndex = 55;
            this.btActualizarTipo.Text = "ACTUALIZAR";
            this.btActualizarTipo.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(369, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 27);
            this.button3.TabIndex = 54;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(223, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 27);
            this.button1.TabIndex = 52;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAgregarTipoProducto
            // 
            this.btnAgregarTipoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarTipoProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarTipoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnAgregarTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTipoProducto.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTipoProducto.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgregarTipoProducto.Location = new System.Drawing.Point(82, 52);
            this.btnAgregarTipoProducto.Name = "btnAgregarTipoProducto";
            this.btnAgregarTipoProducto.Size = new System.Drawing.Size(135, 27);
            this.btnAgregarTipoProducto.TabIndex = 51;
            this.btnAgregarTipoProducto.Text = "AGREGAR TIPO";
            this.btnAgregarTipoProducto.UseVisualStyleBackColor = false;
            this.btnAgregarTipoProducto.Click += new System.EventHandler(this.btnAgregarTipoProducto_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Patente",
            "Generico",
            "Otros"});
            this.comboBox2.Location = new System.Drawing.Point(393, -381);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 21);
            this.comboBox2.TabIndex = 53;
            // 
            // cmbAgregarTipo
            // 
            this.cmbAgregarTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAgregarTipo.FormattingEnabled = true;
            this.cmbAgregarTipo.Items.AddRange(new object[] {
            "Patente",
            "Generico",
            "Otros"});
            this.cmbAgregarTipo.Location = new System.Drawing.Point(82, 18);
            this.cmbAgregarTipo.Name = "cmbAgregarTipo";
            this.cmbAgregarTipo.Size = new System.Drawing.Size(281, 21);
            this.cmbAgregarTipo.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(4, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Tipo deL tipo:";
            // 
            // gbxDatosComun
            // 
            this.gbxDatosComun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxDatosComun.Controls.Add(this.btnCancelarProducto);
            this.gbxDatosComun.Controls.Add(this.btnAgregar);
            this.gbxDatosComun.Controls.Add(this.rbtnEspecialNo);
            this.gbxDatosComun.Controls.Add(this.rbtnEspecialSi);
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
            // rbtnEspecialNo
            // 
            this.rbtnEspecialNo.AutoSize = true;
            this.rbtnEspecialNo.Location = new System.Drawing.Point(212, 306);
            this.rbtnEspecialNo.Name = "rbtnEspecialNo";
            this.rbtnEspecialNo.Size = new System.Drawing.Size(41, 17);
            this.rbtnEspecialNo.TabIndex = 48;
            this.rbtnEspecialNo.TabStop = true;
            this.rbtnEspecialNo.Text = "NO";
            this.rbtnEspecialNo.UseVisualStyleBackColor = true;
            this.rbtnEspecialNo.CheckedChanged += new System.EventHandler(this.rbtnReqPantNo_CheckedChanged);
            // 
            // rbtnEspecialSi
            // 
            this.rbtnEspecialSi.AutoSize = true;
            this.rbtnEspecialSi.Location = new System.Drawing.Point(121, 306);
            this.rbtnEspecialSi.Name = "rbtnEspecialSi";
            this.rbtnEspecialSi.Size = new System.Drawing.Size(35, 17);
            this.rbtnEspecialSi.TabIndex = 47;
            this.rbtnEspecialSi.Text = "SI";
            this.rbtnEspecialSi.UseVisualStyleBackColor = true;
            this.rbtnEspecialSi.CheckedChanged += new System.EventHandler(this.rbtnReqPantSi_CheckedChanged);
            // 
            // gbxEspecial
            // 
            this.gbxEspecial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxEspecial.Controls.Add(this.rbtnReqPantNo);
            this.gbxEspecial.Controls.Add(this.rbtnReqPantSi);
            this.gbxEspecial.Controls.Add(this.label7);
            this.gbxEspecial.Controls.Add(this.dtpFechaCad);
            this.gbxEspecial.Controls.Add(this.label6);
            this.gbxEspecial.Location = new System.Drawing.Point(11, 321);
            this.gbxEspecial.Name = "gbxEspecial";
            this.gbxEspecial.Size = new System.Drawing.Size(341, 100);
            this.gbxEspecial.TabIndex = 32;
            this.gbxEspecial.TabStop = false;
            // 
            // rbtnReqPantNo
            // 
            this.rbtnReqPantNo.AutoSize = true;
            this.rbtnReqPantNo.Location = new System.Drawing.Point(187, 57);
            this.rbtnReqPantNo.Name = "rbtnReqPantNo";
            this.rbtnReqPantNo.Size = new System.Drawing.Size(41, 17);
            this.rbtnReqPantNo.TabIndex = 53;
            this.rbtnReqPantNo.TabStop = true;
            this.rbtnReqPantNo.Text = "NO";
            this.rbtnReqPantNo.UseVisualStyleBackColor = true;
            // 
            // rbtnReqPantSi
            // 
            this.rbtnReqPantSi.AutoSize = true;
            this.rbtnReqPantSi.Location = new System.Drawing.Point(128, 57);
            this.rbtnReqPantSi.Name = "rbtnReqPantSi";
            this.rbtnReqPantSi.Size = new System.Drawing.Size(35, 17);
            this.rbtnReqPantSi.TabIndex = 52;
            this.rbtnReqPantSi.TabStop = true;
            this.rbtnReqPantSi.Text = "SI";
            this.rbtnReqPantSi.UseVisualStyleBackColor = true;
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
            100000,
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
            100000,
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
            this.gbxBusqueda.Controls.Add(this.dgvResBusquedaProd);
            this.gbxBusqueda.Controls.Add(this.cmbBusNombreProducto);
            this.gbxBusqueda.Controls.Add(this.btnEliminarProducto);
            this.gbxBusqueda.Controls.Add(this.btnBuscarProducto);
            this.gbxBusqueda.Controls.Add(this.btnActualizarProducto);
            this.gbxBusqueda.Controls.Add(this.cmbBusTipoProducto);
            this.gbxBusqueda.Controls.Add(this.lblBusTipoProducto);
            this.gbxBusqueda.Controls.Add(this.lblBusNombreProducto);
            this.gbxBusqueda.Controls.Add(this.nudBusLote);
            this.gbxBusqueda.Controls.Add(this.lblBusLote);
            this.gbxBusqueda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxBusqueda.Location = new System.Drawing.Point(373, 116);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(670, 415);
            this.gbxBusqueda.TabIndex = 25;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Opciones";
            // 
            // dgvResBusquedaProd
            // 
            this.dgvResBusquedaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResBusquedaProd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvResBusquedaProd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResBusquedaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResBusquedaProd.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvResBusquedaProd.Location = new System.Drawing.Point(14, 109);
            this.dgvResBusquedaProd.Name = "dgvResBusquedaProd";
            this.dgvResBusquedaProd.Size = new System.Drawing.Size(650, 259);
            this.dgvResBusquedaProd.TabIndex = 30;
            this.dgvResBusquedaProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResBusquedaProd_CellContentClick);
            // 
            // cmbBusNombreProducto
            // 
            this.cmbBusNombreProducto.FormattingEnabled = true;
            this.cmbBusNombreProducto.Location = new System.Drawing.Point(279, 30);
            this.cmbBusNombreProducto.Name = "cmbBusNombreProducto";
            this.cmbBusNombreProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbBusNombreProducto.TabIndex = 27;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarProducto.FlatAppearance.BorderSize = 0;
            this.btnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminarProducto.Location = new System.Drawing.Point(429, 374);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(235, 27);
            this.btnEliminarProducto.TabIndex = 28;
            this.btnEliminarProducto.Text = "ELIMINAR PRODUCTO";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.Location = new System.Drawing.Point(14, 76);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(173, 27);
            this.btnBuscarProducto.TabIndex = 26;
            this.btnBuscarProducto.Text = "BUSCAR PRODUCTO";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizarProducto.FlatAppearance.BorderSize = 0;
            this.btnActualizarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarProducto.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProducto.ForeColor = System.Drawing.Color.Transparent;
            this.btnActualizarProducto.Location = new System.Drawing.Point(17, 374);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(250, 27);
            this.btnActualizarProducto.TabIndex = 29;
            this.btnActualizarProducto.Text = "ACTUALIZAR PRODUCTO";
            this.btnActualizarProducto.UseVisualStyleBackColor = false;
            // 
            // cmbBusTipoProducto
            // 
            this.cmbBusTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusTipoProducto.FormattingEnabled = true;
            this.cmbBusTipoProducto.Items.AddRange(new object[] {
            "Patente",
            "Generico",
            "Otros"});
            this.cmbBusTipoProducto.Location = new System.Drawing.Point(509, 29);
            this.cmbBusTipoProducto.Name = "cmbBusTipoProducto";
            this.cmbBusTipoProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbBusTipoProducto.TabIndex = 24;
            // 
            // lblBusTipoProducto
            // 
            this.lblBusTipoProducto.AutoSize = true;
            this.lblBusTipoProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBusTipoProducto.Location = new System.Drawing.Point(412, 33);
            this.lblBusTipoProducto.Name = "lblBusTipoProducto";
            this.lblBusTipoProducto.Size = new System.Drawing.Size(91, 13);
            this.lblBusTipoProducto.TabIndex = 23;
            this.lblBusTipoProducto.Text = "Tipo de producto:";
            // 
            // lblBusNombreProducto
            // 
            this.lblBusNombreProducto.AutoSize = true;
            this.lblBusNombreProducto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBusNombreProducto.Location = new System.Drawing.Point(164, 33);
            this.lblBusNombreProducto.Name = "lblBusNombreProducto";
            this.lblBusNombreProducto.Size = new System.Drawing.Size(109, 13);
            this.lblBusNombreProducto.TabIndex = 8;
            this.lblBusNombreProducto.Text = "Nombre del producto:";
            // 
            // nudBusLote
            // 
            this.nudBusLote.Location = new System.Drawing.Point(74, 31);
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
            this.lblBusLote.Location = new System.Drawing.Point(20, 33);
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
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(286, 14);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(35, 13);
            this.lblIdProducto.TabIndex = 26;
            this.lblIdProducto.Text = "label9";
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
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbxDatos.ResumeLayout(false);
            this.gbxTipoProducto.ResumeLayout(false);
            this.gbxTipoProducto.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbBusTipoProducto;
        private System.Windows.Forms.Label lblBusTipoProducto;
        private System.Windows.Forms.Label lblBusNombreProducto;
        private System.Windows.Forms.NumericUpDown nudBusLote;
        private System.Windows.Forms.Label lblBusLote;
        private System.Windows.Forms.ToolTip ttpHelp;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer tmrFech;
        private System.Windows.Forms.Button btnActualizarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.ComboBox cmbBusNombreProducto;
        private System.Windows.Forms.GroupBox gbxDatosComun;
        private System.Windows.Forms.RadioButton rbtnEspecialNo;
        private System.Windows.Forms.RadioButton rbtnEspecialSi;
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
        private System.Windows.Forms.RadioButton rbtnReqPantNo;
        private System.Windows.Forms.RadioButton rbtnReqPantSi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaCad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbxTipoProducto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btActualizarTipo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarTipoProducto;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox cmbAgregarTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvResBusquedaProd;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblIdProducto;
    }
}