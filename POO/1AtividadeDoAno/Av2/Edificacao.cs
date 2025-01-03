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

            this.Unidades = new List<UnidadeResidencial>();
        }

        public bool CadastrarUnidade(UnidadeResidencial novaUnid)
        {
            Unidades.Add(novaUnid);
            // System.Console.WriteLine("Unidade Cadastrada"); //Teste pra ver a funcionalidade da função
            return true;

        }

        public abstract string DescricaoDoImovel();
        
        
    }
}