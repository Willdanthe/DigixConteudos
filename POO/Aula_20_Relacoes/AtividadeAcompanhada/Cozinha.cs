using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class Cozinha
    {
        // Utulizar agregação com o objeto Porta Cozinha
        // Propriedades

        public PortaCozinha? PortaCozinha {get;set;}
        public bool? Americana {get;set;}
        public float? MetragemQuadrada {get;set;}

        public Cozinha(bool americana, float metragemQuadrada)
        {
            this.Americana = americana;
            this.MetragemQuadrada = metragemQuadrada;

        }

        public void Entrar(PortaCozinha portaCozinha)
        {
            System.Console.WriteLine($"Entrando pela porta da cozinha {portaCozinha.Cor}");
        }
    }
}