using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Iterface
{
    public class Peixe : Animal, AnimalDeEstimacao
    {
        private string? __nome;

        public Peixe(string nome) : base(0)
        {
            this.__nome = nome;
        }

        public string GetNome()
        {
            return __nome;
        }

        public void SetNome(string nome)
        {
            this.__nome = nome;
        }

        public void Brinca()
        {
            System.Console.WriteLine("Brincando com bolhas!");
        }

        public override void Come()
        {
            System.Console.WriteLine("Comendo algas");
        }
    }
}