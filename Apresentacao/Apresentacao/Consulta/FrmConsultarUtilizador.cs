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
    public partial class FrmConsultarUtilizador : Form
    {
        UtilizadorModel uModel = new UtilizadorModel();
        public FrmConsultarUtilizador()
        {
            InitializeComponent();
            Consultar();
        }
        #region
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr wmsg, int hwms, int wparam, int Iparam);
        #endregion

        private void Consultar()
        {
            try
            {
                ListarUtilizadores.DataSource = uModel.ConsultarModel(txtPesquisa.Text, txtPesquisa.Text, txtPesquisa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar o utilizador. " +ex);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarUtilizador AddUtiliz = new FrmCadastrarUtilizador();
            AddOwnedForm(AddUtiliz);
            AddUtiliz.TopLevel = false;
            AddUtiliz.Dock = DockStyle.Fill;
            this.Controls.Add(AddUtiliz);
            this.Tag = AddUtiliz;
            AddUtiliz.BringToFront();
            AddUtiliz.Show();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListarUtilizadores.SelectedRows != null)
                {
                    int CodUtilizador = Convert.ToInt32(ListarUtilizadores.SelectedRows[0].Cells["CodUtilizador"].Value);

                    FrmCadastrarUtilizador cadastro = new FrmCadastrarUtilizador(CodUtilizador);
                    AddOwnedForm(cadastro);
                    cadastro.TopLevel = false;
                    cadastro.Dock = DockStyle.Fill;
                    this.Controls.Add(cadastro);
                    this.Tag = cadastro;
                    cadastro.BringToFront();

                    if (cadastro != null)
                    {
                        cadastro.Show();
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao editar o utilizador. " +ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListarUtilizadores.SelectedRows != null)
                {
                    if (MessageBox.Show("Tens a certeza que desejas eliminar?", "Utilizador", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                        )== DialogResult.Yes)
                    {
                        int CodUtilizador = Convert.ToInt32(ListarUtilizadores.SelectedRows[0].Cells["CodUtilizador"].Value);

                        if (uModel.EliminarModel(CodUtilizador))
                        {
                            MessageBox.Show("Eliminado com sucesso. ", "Utilizador" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Consultar();
                        }
                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao eliminar o utilizador. " +ex);
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
