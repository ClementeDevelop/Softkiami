using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dados;

namespace Dominio
{
    public class VendaModel
    {
        Venda v = new Venda();

        public DataTable ListarProdutosModel()
        {
            return v.ListarProdutos();
        }
    }
}
