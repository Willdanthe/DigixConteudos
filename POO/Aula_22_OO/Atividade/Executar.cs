using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_22_OO.Atividade
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Produto bolacha = new Produto("Bolacha",50);
            Produto coca = new Produto("Coca-Cola",70);
            Produto arroz = new Produto("Bolacha",180);

            OrdemItem primeiroitem = new OrdemItem(3,bolacha);
            OrdemItem segundoitem = new OrdemItem(2,coca);
            OrdemItem terceiroitem = new OrdemItem(1,arroz);

            Ordem ordem = new Ordem(OrdemStatus.p1);

            ordem.AddItem(primeiroitem);
            ordem.AddItem(segundoitem);
            ordem.AddItem(terceiroitem);

            System.Console.WriteLine(ordem.Total());
            
        }
    }
}