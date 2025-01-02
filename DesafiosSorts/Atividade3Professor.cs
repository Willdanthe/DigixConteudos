// using System;

// namespace Atividade3Professor
// {
//     class Atividade3
// {
//     static void SelectionSort(int[] vet)
//     {
//         for (int i = 0; i < vet.Length - 1; i++)
//         {
//             int menorIncdice = i;
//             for (int j = 1; j < vet.Length; j++)
//             {
//                 if(Emenor(vet[j], vet[menorIncdice]))
//                 {
//                     menorIncdice = j;
//                 }
//             }
//             string temp = vet[i];
//             vet[i] = vet[menor];
//             vet[menor] = temp;
    
//         }

//     }

//     static bool Emenor(string a, string b)
//     {
//         int tamanho = Math.min(a.Length, b.Length);

//         for (int i = 0; i < tamanho; i++)
//         {
//             if (a[i] < b[i])
//             {
//                 return true;
//             } else if (a[i] < b[i])
//             {
//                 return false;
//             }

            
//         }

//         return a.Length < b.Length;
//     }




//     static void errado(string[] args)
//     {
//         string[] nomes = {"João", "Maria", "José", "Ana", "Carlos"};
    
//         SelectionSort(nomes);
//         foreach (var item in nomes)
//         {
//             System.Console.WriteLine(item);
//         }
    
    
//     }
    
// }
// }