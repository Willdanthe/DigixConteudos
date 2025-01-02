using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class PortaSala : Porta
    {
        public PortaSala(string nome, float largura, float altura, double peso) : base(nome, largura, altura, peso)
        {
            
        }


        public override void Abrir()
        {
            System.Console.WriteLine("Porta da sala aberta");
        }
        
        public override void Fechar()
        {
            System.Console.WriteLine("Porta da sala fechada");
        }
    }
}