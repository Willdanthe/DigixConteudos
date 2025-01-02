using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno
{
    public abstract class Animal
    {
        private string Reino {get;}
        private string Filo {get;}
        private string Classe{get;}
        private string Ordem {get;}
        private string Familia {get;}
        private string Genero {get;}
        private string Especie {get;}

        public Animal(string reino, string filo, string classe, string ordem, string familia, string genero, string especie)
        { 
            this.Reino = reino;
            this.Filo = filo;
            this.Classe = classe;
            this.Ordem = ordem;
            this.Familia = familia;
            this.Genero = genero;
            this.Especie = especie;
        }

        public void ObterDescrição()
        {
            Console.WriteLine(@$"
            Reino: {Reino}
            Filo: {Filo}
            Classe: {Classe}
            Ordem: {Ordem}
            Familia: {Familia}
            Genero: {Genero}
            Especie: {Especie}
            ");
            
        }
    }
}