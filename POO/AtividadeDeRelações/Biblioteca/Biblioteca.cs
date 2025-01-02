using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDeRelações.Biblioteca
{
    public class Biblioteca
    {
        public string Nome { get; set; }
        private Catalogo Catalogo;

        public Biblioteca(string nome)
        {
            this.Nome = nome;
            Catalogo = new Catalogo("Catalogo de Livros");
            
        }

        public void AdicionarLivro(Livro livro)
        {
            Catalogo.Adicionar(livro);
        }

        public void ConsultarTodos()
        {
            Catalogo.ConsultarLivros();
        }

        // if (op ==  2)
        // {
        //     produto.imprimirUm();
        // }




        
        
    }
}