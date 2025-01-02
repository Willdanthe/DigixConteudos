using System;


public class HelloWorld
{
    public static void Main(string[] args)
    {
// 3. Ler uma matriz 4 x 4 e calcular a soma do maior com o menor elemento
// da matriz.
        Random r = new Random(); // Importando função Random
        int[,] mat = new int[4,4];
        int maior = int.MinValue;
        int menor = int.MaxValue;
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
        
        for (int c = 0; c < 4;c++)
        {
            for (int d = 0; d < 4; d++)
            {
                if (mat[c,d] > maior)
                {
                    maior = mat[c,d];
                }
                if (mat[c,d] < menor)
                {
                    menor = mat[c,d];
                }
            }
        }
        
        Console.WriteLine($"\nO maior número da matriz é {maior} e o menor é {menor}. \nSoma ={maior+menor}");
        
    }
}