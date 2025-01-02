using System;

namespace Aula8
{
    class Vetores
    {
        // Função de soma
        static int Soma(int a, int b){
            return a+b;
        }


        // Função para imprimir no console
        static void print(int a, int b, int c)
        {
            System.Console.WriteLine($"a soma de {a} + {b} é {c}");
        }


        static double multiplicacao(double a, double b, double c)
        {
            return a*b*c;
        }


        static double multiplicacaodois(double a = 10, double b = 10, double c = 10)
        {
            return a*b*c;
        }

        static void imprimirVetor(int[] vet)
        {
            for (int i = 0 ; i < vet.Length; i++){
                System.Console.Write($"{vet[i]}  ");
            }
        }




        // Função para somar os vetores
        static int somaVetor(int[] vet)
        {
            int soma = 0;

            for (int i = 0 ; i < vet.Length; i++){
                soma += vet[i];
            }
            return soma;
        }

        // Função com parâmetro de matriz
        static int somaMatriz(int[,] mat)
        {
            int soma = 0;

            for(int i = 0 ; i < mat.GetLength(0); i++)
            {
                for(int j = 0 ; j < mat.GetLength(1); j++)
                {
                    soma += mat[i,j];
                }
            }

            return soma;
        }

        static void printMatriz(int[,] mat)
        {
            for(int i = 0 ; i < mat.GetLength(0); i++)
            {
                for(int j = 0 ; j < mat.GetLength(1); j++)
                {
                    System.Console.Write($"{mat[i,j]}  ");
                }
                System.Console.WriteLine("");
            }
        }




        // Procedimento (não tem retorno)
        static void Teste(string[] arg)
        {
            // int n1 = Convert.ToInt32(Console.ReadLine());
            // int n2 = Convert.ToInt32(Console.ReadLine());
            // int soma = Soma(n1,n2);

            // Jeito errado de chamar uma função vazia
            // System.Console.WriteLine(print(n1,n2,soma));

            // Jeito certo de chamar uma função vazia
            // print(n1,n2,soma);

            
            // double x = 10;
            // double y = 10;
            // double z = 10;
            // double resultado = multiplicacao(x,y,z);

            // // System.Console.WriteLine($"a multiplicação dos produtos {x}, {y} e {z} é igual a {resultado}");



            // Quando a Variável já tem parâmetros declarado pode-se usar sem colocar mais parâmetros
            // System.Console.WriteLine(multiplicacaodois());
            
            
            // Ou também pode adicionar mais, que vai sobrescrever o valor original
            // System.Console.WriteLine(multiplicacaodois(2,2,2));

            // int[] vet = new int[5] {2,4,6,8,10};
            // int somaVet = somaVetor(vet);

            // imprimirVetor(vet);
            // System.Console.WriteLine("");
            // Console.WriteLine($"A soma do vetor é {somaVet}");

            int[,] mat = new int[3,3] {{1,2,3}, {4,5,6}, {7,8,9}};

            int soma = somaMatriz(mat);

            printMatriz(mat);

            System.Console.WriteLine($"A soma da matriz intera é {soma}");


        }
    }
}