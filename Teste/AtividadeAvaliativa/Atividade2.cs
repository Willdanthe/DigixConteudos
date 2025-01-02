<<<<<<< HEAD
using System;

namespace Atividade2
{
    class Atividade2
    {
        static void Ex2(string[] args)
        {
            int[,] mat = new int[4,4] {{1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16}};
            int[]  array = new int[4];
            int soma = 0;

            // loop para somar cada linha do vetor e colocar a soma no array
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                soma = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    soma += mat[i,j];
                }
                array[i] = soma;
            }

            // Printando a Matriz no Console.
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    System.Console.Write($"{mat[i,j]}  ");
                }
                System.Console.WriteLine("");
            }

            // Printando a soma de cada linha no console
            System.Console.WriteLine(string.Join(" ", array));
        }
    }
=======
using System;

namespace Atividade2
{
    class Atividade2
    {
        static void Ex2(string[] args)
        {
            int[,] mat = new int[4,4] {{1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16}};
            int[]  array = new int[4];
            int soma = 0;

            // loop para somar cada linha do vetor e colocar a soma no array
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                soma = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    soma += mat[i,j];
                }
                array[i] = soma;
            }

            // Printando a Matriz no Console.
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    System.Console.Write($"{mat[i,j]}  ");
                }
                System.Console.WriteLine("");
            }

            // Printando a soma de cada linha no console
            System.Console.WriteLine(string.Join(" ", array));
        }
    }
>>>>>>> 7c9a559e149af5d97a41afb24b17a8d425a038a0
}