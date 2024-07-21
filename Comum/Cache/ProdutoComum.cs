using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comum
{
    public class ProdutoComum
    {
        public string Designacao { get; set; }
        public  int Qtd { get; set; }
        public  float IVA { get; set; }
        public  double PUnitario { get; set; }
        public  float Desconto { get; set; }
        public int CodCateg { get; set; }

        //public string Designacao;
        //private int DesigCateg;
        //private int Qtd;
        //private float IVA;
        //private double PUnitario;
        //private float Desconto; 
    }
}
