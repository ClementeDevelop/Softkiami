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
    public partial class FrmLogo : Form
    {
        public FrmLogo()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressBar1.Increment(1);
            //progressbarhermes.Value = progressBar1.Value;
            //progressBar1.Increment(1);
            //progressBar1.Value = progressBar1.Value;
          

            //if (progressBar1.Value == 100)
            //{
            //    FrmLogin1 login = new FrmLogin1();
            //    login.Show();
            //    this.Hide();

            //    timer1.Stop();
            //}
        }    
        private void lblDASHBOARD_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = new FrmDashboard();
            dashboard.ShowDialog();
        }
    }
}
