using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace Desafio_09_01
{
    public class Banco
    {
        private readonly string? Nome;
        private readonly int Codigo;

        public List<Conta> Contas { get; set; }
        public List<ContaCorrente> ContasCorrentes { get; set; }
        public List<ContaPoupanca> ContasPoupancas { get; set; }
        
        public Banco(string nome, int codigo)
        {
            this.Nome = nome;
            this.Codigo = codigo;
            this.Contas = new List<Conta>();
            this.ContasCorrentes = new List<ContaCorrente>();
            this.ContasPoupancas = new List<ContaPoupanca>();
        }

        public void CriarConta()
        {
            System.Console.WriteLine("=-=-=-=-=-=Criando Conta=-=-=-=-=-=");
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            System.Console.WriteLine("Cpf: ");
            string cpf = Console.ReadLine();
            
            Console.ReadLine();
            

        }

        public void Maintain()
        {
            System.Console.WriteLine("..."); // WIP
        }
    }
}