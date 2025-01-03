using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProfessor
{
    // Classe Pai
    public abstract class Cliente
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone {get;set;}
        public string CPF { get; set; }

        // Para ocorrer composição o Endereço deve ser Instanciado no Construtor


        // Aqui se iniciar o cliente vazio, ele instancia um endereço, pra lá no Executar instanciar o objeto vazio e aí sim povoar ele com SET
        public Cliente()
        {
            this.Endereco = new Endereco();
        }

        public Cliente(string nome, string rua, string cidade, string estado, int cep, string telefone, string cpf)
        {
            Nome = nome;
            Endereco = new Endereco();
            Telefone = telefone;
            CPF = cpf;
        }
        public abstract string ConsultarFidelidade();
    }

    public class ClienteGold: Cliente
    {
        public double Desconto { get; set; }
        
        
        public override string ConsultarFidelidade()
        {
            return "Cliente Gold, tem o desconto de 5%";
        }
    }
    public class ClientePremium : Cliente
    {
        public double Desconto { get; set; }
        public override string ConsultarFidelidade()
        {
            return "Cliente Premium, tem o desconto de 10%";
        }
    }
}