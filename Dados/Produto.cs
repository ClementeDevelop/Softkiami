using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Comum;

namespace Dados
{
    public class Produto : Conexao
    {
        private SqlDataReader sdr;

        #region Método inserir produto.
        public bool Inserir(string Designacao, float IVA, float PUnitario, float Desconto, int CodCateg)
        {
            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                //Instância da classe SqlCommand.
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexao;
                comando.CommandText = "InserirProduto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Designacao", Designacao);
                comando.Parameters.AddWithValue("@IVA", IVA);
                comando.Parameters.AddWithValue("@PUnitario", PUnitario);
                comando.Parameters.AddWithValue("@Desconto", Desconto);
                comando.Parameters.AddWithValue("@CodCateg", CodCateg);

                if (comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        #endregion

        #region Método listar produtos.
        public DataTable ListarProdutos()
        {
            DataTable dt = new DataTable();

            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                //Instância da classe SqlCommand.
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexao;
                comando.CommandText = "ListarProdutos";
                comando.CommandType = CommandType.StoredProcedure;
                sdr = comando.ExecuteReader();
                dt.Load(sdr);
                sdr.Close();
            }

            return dt;
        }
        #endregion

        #region Método procurar produtos.
        public DataTable ProcurarProdutos(string Designacao)
        {
            //Instância da classe DataTable.
            DataTable dt = new DataTable();

            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                //Instância da classe SqlCommand.
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexao;
                comando.CommandText = "ProcurarProduto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("Designacao", "%" + Designacao + "%");
                sdr = comando.ExecuteReader();
                dt.Load(sdr);
                sdr.Close();
            }

            return dt;
        }
        #endregion

        #region Método buscar código do produto.
        public DataTable Buscar_CodProdut(int CodProdut)
        {
            //Instância da classe DataTable.
            DataTable dt = new DataTable();

            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                //Instância da classe SqlCommand.
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexao;
                comando.CommandText = "Buscar_CodProdut";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodProdut" ,CodProdut);
                sdr = comando.ExecuteReader();
                dt.Load(sdr);
                sdr.Close();
            }

            return dt;
        }
        #endregion

        #region Método editar produto.
        public bool Editar(int CodProdut, string Designacao, float IVA,
        float PUnitario,
        float Desconto, int CodCateg)
        {
            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                //Instância da classe SqlCommand.
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexao;
                comando.CommandText = "EditarProduto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodProdut", CodProdut);
                comando.Parameters.AddWithValue("@Designacao", Designacao);
                comando.Parameters.AddWithValue("@IVA", IVA);
                comando.Parameters.AddWithValue("@PUnitario", PUnitario);
                comando.Parameters.AddWithValue("@Desconto", Desconto);
                comando.Parameters.AddWithValue("@CodCateg", CodCateg);

                if (comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        #endregion

        #region Método Eliminar
        public bool Eliminar(int CodProdut)
        {
            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                //SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                comando.CommandText = "EliminarProduto";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodProdut", CodProdut);
                if (comando.ExecuteNonQuery() > 0)
                {
                    return true;

                }
                else
                    return false;
            }
        }
        #endregion

        #region Método contar produto.
        public DataTable CountProduto()
        {
            //Instância da classe DataTable.
            DataTable dt = new DataTable();

            using (var conexao = GetConnection())
            {
                //Abre a base de dados.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "Count_Produto";
                SqlDataAdapter sda = new SqlDataAdapter(comando);
                sda.Fill(dt);
            }

            return dt;
        }
        #endregion
    }
}

