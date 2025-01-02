<<<<<<< HEAD
    using System;
    using System.Dynamic;

    namespace Atividade3
    {
        class Atividade3
        {
            static void Ex3(string[] args)
            {
                int[] vet = new int[] {1,2,2,1};
                int[] vetInverso = new int[vet.Length];
                int contador = 0;
                bool palindromo = false;
                for (int i = vet.Length-1; i >= 0; i--)
                {
                    vetInverso[contador] = vet[i];
                    contador++;
                }
                
                for (int i = 0; i < vet.Length; i++){
                    if (vet[i] != vetInverso[i]){
                        break;
                    }
                    System.Console.WriteLine("Palindromo");
                }

                for(int i = 0; i < vet.Length; i++)
                {
                    if (vet[i] == vetInverso[i]){
                        palindromo = true;
                    } else{
                        palindromo = false;
                        break;
                    }
                }

                System.Console.WriteLine(string.Join(" ", vet));
                System.Console.WriteLine(string.Join(" ", vetInverso));


                if (palindromo){
                    System.Console.WriteLine("Temos um palíndromo!");
                } else
                {
                    System.Console.WriteLine("Não temos um palíndromo!");
                }
                


                

            }
        }
=======
    using System;
    using System.Dynamic;

    namespace Atividade3
    {
        class Atividade3
        {
            static void Ex3(string[] args)
            {
                int[] vet = new int[] {1,2,2,1};
                int[] vetInverso = new int[vet.Length];
                int contador = 0;
                bool palindromo = false;
                for (int i = vet.Length-1; i >= 0; i--)
                {
                    vetInverso[contador] = vet[i];
                    contador++;
                }
                
                for (int i = 0; i < vet.Length; i++){
                    if (vet[i] != vetInverso[i]){
                        break;
                    }
                    System.Console.WriteLine("Palindromo");
                }

                for(int i = 0; i < vet.Length; i++)
                {
                    if (vet[i] == vetInverso[i]){
                        palindromo = true;
                    } else{
                        palindromo = false;
                        break;
                    }
                }

                System.Console.WriteLine(string.Join(" ", vet));
                System.Console.WriteLine(string.Join(" ", vetInverso));


                if (palindromo){
                    System.Console.WriteLine("Temos um palíndromo!");
                } else
                {
                    System.Console.WriteLine("Não temos um palíndromo!");
                }
                


                

            }
        }
>>>>>>> 7c9a559e149af5d97a41afb24b17a8d425a038a0
    }