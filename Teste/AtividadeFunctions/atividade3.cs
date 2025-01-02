using System;
using System.Reflection.Metadata;

namespace Name
{
    public class Atividade3
    {

        static bool Palindromo(int[] a, int[] b){
            bool controle = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]){
                    controle = false;
                    break;
                }else {
                controle = true;
                }
            }
            return controle;
        }
            
            
        static void Ex3(string[] args)
        {
            int[] vet = [1,2,3,2,1];
            int[] vetInverso = vet.Reverse().ToArray();
            bool controle = Palindromo(vet,vetInverso);

            if (controle){
                System.Console.WriteLine("palindromo!");
            } else{
                System.Console.WriteLine("Não Palíndrmo");
            }
            
        }


    }
}