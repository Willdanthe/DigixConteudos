using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av2
{
    public class Predio : Edificacao
    {
        public string Nome {get;set;}
        public int NumAndares {get;set;}
        public int ApPorAndar {get;set;}

        public Predio(double metragem, string endereço, Engenheiro engenheiro, string nome, int numandares, int apPorAndar) : base(metragem, endereço, engenheiro)
        {
            this.Nome = nome;
            this.NumAndares = numandares;
            this.ApPorAndar = apPorAndar;
        }

        public override string DescricaoDoImovel()
        {
            return @$"
Nome do Predio: {this.Nome} 
Endereço: {this.Endereco}
Área Total: {this.Metragem:f1}m²
Responsável: Eng.{Engenheiro.Nome}. CREA {Engenheiro.Crea}
Número de Andares: {this.NumAndares}
Número de Apartamento Por Andares: {this.ApPorAndar}



";
        }
    }
}