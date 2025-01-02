using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_POO
{
    public class Javali : Animal
    {
        public bool Selvagem;

        // Método Construtor
        public Javali(bool vivo, bool selvagem) : base(vivo)
        {
            this.Selvagem = selvagem;
        }

        public int GetVelocidadeMaxima()
        {
            return 40;
        }

        public void SetSelvagem(bool s)
        {
            this.Selvagem = s;
        }


    }
}