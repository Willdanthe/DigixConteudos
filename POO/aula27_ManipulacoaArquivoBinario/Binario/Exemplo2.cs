using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula27_ManipulacoaArquivoBinario
{
    public class Exemplo2
    {
        static void Ex2(string[] args)
        {
            string filePath = "dados.bin";

            using(BinaryReader leitor = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                int inteiro = leitor.ReadInt32();
                double dãbou = leitor.ReadDouble();
                string texto = leitor.ReadString();

                System.Console.WriteLine($"Numero int do arquivo: {inteiro}");
                System.Console.WriteLine($"Numero int do arquivo: {dãbou}");
                System.Console.WriteLine($"Numero int do arquivo: {texto}");
            }

            System.Console.WriteLine("Arquivo lido...");

        }
    }
}