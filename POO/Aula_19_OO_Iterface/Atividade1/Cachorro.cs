using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Iterface
{
    public class Cachorro : Animal, AnimalDeEstimacao
    {
        private string __nome;

        // COnstrutor
        public Cachorro(string nome) : base(4)
        {
            this.__nome = nome;
        }

        // Funções
        public void SetNome(string nome)
        {
            this.__nome = nome;
        }
        public string GetNome()
        {
            return this.__nome;
        }

        public void Brinca()
        {
            System.Console.WriteLine($"O cachorro {__nome} está brincando com a bola!");
        }

        public override void Come()
        {
            System.Console.WriteLine("Comendo Ração");
        }

        // public override void Caminha()
        // {
        //     System.Console.WriteLine("Caminha com 4 patas");
        // }
    }
}