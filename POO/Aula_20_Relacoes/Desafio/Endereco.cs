using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_20_Relacoes
{
    public class Endereco
    {
        public string __rua {get;set;}
        public int __numero {get;set;}
        public string __bairro {get;set;}
        public string __cep {get;set;}
        public Cidade __cidade;

        public Endereco(string rua, int numero, string bairro, string cep, Cidade cidade)
        {
            __rua = rua;
            __numero = numero;
            __bairro = bairro;
            __cep = cep;
            __cidade = cidade;
        }

    }
}