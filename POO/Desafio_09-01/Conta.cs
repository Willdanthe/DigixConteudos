using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio_09_01.Enum;

namespace Desafio_09_01
{
    public class Conta
    {
        public int IdConta { get; set; }
        public Usuario Usuario {get;set;}
        public double Saldo {get;}

        private readonly EnumTipoConta TipoConta;

        public List<ATMTransacao> Transacoes {get;set;}

        public Conta(Usuario usuario)
        {}

        
        
    }
}