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

namespace Apresentacao.Consulta
{
    public partial class FrmConsultarProduto : Form
    {
        ProdutoModel prod = new ProdutoModel();
        public FrmConsultarProduto()
        {
            InitializeComponent();
        }
        private void FrmConsultarProduto_Load(object sender, EventArgs e)
        {
            ListarProduto();
            ProcurarProduto();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Utilizamos o try, catch para o tratamento de erros.
            try
            {
                if (ListarProdutos.SelectedRows != null)
                {
                    int CodProdut = Convert.ToInt32(ListarProdutos.SelectedRows[0].Cells["codigo"].Value);

                    FrmCadastrarProduto ediProduto = new FrmCadastrarProduto(CodProdut);
                    AddOwnedForm(ediProduto);
                    ediProduto.TopLevel = false;
                    ediProduto.Dock = DockStyle.Fill;
                    this.Controls.Add(ediProduto);
                    this.Tag = ediProduto;
                    ediProduto.BringToFront();

                    if (ediProduto != null)
                    {
                        ediProduto.Show();
                        ListarProduto();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao editar o produto. " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Utilizamos o try, catch para o tratamento de erros.
            try
            {
                if (ListarProdutos.SelectedRows != null)
                {
                    if (MessageBox.Show("Tens a certeza que desejas eliminar o produto selecionado? ", "Produto",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int CodProdut = Convert.ToInt32(ListarProdutos.SelectedRows[0].Cells["codigo"].Value);

                        if (prod.EliminarModel(CodProdut))
                        {
                            MessageBox.Show("Produto eliminado com sucesso. ", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarProduto();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao eliminar o produto. " + ex);
            }
        }

        //Lista todos os produtos cadastrados.
        public void ListarProduto()
        {
            //Utilizamos o try, catch para o tratamento de erros.
            try
            {
                ListarProdutos.DataSource = prod.ListarProdutoModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao listar produtos. " + ex);
            }
        }
        private void ProcurarProduto()
        {
            //Utilizamos o try, catch para o tratamento de erros.
            try
            {
                ListarProdutos.DataSource = prod.ProcurarProdutoModel(txtPesquisa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao procurar produtos. " + ex);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            ProcurarProduto();
        }
    }
}
