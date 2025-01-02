using System;
namespace Aula4
{
    class Tabuada
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Escolha um número para a tabuada: ");
            int tabuada = Convert.ToInt32(Console.ReadLine());
            int x = 0;

            // Tauba com For
            for (int i = 0; i< 11;i++)
            {
                Console.WriteLine($"{tabuada}  x  {i}  =  {tabuada*i}");
            }

            // Tauba com While
            while (x != 10)
            {
                x++;
                Console.WriteLine($"{tabuada}  x  {x}  =  {tabuada*x}");
            }

            // Tauba com Do While
            do{
                x++;
                Console.WriteLine($"{tabuada}  x  {x}  =  {tabuada*x}");
            } while(x != 10);



        }
    }
}