using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void btnProcUtilizador_Click(object sender, EventArgs e)
        {
            FrmConsultarUtilizador procura = new FrmConsultarUtilizador();
            AddOwnedForm(procura);
            procura.TopLevel = false;
            procura.Dock = DockStyle.Fill;
            this.Controls.Add(procura);
            this.Tag = procura;
            procura.BringToFront();
            procura.Show();

        }

        private void btnProcFuncionario_Click(object sender, EventArgs e)
        {
            FrmConsultarFuncionario procura = new FrmConsultarFuncionario();
            AddOwnedForm(procura);
            procura.TopLevel = false;
            procura.Dock = DockStyle.Fill;
            this.Controls.Add(procura);
            this.Tag = procura;
            procura.BringToFront();
            procura.Show();
        }
        private void btnProcCliente_Click(object sender, EventArgs e)
        {
            FrmConsultarCliente procura = new FrmConsultarCliente();
            AddOwnedForm(procura);
            procura.TopLevel = false;
            procura.Dock = DockStyle.Fill;
            this.Controls.Add(procura);
            this.Tag = procura;
            procura.BringToFront();
            procura.Show();
        }
        private void btnProcFornecedor_Click(object sender, EventArgs e)
        {
            FrmConsultarFornecedor procura = new FrmConsultarFornecedor();
            AddOwnedForm(procura);
            procura.TopLevel = false;
            procura.Dock = DockStyle.Fill;
            this.Controls.Add(procura);
            this.Tag = procura;
            procura.BringToFront();
            procura.Show();
        }

        private void btnProcProduto_Click(object sender, EventArgs e)
        {
            Consulta.FrmConsultarProduto  consuProduto = new Consulta.FrmConsultarProduto();
            AddOwnedForm(consuProduto);
            consuProduto.TopLevel = false;
            consuProduto.Dock = DockStyle.Fill;
            this.Controls.Add(consuProduto);
            this.Tag = consuProduto;
            consuProduto.BringToFront();
            consuProduto.Show();
        }
    }
}
