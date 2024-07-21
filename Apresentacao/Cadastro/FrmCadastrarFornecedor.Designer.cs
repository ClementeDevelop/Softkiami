namespace Apresentacao
{
    partial class FrmCadastrarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarFornecedor));
            this.dateTimeDataRegist = new System.Windows.Forms.DateTimePicker();
            this.lblEstadoCiv = new System.Windows.Forms.Label();
            this.comboEstadoCiv = new System.Windows.Forms.ComboBox();
            this.lblDataRegist = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.dateTimeDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtProvin = new System.Windows.Forms.TextBox();
            this.txtMuni = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimeDataRegist
            // 
            this.dateTimeDataRegist.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDataRegist.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataRegist.Location = new System.Drawing.Point(737, 231);
            this.dateTimeDataRegist.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeDataRegist.Name = "dateTimeDataRegist";
            this.dateTimeDataRegist.Size = new System.Drawing.Size(358, 25);
            this.dateTimeDataRegist.TabIndex = 7;
            // 
            // lblEstadoCiv
            // 
            this.lblEstadoCiv.AutoSize = true;
            this.lblEstadoCiv.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCiv.ForeColor = System.Drawing.Color.Black;
            this.lblEstadoCiv.Location = new System.Drawing.Point(99, 287);
            this.lblEstadoCiv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstadoCiv.Name = "lblEstadoCiv";
            this.lblEstadoCiv.Size = new System.Drawing.Size(95, 23);
            this.lblEstadoCiv.TabIndex = 179;
            this.lblEstadoCiv.Text = "Estado civil";
            // 
            // comboEstadoCiv
            // 
            this.comboEstadoCiv.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstadoCiv.FormattingEnabled = true;
            this.comboEstadoCiv.Items.AddRange(new object[] {
            "Solteiro (a)",
            "Casado (a)",
            "Divorciado (a)",
            "Viúvo (a)"});
            this.comboEstadoCiv.Location = new System.Drawing.Point(208, 289);
            this.comboEstadoCiv.Margin = new System.Windows.Forms.Padding(4);
            this.comboEstadoCiv.Name = "comboEstadoCiv";
            this.comboEstadoCiv.Size = new System.Drawing.Size(139, 27);
            this.comboEstadoCiv.TabIndex = 3;
            // 
            // lblDataRegist
            // 
            this.lblDataRegist.AutoSize = true;
            this.lblDataRegist.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRegist.ForeColor = System.Drawing.Color.Black;
            this.lblDataRegist.Location = new System.Drawing.Point(563, 239);
            this.lblDataRegist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataRegist.Name = "lblDataRegist";
            this.lblDataRegist.Size = new System.Drawing.Size(129, 23);
            this.lblDataRegist.TabIndex = 175;
            this.lblDataRegist.Text = "Data de Registo";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.Color.Black;
            this.lblBairro.Location = new System.Drawing.Point(99, 378);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(57, 23);
            this.lblBairro.TabIndex = 174;
            this.lblBairro.Text = "Bairro";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.ForeColor = System.Drawing.Color.Black;
            this.lblRua.Location = new System.Drawing.Point(99, 414);
            this.lblRua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(39, 23);
            this.lblRua.TabIndex = 173;
            this.lblRua.Text = "Rua";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.ForeColor = System.Drawing.Color.Black;
            this.lblMunicipio.Location = new System.Drawing.Point(564, 341);
            this.lblMunicipio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(86, 23);
            this.lblMunicipio.TabIndex = 171;
            this.lblMunicipio.Text = "Munícipio";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.ForeColor = System.Drawing.Color.Black;
            this.lblProvincia.Location = new System.Drawing.Point(99, 331);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(81, 23);
            this.lblProvincia.TabIndex = 169;
            this.lblProvincia.Text = "Província";
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(401, 285);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(137, 30);
            this.txtTel.TabIndex = 4;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // cmbGenero
            // 
            this.cmbGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbGenero.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Mascúlino",
            "Feminino"});
            this.cmbGenero.Location = new System.Drawing.Point(738, 303);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(358, 27);
            this.cmbGenero.TabIndex = 9;
            // 
            // txtNIF
            // 
            this.txtNIF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIF.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(208, 239);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIF.Multiline = true;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(331, 30);
            this.txtNIF.TabIndex = 2;
            this.txtNIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIF_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(738, 265);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(358, 30);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(208, 201);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(330, 30);
            this.txtNome.TabIndex = 1;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.Black;
            this.lblGenero.Location = new System.Drawing.Point(564, 299);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(67, 23);
            this.lblGenero.TabIndex = 160;
            this.lblGenero.Text = "Género";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.ForeColor = System.Drawing.Color.Black;
            this.lblNIF.Location = new System.Drawing.Point(99, 239);
            this.lblNIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(37, 23);
            this.lblNIF.TabIndex = 158;
            this.lblNIF.Text = "NIF";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(564, 267);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 157;
            this.lblEmail.Text = "Email";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.Black;
            this.lblTel.Location = new System.Drawing.Point(361, 291);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(30, 23);
            this.lblTel.TabIndex = 156;
            this.lblTel.Text = "Tel";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.ForeColor = System.Drawing.Color.Black;
            this.lblDataNasc.Location = new System.Drawing.Point(563, 203);
            this.lblDataNasc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(164, 23);
            this.lblDataNasc.TabIndex = 153;
            this.lblDataNasc.Text = "Data de Nascimento";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Black;
            this.lblNome.Location = new System.Drawing.Point(99, 203);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 23);
            this.lblNome.TabIndex = 152;
            this.lblNome.Text = "Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.Navy;
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.White;
            this.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.btnCancelar.Location = new System.Drawing.Point(622, 522);
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
            this.btnCadastrar.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.btnCadastrar.Location = new System.Drawing.Point(365, 522);
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
            this.lblCadastrar.BackColor = System.Drawing.Color.White;
            this.lblCadastrar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.Location = new System.Drawing.Point(482, 112);
            this.lblCadastrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(293, 28);
            this.lblCadastrar.TabIndex = 149;
            this.lblCadastrar.Text = "Cadastro de fornecedor";
            // 
            // dateTimeDataNasc
            // 
            this.dateTimeDataNasc.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDataNasc.Location = new System.Drawing.Point(738, 198);
            this.dateTimeDataNasc.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeDataNasc.Name = "dateTimeDataNasc";
            this.dateTimeDataNasc.Size = new System.Drawing.Size(357, 25);
            this.dateTimeDataNasc.TabIndex = 6;
            // 
            // txtProvin
            // 
            this.txtProvin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProvin.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvin.Location = new System.Drawing.Point(209, 332);
            this.txtProvin.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvin.Multiline = true;
            this.txtProvin.Name = "txtProvin";
            this.txtProvin.Size = new System.Drawing.Size(330, 30);
            this.txtProvin.TabIndex = 5;
            // 
            // txtMuni
            // 
            this.txtMuni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMuni.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMuni.Location = new System.Drawing.Point(738, 337);
            this.txtMuni.Margin = new System.Windows.Forms.Padding(4);
            this.txtMuni.Multiline = true;
            this.txtMuni.Name = "txtMuni";
            this.txtMuni.Size = new System.Drawing.Size(357, 30);
            this.txtMuni.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(209, 373);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(886, 30);
            this.txtBairro.TabIndex = 11;
            // 
            // txtRua
            // 
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(208, 415);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtRua.Multiline = true;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(888, 30);
            this.txtRua.TabIndex = 12;
            // 
            // FrmCadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 694);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtMuni);
            this.Controls.Add(this.txtProvin);
            this.Controls.Add(this.dateTimeDataNasc);
            this.Controls.Add(this.dateTimeDataRegist);
            this.Controls.Add(this.lblEstadoCiv);
            this.Controls.Add(this.comboEstadoCiv);
            this.Controls.Add(this.lblDataRegist);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrarFornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimeDataRegist;
        private System.Windows.Forms.Label lblEstadoCiv;
        private System.Windows.Forms.ComboBox comboEstadoCiv;
        private System.Windows.Forms.Label lblDataRegist;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblNome;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCadastrar;
        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.DateTimePicker dateTimeDataNasc;
        private System.Windows.Forms.TextBox txtProvin;
        private System.Windows.Forms.TextBox txtMuni;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
    }
}