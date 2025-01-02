using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade1Aula18
{
    public class Banco
    {
        // PROPRIEDADES E ATRIBUTOS
        public string? Nome {get;set;}
        public int NumeroConta {get; private set;}
        public double Saldo {get; private set;}
        private double _TaxaSaque = 5;

        // MÉTODOS CONSTRUTORES
        public Banco(string nome, int numeroconta)
        {
            this.Nome = nome;
            this.NumeroConta = numeroconta;
        }

        public Banco(string nome, int numeroconta, double saldo) : this(nome, numeroconta)
        {
            this.Saldo = saldo;
        }

        // FUNÇÕES DO BANCO
        public void Depositar(double valor)
        {
            System.Console.WriteLine($"Você depositou R${valor:F2}");
            this.Saldo += valor;
            System.Console.WriteLine($"Seu saldo atual é de R${this.Saldo}");
            
        }

        public void Sacar(double valor)
        {   
            System.Console.WriteLine($"Saldo Anterior: {this.Saldo}");
            System.Console.WriteLine($"Você sacou R${valor:F2} e será descontado R${this._TaxaSaque}");

            this.Saldo -= (valor + this._TaxaSaque);
            
            System.Console.WriteLine($"Seu saldo atual é de: R${this.Saldo}");
        }

        // public void ImprimirDados()
        // {
        //     Console.WriteLine($"Numero da conta: {this.NumeroConta}\nTitular da conta: {this.Nome} \nSaldo: R${this.Saldo:F2}");
            
        // }

        public override string ToString()
        {
            return $"\nNumero da conta: {NumeroConta}\nTitular: {Nome}\nSaldo: {Saldo}";
        }
    }
}