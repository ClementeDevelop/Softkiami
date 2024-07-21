namespace Apresentacao
{
    partial class FrmListarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarProduto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblListarProuto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnElimProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.CodProdut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TImposto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1234, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 82;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProdut,
            this.Descricao,
            this.Qtd,
            this.TImposto,
            this.PUnitario,
            this.Desconto,
            this.PTotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(935, 435);
            this.dataGridView1.TabIndex = 83;
            // 
            // lblListarProuto
            // 
            this.lblListarProuto.AutoSize = true;
            this.lblListarProuto.Font = new System.Drawing.Font("Arial Unicode MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarProuto.Location = new System.Drawing.Point(12, 75);
            this.lblListarProuto.Name = "lblListarProuto";
            this.lblListarProuto.Size = new System.Drawing.Size(163, 33);
            this.lblListarProuto.TabIndex = 84;
            this.lblListarProuto.Text = "Listar Produto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 36);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // btnElimProduto
            // 
            this.btnElimProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElimProduto.FlatAppearance.BorderSize = 2;
            this.btnElimProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimProduto.ForeColor = System.Drawing.Color.Black;
            this.btnElimProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnElimProduto.Image")));
            this.btnElimProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimProduto.Location = new System.Drawing.Point(964, 270);
            this.btnElimProduto.Name = "btnElimProduto";
            this.btnElimProduto.Size = new System.Drawing.Size(237, 55);
            this.btnElimProduto.TabIndex = 88;
            this.btnElimProduto.Text = "Eliminar";
            this.btnElimProduto.UseVisualStyleBackColor = false;
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarProduto.FlatAppearance.BorderSize = 2;
            this.btnEditarProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduto.ForeColor = System.Drawing.Color.Black;
            this.btnEditarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProduto.Image")));
            this.btnEditarProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProduto.Location = new System.Drawing.Point(964, 192);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(237, 55);
            this.btnEditarProduto.TabIndex = 87;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = false;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduto.FlatAppearance.BorderSize = 2;
            this.btnAddProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduto.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduto.Image")));
            this.btnAddProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduto.Location = new System.Drawing.Point(964, 114);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(237, 55);
            this.btnAddProduto.TabIndex = 86;
            this.btnAddProduto.Text = "Adicionar";
            this.btnAddProduto.UseVisualStyleBackColor = false;
            // 
            // CodProdut
            // 
            this.CodProdut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodProdut.HeaderText = "Código";
            this.CodProdut.Name = "CodProdut";
            this.CodProdut.ReadOnly = true;
            this.CodProdut.Visible = false;
            this.CodProdut.Width = 81;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricao.DefaultCellStyle = dataGridViewCellStyle1;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Qtd
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qtd.DefaultCellStyle = dataGridViewCellStyle2;
            this.Qtd.HeaderText = "Quantidade";
            this.Qtd.Name = "Qtd";
            // 
            // TImposto
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TImposto.DefaultCellStyle = dataGridViewCellStyle3;
            this.TImposto.HeaderText = "TImposto";
            this.TImposto.Name = "TImposto";
            // 
            // PUnitario
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PUnitario.DefaultCellStyle = dataGridViewCellStyle4;
            this.PUnitario.HeaderText = "PUnitario";
            this.PUnitario.Name = "PUnitario";
            // 
            // Desconto
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desconto.DefaultCellStyle = dataGridViewCellStyle5;
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            // 
            // PTotal
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.PTotal.HeaderText = "PTotal";
            this.PTotal.Name = "PTotal";
            // 
            // FrmListarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 636);
            this.Controls.Add(this.btnElimProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblListarProuto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblListarProuto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnElimProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnAddProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProdut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TImposto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTotal;
    }
}