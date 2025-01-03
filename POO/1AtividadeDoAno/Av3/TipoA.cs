using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av3
{
    public class TipoA : Veiculo
    {
        public string Nome {get;set;}
        public int Cilindrada {get;set;}
        public Double ValorLocacao {get;set;}
        public int Dia {get;set;}


        public TipoA(string marca, string nome, int cilindrada, double valorLocacao, int dia) : base(marca)
        {
            this.Nome = nome;
            this.Cilindrada = cilindrada;
            this.ValorLocacao = valorLocacao;
            this.Dia = dia;
        }

        public override void CalcularLocDiaria()
        {
            double cilindrada = Cilindrada switch 
            {
                125 => 1.0,
                150 => 1.2,
                240 => 1.5,
                300 => 2.0,
                _ => -1
            };

            if (cilindrada == -1)
            {
                System.Console.WriteLine("Cilindrada não válida\n");
            } else
            {
                double total = (this.ValorLocacao*cilindrada)*this.Dia;
                System.Console.WriteLine($"Diária Moto: R${total}");
            }
        }
    }
}