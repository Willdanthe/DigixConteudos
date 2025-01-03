using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Animal homem = new Homem();
            homem.ObterDescrição();
            System.Console.WriteLine();
            
            Animal cachorro = new Cachorro();
            cachorro.ObterDescrição();
            System.Console.WriteLine();

            Animal mosca = new Mosca();
            mosca.ObterDescrição();
            System.Console.WriteLine();            
        }
    }
}