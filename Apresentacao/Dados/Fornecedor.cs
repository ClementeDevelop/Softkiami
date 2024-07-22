using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class Fornecedor:Conexao
    {
        #region Método inserir fornecedor.
        public bool Inserir(string Nome, DateTime DataNasc, string NIF, string Email, string Genero, string EstadoCivil, string NumTel, string Provincia, string Municipio, string Bairro, string Rua, DateTime DataRegist)
        {
            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "InserirFornecedor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nome", Nome);
                comando.Parameters.AddWithValue("@DataNasc", DataNasc);
                comando.Parameters.AddWithValue("@NIF", NIF);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Genero", Genero);
                comando.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);
                comando.Parameters.AddWithValue("@NumTel", NumTel);
                comando.Parameters.AddWithValue("@Provincia", Provincia);
                comando.Parameters.AddWithValue("@Municipio", Municipio);
                comando.Parameters.AddWithValue("@Bairro", Bairro);
                comando.Parameters.AddWithValue("@Rua", Rua);
                comando.Parameters.AddWithValue("@DataRegist", DataRegist);
                if (comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        #endregion
         
        #region Método consultar fornecedor.
        public DataTable Consultar(string Nome, string NIF, string Email, string NumTel)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conexao = GetConnection())
                {
                    //Abre a conexão com a BD.
                    conexao.Open();

                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexao;
                    comando.CommandText = "ConsultarFornecedor";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Nome", "%" + Nome + "%");
                    comando.Parameters.AddWithValue("@NIF", "%" + NIF + "%");
                    comando.Parameters.AddWithValue("@Email", "%" + Email + "%");
                    comando.Parameters.AddWithValue("@NumTel", "%" + NumTel + "%");
                    SqlDataAdapter adapt = new SqlDataAdapter(comando);
                    adapt.Fill(dt);
                }
            }
            catch
            {

            }
            return dt;
        }
        #endregion

        #region Método buscar código do fornecedor.
        public DataTable BuscarCodFornecedor(int CodFornec)
        {
            DataTable dt = new DataTable();

            try
            {
                using (var conexao = GetConnection())
                {
                    //Abre a conexão com a BD.
                    conexao.Open();

                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexao;
                    comando.CommandText = "BuscarCodFornecedor";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@CodFornec", CodFornec);
                    SqlDataAdapter adapt = new SqlDataAdapter(comando);
                    adapt.Fill(dt);
                }
            }
            catch
            {

            }
            return dt;
        }
        #endregion

        #region Método editar fornecedor.
        public bool Editar(int CodFornec, string Nome, DateTime DataNasc, string NIF, string Email,
        string Genero, string EstadoCivil, string NumTel, string Provincia, string Municipio, string Bairro,
        string Rua, DateTime DataRegist)
        {

            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "EditarFornecedor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodFornec", CodFornec);
                comando.Parameters.AddWithValue("@Nome", Nome);
                comando.Parameters.AddWithValue("@DataNasc", DataNasc);
                comando.Parameters.AddWithValue("@NIF", NIF);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Genero", Genero);
                comando.Parameters.AddWithValue("@EstadoCivil", EstadoCivil);
                comando.Parameters.AddWithValue("@NumTel", NumTel);
                comando.Parameters.AddWithValue("@Provincia", Provincia);
                comando.Parameters.AddWithValue("@Municipio", Municipio);
                comando.Parameters.AddWithValue("@Bairro", Bairro);
                comando.Parameters.AddWithValue("@Rua", Rua);
                comando.Parameters.AddWithValue("@DataRegist", DataRegist);

                if (comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        #endregion

        #region Método eliminar fornecedor.
        public bool Eliminar(int CodFornec)
        {
            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "EliminarFornecedor";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodFornec", CodFornec);

                if (comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        #endregion

        #region Método contar fornecedor.
        public DataTable CountFornecedor()
        {
            //Instância da classe DataTable.
            DataTable dt = new DataTable();

            using (var conexao = GetConnection())
            {
                //Abre a base de dados.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "Count_Fornecedor";
                SqlDataAdapter sda = new SqlDataAdapter(comando);
                sda.Fill(dt);
            }

            return dt;
        }
        #endregion
    }
}
