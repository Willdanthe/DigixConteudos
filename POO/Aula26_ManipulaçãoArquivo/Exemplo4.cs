using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula26_ManipulaçãoArquivo
{
    public class Exemplo4
    {
        static void Ex4(string[] args)
        {
            string inicioPath = @"C:\Users\willdanthealaman\Desktop\Teste1.txt";
            string finalPath = @"C:\Users\willdanthealaman\Desktop\Teste2.txt";

            try
            {
                string [] lines = File.ReadAllLines(inicioPath);

                using (StreamWriter sw = File.AppendText(finalPath))
                {
                    foreach (var item in lines)
                    {
                        sw.WriteLine(item.ToUpper()); // Escreve a linha em maiúsculo
                        sw.WriteLine(item.ToLower()); // Escreve a linha em minúsculo
                        sw.WriteLine(item.Reverse().ToArray());
                        sw.WriteLine(item.PadRight(2));
                    }


                }
            }
            catch (IOException e)
            {
                
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
        }

    }
}