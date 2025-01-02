using System;

namespace Name
{
    public class Atividade2
    {
        public delegate void Operacao(int[,] mat);

        public static void LinhasMatrizSoma(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                int somaLinha = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    somaLinha += mat[i,j];
                }
                System.Console.WriteLine($"A soma da {i+1}º linha é : {somaLinha}");
            }
        }

        public static void PrintMatriz(int[,] mat) {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i,j]}  ");
                }
                System.Console.WriteLine("");
            }

        }

        static void Ex2(string[] args)
        {
            Operacao op,op2;
            op = LinhasMatrizSoma;
            op2 = PrintMatriz;
            int[,] mat = new int[3,3] {{1,2,3}, {4,5,6},{7,8,9}};

            op2(mat);
            System.Console.WriteLine("");
            op(mat);



        }


    }
}