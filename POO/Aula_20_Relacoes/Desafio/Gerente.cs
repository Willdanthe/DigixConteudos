using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, DateTime nascimento, string cpf, Endereco endereco) : base(nome, nascimento, cpf, endereco)
        {

        }

        public void GetSalario(string nome)
        {
            System.Console.WriteLine($"Salário do Gerente {nome}: R$5604.45");
        }
    }
}