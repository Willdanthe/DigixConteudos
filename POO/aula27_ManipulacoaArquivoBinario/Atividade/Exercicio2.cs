using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net.Security;
using System.Text;
using System.Security.Cryptography;

namespace aula27_ManipulacoaArquivoBinario
{
    public class Exercicio2
    {
        static void Main(string[] args)
        {
            string arquivoCriado = @"C:\Users\willdanthealaman\Documents\GitHub\TesteDemais\POO\aula27_ManipulacoaArquivoBinario\Atividade\produtos.csv";
            string diretorio = "out2";
            string pasta = Path.Combine(diretorio, "summary.csv");

            try
            {
                // Criar uma pasta "out" se não existia
                if (!Directory.Exists(pasta))
                {
                    Directory.CreateDirectory(pasta);
                }

                var lines = File.ReadAllLines(arquivoCriado);
                var summaryLines = new List<string>();

                foreach (var line in lines)
                {
                    var campos = line.Split(',');
                    System.Console.WriteLine("Linha "+ line);

                    if (campos.Length != 3)
                    {
                        System.Console.WriteLine("Linha ignorada: " + line);
                    }
                    
                    string nome = campos[0];
                    if (!double.TryParse(campos[1], out double preco))
                    {
                        System.Console.WriteLine("Preço Inválido:" + campos[1]);
                    }
                    
                    if (!double.TryParse(campos[2], out double quantidade))
                    {
                        System.Console.WriteLine("Preço Inválido:" + campos[2]);
                    }

                    double total = preco * quantidade;

                    summaryLines.Add(nome + "," + total.ToString());
                }

                File.WriteAllLines(pasta, summaryLines);
                System.Console.WriteLine("Arquivo Summary.csv criado com sucesso");

                string arquivoEncriptado = pasta + ".enc";
                string senha = "123456";
                Encriptar(pasta, arquivoCriado, senha);
                System.Console.WriteLine("Arquivo Encriptado criado com sucesso");
                
                string arquivoDesencriptado = pasta + ".enc";
                Desencriptar(pasta, arquivoCriado, senha);

                System.Console.WriteLine("Arquivo Encriptado criado com sucesso");




            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        static public void Encriptar(string original, string encriptar, string senha)
        {
            // O PadRight, ele precisa de pelo menos 32 caracteres
            // O Substringgarante que ele tenha no máximo 32 caracteres examente
            byte[] key = Encoding.UTF8.GetBytes(senha.PadRight(32).Substring(0,32));
            // iv é referente o vetor de inicialização
            byte[] iv = Encoding.UTF8.GetBytes(senha.PadRight(16).Substring(0,16));

            using(Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using(FileStream inputFileStream = new FileStream(original, FileMode.Open))
                using(FileStream outputFileStream = new FileStream(encriptar, FileMode.Create))
                using(CryptoStream cryptoStream = new CryptoStream(outputFileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    inputFileStream.CopyTo(cryptoStream); // Toda a informação que estiver aqui vai ser passado para o arquivo cryptoStream
                }

            }
        }
    
         static public void Desencriptar(string encriptar, string desencriptar, string senha)
        {
            // O PadRight, ele precisa de pelo menos 32 caracteres
            // O Substringgarante que ele tenha no máximo 32 caracteres examente
            byte[] key = Encoding.UTF8.GetBytes(senha.PadRight(32).Substring(0,32));
            // iv é referente o vetor de inicialização
            byte[] iv = Encoding.UTF8.GetBytes(senha.PadRight(16).Substring(0,16));
            using(Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using(FileStream inputFileStream = new FileStream(encriptar, FileMode.Open))
                using(FileStream  outputFileStream = new FileStream(desencriptar, FileMode.Open))
                using(CryptoStream cryptoStream = new CryptoStream(inputFileStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    cryptoStream.CopyTo(outputFileStream); // Toda a informação que estiver aqui vai ser passado para o arquivo cryptoStream
                }

            }
        }

    }
}