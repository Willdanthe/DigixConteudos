using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace Aula26_ManipulaçãoArquivo
{
    public class Exemplo1
    {
    static void Ex1(string[] args)
    {
        // File é uma classe estática que contém metodos
        // Para manipulação de arquivos

        string inicioPath =  @"C:\Users\willdanthealaman\Desktop\Teste1.txt";
        string finalFile = @"C:\Users\willdanthealaman\Desktop\Teste2.txt";

        try
        {
            // FileInfo fileInfo = new(inicioPath); // Cria um obj com referêcia de endereço
            // fileInfo.CopyTo(finalFile); // Copia o arquivo de oregem para o destino

            // Mostrar o que está escrito no arquivo do inicioPatch

            string[] lines = File.ReadAllLines(inicioPath);

            foreach (var item in lines) // Percorre todas as linhas
            {
                System.Console.WriteLine(item);                
            }
        }
        catch (IOException e) // Tratamento de erro especíico para manipular arquivo
        {
            System.Console.WriteLine("Ocorreu erro");
            System.Console.WriteLine(e.Message);
        }

    }
    }
}