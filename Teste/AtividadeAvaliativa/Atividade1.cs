<<<<<<< HEAD
using System;
using System.Globalization;
namespace Atividade1
{
    class Atividade1
    {
        static void Ex1(string[] args)
        {
            int[] vet = new int[10];
            int soma = 0;
            double media;

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"Insira o número da posição {i}º: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
                soma += vet[i];
            }

            media = soma/vet.Length;
            foreach (int item in vet)
            {
                Console.Write($"{item}  ");
            }
            System.Console.WriteLine("");
            System.Console.WriteLine($"A média do vetor é: {media.ToString("F1", CultureInfo.InvariantCulture)}");


        }
    }
=======
using System;
using System.Globalization;
namespace Atividade1
{
    class Atividade1
    {
        static void Ex1(string[] args)
        {
            int[] vet = new int[10];
            int soma = 0;
            double media;

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"Insira o número da posição {i}º: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
                soma += vet[i];
            }

            media = soma/vet.Length;
            foreach (int item in vet)
            {
                Console.Write($"{item}  ");
            }
            System.Console.WriteLine("");
            System.Console.WriteLine($"A média do vetor é: {media.ToString("F1", CultureInfo.InvariantCulture)}");


        }
    }
>>>>>>> 7c9a559e149af5d97a41afb24b17a8d425a038a0
}