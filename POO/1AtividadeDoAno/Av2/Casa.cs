using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av2
{
    public class Casa : Edificacao
    {
        public string Nome {get;set;}
        public bool Condominio {get;set;}

        public Casa(double metragem, string endereço, Engenheiro engenheiro, bool condominio, string nome) : base(metragem, endereço, engenheiro)
        {
            this.Condominio = condominio;
            this.Nome = nome;
        }

        public override string DescricaoDoImovel()
        {
            return @$"
Predio {this.Nome}
Situado {this.Endereco}
Área Total: {this.Metragem:f1}m²
Responsável: Eng.{Engenheiro.Nome}. CREA {Engenheiro.Crea}

";
        }
    }
}