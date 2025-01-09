using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_24_OO_Excecao.Desafio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            bool validacao = true;
            Account conta1 = new Account("Willdanthe", 900);
            do
            {
                System.Console.WriteLine("=--=--=--= Menu =--=--=--=");
                System.Console.WriteLine("[1] Dados da conta");
                System.Console.WriteLine("[2] Sacar Saldo");
                System.Console.WriteLine("[3] Depositar Saldo");
                System.Console.WriteLine("[4] Sair");

                int choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        System.Console.WriteLine(conta1.ToString());
                        break;
                    case 2:
                        conta1.Sacar();
                        break;
                    case 3:
                        conta1.Depositar();
                        break;
                    case 4:
                        validacao = false;
                        break;
                    default:
                        System.Console.WriteLine("Opção errada");
                        break;
                }

            } while (validacao);
        }
    }
}