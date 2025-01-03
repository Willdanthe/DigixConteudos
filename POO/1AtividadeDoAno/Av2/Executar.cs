using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1AtividadeDoAno.Av2
{
    class Executar
    {
        static void Main(string[] args)
        {
            // Setando as pessoas
            Engenheiro engenheiro = new Engenheiro("Professor Dark da Silva", "123.132.123-24", 59712); // Engenheiro do Prédio
            Pessoa dono1Residencia = new Pessoa("Zephaux Xuahphez", "123.523.674-22"); // 1 Proprietário
            Pessoa dono2Residencia = new Pessoa("yumsa Monoi", "222.323.612-45"); // 2 Proprietário
            Pessoa dono3Residencia = new Pessoa("Zoe Aspecto", "321.551.323-04"); // 3 Proprietário

            // Setando as Unidades Residênciais
            UnidadeResidencial apartamento1 = new UnidadeResidencial(80.0,3,2,dono1Residencia);
            UnidadeResidencial apartamento2 = new UnidadeResidencial(80.0,3,2,dono2Residencia);
            UnidadeResidencial apartamento3 = new UnidadeResidencial(80.0,3,2,dono3Residencia);

            // Setando o Edificio

            Predio edificio = new Predio(542.8, "Summoner Rift, 222, Moreninha 4", engenheiro, "Rito Gomes",3,1);

            edificio.CadastrarUnidade(apartamento1);
            edificio.CadastrarUnidade(apartamento2);
            edificio.CadastrarUnidade(apartamento3);

            System.Console.WriteLine(edificio.DescricaoDoImovel());



            
        }
    }
}