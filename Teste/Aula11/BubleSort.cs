using System;

namespace Aula11
{
    class BubbleSort1
    {
        static void BubbleSort(int[] vetor)
        {
            int aux;

            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length -1; j++)
                {
                    if (vetor[j] > vetor[j+1])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j+1];
                        vetor[j+1] = aux;
                    }
                }
            }

        }

        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                System.Console.WriteLine($"{vetor[i]}  ");
            }
            System.Console.WriteLine();
        }


        static void Buble(string[] args)
        {
            int[] vet = {5,7,8,44,6,9,1};
            // int[] vetOrd;

            
            System.Console.Write("Vetor desordenado: ");
            Imprimir(vet);
            BubbleSort(vet);

            System.Console.Write("Vetor ordenado: ");
            Imprimir(vet);
        }

    }
}