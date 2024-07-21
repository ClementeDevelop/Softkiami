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
    public partial class FrmConsultarCliente : Form
    {
        ClienteModel cliente = new ClienteModel();
        public FrmConsultarCliente()
        {
            InitializeComponent();
            Consultar();
        }

        private void Consultar()
        {
            try
            {
                ListarClientes.DataSource = cliente.ConsultarClienteModel(txtPesquisa.Text, txtPesquisa.Text, txtPesquisa.Text, txtPesquisa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao consultar os clientes. " +ex);
            } 
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrarCliente AddCliente = new FrmCadastrarCliente();
            AddOwnedForm(AddCliente);
            AddCliente.TopLevel = false;
            AddCliente.Dock = DockStyle.Fill;
            this.Controls.Add(AddCliente);
            this.Tag = AddCliente;
            AddCliente.BringToFront();
            AddCliente.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListarClientes.SelectedRows != null)
                {
                    int CodCliente = Convert.ToInt32(ListarClientes.SelectedRows[0].Cells["CodCliente"].Value);

                    FrmCadastrarCliente ConsCliente = new FrmCadastrarCliente(CodCliente);
                    AddOwnedForm(ConsCliente);
                    ConsCliente.TopLevel = false;
                    ConsCliente.Dock = DockStyle.Fill;
                    this.Controls.Add(ConsCliente);
                    this.Tag = ConsCliente;
                    ConsCliente.BringToFront();

                    if (ConsCliente != null)
                    {
                        ConsCliente.Show();
                        Consultar();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao editar o cliente. " +ex);
            }
        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListarClientes.SelectedRows != null)
                {
                    if (MessageBox.Show("Tens a certeza que desejas eliminar?", "Cliente", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question
                        ) == DialogResult.Yes)
                    {
                        int CodCliente = Convert.ToInt32(ListarClientes.SelectedRows[0].Cells["CodCliente"].Value);

                        if (cliente.EliminarClienteModel(CodCliente))
                        {
                            MessageBox.Show("Eliminado com sucesso. ", "Cliente", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                            Consultar();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao eliminar o cliente. " + ex);
            }
        }
    }
}
