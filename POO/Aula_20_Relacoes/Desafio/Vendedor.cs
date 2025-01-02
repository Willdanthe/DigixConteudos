using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class Vendedor : Funcionario
    {
        public EquipeVenda Equipe;
        public Vendedor(string nome, DateTime nascimento, string cpf, Endereco endereco, EquipeVenda equipe) : base(nome, nascimento, cpf, endereco)
        {
            Equipe = equipe;
        }

        public float GetSalario()
        {
            return 4520.45f;
        }
    }
}