using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Iterface
{
    public interface AnimalDeEstimacao
    {
        string GetNome();

        void SetNome(string nome);

        void Brinca();
    }
}