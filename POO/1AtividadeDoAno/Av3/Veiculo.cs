using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av3
{
    public abstract class Veiculo
    {
        protected string Marca {get;set;}

        public Veiculo(string marca)
        {
            this.Marca = marca;
        }

        public abstract void CalcularLocDiaria();

    }
}