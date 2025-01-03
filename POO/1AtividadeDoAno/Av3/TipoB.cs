using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av3
{
    public class TipoB : Veiculo
    {
        public string Nome {get;set;}
        public int Potencia {get;set;}
        public Double ValorLocacao {get;set;}
        public int Dia {get;set;}


        public TipoB(string marca, string nome, int potencia, double valorLocacao, int dia) : base(marca)
        {
            this.Nome = nome;
            this.Potencia = potencia;
            this.ValorLocacao = valorLocacao;
            this.Dia = dia;
        }

        public override void CalcularLocDiaria()
        {
            double potencia = Potencia switch 
            {
                125 => 1.0,
                150 => 1.2,
                240 => 1.5,
                300 => 2.0,
                _ => -1
            };

            if (potencia == -1)
            {
                System.Console.WriteLine("Potencia não válida\n");
            } else
            {
                double total = (this.ValorLocacao*potencia)*this.Dia;
                System.Console.WriteLine($"Diária Carro: R${total}");
            }
        }
    }
}