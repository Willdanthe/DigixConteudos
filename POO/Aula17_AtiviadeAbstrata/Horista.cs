using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_AtiviadeAbstrata
{
    public class Horista : Empregado
    {
        public double PrecoHora;
        public double HorasTrabalhada;

        public Horista(string nome, string sobrenome, string cpf, double precoHora, double horasTrabalhada) : base(nome,sobrenome,cpf)
        {
            this.HorasTrabalhada = horasTrabalhada;
            this.PrecoHora = precoHora;
        }

        public override double Vencimento()
        {
            return PrecoHora * HorasTrabalhada;
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            System.Console.WriteLine($"Horas Trabalhadas: {HorasTrabalhada:F2} | Total Vendas: R${PrecoHora:F2}");
            System.Console.WriteLine($"Salário: {Vencimento()}");
        }
    }
}