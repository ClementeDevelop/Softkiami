using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comum
{
    public class UtilizadorComum
    {
        //Definição dos atributos.
       public int CodUtilizador { get; set; }
       private string nome;
       private DateTime dataNasc;
       private string nIF;
       private string utiliza;
       private string senha;
       private string funcao;
       private string email;
       private string genero;
       private string estadoCivil;
       private string numTel;
       private string provincia;
       private string municipio;
       private string bairro;
       private string rua;
       private DateTime dataRegist;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public DateTime DataNasc
        {
            get
            {
                return dataNasc;
            }

            set
            {
                dataNasc = value;
            }
        }

        public string NIF
        {
            get
            {
                return nIF;
            }

            set
            {
                nIF = value;
            }
        }

        public string Utiliza
        {
            get
            {
                return utiliza;
            }

            set
            {
                utiliza = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public string Funcao
        {
            get
            {
                return funcao;
            }

            set
            {
                funcao = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public string EstadoCivil
        {
            get
            {
                return estadoCivil;
            }

            set
            {
                estadoCivil = value;
            }
        }

        public string NumTel
        {
            get
            {
                return numTel;
            }

            set
            {
                numTel = value;
            }
        }

        public string Provincia
        {
            get
            {
                return provincia;
            }

            set
            {
                provincia = value;
            }
        }

        public string Municipio
        {
            get
            {
                return municipio;
            }

            set
            {
                municipio = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Rua
        {
            get
            {
                return rua;
            }

            set
            {
                rua = value;
            }
        }

        public DateTime DataRegist
        {
            get
            {
                return dataRegist;
            }

            set
            {
                dataRegist = value;
            }
        }
    }
}
