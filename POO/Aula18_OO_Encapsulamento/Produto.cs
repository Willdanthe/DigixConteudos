using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula18_OO_Encapsulamento
{
    public class Produto
    {
        // private string _nome; //Convenção de nomen nomenclatura do C# quando o atributo é privado: _nome

        public string Nome {get; set;} //Propriedade que representa um atributo privado
        private double _preco;
        private int _quantidade;

        // Construtor padrão, que instancia mesmo quando não colcoado
        // public Produto()
        // {

        // }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            this._preco = preco;
        }

        //  Reutilizando contrutor dentro de outro construtor
        public Produto(string nome, double preco, int quantidade) : this(nome,preco)
        {
            this._quantidade = quantidade;
        }



        // =-=-=-=-=--===-=-=GETTER E SETTER INÍCIO=-=-=-=-=-=-=-=
        // public string GetNome()
        // {
        //     return _nome;
        // }

        // public void SetNome(string novoNome)
        // {
        //     if(novoNome != null && novoNome.Length > 1)
        //     {
        //         _nome = novoNome;
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Erro ao colocar o nome!");
        //     }
        // }

        // public string Nome
        // {
        //     get 
        //     {
        //         return _nome; 
        //     }
        //     set
        //     {
        //         if (value != null && value.Length > 1)
        //         {
        //             _nome = value;
        //         }
        //     }
        // }

        public double Preco
        {
            get
            {
                return _preco;
            }
            set
            {
                if (value > 0 && value < 100000)
                {
                    _preco = value;
                }
            }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
            set
            {
                if (value > 0 && value < 20)
                {
                    _quantidade = value;
                }
            }
        }



        // public double GetPreco()
        // {
        //     return _preco;
        // }

        // public void SetPreco(double novoPreco)
        // {
        //     if (novoPreco > 0 && _preco < 100000)
        //     {
        //         _preco = novoPreco;
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Preço inválido!");
        //     }
        // }

        // public int GetQuantidade()
        // {
        //     return _quantidade;
        // }

        // public void SetQuantidade(int novaQuantidade)
        // {
        //     if (novaQuantidade > 0 && novaQuantidade < 20)
        //     {
        //         _quantidade = novaQuantidade;
        //     }
        //     else
        //     {
        //         System.Console.WriteLine("Quantidade não permitida!");
        //     }
        // }
        //GETTER E SETTER FIM


        //Função que adiciona quantidade de produtos
        public void adicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            // get {return _preco * _quantidade};
            return _preco * _quantidade;
        }

        // Função ToString
        public override string ToString()
        {
            return Nome + ", $" + _preco.ToString("F2") + " , " + _quantidade + " unidades, Total: $ " +ValorTotalEmEstoque().ToString("F2")    ;
        }
    }

}