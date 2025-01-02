using System;

namespace Aula14
{
    public class Lista
    {
       
        class Node
        {
            public int valor;
            public Node? proximo; //QUando tem a interrogas, está dizendo que pode ter um fim 
        }

        private Node? inicio = null;

        public void Inserir(int valor)
        {
            Node novoNode = new Node { valor =  valor, proximo = null};
            
            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                while(atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }
                atual.Proximo = novoNode;
            }
        }

        public void Excluir(int valor)
        {
            if (inicio == null) return;

            if (inicio.Valor == valor)
            {
                inicio = inicio.Proximo;
                return;
            }

            Node atual = inicio;
            while (atual.Proximo != null && atual.Proximo.Valor != valor)
            {
                atual = atual.Proximo;
            }

            if (atual.Proximo != null)
            {
                atual.Proximo = atual.Proximo.Proximo;
            }
        }

        public void Listar()
        {
            if (inicio == null)
            {
                return;
            }
            
            Node? atual = inicio;
            Console.WriteLine("Elemetnos da Lista: ");

            while (atual != null)
            {
                Console.WriteLine(atual.Valor);
                atual = atual.Proximo;
            }
        }
        

        static void teste()
        {
            Lista lista = new Lista();

            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            lista.Inserir(40);
            lista.Inserir(50);
            lista.Inserir(60);
            lista.Inserir(70);
            lista.Inserir(80);
            lista.Inserir(90);
            lista.Inserir(100);

            lista.Listar();

            lista.Excluir(50);

            lista.Listar();
        }

    }
}