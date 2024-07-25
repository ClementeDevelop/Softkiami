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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region DllImport
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr wmsg, int hwms, int wparam, int Iparam);
        #endregion
 

        private void txtUtilizador_Enter(object sender, EventArgs e)
        {
            if (txtUtilizador.Text == "Utilizador")
            {
                txtUtilizador.Text = "";
            }
        }

        private void txtUtilizador_Leave(object sender, EventArgs e)
        {
            if (txtUtilizador.Text == "")
            {
                txtUtilizador.Text = "Utilizador";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void pnlVertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUtilizador.Text != "Utilizador")
            {
                if (txtSenha.Text != "Senha")
                {
                    UtilizadorModel utiliz = new UtilizadorModel();
                    var ValidLogin = utiliz.UtilizadorLogin(txtUtilizador.Text, txtSenha.Text);

                    if (ValidLogin == true)
                    {
                      
                            FrmMenu menu = new FrmMenu();
                            MessageBox.Show("Bem-vindo (a)" + "  " + CacheUtilizadorLogin.Nome, 
                            "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            menu.Show();
                            menu.FormClosed += Logout;
                            this.Hide();                      
                                           
                    }
                    else
                    {
                        MessageBox.Show("Utilizador ou senha errados. \nPor favor tente novamente.",
                        "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSenha.Clear();
                        txtUtilizador.Focus();
                    }
                }
                else
                    MessageBox.Show("Por favor introduza a senha.", "Falha!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Por favor introduza o utilizador.", "Falha!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtSenha.Clear();
            txtUtilizador.Clear();
            this.Show();
            txtUtilizador.Focus();
        }

        private void pictureBoxEye_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void pictureBoxEye_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }
    }
}
