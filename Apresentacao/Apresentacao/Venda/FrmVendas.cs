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
    public partial class FrmVendas : Form
    {
        //Instância da classe VendaModel.
        VendaModel vModel = new VendaModel();

        //Instância da classe TipoPGTModel.
        TipoPGTModel tipoModel = new TipoPGTModel();

        DataSet ds = new DataSet();
        public FrmVendas()
        {
            InitializeComponent();
        }
        private void FrmVendas_Load(object sender, EventArgs e)
        {
            ListarProdutos();
            ListarIipoPGT();
            txtOperador.Text = "" +CacheUtilizadorLogin.Nome+ "";
            txtMoeda.Text = "AKZ";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
        }
        //Lista os produtos.
        private void ListarProdutos()
        {
            DGV_ListarProdutos.DataSource = vModel.ListarProdutosModel();
            //EscolherProdutos.DataSource = ds.Tables[0];
            //Carrinho.DataSource = ds.Tables[0];
        }
        //Lista os tipos de pagamentos.
        private void ListarIipoPGT()
        {
            cmbTipoPGT.DataSource = tipoModel.ListarTipoPGTModel();
            cmbTipoPGT.DisplayMember = "Nome";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Factura r = new Factura();
            r.ShowDialog();
        }

        //int key = 0, stock;

        private void DGV_ListarProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtDesignacao.Text = DVG_Carrinho.Rows[0][1]
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //if (txtQtd.Text == "" || int.Parse(txtQtd.Text) > stock)
            //{
            //    MessageBox.Show("Quantidade introduzida correcta. ");
            //}
            //else
            //{
            //    int total = Convert.ToInt32(txtQtd.Text) * Convert.ToInt32(txtPUnitario.Text);
            //    DataGridViewRow newRow = new DataGridViewRow();            
            //}
        }
        int i = 0;
        double total = 0;
        private void Vender()
        {
        }
    }
}
