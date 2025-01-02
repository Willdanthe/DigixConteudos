using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeDeRelações.Biblioteca
{
    public class Usuarios
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Usuarios(string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }
        
        
        
    }
}