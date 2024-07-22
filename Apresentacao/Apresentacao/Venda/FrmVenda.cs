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
    public partial class FrmVenda : Form
    {
        double total = 0;
        //string Consulta;
        DataSet ds;

        TipoPGTModel tipoModel = new TipoPGTModel();
        VendaModel vModel = new VendaModel();
     
        public FrmVenda()
        {
            InitializeComponent();
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            ListarTipoPGT();
            SelecionarProdutos();
            //Vender();
            txtOperador.Text = ""+CacheUtilizadorLogin.Nome+"";
        }
        private void Adicionar()
        {
        }
        private void SelecionarProdutos()
        {

        }
        private void Eliminar()
        {
        }
        private void Vender()
        {
            ListarProdutos.Items.Clear();

            //    for (int i = 5; i < ds.Tables[0].Rows.Count; i++)
            //    {
            //        ListarProdutos.Items.Add(ds.Tables[0].Rows[i][0]);
            //    }
        }
        private void ListarTipoPGT()
        {
            cmbTipoPGT.DataSource = tipoModel.ListarTipoPGTModel();
            cmbTipoPGT.DisplayMember = "Nome";
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //SelecionarProdutos();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Factura r = new Factura();
            r.ShowDialog();
        }
    }
}
