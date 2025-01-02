using System;

namespace seila;

public class VarImplicit
{
    static void Teste(string[] args)
    {
        // variavel var convert a variável para o seu tipo
        // var nome = "Willdanthê";
        // System.Console.WriteLine(nome);
        // System.Console.WriteLine(nome.GetType());
        
        
        // var idade = 10;
        // System.Console.WriteLine(idade);
        // System.Console.WriteLine(nome.GetType());

        // var altura = 2.2;
        // System.Console.WriteLine(altura);
        // System.Console.WriteLine(altura.GetType());
        

        // Quando uma variável é const ela não muda seu valor, pós estabelecido
        // const double gravidade = 9.807;
        // System.Console.WriteLine(gravidade);
        // System.Console.WriteLine(gravidade.GetType());

        // var lista = new List<int> {1,2,3,4,5};
        // System.Console.WriteLine(lista.GetType());
        // foreach (var item in lista)
        // {
        //     System.Console.WriteLine(item);
        // }

        var dicionario = new Dictionary<string, int>
        {
            {"C#",1},
            {"Java",2},
            {"Python",3}
        };


        foreach (var item in dicionario) // Retorna cada chave e valor em []
        {
            System.Console.WriteLine(item);
        }
    }
}