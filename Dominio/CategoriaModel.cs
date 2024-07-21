using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dados;

namespace Dominio
{
    public class CategoriaModel
    {
        Categoria c = new Categoria();
        
        public DataTable ConsultarCategoriaModel()
        {
            return c.ConsultarCategoria();
        }
    }
}
