using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDeRelações.Biblioteca
{
    public class RedeDeBibliotecas
    {
        public string? Nome { get; set; }

        public List<Biblioteca> bibliotecas {get;set;} = [];
        


        public void AdicionarBiblioteca(Biblioteca biblioteca)
    {
        bibliotecas.Add(biblioteca);
    }

    public void ListarBibliotecas()
    {
        Console.WriteLine("Bibliotecas na rede:");
        foreach (var biblioteca in bibliotecas)
        {
            Console.WriteLine(biblioteca.Nome);
        }
    }
        
    }
}