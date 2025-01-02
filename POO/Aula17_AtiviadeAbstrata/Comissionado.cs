using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_AtiviadeAbstrata
{
    public class Comissionado : Empregado
    {
        public double TotalVenda;
        public double TaxaComissao;

        public Comissionado(string nome, string sobrenome, string cpf, double totalVenda, double taxaComissao) : base(nome,sobrenome,cpf)
        {
            this.TaxaComissao = taxaComissao;
            this.TotalVenda = totalVenda;
        }

        public override double Vencimento()
        {
            return TotalVenda + TaxaComissao;
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            System.Console.WriteLine($"Taxa Comissão: {TaxaComissao:F2} | Total Vendas: R${TotalVenda}");
            System.Console.WriteLine($"Salário: {Vencimento()}");
        }
    }
}