using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av2
{
    public class CasaTerrea : Casa
    {
        public CasaTerrea(double metragem, string endereço, Engenheiro engenheiro, bool condominio, string nome) : base(metragem, endereço,engenheiro, condominio, nome)
        {

        }
    }
}