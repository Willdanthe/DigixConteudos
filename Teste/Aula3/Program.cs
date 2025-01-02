using System;

namespace Aula3
{
    class Condicional
    {
        static void teste(String[] args)
        {
            Console.WriteLine("Digite a sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());


            // Método Convencional de usar switch case
            // switch (idade)
            // {
            //     case int n when n < 0:
            //     Console.WriteLine("Entrada inválida");
            //     break;

            //     case int n when n >= 18 && n <= 50:
            //     Console.WriteLine("Adulto");
            //     break;

            //     case int n when n > 50 && n <= 100:
            //     Console.WriteLine("Idoso");
            //     break;

            //     case int n when n > 100:
            //     Console.WriteLine("Levanta a mão não, que Deus recolhe kkkk.");
            //     break;
            //     default:
            //     Console.WriteLine("Criança");
            //     break;

            // }

            // Método não convencional de usar switch case

            // string casos = idade switch
            // {
            //     < 0 => "Resposta inválida",
            //     >= 18 and <= 50 => "Adulto",
            //     > 50 and <= 100 => "Idoso",
            //     _ => "Levanta a mão não que Deus recolhe jkjkjkk."
            // };
            // Console.WriteLine(casos);
        

            // Switch Ternário
            string resultado = idade > 18 ? "Adulto" : idade > 50 ? "Idoso" : "Criança";

            Console.WriteLine(resultado);
        
        
        }
    }
}