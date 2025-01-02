<<<<<<< HEAD
using System;

namespace Mariz
{
    class AulaMatriz
    {
        static void Matriz2d(string[] args)
        {
            int[,] matriz = new int[3,3] {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            int[,] transposta = new int[3,3];
            
            // For feito para inverter as linhas, fazendo virarem colunas em uma matriz vazia
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    transposta[j,i] = matriz[i,j];
                }
            }


            // Imprimindo no console as matrizes
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i,j]} ");
                }
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{transposta[i,j]} ");
                }
                System.Console.WriteLine("");
            }


        }
    }
=======
using System;

namespace Mariz
{
    class AulaMatriz
    {
        static void Matriz2d(string[] args)
        {
            int[,] matriz = new int[3,3] {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            int[,] transposta = new int[3,3];
            
            // For feito para inverter as linhas, fazendo virarem colunas em uma matriz vazia
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    transposta[j,i] = matriz[i,j];
                }
            }


            // Imprimindo no console as matrizes
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i,j]} ");
                }
                System.Console.WriteLine("");
            }
            System.Console.WriteLine("");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{transposta[i,j]} ");
                }
                System.Console.WriteLine("");
            }


        }
    }
>>>>>>> 7c9a559e149af5d97a41afb24b17a8d425a038a0
}