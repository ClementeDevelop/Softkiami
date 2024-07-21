namespace Apresentacao
{
    partial class FrmConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPesquisa = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnEditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListarFuncionario = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.CodFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.White;
            this.txtPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPesquisa.BackgroundImage")));
            this.txtPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtPesquisa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisa.Icon = ((System.Drawing.Image)(resources.GetObject("txtPesquisa.Icon")));
            this.txtPesquisa.Location = new System.Drawing.Point(14, 80);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(1020, 51);
            this.txtPesquisa.TabIndex = 2;
            this.txtPesquisa.text = "";
            this.txtPesquisa.OnTextChange += new System.EventHandler(this.txtPesquisa_OnTextChange);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(999, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ActiveBorderThickness = 1;
            this.btnEditar.ActiveCornerRadius = 20;
            this.btnEditar.ActiveFillColor = System.Drawing.Color.Black;
            this.btnEditar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditar.ActiveLineColor = System.Drawing.Color.White;
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.ButtonText = "Editar";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IdleBorderThickness = 1;
            this.btnEditar.IdleCornerRadius = 20;
            this.btnEditar.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditar.IdleForecolor = System.Drawing.Color.White;
            this.btnEditar.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditar.Location = new System.Drawing.Point(487, 475);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(162, 43);
            this.btnEditar.TabIndex = 46;
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ActiveBorderThickness = 1;
            this.btnEliminar.ActiveCornerRadius = 20;
            this.btnEliminar.ActiveFillColor = System.Drawing.Color.Black;
            this.btnEliminar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEliminar.ActiveLineColor = System.Drawing.Color.White;
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IdleBorderThickness = 1;
            this.btnEliminar.IdleCornerRadius = 20;
            this.btnEliminar.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminar.IdleForecolor = System.Drawing.Color.White;
            this.btnEliminar.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEliminar.Location = new System.Drawing.Point(659, 475);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 43);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 44);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // ListarFuncionario
            // 
            this.ListarFuncionario.AllowUserToAddRows = false;
            this.ListarFuncionario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListarFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ListarFuncionario.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ListarFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListarFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListarFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListarFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListarFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodFunc,
            this.Nome,
            this.NIF,
            this.Email});
            this.ListarFuncionario.DoubleBuffered = true;
            this.ListarFuncionario.EnableHeadersVisualStyles = false;
            this.ListarFuncionario.HeaderBgColor = System.Drawing.Color.White;
            this.ListarFuncionario.HeaderForeColor = System.Drawing.Color.Black;
            this.ListarFuncionario.Location = new System.Drawing.Point(12, 149);
            this.ListarFuncionario.Name = "ListarFuncionario";
            this.ListarFuncionario.ReadOnly = true;
            this.ListarFuncionario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListarFuncionario.RowTemplate.Height = 24;
            this.ListarFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListarFuncionario.Size = new System.Drawing.Size(1020, 319);
            this.ListarFuncionario.TabIndex = 48;
            this.ListarFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // CodFunc
            // 
            this.CodFunc.DataPropertyName = "CodFunc";
            this.CodFunc.HeaderText = " Código";
            this.CodFunc.Name = "CodFunc";
            this.CodFunc.ReadOnly = true;
            this.CodFunc.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // NIF
            // 
            this.NIF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NIF.DataPropertyName = "NIF";
            this.NIF.HeaderText = "NIF";
            this.NIF.Name = "NIF";
            this.NIF.ReadOnly = true;
            this.NIF.Width = 59;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 73;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ActiveBorderThickness = 1;
            this.btnCadastrar.ActiveCornerRadius = 20;
            this.btnCadastrar.ActiveFillColor = System.Drawing.Color.Black;
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
            this.btnCadastrar.IdleFillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCadastrar.IdleForecolor = System.Drawing.Color.White;
            this.btnCadastrar.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCadastrar.Location = new System.Drawing.Point(125, 475);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(162, 43);
            this.btnCadastrar.TabIndex = 49;
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 531);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.ListarFuncionario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultar";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar funcionário";
            this.Load += new System.EventHandler(this.FrmConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListarFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTextbox txtPesquisa;
        private System.Windows.Forms.PictureBox btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ListarFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCadastrar;
    }
}