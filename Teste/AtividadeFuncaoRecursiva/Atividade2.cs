 using System;

 namespace Atividade
 {
    class Atividade2
    {
        
        static int Mult(int n)
        {
            if (n == 1)
                return 1;
            else
                return n*Mult(n-1);
        }

        static void Ex2(string[] args)
        {
            System.Console.WriteLine("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine($"O calculo dos produtos de 1 a {numero} é {Mult(numero)} ");

    
        }
    }
 }