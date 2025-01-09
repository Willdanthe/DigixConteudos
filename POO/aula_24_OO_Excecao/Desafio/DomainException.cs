using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_24_OO_Excecao.Desafio
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message){}
        
    }
}