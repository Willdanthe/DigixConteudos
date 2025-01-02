<<<<<<< HEAD
using System;

namespace Atividade5
{
    class Atividade5
    {
        static void Ex5(string[] args)
        {
            int[,] mat = new int[3,3] {
                {1,2,3},
                {4,5,6},
                {7,8,9}};

            int [,] transposta = new int[3,3];

            for (int i= 0; i< mat.GetLength(0); i++){
                for (int j= 0; j < mat.GetLength(1); j++){
                    transposta[j,i] = mat[i,j];
                }   
            }
            
            for (int i= 0; i< mat.GetLength(0); i++){
                for (int j = 0; j < mat.GetLength(1); j++){
                    Console.WriteLine($"{transposta[i,j]}");
                }   
            }


        }
    }
=======
using System;

namespace Atividade5
{
    class Atividade5
    {
        static void Ex5(string[] args)
        {
            int[,] mat = new int[3,3] {
                {1,2,3},
                {4,5,6},
                {7,8,9}};

            int [,] transposta = new int[3,3];

            for (int i= 0; i< mat.GetLength(0); i++){
                for (int j= 0; j < mat.GetLength(1); j++){
                    transposta[j,i] = mat[i,j];
                }   
            }
            
            for (int i= 0; i< mat.GetLength(0); i++){
                for (int j = 0; j < mat.GetLength(1); j++){
                    Console.WriteLine($"{transposta[i,j]}");
                }   
            }


        }
    }
>>>>>>> 7c9a559e149af5d97a41afb24b17a8d425a038a0
}