using System;

namespace Atividade2
{
    class Atividade2
{
    static void BubbleSort(int[] vet)
    {
        int aux = 0;
        bool verificador = false;
        int interac = 0;

        for(int i = 0; i < vet.Length-1;i++)
        {
            for(int k = 0; k < vet.Length-1;k++)
            {
                if (vet[k] > vet[k+1])
                {
                    aux = vet[k+1];
                    vet[k+1] = vet[k];
                    vet[k] = aux;
                    verificador = true;
                    interac++;
                }
            }
            if (verificador == false)
            {
                System.Console.WriteLine("oi");
                break;
                
            }

        }
    }

    static void ValoresVetor(int[] vet)
    {
        
        for(int i = 0; i < vet.Length;i++)
        {
            System.Console.Write($"Digite o valor do vetor {i+1}: ");
            vet[i] = Convert.ToInt32(Console.ReadLine());
        }
    }



    
        static void Ex2(string[] args)
        {
            int[] vet = new int[7];

            // Função para inserir valores no vetor
            ValoresVetor(vet);

            // Função para ordenar em BubbleSort
            BubbleSort(vet);


            System.Console.WriteLine(string.Join(" ", vet));
        }
    
}
}