namespace Apresentacao
{
    partial class FrmVenda
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
            Bunifu.Framework.UI.BunifuThinButton2 btnImprimir;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenda));
            Bunifu.Framework.UI.BunifuThinButton2 btnEliminar;
            Bunifu.Framework.UI.BunifuThinButton2 btnAdicionar;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListarProdutos = new System.Windows.Forms.ListBox();
            this.GrupoProdutos = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDesignacao = new System.Windows.Forms.TextBox();
            this.lblDesignacao = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.pnlPesquisa = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBoxPesquisa = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblVendas = new System.Windows.Forms.Label();
            this.ListarVendas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTipoPGT = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblEntrega = new System.Windows.Forms.Label();
            this.lblPaganento = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            btnImprimir = new Bunifu.Framework.UI.BunifuThinButton2();
            btnEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            btnAdicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.GrupoProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            btnImprimir.ActiveBorderThickness = 1;
            btnImprimir.ActiveCornerRadius = 20;
            btnImprimir.ActiveFillColor = System.Drawing.Color.Black;
            btnImprimir.ActiveForecolor = System.Drawing.Color.White;
            btnImprimir.ActiveLineColor = System.Drawing.Color.White;
            btnImprimir.BackColor = System.Drawing.Color.White;
            btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            btnImprimir.ButtonText = "Imprimir";
            btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            btnImprimir.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnImprimir.ForeColor = System.Drawing.Color.White;
            btnImprimir.IdleBorderThickness = 1;
            btnImprimir.IdleCornerRadius = 20;
            btnImprimir.IdleFillColor = System.Drawing.Color.ForestGreen;
            btnImprimir.IdleForecolor = System.Drawing.Color.White;
            btnImprimir.IdleLineColor = System.Drawing.Color.White;
            btnImprimir.Location = new System.Drawing.Point(716, 870);
            btnImprimir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new System.Drawing.Size(191, 53);
            btnImprimir.TabIndex = 99;
            btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            btnEliminar.ActiveBorderThickness = 1;
            btnEliminar.ActiveCornerRadius = 20;
            btnEliminar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            btnEliminar.ActiveForecolor = System.Drawing.Color.White;
            btnEliminar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            btnEliminar.BackColor = System.Drawing.Color.White;
            btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            btnEliminar.ButtonText = "Eliminar";
            btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEliminar.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEliminar.ForeColor = System.Drawing.Color.White;
            btnEliminar.IdleBorderThickness = 1;
            btnEliminar.IdleCornerRadius = 20;
            btnEliminar.IdleFillColor = System.Drawing.Color.Navy;
            btnEliminar.IdleForecolor = System.Drawing.Color.White;
            btnEliminar.IdleLineColor = System.Drawing.Color.White;
            btnEliminar.Location = new System.Drawing.Point(528, 345);
            btnEliminar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(136, 53);
            btnEliminar.TabIndex = 105;
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            btnAdicionar.ActiveBorderThickness = 1;
            btnAdicionar.ActiveCornerRadius = 20;
            btnAdicionar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            btnAdicionar.ActiveForecolor = System.Drawing.Color.White;
            btnAdicionar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            btnAdicionar.BackColor = System.Drawing.Color.White;
            btnAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.BackgroundImage")));
            btnAdicionar.ButtonText = "Adicionar";
            btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdicionar.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAdicionar.ForeColor = System.Drawing.Color.White;
            btnAdicionar.IdleBorderThickness = 1;
            btnAdicionar.IdleCornerRadius = 20;
            btnAdicionar.IdleFillColor = System.Drawing.Color.Navy;
            btnAdicionar.IdleForecolor = System.Drawing.Color.White;
            btnAdicionar.IdleLineColor = System.Drawing.Color.White;
            btnAdicionar.Location = new System.Drawing.Point(375, 345);
            btnAdicionar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new System.Drawing.Size(136, 53);
            btnAdicionar.TabIndex = 106;
            btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListarProdutos
            // 
            this.ListarProdutos.FormattingEnabled = true;
            this.ListarProdutos.Location = new System.Drawing.Point(24, 119);
            this.ListarProdutos.Name = "ListarProdutos";
            this.ListarProdutos.Size = new System.Drawing.Size(281, 290);
            this.ListarProdutos.TabIndex = 0;
            // 
            // GrupoProdutos
            // 
            this.GrupoProdutos.Controls.Add(this.numericUpDown1);
            this.GrupoProdutos.Controls.Add(this.textBox3);
            this.GrupoProdutos.Controls.Add(this.textBox1);
            this.GrupoProdutos.Controls.Add(this.txtDesignacao);
            this.GrupoProdutos.Controls.Add(this.lblDesignacao);
            this.GrupoProdutos.Controls.Add(this.lblTotal);
            this.GrupoProdutos.Controls.Add(this.lblPreco);
            this.GrupoProdutos.Controls.Add(this.lblQtd);
            this.GrupoProdutos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoProdutos.Location = new System.Drawing.Point(375, 82);
            this.GrupoProdutos.Name = "GrupoProdutos";
            this.GrupoProdutos.Size = new System.Drawing.Size(538, 254);
            this.GrupoProdutos.TabIndex = 1;
            this.GrupoProdutos.TabStop = false;
            this.GrupoProdutos.Text = "Produto";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(386, 69);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(146, 26);
            this.numericUpDown1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(386, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 26);
            this.textBox3.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(386, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 26);
            this.textBox1.TabIndex = 3;
            // 
            // txtDesignacao
            // 
            this.txtDesignacao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignacao.Location = new System.Drawing.Point(19, 57);
            this.txtDesignacao.Name = "txtDesignacao";
            this.txtDesignacao.Size = new System.Drawing.Size(224, 26);
            this.txtDesignacao.TabIndex = 3;
            // 
            // lblDesignacao
            // 
            this.lblDesignacao.AutoSize = true;
            this.lblDesignacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignacao.Location = new System.Drawing.Point(15, 33);
            this.lblDesignacao.Name = "lblDesignacao";
            this.lblDesignacao.Size = new System.Drawing.Size(104, 21);
            this.lblDesignacao.TabIndex = 2;
            this.lblDesignacao.Text = "Designação";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(267, 105);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 21);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(267, 33);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(118, 21);
            this.lblPreco.TabIndex = 0;
            this.lblPreco.Text = "Preço Unitário";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(267, 70);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(108, 21);
            this.lblQtd.TabIndex = 0;
            this.lblQtd.Text = "Quantidade";
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPesquisa.BackgroundImage")));
            this.pnlPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPesquisa.Controls.Add(this.pictureBoxPesquisa);
            this.pnlPesquisa.Controls.Add(this.txtPesquisa);
            this.pnlPesquisa.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlPesquisa.GradientBottomRight = System.Drawing.Color.White;
            this.pnlPesquisa.GradientTopLeft = System.Drawing.Color.White;
            this.pnlPesquisa.GradientTopRight = System.Drawing.Color.White;
            this.pnlPesquisa.Location = new System.Drawing.Point(24, 82);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Quality = 10;
            this.pnlPesquisa.Size = new System.Drawing.Size(281, 29);
            this.pnlPesquisa.TabIndex = 97;
            // 
            // pictureBoxPesquisa
            // 
            this.pictureBoxPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPesquisa.Image")));
            this.pictureBoxPesquisa.Location = new System.Drawing.Point(249, 2);
            this.pictureBoxPesquisa.Name = "pictureBoxPesquisa";
            this.pictureBoxPesquisa.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPesquisa.TabIndex = 54;
            this.pictureBoxPesquisa.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisa.Location = new System.Drawing.Point(12, 2);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(231, 26);
            this.txtPesquisa.TabIndex = 53;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendas.ForeColor = System.Drawing.Color.Black;
            this.lblVendas.Location = new System.Drawing.Point(460, 20);
            this.lblVendas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(85, 24);
            this.lblVendas.TabIndex = 85;
            this.lblVendas.Text = "Vendas";
            // 
            // ListarVendas
            // 
            this.ListarVendas.AllowUserToAddRows = false;
            this.ListarVendas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListarVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ListarVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListarVendas.BackgroundColor = System.Drawing.Color.LightGray;
            this.ListarVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListarVendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListarVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListarVendas.ColumnHeadersHeight = 25;
            this.ListarVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.PTotal});
            this.ListarVendas.DoubleBuffered = true;
            this.ListarVendas.EnableHeadersVisualStyles = false;
            this.ListarVendas.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.ListarVendas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.ListarVendas.HeaderForeColor = System.Drawing.Color.White;
            this.ListarVendas.Location = new System.Drawing.Point(24, 427);
            this.ListarVendas.Name = "ListarVendas";
            this.ListarVendas.ReadOnly = true;
            this.ListarVendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListarVendas.Size = new System.Drawing.Size(889, 233);
            this.ListarVendas.TabIndex = 107;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Designação";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Qtd";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "IVA";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Desconto";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PUnitario";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // PTotal
            // 
            this.PTotal.HeaderText = "PTotal";
            this.PTotal.Name = "PTotal";
            this.PTotal.ReadOnly = true;
            // 
            // cmbTipoPGT
            // 
            this.cmbTipoPGT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTipoPGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPGT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTipoPGT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPGT.FormattingEnabled = true;
            this.cmbTipoPGT.Location = new System.Drawing.Point(167, 726);
            this.cmbTipoPGT.Name = "cmbTipoPGT";
            this.cmbTipoPGT.Size = new System.Drawing.Size(218, 29);
            this.cmbTipoPGT.TabIndex = 119;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(741, 772);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(171, 24);
            this.textBox8.TabIndex = 114;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(741, 730);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(171, 24);
            this.textBox7.TabIndex = 115;
            // 
            // txtOperador
            // 
            this.txtOperador.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperador.Location = new System.Drawing.Point(167, 768);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(218, 27);
            this.txtOperador.TabIndex = 116;
            // 
            // txtMoeda
            // 
            this.txtMoeda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoeda.Location = new System.Drawing.Point(167, 686);
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.Size = new System.Drawing.Size(218, 27);
            this.txtMoeda.TabIndex = 117;
            this.txtMoeda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(741, 690);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(171, 24);
            this.textBox2.TabIndex = 118;
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.ForeColor = System.Drawing.Color.Black;
            this.lblOperador.Location = new System.Drawing.Point(20, 770);
            this.lblOperador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(122, 22);
            this.lblOperador.TabIndex = 108;
            this.lblOperador.Text = "OPERADOR";
            // 
            // lblEntrega
            // 
            this.lblEntrega.AutoSize = true;
            this.lblEntrega.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrega.ForeColor = System.Drawing.Color.Black;
            this.lblEntrega.Location = new System.Drawing.Point(622, 726);
            this.lblEntrega.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrega.Name = "lblEntrega";
            this.lblEntrega.Size = new System.Drawing.Size(114, 24);
            this.lblEntrega.TabIndex = 109;
            this.lblEntrega.Text = "ENTREGA";
            // 
            // lblPaganento
            // 
            this.lblPaganento.AutoSize = true;
            this.lblPaganento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaganento.ForeColor = System.Drawing.Color.Black;
            this.lblPaganento.Location = new System.Drawing.Point(20, 728);
            this.lblPaganento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaganento.Name = "lblPaganento";
            this.lblPaganento.Size = new System.Drawing.Size(136, 22);
            this.lblPaganento.TabIndex = 110;
            this.lblPaganento.Text = "PAGAMENTO";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.Black;
            this.lblTroco.Location = new System.Drawing.Point(622, 768);
            this.lblTroco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(88, 24);
            this.lblTroco.TabIndex = 111;
            this.lblTroco.Text = "TROCO";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoeda.ForeColor = System.Drawing.Color.Black;
            this.lblMoeda.Location = new System.Drawing.Point(20, 688);
            this.lblMoeda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(82, 22);
            this.lblMoeda.TabIndex = 112;
            this.lblMoeda.Text = "MOEDA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(622, 686);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 113;
            this.label1.Text = "TOTAL";
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 964);
            this.Controls.Add(this.cmbTipoPGT);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txtOperador);
            this.Controls.Add(this.txtMoeda);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblOperador);
            this.Controls.Add(this.lblEntrega);
            this.Controls.Add(this.lblPaganento);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListarVendas);
            this.Controls.Add(btnEliminar);
            this.Controls.Add(btnAdicionar);
            this.Controls.Add(btnImprimir);
            this.Controls.Add(this.lblVendas);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.GrupoProdutos);
            this.Controls.Add(this.ListarProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVenda1";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            this.GrupoProdutos.ResumeLayout(false);
            this.GrupoProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListarProdutos;
        private System.Windows.Forms.GroupBox GrupoProdutos;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDesignacao;
        private System.Windows.Forms.Label lblDesignacao;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQtd;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlPesquisa;
        private System.Windows.Forms.PictureBox pictureBoxPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblVendas;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ListarVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTotal;
        private System.Windows.Forms.ComboBox cmbTipoPGT;
        public System.Windows.Forms.TextBox textBox8;
        public System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.TextBox txtMoeda;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblEntrega;
        private System.Windows.Forms.Label lblPaganento;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.Label label1;
    }
}