using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula26_ManipulaçãoArquivo
{
    public class Exemplo2
    {
        static void Ex2(string[] args)
        {
            
            string inicioPath = @"C:\Users\willdanthealaman\Desktop\Teste1.txt";


            // Isso é uma conversa com o sistema operacional que
            // não é gerenciado pelo cs
            FileStream fs = null; // Classe que Permite Leitura e escrita de arquivos, e é uma classe de baixo nível

            StreamReader sr = null; // Classe de manipulação de arquivo como a fs, mas é de alto nível

            try
            {
                fs = new FileStream(inicioPath, FileMode.Open); // Abre o Aqruivo
                sr = new StreamReader(fs);

                string line = sr.ReadLine();

                System.Console.WriteLine(line);

                while (line != null)
                {
                    line = sr.ReadLine();
                    System.Console.WriteLine(line.Trim());
                }
            }


            catch (IOException e)
            {
                
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
            finally
            {
                // Eu preciso fechar o arquivo, pois o sistema operacional não faz isso automaticamente
                if ( sr != null ) sr.Close();
                if ( fs != null ) fs.Close();
            }


        }
    }
}