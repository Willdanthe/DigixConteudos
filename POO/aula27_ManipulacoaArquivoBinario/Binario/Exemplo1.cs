using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula27_ManipulacoaArquivoBinario
{
    public class Exemplo1
    {
        static void Ex1(string[] args)
        {
            // Aqui foi gerado os dados do
            // Arquivo binário
            

            string filePath2 = "dados.bin"; // Caminho do arquivo

            using(BinaryWriter writer = new BinaryWriter(File.Open(filePath2, FileMode.Create)))
            {
                writer.Write(123);
                writer.Write(145.6513);
                writer.Write("HelloWorld");
            }

            System.Console.WriteLine("Dados gravados no: " + filePath2);
        }
    }
}