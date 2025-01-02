using System;


namespace Atividade6
{
    class Atividade6
    {
        static void Main(String[] args)
        {
            // Declaração de variáveis
            Random r = new Random();
            int[,] matA = new int[4,4];
            int[,] matB = new int[4,4];
            int[,] matC = new int[4,4];
        
            // Entrada de valores aleatórios nas matrizes A e B
            for (int i = 0; i<4; i++)
            {
                for(int j = 0; j<4; j++){
                    matA[i,j] = r.Next(10);
                    matB[i,j] = r.Next(10);

                }
            }

            // for para somar as matrizes e guardar na Matriz C
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    matC[i,j] = matA[i,j]*matB[i,j];
                }
            }


            Console.WriteLine("Matriz A");
            Saida(matA);
            Console.WriteLine("Matriz B");
            Saida(matB);
            Console.WriteLine("\nProduto das Matrizes:");
            Saida(matC);
            


            // Função para mostrar a Matriz
            static void Saida(int[,] a){
                for (int i = 0; i<4; i++)
            {
                for(int j = 0; j<4; j++){
                    Console.Write($"{a[i,j]}    ");

                }
                Console.WriteLine("");
            }
            }
        }
    }
}