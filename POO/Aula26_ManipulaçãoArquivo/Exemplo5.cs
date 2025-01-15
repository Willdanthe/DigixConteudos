using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula26_ManipulaçãoArquivo
{
    public class Exemplo5
    {
        static void Ex5(string[] args)
        {
            string inicioPath = @"C:\Users\willdanthealaman\Desktop\Teste";

            string finalPath = @"C:\Users\willdanthealaman\Desktop\Teste";

            try
            {
                // // Directory é uma classe estática que permite a manipulação dos diretórios
                // // EnumerateDirectories está listando os diretórios/pastas
                // //AllDirectories define a busca de todos os diretórios

                // IEnumerable<string> pastas = Directory.EnumerateDirectories(inicioPath, "*.*", SearchOption.AllDirectories);

                // // Will comentário: Ele pega o caminho das pastas e coloca na variavel pasta como se fosse uma lista
                // System.Console.WriteLine("Pastas:");

                // foreach (string item in pastas)
                // {
                //     System.Console.WriteLine(item);
                // }





                // Inumerar os arquivos
                // IEnumerable<string> arquivos = Directory.EnumerateFiles(inicioPath, "*.*", SearchOption.AllDirectories);

                // // E para Inumerar tudo de uma vez a gente coloca Director.EnumerateFileSystemEntries

                // foreach (string item in arquivos)
                // {
                //     System.Console.WriteLine(item);
                // }



                // Criar uma pasta
                // Directory.CreateDirectory(inicioPath + @"\teste2");

                // Deletar uma pasta
                // Directory.Delete(inicioPath + @"\teste2");

                // Verificar se a pasta existe
                // bool existe = Directory.Exists(inicioPath + @"\NovavoN");
                // System.Console.WriteLine("A pasta existe: " + existe);
            
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Ocorreu erro");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}