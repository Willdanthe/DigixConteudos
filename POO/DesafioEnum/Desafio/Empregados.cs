using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEnum.Desafio
{
    public class Empregados
    {
        public int NumeroMaximo { get; set; } = 50;
        public int NumeroEmpregados { get; set; }
        public List<Empregado> ListaEmpregados { get; set; } = new List<Empregado>();
        
        public Empregados(){}

        public void AddEmpregado(Empregado empregado)
        {
            if (NumeroEmpregados <= NumeroMaximo)
            {
                ListaEmpregados.Add(empregado);
                this.NumeroEmpregados++;
            }
            else
            {
                System.Console.WriteLine("Capacidade máximade funcionários alcançada!");
            }
        }

        public void RemEmpregado(Empregado empregado)
        {
            if (NumeroEmpregados > 0)
            {
                ListaEmpregados.Add(empregado);
                this.NumeroEmpregados++;
            }
            else
            {
                System.Console.WriteLine("Lista de Funcionário Vazia!");
            }
        }

        public void ConsultarFuncionario(string nome)
        {
            var funcionariocache = ListaEmpregados.Find(emp => emp.Nome == nome);
            System.Console.WriteLine("Procurando: " + nome);
            Console.WriteLine("...\n");
            
            if (funcionariocache != null)
            {
                System.Console.WriteLine("Dados do funcionario:");
                System.Console.WriteLine($"Nome: {funcionariocache.Nome} \nSalário: R${funcionariocache.Salario:F2}\n");
            } else
            {
                System.Console.WriteLine("Funcionário não encontrado\n");
            }
        }
        public void ImprimirFuncionarios()
        {
            foreach (var funcionario in ListaEmpregados)
            {
                System.Console.WriteLine($"Nome: {funcionario.Nome} \nSalário: R${funcionario.Salario}\n");
                if (funcionario.Regia)
            }
        }
        
        public double FolhaDePagamento()
        {
            return 0;
        }

        
        
    }
}