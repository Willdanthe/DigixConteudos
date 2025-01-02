using System;

namespace Tipagem
{
    internal class Program
    {
        static void Main(String[] args)
        {
            int a = 10;

            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            //tipagem dinâmica
            var v = "a";
            Console.WriteLine(v.GetType());

        }
    }
}