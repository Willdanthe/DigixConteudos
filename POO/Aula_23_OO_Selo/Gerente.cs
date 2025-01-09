using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selo
{
    public sealed class Gerente : Funcionario // Sealed é um método selado que não pode ser herdado
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine($"Salario Base:" + salario * 1.5);
        }

        public override void Trabalhar()
        {
            System.Console.WriteLine("Gerenciando...");
        }

    }
}