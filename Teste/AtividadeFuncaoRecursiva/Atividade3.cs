 using System;

 namespace Atividade
 {
    class Atividade3
    {
        
        // static double Aooopotencia(int n, int p)
        // {
        //     if (n == 1)
        //         return 1;
        //     else
        //         return Math.Pow(n,p)* Aooopotencia(n-1, p-1);
        // }

        static int Aooopotencia(int n, int p)
        {
            if (p == 0)
                return 1;
            else
                return n * Aooopotencia(n,p-1);
        }



        static void Ex3(string[] args)
        {
            System.Console.WriteLine("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());


            System.Console.WriteLine("Digite seu expoente: ");
            int expoente = Convert.ToInt32(Console.ReadLine());


            // double result = Aooopotencia(numero, expoente);
            int result = Aooopotencia(numero, expoente);


            System.Console.WriteLine($"{numero} ^^ {expoente} = {result}");
            

    }
 }
 }