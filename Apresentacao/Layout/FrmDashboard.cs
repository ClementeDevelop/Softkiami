using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Comum;

namespace Apresentacao
{
    public partial class FrmDashboard : Form
    {
        //Instância da classe UtilizadoModel.
        UtilizadorModel uModel = new UtilizadorModel();

        //Instância da classe FuncionarioModel.
        FuncionarioModel fModel = new FuncionarioModel();

        //Instância da classe ProdutoModel.
        ProdutoModel pModel = new ProdutoModel();

        //Instância da classe ClienteModel.
        ClienteModel cModel = new ClienteModel();

        //Instância da classe ClienteModel.
        FornecedorModel fornecedorM = new FornecedorModel();
        public FrmDashboard()
        {
            InitializeComponent();
        }
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            Contar_Utilizador();
            Contar_Funcionario();
            Contar_Produto();
            Contar_Cliente();
            Contar_Fornecedor();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Contar_Utilizador()
        {
            DataTable dt = uModel.CountUtilizadorModel();
            lblContar_Utilizador.Text = dt.Rows[0][0].ToString();
        }
        private void Contar_Funcionario()
        {
            DataTable dt = fModel.CountFuncionarioModel();
            lblContar_Funcionario.Text = dt.Rows[0][0].ToString();
        }
        private void Contar_Produto()
        {
            DataTable dt = pModel.Count_ProdutoModel();
            lblContar_Produto.Text = dt.Rows[0][0].ToString();
        }
        private void Contar_Cliente()
        {
            DataTable dt = cModel.CountClienteModel();
            lblContar_Cliente.Text = dt.Rows[0][0].ToString();
        }
        private void Contar_Fornecedor()
        {
            DataTable dt = fornecedorM.CountFornecedorModel();
            lblContar_Fornecedor.Text = dt.Rows[0][0].ToString();
        }
    }
}
