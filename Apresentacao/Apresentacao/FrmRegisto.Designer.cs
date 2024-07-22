namespace Apresentacao
{
    partial class FrmRegisto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegisto));
            this.lblCadastrar = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.lblUtilizador = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNIF = new System.Windows.Forms.Label();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtutilizador = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.comboFuncao = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.comboProvin = new System.Windows.Forms.ComboBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.comboMuni = new System.Windows.Forms.ComboBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblDataRegist = new System.Windows.Forms.Label();
            this.comboBairro = new System.Windows.Forms.ComboBox();
            this.comboRua = new System.Windows.Forms.ComboBox();
            this.comboEstadoCiv = new System.Windows.Forms.ComboBox();
            this.lblEstadoCiv = new System.Windows.Forms.Label();
            this.dateTimeDataRegist = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDataNasc = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.Location = new System.Drawing.Point(554, 9);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(156, 28);
            this.lblCadastrar.TabIndex = 1;
            this.lblCadastrar.Text = "Cadastre-se";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1194, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 23;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 44);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ActiveBorderThickness = 1;
            this.btnCadastrar.ActiveCornerRadius = 20;
            this.btnCadastrar.ActiveFillColor = System.Drawing.Color.Black;
            this.btnCadastrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCadastrar.ActiveLineColor = System.Drawing.Color.White;
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.BackgroundImage")));
            this.btnCadastrar.ButtonText = "Cadastrar";
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.IdleBorderThickness = 1;
            this.btnCadastrar.IdleCornerRadius = 20;
            this.btnCadastrar.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCadastrar.IdleForecolor = System.Drawing.Color.White;
            this.btnCadastrar.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCadastrar.Location = new System.Drawing.Point(81, 337);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(1079, 43);
            this.btnCadastrar.TabIndex = 44;
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(76, 65);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(78, 22);
            this.lblCodigo.TabIndex = 45;
            this.lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(191, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(65, 22);
            this.lblNome.TabIndex = 46;
            this.lblNome.Text = "Nome";
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNasc.Location = new System.Drawing.Point(600, 65);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(201, 22);
            this.lblDataNasc.TabIndex = 47;
            this.lblDataNasc.Text = "Data de Nascimento";
            // 
            // lblUtilizador
            // 
            this.lblUtilizador.AutoSize = true;
            this.lblUtilizador.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizador.Location = new System.Drawing.Point(77, 125);
            this.lblUtilizador.Name = "lblUtilizador";
            this.lblUtilizador.Size = new System.Drawing.Size(90, 22);
            this.lblUtilizador.TabIndex = 48;
            this.lblUtilizador.Text = "Utilizador";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(480, 125);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(68, 22);
            this.lblSenha.TabIndex = 49;
            this.lblSenha.Text = "Senha";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(727, 185);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(33, 22);
            this.lblTel.TabIndex = 50;
            this.lblTel.Text = "Tel";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(77, 185);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 22);
            this.lblEmail.TabIndex = 51;
            this.lblEmail.Text = "Email";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIF.Location = new System.Drawing.Point(886, 65);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(38, 22);
            this.lblNIF.TabIndex = 52;
            this.lblNIF.Text = "NIF";
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncao.Location = new System.Drawing.Point(886, 125);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(80, 22);
            this.lblFuncao.TabIndex = 53;
            this.lblFuncao.Text = "Função";
            this.lblFuncao.Click += new System.EventHandler(this.lblFuncao_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(424, 186);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(81, 22);
            this.lblGenero.TabIndex = 54;
            this.lblGenero.Text = "Género";
            this.lblGenero.Click += new System.EventHandler(this.ComboBo_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(80, 90);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 25);
            this.txtCodigo.TabIndex = 55;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(195, 90);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(389, 25);
            this.txtNome.TabIndex = 56;
            // 
            // txtutilizador
            // 
            this.txtutilizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtutilizador.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtutilizador.Location = new System.Drawing.Point(80, 150);
            this.txtutilizador.Multiline = true;
            this.txtutilizador.Name = "txtutilizador";
            this.txtutilizador.Size = new System.Drawing.Size(389, 25);
            this.txtutilizador.TabIndex = 57;
            // 
            // txtsenha
            // 
            this.txtsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsenha.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsenha.Location = new System.Drawing.Point(484, 150);
            this.txtsenha.Multiline = true;
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.Size = new System.Drawing.Size(389, 25);
            this.txtsenha.TabIndex = 58;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(80, 210);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(333, 25);
            this.txtEmail.TabIndex = 60;
            // 
            // txtNIF
            // 
            this.txtNIF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIF.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(890, 90);
            this.txtNIF.Multiline = true;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(269, 25);
            this.txtNIF.TabIndex = 61;
            // 
            // comboGenero
            // 
            this.comboGenero.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Items.AddRange(new object[] {
            "Mascúlino",
            "Feminino"});
            this.comboGenero.Location = new System.Drawing.Point(428, 211);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(144, 29);
            this.comboGenero.TabIndex = 62;
            // 
            // comboFuncao
            // 
            this.comboFuncao.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFuncao.FormattingEnabled = true;
            this.comboFuncao.Items.AddRange(new object[] {
            "Administrador",
            "Operador"});
            this.comboFuncao.Location = new System.Drawing.Point(890, 150);
            this.comboFuncao.Name = "comboFuncao";
            this.comboFuncao.Size = new System.Drawing.Size(269, 29);
            this.comboFuncao.TabIndex = 63;
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(731, 209);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(142, 25);
            this.txtTel.TabIndex = 64;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.Location = new System.Drawing.Point(886, 185);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(95, 22);
            this.lblProvincia.TabIndex = 65;
            this.lblProvincia.Text = "Província";
            // 
            // comboProvin
            // 
            this.comboProvin.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProvin.FormattingEnabled = true;
            this.comboProvin.Items.AddRange(new object[] {
            "Luanda",
            "Malanje",
            "Huambo",
            "Cuanza Norte",
            "Bié"});
            this.comboProvin.Location = new System.Drawing.Point(890, 209);
            this.comboProvin.Name = "comboProvin";
            this.comboProvin.Size = new System.Drawing.Size(269, 29);
            this.comboProvin.TabIndex = 66;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.Location = new System.Drawing.Point(77, 243);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(97, 22);
            this.lblMunicipio.TabIndex = 67;
            this.lblMunicipio.Text = "Munícipio";
            // 
            // comboMuni
            // 
            this.comboMuni.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMuni.FormattingEnabled = true;
            this.comboMuni.Items.AddRange(new object[] {
            "Viana",
            "Cazenga",
            "Cacuaco"});
            this.comboMuni.Location = new System.Drawing.Point(81, 268);
            this.comboMuni.Name = "comboMuni";
            this.comboMuni.Size = new System.Drawing.Size(249, 29);
            this.comboMuni.TabIndex = 68;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(620, 243);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(47, 22);
            this.lblRua.TabIndex = 69;
            this.lblRua.Text = "Rua";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(352, 243);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(61, 22);
            this.lblBairro.TabIndex = 70;
            this.lblBairro.Text = "Bairro";
            // 
            // lblDataRegist
            // 
            this.lblDataRegist.AutoSize = true;
            this.lblDataRegist.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRegist.Location = new System.Drawing.Point(886, 243);
            this.lblDataRegist.Name = "lblDataRegist";
            this.lblDataRegist.Size = new System.Drawing.Size(158, 22);
            this.lblDataRegist.TabIndex = 71;
            this.lblDataRegist.Text = "Data de Registo";
            // 
            // comboBairro
            // 
            this.comboBairro.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBairro.FormattingEnabled = true;
            this.comboBairro.Items.AddRange(new object[] {
            "Distrito Urbano do Zango"});
            this.comboBairro.Location = new System.Drawing.Point(356, 268);
            this.comboBairro.Name = "comboBairro";
            this.comboBairro.Size = new System.Drawing.Size(249, 29);
            this.comboBairro.TabIndex = 72;
            // 
            // comboRua
            // 
            this.comboRua.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRua.FormattingEnabled = true;
            this.comboRua.Location = new System.Drawing.Point(624, 268);
            this.comboRua.Name = "comboRua";
            this.comboRua.Size = new System.Drawing.Size(249, 29);
            this.comboRua.TabIndex = 73;
            // 
            // comboEstadoCiv
            // 
            this.comboEstadoCiv.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstadoCiv.FormattingEnabled = true;
            this.comboEstadoCiv.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Viúvo"});
            this.comboEstadoCiv.Location = new System.Drawing.Point(581, 211);
            this.comboEstadoCiv.Name = "comboEstadoCiv";
            this.comboEstadoCiv.Size = new System.Drawing.Size(144, 29);
            this.comboEstadoCiv.TabIndex = 75;
            // 
            // lblEstadoCiv
            // 
            this.lblEstadoCiv.AutoSize = true;
            this.lblEstadoCiv.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCiv.Location = new System.Drawing.Point(577, 185);
            this.lblEstadoCiv.Name = "lblEstadoCiv";
            this.lblEstadoCiv.Size = new System.Drawing.Size(111, 22);
            this.lblEstadoCiv.TabIndex = 76;
            this.lblEstadoCiv.Text = "Estado civil";
            // 
            // dateTimeDataRegist
            // 
            this.dateTimeDataRegist.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDataRegist.Location = new System.Drawing.Point(890, 268);
            this.dateTimeDataRegist.Name = "dateTimeDataRegist";
            this.dateTimeDataRegist.Size = new System.Drawing.Size(269, 30);
            this.dateTimeDataRegist.TabIndex = 77;
            // 
            // dateTimeDataNasc
            // 
            this.dateTimeDataNasc.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDataNasc.Location = new System.Drawing.Point(604, 90);
            this.dateTimeDataNasc.Name = "dateTimeDataNasc";
            this.dateTimeDataNasc.Size = new System.Drawing.Size(269, 30);
            this.dateTimeDataNasc.TabIndex = 78;
            // 
            // FrmRegisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1240, 419);
            this.Controls.Add(this.dateTimeDataNasc);
            this.Controls.Add(this.dateTimeDataRegist);
            this.Controls.Add(this.lblEstadoCiv);
            this.Controls.Add(this.comboEstadoCiv);
            this.Controls.Add(this.comboRua);
            this.Controls.Add(this.comboBairro);
            this.Controls.Add(this.lblDataRegist);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.comboMuni);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.comboProvin);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.comboFuncao);
            this.Controls.Add(this.comboGenero);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtutilizador);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUtilizador);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCadastrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegisto";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de utilizador";
            this.Load += new System.EventHandler(this.FrmRegisto_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmRegisto_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastrar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCadastrar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.Label lblUtilizador;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtutilizador;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.ComboBox comboGenero;
        private System.Windows.Forms.ComboBox comboFuncao;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox comboProvin;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.ComboBox comboMuni;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblDataRegist;
        private System.Windows.Forms.ComboBox comboBairro;
        private System.Windows.Forms.ComboBox comboRua;
        private System.Windows.Forms.ComboBox comboEstadoCiv;
        private System.Windows.Forms.Label lblEstadoCiv;
        private System.Windows.Forms.DateTimePicker dateTimeDataRegist;
        private System.Windows.Forms.DateTimePicker dateTimeDataNasc;
    }
}