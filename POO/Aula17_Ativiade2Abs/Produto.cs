using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17_Ativiade2Abs
{
    public abstract class Produto
    {
        public int Codigo;
        public double Preco;

        public Produto(int codigo, double preco)
        {
            this.Preco = preco;
            this.Codigo = codigo;
        }

        public abstract void SetCodigo(int codigo);

        public abstract int GetCodigo();

        public abstract void SetPreco(double preco);

        public abstract double GetPreco();
        // public abstract void AtualizarPreco();
    }
}