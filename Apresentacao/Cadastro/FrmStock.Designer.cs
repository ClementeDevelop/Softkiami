namespace Apresentacao
{
    partial class FrmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblOrigem = new System.Windows.Forms.Label();
            this.lblDataFabrico = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblDataExpiracao = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.numericUpDownQtd = new System.Windows.Forms.NumericUpDown();
            this.dateTimeFabrico = new System.Windows.Forms.DateTimePicker();
            this.dateTimeExpiracao = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.lblCodProdut = new System.Windows.Forms.Label();
            this.txtCodProdut = new System.Windows.Forms.TextBox();
            this.lblCodStock = new System.Windows.Forms.Label();
            this.txtCodStock = new System.Windows.Forms.TextBox();
            this.lblStockMax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownStockMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStockMin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockMin)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(459, 467);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 0);
            this.textBox1.TabIndex = 174;
            // 
            // lblOrigem
            // 
            this.lblOrigem.AutoSize = true;
            this.lblOrigem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigem.Location = new System.Drawing.Point(176, 193);
            this.lblOrigem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrigem.Name = "lblOrigem";
            this.lblOrigem.Size = new System.Drawing.Size(67, 23);
            this.lblOrigem.TabIndex = 173;
            this.lblOrigem.Text = "Origem";
            // 
            // lblDataFabrico
            // 
            this.lblDataFabrico.AutoSize = true;
            this.lblDataFabrico.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFabrico.Location = new System.Drawing.Point(513, 263);
            this.lblDataFabrico.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataFabrico.Name = "lblDataFabrico";
            this.lblDataFabrico.Size = new System.Drawing.Size(153, 23);
            this.lblDataFabrico.TabIndex = 167;
            this.lblDataFabrico.Text = "Data de fabricação";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(513, 190);
            this.lblQtd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(101, 23);
            this.lblQtd.TabIndex = 166;
            this.lblQtd.Text = "Quantidade";
            // 
            // lblDataExpiracao
            // 
            this.lblDataExpiracao.AutoSize = true;
            this.lblDataExpiracao.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataExpiracao.Location = new System.Drawing.Point(513, 331);
            this.lblDataExpiracao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataExpiracao.Name = "lblDataExpiracao";
            this.lblDataExpiracao.Size = new System.Drawing.Size(147, 23);
            this.lblDataExpiracao.TabIndex = 165;
            this.lblDataExpiracao.Text = "Data de expiração";
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(178, 416);
            this.lblDataEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(133, 23);
            this.lblDataEntrada.TabIndex = 164;
            this.lblDataEntrada.Text = "Data de entrada";
            this.lblDataEntrada.Click += new System.EventHandler(this.lblDataEntrada_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(512, 521);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(179, 62);
            this.btnCancelar.TabIndex = 161;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnCadastrar.Location = new System.Drawing.Point(296, 521);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(179, 62);
            this.btnCadastrar.TabIndex = 162;
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(363, 31);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(342, 28);
            this.lblEntrada.TabIndex = 160;
            this.lblEntrada.Text = "Entrada de produto no stock";
            // 
            // numericUpDownQtd
            // 
            this.numericUpDownQtd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQtd.Location = new System.Drawing.Point(517, 221);
            this.numericUpDownQtd.Name = "numericUpDownQtd";
            this.numericUpDownQtd.Size = new System.Drawing.Size(395, 27);
            this.numericUpDownQtd.TabIndex = 176;
            // 
            // dateTimeFabrico
            // 
            this.dateTimeFabrico.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimeFabrico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFabrico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFabrico.Location = new System.Drawing.Point(517, 290);
            this.dateTimeFabrico.MinDate = new System.DateTime(1924, 1, 1, 0, 0, 0, 0);
            this.dateTimeFabrico.Name = "dateTimeFabrico";
            this.dateTimeFabrico.Size = new System.Drawing.Size(395, 27);
            this.dateTimeFabrico.TabIndex = 177;
            // 
            // dateTimeExpiracao
            // 
            this.dateTimeExpiracao.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimeExpiracao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeExpiracao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeExpiracao.Location = new System.Drawing.Point(517, 357);
            this.dateTimeExpiracao.MinDate = new System.DateTime(1924, 1, 1, 0, 0, 0, 0);
            this.dateTimeExpiracao.Name = "dateTimeExpiracao";
            this.dateTimeExpiracao.Size = new System.Drawing.Size(395, 27);
            this.dateTimeExpiracao.TabIndex = 178;
            // 
            // dateTimeEntrada
            // 
            this.dateTimeEntrada.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimeEntrada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEntrada.Location = new System.Drawing.Point(337, 412);
            this.dateTimeEntrada.MinDate = new System.DateTime(1924, 1, 1, 0, 0, 0, 0);
            this.dateTimeEntrada.Name = "dateTimeEntrada";
            this.dateTimeEntrada.Size = new System.Drawing.Size(575, 27);
            this.dateTimeEntrada.TabIndex = 179;
            // 
            // txtOrigem
            // 
            this.txtOrigem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrigem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigem.Location = new System.Drawing.Point(180, 221);
            this.txtOrigem.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(223, 27);
            this.txtOrigem.TabIndex = 180;
            // 
            // lblCodProdut
            // 
            this.lblCodProdut.AutoSize = true;
            this.lblCodProdut.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProdut.Location = new System.Drawing.Point(515, 116);
            this.lblCodProdut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodProdut.Name = "lblCodProdut";
            this.lblCodProdut.Size = new System.Drawing.Size(154, 23);
            this.lblCodProdut.TabIndex = 163;
            this.lblCodProdut.Text = "Código do produto";
            // 
            // txtCodProdut
            // 
            this.txtCodProdut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodProdut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProdut.Location = new System.Drawing.Point(517, 146);
            this.txtCodProdut.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodProdut.Name = "txtCodProdut";
            this.txtCodProdut.Size = new System.Drawing.Size(179, 27);
            this.txtCodProdut.TabIndex = 168;
            // 
            // lblCodStock
            // 
            this.lblCodStock.AutoSize = true;
            this.lblCodStock.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodStock.Location = new System.Drawing.Point(176, 115);
            this.lblCodStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodStock.Name = "lblCodStock";
            this.lblCodStock.Size = new System.Drawing.Size(132, 23);
            this.lblCodStock.TabIndex = 163;
            this.lblCodStock.Text = "Código do stock";
            // 
            // txtCodStock
            // 
            this.txtCodStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodStock.Location = new System.Drawing.Point(180, 146);
            this.txtCodStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodStock.Name = "txtCodStock";
            this.txtCodStock.Size = new System.Drawing.Size(179, 27);
            this.txtCodStock.TabIndex = 168;
            // 
            // lblStockMax
            // 
            this.lblStockMax.AutoSize = true;
            this.lblStockMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMax.Location = new System.Drawing.Point(178, 260);
            this.lblStockMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockMax.Name = "lblStockMax";
            this.lblStockMax.Size = new System.Drawing.Size(118, 23);
            this.lblStockMax.TabIndex = 181;
            this.lblStockMax.Text = "Stock Máximo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 331);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 183;
            this.label1.Text = "Stock Máximo";
            // 
            // numericUpDownStockMax
            // 
            this.numericUpDownStockMax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStockMax.Location = new System.Drawing.Point(180, 293);
            this.numericUpDownStockMax.Name = "numericUpDownStockMax";
            this.numericUpDownStockMax.Size = new System.Drawing.Size(223, 27);
            this.numericUpDownStockMax.TabIndex = 185;
            // 
            // numericUpDownStockMin
            // 
            this.numericUpDownStockMin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStockMin.Location = new System.Drawing.Point(182, 360);
            this.numericUpDownStockMin.Name = "numericUpDownStockMin";
            this.numericUpDownStockMin.Size = new System.Drawing.Size(223, 27);
            this.numericUpDownStockMin.TabIndex = 186;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 658);
            this.Controls.Add(this.numericUpDownStockMin);
            this.Controls.Add(this.numericUpDownStockMax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStockMax);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.dateTimeEntrada);
            this.Controls.Add(this.dateTimeExpiracao);
            this.Controls.Add(this.dateTimeFabrico);
            this.Controls.Add(this.numericUpDownQtd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblOrigem);
            this.Controls.Add(this.txtCodStock);
            this.Controls.Add(this.txtCodProdut);
            this.Controls.Add(this.lblDataFabrico);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblCodStock);
            this.Controls.Add(this.lblDataExpiracao);
            this.Controls.Add(this.lblCodProdut);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStock";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.Label lblDataFabrico;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblDataExpiracao;
        private System.Windows.Forms.Label lblDataEntrada;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCadastrar;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.NumericUpDown numericUpDownQtd;
        private System.Windows.Forms.DateTimePicker dateTimeFabrico;
        private System.Windows.Forms.DateTimePicker dateTimeExpiracao;
        private System.Windows.Forms.DateTimePicker dateTimeEntrada;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Label lblCodProdut;
        private System.Windows.Forms.TextBox txtCodProdut;
        private System.Windows.Forms.Label lblCodStock;
        private System.Windows.Forms.TextBox txtCodStock;
        private System.Windows.Forms.Label lblStockMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownStockMax;
        private System.Windows.Forms.NumericUpDown numericUpDownStockMin;
    }
}