using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av2
{
    public class UnidadeResidencial
    {
        public double MetragemUnid {get;set;}
        public int NumQuartos {get;set;}
        public int NumBanheiros {get;set;}
        public Pessoa Pessoa{get;set;}

        public UnidadeResidencial(double metragem, int quartos, int banheiros, Pessoa pessoa)
        {
            this.MetragemUnid = metragem;
            this.NumQuartos = quartos;
            this.NumBanheiros = banheiros;
            this.Pessoa = pessoa;
            
        }

    }
}