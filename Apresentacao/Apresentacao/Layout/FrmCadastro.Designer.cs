namespace Apresentacao
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.btnAddUtilizador = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.btnAddFornecedor = new System.Windows.Forms.Button();
            this.btnAddFuncionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddUtilizador
            // 
            this.btnAddUtilizador.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddUtilizador.FlatAppearance.BorderSize = 0;
            this.btnAddUtilizador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUtilizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUtilizador.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUtilizador.Image")));
            this.btnAddUtilizador.Location = new System.Drawing.Point(29, 14);
            this.btnAddUtilizador.Name = "btnAddUtilizador";
            this.btnAddUtilizador.Size = new System.Drawing.Size(178, 145);
            this.btnAddUtilizador.TabIndex = 0;
            this.btnAddUtilizador.Text = "Utilizadores";
            this.btnAddUtilizador.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddUtilizador.UseVisualStyleBackColor = false;
            this.btnAddUtilizador.Click += new System.EventHandler(this.btnAddUtilizador_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddCliente);
            this.panel1.Controls.Add(this.btnAddFornecedor);
            this.panel1.Controls.Add(this.btnAddFuncionario);
            this.panel1.Controls.Add(this.btnAddUtilizador);
            this.panel1.Location = new System.Drawing.Point(178, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 350);
            this.panel1.TabIndex = 1;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddCliente.FlatAppearance.BorderSize = 0;
            this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCliente.Image")));
            this.btnAddCliente.Location = new System.Drawing.Point(29, 190);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(178, 145);
            this.btnAddCliente.TabIndex = 0;
            this.btnAddCliente.Text = "Clientes";
            this.btnAddCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCliente.UseVisualStyleBackColor = false;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // btnAddFornecedor
            // 
            this.btnAddFornecedor.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddFornecedor.FlatAppearance.BorderSize = 0;
            this.btnAddFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFornecedor.Image")));
            this.btnAddFornecedor.Location = new System.Drawing.Point(243, 190);
            this.btnAddFornecedor.Name = "btnAddFornecedor";
            this.btnAddFornecedor.Size = new System.Drawing.Size(178, 145);
            this.btnAddFornecedor.TabIndex = 0;
            this.btnAddFornecedor.Text = "Fornecedores";
            this.btnAddFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddFornecedor.UseVisualStyleBackColor = false;
            this.btnAddFornecedor.Click += new System.EventHandler(this.btnAddFornecedor_Click);
            // 
            // btnAddFuncionario
            // 
            this.btnAddFuncionario.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddFuncionario.FlatAppearance.BorderSize = 0;
            this.btnAddFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFuncionario.Image")));
            this.btnAddFuncionario.Location = new System.Drawing.Point(243, 15);
            this.btnAddFuncionario.Name = "btnAddFuncionario";
            this.btnAddFuncionario.Size = new System.Drawing.Size(178, 145);
            this.btnAddFuncionario.TabIndex = 0;
            this.btnAddFuncionario.Text = "Funcionários";
            this.btnAddFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddFuncionario.UseVisualStyleBackColor = false;
            this.btnAddFuncionario.Click += new System.EventHandler(this.btnAddFuncionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de entidades";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(806, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddUtilizador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Button btnAddFornecedor;
        private System.Windows.Forms.Button btnAddFuncionario;
        private System.Windows.Forms.Label label1;
    }
}