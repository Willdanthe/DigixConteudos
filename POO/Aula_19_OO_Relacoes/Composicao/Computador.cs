using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Relacoes.Composicao
{
    public class Computador
    {
        public Processador processador;

        public Computador()
        {
            processador = new Processador();
        }

        void iniciar()
        {
            System.Console.WriteLine("Ligando...");
            processador.Processar();
        }

    }
    // Composição é quando uma classe principal contém partes
    // essenciais que não podem existir sem ela
}