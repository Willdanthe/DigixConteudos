using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Iterface
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Formiga
            Formiga formiga = new Formiga();
            formiga.Come();

            System.Console.WriteLine();
            
            // Cachorro
            Cachorro cachorro = new Cachorro("Athena");
            cachorro.SetNome("Reyel");
            Console.WriteLine($"Meu cachorro se chama {cachorro.GetNome()}!");
            cachorro.Come();            
            cachorro.Brinca();

            System.Console.WriteLine();

            // Peixe
            Peixe peixe = new Peixe("Pacu");
            Console.WriteLine($"Meu Peixe se chama {peixe.GetNome()}!");
            peixe.Come();
            peixe.Brinca();
        }
    }
}