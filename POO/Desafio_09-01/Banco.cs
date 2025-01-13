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

        public Conta    CriarConta(EnumTipoConta tipoConta)
        {
            System.Console.WriteLine("=-=-=-=-=-=Criando Conta=-=-=-=-=-=");
            System.Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            
            System.Console.WriteLine("Cpf: ");
            string cpf = Console.ReadLine();
            
            System.Console.WriteLine("Endereço: ");
            string endereco = Console.ReadLine();

            System.Console.WriteLine("Data de Nascimento (dd/MM/yyyy): ");
            DateTime ddn = Convert.ToDateTime(Console.ReadLine());
            
            string senha;
            do
            {
                System.Console.WriteLine("Digite uma senha de 4 a 6 Digitos: ");
                senha = Console.ReadLine();

                if (senha.Length < 4) 
                {
                    Console.WriteLine("Senha inválida: Digite uma senha com mais de 4 digitos\n");
                } else if(senha.Length > 6)
                {
                    Console.WriteLine("Senha inválida: Digite uma senha com mais de 6 digitos\n");
                } else if (senha == null)
                {
                    System.Console.WriteLine("Entrada inválida\n");
                } else
                {
                    break;
                }
            } while (true);
            Usuario user = new Usuario(nome, cpf, endereco, ddn, senha);
            Conta conta = new Conta(user, tipoConta);

            this.Contas.Add(conta);

            if (tipoConta == EnumTipoConta.Poupanca)
            {
                ContaPoupanca contapou = new ContaPoupanca(user, tipoConta);
                this.ContasPoupancas.Add(contapou);
                return contapou;

            } else if(tipoConta == EnumTipoConta.Corrente)
            {
                ContaCorrente contaco = new ContaCorrente(user, tipoConta);
                this.ContasCorrentes.Add(contaco);
                return contaco;
            } else 
            {
                System.Console.WriteLine("Tipo de conta inválido");
                return null;
            }

        }

        public void ListarContas()
        {
            foreach (var conta in Contas)
            {
                System.Console.WriteLine();
                System.Console.WriteLine(conta.ToString());
                System.Console.WriteLine();
            }
        }

        public void BuscarPorCpf(string cpf)
        {
                Conta contacache = Contas.Find(cont => cont.Usuario.CPF == "cpf");
                System.Console.WriteLine("Buscando...");
                if (contacache != null)
                {
                    System.Console.WriteLine("Conta encontrada:");
                    Console.WriteLine(contacache.ToString());
                } else
                {
                    throw new DomainException("Erro de Busca: CPF inválido ou conta não existe");
                }
        }
    }
}