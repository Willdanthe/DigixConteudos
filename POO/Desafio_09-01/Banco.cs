using System;
using System.Collections.Generic;
using System.Linq;
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
        }

        public void Gerenciamentos()
        {
            System.Console.WriteLine("Gerenciando..."); // WIP
        }

        public void Maintain()
        {
            System.Console.WriteLine("..."); // WIP
        }
    }
}