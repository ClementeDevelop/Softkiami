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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnAddFuncionario_Click(object sender, EventArgs e)
        {
            FrmCadastrarFuncionario AddFuncionario = new FrmCadastrarFuncionario();
            AddOwnedForm(AddFuncionario);
            AddFuncionario.TopLevel = false;
            AddFuncionario.Dock = DockStyle.Fill;
            AddFuncionario.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(AddFuncionario);
            this.Tag = AddFuncionario;
            AddFuncionario.BringToFront();
            AddFuncionario.Show();
        }

        private void btnAddUtilizador_Click(object sender, EventArgs e)
        {
         
            FrmCadastrarUtilizador frmCadUtilizador = new FrmCadastrarUtilizador();
            AddOwnedForm(frmCadUtilizador);
            frmCadUtilizador.TopLevel = false;
            frmCadUtilizador.Dock = DockStyle.Fill;
            this.Controls.Add(frmCadUtilizador);
            this.Tag = frmCadUtilizador;
            frmCadUtilizador.BringToFront();
            frmCadUtilizador.Show();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            FrmCadastrarProduto AddProduto = new FrmCadastrarProduto();
            AddOwnedForm(AddProduto);
            AddProduto.TopLevel = false;
            AddProduto.Dock = DockStyle.Fill;
            this.Controls.Add(AddProduto);
            this.Tag = AddProduto;
            AddProduto.BringToFront();
            AddProduto.Show();

        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente AddCliente = new FrmCadastrarCliente();
            AddOwnedForm(AddCliente);
            AddCliente.TopLevel = false;
            AddCliente.Dock = DockStyle.Fill;
            this.Controls.Add(AddCliente);
            this.Tag = AddCliente;
            AddCliente.BringToFront();
            AddCliente.Show();

        }

        private void btnAddFornecedor_Click(object sender, EventArgs e)
        {
            FrmCadastrarFornecedor AddFornecedor = new FrmCadastrarFornecedor();
            AddOwnedForm(AddFornecedor);
            AddFornecedor.TopLevel = false;
            AddFornecedor.Dock = DockStyle.Fill;
            this.Controls.Add(AddFornecedor);
            this.Tag = AddFornecedor;
            AddFornecedor.BringToFront();
            AddFornecedor.Show();
        }
    }
}
