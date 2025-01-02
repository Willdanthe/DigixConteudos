using System;

namespace Aula12
{
    class QuickSort
    {

        static void Ordenar(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = Particionar(vetor, inicio, fim);
                Ordenar(vetor, inicio, p-1);
                Ordenar(vetor, p+1, fim);
            }
        }

        static int Particionar(int[] vetor, int inicio, int fim)
        {
            int pivo = vetor[fim];
            int i = inicio-1;
            for (int j = inicio; j < fim;j++ )
            {
                if (vetor[j] < pivo){
                    i++;
                    int aux = vetor[i];
                    vetor[i] = vetor[j];
                    vetor[j] = aux;
                }
            }
            int aux2 = vetor[i+1];
            vetor[i+1] = vetor[fim];
            vetor[fim] = aux2;
            return i+1;
        }

        static void Quick(string[] args)
        {
            int[] vet = {25 , 57 , 48 , 37 , 12 , 92 , 86 , 33};

            Ordenar(vet, 0, vet.Length-1);

            Console.WriteLine(string.Join(" ", vet));
        }
    }
}