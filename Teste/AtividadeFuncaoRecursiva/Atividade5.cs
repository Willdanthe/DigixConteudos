 using System;

 namespace Atividade
 {
    class Atividade5
    {

        static int Soma(int[] n, int a){
            if (a < 0){
                return 0;
            } else
            {
                return n[a] + Soma(n, a-1);
            }
        }


        static void Ex5(string[] args)
        {
            int[] n = {1,2,3,4}; 
            int a = (n.Length)-1;
            System.Console.WriteLine($"A somaé {Soma(n,a)}");        
    
        }
    }
 }