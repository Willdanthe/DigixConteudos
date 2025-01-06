using System;
using System.Buffers;
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
                // Console.Clear();
                System.Console.WriteLine("1 - Cadastrar Cliente");
                System.Console.WriteLine("2 - Cadastrar Produto");
                System.Console.WriteLine("3 - Cadastrar Venda");
                System.Console.WriteLine("4 - Consultar Estoque");
                System.Console.WriteLine("5 - Gerar Relatório de Funcionários");
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

        
        static public void CadastrarCliente(List<Cliente> clientes)
        {
            System.Console.WriteLine("Digite o nome do Cliente: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("Digite o CPF do Cliente: ");
            string  cpf = Console.ReadLine();

            System.Console.WriteLine("Digite o Telefone do Cliente: ");
            string telefone = Console.ReadLine();

            System.Console.WriteLine("Digite o Endereço do Cliente: ");
            string endereço = Console.ReadLine();

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

            clientes.Add(cliente);
            System.Console.WriteLine("CLiente Aducuibadi");
        }

        private static void CadastarProduto(List<Produto> produtos, Estoque estoque)
        {

            Console.Clear();
            System.Console.WriteLine("===== Cadastro de Produto =====");
            
            // Inserir Nome do Produto
            System.Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            // Inserir Código do produto
            System.Console.Write("Digite o Código do produto: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            // Inserir preço de custo do produto
            System.Console.Write("Digite o Preço de Custo: ");
            double precoCusto = Convert.ToDouble(Console.ReadLine());
            
            // Inserir Apelido do produto
            System.Console.Write("Digite o Apelido do produto: ");
            string apelido = Console.ReadLine();

            // Inserir se o produto é perecível
            System.Console.Write("Digite se o produto é perecível: ");
            bool perecivel = Convert.ToBoolean(Console.ReadLine());

            // Inserir Preço final do produto
            System.Console.Write("Digite o Preço de Final: ");
            double precoFinal = Convert.ToDouble(Console.ReadLine());            

            // Inserir a Data de Validade do Produto
            System.Console.Write("Digite a data de validade do produto: ");
            DateTime dataValidade = Convert.ToDateTime(Console.ReadLine());

            // Cadastrar Fornecedor

            System.Console.WriteLine("===== Cadastro do Fornecedor =====");
            
            // Inserir Nome do Fornecedor
            System.Console.Write("Digite o nome do produto: ");
            string nomeFornecedor = Console.ReadLine();

            // Inserir Endereço do Fornecedor
            System.Console.WriteLine("Digite o Endereço do Cliente (Rua, Cidade, Estado, CEP): ");
            string  endereço = Console.ReadLine();

            // Inserir Nome do Fornecedor
            System.Console.Write("Digite o nome do produto: ");
            string cpnj= Console.ReadLine();

            System.Console.WriteLine("Digite se é recorrente: ");
            bool recorrente = Convert.ToBoolean(Console.ReadLine());

            System.Console.WriteLine("Digite o desconte: ");
            double desconto = Convert.ToDouble(Console.ReadLine());

            Fornecedor fornecedor = new Fornecedor{
                Nome = nomeFornecedor,
                CNPJ = cpnj,
                Recorrente = recorrente,
                Desconto = desconto,
                Endereco = new Endereco{
                    Rua = endereço.Split(", ")[0],
                    Cidade = endereço.Split(", ")[1],
                    Estado = endereço.Split(", ")[2],
                    CEP = endereço.Split(", ")[3]
                }

            };

            Produto produto = new Produto
            {
                Nome = nome,
                Codigo = codigo,
                PrecoCusto = precoCusto,
                Apelido = apelido,
                Perecivel = perecivel,
                PrecoFinal = precoFinal,
                DataValidade = dataValidade,
                Fornecedor = fornecedor
            };

            produtos.Add(produto);
            
            estoque.Produtos = produtos.ToArray();

            System.Console.WriteLine("Produto Cadastrado com Sucesso!");            
        }

        private static void RegistrarVenda(List<Cliente> clientes, List<Produto> produtos, List<Venda> vendas)
        {
            System.Console.WriteLine("===== Cadastro de Venda =====");

            // Console.Clear();
            
            System.Console.WriteLine("===== Cadastro de Venda =====");
            System.Console.WriteLine("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();

            Cliente cliente = clientes.Find(c => c.CPF == cpf); // Find é o método que compara o atributo do objeto e retorna null ou o objeto  
            
            if (cliente == null)
            {
                System.Console.WriteLine("Cliente não encontrado!");
                return;
            }

            List<Produto> produtosVenda = new List<Produto>();

            while (true)
            {
                System.Console.WriteLine("Digite o código do produto");
                int codigo = Convert.ToInt32(Console.ReadLine());

                if (codigo == 0) break;

                Produto produto = produtos.Find(p => p.Codigo == codigo);
                if (produto != null)
                {
                    produtosVenda.Add(produto);
                    break;
                }
                else
                {
                    System.Console.WriteLine("Produto não encontrado");
                }
            }

            Venda venda  = new Venda
            {
                Produtos = produtosVenda.ToArray(),
                Data = DateTime.Now,
                Cliente = cliente,
                // Vendedor = new Vendedor,
                FormaPagamento = "Cartão",
                Parcelas = 3,
                // ValorTotal = venda.CalcularValorFinal(),
                ValorTotal = 0
            };
            venda.ValorTotal = venda.CalcularValorFinal(); // Aqui é chamado o método da classe venda

            vendas.Add(venda);
            System.Console.WriteLine("Venda Registrada com Sucesso");
        }


        private static void ConsultarEstoque(Estoque estoque)
        {
            // Console.Clear();
            System.Console.WriteLine("===== Consulta de Estoque =====");

            if (estoque.Produtos != null)
            {
                for(int i = 0; i < estoque.Produtos.Length; i++)
                {
                    System.Console.WriteLine("Nome: " + estoque.Produtos[i].Nome);
                    System.Console.WriteLine("Código: " + estoque.Produtos[i].Codigo);
                    System.Console.WriteLine("Preço de Custo: R$" + estoque.Produtos[i].PrecoCusto);
                    System.Console.WriteLine("Apelido: " + estoque.Produtos[i].Apelido);
                    System.Console.WriteLine();
                }
            } else
            {
                System.Console.WriteLine("Estoque Vazio");
            }
        }

        public static void GerarRelatorioVendas(List<Venda> vendas)
        {
            // Console.Clear();
            System.Console.WriteLine("===== Relatório de Vendas =====");
            if (vendas != null)
            {
                foreach (var venda in vendas)
                {
                    System.Console.WriteLine("Data: " + venda.Data);
                    System.Console.WriteLine("Nome do Cliente: " + venda.Cliente.Nome);
                    System.Console.WriteLine("Valor Total: " + venda.ValorTotal);
                    System.Console.WriteLine("Forma de Pagamento: " + venda.FormaPagamento);
                    System.Console.WriteLine("Parcelas: " + venda.Parcelas);
                }
            }
        }

    }
}