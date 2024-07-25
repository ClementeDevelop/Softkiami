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

namespace Apresentacao
{
    public partial class FrmCadastrarProduto : Form
    {
        //Instância da classe ProdutoModel.
        ProdutoModel prod = new ProdutoModel();

        //Instância da classe CategoriaModel.
        CategoriaModel c = new CategoriaModel();

        int CodProdut = 0;
        public FrmCadastrarProduto()
        {
            InitializeComponent();
        }
        private void FrmProduto_Load(object sender, EventArgs e)
        {
            ListarCategoria();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDesignacao.Text != "" & txtIVA.Text != "" & txtPUnitario.Text != "" & txtDesconto.Text != "" & cmbCategoria.Text != "")
            {
                if (CodProdut == 0)
                {
                    prod.Inserir_ProdutoModel(txtDesignacao.Text, float.Parse(txtIVA.Text), float.Parse(txtPUnitario.Text), float.Parse(txtDesconto.Text), Convert.ToInt32(cmbCategoria.SelectedValue));
                    MessageBox.Show("Produto cadastrado com sucesso. ", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                }
                Limpar();
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos. ", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*Limpa todos os campos do formulário de cadastro,
        de produto depois de serem preenchidos.*/
        private void Limpar()
        {
            txtDesignacao.Text = "";
            txtIVA.Text = "";
            txtPUnitario.Text = "";
            txtDesconto.Text = "";
            cmbCategoria.Text = "";
        }

        //Lista as categorias de produto.
        private void ListarCategoria()
        {
            cmbCategoria.DataSource = c.ConsultarCategoriaModel();
            cmbCategoria.DisplayMember = "DesigCateg";
            cmbCategoria.ValueMember = "CodCateg";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
