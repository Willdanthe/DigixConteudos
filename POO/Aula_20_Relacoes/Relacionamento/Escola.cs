using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class Escola
    {
        private Aluno estudante;
        private Professor professor;
    
        // COMPOSIÇÂO
        public Escola (string nomeEstudante)
        {
            estudante = new Aluno(nomeEstudante);
        }

        // AGREGAÇÂO
        public void ContratarProfessor(Professor professor)
        {
            this.professor = professor;
        }

        public void MostarInfo()
        {
            Console.WriteLine($"Nome do Aluno: {estudante.Nome}");
            Console.WriteLine($"Nome do Professor: {professor.Nome}");
            professor.Ensinar();
            
        }
    }
    


}