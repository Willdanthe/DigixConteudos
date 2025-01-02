using System;

namespace Poo
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        // Metodo Construtor
        // public Produto(string nome, double preco)
        // {
        //     this.Nome = nome;
        //     this.Preco = preco;
        // }

        public Produto()
        {
            this.Nome = "nome";
            this.Preco = 0.0;
        }
        
        public void ExibirInformações()
        {
            System.Console.WriteLine($"Produto: {this.Nome} -> Preço: R${this.Preco}");
        }

        public static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Nome = "Suco de Laranja Natural";
            p1.Preco = 27.99;
            p1.ExibirInformações();
        }

    }
}