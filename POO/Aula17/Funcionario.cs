using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula17
{
    public class Funcionario
    {
        public string Nome;
        private double Salario;
        protected string Cargo;

        public Funcionario(string nome, double salario, string cargo)
        {
            this.Nome = nome;
            this.Salario = salario;
            this.Cargo = cargo;
        }

        // Método publico: Acessível de qualquer lugar
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            // Console.WriteLine($"Salario: {Salario}");
            Console.WriteLine($"Cargo: {Cargo}");
        }

        // Metodos protegidos: acessíveis apenas dentro da classe e suas subclasses
        protected void AtualizarCargo(string novoCargo)
        {
            this.Cargo = novoCargo;
            Console.WriteLine($"Cargo atualizado para: {this.Cargo}");
            
        }

        // Método privado: acessível apenas dentro da classe
        private double CalcularImposto()
        {
            return Salario * 0.1;
        }




    }
}