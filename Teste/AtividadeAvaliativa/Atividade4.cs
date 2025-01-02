<<<<<<< HEAD
using System;

namespace Atividade4
{
    class Atividade4
    {
        static void Ex4(string[] args)
        {
            int[,] mat = new int[3,3] {
                {1,2,3},
                {4,5,6},
                {7,8,9}};

            int tamanho = mat.GetLength(0);
            int somaDiagonalPrincipal = 0;
            int somaDiagonalSecundaria = 0;

            for (int i = 0; i < mat.GetLength(0); i++){
                for (int j = 0; j < mat.GetLength(1); j++){
                    if (i == j){
                        somaDiagonalPrincipal += mat[i,j];
                    }
                }
            }

            for (int i = 0; i < tamanho; i++){
                somaDiagonalSecundaria += mat[i, tamanho - 1 - i];
            }





            System.Console.WriteLine(somaDiagonalPrincipal);
            System.Console.WriteLine(somaDiagonalSecundaria);
        }
    }
=======
using System;

namespace Atividade4
{
    class Atividade4
    {
        static void Ex4(string[] args)
        {
            int[,] mat = new int[3,3] {
                {1,2,3},
                {4,5,6},
                {7,8,9}};

            int tamanho = mat.GetLength(0);
            int somaDiagonalPrincipal = 0;
            int somaDiagonalSecundaria = 0;

            for (int i = 0; i < mat.GetLength(0); i++){
                for (int j = 0; j < mat.GetLength(1); j++){
                    if (i == j){
                        somaDiagonalPrincipal += mat[i,j];
                    }
                }
            }

            for (int i = 0; i < tamanho; i++){
                somaDiagonalSecundaria += mat[i, tamanho - 1 - i];
            }





            System.Console.WriteLine(somaDiagonalPrincipal);
            System.Console.WriteLine(somaDiagonalSecundaria);
        }
    }
>>>>>>> 7c9a559e149af5d97a41afb24b17a8d425a038a0
}