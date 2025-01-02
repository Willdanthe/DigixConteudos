using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class Quarto
    {
        // Utulizar agregação com o objeto Porta Cozinha
        // Propriedades

        public PortaQuarto PortaQuarto {get;set;}
        public bool Banheiro {get;set;}
        public float MetragemQuadrada {get;set;}

        public Quarto(bool americana, float metragemQuadrada)
        {
            this.Banheiro = Banheiro;
            this.MetragemQuadrada = metragemQuadrada;
            this.PortaQuarto = new PortaQuarto("Branca",0.8f,2.0f,15.8);
        }
    }
}