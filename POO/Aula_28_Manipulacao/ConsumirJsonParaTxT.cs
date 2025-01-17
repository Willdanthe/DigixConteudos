using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
// using System.Net.Http.HttpResponseMessage;
// using System.Buffers.ReadOnlySequence<>;
namespace Aula_28_Manipulacao
{
    public class ConsumirJsonParaTxT
    {
        static async Task Main(string[] args)
        {
            // Url do arquivo Json
            string url = "https://raw.githubusercontent.com/manami-project/anime-offline-database/master/anime-offline-database-minified.json";

            // Nome do arquivo txt de saída
            string nomeArquivo = "animes.txt";

            try
            {
                // HttpClient é uma classe que permite fazer requisições HTTP
                using (HttpClient cliente = new HttpClient())
                {
                    // Faz requisição get para obter o Json
                    var response = await cliente.GetAsync(url);

                    // Le o conteudo da resposta para string
                    var responseString = await response.Content.ReadAsStringAsync();

                    // Deixar o conteúdo em estrutura dinâmica que é o JArray
                    using (JsonDocument document = JsonDocument.Parse(responseString))
                    {
                        var myAnimeList = document.RootElement.GetProperty("data");

                        // FUnção que grava todas as informações do Json e salva em um arquivo
                        SalvarEmTxt(myAnimeList, nomeArquivo);
                    }

                    System.Console.WriteLine("Informações salvas com sucesso!");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Erro:" + e.Message);
            }
        }

        static void SalvarEmTxt(JsonElement animeList, string nomeArquivo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(nomeArquivo))
                {
                    foreach (var anime in animeList.EnumerateArray())
                    {
                        string tittle = anime.GetProperty("tittle").GetString() ?? "sem titulo"; // os "??" são um "Caso não aconteça, devolva isto"

                        string type = anime.GetProperty("type").GetString() ?? "sem tipo";

                        // string episodes = anime.GetProperty("episodes").GetString() ?? "sem episodio";

                        string status = anime.GetProperty("status").GetString() ?? "sem Status";


                        // Escrever a temporada do anime
                        string season = "n/a";
                        int year = 0;

                        // if (anime.TryGetProperty("animeSeason", out JsonElement animeSeason)) // out é a forma de acessar as propriedades de animeSeason
                        // {
                        //     season = animeSeason.GetProperty("season").GetString() ?? "N/A";
                        // }

                        writer.WriteLine($"Título: {tittle}");
                        writer.WriteLine($"Tipo: {type}");
                        // writer.WriteLine($"Episódio: {episodes}");
                        writer.WriteLine($"Status: {status}");
                    }

                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Erro:" + e.Message);

            }
        }


    }
}