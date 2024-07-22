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
    public partial class FrmDefinicoesConta : Form
    {
        public FrmDefinicoesConta()
        {
            InitializeComponent();
        }

        private void lblConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultarUtilizador consu = new FrmConsultarUtilizador();
            AddOwnedForm(consu);
            consu.TopLevel = false;
            consu.Dock = DockStyle.Fill;
            this.Controls.Add(consu);
            this.Tag = consu;
            consu.BringToFront();
            consu.Show();
        }
        private void lblTipoConta_Click(object sender, EventArgs e)
        {
            FrmTiposConta abrir = new FrmTiposConta();
            AddOwnedForm(abrir);
            abrir.TopLevel = false;
            abrir.Dock = DockStyle.Fill;
            abrir.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(abrir);
            this.Tag = abrir;
            abrir.BringToFront();
            abrir.Show();
            //abrir.ShowDialog();
        }
    }
}
