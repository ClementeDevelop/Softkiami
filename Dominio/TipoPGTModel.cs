using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dados;

namespace Dominio
{
    public class TipoPGTModel
    {
        TipoPGT tipo = new TipoPGT();

        public DataTable ListarTipoPGTModel()
        {
            return tipo.ListarTipoPGT();
        }
    }
}
