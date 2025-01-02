using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDeRelações.Biblioteca
{
    public class Exec
    {
        static void Main(string[] args)
        {
            RedeDeBibliotecas rede = new RedeDeBibliotecas();

            Biblioteca bibliotecaPrincipal = new Biblioteca("Principal");

            rede.AdicionarBiblioteca(bibliotecaPrincipal);

            Funcionario funcionario = new Funcionario("Rodrigo", "312321421421", "Estagiário");
            Leitor leitor = new Leitor("Rogerinho", "312321421421");

            Livro livro1 = new Livro("O nome do vendo", "Patrick Rothfuss",DateTime.Parse("21/06/2009"), 50);
            Livro livro2 = new Livro("Bíblia", "Profetas e Apóstolos",DateTime.Parse("01/01/0001"), 200);

            bibliotecaPrincipal.AdicionarLivro(livro1);
            bibliotecaPrincipal.AdicionarLivro(livro2);

            bibliotecaPrincipal.ConsultarTodos();

            System.Console.WriteLine();

            rede.ListarBibliotecas();
        }
    }
}