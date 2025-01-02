using System;
using System.Numerics;
namespace AulaMatriz{
    class AulaMatriz
    {
        static void Main(String[] args)
        {
            int[,] matriz1 = new int[2,2]; //1º número é linha e o 2º é coluna
            //Que é:
            // 0 1
            // 2 3

            // declaração de matriz atribuida
            int[,] matriz2 = new int[2,2] {{1,2},{3,4}}; //1º número é linha e o 2º é coluna
            int[,] matriz3 = new int[2,2] {
                {1,2}, //linha 0 tem 1 e 2, linha 1 tem 3 e 4
                {3,4} // oluna 0 tem 1 e 3, coluna 1 tem 2 e 4
                };
            // Acessando elementos da matriz
            Console.WriteLine(matriz2[0,0]);
            Console.WriteLine(matriz2[0,1]);

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; i < matriz2.GetLength(1); i++)
                {
                    Console.WriteLine(matriz1[i,j]);
                }
            }
            // Somando os elementos da Matriz
            int[,] matrizA = {{1,2,3},{4,5,6},{7,8,9}};
            int[,] matrizB = {{9,8,7},{6,5,4},{3,2,1}};

            int[,] matrizC = new int[3,3];

            for (int i =0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1);j++)
                {
                    matrizC[i,j] = matrizA[i,j] + matrizB[i,j];
                    
                 }
            }



        }
    }
}