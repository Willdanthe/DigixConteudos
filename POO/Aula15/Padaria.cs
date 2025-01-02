using System;
using System.Linq.Expressions;

namespace Poo
{
    public class Padaria
    {
        public string ?NomeAlimento;
        public string ?Bebida;
        public string ?Doces;
        public DateTime DateDeValidade;
        public Double Preco;

        public String Encomenda()
        {
            return $"Encomenda de {NomeAlimento}. Preço: R${Preco}";
        }

        // public Double CestaDeCompras(string NomeAlimento, double Preco)
        // {

        //     return Preco;
        // }
        public double CestaCompras(List<(string NomeAlimento, double Preco)> itens)
        {
            double total = 0;

            foreach (var item in itens)
            {
                System.Console.WriteLine($"Item: {item.NomeAlimento}\nPreço: {item.Preco}\n");
                total += item.Preco;
            }
            return total;
        }
    }
}
