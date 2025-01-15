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

        public readonly EnumTipoConta TipoConta;

        public List<ATMTransacao> Transacoes {get;set;}


        // Metodo Consturtor
        public Conta(Usuario usuario, EnumTipoConta tipoConta)
        {
            Random r = new Random();

            this.IdConta = r.Next(0,1000000);
            this.Usuario = usuario;
            this.Saldo = 0;
            this.TipoConta = tipoConta;
            this.Transacoes = new List<ATMTransacao>();
        }


        // Métodos

        public void HistoricoTransacoes()
        {
            foreach (var comprovante in Transacoes)
            {
                System.Console.WriteLine();
                System.Console.WriteLine(comprovante.ToString());
                System.Console.WriteLine();
            }
        }

                public void Depositar(double valor, Conta contaRemetente)
        {   
            try{
                if (valor <= 0)
                {
                    Console.WriteLine("Depósito Inválido: o valor do seu depósito não pode ser menor ou igual a 0.");
                } else
                {
                    contaRemetente.Saldo += valor; // Creditando na conta

                    ATMTransacao comprovante = new ATMTransacao(EnumTipoTransacao.Deposito, valor, contaRemetente, contaRemetente);

                    this.Transacoes.Add(comprovante);

                    System.Console.WriteLine(comprovante.ToString());
                }
            }
            catch (FormatException e) 
            {
                System.Console.WriteLine("Entrada de dados errada: "+ e.Message);
            }
        }

        public void Sacar(double valor, Conta contaRemetente)
        {   
            do{
            try{
                if (valor <= 0)
                {
                    Console.WriteLine("Saque Inválido: o valor do seu depósito não pode ser menor ou igual a 0.");
                    break;

                } else if (contaRemetente.Saldo <= 0)
                {
                    Console.WriteLine("Saque Inválido: Você você não pode sacar com seu saldo negativo.");
                    break;


                } else if (valor > contaRemetente.Saldo)
                {
                    Console.WriteLine("Saque Inválido: Você você não pode sacar mais que seu saldo. ");
                    break;
                } else
                {
                    contaRemetente.Saldo -= valor; // Debitando da conta

                    ATMTransacao comprovante = new ATMTransacao(EnumTipoTransacao.Deposito, valor, contaRemetente, contaRemetente);
                    this.Transacoes.Add(comprovante);

                    System.Console.WriteLine(comprovante.ToString());
                    break;

                }
            }
            catch (FormatException e) 
            {
                System.Console.WriteLine("Entrada de dados errada: "+ e.Message);
            }
        }   while(true);
        }
        public void FazerTransacao(double valor, Conta contaRemetente, Conta contaDestinataria)
        {   
            try{
                if (valor <= 0)
                {
                    Console.WriteLine("Erro de Depósito: o valor do seu depósito não pode ser menor ou igual a 0.");
                } 
                else if (contaRemetente.Saldo <= 0)
                {
                    Console.WriteLine("Erro de Depósito: Você não tem saldo!.");
                    
                }
                else
                {
                    contaRemetente.Saldo -= valor; // Debitando da conta Remetente
                    contaDestinataria.Saldo =+ valor; // Creditando da conta Destinatária
                    
                    ATMTransacao comprovante = new ATMTransacao(EnumTipoTransacao.Deposito, valor, contaRemetente, contaDestinataria);
                    this.Transacoes.Add(comprovante);


                    System.Console.WriteLine(comprovante.ToString());

                }
            }
            catch (FormatException e) 
            {
                System.Console.WriteLine("Entrada de dados errada: "+ e.Message);
            }
        }

        public override string ToString()
        {
            return @$"
Nome: {Usuario.Nome}
CPF: {Usuario.CPF}
Endereço: {Usuario.Endereco}
Data De Nascimento: {Usuario.Ddn.ToString("dd/MM/yyyy")}
Conta: {this.TipoConta}
";
        }


    }
    

    public interface IContaActions 
    {
        public void Depositar(double valor, Conta contaDestinataria);

        public void Sacar(double valor, Conta contaDestinataria);
        public void FazerTransacao(double valor, Conta contaDestinataria, Conta contaRemetente);

        
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