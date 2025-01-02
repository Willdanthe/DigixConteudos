using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{   // Vai ser agregado com o da esola, então vai ter relação
    // De agregação
    public class Professor
    {
        public string? Nome {get;set;}

        public Professor(string nome)
        {
            Nome = nome;
        }


        public void Ensinar()
        {
            System.Console.WriteLine("Ensinando Filosofia");
        }
    }
}
