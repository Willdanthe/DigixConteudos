using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av2
{
    public class Engenheiro : Pessoa
    {
        public int Crea {get; set;}

        public Engenheiro(string nome, string CPF, int Crea) : base(nome,CPF)
        {
            this.Crea = Crea;
        }


    }
}