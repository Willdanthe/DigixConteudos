using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{   // Classe aluno vai ser fundamental para
    // Então vai ter relacao de Composção
    public class Aluno
    {
        public string? Nome {get;set;}

        public Aluno(string nome)
        {
            Nome = nome;
        }

        public void MostarInfo()
        {
            Console.WriteLine($"Nome: {Nome}");
            
        }
    }
}