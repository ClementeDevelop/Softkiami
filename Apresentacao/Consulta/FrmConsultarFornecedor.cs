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
    public partial class FrmConsultarFornecedor : Form
    {
        FornecedorModel fornec = new FornecedorModel();
        public FrmConsultarFornecedor()
        {
            InitializeComponent();
            Consultar();
        }

        private void Consultar()
        {
            try
            {
                ListarFornecedores.DataSource = fornec.ConsultarFornecedorModel(txtPesquisa.Text, txtPesquisa.Text, txtPesquisa.Text, txtPesquisa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar o fornecedor. " + ex);
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarFornecedor AddFornecedor = new FrmCadastrarFornecedor();
            AddOwnedForm(AddFornecedor);
            AddFornecedor.TopLevel = false;
            AddFornecedor.Dock = DockStyle.Fill;
            this.Controls.Add(AddFornecedor);
            //this.tag = AddFornecedor;
            AddFornecedor.BringToFront();
            AddFornecedor.Show();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListarFornecedores.SelectedRows != null)
                {
                    int CodFornec = Convert.ToInt32(ListarFornecedores.SelectedRows[0].Cells["CodFornec"].Value);

                    FrmCadastrarFornecedor ConsFornec = new FrmCadastrarFornecedor(CodFornec);
                    AddOwnedForm(ConsFornec);
                    ConsFornec.TopLevel = false;
                    ConsFornec.Dock = DockStyle.Fill;
                    this.Controls.Add(ConsFornec);
                    this.Tag = ConsFornec;
                    ConsFornec.BringToFront();

                    if (ConsFornec != null)
                    {
                        ConsFornec.Show();
                        Consultar();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao editar o fornecedor.  " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListarFornecedores.SelectedRows != null)
                {
                    if (MessageBox.Show("Tens a certeza que desejas eliminar? ", "Fornecedor",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int CodFornec = Convert.ToInt32(ListarFornecedores.SelectedRows[0].Cells["CodFornec"].Value);

                        if (fornec.EliminarFornecedorModel(CodFornec))
                        {
                            MessageBox.Show("Eliminado com sucesso. ", "Fornecedor", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                            Consultar();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao eliminar o fornecedor. " + ex);
            }
        }

    }
}
