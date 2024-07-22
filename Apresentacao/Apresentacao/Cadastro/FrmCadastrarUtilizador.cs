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
using Comum;

namespace Apresentacao
{
    public partial class FrmCadastrarUtilizador : Form
    {
        int CodUtilizador = 0;

        //Instância da classe UtilizadorModel.
        UtilizadorModel uModel = new UtilizadorModel();
        //Instância da classe UtilizadorComum.
        UtilizadorComum comum = new UtilizadorComum();
        public FrmCadastrarUtilizador()
        {
            InitializeComponent();
        }
        public FrmCadastrarUtilizador(int CodUtilizador)
        {
            InitializeComponent();
            this.CodUtilizador = CodUtilizador;
            BuscarCodUtilizador(CodUtilizador);
            lblCadastrar.Text = "Editar Utilizador";
            btnCadastrar.ButtonText = "Editar";

        }
        private void FrmCadastrarUtilizador_Load(object sender, EventArgs e)
        {
        }
        public void BuscarCodUtilizador(int CodUtilizador)
        {
            try
            {
                /*A variável "dt" recebe o método BuscarCodUtilizadorModel*/
                DataTable dt = uModel.BuscarCodUtilizadorModel(CodUtilizador);

                foreach (DataRow item in dt.Rows)
                {
                    comum.Nome = txtNome.Text = item["Nome"].ToString();
                    comum.DataNasc = dateTimeDataNasc.Value = Convert.ToDateTime(item["DataNasc"]);
                    comum.NIF = txtNIF.Text = item["NIF"].ToString();
                    comum.Utiliza = txtutilizador.Text = item["Utiliza"].ToString();
                    comum.Senha = txtsenha.Text = item["Senha"].ToString();
                    comum.Funcao = cmbFuncao.Text = item["Funcao"].ToString();
                    comum.Email = txtEmail.Text = item["Email"].ToString();
                    comum.Genero = cmbGenero.Text = item["Genero"].ToString();
                    comum.EstadoCivil = comboEstadoCiv.Text = item["EstadoCivil"].ToString();
                    comum.NumTel = txtTel.Text = item["NumTel"].ToString();
                    comum.Provincia = txtProvin.Text = item["Provincia"].ToString();
                    comum.Municipio = txtMuni.Text = item["Municipio"].ToString();
                    comum.Bairro = txtBairro.Text = item["Bairro"].ToString();
                    comum.Rua = txtRua.Text = item["Rua"].ToString();
                    comum.DataRegist = dateTimeDataRegist.Value = Convert.ToDateTime(item["DataRegist"]);
               }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha ao buscar o código do utilizador. " +ex);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            //Fecha o formulário de cadastro.
            this.Close();
        }

        //Limpa o formulário de cadastro.
        private void Limpar()
        {
            txtNome.Text = "";
            dateTimeDataNasc.Text = "";
            txtNIF.Text = "";
            txtutilizador.Text = "";
            txtsenha.Text = "";
            cmbFuncao.Text = "";
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

        //Cadastra o utilizador.
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" & dateTimeDataNasc.Text != "" & txtNIF.Text != "" & txtutilizador.Text != "" & txtsenha.Text != "" & cmbFuncao.Text != "" & txtEmail.Text != "" & cmbGenero.Text != "" & comboEstadoCiv.Text != "" & txtTel.Text != "" & txtProvin.Text != "" & txtMuni.Text != "" & txtBairro.Text != "" & txtRua.Text != "" & dateTimeDataRegist.Text != "")
            {
                if (CodUtilizador == 0)
                {
                    Cadastrar();
                    uModel.InserirModel(comum);
                    MessageBox.Show("Utilizador cadastrado com sucesso. ", "Utilizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    uModel.EditarModel(CodUtilizador, txtNome.Text, DateTime.Parse(dateTimeDataNasc.Text), txtNIF.Text, txtutilizador.Text, txtsenha.Text, cmbFuncao.Text, txtEmail.Text, cmbGenero.Text,  comboEstadoCiv.Text, int.Parse(txtTel.Text), txtProvin.Text, txtMuni.Text, txtBairro.Text, txtRua.Text, DateTime.Parse(dateTimeDataRegist.Text));
                    MessageBox.Show("Utilizador editado com sucesso.", "Utilizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                //Este método limpa todos os campos do forrmulário de cadastro depois de preenchido.                           
                Limpar();
            }
            else

                MessageBox.Show("Por favor preencha todos os campos. ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        //Valida o campo telefone.
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Atribui os valores dos campos do formulário de cadastro nas respectivas propriedades da classe 
        UtitilizadorComum.*/
        private void Cadastrar()
        {
            comum.Nome = txtNome.Text;
            comum.DataNasc = DateTime.Parse(dateTimeDataNasc.Text);
            comum.NIF = txtNIF.Text;
            comum.Utiliza = txtutilizador.Text;
            comum.Senha = txtsenha.Text;
            comum.Funcao = cmbFuncao.Text;
            comum.Email = txtEmail.Text;
            comum.Genero = cmbGenero.Text;
            comum.EstadoCivil = comboEstadoCiv.Text;
            comum.NumTel = txtTel.Text;
            comum.Provincia = txtProvin.Text;
            comum.Municipio = txtMuni.Text;
            comum.Bairro = txtBairro.Text;
            comum.Rua = txtRua.Text;
            comum.DataRegist = DateTime.Parse(dateTimeDataRegist.Text);
        }

        /*Atribui os valores dos campos nas respectivas propriedades
        .*/

    }
}
