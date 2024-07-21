namespace Apresentacao
{
    partial class FrmConsultarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarFornecedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pnlPesquisa = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBoxPesquisa = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.ListarFornecedores = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.CodFornec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(876, 65);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 33);
            this.btnEliminar.TabIndex = 103;
            this.btnEliminar.Text = "    Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(698, 68);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(162, 33);
            this.btnEditar.TabIndex = 102;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(519, 69);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(162, 33);
            this.btnCadastrar.TabIndex = 101;
            this.btnCadastrar.Text = "     Adicionar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
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
            this.pnlPesquisa.Location = new System.Drawing.Point(14, 65);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Quality = 10;
            this.pnlPesquisa.Size = new System.Drawing.Size(405, 30);
            this.pnlPesquisa.TabIndex = 99;
            // 
            // pictureBoxPesquisa
            // 
            this.pictureBoxPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPesquisa.Image")));
            this.pictureBoxPesquisa.Location = new System.Drawing.Point(373, 2);
            this.pictureBoxPesquisa.Name = "pictureBoxPesquisa";
            this.pictureBoxPesquisa.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxPesquisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPesquisa.TabIndex = 54;
            this.pictureBoxPesquisa.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(17, 3);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(348, 26);
            this.txtPesquisa.TabIndex = 53;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // ListarFornecedores
            // 
            this.ListarFornecedores.AllowUserToAddRows = false;
            this.ListarFornecedores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarFornecedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListarFornecedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListarFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListarFornecedores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ListarFornecedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListarFornecedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ListarFornecedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListarFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListarFornecedores.ColumnHeadersHeight = 29;
            this.ListarFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodFornec,
            this.Nome,
            this.Email,
            this.NIF,
            this.NumTel});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListarFornecedores.DefaultCellStyle = dataGridViewCellStyle7;
            this.ListarFornecedores.DoubleBuffered = true;
            this.ListarFornecedores.EnableHeadersVisualStyles = false;
            this.ListarFornecedores.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.ListarFornecedores.HeaderForeColor = System.Drawing.Color.White;
            this.ListarFornecedores.Location = new System.Drawing.Point(14, 112);
            this.ListarFornecedores.Margin = new System.Windows.Forms.Padding(2);
            this.ListarFornecedores.Name = "ListarFornecedores";
            this.ListarFornecedores.ReadOnly = true;
            this.ListarFornecedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListarFornecedores.RowTemplate.Height = 24;
            this.ListarFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListarFornecedores.Size = new System.Drawing.Size(1024, 524);
            this.ListarFornecedores.TabIndex = 98;
            // 
            // CodFornec
            // 
            this.CodFornec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodFornec.DataPropertyName = "CodFornec";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodFornec.DefaultCellStyle = dataGridViewCellStyle3;
            this.CodFornec.Frozen = true;
            this.CodFornec.HeaderText = " Código";
            this.CodFornec.Name = "CodFornec";
            this.CodFornec.ReadOnly = true;
            this.CodFornec.Visible = false;
            this.CodFornec.Width = 94;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.DataPropertyName = "Email";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.DefaultCellStyle = dataGridViewCellStyle4;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 75;
            // 
            // NIF
            // 
            this.NIF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NIF.DataPropertyName = "NIF";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIF.DefaultCellStyle = dataGridViewCellStyle5;
            this.NIF.HeaderText = "NIF";
            this.NIF.Name = "NIF";
            this.NIF.ReadOnly = true;
            this.NIF.Width = 56;
            // 
            // NumTel
            // 
            this.NumTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumTel.DataPropertyName = "NumTel";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTel.DefaultCellStyle = dataGridViewCellStyle6;
            this.NumTel.HeaderText = "Telefone";
            this.NumTel.Name = "NumTel";
            this.NumTel.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1024, 33);
            this.label3.TabIndex = 134;
            this.label3.Text = "Lista de fornecedoress";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmConsultarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1046, 671);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pnlPesquisa);
            this.Controls.Add(this.ListarFornecedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedores";
            this.pnlPesquisa.ResumeLayout(false);
            this.pnlPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlPesquisa;
        private System.Windows.Forms.PictureBox pictureBoxPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ListarFornecedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodFornec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumTel;
        private System.Windows.Forms.Label label3;
    }
}