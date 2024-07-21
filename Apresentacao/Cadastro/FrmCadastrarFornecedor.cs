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
    public partial class FrmCadastrarFornecedor : Form
    {
        FornecedorModel fornec = new FornecedorModel();
        int CodFornec = 0;
        public FrmCadastrarFornecedor()
        {
            InitializeComponent();
        }
        public FrmCadastrarFornecedor(int CodFornec)
        {
            InitializeComponent();
            BuscarCodFornecedor(CodFornec);
            this.CodFornec = CodFornec;
            lblCadastrar.Text = "Editar Fornecedor";
            btnCadastrar.ButtonText = "Editar";
        }

        private void BuscarCodFornecedor(int CodFornec)
        {
            try
            {
                DataTable dt = fornec.BuscarCodFornecModel(CodFornec);

                foreach (DataRow Item in dt.Rows)
                {
                    txtNome.Text = Item["Nome"].ToString();
                    dateTimeDataNasc.Value = Convert.ToDateTime(Item["DataNasc"]);
                    txtNIF.Text = Item["NIF"].ToString();
                    txtEmail.Text = Item["Email"].ToString();
                    cmbGenero.Text = Item["Genero"].ToString();
                    comboEstadoCiv.Text = Item["EstadoCivil"].ToString();
                    txtTel.Text = Item["NumTel"].ToString();
                    txtProvin.Text = Item["Provincia"].ToString();
                    txtMuni.Text = Item["Municipio"].ToString();
                    txtBairro.Text = Item["Bairro"].ToString();
                    txtRua.Text = Item["Rua"].ToString();
                    dateTimeDataRegist.Value = Convert.ToDateTime(Item["DataRegist"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao buscar o código do fornecedor. " + ex);
            }

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" & dateTimeDataNasc.Text != "" & txtNIF.Text != "" & txtEmail.Text != "" & cmbGenero.Text != "" & comboEstadoCiv.Text != "" & txtTel.Text != "" & txtProvin.Text != "" & txtMuni.Text != "" & txtBairro.Text != "" & txtRua.Text != "" & dateTimeDataRegist.Text != "")
            {
                if (CodFornec == 0)
                {
                fornec.InserirFornecedorModel(txtNome.Text, DateTime.Parse(dateTimeDataNasc.Text), txtNIF.Text, txtEmail.Text, cmbGenero.Text, comboEstadoCiv.Text, txtTel.Text, txtProvin.Text, txtMuni.Text, txtBairro.Text, txtRua.Text, DateTime.Parse(dateTimeDataRegist.Text));
                MessageBox.Show("Fornecedor cadastrado com sucesso. ", "Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
                }
                else
                {
                    fornec.EditarFornecedorModel(CodFornec, txtNome.Text, DateTime.Parse(dateTimeDataNasc.Text), txtNIF.Text, txtEmail.Text, cmbGenero.Text, comboEstadoCiv.Text, txtTel.Text, txtProvin.Text, txtMuni.Text, txtBairro.Text, txtRua.Text, DateTime.Parse(dateTimeDataRegist.Text));
                    MessageBox.Show("Fornecedor editado com sucesso. ", "Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
           
                Limpar();
            }
            else
                MessageBox.Show("Por favor preencha todos os campos", "Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Limpa todos os campos do formulário de cadastro depois de preenchidos.
        private void Limpar()
        {
            txtNome.Text = "";
            dateTimeDataNasc.Text = "";
            txtNIF.Text = "";
            txtEmail.Text = "";
            cmbGenero.Text = "";
            comboEstadoCiv.Text = "";
            txtTel.Text = "";
            txtProvin.Text = "";
            txtMuni.Text = "";
            txtBairro.Text = "";
            txtRua.Text = "";
            dateTimeDataRegist.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Permite apenas a entrada de números no campo telenone.
        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Permite apenas a entrada de números no campo NIF.
        private void txtNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
