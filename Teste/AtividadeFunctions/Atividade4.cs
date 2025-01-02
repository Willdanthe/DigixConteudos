using System;   

namespace Name
{
    public class Atividade4
    {
        public void SomaDiagonais(int[,] mat)
        {
            int tamanho = mat.GetLength(0);
            int soma = 0;


            for(int i = 0; i < tamanho; i++)
            {
                for(int j = 0; j < tamanho; j++)
                {
                    if (i == j){
                        soma += mat[i,j];
                        break;
                    }
                }
            }

            System.Console.WriteLine($"A soma da diagonal principal é {soma}");
            soma = 0;
            for (int i = 0; i < tamanho; i++){
                
                soma += mat[i, tamanho - 1 - i];
            }
            System.Console.WriteLine($"A soma da diagonal secundária é {soma}");


        }

        static void Ex4(string[] args)
        {
            Atividade4 a = new Atividade4();
            int[,] mat = new int[3,3] {
                {1,2,3},
                {4,5,6},
                {7,8,9}};


            a.SomaDiagonais(mat);
        }


    }
}