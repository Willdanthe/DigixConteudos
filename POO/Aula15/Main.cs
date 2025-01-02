using System;
using System.Data;

namespace Poo
{
    public class Program
    {
        static void Teste(string[] args)
        {
            Padaria padaria = new Padaria();

            padaria.NomeAlimento = "Sonho";
            padaria.Preco = 7.5;
            padaria.Bebida = "Pingado";
            padaria.Doces = "Bolo de Cenoura com Chocolate";
            padaria.DateDeValidade = DateTime.Now.AddDays(3);
            
            // Exibindo os detalhes da encomenda
            System.Console.WriteLine(padaria.Encomenda());

            // Criando uma lista de Compras com o nome e o preço
            List<(string NomeAlimento, double Preco)> listaCompras =
            [
                ("Pão Francês", 5.90),
                ("Bolo Cenoura", 20.00),
                ("Coxinha", 5.0),
                ("Suco Naural 750ml", 10.99)
            ];

            double total = padaria.CestaCompras(listaCompras);

            System.Console.WriteLine($"R${total:F2}");
        }
    }
}