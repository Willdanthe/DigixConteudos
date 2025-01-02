using System;
namespace Desafio
{
    class MatrizTresde
    {
        static void CalcularMediaRegiões(double[,,] mat)
        {
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                double soma = 0;
                double dias = mat.GetLength(1)*mat.GetLength(2); 



                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    System.Console.WriteLine($"{i}   {j}");
                    // for(int k = 0; k < mat.GetLength(1); k++)
                    // {

                    // }
                }
            }
        }

        static void Main(string[] args)
        {
            double[,,] matriz3D = new double[5, 2, 3]
            {
                {
                    { 1.0, 2.0, 3.0 },
                    { 4.0, 5.0, 6.0 }
                },
                {
                    { 7.0, 8.0, 9.0 },
                    { 10.0, 11.0, 12.0 }
                },
                {
                    { 13.0, 14.0, 15.0 },
                    { 16.0, 17.0, 18.0 }
                },
                {
                    { 19.0, 20.0, 21.0 },
                    { 22.0, 23.0, 24.0 }
                },
                {
                    { 25.0, 26.0, 27.0 },
                    { 28.0, 29.0, 30.0 }
                }
            };
            CalcularMediaRegiões(matriz3D);

        }
    }
}