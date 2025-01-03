using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av3
{
    public class TipoC : Veiculo
    {
        public string Nome {get;set;}
        public int Eixo {get;set;}
        public Double ValorLocacao {get;set;}
        public int Dia {get;set;}


        public TipoC(string marca, string nome, int eixo, double valorLocacao, int dia) : base(marca)
        {
            this.Nome = nome;
            this.Eixo = eixo;
            this.ValorLocacao = valorLocacao;
            this.Dia = dia;
        }

        public override void CalcularLocDiaria()
        {
            double eixo = Eixo switch 
            {
                125 => 1.0,
                150 => 1.2,
                240 => 1.5,
                300 => 2.0,
                _ => -1
            };

            if (eixo == -1)
            {
                System.Console.WriteLine("Eixo não válida\n");
            } else
            {
                double total = (this.ValorLocacao*eixo)*this.Dia;
                System.Console.WriteLine($"Diária Caminhão: R${total}");
            }
        }
    }
}