using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class TipoPGT : Conexao
    {
        private SqlDataReader LerLinhas;

        #region Método Listar TipoPGT.
        public DataTable ListarTipoPGT()
        {
            DataTable tabela = new DataTable();

            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                //SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                comando.CommandText = "ListarTipoPGT";
                comando.CommandType = CommandType.StoredProcedure;
                LerLinhas = comando.ExecuteReader();
                tabela.Load(LerLinhas);
                LerLinhas.Close();
            }

            return tabela;
        }
        #endregion  
    }
}
