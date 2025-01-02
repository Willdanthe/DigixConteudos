using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class PortaQuarto : Porta
    {
        //Construtor base
        public PortaQuarto(string nome, float largura, float altura, double peso) : base(nome, largura, altura, peso)
        {
            
        }
        // Subscrevendo os métodos

        public override void Abrir()
        {
            System.Console.WriteLine("Porta do quarto aberta");
        }
        
        public override void Fechar()
        {
            System.Console.WriteLine("Porta do quarto fechada");
        }
    }
}