using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEnum.Desafio
{
    public class Empregado : Pessoa
    {
        public double Salario { get; set; }
        public double SalarioMin{ get; set; } = 240.0;
        public int LicencaPremioRecebido { get; set; } = 0;

        public Empregado(string nome, double salario) : base(nome)
        {
            this.Salario = salario;
        }
        
    }
}