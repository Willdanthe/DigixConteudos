using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula26_ManipulaçãoArquivo
{
    public class Exemplo6
    {
        static void Main(string[] args)
        {
            string inicioPath = @"C:\Users\willdanthealaman\Desktop\Teste\Teste1.txt";

            System.Console.WriteLine("Directory Separator Char " + Path.DirectorySeparatorChar);
            System.Console.WriteLine("Separador de caminho: " + Path.PathSeparator);
            System.Console.WriteLine("Retorna o diretório do arquivo: " + Path.GetDirectoryName(inicioPath));
            System.Console.WriteLine("Retorna o nome do arqruivo: " + Path.GetFileName(inicioPath));
            System.Console.WriteLine("Retorna o nome do arquivo sem extenção: " + Path.GetFileNameWithoutExtension(inicioPath));
            System.Console.WriteLine("Retorna Somente a Extensão do arquivo: " + Path.GetExtension(inicioPath));
        }
    }
}