using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class Venda : Conexao
    {
       
        #region Método selecionar produtos.
        public DataTable ListarProdutos()
        {
            DataTable dt = new DataTable();

            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "ListarProdutos";
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(comando);
                sda.Fill(dt);

                //Fecha a conexão com a BD.
                conexao.Close();
            }

            return dt;
        }
        #endregion   
    }
}
