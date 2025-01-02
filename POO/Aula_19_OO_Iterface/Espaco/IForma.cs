using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Iterface
{
    public interface IForma
    {
        double CalcularArea();
        double CalcularPerimetro();

        void ExibirInformacoes()
        {
            Console.WriteLine($"Área: {CalcularArea()}");
            Console.WriteLine($"Perimetro: {CalcularPerimetro()}");
        }
    }
}