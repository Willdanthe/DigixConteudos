using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace ExercicioMatrizRevisao.Desafio
{
    public class TEste
    {
        
        static void Main2(string[] args)
        {
            try
            {
                int[,] mat = {
                    {1,2,3},
                    {4,5,6},
                    {7,8,9}
                };



                string CaminhoArquivo = @"C:\Users\willdanthealaman\Documents\GitHub\TesteDemais\POO\ExercicioMatrizRevisao\Desafio\matriz.csv";

                using (StreamWriter wr = new StreamWriter(CaminhoArquivo))
                    for (int i = 0; i < mat.GetLength(0); i++)
                    {
                        string[] linha = new string[mat.GetLength(1)]; // Nota mental para não esquecer... Aqui está sendo declarado um vetor de linha, que tem o tamanho da coluna, para poder armazenar cada valor da coluna na linha atual
                        for (var j = 0; j < mat.GetLength(1); j++)
                        {
                            linha[j] = mat[i,j].ToString();
                        }
                        wr.WriteLine(string.Join("; ", linha));
                    }


            }
            catch (Exception e)
            {
                System.Console.WriteLine("Deu erro kkkk");
                System.Console.WriteLine(e.Message);
            }    
        }        
    }
}