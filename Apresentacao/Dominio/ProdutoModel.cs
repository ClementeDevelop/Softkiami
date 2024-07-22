using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dados;
using Comum;

namespace Dominio
{
    public class ProdutoModel
    {
        //Instância da classe Produto.
        Produto prod = new Produto();

        public bool InserirModel(string Designacao, float IVA, float PUnitario, float Desconto, int CodCateg)
        {
            return prod.Inserir(Designacao, IVA, PUnitario, Desconto, CodCateg);
        }
        public DataTable ListarProdutoModel()
        {
            return prod.ListarProdutos();
        }
        public DataTable ProcurarProdutoModel(string Designacao)
        {
            return prod.ProcurarProdutos(Designacao);
        }
        public DataTable Buscar_CodProdutModel(int CodProdut)
        {
            return prod.Buscar_CodProdut(CodProdut);
        }
        public bool EditarModel(int CodProdut, string Designacao, float IVA, float PUnitario, float Desconto, int CodCateg)
        {
            return prod.Editar(CodProdut, Designacao, IVA, PUnitario, Desconto, CodCateg);
        }
        public bool EliminarModel(int CodProdut)
        {
            return prod.Eliminar(CodProdut);
        }
        public DataTable CountProdutoModel()
        {
            return prod.CountProduto();
        }
    }
}
