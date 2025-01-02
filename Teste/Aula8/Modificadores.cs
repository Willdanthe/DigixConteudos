using System;

namespace Aula
{
    public class Modificadores
    {
        public int soma(int a, int b)
        {
            return a+b;
        }


        static void MWAHAHAHAHAHAHAH(string[] args)
        {
            // Chamando a função soma

            Modificadores m = new Modificadores();

        System.Console.WriteLine(m.soma(4,4));

        }
    }
}