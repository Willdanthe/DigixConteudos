 using System;

 namespace Atividade
 {
    class Atividade4
    {
        public static int Mdc(int a, int b)
    {
        if (b == 0)
            return a;

        return Mdc(b, a % b);
    }

        static void Ex4(string[] args)
        {

            System.Console.WriteLine();
            int num1 = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine();
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int mdc = Mdc(num1, num2);

            System.Console.WriteLine(mdc);
        }
 }
 }