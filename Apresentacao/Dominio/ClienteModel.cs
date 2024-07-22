using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dados;

namespace Dominio
{
    public class ClienteModel
    {
        Cliente cliente = new Cliente();
        public bool InserirModel(string Nome, string NIF, string Email, string NumTel, DateTime DataRegist)
        {
            return cliente.Inserir(Nome, NIF, Email, NumTel, DataRegist);
        }
        public DataTable ConsultarClienteModel(string Nome, string NIF, string Email, string NumTel)
        {
            return cliente.Consultar(Nome, NIF, Email, NumTel);
        }
        public DataTable BuscarCodClienteModel(int CodCliente)
        {
            return cliente.Buscar_CodCliente(CodCliente);
        }
        public bool EditarClienteModel(int CodCliente, string Nome, string NIF, string Email,  string NumTel, DateTime DataRegist)
        {
            return cliente.Editar(CodCliente, Nome, NIF, Email, NumTel, DataRegist);
        }
        public bool EliminarClienteModel(int CodCliente)
        {
            return cliente.Eliminar(CodCliente);
        }
        public DataTable CountClienteModel()
        {
            return cliente.CountCliente();
        }
    }
}
