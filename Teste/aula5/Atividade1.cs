using System;

namespace Atividade1
{
    class Atividade1
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo que receba 10 números inteiro e positivos. Em
            seguida o algoritmos deverá mostrar o menor e o maior deles.
            5. Escreva um algoritmo que dado uma quantidade indeterminada de
            números inteiros e positivos, informe o menor e o maior. Utilize o
            número -1 como finalizador, ou seja, servirá como recurso de saída do
            laço de repetição*/
        
            int maior = 0; // poderia ser usado o int.MaxValue
            int menor = 0; // poderia ser usado o int.Minalue
            int num = 0;


            for (int i = 1; i<11; i++)
            {
                Console.WriteLine($"Digite o {i}º número:");
                num = Convert.ToInt32(Console.ReadLine());

                if (i == 1)
                {
                    maior = num;
                    menor = num;
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