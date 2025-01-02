using System;

namespace Atividade1
{
    public class ListaEncadeada
    {
        class Node
        {
            public int valor;
            public Node? proximo;
        }

        private Node? inicio = null;

    
        public void Inserir(int valor, int indice)
        {
            Node novoNode = new Node { valor = valor, proximo = null };
     
            if (indice == 0)
            {
                novoNode.proximo = inicio;
                inicio = novoNode;
                return;
            }


            Node atual = inicio;
            int contador = 0;


            while (atual != null && contador < indice - 1)
            {
                atual = atual.proximo;
                contador++;
            }

            if (atual == null)
            {
                Console.WriteLine("Índice inválido.");
                return;
            }

            novoNode.proximo = atual.proximo;
            atual.proximo = novoNode;
        }
        public void Listar()
        {
            if (inicio == null)
            {
                Console.WriteLine("A lista está vazia.");
                return;
            }
            
            Node? atual = inicio;
            Console.WriteLine("Lista:");

            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.proximo; 
            }
        }

        public void Contem(int valor)
        {
            bool verificador = false;
            if (inicio == null)
            {
                Console.WriteLine("A lista está vazia.");
            }

            Node? atual = inicio;

            while(atual != null)
            {
                if (atual.valor == valor)
                {
                    verificador = true;
                }

                atual = atual.proximo; 
            }

            System.Console.WriteLine(verificador);
        }
    }

    class Program
    {
        static void Teste(string[] args)
        {   
            //Atividade 1
            ListaEncadeada lista = new ListaEncadeada();
            lista.Inserir(10, 0); 
            lista.Inserir(20, 1); 
            lista.Inserir(30, 2); 
            lista.Inserir(25, 1);

            Console.WriteLine("\nApós inserir 25 na posição 1:");
            
            lista.Listar(); 
  
            lista.Inserir(40, 10); 



            //Atividade 2
            System.Console.WriteLine("Contém 20:");
            lista.Contem(20);
            lista.Contem(40);
        }
    }
}