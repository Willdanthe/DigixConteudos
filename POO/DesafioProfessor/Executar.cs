using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProfessor
{
    public class Executar
    {
        public static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            List<Produto> produtos = new List<Produto>();
            List<Venda> vendas = new List<Venda>();
            Estoque estoque = new Estoque();

            int opcao;

            do
            {
                Console.Clear();
                System.Console.WriteLine("1 - Cadastrar Cliente");
                System.Console.WriteLine("1 - Cadastrar Produto");
                System.Console.WriteLine("1 - Cadastrar Venda");
                System.Console.WriteLine("1 - Consultar Estoque");
                System.Console.WriteLine("1 - Gerar Relatório de Funcionários");
                System.Console.WriteLine("6 - Sair");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarCliente(clientes);
                        break;
                    case 2:
                        CadastarProduto(produtos, estoque);
                        break;
                    case 3:
                        RegistrarVenda(clientes, produtos, vendas);
                        break;
                    case 4:
                        ConsultarEstoque(estoque);
                        break;
                    case 5:
                        GerarRelatorioVendas(vendas);
                        break;
                    case 6:
                        System.Console.WriteLine("Saindo...");
                        break;
                    default:
                        System.Console.WriteLine("Opção inválida");
                        break;
                }
                
            } while (opcao != 6);
        }

        
        public void CadastrarCliente(List<Cliente> clientes)
        {
            System.Console.WriteLine("Digite o nome do CLiente: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Digite o CPF do CLiente: ");
            string cpf= Console.ReadLine();

            System.Console.WriteLine("Digite o Telefone do CLiente: ");
            string telefone = Console.ReadLine();

            System.Console.WriteLine("Digite o Endereço do CLiente: ");
            string  endereço = Console.ReadLine();

            Cliente cliente = new ClienteGold{
                Nome = nome,
                CPF = cpf,
                Telefone = telefone,
                
                Endereco = new Endereco{
                    Rua = endereço.Split(", ")[0],
                    Cidade = endereço.Split(", ")[1],
                    Estado = endereço.Split(", ")[2],
                    CEP = endereço.Split(", ")[3]
                }
                
            };
        }
    }
}