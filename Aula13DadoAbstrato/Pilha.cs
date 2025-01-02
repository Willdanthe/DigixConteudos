using System;

namespace Aula_13
{
    public class Pilha
    {
        static int[] pilha = new int[10];
    
        static int topo = 0;
    
        public static void Adicionar(int valor)
        {
            if (topo < pilha.Length)
            {
                pilha[topo] = valor;
                topo++;
            } else
            {
                Console.WriteLine("Pilha Cheia");
            }
        }

        public static void Remover()
        {
            if (topo > 0)
            {
                topo--;
                pilha[topo] = 0;
            }
            else
            {
                Console.WriteLine("Pilha vazia");
            }
        }

        public static void Listar()
        {
            for (int i = topo - 1; i >=0; i--)
            {
                Console.WriteLine(pilha[i]);
            }
        }

        public static void Main(string[] args)
        {
            Adicionar(10);
            Adicionar(20);
            Adicionar(30);
            Adicionar(40);
            Adicionar(50);
            Adicionar(60);
            Adicionar(70);
            Adicionar(80);
            Adicionar(90);
            Adicionar(100);

            Listar();
            Remover();
            Console.WriteLine();
            Listar();
        }
    }
}