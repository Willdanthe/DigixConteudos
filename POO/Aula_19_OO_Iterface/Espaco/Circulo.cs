using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Iterface
{
    public class Circulo : IForma
    {
        public double Raio {get;set;}

        public Circulo(double realizado){
            this.Raio = Raio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio,2);
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * this.Raio;
        }


        public void ExibirInformacoes()
        {
            System.Console.WriteLine("Circulo");
            System.Console.WriteLine("Raio: " + this.Raio);
            System.Console.WriteLine("Área: "+ CalcularArea());
            System.Console.WriteLine("Perimetro: " + CalcularPerimetro());


        }

    }
}