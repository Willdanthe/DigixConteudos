// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_28_Manipulacao
// {
//     public class ClasseTask
//     {
//         static Task<int> Soma(int a,int b)
//         {
//             return Task.Run( () => {
//                 Task.Delay(2000).Wait(); // Espera 2 segundos
//                 return a + b;
//             }
//             );
//         }
//         static async Task Main(string[] args)
//         {
//              // O assync é quando função é assíncrona, ou seja
//              // ela n]ao é executada de forma que o não trava o programa
//              // enquanto espera o retorno.

//              System.Console.WriteLine("Inicio do programa");
//              int resultado = await Soma(10,20); // await é para esperar o retorno da função
//              System.Console.WriteLine("Resultado: " + resultado);

//         }
//     }
// }