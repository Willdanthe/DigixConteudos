using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av3
{
    public class Executar
    {
        static void Teste(string[] args)
        {
            TipoA moto = new("Honda","Bis 125",300, 50.50,3);
            moto.CalcularLocDiaria();

            TipoB carro = new("Chevrolet","Corsa Classic",300, 50.50,3);
            carro.CalcularLocDiaria();
            
            
            TipoC caminhao = new("Volkswagen","710",300, 50.50,3);
            caminhao.CalcularLocDiaria();
        }
    }
}