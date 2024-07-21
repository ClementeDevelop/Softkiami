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
        public FrmCadastrarProduto(int CodProdut)
        {
            InitializeComponent();
            this.CodProdut = CodProdut;
            Busc_CodProduto(CodProdut);
            lblCadastrar.Text = "Editar produto";
            btnCadastrar.ButtonText = "Editar";
        }
        private void FrmProduto_Load(object sender, EventArgs e)
        {
            //Lista as categorias de produto quando a aplicação é executada.
            ListarCategoria();
            //Mostra_CasasDecimais();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDesignacao.Text != "" & txtIVA.Text != "" & txtPUnitario.Text != "" & txtDesconto.Text != "" & cmbCategoria.Text != "")
            {
                if (CodProdut == 0)
                {
                    prod.InserirModel(txtDesignacao.Text, float.Parse(txtIVA.Text), float.Parse(txtPUnitario.Text), float.Parse(txtDesconto.Text), Convert.ToInt32(cmbCategoria.SelectedValue));
                    MessageBox.Show("Produto cadastrado com sucesso. ", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();
                }
                else
                {
                    prod.EditarModel(CodProdut, txtDesignacao.Text, float.Parse(txtIVA.Text), float.Parse(txtPUnitario.Text), float.Parse(txtDesconto.Text), Convert.ToInt32(cmbCategoria.SelectedValue));
                    MessageBox.Show("Produto editado com sucesso. ", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                Limpar();
            }
            else
            {
                MessageBox.Show("Por favor preencha todos os campos. ", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*Limpa todos os campos do formulário de cadastro,
        depois de serem preenchidos.*/
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
        private void Mostra_CasasDecimais()
        {
            txtIVA.Text = " ,00";
            txtPUnitario.Text = " ,00";
            txtDesconto.Text = " ,00";

        }

        //Busca o código do produto para poder edita-lo.
        private void Busc_CodProduto(int CodProdut)
        {
            DataTable dt = prod.Buscar_CodProdutModel(CodProdut);

            try
            {
                foreach (DataRow item in dt.Rows)
                {
                    txtDesignacao.Text = item["Designacao"].ToString();
                    txtIVA.Text = item["IVA"].ToString();
                    txtPUnitario.Text = item["PUnitario"].ToString();
                    txtDesconto.Text = item["Desconto"].ToString();
                    cmbCategoria.SelectedValue = item["DesigCateg"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao buscar o código do produto. " + ex);
            }
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
