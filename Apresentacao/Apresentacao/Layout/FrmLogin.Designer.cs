namespace Apresentacao
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlBackGround = new System.Windows.Forms.Panel();
            this.pnlUtilizador = new System.Windows.Forms.Panel();
            this.pictureBoxUtilizador = new System.Windows.Forms.PictureBox();
            this.txtUtilizador = new System.Windows.Forms.TextBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.pnlSenha = new System.Windows.Forms.Panel();
            this.pictureBoxEye = new System.Windows.Forms.PictureBox();
            this.pictureBoxLock = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSoftkiami = new System.Windows.Forms.Label();
            this.LoginLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlBackGround.SuspendLayout();
            this.pnlUtilizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.pnlSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLock)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackGround
            // 
            this.pnlBackGround.BackColor = System.Drawing.Color.White;
            this.pnlBackGround.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBackGround.Controls.Add(this.pnlUtilizador);
            this.pnlBackGround.Controls.Add(this.pictureUser);
            this.pnlBackGround.Controls.Add(this.pnlSenha);
            this.pnlBackGround.Controls.Add(this.btnEntrar);
            this.pnlBackGround.Controls.Add(this.pnlSuperior);
            this.pnlBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackGround.Location = new System.Drawing.Point(0, 0);
            this.pnlBackGround.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBackGround.Name = "pnlBackGround";
            this.pnlBackGround.Size = new System.Drawing.Size(450, 534);
            this.pnlBackGround.TabIndex = 1;
            // 
            // pnlUtilizador
            // 
            this.pnlUtilizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUtilizador.Controls.Add(this.pictureBoxUtilizador);
            this.pnlUtilizador.Controls.Add(this.txtUtilizador);
            this.pnlUtilizador.Location = new System.Drawing.Point(66, 324);
            this.pnlUtilizador.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUtilizador.Name = "pnlUtilizador";
            this.pnlUtilizador.Size = new System.Drawing.Size(315, 28);
            this.pnlUtilizador.TabIndex = 10;
            // 
            // pictureBoxUtilizador
            // 
            this.pictureBoxUtilizador.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUtilizador.Image")));
            this.pictureBoxUtilizador.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxUtilizador.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUtilizador.Name = "pictureBoxUtilizador";
            this.pictureBoxUtilizador.Size = new System.Drawing.Size(26, 20);
            this.pictureBoxUtilizador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUtilizador.TabIndex = 1;
            this.pictureBoxUtilizador.TabStop = false;
            // 
            // txtUtilizador
            // 
            this.txtUtilizador.BackColor = System.Drawing.Color.White;
            this.txtUtilizador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUtilizador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilizador.Location = new System.Drawing.Point(32, 3);
            this.txtUtilizador.Margin = new System.Windows.Forms.Padding(2);
            this.txtUtilizador.Name = "txtUtilizador";
            this.txtUtilizador.Size = new System.Drawing.Size(279, 20);
            this.txtUtilizador.TabIndex = 0;
            this.txtUtilizador.Text = "Utilizador";
            this.txtUtilizador.Enter += new System.EventHandler(this.txtUtilizador_Enter);
            this.txtUtilizador.Leave += new System.EventHandler(this.txtUtilizador_Leave);
            // 
            // pictureUser
            // 
            this.pictureUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureUser.Image")));
            this.pictureUser.Location = new System.Drawing.Point(133, 145);
            this.pictureUser.Margin = new System.Windows.Forms.Padding(2);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(181, 127);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUser.TabIndex = 13;
            this.pictureUser.TabStop = false;
            // 
            // pnlSenha
            // 
            this.pnlSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSenha.Controls.Add(this.pictureBoxEye);
            this.pnlSenha.Controls.Add(this.pictureBoxLock);
            this.pnlSenha.Controls.Add(this.txtSenha);
            this.pnlSenha.Location = new System.Drawing.Point(66, 365);
            this.pnlSenha.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSenha.Name = "pnlSenha";
            this.pnlSenha.Size = new System.Drawing.Size(315, 28);
            this.pnlSenha.TabIndex = 11;
            // 
            // pictureBoxEye
            // 
            this.pictureBoxEye.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEye.Image")));
            this.pictureBoxEye.Location = new System.Drawing.Point(274, 4);
            this.pictureBoxEye.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEye.Name = "pictureBoxEye";
            this.pictureBoxEye.Size = new System.Drawing.Size(32, 18);
            this.pictureBoxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEye.TabIndex = 2;
            this.pictureBoxEye.TabStop = false;
            this.pictureBoxEye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxEye_MouseDown);
            this.pictureBoxEye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxEye_MouseUp);
            // 
            // pictureBoxLock
            // 
            this.pictureBoxLock.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLock.Image")));
            this.pictureBoxLock.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxLock.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLock.Name = "pictureBoxLock";
            this.pictureBoxLock.Size = new System.Drawing.Size(26, 20);
            this.pictureBoxLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLock.TabIndex = 1;
            this.pictureBoxLock.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(32, 3);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(236, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // btnEntrar
            // 
            this.btnEntrar.ActiveBorderThickness = 1;
            this.btnEntrar.ActiveCornerRadius = 20;
            this.btnEntrar.ActiveFillColor = System.Drawing.Color.Black;
            this.btnEntrar.ActiveForecolor = System.Drawing.Color.Gainsboro;
            this.btnEntrar.ActiveLineColor = System.Drawing.Color.White;
            this.btnEntrar.BackColor = System.Drawing.Color.White;
            this.btnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.BackgroundImage")));
            this.btnEntrar.ButtonText = "Entrar";
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEntrar.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEntrar.IdleBorderThickness = 1;
            this.btnEntrar.IdleCornerRadius = 20;
            this.btnEntrar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnEntrar.IdleForecolor = System.Drawing.Color.White;
            this.btnEntrar.IdleLineColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(60, 424);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(327, 54);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.pnlSuperior.Controls.Add(this.bunifuCustomLabel1);
            this.pnlSuperior.Controls.Add(this.lblSoftkiami);
            this.pnlSuperior.Controls.Add(this.LoginLogo);
            this.pnlSuperior.Controls.Add(this.btnClose);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(448, 105);
            this.pnlSuperior.TabIndex = 8;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlVertical_MouseDown);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(163, 81);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(113, 22);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Versão: 1.0";
            // 
            // lblSoftkiami
            // 
            this.lblSoftkiami.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoftkiami.ForeColor = System.Drawing.Color.White;
            this.lblSoftkiami.Location = new System.Drawing.Point(100, 34);
            this.lblSoftkiami.Name = "lblSoftkiami";
            this.lblSoftkiami.Size = new System.Drawing.Size(137, 29);
            this.lblSoftkiami.TabIndex = 14;
            this.lblSoftkiami.Text = "SOFTKIAMI";
            // 
            // LoginLogo
            // 
            this.LoginLogo.Image = ((System.Drawing.Image)(resources.GetObject("LoginLogo.Image")));
            this.LoginLogo.Location = new System.Drawing.Point(-1, 3);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(95, 88);
            this.LoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginLogo.TabIndex = 13;
            this.LoginLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(386, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 36);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 9;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 100;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 534);
            this.Controls.Add(this.pnlBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlBackGround.ResumeLayout(false);
            this.pnlUtilizador.ResumeLayout(false);
            this.pnlUtilizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUtilizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.pnlSenha.ResumeLayout(false);
            this.pnlSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLock)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBackGround;
        private System.Windows.Forms.Panel pnlUtilizador;
        private System.Windows.Forms.PictureBox pictureBoxUtilizador;
        private System.Windows.Forms.TextBox txtUtilizador;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel pnlSenha;
        private System.Windows.Forms.PictureBox pictureBoxEye;
        private System.Windows.Forms.PictureBox pictureBoxLock;
        private System.Windows.Forms.TextBox txtSenha;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEntrar;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox LoginLogo;
        private System.Windows.Forms.Label lblSoftkiami;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}