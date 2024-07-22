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
    public partial class FrmCadastrarCliente : Form
    {
        ClienteModel cliente = new ClienteModel();
        int CodCliente = 0;
        public FrmCadastrarCliente()
        {
            InitializeComponent();
        }
        public FrmCadastrarCliente(int CodCliente)
        {
            InitializeComponent();
            this.CodCliente = CodCliente;
            BuscarCodCliente(CodCliente); 
            lblCadastrar.Text = "Editar Cliente";
            btnCadastrar.ButtonText = "Editar";
        }

        private void FrmCadastrarCliente_Load(object sender, EventArgs e)
        {

        }
        private void BuscarCodCliente(int CodCliente)
        {
            try
            {
                DataTable dt = cliente.BuscarCodClienteModel(CodCliente);

                foreach (DataRow item in dt.Rows)
                {
                    txtNome.Text = item["Nome"].ToString();
                    txtNIF.Text = item["NIF"].ToString();
                    txtEmail.Text = item["Email"].ToString();
                    txtTel.Text = item["NumTel"].ToString();
                    dateTimeDataRegist.Value = Convert.ToDateTime(item["DataRegist"]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao buscar o código do cliente. " +ex);
            }
         
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != ""  &  txtNIF.Text != "" & txtEmail.Text != ""  & txtTel.Text != ""  & dateTimeDataRegist.Text != "")
            {
                if (CodCliente == 0)
                {
                    cliente.InserirModel(txtNome.Text, txtNIF.Text, txtEmail.Text, txtTel.Text, DateTime.Parse(dateTimeDataRegist.Text));
                    MessageBox.Show("Cliente cadastrado com sucesso. ", "Cadastro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();               
                }
                else
                {
                    cliente.EditarClienteModel(CodCliente, txtNome.Text, txtNIF.Text, txtEmail.Text, txtTel.Text, DateTime.Parse(dateTimeDataRegist.Text));
                    MessageBox.Show("Cliente editado com sucesso. ", "Edição de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                Limpar();
            }

            else
                MessageBox.Show("Por favor preencha todos os campos", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Limpa os campos do formulário de cadastro de cliente, depois de inseridos todos os dados.
        private void Limpar()
        {
            txtNome.Text = "";
            txtNIF.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
            dateTimeDataRegist.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

