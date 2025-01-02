using System;

namespace naoseiainda{
    public class Lista
    {
        static int[] vetor = new int[10];


        // Metodo para Inserir
        static void Inserir(int valor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == 0)
                {
                    vetor[i] = valor;
                    break;
                }
            }
        }

        // Método para Remover
        static void Remover(int valor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == valor)
                {
                    vetor[i] = 0;
                    break;
                }
            }
        }

        // Método para Listar
        static void Listar()
        {
            for (int i = 0 ; i < vetor.Length; i++)
            {
                if (vetor[i] != 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }

        // Método para listar inverso
        static void ListarInverso()
        {
            for(int i = vetor.Length-1; i >= 0; i--)
            {
                if (vetor[i] != 0)
                {
                    System.Console.WriteLine(vetor[i]);
                }
            }
        }
    


    static void Teste(string[] args)
    {
        Inserir(10);
        Inserir(20);
        Inserir(30);
        Inserir(40);
        Inserir(50);
        Inserir(60);
        Inserir(70);
        Inserir(80);
        Inserir(90);
        Inserir(100);
        Listar();
        System.Console.WriteLine();
        Remover(90);
        Listar();
    }
}
}