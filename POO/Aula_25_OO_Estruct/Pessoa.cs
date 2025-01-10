using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_25_OO_Estruct
{
    public struct PessoaStruct
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public PessoaStruct(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} \nIdade: {Idade}";
        }


    }

    public class PessoaClasse
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public PessoaClasse(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} \nIdade: {Idade}";
        }
    }

    public class Executar
    {
        public static void Exemplo1(string[] args)
        {
            // Trabalhar com Struc Pessoa
            PessoaStruct pessoaStruct1 = new PessoaStruct("João", 20);
            PessoaStruct pessoaStruct2 = pessoaStruct1;
            pessoaStruct2.Nome = "Maria";

            // Struct é um valor, por isso ao alterar os nomes ficam diferenciados
            System.Console.WriteLine(pessoaStruct1);
            System.Console.WriteLine(pessoaStruct2);

            // Trabalhar com Class Pessoa
            PessoaClasse PessoaClasse1 = new PessoaClasse("João", 20);
            PessoaClasse PessoaClasse2 = PessoaClasse1;
            PessoaClasse2.Nome = "Roger";

            // Classe é uma referencia por isso a pessoa 1 e 2 ficaram como Roger
            System.Console.WriteLine(PessoaClasse1);
            System.Console.WriteLine(PessoaClasse2);

            // 1. Struct é um tipo de valor, então atribuições   criam copias independentes

            // 2. Classe é um tipo de referência, então atribuições criam referências para o mesmo objeto 
            
            // 3. Struct são mais leves e geralmente são usados para simples e imutaveis
            
            // 4. Classes são mais adequadas para objetos com estados mutaveis e comprotamentos 
            
        }
    }
}