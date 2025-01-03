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
            string teste = "";
<<<<<<< HEAD


=======
>>>>>>> e9a3d52522c6db98556194ca31c6699e74b0529b
            int cont = 1;
            foreach (var unidade in Unidades)
            {
                teste += @$"

<<<<<<< HEAD
                Unidade: {cont}
                Propriedade de {unidade.Pessoa.Nome}
                Possui {unidade.MetragemUnid:f1}m², {unidade.NumQuartos} Quartos e {unidade.NumBanheiros} banheiros";
=======
Unidade: {cont}
Propriedade de {unidade.Pessoa.Nome}
Possui {unidade.MetragemUnid:f1}m², {unidade.NumQuartos} Quartos e {unidade.NumBanheiros} banheiros";
>>>>>>> e9a3d52522c6db98556194ca31c6699e74b0529b
                cont++;
            }


<<<<<<< HEAD
                return @$"
                Predio {this.Nome}
                Situado {this.Endereco}
                Área Total: {this.Metragem:f1}m²
                Responsável: Eng.{Engenheiro.Nome}. CREA {Engenheiro.Crea}
                Número de Andares: {this.NumAndares}
                Número de Apartamento Por Andares: {this.ApPorAndar}

                "+teste; 


=======
            return @$"
Predio {this.Nome}
Situado {this.Endereco}
Área Total: {this.Metragem:f1}m²
Responsável: Eng.{Engenheiro.Nome}. CREA {Engenheiro.Crea}
Número de Andares: {this.NumAndares}
Número de Apartamento Por Andares: {this.ApPorAndar}
"+teste; 
>>>>>>> e9a3d52522c6db98556194ca31c6699e74b0529b
        }
    }
}