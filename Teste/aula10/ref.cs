using System;

namespace Program
{
    class Referenciacao
    {
        static int Square(int a)
        {
            return a*a;
        }

        static int QuadradoPerma(ref int x){
            return x = x*x;
        }




        static void Aaa(string[] args)
        {
            int a = 8;

            System.Console.WriteLine(Square(a)); // Retorna 64
            System.Console.WriteLine(a); // Retorna 8, porque não foi alterado

            QuadradoPerma(ref a); // Modifica a variável "a" por referência
            System.Console.WriteLine(a); // Retorna 8, porque não foi alterado
            
        }
    }       
}