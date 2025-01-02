using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_POO
{
    public class Cobra : Animal
    {
        public bool Venenosa;

        // Método Construtor
        public Cobra(bool vivo, bool venenosa) : base(vivo)
        {
            this.Venenosa = venenosa;
        }

        // Imprime do que se alimenta
        public void Alimento(string a)
        {
            System.Console.WriteLine($"A cobra se alimenta de {a}");
        }


        // Seta se é venenosa
        public void SetVenenosa(bool v)
        {
            this.Venenosa = v;
        }
    }
}