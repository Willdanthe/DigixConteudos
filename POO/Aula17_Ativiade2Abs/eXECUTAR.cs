using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_Ativiade2Abs
{
    public class EXECUTAR
    {
        static void Main(string[] args)
        {
            Produto [] produto = new Produto[3];
            produto[0] = new Livro(1,20.0, "Patrick Rothfuss", 8599296493);
            produto[1] = new CompactDisc(2,30.0 ,"Lucas ART", "8 minutoz");
            produto[2] = new Livro(3,40.9,"Galinha pitadinha: A volta dos que nunca foram", 489127489);

            foreach (var produto in produto)
            {
                System.Console.WriteLine($"Codigo: {produto.GetCodigo()}");
                System.Console.WriteLine($"Preço: {produto.GetPreco()}");
                // produto.AtualizarPreco(produto.GetPreco() * 1.1);
                System.Console.WriteLine($"Preço Atualizado: {produto.GetPreco()}");
                System.Console.WriteLine(); 
            }
        }
    }
}