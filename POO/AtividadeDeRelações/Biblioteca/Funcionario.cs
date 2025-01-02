using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace AtividadeDeRelações.Biblioteca
{
    public class Funcionario : Usuarios
    {
        public string Cargo {get;set;}

        public Funcionario(string nome, string cpf, string cargo) : base(nome,cpf)
        {
            this.Cargo = cargo;
        }

        public void AdicionarLivro(Catalogo catalogo, Livro livro)
        {
            // Catalogo.Add(livro);
        }

        public void Emprestimo(Livro livro, Leitor leitor)
        {
            
        }

    }
}