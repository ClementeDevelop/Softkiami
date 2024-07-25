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

        public bool Inserir_ProdutoModel(string Designacao, float IVA, float PUnitario, float Desconto, int CodCateg)
        {
            return prod.InserirProduto(Designacao, IVA, PUnitario, Desconto, CodCateg);
        }
        public DataTable Listar_ProdutoModel()
        {
            return prod.ListarProdutos();
        }
        public DataTable Procurar_ProdutoModel(string Designacao)
        {
            return prod.ProcurarProdutos(Designacao);
        }
        public DataTable Buscar_CodProdutModel(int CodProdut)
        {
            return prod.Buscar_CodProdut(CodProdut);
        }
        public bool Editar_ProdutoModel(int CodProdut, string Designacao, float IVA, float PUnitario, float Desconto, int CodCateg)
        {
            return prod.EditarProduto(CodProdut, Designacao, IVA, PUnitario, Desconto, CodCateg);
        }
        public bool Eliminar_ProdutoModel(int CodProdut)
        {
            return prod.EliminarProduto(CodProdut);
        }
        public DataTable Count_ProdutoModel()
        {
            return prod.CountProduto();
        }
    }
}
