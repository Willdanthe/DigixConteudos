using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_Ativiade2Abs
{
    public class CompactDisc : Produto
    {
        public string Artista;
        public string Gravadora;

        public CompactDisc(int codigo, double preco, string artista, string gravadora) : base(codigo,preco)
        {
            this.Artista = artista;
            this.Gravadora = gravadora;
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

        public void SetArtista(string artista)
        {
            this.Artista = artista;
        }
        public void SetGravadora(string gravadora)
        {
            this.Gravadora = gravadora;
        }
        public string GetGravadora()
        {
            return this.Gravadora;
        }
        public string GetArtista()
        {
            return this.Artista;
        }
    }
}