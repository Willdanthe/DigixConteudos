using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17
{
    public class Gerente : Funcionario
    {
        public Gerente (string nome, double salario) : base(nome, salario, "Gerente"){}

        // Chamar método público da classe pai
        public void Imprimir()
        {
            ExibirInformacoes();
        }

        // Chamar metodo protegido da classe base
        public void AtualizarCargoGerente(string novoCargo)
        {
            AtualizarCargo(novoCargo);
        }

        // CW comentado pois o método é privado, então da erro de proteção
        public void CalcularImpostoGerente()
        {
            // System.Console.WriteLine(CalcularImposto());
        }
    }
}