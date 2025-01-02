using System;

namespace seila;

class Aula
{
    static void Teste(string[] args)
    {
        int[] vetor = {1,2,3,4,5,6,7,8,9,10};
        var numeorsImpares = vetor.Where(n => n % 2 != 0);

        foreach (var numero in numeorsImpares)
        {
            System.Console.WriteLine(numero);
        }


    }
}