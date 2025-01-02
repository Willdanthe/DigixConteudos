using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDeRelações.Biblioteca
{
    public class Livro
    {
        public string Titulo {get;set;}
        public string Autor {get;set;}
        public DateTime AnoPubli {get;set;}
        public int Quantidade {set;get;}

        public Livro(string titulo, string autor, DateTime anoPubli, int quantidade)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.AnoPubli = anoPubli;
            this.Quantidade = quantidade;
        }
    }
}