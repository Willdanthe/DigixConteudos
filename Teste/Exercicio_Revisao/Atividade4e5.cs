using System;
namespace Atividade4e5
{
    class Atividade4e5
    {
        static void Main(string[] args)
        {
            int maior = int.MinValue; // poderia ser usado o int.MaxValue
            int menor = int.MaxValue; // poderia ser usado o int.Minalue
            int num = 0;


            while (num != -1)
            {
                Console.WriteLine($"Digite um número:");
                num = Convert.ToInt32(Console.ReadLine());
                
                if (num == -1){
                    break;
                }

                if (num > maior){
                    maior = num;
                }
                if ( num < menor){
                    menor = num;
                }
            }
            Console.WriteLine($"O maior número é {maior} e o menor é {menor}");
        }
    }
}