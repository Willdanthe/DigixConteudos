using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selo
{
    public class Instrutor : Coordenador
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine("Salário: "+ salario*1.3);
        }
        

        // Esse método não pode ser sobrescrito pois tem sealed no método herdado do coordenador
        // public override void Trabalhar() {}
    }
}