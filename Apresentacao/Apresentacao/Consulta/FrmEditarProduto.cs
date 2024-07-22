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
    public partial class FrmEditarProduto : Form    
    {
        ProdutoModel prod = new ProdutoModel();
        CategoriaModel c = new CategoriaModel();
        public int CodProdut = 0;
        public FrmEditarProduto()
        {
            InitializeComponent();
        }
        private void FrmProduto_Load(object sender, EventArgs e)
        {
            //ConsultarProduto();
            //ConsultarCategoria();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {       
            try
            {
                if (CodProdut == 0)
                {
                    prod.InserirModel(txtDesignacao.Text, float.Parse(txtIVA.Text), float.Parse(txtPUnitario.Text), float.Parse(txtDesconto.Text), Convert.ToInt32(cmbCategoria.SelectedValue));
                    MessageBox.Show("Produto cadastrado com sucesso. ", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                 else
                 {
                    prod.EditarModel(CodProdut, txtDesignacao.Text, float.Parse(txtIVA.Text), float.Parse(txtPUnitario.Text), float.Parse(txtDesconto.Text), Convert.ToInt32(cmbCategoria.SelectedValue));
                    MessageBox.Show("Produto editado com sucesso. ", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                //ConsultarCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao editar o produto. " + ex);
            }
        }
        private void ConsultarProduto()
        {
            //ListarProdutos.DataSource = prod.ConsultarProdutoModel();
            prod.ListarProdutoModel();

        }
        public void ConsultarCategoria()
        {
            cmbCategoria.DataSource = c.ConsultarCategoriaModel();
            cmbCategoria.DisplayMember = "DesigCateg";
            cmbCategoria.ValueMember = "CodCateg";
        }               
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
