using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_OO_Estruct
{
    public struct ContaBancariaStruct
    {
        public string Numero {get;set;}
        public string Titular {get;set;}
        public decimal Saldo { get; set; }

        public ContaBancariaStruct(string numero, string titular, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        
        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }

        public void Saque(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            } else
            {
                System.Console.WriteLine("Saldo insuficiente");
            }
        }

        public override string ToString()
        {
            return $"Conta: {Numero} \nTitular: {Titular} \nSaldo: {Saldo}";
        }

        public void AlterarSaldo(decimal valor)
        {
            this = new ContaBancariaStruct(this.Numero, this.Titular, valor + Saldo);

            System.Console.WriteLine("Saldo alterado com sucesso");


        }
    }

    public class ContaBancariaClasse
    {
        public string Numero {get;set;}
        public string Titular {get;set;}
        public decimal Saldo { get; set; }

        public ContaBancariaClasse(string numero, string titular, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        
        public void Deposito(decimal valor)
        {
            Saldo += valor;
        }

        public void Saque(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            } else
            {
                System.Console.WriteLine("Saldo insuficiente");
            }
        }
        public override string ToString()
        {
            return $"Conta: {Numero} \nTitular: {Titular} \nSaldo: {Saldo}";
        }

        public void AlterarSaldo(decimal valor)
        {
            Saldo += valor;
            System.Console.WriteLine("Saldo alterado com sucesso");
        }
    }

    public class Executaraaaa
    {
        static void Main(string[] args)
        {
            ContaBancariaStruct conta1 = new ContaBancariaStruct("123","Maria",1000);

            conta1.AlterarSaldo(500);
            System.Console.WriteLine(conta1);

            ContaBancariaClasse conta2 = new ContaBancariaClasse("123","Mari", 1000);

            conta2.AlterarSaldo(500);
            System.Console.WriteLine(conta2);

        }
    }
}