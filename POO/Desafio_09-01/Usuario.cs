using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_09_01
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string CPF { get; }
        public string Endereco { get;set; }
        public DateTime Ddn { get; set; } // Data de Nascimento

        public string NumCartao { get; }

        private int Senha;

        public Usuario(string nome, string cpf, string endereco, DateTime dataDeNascimento, int senha)
        {

            Random r = new Random();
            // Gerador do número de Cartão
            for(int j = 0; j < 3; j++){
                for (int i = 0; i < 4; i++)
                {
                    string cache = Convert.ToString(r.Next(0,10));
                    this.NumCartao = cache+" ";
                }
            }

            this.Nome = nome;
            this.CPF = cpf;
            this.Endereco = endereco;
            this.Ddn = dataDeNascimento;
            this.Senha = senha;
        }

        public int VerificarSenha()
        {
            var a = 1;
            return this.Senha;
        }
        
        
    }
}