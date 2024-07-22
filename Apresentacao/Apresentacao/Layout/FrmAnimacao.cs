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
    public partial class FrmAnimacao : Form
    {
        public FrmAnimacao()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void FrmAnimacao_Load(object sender, EventArgs e)
        {
            //timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(1);
            bunifuCircleProgressbar1.Value = progressBar1.Value;

            if (progressBar1.Value == 100)
            {
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
