using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_24_OO_Excecao.Desafio
{
    public class Account
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public double SaqueLimite { get; set; } = 500;

        public Account(string nome, double saldo)
        {
            Random r = new Random();
            this.Id = r.Next(100000,200000);
            this.Nome = nome;
            this.Saldo = saldo;
        }

        public void Sacar()
        {
            System.Console.WriteLine("Quantos gostaria de sacar?\n");
            double valor = Convert.ToDouble(Console.ReadLine());
            
            if (Saldo <= 0)
            {
                throw new DomainException("Erro Saque: Você não pode sacar sem nenhum valor na conta");
            } else if(valor > SaqueLimite)
            {
                throw new DomainException($"Erro Saque: Você não pode sacar mais que R${SaqueLimite:F2}");
            } else
            {
                this.Saldo -= valor;
                System.Console.WriteLine($"Seu novo saldo é de R${this.Saldo:F2}");
            }
        }

        public void Depositar()
        {
            System.Console.WriteLine("Quantos gostaria de depositar?\n");
            double valor = Convert.ToDouble(Console.ReadLine());

            this.Saldo += valor;
            System.Console.WriteLine($"Seu novo saldo é de R${this.Saldo:F2}");


        }

        public override string ToString()
        {
            return $"Dados da conta:\nId: {Id} \nNome: {Nome} \nSaldo: {Saldo}";
        }





    }
}