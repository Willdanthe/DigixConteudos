using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace POO.aula27_ManipulacoaArquivoBinario
{
    public class Atividade
    {
        static void NotMain(string[] args)
        {
            string inicialPath = @"C:\Users\willdanthealaman\Documents\GitHub\TesteDemais\POO\aula27_ManipulacoaArquivoBinario\Atividade\produtos.csv";
            string finalPath = @"C:\Users\willdanthealaman\Documents\GitHub\TesteDemais\POO\aula27_ManipulacoaArquivoBinario\Atividade\Out\summary.csv";

            // Leitura do arquivo CSV

            using var reader = new StreamReader(inicialPath);
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var produtos = csvReader.GetRecords<Produto>().ToList();

                 // Calcula o preço total e grava no novo arquivo CSV
                using (var writer = new StreamWriter(finalPath))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteHeader<ProdutoCalculado>();
                    csvWriter.NextRecord();

                    foreach (var produto in produtos)
                    {
                        double precoTotal = produto.preco_unitario * produto.quantidade;
                        csvWriter.WriteRecord(new ProdutoCalculado{
                            nome = produto.nome,
                            total =  precoTotal
                        });

                        csvWriter.NextRecord();
                    }
                }
            }

            // Exibição do conteúdo do novo arquivo CSV
            using (var readera = new StreamReader(finalPath))
            using (var csvReader = new CsvReader(readera, CultureInfo.InvariantCulture))
            {
                var registros = csvReader.GetRecords<ProdutoCalculado>().ToList();
                foreach (var registro in registros)
                {
                    Console.WriteLine($"{registro.nome}, {registro.total:F2}");
                }
            }
        }
        public class Produto
        {
            public string nome { get; set; }
            public double preco_unitario { get; set; }
            public int quantidade { get; set; }

        }
        public class ProdutoCalculado
        {
            public string nome { get; set; }
            public double total { get; set; }
        }
    }
}