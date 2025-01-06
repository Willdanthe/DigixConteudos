// namespace Aula_22_OO
// {
//     public enum Estado
//     {
//         SP,
//         RJ,
//         MG,
//         BA,
//     }

//     public class ExtencaoEstado
//     {
//         public static string GetDescricao(Estado estado)
//         {
//             switch (estado)
//             {
//                 case Estado.SP:
//                     return "São Paulo";
//                 case Estado.RJ:
//                     return "Rio De Janeiro";
//                 case Estado.MG:
//                     return "Minas Gerais";
//                 case Estado.BA:
//                     return "Bahia";
//                 default:
//                     return "Estado não encontrado ou não atualizado ainda";
//             }
            
//         }
//     }


//     public class Regiao
//     {
//         public string[] Regioes = new string[] 
//         {
//             "Sul",
//             "Sudeste",
//             "Centro-Oeste",
//             "Norte",
//             "Nordeste"
//         };

//         public string GetRegiao(Estado estado)
//         {

//             int opcao = 2;

//             string sea = opcao switch {
//                 1 => "aa",
//                 _ => "bb",
//             };

//             return estado switch
//             { // é possivel fazer um switch dentro de um return
//                 Estado.SP => Regioes[1],
//                 Estado.RJ => Regioes[1],
//                 Estado.MG => Regioes[1],
//                 Estado.BA => Regioes[4],
//                 _ => "Região não encontrada!",
//             };
//         }
//     }
// }