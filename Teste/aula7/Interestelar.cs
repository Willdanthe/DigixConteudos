<<<<<<< HEAD
using System;
using System.Dynamic;

namespace AulaInterestelar
{
    class MatrizesTriDimencional
    {
        static void Main(string[] args)
        {
            // Matriz Tridimencional
            // Nela temos 3 índices
            // Linha, Coluna e profundidade

            int[,,] matriz3D = new int[2,2,2]{
                {
                    {1,2},
                    {3,4}
                },

                {
                    {5,6},
                    {7,8}
                }
            };

            int somaMatriz = 0;



            for (int i = 0; i < matriz3D.GetLength(0); i++)
            {
                for (int j = 0; j < matriz3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matriz3D.GetLength(2); k++)
                    {
                        System.Console.WriteLine($"[{i},{j},{k}] = {matriz3D[i,j,k]}");
                    }
                }
            }
            
            // Acessando um elemento da matriz3D
            System.Console.WriteLine(matriz3D[0,0,0]);
            System.Console.WriteLine(matriz3D[1,1,1]);

            // Alterando um elemento da matriz3D

            matriz3D[1,1,1] = 100;
            System.Console.WriteLine(matriz3D[1,1,1]);
            
            // Somar todos os elementos 

            for (int i = 0; i < matriz3D.GetLength(0); i++)
            {
                for(int j = 0; j < matriz3D.GetLength(1); j++)
                {
                    for(int k = 0; k < matriz3D.GetLength(2); k++)
                    {
                        somaMatriz += matriz3D[i,j,k];
                    }
                }
            }
            
            System.Console.WriteLine($"a soma da matriz inteira é {somaMatriz}");

            // Acessar todos os elementos da Matriz3D com Foreach

            foreach(int item in matriz3D)
            {
                System.Console.WriteLine(somaMatriz += item);
            }



        }
    }
=======
using System;
using System.Dynamic;

namespace AulaInterestelar
{
    class MatrizesTriDimencional
    {
        static void Main(string[] args)
        {
            // Matriz Tridimencional
            // Nela temos 3 índices
            // Linha, Coluna e profundidade

            int[,,] matriz3D = new int[2,2,2]{
                {
                    {1,2},
                    {3,4}
                },

                {
                    {5,6},
                    {7,8}
                }
            };

            int somaMatriz = 0;



            for (int i = 0; i < matriz3D.GetLength(0); i++)
            {
                for (int j = 0; j < matriz3D.GetLength(1); j++)
                {
                    for (int k = 0; k < matriz3D.GetLength(2); k++)
                    {
                        System.Console.WriteLine($"[{i},{j},{k}] = {matriz3D[i,j,k]}");
                    }
                }
            }
            
            // Acessando um elemento da matriz3D
            System.Console.WriteLine(matriz3D[0,0,0]);
            System.Console.WriteLine(matriz3D[1,1,1]);

            // Alterando um elemento da matriz3D

            matriz3D[1,1,1] = 100;
            System.Console.WriteLine(matriz3D[1,1,1]);
            
            // Somar todos os elementos 

            for (int i = 0; i < matriz3D.GetLength(0); i++)
            {
                for(int j = 0; j < matriz3D.GetLength(1); j++)
                {
                    for(int k = 0; k < matriz3D.GetLength(2); k++)
                    {
                        somaMatriz += matriz3D[i,j,k];
                    }
                }
            }
            
            System.Console.WriteLine($"a soma da matriz inteira é {somaMatriz}");

            // Acessar todos os elementos da Matriz3D com Foreach

            foreach(int item in matriz3D)
            {
                System.Console.WriteLine(somaMatriz += item);
            }



        }
    }
>>>>>>> 7c9a559e149af5d97a41afb24b17a8d425a038a0
}