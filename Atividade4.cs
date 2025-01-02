using System;


public class HelloWorld
{
    public static void Main(string[] args)
    {
// 4. Ler uma matriz 4 x 4 e calcular a soma dos elementos da diagonal
// principal.
        Random r = new Random(); // Importando função Random
        int[,] mat = new int[4,4];
        int somaDiagonal = 0;
        
        for (int i = 0; i < 4; i++) // Adicionando numeros na matriz
        {
            for (int j = 0; j < 4; j++)
                mat[i,j] = r.Next(10);
        }
        
        // for para checar se a matriz está correta
        for (int i = 0; i < 4; i++) 
        {
            for (int j = 0; j < 4; j++){
                
                Console.Write($"{mat[i,j]}     ");
        }
        Console.WriteLine("");
        }
        
        // Somando as diagonais
        for (int i = 0; i<4;i++){
            somaDiagonal += mat[i,i];
        }
        
        Console.WriteLine($"\nSoma da diagonal principal: {somaDiagonal}");
        
    }
}