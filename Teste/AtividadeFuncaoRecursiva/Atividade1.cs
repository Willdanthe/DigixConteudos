 using System;

 namespace Atividade
 {
    class Atividade1
    {

        static int Soma(int n){
            if (n ==1){
                return 1;
            } else
            {
                return n + Soma(n-1);
            }
        }


        static void Ex1(string[] args)
        {
            System.Console.WriteLine("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int soma = Soma(numero);

            System.Console.WriteLine($"A soma de 1 até {numero} é {soma}");        
    
        }
    }
 }