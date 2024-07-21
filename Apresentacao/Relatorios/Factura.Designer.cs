namespace Apresentacao
{
    partial class Factura
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDSoftkiamiDataSet = new Apresentacao.BDSoftkiamiDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProdutoTableAdapter = new Apresentacao.BDSoftkiamiDataSetTableAdapters.ProdutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSoftkiamiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutoBindingSource
            // 
            this.ProdutoBindingSource.DataMember = "Produto";
            this.ProdutoBindingSource.DataSource = this.BDSoftkiamiDataSet;
            // 
            // BDSoftkiamiDataSet
            // 
            this.BDSoftkiamiDataSet.DataSetName = "BDSoftkiamiDataSet";
            this.BDSoftkiamiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.ProdutoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Apresentacao.Relatorios.Report_01.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(825, 635);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProdutoTableAdapter
            // 
            this.ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 635);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDSoftkiamiDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProdutoBindingSource;
        private BDSoftkiamiDataSet BDSoftkiamiDataSet;
        private BDSoftkiamiDataSetTableAdapters.ProdutoTableAdapter ProdutoTableAdapter;







    }
}