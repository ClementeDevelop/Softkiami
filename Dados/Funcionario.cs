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
    public class Funcionario : Conexao
    {
        public object CodCliente { get; private set; }

        #region Método inserir funcionário
        public bool Inserir(string Nome, DateTime DataNasc, string NIF, string Funcao, string Email, string Genero, string EstadoCivil, string NumTel, string Provincia, string Municipio, string Bairro, string Rua, DateTime DataRegist)
        {
            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "InserirFuncionario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nome", Nome);
                comando.Parameters.AddWithValue("@DataNasc", DataNasc);
                comando.Parameters.AddWithValue("@NIF", NIF);
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

        #region Método consultar funcionário.
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
                    comando.CommandText = "ConsultarFuncionario";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Nome", "%" + Nome + "%");
                    comando.Parameters.AddWithValue("@Email", "%" + Email + "%");
                    comando.Parameters.AddWithValue("@NIF", "%" + NIF + "%");
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

        #region Método buscar código do funcionário.
        public DataTable Buscar_CodFunc(int CodFunc)
        {
            //Instância da classe DataTable.
            DataTable dt = new DataTable();

            try
            {
                using (var conexao = GetConnection())
                {
                    //Abre a conexão com a BD.
                    conexao.Open();

                    SqlCommand comando = new SqlCommand();
                    comando.Connection = conexao;
                    comando.CommandText = "Buscar_CodFunc";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@CodFunc", CodFunc);
                    SqlDataAdapter sda = new SqlDataAdapter(comando);
                    sda.Fill(dt);
                }
            }
            catch
            {

            }
            return dt;
        }
        #endregion

        #region Método editar funcionário.
        public bool Editar(int CodFunc, string Nome, DateTime DataNasc, string NIF, string Funcao, string Email,
        string Genero, string EstadoCivil, string NumTel, string Provincia, string Municipio, string Bairro,
        string Rua, DateTime DataRegist)
        {

            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "EditarFuncionario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodFunc", CodFunc);
                comando.Parameters.AddWithValue("@Nome", Nome);
                comando.Parameters.AddWithValue("@DataNasc", DataNasc);
                comando.Parameters.AddWithValue("@NIF", NIF);
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

        #region Método eliminar funcionario.
        public bool Eliminar(int CodFunc)
        {
            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "EliminarFuncionario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodFunc", CodFunc);

                if (comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        #endregion

        #region Método contar funcionario.
        public DataTable CountFuncionario()
        {
            //Instância da classe DataTable.
            DataTable dt = new DataTable();

            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "Count_Funcionario";
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
