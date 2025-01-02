using System;
using System.Reflection.Metadata;

namespace Exemplo
{
    internal class Program
    {
        static void TestePrimitivo()
        {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0053';
            byte n1 = 126;
            int n2 =  1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Maria Brown";
            object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(Convert.ToInt32(n5));
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);






        }
    }
}