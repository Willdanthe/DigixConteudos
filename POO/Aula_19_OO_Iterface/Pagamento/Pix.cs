using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Iterface
{
    public class Pix : IPagamento
    {
        public string ChavePix {get;set;}
        public string NomeTitular{get;set;}
        public string Cpf {get;}
        public double Valor {get;set;}
        public DateTime DataPagamento {get;set;}

        public Pix(string chavePix, string nometitular, string cpf, double valor, DateTime datapagamento)
        {
            this.ChavePix = chavePix;
            this.NomeTitular = nometitular;
            this.Cpf = cpf;
            this.Valor = valor;
            this.DataPagamento = datapagamento;
        }

        public void RealizarPagamento(double valor)
        {
            this.Valor = valor;
            System.Console.WriteLine("Pagamento Realizado com sucesso via Pix!");
            // base.RealizarPagamento();
        }
        public void ExibirComprovante()
        {
            Console.WriteLine($"Comprovante de pagamento com o cartão ");
        }

        public void Pagar()
        {
            System.Console.WriteLine($"Pagamento realzado com sucesso via pix de R${this.Valor:F2}");
        }

        public void ExibirComprovanteComprovante()
        {
            System.Console.WriteLine("Comprovante de pagamento via Pix");
            Console.WriteLine($"Chave pix: {this.ChavePix}");
            
        }

    }
}