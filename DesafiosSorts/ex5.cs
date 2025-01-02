using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_12
{
    public class Exe5
    {
        
        static void Merge(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = (inicio + fim)/2;
                Merge(vetor, inicio, meio);
                Merge(vetor, meio +1, fim);
                Intercalar(vetor, inicio, meio, fim);
            }
        }


        static void Intercalar(int[] vetor, int inicio , int meio, int fim)
        {
            int[] aux = new int[vetor.Length];

            for(int j = inicio; j <= fim; j++)
            {
                aux[j] = vetor[j];
            }

            int i1 = inicio;
            int i2 = meio +1;
            int i3 = inicio;

            while (i1 <= meio && i2 <= fim)
            {
                if (aux[i1] < aux[i2])
                {
                    vetor[i3] = aux[i1];
                    i1++;
                }
                else{
                    vetor[i3] = aux[i2];
                    i2++;
                }
                i3++;
            }
            while (i1 <= meio)
            {
                vetor[i3] = aux[i1];
                i1++;
                i3++;
            }

        }

        static void BuubleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }

        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int chave = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > chave)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = chave;
            }
        }
        static void Main()
        {
            int [] numeros = new int[1000];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = (i % 100) + 1;
            }

            // Criar copias para cada algoritmo
            int[] bubleArray = (int[])numeros.Clone();
            int[] selectionArray = (int[])numeros.Clone();
            int[] insertionArray = (int[])numeros.Clone();
            int[] MergeArray = (int[])numeros.Clone();

            // Mede o tempo de execução do BubbleSort
            var inicio = DateTime.Now.Ticks; // Pega o tempo atual em ticks
            BuubleSort(bubleArray);
            var tempoBubble = DateTime.Now.Ticks - inicio; // Pega o tempo atual em ticks

            // Mede o tempo de execução do SelectionSort
            inicio = DateTime.Now.Ticks; // Pega o tempo atual em ticks
            SelectionSort(selectionArray);
            var tempoSelection = DateTime.Now.Ticks - inicio; // Pega o tempo atual em ticks

            // // Mede o tempo de execução do InsertionSort
            // inicio = DateTime.Now.Ticks; // Pega o tempo atual em ticks
            // InsertionSort(insertionArray);
            // var tempoInsertion = DateTime.Now.Ticks - inicio; // Pega o tempo atual em ticks

            inicio = DateTime.Now.Ticks; // Pega o tempo atual em ticks
            Merge(MergeArray);
            var tempoMerge = DateTime.Now.Ticks - inicio; // Pega o tempo atual em ticks




            string melhorAlgoritmo;
            int[] melhorArray;

            if (tempoBubble < tempoSelection && tempoBubble < tempoInsertion)
            {
                melhorAlgoritmo = "BubbleSort";
                melhorArray = bubleArray;
            }
            else if (tempoSelection < tempoBubble && tempoSelection < tempoInsertion)
            {
                melhorAlgoritmo = "SelectionSort";
                melhorArray = selectionArray;
            }
            else
            {
                melhorAlgoritmo = "InsertionSort";
                melhorArray = insertionArray;
            }

            // Exibe os tempos de execução
            Console.WriteLine($"Tempo de execução do BubbleSort: {tempoBubble}");
            Console.WriteLine($"Tempo de execução do SelectionSort: {tempoSelection}");
            // Console.WriteLine($"Tempo de execução do InsertionSort: {tempoInsertion}");
            // Console.WriteLine($"Tempo de execução do InsertionSort: {tempoMerge}");
            Console.WriteLine($"Tempo de execução do InsertionSort: {tempoInsertion}");

            Console.WriteLine($"O melhor algoritmo foi o {melhorAlgoritmo}");
        }
    }
}