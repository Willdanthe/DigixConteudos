using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_24_OO_Excecao
{
    public class Executar
    {
        static void Teste(string[] args)
        {
            // int n1 = 10;
            // int n2 = 0;
            
            // int resultado = n1 / n2;
            // System.Console.WriteLine(resultado);

            try
            {                
                int n1 = 10;
                int n2 = 0;
                
                int resultado = n1 / n2;
                System.Console.WriteLine(resultado);
         
            }
            catch (Exception ex)
            {
                
                System.Console.WriteLine("Error: " + ex.Message);

                System.Console.WriteLine("Erro: Não pode divifir algum número por 0");
            }
        }
    }
}