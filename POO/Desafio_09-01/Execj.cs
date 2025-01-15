<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace Desafio_09_01
{
    public class Executar
    {
        
        static void Main(string[] args)
        {
            // Objetos Pré-setados
            Usuario usuarioGerente = new Usuario("Willdanthê", "54565231575", "Rua atchum, 444, Jhin", DateTime.Parse("27/08/2004") ,"4444");
            Usuario usuarioTeste = new("Will", "111", "Rua atchum, 444, Jhin", DateTime.Parse("27/08/2004") ,"4444");
            Usuario userdefault = new("Zilda", "222", "Rua atchum, 444, Jhincd", DateTime.Parse("27/08/2004") ,"4444");
            Conta gerente = new Conta(usuarioGerente, EnumTipoConta.Gerente);
            ContaCorrente contaTeste = new(usuarioTeste,EnumTipoConta.Corrente);
            ContaCorrente contaTeste2 = new(userdefault,EnumTipoConta.Corrente);
            Banco nobanco = new Banco("NoBanco",1);

            nobanco.Contas.Add(contaTeste);
            nobanco.Contas.Add(contaTeste2);
            nobanco.Contas.Add(gerente);

            ATM atm = new ATM(nobanco);
            bool validacao = true;

            while (validacao){
                try{
                
                    System.Console.WriteLine("==--==--==--== Nobanco ==--==--==--==");
                    System.Console.WriteLine("Seja bem-vindo(a) ao Nobanco");
                    System.Console.WriteLine("[1]Login \n[2]Cadastrar \n[3]Listar Contas \n[4]Sair");
                
                    int op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                    case 1: // Login
                        System.Console.Write("Cpf: ");
                        string cpf = Console.ReadLine();

                        System.Console.Write("senha: ");
                        string senha = Console.ReadLine();
                        
                        atm.OperecaoDeConta(cpf,senha);
                        break;

                    case 2: // Cadastrar
                        System.Console.WriteLine("[1]Conta Corrente\n[2]Conta Poupança");
                        op = Convert.ToInt32(Console.ReadLine());
                        if (op == 1)
                        {
                            System.Console.WriteLine("Entrou1");
                            nobanco.CriarConta(EnumTipoConta.Corrente);
                            break;
                        }
                        else if (op == 2)
                        {
                            System.Console.WriteLine("Entrou2");
                            nobanco.CriarConta(EnumTipoConta.Poupanca);
                            break;
                        } 
                        else if (op == -1)
                        {
                            nobanco.CriarConta(EnumTipoConta.Gerente);
                            break;
                        }
                        else
                        {
                            
                            break;
                        }
                        default:
                        
                            break;
                            
                    case 3:
                        nobanco.ListarContas();
                        GerarExcel(new List<Conta> {contaTeste, contaTeste2});
                        break;
                    case 4:
                        System.Console.WriteLine("Saindo...");
                        validacao = false;
                        break;
                    }
                    
                }catch (FormatException e)
                {
                    System.Console.WriteLine("Erro de entrada: Por favor, apenas números!");
                }

            } 
                
        } 

        public static void GerarExcel(List<Conta> contas)
        {
            // Geralção Excel: Tem que instalar a biblioteca ClosedXML
            // dotnet add package ClosedXML -> Comando para baixar a biblioteca
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.AddWorksheet("Contas Bancarias");

                // Cabeçário Excel
                worksheet.Cell(1,1).Value = "Numero da Conta";
                worksheet.Cell(1,2).Value = "Nome do Cliente";
                worksheet.Cell(1,3).Value = "Tipo Conta";
                worksheet.Cell(1,4).Value = "Saldo";
                // Cabeçário Excel

                int row = 2;
                
                foreach (var item in contas)
                {
                    worksheet.Cell(row,1).Value = item.IdConta;
                    worksheet.Cell(row,2).Value = item.Usuario.Nome;
                    worksheet.Cell(row,3).Value = item.TipoConta.ToString();
                    worksheet.Cell(row,4).Value = item.Saldo;
                    row++;
                }

                workbook.SaveAs("ContasBancarias.xlsx");
                System.Console.WriteLine("Arquivo gerado com sucesso!");
                
                

                


            }
        }
}
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_09_01
{
    public class Executar
    {
        
        static void Main(string[] args)
        {
            // Objetos Pré-setados
            Usuario usuarioGerente = new Usuario("Willdanthê", "54565231575", "Rua atchum, 444, Jhin", DateTime.Parse("27/08/2004") ,"4444");
            Usuario usuarioTeste = new("Will", "111", "Rua atchum, 444, Jhin", DateTime.Parse("27/08/2004") ,"4444");
            Usuario userdefault = new("Zilda", "222", "Rua atchum, 444, Jhincd", DateTime.Parse("27/08/2004") ,"4444");
            Conta gerente = new Conta(usuarioGerente, EnumTipoConta.Gerente);
            ContaCorrente contaTeste = new(usuarioTeste,EnumTipoConta.Corrente);
            ContaCorrente contaTeste2 = new(userdefault,EnumTipoConta.Corrente);
            Banco nobanco = new Banco("NoBanco",1);

            nobanco.Contas.Add(contaTeste);
            nobanco.Contas.Add(contaTeste2);
            nobanco.Contas.Add(gerente);

            ATM atm = new ATM(nobanco);
            bool validacao = true;

            while (validacao){
                try{
                
                    System.Console.WriteLine("==--==--==--== Nobanco ==--==--==--==");
                    System.Console.WriteLine("Seja bem-vindo(a) ao Nobanco");
                    System.Console.WriteLine("[1]Login \n[2]Cadastrar \n[3]Listar Contas \n[4]Sair");
                
                    int op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                    case 1: // Login
                        System.Console.Write("Cpf: ");
                        string cpf = Console.ReadLine();

                        System.Console.Write("senha: ");
                        string senha = Console.ReadLine();
                        
                        atm.OperecaoDeConta(cpf,senha);
                        break;

                    case 2: // Cadastrar
                        System.Console.WriteLine("[1]Conta Corrente\n[2]Conta Poupança");
                        op = Convert.ToInt32(Console.ReadLine());
                        if (op == 1)
                        {
                            System.Console.WriteLine("Entrou1");
                            nobanco.CriarConta(EnumTipoConta.Corrente);
                            break;
                        }
                        else if (op == 2)
                        {
                            System.Console.WriteLine("Entrou2");
                            nobanco.CriarConta(EnumTipoConta.Poupanca);
                            break;
                        } 
                        else if (op == -1)
                        {
                            nobanco.CriarConta(EnumTipoConta.Gerente);
                            break;
                        }
                        else
                        {
                            
                            break;
                        }
                        default:
                        
                            break;
                            
                    case 3:
                        nobanco.ListarContas();
                        break;
                    case 4:
                        System.Console.WriteLine("Saindo...");
                        validacao = false;
                        break;
                    }
                    
                }catch (FormatException e)
                {
                    System.Console.WriteLine("Erro de entrada: Por favor, apenas números!");
                }

                
        } 
    }
}
>>>>>>> 38dd9c39b819aae2370b2f62b5cbbf3eefa22dad
}