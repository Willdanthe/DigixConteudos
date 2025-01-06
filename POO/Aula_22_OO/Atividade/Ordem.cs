using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Aula_22_OO.Atividade
{
    public class Ordem
    {
        public DateTime Data {get;set;}
        public OrdemStatus Status {get;set;}
        public List<OrdemItem> Produtos = new List<OrdemItem>{};



        public Ordem(OrdemStatus status)
        {
            this.Data = DateTime.Now;
            this.Status = status;
        }

        public void AddItem(OrdemItem item)
        {
            Produtos.Add(item);
        }

        public void RemoveItem(OrdemItem item)
        {
            Produtos.Remove(item);
        }

        public double Total()
        {
            double soma = 0;

            foreach (var item in Produtos)
            {
                soma += item.Produto.Preco;
            };

            return soma;
        }
    }
}