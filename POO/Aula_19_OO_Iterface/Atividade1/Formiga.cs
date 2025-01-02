using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Iterface
{
    public class Formiga : Animal
    {
        public Formiga():base(6){}

        public override void Come()
        {
            System.Console.WriteLine("Formiga come Folha!");   
        }
    }
}