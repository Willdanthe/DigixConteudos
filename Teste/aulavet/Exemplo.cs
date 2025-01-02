using System;
namespace Exemplo
{
    class Exemplo
    {
        static void Teste(String[] args)
        {
            int[] vetor = new int[10];
            Random r = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                vetor[i] = r.Next(1,100);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{vetor[i]}");
            }
            
            Console.WriteLine($"\n");

            for (int i = 9; i >= 0; i--)
            {
                Console.Write($"{vetor[i]}");
            }

            

        }
    }
}