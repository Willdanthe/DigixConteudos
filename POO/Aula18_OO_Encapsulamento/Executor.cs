using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula18_OO_Encapsulamento
{
    public class Executor
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Bomba Atômica", 10000000, 4);

            // p.SetNome("Bomba de Hidrogênio");
            p.Nome = "Bomba de Hidrogênio";


            p.Preco = 20000.40;
            p.Quantidade = 19;

            Console.WriteLine($"Nome: {p.Nome} \nPreço: ${p.Preco} \nQuantidade: {p.Quantidade}");
            
            // System.Console.WriteLine(p.ToString());


            // A classe type representa o metadado de uma classe em tempo de execução
            Type t = typeof(Produto); // Retorna o tipo da classe
            System.Console.WriteLine(t.Name); // Rertorna o nome da classe

            System.Console.WriteLine();

            foreach (PropertyInfo prop in t.GetProperties())
            {
                System.Console.WriteLine(prop.Name);
            }
        }
    }
}