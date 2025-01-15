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
    public class Exemplo3Encripty
    {
        static void Ex3(string[] args)
        {
            string original = "arquivo_original.txt";
            string password = "MinhaSenhaSegura";
            
            string encriptyFile = "arquivo_encriptado.txt";
            string decrytFile = "arquivo_desencripitado.txt";

            //Criar o arquivo de Texto simples

            File.WriteAllText(original,"Este é o conteudo do arquivo original");
            
            System.Console.WriteLine("Arquivo original Criado");

            // Método para encriptar

            EncryptFile(original, encriptyFile, password);
            System.Console.WriteLine("Arquivo encriptado Criado");


            DesencryptFile(encriptyFile, decrytFile, password);
            System.Console.WriteLine("Arquivo desencriptado Criado");

        }


        static public void EncryptFile(string original, string encriptar, string senha)
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
    
         static public void DesencryptFile(string encriptar, string desencriptar, string senha)
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

