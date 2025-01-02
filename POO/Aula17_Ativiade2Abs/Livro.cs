using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_Ativiade2Abs
{
    public class Livro : Produto
    {
        public string Autor;
        public long Isbn;

        public Livro(int codigo, double preco, string autor, long isbn) : base(codigo, preco)
        {
            this.Autor = autor;
            this.Isbn = isbn;
        }

        public override void SetCodigo(int codigo)
        {
            this.Codigo = codigo;
        }
        public override void SetPreco(double preco)
        {
            this.Preco = preco;
        }
        public override int GetCodigo()
        {
            return this.Codigo;
        }

        public override double GetPreco()
        {
            return this.Preco;
        }

        // public override void AtualizarPreco(double preco)
        // {
        //     this.Preco = preco;
        // }

        public void SetAutor(string autor)
        {
            this.Autor = autor;
        }

        public void SetIsbn(long isbn)
        {
            this.Isbn = isbn;
        }


    }
}