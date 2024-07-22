namespace Apresentacao
{
    partial class Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produto));
            this.btnEntradaStock = new System.Windows.Forms.Button();
            this.btnSaidaStock = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.btnConsultarProduto = new System.Windows.Forms.Button();
            this.btnIventario = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEntradaStock
            // 
            this.btnEntradaStock.BackColor = System.Drawing.SystemColors.Info;
            this.btnEntradaStock.FlatAppearance.BorderSize = 0;
            this.btnEntradaStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEntradaStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradaStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradaStock.ForeColor = System.Drawing.Color.Black;
            this.btnEntradaStock.Image = ((System.Drawing.Image)(resources.GetObject("btnEntradaStock.Image")));
            this.btnEntradaStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntradaStock.Location = new System.Drawing.Point(50, 170);
            this.btnEntradaStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntradaStock.Name = "btnEntradaStock";
            this.btnEntradaStock.Size = new System.Drawing.Size(253, 43);
            this.btnEntradaStock.TabIndex = 85;
            this.btnEntradaStock.Text = "       Entrada no Stock";
            this.btnEntradaStock.UseVisualStyleBackColor = false;
            this.btnEntradaStock.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSaidaStock
            // 
            this.btnSaidaStock.BackColor = System.Drawing.SystemColors.Info;
            this.btnSaidaStock.FlatAppearance.BorderSize = 0;
            this.btnSaidaStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSaidaStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaidaStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaidaStock.ForeColor = System.Drawing.Color.Black;
            this.btnSaidaStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaidaStock.Location = new System.Drawing.Point(319, 170);
            this.btnSaidaStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaidaStock.Name = "btnSaidaStock";
            this.btnSaidaStock.Size = new System.Drawing.Size(251, 43);
            this.btnSaidaStock.TabIndex = 86;
            this.btnSaidaStock.Text = "Saida no Stock";
            this.btnSaidaStock.UseVisualStyleBackColor = false;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddProduto.FlatAppearance.BorderSize = 0;
            this.btnAddProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduto.Image")));
            this.btnAddProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduto.Location = new System.Drawing.Point(52, 104);
            this.btnAddProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(171, 40);
            this.btnAddProduto.TabIndex = 85;
            this.btnAddProduto.Text = "    Produdo";
            this.btnAddProduto.UseVisualStyleBackColor = false;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // btnConsultarProduto
            // 
            this.btnConsultarProduto.BackColor = System.Drawing.SystemColors.Info;
            this.btnConsultarProduto.FlatAppearance.BorderSize = 0;
            this.btnConsultarProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnConsultarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProduto.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarProduto.Image")));
            this.btnConsultarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarProduto.Location = new System.Drawing.Point(229, 104);
            this.btnConsultarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarProduto.Name = "btnConsultarProduto";
            this.btnConsultarProduto.Size = new System.Drawing.Size(171, 40);
            this.btnConsultarProduto.TabIndex = 85;
            this.btnConsultarProduto.Text = "    Consultar";
            this.btnConsultarProduto.UseVisualStyleBackColor = false;
            this.btnConsultarProduto.Click += new System.EventHandler(this.btnConsultarProduto_Click);
            // 
            // btnIventario
            // 
            this.btnIventario.BackColor = System.Drawing.SystemColors.Info;
            this.btnIventario.FlatAppearance.BorderSize = 0;
            this.btnIventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnIventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIventario.ForeColor = System.Drawing.Color.Black;
            this.btnIventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIventario.Location = new System.Drawing.Point(400, 104);
            this.btnIventario.Margin = new System.Windows.Forms.Padding(2);
            this.btnIventario.Name = "btnIventario";
            this.btnIventario.Size = new System.Drawing.Size(171, 40);
            this.btnIventario.TabIndex = 85;
            this.btnIventario.Text = "    Iventario";
            this.btnIventario.UseVisualStyleBackColor = false;
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.SystemColors.Info;
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.Black;
            this.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.Location = new System.Drawing.Point(580, 104);
            this.btnHistorico.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(171, 40);
            this.btnHistorico.TabIndex = 85;
            this.btnHistorico.Text = "    Histórico";
            this.btnHistorico.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(137, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(526, 33);
            this.label3.TabIndex = 135;
            this.label3.Text = "Produtos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnIventario);
            this.Controls.Add(this.btnConsultarProduto);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.btnEntradaStock);
            this.Controls.Add(this.btnSaidaStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntradaStock;
        private System.Windows.Forms.Button btnSaidaStock;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.Button btnConsultarProduto;
        private System.Windows.Forms.Button btnIventario;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Label label3;
    }
}