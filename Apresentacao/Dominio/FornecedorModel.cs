using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Dados;

namespace Dominio
{
    public class FornecedorModel
    {
        Fornecedor fornec = new Fornecedor();
        public bool InserirFornecedorModel(string Nome, DateTime DataNasc, string NIF, string Email, string Genero, string EstadoCivil, string NumTel, string Provincia, string Municipio, string Bairro, string Rua, DateTime DataRegist)
        {
          return  fornec.Inserir(Nome, DataNasc, NIF, Email, Genero, EstadoCivil, NumTel, Provincia, Municipio, Bairro, Rua, DataRegist);
        }
        public DataTable ConsultarFornecedorModel(string Nome, string NIF, string Email, string NumTel)
        {
            return fornec.Consultar(Nome, NIF, Email, NumTel);
        }
        public DataTable BuscarCodFornecModel(int CodFornec)
        {
            return fornec.BuscarCodFornecedor(CodFornec);
        }
        public bool EditarFornecedorModel(int CodFornec, string Nome, DateTime DataNasc, string NIF, string Email, string Genero, string EstadoCivil, string NumTel, string Provincia, string Municipio, string Bairro, string Rua, DateTime DataRegist)
        {
            return fornec.Editar(CodFornec, Nome, DataNasc, NIF, Email, Genero, EstadoCivil, NumTel, Provincia, Municipio, Bairro, Rua, DataRegist);
        }
        public bool EliminarFornecedorModel(int CodFornec)
        {
            return fornec.Eliminar(CodFornec);
        }
        public DataTable CountFornecedorModel()
        {
            return fornec.CountFornecedor();
        }
    }
}
