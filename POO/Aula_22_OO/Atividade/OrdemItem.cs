using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_22_OO.Atividade
{
    public class OrdemItem
    {
        public int Quantidade {get;set;}
        public Produto Produto {get;set;}

        public OrdemItem(int quantidade, Produto produto)
        {
            this.Quantidade = quantidade;
            this.Produto = produto;
        }

        public double Total()
        {
            return (double)Quantidade*Produto.Preco;
        }
    }
}