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
    public partial class FrmTiposConta : Form
    {
        public FrmTiposConta()
        {
            InitializeComponent();
        }

        private void lblUtilizador_Click(object sender, EventArgs e)
        {
            FrmCadastrarUtilizador abrir = new FrmCadastrarUtilizador();
            AddOwnedForm(abrir);
            abrir.TopLevel = false;
            abrir.Dock = DockStyle.Fill;
            this.Controls.Add(abrir);
            this.Tag = abrir;
            abrir.BringToFront();
            abrir.Show();
        }
    }
}
