using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17
{
    public class Executar
    {
        static void Main(string[] args)
        {
            // Instanciar o objeto funcionario

            Funcionario funcionario = new Funcionario("João",3500,"Analista");

            Console.WriteLine($"Funcionário: {funcionario.Nome}");
            funcionario.Nome = "Jubileu";
            Console.WriteLine($"Funcionário: {funcionario.Nome}");
            

            Gerente gerente = new Gerente("Roberta", 8456.55);

            Console.WriteLine($"Gerente: {gerente.Nome}");
            gerente.Nome = "RauzinPVP";
            Console.WriteLine($"Gerente: {gerente.Nome}");
            gerente.AtualizarCargoGerente("Cliente");


            
            
            
        }
    }
}