using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_POO
{
    public class Executor
    {
        static void Main(string[] args)
        {
            Cobra cobra = new Cobra(true, true);
            Javali javali = new Javali(true, true);
            
            cobra.Alimento("Sapo");
            cobra.SetVenenosa(false);
            Console.WriteLine("A cobra é Venenosa: "+ cobra.Venenosa);

            Console.WriteLine($"Velocidade do Javali: {javali.GetVelocidadeMaxima()}");
            javali.SetSelvagem(false);
            Console.WriteLine($"O Javali é Selvagem: {javali.Selvagem}");
            
            
        }
    }
}
