using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_09_01
{
    public class Conta : IContaActions
    {
        // Propriedades
        public int IdConta { get; set; }
        public Usuario Usuario {get;set;}
        public double Saldo {get;set;}

        private readonly EnumTipoConta TipoConta;

        public List<ATMTransacao> Transacoes {get;set;}


        // Metodo Consturtor
        public Conta(Usuario usuario, EnumTipoConta tipoConta)
        {
            Random r = new Random();

            this.IdConta = r.Next(0,1000000);
            this. Usuario = usuario;
            this.Saldo = 0;
            this.TipoConta = tipoConta;
            this.Transacoes = new List<ATMTransacao>();
        }


        // Métodos

        public void HistoricoTransacoes()
        {}

                public void Depositar(double valor, Conta contaRemetente)
        {   
            try{
                if (valor <= 0)
                {
                    throw new DomainException("Depósito Inválido: o valor do seu depósito não pode ser menor ou igual a 0.");
                } else
                {
                    contaRemetente.Saldo += valor; // Creditando na conta

                    ATMTransacao comprovante = new ATMTransacao(EnumTipoTransacao.Deposito, valor, contaRemetente, contaRemetente);
                    System.Console.WriteLine(comprovante.ToString());
                }
            }
            catch (FormatException e) 
            {
                System.Console.WriteLine("Entrada de dados errada: "+ e.Message);
            }
        }

        public void Sacar(int valor, Conta contaRemetente)
        {   
            try{
                if (valor <= 0)
                {
                    throw new DomainException("Saque Inválido: o valor do seu depósito não pode ser menor ou igual a 0.");

                } else if (contaRemetente.Saldo <= 0)
                {
                    throw new DomainException("Saque Inválido: Você você não pode sacar com seu saldo negativo.");

                } else if (valor > contaRemetente.Saldo)
                {
                    throw new DomainException("Saque Inválido: Você você não pode sacar mais que seu saldo. ");
                }
                {
                    contaRemetente.Saldo -= valor; // Debitando da conta

                    ATMTransacao comprovante = new ATMTransacao(EnumTipoTransacao.Deposito, valor, contaRemetente, contaRemetente);
                    System.Console.WriteLine(comprovante.ToString());

                }
            }
            catch (FormatException e) 
            {
                System.Console.WriteLine("Entrada de dados errada: "+ e.Message);
            }
        }
        public void FazerTransacao(int valor, Conta contaRemetente, Conta contaDestinataria)
        {   
            try{
                if (valor <= 0)
                {
                    throw new DomainException("Erro de Depósito: o valor do seu depósito não pode ser menor ou igual a 0.");
                } else
                {
                    contaRemetente.Saldo -= valor; // Debitando da conta Remetente
                    contaDestinataria.Saldo =+ valor; // Creditando da conta Destinatária
                    
                    ATMTransacao comprovante = new ATMTransacao(EnumTipoTransacao.Deposito, valor, contaRemetente, contaDestinataria);

                    System.Console.WriteLine(comprovante.ToString());

                }
            }
            catch (FormatException e) 
            {
                System.Console.WriteLine("Entrada de dados errada: "+ e.Message);
            }
        }
        
    }
    

    public interface IContaActions 
    {
        public void Depositar(double valor, Conta contaDestinataria);

        public void Sacar(int valor, Conta contaDestinataria);
        public void FazerTransacao(int valor, Conta contaDestinataria, Conta contaRemetente);

        
    }


    public class ContaCorrente : Conta
    {
        public ContaCorrente(Usuario usuario, EnumTipoConta tipoConta) : base(usuario, tipoConta)
        {}
    }

    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(Usuario usuario, EnumTipoConta tipoConta) : base(usuario, tipoConta)
        {}

    }
}