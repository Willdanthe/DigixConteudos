using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Iterface
{
    public class CartaoDeCredito : IPagamento, IAnuidade
    {
        public string NumeroCartao {get;set;}
        public DateTime DataVencimento {get;set;}
        public double ValorAnuidade{get;set;}



        // Construtor
        // public CartaoDeCredito (string numeroCartao)
        // {
        //     this.NumeroCartao = numeroCartao;
        // }
        public CartaoDeCredito(string numeroCartao, DateTime datavencimento, double valorAnuidade)
        {
            this.NumeroCartao = numeroCartao;
        }


        public void RealizarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento de  R${valor} realizado com Sucesso");
        }

        public void ExibirComprovante()
        {
            Console.WriteLine($"Comprovante de pagamento com o cartão {NumeroCartao}");
        }

        //Importar interface anuidade
        public DateTime CalcularDataVencimento()
        {
            return DateTime.Now.AddYears(1);
        }

        public double CalcularValorAnuidade()
        {
            return 100;
        }
    }
}