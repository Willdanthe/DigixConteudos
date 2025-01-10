using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_09_01
{
    public class ATM 
    {
        public Banco Banco {get;set;}

        public ATM(Banco banco)
        {
            this.Banco = banco;
        }


        public bool Verificacao(string cpf, int senha)
        {
            Conta validacao = Banco.Contas.Find(cont => cont.Usuario.CPF == cpf);
            
            if (validacao == null)
            {
                throw new DomainException("Erro de Login: CPF ou Senha inválidos.");
                return false;
            }
            else
            {
                System.Console.WriteLine("Entrando...");
                return true;
            }
        }
    }
}