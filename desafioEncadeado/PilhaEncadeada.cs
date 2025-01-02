namespace Aula_14
{
    public class PilhaEncadeada
    {
        class Node
        {
            public int valor;
            public Node? proximo;
        }

        static int tamanho = 0;
        static Node? topo = null;

        // Empilha é acrescentar um elemento no topo da pilha
        static void Empilhar(int valor)
        {
            // Cria um novo no com valor fornecido
            Node novoNode = new Node { valor = valor, proximo = topo };

            // Atualiza o topo do No
            topo = novoNode;
            tamanho++;
        }

        // Desempilhar é remover o elemento do topo da pilha
        static void Desempilhar()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia!");
                return;
            }

            // Console.WriteLine($"Desempilhando {topo.valor}");
            topo = topo.proximo;
        }

        // Listar a Pilha
        static void Listar()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia!");
                return;
            }
            System.Console.WriteLine("Listando a Pilha");
            Node? atual = topo;
            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }

        static void Inverter()
        {
            // System.Console.WriteLine(tamanho);
            int[] aux = new int[tamanho];

            for(int i = 0; i < tamanho; i++)
            {
                aux[i] = topo.valor;
                Desempilhar();
            }
            
            for(int j = 0; j < 3; j++)
            {
                Empilhar(aux[j]);
                Listar();
            }
            


            System.Console.WriteLine(string.Join(" ", aux));
        }

        static void Topo()
        {
            System.Console.WriteLine(topo.valor);
        }


        static void teste(string[] args)
        {
            Empilhar(10);
            Empilhar(20);
            Empilhar(30);
            Listar();

            // Atividade 3
            Topo();
            System.Console.WriteLine();

            // Atividade 4
            Inverter();
            Topo();

        }
    }
}