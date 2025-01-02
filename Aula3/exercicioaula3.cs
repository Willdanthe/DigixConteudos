using System;

namespace Atividade
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            // Entrada do Valor
            Console.WriteLine("Digite um valor a ser investido: ");
            double initialValue = Convert.ToDouble(Console.ReadLine());
            
            // Entrada do Ano
            Console.WriteLine("Tempo do investimento (Em anos): ");
            double year = Convert.ToDouble(Console.ReadLine());
            
            int choose;
            double finalValue;

            /* Validação básica apenas com Int
            Poupança: 3% ao ano
            Renda Fixa: 5% ao ano
            Ações: Calculo de 10%, mas com uma chance perda de 5%(usar estrutura condicional)
            */

            while (1==1)
            {

                Console.WriteLine("Digite uma opção:\n[1]Poupança\n[2]Renda Fixa\n[3]Ações");
                choose = Convert.ToInt32(Console.ReadLine());
                
                
                 if (choose == 1)
                 {
                    finalValue = ((initialValue* 0.03) + initialValue)*year;
                    Console.WriteLine($"Em {year} anos, você vai ficar com o saldo de R${finalValue:F2}");
                 }
                else if (choose == 2)
                {
                    finalValue = ((initialValue* 0.05) + initialValue)*year;
                    Console.WriteLine($"Em {year} anos, você vai ficar com o saldo de R${finalValue:F2}");
                }
                else if (choose == 3)
                {
                    finalValue = ((initialValue* 0.1) + initialValue)*year;
                    Console.WriteLine($"Em {year} anos, você vai ficar com o saldo de R${finalValue:F2}");
                    Console.WriteLine($"Mas também pode perder R${initialValue*0.05:F2}");
                    
                }

                switch (choose)
                {
                    case 1:
                    finalValue = ((initialValue* 0.03) + initialValue)*year;
                    Console.WriteLine($"Em {year} anos, você vai ficar com o saldo de R${finalValue:F2}");
                    break;
                    
                    case 2:
                    finalValue = ((initialValue* 0.05) + initialValue)*year;
                    Console.WriteLine($"Em {year} anos, você vai ficar com o saldo de R${finalValue:F2}");
                    break;

                    case 3:
                    finalValue = ((initialValue* 0.1) + initialValue)*year;
                    Console.WriteLine($"Em {year} anos, você vai ficar com o saldo de R${finalValue:F2}");
                    Console.WriteLine($"Mas também pode perder R${initialValue*0.05:F2}");
                    break;
                }





            }

            


        }
    }
}