using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_AtiviadeAbstrata
{
    public class Assalariado : Empregado
    {
        public double Salario;

        public Assalariado(string nome, string sobrenome, string cpf, double salario) : base(nome,sobrenome,cpf)
        {
            this.Salario = salario;
        }

        public override double Vencimento()
        {
            return Salario;
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            System.Console.WriteLine($"Salário: {Vencimento()}");
        }
    }
}