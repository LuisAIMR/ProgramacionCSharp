
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbxlogo = new System.Windows.Forms.PictureBox();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.lblLOGIN = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lklOlvidoContra = new System.Windows.Forms.LinkLabel();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOcultarC = new System.Windows.Forms.PictureBox();
            this.btnMostarC = new System.Windows.Forms.PictureBox();
            this.ttpHelp = new System.Windows.Forms.ToolTip(this.components);
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).BeginInit();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostarC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.SlateBlue;
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
            this.BarraSuperior.BackColor = System.Drawing.Color.SlateBlue;
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
            this.btnMinimizar.BackColor = System.Drawing.Color.SlateBlue;
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
            this.btnCerrar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCerrar.Image = global::GUI.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(490, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lklOlvidoContra
            // 
            this.lklOlvidoContra.ActiveLinkColor = System.Drawing.Color.SlateBlue;
            this.lklOlvidoContra.AutoSize = true;
            this.lklOlvidoContra.LinkColor = System.Drawing.Color.White;
            this.lklOlvidoContra.Location = new System.Drawing.Point(474, 288);
            this.lklOlvidoContra.Name = "lklOlvidoContra";
            this.lklOlvidoContra.Size = new System.Drawing.Size(130, 13);
            this.lklOlvidoContra.TabIndex = 8;
            this.lklOlvidoContra.TabStop = true;
            this.lklOlvidoContra.Text = "¿Olvidaste la contraseña?";
            this.lklOlvidoContra.Click += new System.EventHandler(this.lklOlvidoContra_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.Transparent;
            this.btnAcceder.Location = new System.Drawing.Point(320, 239);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(444, 27);
            this.btnAcceder.TabIndex = 12;
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
            this.txtContrasena.Location = new System.Drawing.Point(320, 147);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(444, 15);
            this.txtContrasena.TabIndex = 11;
            this.txtContrasena.Text = "CONTRASEÑA";
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            this.txtContrasena.Leave += new System.EventHandler(this.txtContrasena_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateBlue;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(320, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 5);
            this.panel3.TabIndex = 13;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Gray;
            this.txtUsuario.Location = new System.Drawing.Point(320, 94);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(444, 15);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(320, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 5);
            this.panel2.TabIndex = 10;
            // 
            // btnOcultarC
            // 
            this.btnOcultarC.BackColor = System.Drawing.Color.SlateBlue;
            this.btnOcultarC.Image = global::GUI.Properties.Resources.hide;
            this.btnOcultarC.Location = new System.Drawing.Point(770, 141);
            this.btnOcultarC.Name = "btnOcultarC";
            this.btnOcultarC.Size = new System.Drawing.Size(21, 21);
            this.btnOcultarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnOcultarC.TabIndex = 15;
            this.btnOcultarC.TabStop = false;
            this.btnOcultarC.Visible = false;
            this.btnOcultarC.Click += new System.EventHandler(this.btnOcultarC_Click);
            // 
            // btnMostarC
            // 
            this.btnMostarC.BackColor = System.Drawing.Color.SlateBlue;
            this.btnMostarC.Image = global::GUI.Properties.Resources.eye;
            this.btnMostarC.Location = new System.Drawing.Point(770, 141);
            this.btnMostarC.Name = "btnMostarC";
            this.btnMostarC.Size = new System.Drawing.Size(21, 21);
            this.btnMostarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMostarC.TabIndex = 14;
            this.btnMostarC.TabStop = false;
            this.btnMostarC.Click += new System.EventHandler(this.btnMostarC_Click);
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(810, 330);
            this.Controls.Add(this.btnOcultarC);
            this.Controls.Add(this.btnMostarC);
            this.Controls.Add(this.lklOlvidoContra);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLog";
            this.Opacity = 0.8D;
            this.Text = "LOGIN";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxlogo)).EndInit();
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOcultarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMostarC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pbxlogo;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label lblLOGIN;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.LinkLabel lklOlvidoContra;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnMostarC;
        private System.Windows.Forms.PictureBox btnOcultarC;
        private System.Windows.Forms.ToolTip ttpHelp;
    }
}

