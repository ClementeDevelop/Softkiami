using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Apresentacao
{
    public partial class FrmConsultarFuncionario : Form
    {
        FuncionarioModel fModel = new FuncionarioModel();

        public FrmConsultarFuncionario()
        {
            InitializeComponent();
        }
        private void FrmConsultarFuncionario_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        //O método Consultar permite pesquisar os funcionários na barra de pesquisa.
        public void Consultar()
        {
            try
            {
                ListarFuncionarios.DataSource = fModel.ConsultarFuncionarioModel(txtPesquisa.Text, txtPesquisa.Text, txtPesquisa.Text, txtPesquisa.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao consultar o funcionário. " +ex);
            }
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarFuncionario AddFunc = new FrmCadastrarFuncionario();
            AddOwnedForm(AddFunc);
            AddFunc.TopLevel = false;
            AddFunc.Dock = DockStyle.Fill;
            this.Controls.Add(AddFunc);
            this.Tag = AddFunc;
            AddFunc.BringToFront();
            AddFunc.Show();
            Consultar();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListarFuncionarios.SelectedRows != null)
                {
                    int CodFunc = Convert.ToInt32(ListarFuncionarios.SelectedRows[0].Cells["CodFunc"].Value);

                    FrmCadastrarFuncionario funcionario = new FrmCadastrarFuncionario(CodFunc);
                    AddOwnedForm(funcionario);
                    funcionario.TopLevel = false;
                    funcionario.Dock = DockStyle.Fill;
                    this.Controls.Add(funcionario);
                    this.Tag = funcionario;
                    funcionario.BringToFront();

                    if (funcionario != null)
                    {
                        funcionario.Show();
                        Consultar();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao editar o funcionário. " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListarFuncionarios.SelectedRows != null)
                {
                    if (MessageBox.Show("Tens a certeza que desejas eliminar? ", "Funcionario",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int CodFunc = Convert.ToInt32(ListarFuncionarios.SelectedRows[0].Cells["CodFunc"].Value);

                        if (fModel.EliminarFuncionarioModel(CodFunc))
                        {
                            MessageBox.Show("Eliminado com sucesso. ", "Funcionario", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            Consultar();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao eliminar o funcionario. " + ex);
            }
        }
    }
}
