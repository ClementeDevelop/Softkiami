using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class Cliente : Conexao
    {
        #region Método inserir cliente.
        public bool Inserir(string Nome, string NIF, string Email, string NumTel, DateTime DataRegist)
        {
            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "InserirCliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nome", Nome);
                comando.Parameters.AddWithValue("@NIF", NIF);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@NumTel", NumTel);
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

        #region Método consultar cliente.
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
                    comando.CommandText = "ConsultarCliente";
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

        #region Método buscar código do cliente.
        public DataTable Buscar_CodCliente(int CodCliente)
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
                comando.CommandText = "Buscar_CodCliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodCliente", CodCliente);
                SqlDataAdapter sda = new SqlDataAdapter(comando);
                sda.Fill(dt);
            }

            return dt;
        }
        #endregion


        #region Método editar cliente.
        public bool Editar(int CodCliente, string Nome, string NIF, string Email,
        string NumTel, DateTime DataRegist)
        {

            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "EditarCliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodCliente", CodCliente);
                comando.Parameters.AddWithValue("@Nome", Nome);
                comando.Parameters.AddWithValue("@NIF", NIF);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@NumTel", NumTel);
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

        #region Método Eliminar
        public bool Eliminar(int CodCliente)
        {
            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "EliminarCliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodCliente", CodCliente);

                if (comando.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }
        #endregion

        #region Método contar cliente.
        public DataTable CountCliente()
        {
            //Instância da classe DataTable.
            DataTable dt = new DataTable();

            using (var conexao = GetConnection())
            {
                //Abre a conexão com a BD.
                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "Count_Cliente";
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
