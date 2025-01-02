using System;

namespace seila;

class Recursao
{
    static int[] ObterPares(int[] vet, int indice = 0)
    {
        if (indice >= vet.Length)
        {
            return new int[0];
        }                   

        // Chama Recursivamente os pares restantes do vetor

        int[] paresRestantes = ObterPares(vet, indice+1);

        if (vet[indice] % 2 == 0)
        {
            int[] resultado = new int[paresRestantes.Length+1];

            resultado[0] = vet[indice];
            paresRestantes.CopyTo(resultado,1 );

            return resultado;
        }else{
            return paresRestantes;
        }


    }

    static void Main(string[] args)
    {
        int[] vet = {1,2,3,4,5,6,7,8,9,10};
        int[] pares = ObterPares(vet);

        foreach (var item in pares)
        {
            System.Console.WriteLine(item);
        }


    }
}