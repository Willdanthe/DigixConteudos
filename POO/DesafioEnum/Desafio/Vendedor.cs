using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioEnum.Desafio
{
    public class Vendedor : Empregado
    {
        public Double Comissao { get; set; }

        public Vendedor(string nome, double salario) : base(nome,salario) {}

        public double GetSalario()
        {
            return this.Salario; // Propriedade do Empregado
        }
        
        
    }
}