using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade1Aula18
{
    public class Executar
    {

        static void Main(string[] args)
        {
            Banco conta1;
            double valor;

            System.Console.WriteLine("Cadastro\nNome: ");
            string? nome = Convert.ToString(Console.ReadLine());

            Random r = new Random();
            int aleatorio = r.Next(0,10000);

            Console.WriteLine("Quer fazer um depóstio incial? [s/n]");
            char? answer = Convert.ToChar(Console.ReadLine());
            if ( answer == 's' || answer == 'S')
            {
                System.Console.WriteLine("Deposite um valor: ");
                valor = Convert.ToDouble(Console.ReadLine());
                conta1 = new Banco(nome,aleatorio,valor);
            }
            else
            {
                conta1 = new Banco(nome,aleatorio);

            }

            // conta1.Sacar(200);
            // conta1.Depositar(2205);
            // System.Console.WriteLine(conta1.ToString());
            // System.Console.WriteLine(conta1);

            // TRATAMENTO PARA O MENO
            while (true)
            {
                // MENU
                System.Console.WriteLine("Menu\n[1]Depositar\n[2]Sacar\n[3]Ver Saldo\n[4]Informações da Conta\n[5]Sair");
                int choose = Convert.ToInt32(Console.ReadLine());

                // AÇÃO
                if (choose == 1 || choose == 2 || choose == 3 || choose == 4)
                {
                    // EVENTO DO MENU
                    switch (choose)
                    {
                        case 1: // Depositar
                            System.Console.WriteLine("\nQual valor deseja Depositar: \n");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conta1.Depositar(valor);
                            break;

                        case 2: // Sacar
                            System.Console.WriteLine("\nQual valor deseja Sacar: \n");
                            valor = Convert.ToDouble(Console.ReadLine());
                            conta1.Sacar(valor);
                            break;
                        case 3: // Ver Saldo (Ficou redundante com a opção quatro, tirar depois)
                            System.Console.WriteLine($"\nSaldo: {conta1.Saldo}");
                            break;
                        case 4: // Ver informações da conta
                            System.Console.WriteLine();
                            System.Console.WriteLine(conta1);
                            break;
                    }
                }

                else if (choose == 5) //Sair do Sistema
                {
                    break;
                }
                
                else //Tratamento de número errado
                {
                    System.Console.WriteLine("\nEscolha errada!\n");
                    continue;
                }
                

            }

            System.Console.WriteLine("Obrigado por utilizar nosso sistema! :)");
        }
    }
}