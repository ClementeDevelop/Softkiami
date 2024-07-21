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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }
        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }
        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            FrmCadastrarProduto AddProdut = new FrmCadastrarProduto();
            AddOwnedForm(AddProdut);
            AddProdut.TopLevel = false;
            AddProdut.Dock = DockStyle.Fill;
            this.Controls.Add(AddProdut);
            this.Tag = AddProdut;
            AddProdut.BringToFront();
            AddProdut.Show();

        }
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            FrmStock s = new FrmStock();
            AddOwnedForm(s);
            s.TopLevel = false;
            s.Dock = DockStyle.Fill;
            this.Controls.Add(s);
            this.Tag = s;
            s.BringToFront();
            s.Show();
        }

        private void btnConsultarProduto_Click(object sender, EventArgs e)
        {
            Consulta.FrmConsultarProduto consuProduto = new Consulta.FrmConsultarProduto();
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
