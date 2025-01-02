using System;

namespace Aula11
{
    class SelectionSort1
    {
        static void SelectionSort(int[] vetor)
        {
            int menor, aux;
            
            
            // 5  7  8  44  6  9  1
            // menor = 0 
            //  se (vetor[j=1] 7) < (vetor[menor=0] 5)
            // 
            // 
            // 

            
            for (int i = 0; i < vetor.Length; i++){
                menor = i;
                
                for (int j = i+1; j < vetor.Length; j++)
                {
                    if (vetor[j] > vetor[menor])
                    {
                        menor = j;
                    }
                    aux = vetor[i];
                    vetor[i] = vetor[menor];
                    vetor[menor] = aux;
                }

                
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


        static void Main(string[] args)
        {
            int[] vet = {5,7,8,44,6,9,1};
            // int[] vetOrd;

            
            System.Console.Write("Vetor desordenado: ");
            Imprimir(vet);
            SelectionSort(vet);

            System.Console.Write("Vetor ordenado: ");
            Imprimir(vet);
        }

    }
}