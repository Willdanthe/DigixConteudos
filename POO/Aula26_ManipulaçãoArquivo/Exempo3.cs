using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Aula26_ManipulaçãoArquivo
{
    public class Exempo3
    {
        static void Ex3(string[] args)
        {
            string inicioPath = @"C:\Users\willdanthealaman\Desktop\Teste1.txt";

            try
            {
                // Abre e fecha automaticamente
                using (FileStream fs = new FileStream(inicioPath, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        System.Console.WriteLine(line);

                        while (line != null)
                        {
                            line = sr.ReadLine();
                            System.Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu um erro.");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}