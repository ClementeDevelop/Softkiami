﻿namespace Apresentacao
{
    partial class FrmDefinicoesConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDefinicoesConta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblConsultar);
            this.panel1.Controls.Add(this.lblTipoConta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 81);
            this.panel1.TabIndex = 1;
            // 
            // lblConsultar
            // 
            this.lblConsultar.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblConsultar.Location = new System.Drawing.Point(16, 50);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(285, 22);
            this.lblConsultar.TabIndex = 3;
            this.lblConsultar.Text = "Consultar";
            this.lblConsultar.Click += new System.EventHandler(this.lblConsultar_Click);
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.lblTipoConta.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConta.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTipoConta.Location = new System.Drawing.Point(16, 28);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(285, 22);
            this.lblTipoConta.TabIndex = 2;
            this.lblTipoConta.Text = "Tipos de conta";
            this.lblTipoConta.Click += new System.EventHandler(this.lblTipoConta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contas de Utilizador";
            // 
            // FrmDefinicoesConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 504);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDefinicoesConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definições de  Conta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.Label label1;
    }
}