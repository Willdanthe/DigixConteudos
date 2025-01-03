<<<<<<< HEAD
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
=======
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
>>>>>>> e9a3d52522c6db98556194ca31c6699e74b0529b
}