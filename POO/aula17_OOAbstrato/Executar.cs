using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula17_OOAbstrato
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Não pode instanciar uma classe abastrata, no caso "Forma"
            // Forma forma = new Forma("Quadrado");

             Circulo circulo = new Circulo("Circulo",5);
             circulo.ImprimirDados();

             Retangulo retangulo = new Retangulo("Retângulo",10,12);
             retangulo.ImprimirDados();
        }
    }
}