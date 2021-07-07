
namespace GUI
{
    partial class frmLog
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLog));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbxlogo = new System.Windows.Forms.PictureBox();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.lblLOGIN = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.ttpHelp = new System.Windows.Forms.ToolTip(this.components);
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.dtpFechaNac = new Metroit.Windows.Forms.MetDateTimePicker();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtConfirmarContra = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconContrasena = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.txtContrasenaRegistrada = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsuarioRegistrado = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRegistrarNuevoUsuario = new System.Windows.Forms.Button();
            this.pnlDeAcceso = new System.Windows.Forms.Panel();
            this.pbxContra = new FontAwesome.Sharp.IconPictureBox();
            this.pbxUser = new FontAwesome.Sharp.IconPictureBox();
            this.btnRegistrarme = new System.Windows.Forms.Button();
            this.btnOcultarC = new System.Windows.Forms.PictureBox();
            this.btnMostarC = new System.Windows.Forms.PictureBox();
            this.lklOlvidoContra = new System.Windows.Forms.LinkLabel();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvValidacionUsuario = new System.Windows.Forms.DataGridView();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).BeginInit();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconContrasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.pnlDeAcceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidacionUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.panelLogo.Controls.Add(this.dgvValidacionUsuario);
            this.panelLogo.Controls.Add(this.pbxlogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(292, 330);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // pbxlogo
            // 
            this.pbxlogo.Image = global::GUI.Properties.Resources.senal_de_farmacia;
            this.pbxlogo.Location = new System.Drawing.Point(72, 85);
            this.pbxlogo.Name = "pbxlogo";
            this.pbxlogo.Size = new System.Drawing.Size(150, 117);
            this.pbxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxlogo.TabIndex = 0;
            this.pbxlogo.TabStop = false;
            this.pbxlogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxlogo_MouseDown);
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.btnRegresar);
            this.BarraSuperior.Controls.Add(this.lblLOGIN);
            this.BarraSuperior.Controls.Add(this.btnMinimizar);
            this.BarraSuperior.Controls.Add(this.btnCerrar);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(292, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(518, 35);
            this.BarraSuperior.TabIndex = 7;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = global::GUI.Properties.Resources.logout_1;
            this.btnRegresar.Location = new System.Drawing.Point(3, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(24, 29);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegresar.TabIndex = 83;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Visible = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblLOGIN
            // 
            this.lblLOGIN.AutoSize = true;
            this.lblLOGIN.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLOGIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLOGIN.Location = new System.Drawing.Point(221, 3);
            this.lblLOGIN.Name = "lblLOGIN";
            this.lblLOGIN.Size = new System.Drawing.Size(72, 25);
            this.lblLOGIN.TabIndex = 9;
            this.lblLOGIN.Text = "LOGIN";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnMinimizar.Image = global::GUI.Properties.Resources.minimizar;
            this.btnMinimizar.Location = new System.Drawing.Point(459, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(40)))));
            this.btnCerrar.Image = global::GUI.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(490, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.pnlRegistro);
            this.pnlContenedor.Controls.Add(this.pnlDeAcceso);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(292, 35);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(518, 295);
            this.pnlContenedor.TabIndex = 8;
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Controls.Add(this.dtpFechaNac);
            this.pnlRegistro.Controls.Add(this.iconPictureBox3);
            this.pnlRegistro.Controls.Add(this.label1);
            this.pnlRegistro.Controls.Add(this.txtTelefono);
            this.pnlRegistro.Controls.Add(this.panel11);
            this.pnlRegistro.Controls.Add(this.iconPictureBox1);
            this.pnlRegistro.Controls.Add(this.txtCurp);
            this.pnlRegistro.Controls.Add(this.panel10);
            this.pnlRegistro.Controls.Add(this.txtApMaterno);
            this.pnlRegistro.Controls.Add(this.panel9);
            this.pnlRegistro.Controls.Add(this.txtApPaterno);
            this.pnlRegistro.Controls.Add(this.panel8);
            this.pnlRegistro.Controls.Add(this.iconPictureBox5);
            this.pnlRegistro.Controls.Add(this.txtCorreo);
            this.pnlRegistro.Controls.Add(this.panel7);
            this.pnlRegistro.Controls.Add(this.iconPictureBox4);
            this.pnlRegistro.Controls.Add(this.txtNombre);
            this.pnlRegistro.Controls.Add(this.panel6);
            this.pnlRegistro.Controls.Add(this.txtConfirmarContra);
            this.pnlRegistro.Controls.Add(this.panel5);
            this.pnlRegistro.Controls.Add(this.iconContrasena);
            this.pnlRegistro.Controls.Add(this.iconPictureBox2);
            this.pnlRegistro.Controls.Add(this.txtContrasenaRegistrada);
            this.pnlRegistro.Controls.Add(this.panel1);
            this.pnlRegistro.Controls.Add(this.txtUsuarioRegistrado);
            this.pnlRegistro.Controls.Add(this.panel4);
            this.pnlRegistro.Controls.Add(this.btnRegistrarNuevoUsuario);
            this.pnlRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegistro.ForeColor = System.Drawing.Color.White;
            this.pnlRegistro.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(518, 295);
            this.pnlRegistro.TabIndex = 63;
            this.pnlRegistro.Visible = false;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.BaseBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtpFechaNac.BaseForeColor = System.Drawing.SystemColors.Info;
            this.dtpFechaNac.FocusBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dtpFechaNac.FocusForeColor = System.Drawing.SystemColors.Info;
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(163, 99);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaNac.TabIndex = 6;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 20;
            this.iconPictureBox3.Location = new System.Drawing.Point(14, 100);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox3.TabIndex = 91;
            this.iconPictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(32, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "FECHA DE NACIMIENTO:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefono.Location = new System.Drawing.Point(309, 66);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(170, 15);
            this.txtTelefono.TabIndex = 5;
            this.txtTelefono.Text = "TELÉFONO";
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.SlateBlue;
            this.panel11.Enabled = false;
            this.panel11.Location = new System.Drawing.Point(309, 79);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(170, 5);
            this.panel11.TabIndex = 88;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 20;
            this.iconPictureBox1.Location = new System.Drawing.Point(14, 64);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox1.TabIndex = 85;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtCurp
            // 
            this.txtCurp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCurp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurp.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurp.ForeColor = System.Drawing.Color.Gray;
            this.txtCurp.Location = new System.Drawing.Point(35, 66);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(170, 15);
            this.txtCurp.TabIndex = 4;
            this.txtCurp.Text = "CURP";
            this.txtCurp.Enter += new System.EventHandler(this.txtCurp_Enter);
            this.txtCurp.Leave += new System.EventHandler(this.txtCurp_Leave);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SlateBlue;
            this.panel10.Enabled = false;
            this.panel10.Location = new System.Drawing.Point(35, 79);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(170, 5);
            this.panel10.TabIndex = 84;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtApMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApMaterno.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApMaterno.ForeColor = System.Drawing.Color.Gray;
            this.txtApMaterno.Location = new System.Drawing.Point(368, 24);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(111, 15);
            this.txtApMaterno.TabIndex = 3;
            this.txtApMaterno.Text = "APELLIDO MATERNO";
            this.txtApMaterno.Enter += new System.EventHandler(this.txtApMaterno_Enter);
            this.txtApMaterno.Leave += new System.EventHandler(this.txtApMaterno_Leave);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SlateBlue;
            this.panel9.Enabled = false;
            this.panel9.Location = new System.Drawing.Point(368, 37);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(111, 5);
            this.panel9.TabIndex = 82;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtApPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApPaterno.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApPaterno.ForeColor = System.Drawing.Color.Gray;
            this.txtApPaterno.Location = new System.Drawing.Point(231, 24);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(111, 15);
            this.txtApPaterno.TabIndex = 2;
            this.txtApPaterno.Text = "APELLIDO PATERNO";
            this.txtApPaterno.Enter += new System.EventHandler(this.txtApPaterno_Enter);
            this.txtApPaterno.Leave += new System.EventHandler(this.txtApPaterno_Leave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SlateBlue;
            this.panel8.Enabled = false;
            this.panel8.Location = new System.Drawing.Point(231, 37);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(111, 5);
            this.panel8.TabIndex = 80;
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 20;
            this.iconPictureBox5.Location = new System.Drawing.Point(13, 163);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox5.TabIndex = 78;
            this.iconPictureBox5.TabStop = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Gray;
            this.txtCorreo.Location = new System.Drawing.Point(35, 165);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(444, 15);
            this.txtCorreo.TabIndex = 8;
            this.txtCorreo.Text = "CORREO";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SlateBlue;
            this.panel7.Enabled = false;
            this.panel7.Location = new System.Drawing.Point(35, 178);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(444, 5);
            this.panel7.TabIndex = 77;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 20;
            this.iconPictureBox4.Location = new System.Drawing.Point(14, 22);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox4.TabIndex = 75;
            this.iconPictureBox4.TabStop = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(35, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 15);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "NOMBRE";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SlateBlue;
            this.panel6.Enabled = false;
            this.panel6.Location = new System.Drawing.Point(35, 37);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(170, 5);
            this.panel6.TabIndex = 74;
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtConfirmarContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarContra.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContra.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmarContra.Location = new System.Drawing.Point(286, 196);
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.Size = new System.Drawing.Size(193, 15);
            this.txtConfirmarContra.TabIndex = 10;
            this.txtConfirmarContra.Text = "CONFIRMAR CONTRASEÑA";
            this.txtConfirmarContra.Enter += new System.EventHandler(this.txtConfirmarContra_Enter);
            this.txtConfirmarContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarContra_KeyPress);
            this.txtConfirmarContra.Leave += new System.EventHandler(this.txtConfirmarContra_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SlateBlue;
            this.panel5.Enabled = false;
            this.panel5.Location = new System.Drawing.Point(286, 209);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(193, 5);
            this.panel5.TabIndex = 70;
            // 
            // iconContrasena
            // 
            this.iconContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iconContrasena.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconContrasena.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconContrasena.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconContrasena.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconContrasena.IconSize = 20;
            this.iconContrasena.Location = new System.Drawing.Point(13, 196);
            this.iconContrasena.Name = "iconContrasena";
            this.iconContrasena.Size = new System.Drawing.Size(20, 20);
            this.iconContrasena.TabIndex = 68;
            this.iconContrasena.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 20;
            this.iconPictureBox2.Location = new System.Drawing.Point(13, 131);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(20, 20);
            this.iconPictureBox2.TabIndex = 67;
            this.iconPictureBox2.TabStop = false;
            // 
            // txtContrasenaRegistrada
            // 
            this.txtContrasenaRegistrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtContrasenaRegistrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenaRegistrada.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaRegistrada.ForeColor = System.Drawing.Color.Gray;
            this.txtContrasenaRegistrada.Location = new System.Drawing.Point(37, 196);
            this.txtContrasenaRegistrada.Name = "txtContrasenaRegistrada";
            this.txtContrasenaRegistrada.Size = new System.Drawing.Size(193, 15);
            this.txtContrasenaRegistrada.TabIndex = 9;
            this.txtContrasenaRegistrada.Text = "CONTRASEÑA";
            this.txtContrasenaRegistrada.Enter += new System.EventHandler(this.txtContraseñaRegistrada_Enter);
            this.txtContrasenaRegistrada.Leave += new System.EventHandler(this.txtContraseñaRegistrada_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(35, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 5);
            this.panel1.TabIndex = 66;
            // 
            // txtUsuarioRegistrado
            // 
            this.txtUsuarioRegistrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuarioRegistrado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioRegistrado.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioRegistrado.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuarioRegistrado.Location = new System.Drawing.Point(35, 133);
            this.txtUsuarioRegistrado.Name = "txtUsuarioRegistrado";
            this.txtUsuarioRegistrado.Size = new System.Drawing.Size(444, 15);
            this.txtUsuarioRegistrado.TabIndex = 7;
            this.txtUsuarioRegistrado.Text = "USUARIO";
            this.txtUsuarioRegistrado.Enter += new System.EventHandler(this.txtUsuarioRegistrado_Enter);
            this.txtUsuarioRegistrado.Leave += new System.EventHandler(this.txtUsuarioRegistrado_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateBlue;
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(35, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(444, 5);
            this.panel4.TabIndex = 64;
            // 
            // btnRegistrarNuevoUsuario
            // 
            this.btnRegistrarNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnRegistrarNuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarNuevoUsuario.FlatAppearance.BorderSize = 2;
            this.btnRegistrarNuevoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarNuevoUsuario.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarNuevoUsuario.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrarNuevoUsuario.Location = new System.Drawing.Point(35, 252);
            this.btnRegistrarNuevoUsuario.Name = "btnRegistrarNuevoUsuario";
            this.btnRegistrarNuevoUsuario.Size = new System.Drawing.Size(444, 31);
            this.btnRegistrarNuevoUsuario.TabIndex = 11;
            this.btnRegistrarNuevoUsuario.Text = "REGISTRARME";
            this.btnRegistrarNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarNuevoUsuario.Click += new System.EventHandler(this.btnRegistrarNuevoUsuario_Click);
            // 
            // pnlDeAcceso
            // 
            this.pnlDeAcceso.Controls.Add(this.pbxContra);
            this.pnlDeAcceso.Controls.Add(this.pbxUser);
            this.pnlDeAcceso.Controls.Add(this.btnRegistrarme);
            this.pnlDeAcceso.Controls.Add(this.btnOcultarC);
            this.pnlDeAcceso.Controls.Add(this.btnMostarC);
            this.pnlDeAcceso.Controls.Add(this.lklOlvidoContra);
            this.pnlDeAcceso.Controls.Add(this.btnAcceder);
            this.pnlDeAcceso.Controls.Add(this.txtContrasena);
            this.pnlDeAcceso.Controls.Add(this.panel3);
            this.pnlDeAcceso.Controls.Add(this.txtUsuario);
            this.pnlDeAcceso.Controls.Add(this.panel2);
            this.pnlDeAcceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeAcceso.Location = new System.Drawing.Point(0, 0);
            this.pnlDeAcceso.Name = "pnlDeAcceso";
            this.pnlDeAcceso.Size = new System.Drawing.Size(518, 295);
            this.pnlDeAcceso.TabIndex = 0;
            // 
            // pbxContra
            // 
            this.pbxContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pbxContra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pbxContra.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.pbxContra.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.pbxContra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxContra.IconSize = 20;
            this.pbxContra.Location = new System.Drawing.Point(14, 97);
            this.pbxContra.Name = "pbxContra";
            this.pbxContra.Size = new System.Drawing.Size(20, 20);
            this.pbxContra.TabIndex = 62;
            this.pbxContra.TabStop = false;
            // 
            // pbxUser
            // 
            this.pbxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pbxUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pbxUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.pbxUser.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.pbxUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxUser.IconSize = 20;
            this.pbxUser.Location = new System.Drawing.Point(13, 43);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(20, 20);
            this.pbxUser.TabIndex = 61;
            this.pbxUser.TabStop = false;
            // 
            // btnRegistrarme
            // 
            this.btnRegistrarme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnRegistrarme.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarme.FlatAppearance.BorderSize = 2;
            this.btnRegistrarme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarme.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarme.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrarme.Location = new System.Drawing.Point(35, 216);
            this.btnRegistrarme.Name = "btnRegistrarme";
            this.btnRegistrarme.Size = new System.Drawing.Size(444, 31);
            this.btnRegistrarme.TabIndex = 60;
            this.btnRegistrarme.Text = "REGISTRARME";
            this.btnRegistrarme.UseVisualStyleBackColor = false;
            this.btnRegistrarme.Click += new System.EventHandler(this.btnRegistrarme_Click);
            // 
            // btnOcultarC
            // 
            this.btnOcultarC.BackColor = System.Drawing.Color.SlateBlue;
            this.btnOcultarC.Image = global::GUI.Properties.Resources.hide;
            this.btnOcultarC.Location = new System.Drawing.Point(485, 92);
            this.btnOcultarC.Name = "btnOcultarC";
            this.btnOcultarC.Size = new System.Drawing.Size(21, 21);
            this.btnOcultarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOcultarC.TabIndex = 59;
            this.btnOcultarC.TabStop = false;
            this.btnOcultarC.Visible = false;
            this.btnOcultarC.Click += new System.EventHandler(this.btnOcultarC_Click);
            // 
            // btnMostarC
            // 
            this.btnMostarC.BackColor = System.Drawing.Color.SlateBlue;
            this.btnMostarC.Image = global::GUI.Properties.Resources.eye;
            this.btnMostarC.Location = new System.Drawing.Point(485, 92);
            this.btnMostarC.Name = "btnMostarC";
            this.btnMostarC.Size = new System.Drawing.Size(21, 21);
            this.btnMostarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMostarC.TabIndex = 58;
            this.btnMostarC.TabStop = false;
            this.btnMostarC.Click += new System.EventHandler(this.btnMostarC_Click);
            // 
            // lklOlvidoContra
            // 
            this.lklOlvidoContra.ActiveLinkColor = System.Drawing.Color.SlateBlue;
            this.lklOlvidoContra.AutoSize = true;
            this.lklOlvidoContra.LinkColor = System.Drawing.Color.White;
            this.lklOlvidoContra.Location = new System.Drawing.Point(189, 263);
            this.lklOlvidoContra.Name = "lklOlvidoContra";
            this.lklOlvidoContra.Size = new System.Drawing.Size(130, 13);
            this.lklOlvidoContra.TabIndex = 52;
            this.lklOlvidoContra.TabStop = true;
            this.lklOlvidoContra.Text = "¿Olvidaste la contraseña?";
            this.lklOlvidoContra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklOlvidoContra_LinkClicked);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.Transparent;
            this.btnAcceder.Location = new System.Drawing.Point(35, 183);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(444, 27);
            this.btnAcceder.TabIndex = 56;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.Color.Gray;
            this.txtContrasena.Location = new System.Drawing.Point(35, 98);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(444, 15);
            this.txtContrasena.TabIndex = 55;
            this.txtContrasena.Text = "CONTRASEÑA";
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasena_KeyPress);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateBlue;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(35, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 5);
            this.panel3.TabIndex = 57;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(35, 45);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(444, 15);
            this.txtUsuario.TabIndex = 53;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(35, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 5);
            this.panel2.TabIndex = 54;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvValidacionUsuario
            // 
            this.dgvValidacionUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValidacionUsuario.Location = new System.Drawing.Point(72, 244);
            this.dgvValidacionUsuario.Name = "dgvValidacionUsuario";
            this.dgvValidacionUsuario.Size = new System.Drawing.Size(149, 67);
            this.dgvValidacionUsuario.TabIndex = 1;
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(810, 330);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLog";
            this.Opacity = 0.9D;
            this.Text = "LOGIN";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).EndInit();
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconContrasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.pnlDeAcceso.ResumeLayout(false);
            this.pnlDeAcceso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValidacionUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pbxlogo;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label lblLOGIN;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.ToolTip ttpHelp;
        public System.Windows.Forms.Panel pnlContenedor;
        private FontAwesome.Sharp.IconPictureBox pbxContra;
        private FontAwesome.Sharp.IconPictureBox pbxUser;
        private System.Windows.Forms.Button btnRegistrarme;
        private System.Windows.Forms.PictureBox btnOcultarC;
        private System.Windows.Forms.PictureBox btnMostarC;
        private System.Windows.Forms.LinkLabel lklOlvidoContra;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel pnlDeAcceso;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Button btnRegistrarNuevoUsuario;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtConfirmarContra;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconContrasena;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.TextBox txtContrasenaRegistrada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuarioRegistrado;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox btnRegresar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Panel panel11;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label label1;
        private Metroit.Windows.Forms.MetDateTimePicker dtpFechaNac;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvValidacionUsuario;
    }
}

