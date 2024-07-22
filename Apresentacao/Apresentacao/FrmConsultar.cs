using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmConsultar : Form
    {
        UtilizadorModel Ins = new UtilizadorModel();
        public FrmConsultar()
        {
            InitializeComponent();
            Consultar();
        }

        public void Consultar()
        {
            try
            {
                ListarFuncionario.DataSource = Ins.ConsultarModel(txtPesquisa.text);
            }
            catch (Exception)
            {
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
          
        }

        private void txtPesquisa_OnTextChange(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListarFuncionario.SelectedRows != null)
                {
                    int CodFunc = Convert.ToInt32(ListarFuncionario.SelectedRows[0].Cells["CodFunc"].Value);
                    FrmRegisto registo = new FrmRegisto(CodFunc);
                    if (registo.ShowDialog() != null)
                    {
                        Consultar();
                    }

                }
            }
            catch
            {

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FrmRegisto RG = new FrmRegisto();
            if (RG.ShowDialog() != null)
            {
                Consultar();
            }
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListarFuncionario.SelectedRows != null)
                {
                    if (MessageBox.Show("Tens a certeza que desejas eliminar?","Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
                    {
                        int CodFunc = Convert.ToInt32(ListarFuncionario.SelectedRows[0].Cells["CodFunc"].Value);
                        if (Ins.EliminarModel(CodFunc))
                        {
                            MessageBox.Show("Eliminado com sucesso!");
                            Consultar();
                        }
                        
                    }
                }
            }
            catch 
            {
                
            }
        }
    }
}
