using System;

namespace Program
{
    class Referenciacao1
    {
//                    2 3 4 5 6
        static int Pares(int[] vetor, int n)  
        {
            if ( n == 0)
            {
                return 0;

            }else if (vetor[n-1] % 2 == 0)
            {
                return vetor[n-1] + Pares(vetor, n-1);
            } else{
                return Pares(vetor, n-1);
            }   
        }
        static int Impares(int[] vetor, int n)  
        {
            if ( n == 0)
            {
                return 0;

            }else if (vetor[n-1] % 2 == 0)
            {
                return vetor[n-1] + Pares(vetor, n-1);
            } else{
                return Pares(vetor, n-1);
            }   
        }

        static int Fatorial(int n)
        {
            if (n == 0){
                return 1;
            } else{
                return n * Fatorial(n-1);
            }
        }

        static int Fatorial2(int n)
        {
            int b = 1;
            for (int i = 1; i <= n; i++)
            {
                b *= i;
            }
            return b;
        }


        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return Fibonacci(n-1) + Fibonacci(n-2);
            
        }

        static int Fibonacci2(int n)
        {
            int b = 1; // atual
            int c = 1;  // antiga 1
            int a = 0; // antiga 2
            
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;

        }


       static void Choro(string[] args)
       {
            int[] numero = {1,2,3,4,5,6,7,8,9,10};
            // System.Console.WriteLine("Digite um número: ");
            // int numero = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine($"O fatorial de {numero} é {Fatorial(numero)}");
            // System.Console.WriteLine($"O fatorial de {numero} é {Fatorial2(numero)}");

            System.Console.WriteLine(Pares(numero, numero.Length));

            // System.Console.WriteLine("Digite um número: ");
            // numero = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine($"O Fibonacci de {numero} é {Fibonacci(numero)}");
            // System.Console.WriteLine($"O Fibonacci de {numero} é {Fibonacci2(numero)}");
       }     
        
    }       
}