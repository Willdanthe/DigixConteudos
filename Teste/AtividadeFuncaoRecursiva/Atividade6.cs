 using System;

 namespace Atividade
 {
    class Atividade6
    {

        static int Soma(int[] n, int a){
            if (a < 0){
                return 0;
            } else
            {
                return n[a] + Soma(n, a-1);
            }
        }

        static (int, double) SomaMediaVetor(int[] vetor, int index)
        {
            if (index < 0){
                return (0,0);
            }
            var (soma, media) = SomaMediaVetor(vetor,index-1);
            return (vetor[index]+soma, (vetor[index]+soma)/(index+1)); 
        }

        static (int, double) SomaMediaVetor2(int[] vetor, int index, int tamanho)
        {
            if (index < 0){
                return (0,0);
            }
            (int somaParcial, double _) = SomaMediaVetor2(vetor, index -1, tamanho);
            int somaTotal = somaParcial + vetor[index];

            double media = (double)somaTotal / tamanho;

            return (somaTotal,media);
        }


        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());
            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o elemento {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            (int soma, double media) = SomaMediaVetor2(vetor, tamanho - 1, tamanho);
            Console.WriteLine($"A soma dos elementos do vetor é: {soma}");
            Console.WriteLine($"A média dos elementos do vetor é: {media}");


        }
    }
 }