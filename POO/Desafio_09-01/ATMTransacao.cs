using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Desafio_09_01
{
    public class ATMTransacao
    {
        private readonly string IdTransacao;
        public readonly DateTime Data;

        public EnumTipoTransacao Tipo { get; set; }

        public double Quantia { get; }
        public double SaldoConta { get; } // Saldo Restante da Conta
        public Conta ContaRemetente {get;set;}
        public Conta ContaDestinataria {get;set;}

        public ATMTransacao(EnumTipoTransacao tipo, double quantia, Conta contaRemetente, Conta contaDestinataria)
        {
            this.IdTransacao = Guid.NewGuid().ToString();
            this.Data = DateTime.Now;
            this.Tipo = tipo;
            this.Quantia = quantia;
            this.SaldoConta = contaRemetente.Saldo; // Provavelmente vai ter que alterar para não mostrar errado
            this.ContaDestinataria = contaDestinataria;
            this.ContaRemetente = contaRemetente;
        }

        public void Modificar()
        {
            //WIP
        }

        public override string ToString()
        {
            return @$"

=-=-==-=-=-=Comprovante=-=-=-=-=-=-==-=
Protocolo: {this.IdTransacao}
Data: {this.Data} 
Transação: {this.Tipo} 
Valor: {this.Quantia} 
Saldo Atual: {this.ContaDestinataria.Saldo} 
Remetente: {this.ContaDestinataria.Usuario.Nome} 
Destinatario: {this.ContaRemetente.Usuario.Nome}
=-=-==-=-=-=Comprovante=-=-=-=-=-=-==-=

";
        }

        
        
    }
}