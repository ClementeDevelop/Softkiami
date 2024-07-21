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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (pnlVertical.Width == 280)
            {
                pnlVertical.Width = 70;
            }
            else
                pnlVertical.Width = 280;
        }
    }
}
