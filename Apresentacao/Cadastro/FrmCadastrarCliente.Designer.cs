namespace Apresentacao
{
    partial class FrmCadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarCliente));
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.dateTimeDataRegist = new System.Windows.Forms.DateTimePicker();
            this.lblDataRegist = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.White;
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 20;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.btnCancelar.IdleForecolor = System.Drawing.Color.White;
            this.btnCancelar.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Location = new System.Drawing.Point(558, 556);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(214, 62);
            this.btnCancelar.TabIndex = 150;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ActiveBorderThickness = 1;
            this.btnCadastrar.ActiveCornerRadius = 20;
            this.btnCadastrar.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnCadastrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCadastrar.ActiveLineColor = System.Drawing.Color.White;
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.BackgroundImage")));
            this.btnCadastrar.ButtonText = "Cadastrar";
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.IdleBorderThickness = 1;
            this.btnCadastrar.IdleCornerRadius = 20;
            this.btnCadastrar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.btnCadastrar.IdleForecolor = System.Drawing.Color.White;
            this.btnCadastrar.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrar.Location = new System.Drawing.Point(301, 556);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(214, 62);
            this.btnCadastrar.TabIndex = 151;
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.Location = new System.Drawing.Point(415, 131);
            this.lblCadastrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(243, 28);
            this.lblCadastrar.TabIndex = 149;
            this.lblCadastrar.Text = "Cadastro de cliente";
            // 
            // dateTimeDataRegist
            // 
            this.dateTimeDataRegist.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDataRegist.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataRegist.Location = new System.Drawing.Point(365, 424);
            this.dateTimeDataRegist.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeDataRegist.Name = "dateTimeDataRegist";
            this.dateTimeDataRegist.Size = new System.Drawing.Size(330, 25);
            this.dateTimeDataRegist.TabIndex = 5;
            // 
            // lblDataRegist
            // 
            this.lblDataRegist.AutoSize = true;
            this.lblDataRegist.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRegist.ForeColor = System.Drawing.Color.Black;
            this.lblDataRegist.Location = new System.Drawing.Point(170, 426);
            this.lblDataRegist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataRegist.Name = "lblDataRegist";
            this.lblDataRegist.Size = new System.Drawing.Size(129, 23);
            this.lblDataRegist.TabIndex = 197;
            this.lblDataRegist.Text = "Data de Registo";
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(366, 372);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(325, 27);
            this.txtTel.TabIndex = 4;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtNIF
            // 
            this.txtNIF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIF.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(366, 272);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIF.Multiline = true;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(331, 27);
            this.txtNIF.TabIndex = 2;
            this.txtNIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIF_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(366, 320);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(366, 220);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(330, 27);
            this.txtNome.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(170, 319);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 185;
            this.lblEmail.Text = "Email";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.Black;
            this.lblTel.Location = new System.Drawing.Point(170, 371);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(30, 23);
            this.lblTel.TabIndex = 184;
            this.lblTel.Text = "Tel";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(170, 222);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 23);
            this.lblNome.TabIndex = 182;
            this.lblNome.Text = "Nome";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.ForeColor = System.Drawing.Color.Black;
            this.lblNIF.Location = new System.Drawing.Point(170, 274);
            this.lblNIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(37, 23);
            this.lblNIF.TabIndex = 204;
            this.lblNIF.Text = "NIF";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 205;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1239, 1006);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.dateTimeDataRegist);
            this.Controls.Add(this.lblDataRegist);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCadastrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCadastrar;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.DateTimePicker dateTimeDataRegist;
        private System.Windows.Forms.Label lblDataRegist;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}