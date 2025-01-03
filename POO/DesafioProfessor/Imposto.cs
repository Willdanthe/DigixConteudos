using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProfessor
{
    public class Imposto
    {
        public double TotalVendas { get; set; }
        public double TotalSalarios { get; set; }

        public double CalcularImpostoVendas()
        {
            return TotalSalarios * 0.1;
        }
        
        public double CalcularImpostoSalario()
        {
            return TotalSalarios * 0.2;
        }
        
        
    }
}