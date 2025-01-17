using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace ExercicioMatrizRevisao.Desafio
{
    public class OperadorMatriz
    {
        static public int RandomMatrizNumber()
        {
            Random r = new Random();
            return r.Next(0, 10);
        }

        public void PovoarMatriz(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = RandomMatrizNumber();
                }
            }
        }

        public void SomarLinhasMatriz(int[,] mat)
        {
            string CaminhoArquivo = @"C:\Users\willdanthealaman\Documents\GitHub\TesteDemais\POO\ExercicioMatrizRevisao\Desafio\SomaLinhasMatriz.csv";
            int linha;
            int linhas = 0;
            try
            {
                // Abrindo arquivo
                using (StreamWriter wr = new StreamWriter(CaminhoArquivo))
                {
                    // Colocando a Matriz original no arquivo
                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        for (int j = 0; j < mat.GetLength(1); j++)
                        {
                            wr.Write($"{mat[i, j]}; ");
                        }
                        wr.WriteLine(" ");
                    }
                    {
                        for (int i = 0; i < mat.GetLength(0); i++)
                        {
                            linha = 0;
                            for (int j = 0; j < mat.GetLength(1); j++)
                            {
                                linha += mat[i, j];
                                linhas += mat[i, j];

                            }
                            wr.WriteLine($"Soma da coluna {i + 1}; {linha}");

                        }
                        wr.WriteLine($"Soma Total ; {linhas}");
                    }
                }
                // Fechando arquivo

                System.Console.WriteLine("Criando Aqruivo CSV...");
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Erro: " + e.Message);
            }


        }

        public void SomarColunasMatriz(int[,] mat)
        {
            try
            {
                int coluna;
                int colunas = 0;
                string CaminhoArquivo = @"C:\Users\willdanthealaman\Documents\GitHub\TesteDemais\POO\ExercicioMatrizRevisao\Desafio\SomaColunasMatriz.csv";

                using (StreamWriter wr = new StreamWriter(CaminhoArquivo))
                {
                    // Colocando a Matriz original no arquivo
                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        for (int j = 0; j < mat.GetLength(1); j++)
                        {
                            wr.Write($"{mat[i, j]}; ");
                        }
                        wr.WriteLine(" ");
                    }

                    for (int i = 0; i < mat.GetLength(1); i++)
                    {
                        coluna = 0;
                        for (int j = 0; j < mat.GetLength(0); j++)
                        {
                            coluna += mat[j, i];
                            colunas += mat[j, i];
                        }
                        wr.WriteLine($"Soma da coluna {i + 1}; {coluna}");
                    }
                    wr.WriteLine($"Soma Total ; {colunas}");
                }
                System.Console.WriteLine("Criando Arquivo soma CSV...");

            }
            catch (Exception e)
            {
                System.Console.WriteLine("Erro: " + e.Message);
            }
        }

        public void TransporMatriz(int[,] mat, int linha, int coluna)
        {
            int[,] mat2 = new int[linha, coluna];

            for (int i = 0; i < mat.GetLength(1); i++)
            {
                for (int j = 0; j < mat.GetLength(0); j++)
                {
                    mat2[j, i] = mat[i, j];

                }
            }

            string CaminhoArquivo = @"C:\Users\willdanthealaman\Documents\GitHub\TesteDemais\POO\ExercicioMatrizRevisao\Desafio\matrizTransposta.csv";

            using (StreamWriter wr = new StreamWriter(CaminhoArquivo))
            {
                // Colocando a Matriz original no arquivo
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {
                        wr.Write($"{mat[i, j]}; ");
                    }
                    wr.WriteLine(" ");
                }

                // Colocando a matriz transposta
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    string[] linhaLista = new string[mat.GetLength(1)]; // Nota mental para não esquecer... Aqui está sendo declarado um vetor de linha, que tem o tamanho da coluna, para poder armazenar cada valor da coluna na linha atual
                    for (var j = 0; j < mat.GetLength(1); j++)
                    {
                        linhaLista[j] = mat2[i, j].ToString(); 
                    }
                    wr.WriteLine(string.Join("; ", linhaLista)); // Join, pega todo o array e converte em string, separado pelo parâmetro definido
                }

                System.Console.WriteLine("Criando Aqruivo CSV...");
            }
        }

        public void PrintMatriz(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    System.Console.Write($"{mat[i, j]} ");
                }
                System.Console.WriteLine();
            }
        }
    }
}