using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_23_OO_Selo
{
    public class Executar
    {
        // Instrutor instrutor = new Instrutor();

        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            f.Salario(2000);
            f.Trabalhar();

            Coordenador C = new Coordenador();
            C.Salario(2000);
            C.Trabalhar();

            Instrutor i = new Instrutor();
            i.Salario(2000);
            i.Trabalhar(); // Podemos até chamar a função por ser herdado da classe Coordenador,
            // Mas não podemos alterar.

            Gerente g = new Gerente();
            g.Salario(2000);
            g.Trabalhar();


            
        }
    }
}