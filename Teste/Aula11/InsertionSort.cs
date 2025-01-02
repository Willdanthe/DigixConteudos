using System;

namespace Aula11
{
    class InsertionSort1
    {
        //33
        static void InsertionSort(int[] vetor)
        {
            int aux, j;

            for (int i = 1; i < vetor.Length; i++)
            
            {
                aux = vetor[i];
                j = i - 1;

                while (j >= 0 && vetor[j] > aux)
                {
                    vetor[j+1] = vetor[j];
                    j--;
                }
                vetor[j+1] = aux;

            }
            
        }

        static void Imprimir(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                System.Console.Write($"{vetor[i]}  ");
            }
            System.Console.WriteLine();
        }


        static void Tete(string[] args)
        {
            int[] vet = {5,7,8,44,6,9,1};
            // int[] vetOrd;

            
            System.Console.Write("Vetor desordenado: ");
            Imprimir(vet);
            InsertionSort(vet);

            System.Console.Write("Vetor ordenado: ");
            Imprimir(vet);
        }

    }
}