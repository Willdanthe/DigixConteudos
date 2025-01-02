using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_AtiviadeAbstrata
{
    public class Executar
    {
        static void Main(string[] args)
        {    
            Comissionado comissionado = new Comissionado("Carlos", "Roberto", "123.123.123-01", 1450.67, 1.03);
            
            comissionado.ImprimirDados();
            System.Console.WriteLine();
            Horista horista = new Horista("Igor", "3K","123.123.123-02", 450.50, 20);

            horista.ImprimirDados();
            System.Console.WriteLine();
            Assalariado assalariado = new Assalariado("Willdanthê", "Amorim","123.123.123-023", 120.45);

            assalariado.ImprimirDados();
        }    
    }
}