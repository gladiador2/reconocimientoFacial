namespace Reconocimiento_facial
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new Reconocimiento_facial.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.onlinePicture = new Reconocimiento_facial.RJControls.RJCircularPictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.PerfilPicture = new Reconocimiento_facial.RJControls.RJCircularPictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rjButton1 = new Reconocimiento_facial.RJControls.RJButton();
            this.btnReconocimiento = new Reconocimiento_facial.RJControls.RJButton();
            this.BtnPersonas = new Reconocimiento_facial.RJControls.RJButton();
            this.btnUbicaciones = new Reconocimiento_facial.RJControls.RJButton();
            this.btnUsuario = new Reconocimiento_facial.RJControls.RJButton();
            this.panelformularios = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnOcultarMenu = new Reconocimiento_facial.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlinePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerfilPicture)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelformularios);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(910, 575);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 575);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.BackgroundColor = System.Drawing.Color.Red;
            this.btnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.BorderRadius = 5;
            this.btnSalir.BorderSize = 0;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Reconocimiento_facial.Properties.Resources.exit;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(3, 530);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 40);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Cerrar Session";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.onlinePicture);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.PerfilPicture);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 135);
            this.panel2.TabIndex = 0;
            // 
            // onlinePicture
            // 
            this.onlinePicture.BackColor = System.Drawing.Color.Lime;
            this.onlinePicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.onlinePicture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.onlinePicture.BorderColor2 = System.Drawing.Color.Lime;
            this.onlinePicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.onlinePicture.BorderSize = 2;
            this.onlinePicture.GradientAngle = 50F;
            this.onlinePicture.Location = new System.Drawing.Point(3, 110);
            this.onlinePicture.Name = "onlinePicture";
            this.onlinePicture.Size = new System.Drawing.Size(22, 22);
            this.onlinePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.onlinePicture.TabIndex = 10;
            this.onlinePicture.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(26, 115);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 17);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "José Rolón";
            // 
            // PerfilPicture
            // 
            this.PerfilPicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.PerfilPicture.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PerfilPicture.BorderColor2 = System.Drawing.Color.HotPink;
            this.PerfilPicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PerfilPicture.BorderSize = 2;
            this.PerfilPicture.GradientAngle = 50F;
            this.PerfilPicture.Image = global::Reconocimiento_facial.Properties.Resources._1461141;
            this.PerfilPicture.Location = new System.Drawing.Point(22, 12);
            this.PerfilPicture.Name = "PerfilPicture";
            this.PerfilPicture.Size = new System.Drawing.Size(100, 100);
            this.PerfilPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PerfilPicture.TabIndex = 0;
            this.PerfilPicture.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.rjButton1);
            this.flowLayoutPanel1.Controls.Add(this.btnReconocimiento);
            this.flowLayoutPanel1.Controls.Add(this.BtnPersonas);
            this.flowLayoutPanel1.Controls.Add(this.btnUbicaciones);
            this.flowLayoutPanel1.Controls.Add(this.btnUsuario);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 135);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(144, 392);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Transparent;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderColor = System.Drawing.SystemColors.Highlight;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Image = global::Reconocimiento_facial.Properties.Resources.vdashboard;
            this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton1.Location = new System.Drawing.Point(3, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(138, 40);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.Text = "dashboard";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnReconocimiento
            // 
            this.btnReconocimiento.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReconocimiento.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.btnReconocimiento.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnReconocimiento.BorderRadius = 10;
            this.btnReconocimiento.BorderSize = 2;
            this.btnReconocimiento.FlatAppearance.BorderSize = 0;
            this.btnReconocimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReconocimiento.ForeColor = System.Drawing.Color.White;
            this.btnReconocimiento.Image = global::Reconocimiento_facial.Properties.Resources.registros;
            this.btnReconocimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReconocimiento.Location = new System.Drawing.Point(3, 49);
            this.btnReconocimiento.Name = "btnReconocimiento";
            this.btnReconocimiento.Size = new System.Drawing.Size(138, 40);
            this.btnReconocimiento.TabIndex = 1;
            this.btnReconocimiento.Text = "Reconocimiento";
            this.btnReconocimiento.TextColor = System.Drawing.Color.White;
            this.btnReconocimiento.UseVisualStyleBackColor = false;
            this.btnReconocimiento.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // BtnPersonas
            // 
            this.BtnPersonas.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnPersonas.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.BtnPersonas.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnPersonas.BorderRadius = 10;
            this.BtnPersonas.BorderSize = 2;
            this.BtnPersonas.FlatAppearance.BorderSize = 0;
            this.BtnPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonas.ForeColor = System.Drawing.Color.White;
            this.BtnPersonas.Image = global::Reconocimiento_facial.Properties.Resources.informes;
            this.BtnPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonas.Location = new System.Drawing.Point(3, 95);
            this.BtnPersonas.Name = "BtnPersonas";
            this.BtnPersonas.Size = new System.Drawing.Size(138, 40);
            this.BtnPersonas.TabIndex = 2;
            this.BtnPersonas.Text = "Personas";
            this.BtnPersonas.TextColor = System.Drawing.Color.White;
            this.BtnPersonas.UseVisualStyleBackColor = false;
            this.BtnPersonas.Click += new System.EventHandler(this.rjButton3_Click);
            // 
            // btnUbicaciones
            // 
            this.btnUbicaciones.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUbicaciones.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.btnUbicaciones.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnUbicaciones.BorderRadius = 10;
            this.btnUbicaciones.BorderSize = 2;
            this.btnUbicaciones.FlatAppearance.BorderSize = 0;
            this.btnUbicaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbicaciones.ForeColor = System.Drawing.Color.White;
            this.btnUbicaciones.Image = global::Reconocimiento_facial.Properties.Resources.registros;
            this.btnUbicaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUbicaciones.Location = new System.Drawing.Point(3, 141);
            this.btnUbicaciones.Name = "btnUbicaciones";
            this.btnUbicaciones.Size = new System.Drawing.Size(138, 40);
            this.btnUbicaciones.TabIndex = 4;
            this.btnUbicaciones.Text = "Ubicaiones";
            this.btnUbicaciones.TextColor = System.Drawing.Color.White;
            this.btnUbicaciones.UseVisualStyleBackColor = false;
            this.btnUbicaciones.Click += new System.EventHandler(this.rjButton5_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUsuario.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.btnUsuario.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnUsuario.BorderRadius = 10;
            this.btnUsuario.BorderSize = 2;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = global::Reconocimiento_facial.Properties.Resources.usuarios;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(3, 187);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(138, 40);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.TextColor = System.Drawing.Color.White;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.rjButton6_Click);
            // 
            // panelformularios
            // 
            this.panelformularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelformularios.Location = new System.Drawing.Point(0, 46);
            this.panelformularios.Name = "panelformularios";
            this.panelformularios.Size = new System.Drawing.Size(762, 529);
            this.panelformularios.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.BtnOcultarMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRestaurar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 46);
            this.panel1.TabIndex = 0;
            // 
            // BtnOcultarMenu
            // 
            this.BtnOcultarMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnOcultarMenu.BackgroundColor = System.Drawing.Color.Transparent;
            this.BtnOcultarMenu.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnOcultarMenu.BorderRadius = 10;
            this.BtnOcultarMenu.BorderSize = 0;
            this.BtnOcultarMenu.FlatAppearance.BorderSize = 0;
            this.BtnOcultarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOcultarMenu.ForeColor = System.Drawing.Color.Black;
            this.BtnOcultarMenu.Image = global::Reconocimiento_facial.Properties.Resources.hamburger_menu_icon_149466__1_;
            this.BtnOcultarMenu.Location = new System.Drawing.Point(3, 3);
            this.BtnOcultarMenu.Name = "BtnOcultarMenu";
            this.BtnOcultarMenu.Size = new System.Drawing.Size(41, 40);
            this.BtnOcultarMenu.TabIndex = 9;
            this.BtnOcultarMenu.TabStop = false;
            this.BtnOcultarMenu.TextColor = System.Drawing.Color.Black;
            this.BtnOcultarMenu.UseVisualStyleBackColor = false;
            this.BtnOcultarMenu.Click += new System.EventHandler(this.rjButton8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(296, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(723, 14);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(12, 16);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(707, 14);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(12, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(723, 14);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(12, 16);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(739, 14);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(12, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(910, 575);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Californian FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onlinePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerfilPicture)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private RJControls.RJButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        private RJControls.RJCircularPictureBox onlinePicture;
        private System.Windows.Forms.Label lblUsuario;
        private RJControls.RJCircularPictureBox PerfilPicture;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private RJControls.RJButton rjButton1;
        private RJControls.RJButton btnReconocimiento;
        private RJControls.RJButton BtnPersonas;
        private RJControls.RJButton btnUbicaciones;
        private RJControls.RJButton btnUsuario;
        private System.Windows.Forms.Panel panelformularios;
        private RJControls.RJButton BtnOcultarMenu;
    }
}