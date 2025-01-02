using System;

namespace Aula_14;

public class ListaDuplamenteEncadeada
{
    class Node
    {
        public int valor;
        public Node? proximo;
        public Node? anterior;
    }

    static Node? inicio = null;
    
    static void Inserir(int valor)
    {
        Node novoNode = new Node {valor = valor, proximo = null, anterior = null};

        if (inicio == null)
        {
            inicio = novoNode;
        }
        else{
            Node atual = inicio;
            while (atual.proximo != null)
            {
                atual = atual.proximo;
            }
            atual.proximo = novoNode;
            novoNode.anterior = atual;
        }
    }

    static void Remover(int valor)
    {
        if (inicio == null)
        {
            System.Console.WriteLine("Lista Vazia!");
        }
        // if (inicio.valor == valor)
        // {
        //     inicio = inicio.proximo;
        //     inicio.anterior = null;
        //     return;
        // }

        if (inicio.valor == valor)
        {
            if(inicio.proximo != null)
            {
                inicio.proximo.anterior = null;
            }
            inicio = inicio.proximo;
            return;
        }

        Node atual = inicio;

        while (atual != null && atual.valor != valor)
        {
            atual = atual.proximo;
        }

        if (atual != null)
        {
             if (atual.anterior != null)
             {
                atual.anterior.proximo = atual.proximo;
             }
        }
        
        static void RemoverRecorrenciaTodos(int valor)
        {
            Node? atual = inicio;
            while (atual != null)
            {
                if (atual.anterior == null)
                {
                    inicio = inicio.proximo;
                    if(inicio != null)
                    {
                        inicio.anterior = null;
                    }
                }
                else if (atual.proximo == null)
                {
                    atual.anterior.proximo = null;
                }

                else
                {
                    atual.proximo.anterior = atual.proximo;
                    atual.anterior.proximo = atual.anterior;
                }
            }

            atual = atual.proximo;
        }

        static void Listar()
        {
            Node? atual = inicio;

            while(atual != null)
            {
                System.Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }

        static void Main(string[] args)
        {
            Inserir(10);
            Inserir(20);
            Inserir(30);
            Inserir(40);
            Inserir(50);

            // Listar();
        }

    }
}