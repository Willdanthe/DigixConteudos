using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDeRelações.Biblioteca
{
    public class Catalogo
    {
        public string Nome {get;set;} // Ficção por exemplo
        public List<Livro> Livros {get;set;}

        // Construtor
        public Catalogo(string nome)
        {
            this.Nome = nome;
            Livros = new List<Livro>();
        }

        // Metodos
        public void Adicionar(Livro livro)
        {
            Livros.Add(livro);
        }

        public void ConsultarLivros()
        {
            foreach (var item in Livros)
            {
                System.Console.WriteLine($"Titulo: {item.Titulo}   Autor: {item.Autor}    Ano de Publicação: {item.AnoPubli} Quantidade: {item.Quantidade}");
            }
        }
    }
}