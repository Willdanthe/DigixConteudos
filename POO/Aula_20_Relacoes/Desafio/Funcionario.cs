using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class Funcionario
    {
        private object value;

        public string Nome { get; }
        public DateTime Nascimento { get; }
        public string CPF {get;}
        public Endereco __endereco { get; } 
        
        public Funcionario(string nome, DateTime nascimento, string cpf, Endereco endereco)
        {
            Nome = nome;
            Nascimento = nascimento;
            CPF = cpf;
            __endereco = endereco;
        }
    }
}