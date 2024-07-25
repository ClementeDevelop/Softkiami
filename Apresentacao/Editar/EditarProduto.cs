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
    public partial class EditarProduto : Form
    {
        //Instância da classe ProdutoModel.
        ProdutoModel prod = new ProdutoModel();

        //Instância da classe CategoriaModel.
        CategoriaModel c = new CategoriaModel();

        //Instância da classe CategoriaModel.
        Consulta.FrmConsultarProduto produto = new Consulta.FrmConsultarProduto();

        public int CodProdut = 0;
        public EditarProduto()
        {
            InitializeComponent();
        }
        private void EditarProduto_Load(object sender, EventArgs e)
        {
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (CodProdut != 0)
            {
                prod.Editar_ProdutoModel(CodProdut, txtDesignacao.Text, float.Parse(txtIVA.Text),
                float.Parse(txtPUnitario.Text), float.Parse(txtDesconto.Text),
                Convert.ToInt32(cmbCategoria.SelectedValue));
                MessageBox.Show("Produto editado com sucesso. ",
                "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Lista as categorias de produto.
        public void ListarCategoria()
        {
            cmbCategoria.DataSource = c.ConsultarCategoriaModel();
            cmbCategoria.DisplayMember = "DesigCateg";
            cmbCategoria.ValueMember = "CodCateg";
        }
    }
}
