using System;

namespace Aula_13
{
    public class Fila
    {
        static int[] fila = new int[10];

        static int inicio = 0; // Inicio da Fila

        static int fim = 0; // Fim da fila

        static int cont = 0; // Quantidade de elementos na fila



        public static void Adicionar(int valor)
        {
            if (cont < fila.Length)
            {
                fila[fim] = valor;
                fim = (fim + 1) % fila.Length; // Move o fim para o próximo elemento
                cont++; // Incrementa a quantidade de elementos na fila
            }
            else
            {
                Console.WriteLine("Fila Cheia");
            }
        }
        
        public static void Remover()
        {
            if (cont > 0)
            {
                fila[inicio] = 0;
                inicio = (inicio + 1) % fila.Length;
                cont--;
            }
            else
            {
                Console.WriteLine("Fila Vazia");
            }
        }

        public static void Mostrar()
        {
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine(fila[(inicio+i) % fila.Length]);
                //Console.WriteLine(vetor[i]);
            }
        }

        public static void Primeiro()
        {
            if(cont >0)
            {
                Console.WriteLine(fila[inicio]);
            }
            else
            {
                Console.WriteLine("Fila Vazia");
            }
        }
        
        public static void Teste(string[] args)
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

            Mostrar();
            Remover();
            Console.WriteLine();
            Remover();
            Mostrar();
            Primeiro();

 
        }
    }
}