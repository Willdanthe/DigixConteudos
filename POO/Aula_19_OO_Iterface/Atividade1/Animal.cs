using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_19_OO_Iterface
{
    public abstract class Animal
    {
            protected int Pernas;

            public Animal(){}

            public Animal(int pernas)
            {
                this.Pernas = pernas;
            }
            
            public void Caminha(){}

            public abstract void Come();
            // public virtual void Come(){}
    }
}