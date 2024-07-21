using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dados
{
    public abstract class Conexao
    {
        //String de conexão.
        private readonly string strConexao;
        //private readonly string strConexao1;
        public Conexao() 
        {
            strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Fernandes\BDs\BDSoftkiami.mdf;Integrated Security=True;Connect Timeout=30";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(strConexao);
        }
        //protected SqlCeConnection GetConnection()
        //{
        //    //return new SqlCeConnection(strConexao1);
        //}


    }
}