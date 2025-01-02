using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class Sala
    {
        // Compsição de entrada da porta da sala
        public PortaSala PortaSala {get;set;}
        public Porta PortaAuxiliar {get;set;}
        public float MetragemQuadrada {get;set;}

        public Sala (PortaSala portasala, Porta portaAulxiliar, float metragemQuadrada)
        {
            PortaAuxiliar = portaAulxiliar;
            MetragemQuadrada = metragemQuadrada;
            PortaSala = new PortaSala(PortaSala.Cor, PortaSala.Largura, PortaSala.Altura, PortaSala.Peso);
        }
        public void AbrirPortaAuxiliar()
        {
            PortaAuxiliar.Abrir();
        }

        
    }
}