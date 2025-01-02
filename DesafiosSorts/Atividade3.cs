// using System;

// namespace Atividade3
// {
//     class Atividade3
// {
//     static void BubbleSort(int[] vet)
//     {
//         int aux;
//         for(int i = 0; i < vet.Length-1;i++)
//         {
//             for(int k = 0; k < vet.Length-1;k++)
//             {
//                 if (vet[k] > vet[k+1])
//                 {
//                     aux = vet[k+1];
//                     vet[k+1] = vet[k];
//                     vet[k] = aux;
//                 }
//             }
//         }
//     }

//     static void ValoresVetor(string[] vet)
//     {
        
//         for(int i = 0; i < vet.Length;i++)
//         {
//             System.Console.Write($"Digite o valor do vetor {i+1}: ");
//             vet[i] = Console.ReadLine();
//         }
//     }



    
//         static void Ex3(string[] args)
//         {
//             string[] vetor = new string[7];

//             ValoresVetor(vetor);

//             int menor;
//             string aux;
            
//             for (int i = 0; i < vetor.Length; i++){
//                 menor = i;
                
//                 for (int j = i+1; j < vetor.Length; j++)
//                 {
//                     if (vetor[j][0] < vetor[menor][0]) 
//                     }
//                         menor = j;
//                     }
//                     aux = vetor[i];
//                     vetor[i] = vetor[menor];
//                     vetor[menor] = aux;
//                 }

                
//             }


//             System.Console.WriteLine(string.Join(" ", vetor));
//         }
    
// }
// }