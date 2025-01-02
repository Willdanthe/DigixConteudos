using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class Cidade
    {
        public string Nome {get;set;}
        public Estado __estado;

        public Cidade(string nome, Estado estado)
        {
            Nome = nome;
            __estado = estado;
        }
    }
}