using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av2
{
    public class Pessoa
    {
        public string? Nome {get;set;}
        public string CPF {get;set;}


        public Pessoa(string Nome, string CPF)
        {
            this.Nome = Nome;
            this.CPF = CPF;
        }
    }
}