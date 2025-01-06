using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProfessor
{
    public abstract class Funcionario : IRelatorio
    {
        // Propriedades
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public int CPF { get; set; }
        public string Telefone { get; set; }
        public double SalarioBase { get; set; }

        // Métodos
        public abstract double CalcularSalario();
        public abstract void GerarRelatorio();
    }

    public class Gerente : Funcionario
    {
        public double Bonus {get;set;}

        public override double CalcularSalario()
        {
            return SalarioBase*1.2;
        }
        public override void GerarRelatorio()
        {
            System.Console.WriteLine($"Gerente: {Nome}");
            System.Console.WriteLine($"Salário: {CalcularSalario()}");
        }

        public void CalcularGratificacao()
        {
            System.Console.WriteLine("Foi calculado a Gratificacao do Gerente");
        }
    }

    public class Vendedor : Funcionario
    {
        public double VendasRealizadas {get;set;}

        public override double CalcularSalario()
        {
            return SalarioBase;
        }
        public override void GerarRelatorio()
        {
            System.Console.WriteLine($"Vendedor: {Nome}");
            System.Console.WriteLine($"Salário: {CalcularSalario()}");
        }

        public void CalcularGratificacao()
        {
            System.Console.WriteLine("Foi calculado a gratificacao do Gerente");
        }
    }

    public class Padeiro : Funcionario
    {
        public double HorasExtra {get;set;}

        public override double CalcularSalario()
        {
            double adicionalnoturno = HorasExtra + (SalarioBase* 0.25/160);
            return adicionalnoturno;
        }
        public override void GerarRelatorio()
        {
            System.Console.WriteLine($"Padeiro: {Nome}");
            System.Console.WriteLine($"Salário: {CalcularSalario()}");
        }

        public void CalcularComissao()
        {
            System.Console.WriteLine("Foi calculado a comissão do Vendedor");
        }
    }
    
}