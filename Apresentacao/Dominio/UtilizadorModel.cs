using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Comum;
using System.Data;

namespace Dominio
{
    public class UtilizadorModel
    {

        //Instancia da classe Utilizador.
        Utilizador utilizador = new Utilizador();
        public bool UtilizadorLogin(string Utiliza, string Senha)
    {
        return utilizador.Login(Utiliza, Senha);
    }
        public bool InserirModel(Comum.UtilizadorComum comum)
        {
            return utilizador.Inserir(comum);
        }

        public DataTable ConsultarModel(string Nome, string NIF, string Funcao)
        {
            return utilizador.Consultar(Nome, NIF, Funcao);
        }

        public DataTable BuscarCodUtilizadorModel(int CodUtilizador)
        {
            return utilizador.BuscarCodUtilizador(CodUtilizador);
        }
        public bool EditarModel(int CodUtilizador, string Nome, DateTime DataNasc, string NIF, string Utiliza, string Senha, string Funcao, string Email, string Genero, string EstadoCivil, int NumTel, string Provincia, string Municipio, string Bairro, string Rua, DateTime DataRegist)
        {
            return utilizador.Editar(CodUtilizador, Nome, DataNasc, NIF, Utiliza,  Senha, Funcao, Email, Genero, EstadoCivil, NumTel, Provincia, Municipio,  Bairro, Rua, DataRegist);
        }


        public bool EliminarModel(int CodUtilizador)
        {
            return utilizador.Eliminar(CodUtilizador);
        }
        public DataTable CountUtilizadorModel()
        {
            return utilizador.CountUtilizador();
        }
    }
}
