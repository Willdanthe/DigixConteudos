using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_09_01
{
    public class ATM 
    {
        public Banco Banco {get;set;}

        public ATM(Banco banco)
        {
            this.Banco = banco;
        }


        public bool Verificacao(string cpf, string senha)
        {
            Conta validacaoCpf = Banco.Contas.Find(cont => cont.Usuario.CPF == cpf);
            Conta validacaoSenha = Banco.Contas.Find(cont => cont.Usuario.VerificarSenha() == senha);
            
            if (validacaoCpf != null && validacaoSenha != null)
            {
                System.Console.WriteLine("Entrando...");
                return true;
            } else
            {
                System.Console.WriteLine("Erro de Login: CPF ou Senha inválidos.");
                return false;
            }
        }

        public void OperecaoDeConta(string cpf, string senha)
        {
            bool validation = true;
            while (validation)
            {
                if (Verificacao(cpf, senha))
                {
                        Conta contaValidada = Banco.Contas.Find(conta => conta.Usuario.CPF == cpf);

                        System.Console.WriteLine("==--==--==--== Nobanco ==--==--==--==");
                        System.Console.WriteLine($"Bem-vindo(a) {contaValidada.Usuario.Nome}! Como posso ajudar?");
                        System.Console.WriteLine("[1]Depositar \n[2]Sacar \n[3]Tranferência \n[4]Extrato \n[5]Sair");

                        int op = Convert.ToInt32(Console.ReadLine());

                        switch (op)
                        {
                            case 1:

                                System.Console.WriteLine("Digite um valor pra depositar: ");
                                double valorDeposito = Convert.ToDouble(Console.ReadLine());
                                contaValidada.Depositar(valorDeposito, contaValidada);
                                break;

                            case 2:

                                System.Console.WriteLine("Digite um valor pra Sacar: ");
                                double valorSaque = Convert.ToDouble(Console.ReadLine());
                                contaValidada.Sacar(valorSaque, contaValidada);
                                break;

                            case 3:
                                System.Console.Write("Digite uma chave PIX CPF: ");
                                string chavePix = Console.ReadLine();
                                
                                Conta contaCache = Banco.Contas.Find(conta => conta.Usuario.CPF == chavePix);
                                
                                if (contaCache != null)
                                {
                                    System.Console.WriteLine("Digite um valor pra transferência: ");
                                    double valorTransferencia = Convert.ToDouble(Console.ReadLine());

                                    if (valorTransferencia <= contaValidada.Saldo){
                                        contaValidada.FazerTransacao(valorTransferencia, contaValidada, contaCache);
                                        break;
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Erro de transferência: Saldo Insuficiente");
                                        break;
                                    }
                                } 
                                else 
                                {
                                    Console.WriteLine($"Chave pix '{chavePix}' não encontrada");
                                    break;
                                }

                            case 4:
                                contaValidada.HistoricoTransacoes();
                                break;
                            case 5:
                                System.Console.WriteLine("Deslogando...");
                                validation = false;
                                break;
                            default:
                                System.Console.WriteLine("Opção inválida!");
                                break;
                        }   
                } else
                {
                    break;
                }
            }
        }
        // static void Main(string[] args)
        // {
        //     System.Console.WriteLine("oi");
        // }
    }
}