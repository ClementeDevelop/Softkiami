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
    public partial class FrmCadastrarFuncionario : Form
    {
        //Instância da classe FuncionarioModel.
        FuncionarioModel funcionario = new FuncionarioModel();

        int CodFunc = 0;
        public FrmCadastrarFuncionario()
        {
            InitializeComponent();
        }
        public FrmCadastrarFuncionario(int CodFunc)
        {
            InitializeComponent();
            this.CodFunc = CodFunc;
            Buscar_CodFuncionario(CodFunc);
            lblCadastrar.Text = "Editar funcionário";
            btnCadastrar.ButtonText = "Editar";
        }
        public void Buscar_CodFuncionario(int CodFunc)
        {
            try
            {
                DataTable dt = funcionario.BuscarCodFuncModel(CodFunc);

                foreach (DataRow item in dt.Rows)
                {
                    txtNome.Text = item["Nome"].ToString();
                    dateTimeDataNasc.Value = Convert.ToDateTime(item["DataNasc"]);
                    txtNIF.Text = item["NIF"].ToString();
                    cmbFuncao.Text = item["Funcao"].ToString();
                    txtEmail.Text = item["Email"].ToString();                 
                    cmbGenero.Text = item["Genero"].ToString();
                    cmbEstadoCiv.Text = item["EstadoCivil"].ToString();
                    txtTel.Text = item["NumTel"].ToString();
                    txtProvin.Text = item["Provincia"].ToString();
                    txtMuni.Text = item["Municipio"].ToString();
                    txtBairro.Text = item["Bairro"].ToString();
                    txtRua.Text = item["Rua"].ToString();
                    dateTimeDataRegist.Value = Convert.ToDateTime(item["DataRegist"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao buscar o código do funcionário. " +ex);
            }
            
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" & dateTimeDataNasc.Text != "" & txtNIF.Text != "" & cmbFuncao.Text != "" & txtEmail.Text != "" & cmbGenero.Text != "" & cmbEstadoCiv.Text != "" & txtTel.Text != "" & txtProvin.Text != "" & txtMuni.Text != "" & txtBairro.Text != "" & txtRua.Text != "" & dateTimeDataRegist.Text != "")
            {
                if (CodFunc == 0)
                {
                    funcionario.InserirFuncionarioModel(txtNome.Text, DateTime.Parse(dateTimeDataNasc.Text), txtNIF.Text, cmbFuncao.Text, txtEmail.Text, cmbGenero.Text, cmbEstadoCiv.Text, txtTel.Text, txtProvin.Text, txtMuni.Text, txtBairro.Text, txtRua.Text, DateTime.Parse(dateTimeDataRegist.Text));
                    MessageBox.Show("Funcionário cadastrado com sucesso. ", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Close();

                }
                else
                {
                    funcionario.EditarFuncionarioModel(CodFunc, txtNome.Text, DateTime.Parse(dateTimeDataNasc.Text), txtNIF.Text, cmbFuncao.Text, txtEmail.Text, cmbGenero.Text, cmbEstadoCiv.Text, txtTel.Text, txtProvin.Text, txtMuni.Text, txtBairro.Text, txtRua.Text, DateTime.Parse(dateTimeDataRegist.Text));
                    MessageBox.Show("Funcionário editado com sucesso. ", "Edição de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }      
                    Limpar();

            }

            else
                MessageBox.Show("Por favor preencha todos os campos. ", "Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Limpar()
        {
            txtNome.Text = "";
            dateTimeDataNasc.Text = "";
            txtNIF.Text = "";
            cmbFuncao.Text = "";
            txtEmail.Text = "";
            cmbGenero.Text = "";
            cmbEstadoCiv.Text = "";
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
