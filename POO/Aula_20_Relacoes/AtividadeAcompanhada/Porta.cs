using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class Porta
    {
        private string nome;
        private object value;

        public string? Cor { get; set; }
        public float Largura { get; set; }
        public float Altura { get; set; }
        public double Peso { get; set; }

        public Porta(string cor, float largura, float altura, double peso)
        {
            this.Cor = cor;
            this.Largura = largura;
            this.Altura = altura;
            this.Peso = peso;
        }

        public Porta(string nome, object value)
        {
            this.nome = nome;
            this.value = value;
        }

        public virtual void Abrir()
        {
            System.Console.WriteLine("Porta Aberta");
        }

        public virtual void Fechar()
        {
            System.Console.WriteLine("Porta Fechada");
        }
        
    }
}