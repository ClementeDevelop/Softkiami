using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dados;

namespace Dominio
{
    public class FuncionarioModel
    {
        Funcionario funcionario = new Funcionario();
        public bool InserirFuncionarioModel(string Nome, DateTime DataNasc, string NIF, string Funcao, string Email, string Genero, string EstadoCivil, string NumTel, string Provincia, string Municipio, string Bairro, string Rua, DateTime DataRegist)
        {
            return funcionario.Inserir( Nome, DataNasc, NIF, Funcao, Email, Genero, EstadoCivil, NumTel, Provincia, Municipio, Bairro, Rua, DataRegist);
        }
        public DataTable ConsultarFuncionarioModel(string Nome, string Email, string NIF, string NumTel)
        {
           return  funcionario.Consultar(Nome, Email, NIF, NumTel);
        }
        public DataTable BuscarCodFuncModel(int CodFunc)
        {
            return funcionario.BuscarCodFunc(CodFunc);
        }
        public bool EditarFuncionarioModel(int CodFunc, string Nome, DateTime DataNasc, string NIF, string Funcao, string Email, string Genero, string EstadoCivil, string NumTel, string Provincia, string Municipio, string Bairro, string Rua, DateTime DataRegist)
        {
            return funcionario.Editar(CodFunc, Nome, DataNasc, NIF, Funcao, Email, Genero, EstadoCivil, NumTel, Provincia, Municipio, Bairro, Rua, DataRegist);
        }
        public bool EliminarFuncionarioModel(int CodFunc)
        {
            return funcionario.Eliminar(CodFunc);
        }
        public DataTable CountFuncionarioModel()
        {
            return funcionario.CountFuncionario();
        }
    }
}
