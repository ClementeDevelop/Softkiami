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
    public class Utilizador : Conexao
    {
        #region Método Login.
        public bool Login(string Utiliza, string Senha)
        {
            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = "LoginUser";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Utiliza", Utiliza);
                    comando.Parameters.AddWithValue("@Senha", Senha);
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheUtilizadorLogin.CodUtilizador = reader.GetInt32(0);
                            CacheUtilizadorLogin.Nome = reader.GetString(1);
                            CacheUtilizadorLogin.Funcao = reader.GetString(6);
                            //CacheUtilizadorLogin.Email = reader.GetString(7);
                        }
                        return true;
                    }
                    else

                        return false;

                }

            }
        }
        #endregion

        #region Método Inserir.
        public bool Inserir(UtilizadorComum comum)
        {
            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "InserirUtilizador";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nome", comum.Nome);
                comando.Parameters.AddWithValue("@DataNasc", comum.DataNasc);
                comando.Parameters.AddWithValue("@NIF", comum.NIF);
                comando.Parameters.AddWithValue("@Utiliza", comum.Utiliza);
                comando.Parameters.AddWithValue("@Senha", comum.Senha);
                comando.Parameters.AddWithValue("@Funcao", comum.Funcao);
                comando.Parameters.AddWithValue("@Email", comum.Email);
                comando.Parameters.AddWithValue("@Genero", comum.Genero);
                comando.Parameters.AddWithValue("@EstadoCivil", comum.EstadoCivil);
                comando.Parameters.AddWithValue("@NumTel", comum.NumTel);
                comando.Parameters.AddWithValue("@Provincia", comum.Provincia);
                comando.Parameters.AddWithValue("@Municipio", comum.Municipio);
                comando.Parameters.AddWithValue("@Bairro", comum.Bairro);
                comando.Parameters.AddWithValue("@Rua", comum.Rua);
                comando.Parameters.AddWithValue("@DataRegist", comum.DataRegist);

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

        #region Método buscar código do utilizador
        public DataTable BuscarCodUtilizador(int CodUtilizador)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conexao = GetConnection())
                {
                    conexao.Open();
                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexao;
                    comando.CommandText = "BuscarCodUtilizador";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@CodUtilizador", CodUtilizador);
                    SqlDataAdapter Adapt = new SqlDataAdapter(comando);
                    Adapt.Fill(dt);
                }
            }
            catch
            {

            }
            return dt;
        }
        #endregion

        #region Método Consultar.
        public DataTable Consultar(string Nome, string NIF, string Funcao)
        {

            //Instância da classe DataTable.
            DataTable dt = new DataTable();
        
                using (var conexao = GetConnection())
                {
                    //Abre a conexão com a BD.
                    conexao.Open();

                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexao;
                    comando.CommandText = "ConsultarUtilizador";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("Nome", "%" + Nome + "%");
                    comando.Parameters.AddWithValue("NIF", "%" + NIF + "%");
                    comando.Parameters.AddWithValue("Funcao", "%" + Funcao + "%");
                    SqlDataAdapter Adapt = new SqlDataAdapter(comando);
                    Adapt.Fill(dt);
                }
          
        
            return dt;

        }

        #endregion

        #region Método Editar.
        public bool Editar(int CodUtilizador, string Nome, DateTime DataNasc, string NIF, string Utiliza, string Senha, string Funcao, string Email, string Genero, string EstadoCivil, int NumTel, string Provincia, string Municipio, string Bairro, string Rua, DateTime DataRegist)
        {
            using (var conexao = GetConnection())
            {

                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "EditarUtilizador";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodUtilizador", CodUtilizador);
                comando.Parameters.AddWithValue("@Nome", Nome);
                comando.Parameters.AddWithValue("@DataNasc",DataNasc);
                comando.Parameters.AddWithValue("@NIF", NIF);
                comando.Parameters.AddWithValue("@Utiliza", Utiliza);
                comando.Parameters.AddWithValue("@Senha", Senha);
                comando.Parameters.AddWithValue("@Funcao", Funcao);
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

        #region Método Eliminar.
        public bool Eliminar(int CodUtilizador)
        {
            using (var conexao = GetConnection())
            {

                //Abre a base de dados.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                //SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                comando.CommandText = "EliminarUtilizador";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodUtilizador", CodUtilizador);
                if (comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else

                    return false;

            }
        }
        #endregion

        #region Método contar utilizador.
        public DataTable CountUtilizador()
        {
            //Instância da classe DataTable.
            DataTable dt = new DataTable();

            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "Count_Utilizador";
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
