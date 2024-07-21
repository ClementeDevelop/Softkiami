namespace Apresentacao
{
    partial class FrmCadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarProduto));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtPUnitario = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtDesignacao = new System.Windows.Forms.TextBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblPUnitario = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblCadastrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(686, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 160;
            this.pictureBox1.TabStop = false;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(267, 339);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(395, 29);
            this.cmbCategoria.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(423, 325);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 0);
            this.textBox1.TabIndex = 158;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(111, 344);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(83, 23);
            this.lblCategoria.TabIndex = 157;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtIVA
            // 
            this.txtIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIVA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(267, 216);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(2);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(395, 27);
            this.txtIVA.TabIndex = 2;
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIVA_KeyPress);
            // 
            // txtPUnitario
            // 
            this.txtPUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPUnitario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPUnitario.Location = new System.Drawing.Point(267, 255);
            this.txtPUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.txtPUnitario.Name = "txtPUnitario";
            this.txtPUnitario.Size = new System.Drawing.Size(395, 27);
            this.txtPUnitario.TabIndex = 3;
            this.txtPUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPUnitario_KeyPress);
            // 
            // txtDesconto
            // 
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(267, 297);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(395, 27);
            this.txtDesconto.TabIndex = 4;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            // 
            // txtDesignacao
            // 
            this.txtDesignacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesignacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignacao.Location = new System.Drawing.Point(267, 178);
            this.txtDesignacao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesignacao.Name = "txtDesignacao";
            this.txtDesignacao.Size = new System.Drawing.Size(395, 27);
            this.txtDesignacao.TabIndex = 1;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.Color.Black;
            this.lblIVA.Location = new System.Drawing.Point(113, 220);
            this.lblIVA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(37, 23);
            this.lblIVA.TabIndex = 151;
            this.lblIVA.Text = "IVA";
            // 
            // lblPUnitario
            // 
            this.lblPUnitario.AutoSize = true;
            this.lblPUnitario.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUnitario.ForeColor = System.Drawing.Color.Black;
            this.lblPUnitario.Location = new System.Drawing.Point(109, 259);
            this.lblPUnitario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPUnitario.Name = "lblPUnitario";
            this.lblPUnitario.Size = new System.Drawing.Size(120, 23);
            this.lblPUnitario.TabIndex = 149;
            this.lblPUnitario.Text = "Preço Unitário";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.Color.Black;
            this.lblDesconto.Location = new System.Drawing.Point(109, 301);
            this.lblDesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(83, 23);
            this.lblDesconto.TabIndex = 148;
            this.lblDesconto.Text = "Desconto";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(113, 182);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(98, 23);
            this.lblDescricao.TabIndex = 147;
            this.lblDescricao.Text = "Designação";
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
            this.btnCancelar.Location = new System.Drawing.Point(483, 389);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(179, 62);
            this.btnCancelar.TabIndex = 145;
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
            this.btnCadastrar.Location = new System.Drawing.Point(267, 389);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(179, 62);
            this.btnCadastrar.TabIndex = 146;
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.Location = new System.Drawing.Point(343, 87);
            this.lblCadastrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(256, 28);
            this.lblCadastrar.TabIndex = 144;
            this.lblCadastrar.Text = "Cadastro de produto";
            // 
            // FrmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtPUnitario);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtDesignacao);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblPUnitario);
            this.Controls.Add(this.lblDesconto);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtPUnitario;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtDesignacao;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblPUnitario;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblDescricao;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCadastrar;
        private System.Windows.Forms.Label lblCadastrar;
    }
}