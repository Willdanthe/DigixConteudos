using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProfessor
{
    public class Venda
    {
        public Produto[] Produtos { get; set; }
        public DataSetDateTime Data { get; set; }
        public Vendedor Vendedor { get; set; }
        public string FormaPagamento { get; set; }
        public int Parcelas { get;set;}
        public double ValorTotal { get;set;}
        public Cliente Cliente {get;set;}

        public double CalcularValorFinal()
        {
            Imposto imposto = new Imposto();

            double ValorFinal = 0;
            foreach (var produto in Produtos)
            {
                ValorFinal += produto.CalcularPrecoFinal();
            }
            return ValorFinal - imposto.CalcularImpostoVendas();
        }
    }
}