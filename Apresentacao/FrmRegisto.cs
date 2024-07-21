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

namespace Apresentacao
{
    public partial class FrmRegisto : Form
    {
        int CodFunc = 0;
        public FrmRegisto()
        {
            InitializeComponent();
        }
        public FrmRegisto(int CodFunc)
        {
            InitializeComponent();
            this.CodFunc = CodFunc;
            Buscar(CodFunc);
            lblCadastrar.Text = "Editar";
            btnCadastrar.ButtonText = "Editar";

        }
        public void Buscar(int CodFunc)
        {
            try
            {
                DataTable dt = Ins.BuscarPorCodFuncModel(CodFunc);

                foreach (DataRow item in dt.Rows)
                {
                    txtNome.Text = item["Nome"].ToString();
                    dateTimeDataNasc.Value = Convert.ToDateTime(item["DataNasc"]);
                    txtNIF.Text = item["NIF"].ToString();
                    txtutilizador.Text = item["Utiliza"].ToString();
                    txtsenha.Text = item["Senha"].ToString();
                    comboFuncao.Text = item["Funcao"].ToString();
                    txtEmail.Text = item["Email"].ToString();
                    comboGenero.Text = item["Genero"].ToString();
                    comboEstadoCiv.Text = item["EstadoCivil"].ToString();
                    txtTel.Text = item["NumTelef"].ToString();
                    comboProvin.Text = item["Provincia"].ToString();
                    comboMuni.Text = item["Municipio"].ToString();
                    comboBairro.Text = item["Bairro"].ToString();
                    comboRua.Text = item["Rua"].ToString();
                    dateTimeDataRegist.Value = Convert.ToDateTime(item["DataRegist"]);
                }


            }
            catch (Exception ex)
            {

            }
        }
        #region DllImport
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr wmsg, int hwms, int wparam, int Iparam);
        #endregion
        private void FrmRegisto_MouseDown(object sender, MouseEventArgs e)
        {
            //Os métodos ReleaseCapture e SendMessage permitem arrastar o formulário de registo.
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void FrmRegisto_Load(object sender, EventArgs e)
        {
            //txtsenha.UseSystemPasswordChar = true;
        }
        UtilizadorModel Ins = new UtilizadorModel();
        private void btnCadastrar_Click(object sender, EventArgs e)
        {  
            if (txtNome.Text != "" & dateTimeDataNasc.Text != "" & txtNIF.Text != "" & txtutilizador.Text != "" & txtsenha.Text != "" & comboFuncao.Text != "" & txtEmail.Text != "" & comboGenero.Text != "" & comboEstadoCiv.Text != "" & txtTel.Text != "" & comboProvin.Text != "" & comboMuni.Text != "" & comboBairro.Text != "" & comboRua.Text != "" & dateTimeDataRegist.Text != "")
            {
                if (CodFunc == 0)
                {
                    Ins.InserirModel(txtNome.Text, dateTimeDataNasc.Text, txtNIF.Text, txtutilizador.Text, txtsenha.Text, comboFuncao.Text, txtEmail.Text, comboGenero.Text, comboEstadoCiv.Text, txtTel.Text, comboProvin.Text, comboMuni.Text, comboBairro.Text, comboRua.Text, dateTimeDataRegist.Text);
                    MessageBox.Show("Cadastro efetuado com sucesso", "Aviso");
                    this.Close();
                }
                else
                {
                    Ins.EditarModel(CodFunc, txtNome.Text, dateTimeDataNasc.Text, txtNIF.Text, txtutilizador.Text, txtsenha.Text, comboFuncao.Text, txtEmail.Text, comboGenero.Text, comboEstadoCiv.Text, txtTel.Text, comboProvin.Text, comboMuni.Text, comboBairro.Text, comboRua.Text, dateTimeDataRegist.Text);
                    MessageBox.Show("Cadastro editado com sucesso.", "Aviso");
                    this.Close();
                }
                Limpar();
            }
             else
            {
              MessageBox.Show("Por favor preencha os campos obrigatórios.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Limpar()
        {
            txtNome.Text = "";
            dateTimeDataNasc.Text = "";
            txtNIF.Text = "";
            txtutilizador.Text = "";
            txtsenha.Text = "";
            comboFuncao.Text = "";
            txtEmail.Text = "";
            comboGenero.Text = "";
            comboEstadoCiv.Text = "";
            txtTel.Text = "";
            comboProvin.Text = "";
            comboMuni.Text = "";
            comboBairro.Text = "";
            comboRua.Text = "";
            dateTimeDataRegist.Text = "";
        }

        private void lblRua_Click(object sender, EventArgs e)
        {

        }

        private void lblFuncao_Click(object sender, EventArgs e)
        {

        }

        private void ComboBo_Click(object sender, EventArgs e)
        {

        }
    }
}
