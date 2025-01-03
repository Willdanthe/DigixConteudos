using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av2
{
    public class CasaSobrado : Casa
    {
        public int NumAndares {get;set;}

        public CasaSobrado(double metragem, string endereço, Engenheiro engenheiro, bool condominio, string nome, int numAndares) : base(metragem, endereço,engenheiro, condominio, nome)
        {
            this.NumAndares = numAndares;
        }

    }
}