using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno
{
    public class Executar
    {
        static void Teste(string[] args)
        {
            Homem homem = new Homem();
            homem.ObterDescrição();
            System.Console.WriteLine();
            
            Cachorro cachorro = new Cachorro();
            cachorro.ObterDescrição();
            System.Console.WriteLine();

            Mosca mosca = new Mosca();
            mosca.ObterDescrição();
            System.Console.WriteLine();            
        }
    }
}