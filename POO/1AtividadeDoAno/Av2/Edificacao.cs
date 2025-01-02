using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av2
{
    public abstract class Edificacao
    {
        public double Metragem {get;set;}
        public string Endereco {get;set;}
        public Engenheiro Engenheiro {get;set;}
        public List<UnidadeResidencial> Unidades {get;set;}

        public Edificacao(double metragem, string endereço, Engenheiro engenheiro)
        {
            this.Metragem = metragem;
            this.Endereco = endereço;
            this.Engenheiro = engenheiro;
        }

        public bool CadastrarUnidade(UnidadeResidencial novaUnid)
        {
            Unidades.Add(novaUnid);
            return  true;
        }

        public abstract string DescricaoDoImovel();
        
        
    }
}