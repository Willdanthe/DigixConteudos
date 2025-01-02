using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Iterface
{
    public interface IPagamento
    {
        void RealizarPagamento(double valor);

        void ExibirComprovante();
    }
}