using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Aula_20_Relacoes
{
    public class Exec
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Herança");
            // PortaCozinha portaCozinha = new PortaCozinha("Branca", 1.5f,2.5f,10);
            // portaCozinha.Abrir();
            // portaCozinha.Fechar();
            // System.Console.WriteLine($"Cor: {portaCozinha.Cor}\nLargura: {portaCozinha.Largura}\nAltura: {portaCozinha.Altura}\nPeso: {portaCozinha.Peso}");
            
            // System.Console.WriteLine();
            // //Agregação
            // System.Console.WriteLine("Agregação");
            // Cozinha cozinha = new Cozinha(true, 20);
            // cozinha.Entrar(portaCozinha);
            
            
            // System.Console.WriteLine();
            // //Composição
            // System.Console.WriteLine("Composição");
            // PortaQuarto portaQuarto = new PortaQuarto("Dourada",122.5f,222.5f,210);
            // Quarto quarto = new Quarto(true, 20);
            // System.Console.WriteLine($"Cor: {portaQuarto.Cor}\nLargura: {portaQuarto.Largura}\nAltura: {portaQuarto.Altura}\nPeso: {portaQuarto.Peso}");
            // // System.Console.WriteLine($"Quarto: {quarto.PortaQuarto.Cor}");

            // Console.WriteLine("");
            // //Associação Simples
            // System.Console.WriteLine("Associação Simples");
            // PortaSala portaSala = new PortaSala("Prata",2.4f,5.5f,22.5);
            // Sala sala = new Sala(portaSala, portaQuarto, 20);
            // sala.AbrirPortaAuxiliar();
        
            //Estado
            Estado estado = new Estado("Mato Grosso do SUl","MS");
            Cidade cidade = new Cidade("Campo Grande", estado);
            Endereco endereco = new Endereco("Rua Bilutetéia", 1010,"Bauneario","564456-123", cidade);
            EquipeVenda equipe = new EquipeVenda("AlphaBetta");
            Gerente gerente = new Gerente("Uiuidanthê", DateTime.Parse("2004/08/24"), "123.564.789-78", endereco);

            System.Console.WriteLine();
            Console.WriteLine($"Gerente");
            Console.WriteLine($"Nome: {gerente.Nome} | CPF: {gerente.CPF}| Data de Nascimento: {gerente.Nascimento}");
            Console.WriteLine($"Endereço: {gerente.__endereco.__rua}, {gerente.__endereco.__numero}, {gerente.__endereco.__bairro} | CEP: {gerente.__endereco.__cep}");
            Console.WriteLine($"Estado: {gerente.__endereco.__cidade.__estado.Nome} - {gerente.__endereco.__cidade.__estado.Sigla}");
            Console.WriteLine($"Cidade: {gerente.__endereco.__cidade.Nome}");
            System.Console.WriteLine();

            gerente.GetSalario(gerente.Nome);
            
            
            
                      
            

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }

    }
}