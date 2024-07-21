using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;
using Comum;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();                
            pnlUtilizador.Visible = false;
            lblExpiracao.Visible = false;
            lblStock.Visible = false;
            CarregarDadosUtilizador();
            MostrarLogo();
        }
        #region DllImport
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr wmsg, int hwms, int wparam, int Iparam);
        #endregion

        //Permite arrastar o formulário do menu através da barra de titulo.
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Abre os demais formulários no painel central.
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.pnlCentro.Controls.Count > 0)
                this.pnlCentro.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnlCentro.Controls.Add(fh);
            this.pnlCentro.Tag = fh;
            fh.Show();
        }

        //Encerra a aplicação.
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar a aplicação?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            Application.Exit();
        }

        //Maximiza o formulário do menu.
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        //Restaura o formulário do menu.
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        //Minimiza o formulário do menu.
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (pnlVertical.Width == 276)
            {
                pnlVertical.Width = 79;
            }
            else
                pnlVertical.Width = 276;
        }
        private void CarregarDadosUtilizador()
        {
            lblFuncao.Text = CacheUtilizadorLogin.Funcao;
            lblNome.Text = CacheUtilizadorLogin.Nome;
            //lblEmail.Text = CacheUtilizadorLogin.Email;
        }

        private void btnPaginaInicial_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmLogo());     
        }
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Produto());
        }
        private void btnVendas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmVendas());
        }

        private void btnTesouraria_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmTesouraria());
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new FrmRelatorio());
            FrmRelatorio r = new FrmRelatorio();
            r.ShowDialog();
        }

        private void btnDefinicoes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmDefinicoes());
        }

        private void lblTerminarSessao_Click(object sender, EventArgs e)
        {
         if (MessageBox.Show("Queres terminar sessão?", "Terminar sessão",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
         this.Close();
        }

        private void lblCriarConta_Click(object sender, EventArgs e)
        {
            //FrmCadastrarFuncionario abrir = new FrmCadastrarFuncionario();
            //abrir.ShowDialog();
            AbrirFormInPanel(new FrmCadastrarUtilizador());
        }

        private void btnUtilizador_MouseHover(object sender, EventArgs e)
        {
            pnlUtilizador.Visible = true;
        }

        private void btnUtilizador_MouseLeave(object sender, EventArgs e)
        {
            //pnlUtilizador.Visible = false;
        }

        private void btnUtilizador_Click(object sender, EventArgs e)
        {
            pnlUtilizador.Visible = false;
        }

        private void lblDefinicoesConta_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmDefinicoesConta());
        }

        private void pictureExpiracao_MouseHover(object sender, EventArgs e)
        {
            lblExpiracao.Visible = true;
        }

        private void pictureExpiracao_MouseLeave(object sender, EventArgs e)
        {
            lblExpiracao.Visible = false;
        }

        private void pictureStock_MouseHover(object sender, EventArgs e)
        {
            lblStock.Visible = true;
        }

        private void pictureStock_MouseLeave(object sender, EventArgs e)
        {
            lblStock.Visible = false;
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro show = new FrmCadastro();
            AbrirFormInPanel(show);
        }
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmConsulta());
        }

        private void MostrarLogo()
        {
            AbrirFormInPanel(new FrmLogo());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Exibe a data no menu.
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //Exibe a hora no menu.
            lblHora.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
