using System;

namespace Atividade5
{
    public class Atividade5
    {
        private void RotarMatriz(int[,] mat, int[,] mat2)
        {
            int n = mat.GetLength(0);
            for (int i= 0; i< mat.GetLength(0); i++){
                for (int j= 0; j < mat.GetLength(1); j++){
                    mat2[j, n - 1 - i] = mat[i, j];
                }   
            }
        }
        
        public void PrintarMatriz(int[,] mat)
        {
            for (int i= 0; i< mat.GetLength(0); i++){
                for (int j = 0; j < mat.GetLength(1); j++){
                    Console.Write($"{mat[i,j]}  ");
                }   
                System.Console.WriteLine("");
            }
        }

        static void Main(string[] args)
        {
            Atividade5 at = new Atividade5();
            int[,] mat = new int[3,3] {
                {1,2,3},
                {4,5,6},
                {7,8,9}};

            int [,] mat2 = new int[3,3];
            at.RotarMatriz(mat,mat2);
            at.PrintarMatriz(mat2);


        }
    }
}