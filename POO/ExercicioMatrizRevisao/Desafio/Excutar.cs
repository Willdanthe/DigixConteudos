using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace ExercicioMatrizRevisao.Desafio
{
    public class Excutar
    {

        static void Main(string[] args)
        {
            OperadorMatriz opmat = new OperadorMatriz();

            System.Console.WriteLine("=-=-==-=-=Matriz=-=-==-=-=");
            System.Console.Write("Linhas: ");
            int rows = Convert.ToInt32(Console.ReadLine()); 
            System.Console.Write("Colunas:");
            int columns = Convert.ToInt32(Console.ReadLine());
            
            int[,] mat = new int[rows,columns];

            opmat.PovoarMatriz(mat);

            opmat.PrintMatriz(mat);

            System.Console.WriteLine("Selecione uma opção:");
            System.Console.WriteLine("[1] - Soma de Cada Linha");
            System.Console.WriteLine("[2] - Soma de Cada Coluna");
            System.Console.WriteLine("[3] - Transpor Matriz (Linhas por coluna)");

            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    opmat.SomarLinhasMatriz(mat);
                    break;
                case 2:
                    opmat.SomarColunasMatriz(mat);
                    break;
                case 3:
                    opmat.TransporMatriz(mat, rows, columns);
                    break;
            }


            
            
        }
    }
}