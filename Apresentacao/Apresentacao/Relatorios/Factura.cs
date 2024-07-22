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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
             //TODO: This line of code loads data into the 'BDSoftkiamiDataSet.Produto' table. You can move, or remove it, as needed.
            this.ProdutoTableAdapter.Fill(this.BDSoftkiamiDataSet.Produto);
            this.reportViewer1.RefreshReport();
        }
        

    }
}
