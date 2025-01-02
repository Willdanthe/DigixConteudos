using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_AtiviadeAbstrata
{
    public abstract class Empregado
    {
        public string Nome;
        public string Cpf;
        public string Sobrenome;

        public Empregado(string nome, string sobrenome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Sobrenome = sobrenome;
        }
        public abstract double Vencimento();

        public virtual void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome} {Sobrenome} | CPF: {Cpf}");
        }
    }
}