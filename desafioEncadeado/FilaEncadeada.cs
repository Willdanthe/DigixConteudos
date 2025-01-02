using System;

namespace ExercicioFila
{
    public class Fila
    {
        class Node
        {
            public int valor;
            public Node? proximo;
        }

        private Node? inicio = null;
        private Node? fim = null;

        public void Enfileirar(int valor)
        {
            Node novoNode = new Node { valor = valor, proximo = null };

            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                fim!.proximo = novoNode; 
            }

            fim = novoNode; 
        }

        public void Listar()
        {
            if (inicio == null)
            {
                Console.WriteLine("Fila vazia!");
                return;
            }

            Node? atual = inicio;
            Console.WriteLine("Elementos da Fila:");
            while (atual != null)
            {
                Console.Write(atual.valor + " ");
                atual = atual.proximo;
            }
        }

        public void Contar()
        {
            int contador = 0;
            if (inicio == null)
            {
                Console.WriteLine("Fila vazia!");
                return;
            }

            Node? atual = inicio;
            while (atual != null)
            {
                atual = atual.proximo; 
                contador++;
            }
            Console.WriteLine(contador);
        }

        public void InserirFila(Fila outraFila)
        {
            Node? atual = outraFila.inicio;

            while (atual != null)
            {
                this.Enfileirar(atual.valor); 
                atual = atual.proximo; 
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fila fila1 = new Fila();
            fila1.Enfileirar(10);
            fila1.Enfileirar(20);
            Fila fila2 = new Fila();
            fila2.Enfileirar(30);
            fila2.Enfileirar(40);
            Console.WriteLine("Fila 1:");
            fila1.Listar();
            Console.WriteLine("\nFila 2:");
            fila2.Listar();
            fila1.InserirFila(fila2);

            // Atividade 1
            Console.WriteLine("\nFila 1 após inserir elementos da Fila 2:");
            fila1.Listar();
            fila1.Contar();
        }
    }
}
