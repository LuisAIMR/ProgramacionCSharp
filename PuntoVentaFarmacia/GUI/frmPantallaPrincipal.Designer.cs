
namespace GUI
{
    partial class frmPantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaPrincipal));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizarV = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlMenVertical = new System.Windows.Forms.Panel();
            this.pnlSeleccionador = new System.Windows.Forms.Panel();
            this.btnProveedores = new FontAwesome.Sharp.IconButton();
            this.btnDevoluciones = new FontAwesome.Sharp.IconButton();
            this.btnHorarios = new FontAwesome.Sharp.IconButton();
            this.pnlSubmenuReportes = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnReporte = new FontAwesome.Sharp.IconButton();
            this.pnlSubmenuCompras = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.pnlSubmenuEmpleados = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEmpleados = new FontAwesome.Sharp.IconButton();
            this.pnlSubmenuVentas = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.pnlSubmenuClientes = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClientes = new FontAwesome.Sharp.IconButton();
            this.pnlSubmenuProductos = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnProducto = new FontAwesome.Sharp.IconButton();
            this.pnlBtnMenu = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconPictureBox();
            this.ttpHelp = new System.Windows.Forms.ToolTip(this.components);
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizarV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlMenVertical.SuspendLayout();
            this.pnlSubmenuReportes.SuspendLayout();
            this.pnlSubmenuCompras.SuspendLayout();
            this.pnlSubmenuEmpleados.SuspendLayout();
            this.pnlSubmenuVentas.SuspendLayout();
            this.pnlSubmenuClientes.SuspendLayout();
            this.pnlSubmenuProductos.SuspendLayout();
            this.pnlBtnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).BeginInit();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.SlateBlue;
            this.barraTitulo.Controls.Add(this.btnRegresar);
            this.barraTitulo.Controls.Add(this.btnLogo);
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnCerrarSesion);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnMaximizarV);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1300, 35);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = global::GUI.Properties.Resources.logout_1;
            this.btnRegresar.Location = new System.Drawing.Point(42, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(24, 29);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.Image = global::GUI.Properties.Resources.senal_de_farmacia;
            this.btnLogo.Location = new System.Drawing.Point(3, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(33, 32);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 0;
            this.btnLogo.TabStop = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRestaurar.Image = global::GUI.Properties.Resources.flecha_cuadrada_hacia_abajo_a_la_derecha;
            this.btnRestaurar.Location = new System.Drawing.Point(1241, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(72, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(120, 25);
            this.btnCerrarSesion.TabIndex = 22;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click_1);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnMinimizar.Image = global::GUI.Properties.Resources.minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(1210, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizarV
            // 
            this.btnMaximizarV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizarV.BackColor = System.Drawing.Color.SlateBlue;
            this.btnMaximizarV.Image = global::GUI.Properties.Resources.boton_maximizar;
            this.btnMaximizarV.Location = new System.Drawing.Point(1241, 3);
            this.btnMaximizarV.Name = "btnMaximizarV";
            this.btnMaximizarV.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizarV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizarV.TabIndex = 1;
            this.btnMaximizarV.TabStop = false;
            this.btnMaximizarV.Click += new System.EventHandler(this.btnMaximizarV_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCerrar.Image = global::GUI.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1272, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlMenVertical
            // 
            this.pnlMenVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlMenVertical.Controls.Add(this.pnlSeleccionador);
            this.pnlMenVertical.Controls.Add(this.btnProveedores);
            this.pnlMenVertical.Controls.Add(this.btnDevoluciones);
            this.pnlMenVertical.Controls.Add(this.btnHorarios);
            this.pnlMenVertical.Controls.Add(this.pnlSubmenuReportes);
            this.pnlMenVertical.Controls.Add(this.btnReporte);
            this.pnlMenVertical.Controls.Add(this.pnlSubmenuCompras);
            this.pnlMenVertical.Controls.Add(this.btnCompras);
            this.pnlMenVertical.Controls.Add(this.pnlSubmenuEmpleados);
            this.pnlMenVertical.Controls.Add(this.btnEmpleados);
            this.pnlMenVertical.Controls.Add(this.pnlSubmenuVentas);
            this.pnlMenVertical.Controls.Add(this.btnVentas);
            this.pnlMenVertical.Controls.Add(this.pnlSubmenuClientes);
            this.pnlMenVertical.Controls.Add(this.btnClientes);
            this.pnlMenVertical.Controls.Add(this.pnlSubmenuProductos);
            this.pnlMenVertical.Controls.Add(this.btnProducto);
            this.pnlMenVertical.Controls.Add(this.pnlBtnMenu);
            this.pnlMenVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenVertical.Location = new System.Drawing.Point(0, 35);
            this.pnlMenVertical.Name = "pnlMenVertical";
            this.pnlMenVertical.Size = new System.Drawing.Size(220, 615);
            this.pnlMenVertical.TabIndex = 2;
            // 
            // pnlSeleccionador
            // 
            this.pnlSeleccionador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.pnlSeleccionador.Location = new System.Drawing.Point(208, 103);
            this.pnlSeleccionador.Name = "pnlSeleccionador";
            this.pnlSeleccionador.Size = new System.Drawing.Size(12, 33);
            this.pnlSeleccionador.TabIndex = 33;
            this.pnlSeleccionador.Visible = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.TruckLoading;
            this.btnProveedores.IconColor = System.Drawing.Color.White;
            this.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProveedores.IconSize = 36;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(0, 568);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(220, 33);
            this.btnProveedores.TabIndex = 36;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevoluciones.FlatAppearance.BorderSize = 0;
            this.btnDevoluciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnDevoluciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevoluciones.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDevoluciones.ForeColor = System.Drawing.Color.White;
            this.btnDevoluciones.IconChar = FontAwesome.Sharp.IconChar.Vial;
            this.btnDevoluciones.IconColor = System.Drawing.Color.White;
            this.btnDevoluciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDevoluciones.IconSize = 36;
            this.btnDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevoluciones.Location = new System.Drawing.Point(0, 535);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(220, 33);
            this.btnDevoluciones.TabIndex = 35;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.UseVisualStyleBackColor = true;
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // btnHorarios
            // 
            this.btnHorarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHorarios.FlatAppearance.BorderSize = 0;
            this.btnHorarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnHorarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorarios.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnHorarios.ForeColor = System.Drawing.Color.White;
            this.btnHorarios.IconChar = FontAwesome.Sharp.IconChar.Wpforms;
            this.btnHorarios.IconColor = System.Drawing.Color.White;
            this.btnHorarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHorarios.IconSize = 36;
            this.btnHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorarios.Location = new System.Drawing.Point(0, 502);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(220, 33);
            this.btnHorarios.TabIndex = 34;
            this.btnHorarios.Text = "Horarios";
            this.btnHorarios.UseVisualStyleBackColor = true;
            this.btnHorarios.Click += new System.EventHandler(this.btnHorarios_Click);
            // 
            // pnlSubmenuReportes
            // 
            this.pnlSubmenuReportes.Controls.Add(this.panel8);
            this.pnlSubmenuReportes.Controls.Add(this.button6);
            this.pnlSubmenuReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSubmenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuReportes.Location = new System.Drawing.Point(0, 468);
            this.pnlSubmenuReportes.Name = "pnlSubmenuReportes";
            this.pnlSubmenuReportes.Size = new System.Drawing.Size(220, 34);
            this.pnlSubmenuReportes.TabIndex = 28;
            this.pnlSubmenuReportes.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SlateBlue;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 28);
            this.panel8.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(49, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 28);
            this.button6.TabIndex = 16;
            this.button6.Text = "Reporte de Ventas";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnReporte
            // 
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btnReporte.IconColor = System.Drawing.Color.White;
            this.btnReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporte.IconSize = 36;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(0, 435);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(220, 33);
            this.btnReporte.TabIndex = 27;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // pnlSubmenuCompras
            // 
            this.pnlSubmenuCompras.Controls.Add(this.panel10);
            this.pnlSubmenuCompras.Controls.Add(this.button5);
            this.pnlSubmenuCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSubmenuCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuCompras.Location = new System.Drawing.Point(0, 401);
            this.pnlSubmenuCompras.Name = "pnlSubmenuCompras";
            this.pnlSubmenuCompras.Size = new System.Drawing.Size(220, 34);
            this.pnlSubmenuCompras.TabIndex = 26;
            this.pnlSubmenuCompras.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SlateBlue;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 28);
            this.panel10.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(49, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 28);
            this.button5.TabIndex = 16;
            this.button5.Text = "Reporte de Ventas";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnCompras
            // 
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.btnCompras.IconColor = System.Drawing.Color.White;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.IconSize = 36;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 368);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(220, 33);
            this.btnCompras.TabIndex = 25;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // pnlSubmenuEmpleados
            // 
            this.pnlSubmenuEmpleados.Controls.Add(this.panel12);
            this.pnlSubmenuEmpleados.Controls.Add(this.button4);
            this.pnlSubmenuEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSubmenuEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuEmpleados.Location = new System.Drawing.Point(0, 334);
            this.pnlSubmenuEmpleados.Name = "pnlSubmenuEmpleados";
            this.pnlSubmenuEmpleados.Size = new System.Drawing.Size(220, 34);
            this.pnlSubmenuEmpleados.TabIndex = 24;
            this.pnlSubmenuEmpleados.Visible = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SlateBlue;
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 28);
            this.panel12.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(49, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 28);
            this.button4.TabIndex = 16;
            this.button4.Text = "Reporte de Ventas";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnEmpleados.IconColor = System.Drawing.Color.White;
            this.btnEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmpleados.IconSize = 36;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 301);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(220, 33);
            this.btnEmpleados.TabIndex = 23;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // pnlSubmenuVentas
            // 
            this.pnlSubmenuVentas.Controls.Add(this.panel6);
            this.pnlSubmenuVentas.Controls.Add(this.button3);
            this.pnlSubmenuVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSubmenuVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuVentas.Location = new System.Drawing.Point(0, 267);
            this.pnlSubmenuVentas.Name = "pnlSubmenuVentas";
            this.pnlSubmenuVentas.Size = new System.Drawing.Size(220, 34);
            this.pnlSubmenuVentas.TabIndex = 22;
            this.pnlSubmenuVentas.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SlateBlue;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 28);
            this.panel6.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(49, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 28);
            this.button3.TabIndex = 16;
            this.button3.Text = "Reporte de Ventas";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 36;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 234);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(220, 33);
            this.btnVentas.TabIndex = 22;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // pnlSubmenuClientes
            // 
            this.pnlSubmenuClientes.Controls.Add(this.panel4);
            this.pnlSubmenuClientes.Controls.Add(this.button1);
            this.pnlSubmenuClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSubmenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuClientes.Location = new System.Drawing.Point(0, 200);
            this.pnlSubmenuClientes.Name = "pnlSubmenuClientes";
            this.pnlSubmenuClientes.Size = new System.Drawing.Size(220, 34);
            this.pnlSubmenuClientes.TabIndex = 21;
            this.pnlSubmenuClientes.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateBlue;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 28);
            this.panel4.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(49, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reporte de Ventas";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.IconChar = FontAwesome.Sharp.IconChar.CreativeCommonsBy;
            this.btnClientes.IconColor = System.Drawing.Color.White;
            this.btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientes.IconSize = 36;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 170);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(220, 30);
            this.btnClientes.TabIndex = 20;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnlSubmenuProductos
            // 
            this.pnlSubmenuProductos.Controls.Add(this.panel3);
            this.pnlSubmenuProductos.Controls.Add(this.button2);
            this.pnlSubmenuProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlSubmenuProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuProductos.Location = new System.Drawing.Point(0, 136);
            this.pnlSubmenuProductos.Name = "pnlSubmenuProductos";
            this.pnlSubmenuProductos.Size = new System.Drawing.Size(220, 34);
            this.pnlSubmenuProductos.TabIndex = 19;
            this.pnlSubmenuProductos.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateBlue;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 28);
            this.panel3.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(49, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Reporte de Ventas";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnProducto
            // 
            this.btnProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnProducto.ForeColor = System.Drawing.Color.White;
            this.btnProducto.IconChar = FontAwesome.Sharp.IconChar.Pills;
            this.btnProducto.IconColor = System.Drawing.Color.White;
            this.btnProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducto.IconSize = 36;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(0, 103);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(220, 33);
            this.btnProducto.TabIndex = 19;
            this.btnProducto.Text = "Productos";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // pnlBtnMenu
            // 
            this.pnlBtnMenu.Controls.Add(this.lblNombre);
            this.pnlBtnMenu.Controls.Add(this.lblPuesto);
            this.pnlBtnMenu.Controls.Add(this.btnMenu);
            this.pnlBtnMenu.Controls.Add(this.btnUser);
            this.pnlBtnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBtnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlBtnMenu.Name = "pnlBtnMenu";
            this.pnlBtnMenu.Size = new System.Drawing.Size(220, 103);
            this.pnlBtnMenu.TabIndex = 32;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(46, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(131, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre de la persona";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblPuesto.Location = new System.Drawing.Point(46, 6);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(56, 16);
            this.lblPuesto.TabIndex = 2;
            this.lblPuesto.Text = "Puesto";
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.Th;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 36;
            this.btnMenu.Location = new System.Drawing.Point(180, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnUser.IconColor = System.Drawing.Color.SlateBlue;
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUser.IconSize = 43;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(220, 43);
            this.btnUser.TabIndex = 1;
            this.btnUser.TabStop = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.pnlContenedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(220, 35);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1080, 615);
            this.pnlContenedor.TabIndex = 3;
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenVertical);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPantallaPrincipal";
            this.Text = "Punto de Venta Farmacia ";
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizarV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlMenVertical.ResumeLayout(false);
            this.pnlSubmenuReportes.ResumeLayout(false);
            this.pnlSubmenuCompras.ResumeLayout(false);
            this.pnlSubmenuEmpleados.ResumeLayout(false);
            this.pnlSubmenuVentas.ResumeLayout(false);
            this.pnlSubmenuClientes.ResumeLayout(false);
            this.pnlSubmenuProductos.ResumeLayout(false);
            this.pnlBtnMenu.ResumeLayout(false);
            this.pnlBtnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMaximizarV;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnLogo;
        private System.Windows.Forms.PictureBox btnRegresar;
        public System.Windows.Forms.Panel pnlMenVertical;
        private System.Windows.Forms.ToolTip ttpHelp;
        private System.Windows.Forms.Button btnCerrarSesion;
        private FontAwesome.Sharp.IconButton btnVentas;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlSubmenuReportes;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button6;
        private FontAwesome.Sharp.IconButton btnReporte;
        private System.Windows.Forms.Panel pnlSubmenuCompras;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button5;
        private FontAwesome.Sharp.IconButton btnCompras;
        private System.Windows.Forms.Panel pnlSubmenuEmpleados;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button4;
        private FontAwesome.Sharp.IconButton btnEmpleados;
        private System.Windows.Forms.Panel pnlSubmenuVentas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlSubmenuClientes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton btnClientes;
        private FontAwesome.Sharp.IconButton btnProducto;
        private System.Windows.Forms.Panel pnlBtnMenu;
        private System.Windows.Forms.Panel pnlSubmenuProductos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlSeleccionador;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPuesto;
        private FontAwesome.Sharp.IconPictureBox btnUser;
        private FontAwesome.Sharp.IconButton btnMenu;
        private FontAwesome.Sharp.IconButton btnProveedores;
        private FontAwesome.Sharp.IconButton btnDevoluciones;
        private FontAwesome.Sharp.IconButton btnHorarios;
    }
}