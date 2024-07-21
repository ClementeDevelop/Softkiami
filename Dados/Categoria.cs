using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class Categoria : Conexao
    {
        private SqlDataReader LerLinhas;

        #region Método consultar categoria.
        public DataTable ConsultarCategoria()
        {
            DataTable dt = new DataTable();

            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                //SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                comando.CommandText = "ConsultarCategoria";
                comando.CommandType = CommandType.StoredProcedure;
                LerLinhas = comando.ExecuteReader();
                dt.Load(LerLinhas);
                LerLinhas.Close();
            }

            return dt;
        }
        #endregion  
        
    }
}
